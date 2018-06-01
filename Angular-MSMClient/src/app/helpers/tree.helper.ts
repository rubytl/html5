var priorities = [];
var siteGroups = [];
var mappedArr;
var tree;
priorities.splice(0, 0, { Description: "All", Value: "0" });
siteGroups.splice(0, 0, { Description: "", id: -1 });
export function listToTree(arr) {
    tree = [];
    mappedArr = {};
    var arrElem, mappedElem;

    if (arr === null || arr.length == 0) {
        return tree;
    }

    // First map the nodes of the array to an object -> create a hash table.
    for (var i = 0, len = arr.length; i < len; i++) {
        arrElem = arr[i];
        if (arrElem.sitePriority && priorities.findIndex(p => p.Description === arrElem.sitePriority.toString()) < 0) {
            priorities.push({ Description: arrElem.sitePriority.toString(), Value: arrElem.sitePriority });
        }

        if ((arrElem.address === null || arrElem.address === "")
            && siteGroups.findIndex(s => s.id === arrElem.id) < 0) {
            siteGroups.push(arrElem);
        }

        mappedArr[arrElem.id] = arrElem;
        mappedArr[arrElem.id]['children'] = [];
    }

    for (var id in mappedArr) {
        if (mappedArr.hasOwnProperty(id)) {
            mappedElem = mappedArr[id];
            // If the element is not at the root level, add it to its parent array of children.
            if (mappedElem.parentId) {
                mappedArr[mappedElem.parentId]['children'].push(mappedElem);
            }
            // If the element is at the root level, add it to first level elements array.
            else {
                tree.push(mappedElem);
            }
        }
    }

    return tree;
}

export function createPriorityList() {
    return priorities;
}

export function createSiteGroups() {
    return siteGroups;
}

export function addNewSite(newSite) {
    if (newSite.parentId && mappedArr[newSite.parentId]) {
        mappedArr[newSite.parentId]['children'].push(newSite);
    }
    // If the element is at the root level, add it to first level elements array.
    else {
        tree.push(newSite);
    }

    if (newSite.address === null || newSite.address === "") {
        this.siteGroups.push(newSite);
    }
}

function removeItemById(arr, id) {
    if (arr === undefined || arr.length === 0) {
        return;
    }

    var index = arr.findIndex(s => s.id === id);
    if (index !== -1) arr.splice(index, 1);
}

export function removeSite(deletedSites) {
    deletedSites.forEach(deletedSite => {
        if (deletedSite.parentId && mappedArr[deletedSite.parentId]) {
            removeItemById(mappedArr[deletedSite.parentId]['children'], deletedSite.id);
        }
        // If the element is at the root level, add it to first level elements array.
        else {
            removeItemById(tree, deletedSite.id);
        }

        if (deletedSite.address === null || deletedSite.address === "") {
            removeItemById(this.siteGroups, deletedSite.id);
        }
    });
}


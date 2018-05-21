var priorities = [];
var siteGroups = [];
priorities.splice(0, 0, { Description: "All", Value: "0" });
siteGroups.splice(0, 0, { Description: "", id: -1 });
export function listToTree(arr) {
    var tree = [],
        mappedArr = {},
        arrElem,
        mappedElem;

    if (arr === null || arr.length == 0) {
        return tree;
    }

    // First map the nodes of the array to an object -> create a hash table.
    for (var i = 0, len = arr.length; i < len; i++) {
        arrElem = arr[i];
        if (priorities.findIndex(p => p.Description === arrElem.sitePriority.toString()) < 0) {
            priorities.push({ Description: arrElem.sitePriority.toString(), Value: arrElem.sitePriority });
        }

        if (arrElem.address === null && siteGroups.findIndex(s => s.id === arrElem.id) < 0) {
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

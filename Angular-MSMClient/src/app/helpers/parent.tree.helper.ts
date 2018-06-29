export function listToTree(arr, fb) {
    var tree = [];
    var mappedArr = {};
    var arrElem, mappedElem, arrElemFormGroup;
    if (arr === null || arr.length == 0) {
        return tree;
    }

    // First map the nodes of the array to an object -> create a hash table.
    for (var i = 0, len = arr.length; i < len; i++) {
        arrElem = arr[i];
        arrElem.children = null;
        arrElemFormGroup = fb.group(arrElem);
        mappedArr[arrElem.id] = arrElemFormGroup;
    }

    for (var id in mappedArr) {
        if (mappedArr.hasOwnProperty(id)) {
            mappedElem = mappedArr[id];
            // If the element is not at the root level, add it to its parent array of children.
            if (mappedElem.value.parentId) {
                let parentGroup = mappedArr[mappedElem.value.parentId];
                let childrenForm = parentGroup.controls.children;
                if (childrenForm.value === null) {
                    childrenForm = fb.group({
                        parentSiteSource: fb.array([mappedElem])
                    });

                    parentGroup.setControl('children', childrenForm);
                }
                else {
                    childrenForm.controls.parentSiteSource.push(mappedElem);
                }
            }
            // If the element is at the root level, add it to first level elements array.
            else {
                tree.push(mappedElem);
            }
        }
    }

    return tree;
}
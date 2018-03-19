export class Site {
    id: number;
    parentId: number;
    description: string;
    latitude: string;
    longitude: string;
    children: Site[] = [];
    constructor(values: Object = {}) {
        Object.assign(this, values);
    }
}

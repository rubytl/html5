export class Site {
    id: number;
    parentId: number;
    description: string;
    status: number;
    latitude: string;
    longitude: string;
    children: Site[] = [];
    constructor(values: Object = {}) {
        Object.assign(this, values);
    }
}

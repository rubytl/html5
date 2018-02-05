export class Site {
    id: number;
    name: string = '';
    lat: number;
    long: number;
    children: Site[] = [];
    constructor(values: Object = {}) {
        Object.assign(this, values);
    }
}

export class Site {
    id: number;
    parentId: number;
    description: string;
    sitePriority:number;
    address:string;
    controllerType:number;
    status: number;
    latitude: string;
    longitude: string;
    templateId:string;
    snmpTemplateId:number;
    snmpDataTemplateId:string;
    ssl:boolean;
    jsonUserName:string;
    jsonPassword:string;
    children: Site[] = [];
    constructor(values: Object = {}) {
        Object.assign(this, values);
    }
}

import { Injectable } from '@angular/core';
import { Site } from '../models/site';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import { HttpClient } from '@angular/common/http';
import { BaseService } from "./base.service";

@Injectable()
export class MockRestrictedSiteApiService extends BaseService {

    constructor(
        private httpClient: HttpClient
    ) {
        super();
    }

    public getAllSites() {
        return Promise.resolve([
            new Site({ id: 1, name: 'Hybrid' })
        ]);
    }
}

import { Injectable } from '@angular/core';
import { Site } from '../models/site';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';

@Injectable()
export class MockRestrictedSiteApiService {

    constructor(
    ) {
    }

    public getAllSites(): Observable<Site[]> {
        return Observable.of([
            new Site({ id: 1, name: 'Hybrid' })
        ]);
    }
}

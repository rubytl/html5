import { TestBed, inject } from '@angular/core/testing';
import { RestrictedSiteApiService } from './restricted-site.service';
import { BaseRequestOptions, Http, XHRBackend } from '@angular/http';
import { MockBackend } from '@angular/http/testing';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Site } from '../models/site';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/of';
import { BaseService } from "./base.service";

describe('RestrictedSiteApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: HttpClient, useFactory: (backend, options) => {
            return new Http(backend, options);
          },
          deps: [MockBackend, BaseRequestOptions]
        },
        MockBackend,
        BaseRequestOptions,
        RestrictedSiteApiService
      ]
    });
  });

  it('should be created', inject([RestrictedSiteApiService], (service: MockRestrictedSiteApiService) => {
    expect(service).toBeTruthy();
  }));

  it('getAllSites should be called sucessful', inject([RestrictedSiteApiService], (service: MockRestrictedSiteApiService) => {
    expect(service.getAllSites()).toBeTruthy();
  }));
});

@Injectable()
export class MockRestrictedSiteApiService extends BaseService {

  constructor(
    private httpClient: HttpClient
  ) {
    super();
  }

  public getAllSites() {
    return [
      new Site({ id: 1, name: 'Hybrid' })
    ];
  }
}
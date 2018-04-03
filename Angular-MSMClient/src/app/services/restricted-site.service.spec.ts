import { TestBed, inject } from '@angular/core/testing';
import { RestrictedSiteApiService } from './restricted-site.service';
import { BaseRequestOptions, Http, XHRBackend } from '@angular/http';
import { MockBackend } from '@angular/http/testing';
import { MockRestrictedSiteApiService } from './restricted-site-mock.service';
import { HttpClient } from '@angular/common/http';

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

  it('Should be created', inject([RestrictedSiteApiService], (service: MockRestrictedSiteApiService) => {
    expect(service).toBeTruthy();
  }));

  it('getAllSites should be called sucessful', inject([RestrictedSiteApiService], (service: MockRestrictedSiteApiService) => {
    expect(service.getAllSites()).length > 0;
  }));
});

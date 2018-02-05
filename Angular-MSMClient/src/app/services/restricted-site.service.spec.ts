import { TestBed, inject } from '@angular/core/testing';
import { RestrictedSiteApiService } from './restricted-site.service';
import { BaseRequestOptions, Http, XHRBackend } from '@angular/http';
import { MockBackend } from '@angular/http/testing';

describe('RestrictedSiteApiService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [
        {
          provide: Http, useFactory: (backend, options) => {
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

  it('Should be created', inject([RestrictedSiteApiService], (service: RestrictedSiteApiService) => {
    expect(service).toBeTruthy();
  }));
});

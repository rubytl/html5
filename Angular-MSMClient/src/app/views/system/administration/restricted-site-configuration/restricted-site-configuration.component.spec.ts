import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RestrictedSiteConfigurationComponent } from './restricted-site-configuration.component';

describe('RestrictedSiteConfigurationComponent', () => {
  let component: RestrictedSiteConfigurationComponent;
  let fixture: ComponentFixture<RestrictedSiteConfigurationComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RestrictedSiteConfigurationComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RestrictedSiteConfigurationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

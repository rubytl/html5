import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SiteTemplateSetupComponent } from './site-template-setup.component';

describe('SiteTemplateComponent', () => {
  let component: SiteTemplateSetupComponent;
  let fixture: ComponentFixture<SiteTemplateSetupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [SiteTemplateSetupComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SiteTemplateSetupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

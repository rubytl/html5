import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmSiteTemplateComponent } from './msm-site-template.component';

describe('MsmSiteTemplateComponent', () => {
  let component: MsmSiteTemplateComponent;
  let fixture: ComponentFixture<MsmSiteTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [MsmSiteTemplateComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmSiteTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

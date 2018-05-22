import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmSnmpTemplateComponent } from './msm-snmp-template.component';

describe('MsmSitegroupComponent', () => {
  let component: MsmSnmpTemplateComponent;
  let fixture: ComponentFixture<MsmSnmpTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [MsmSnmpTemplateComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmSnmpTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

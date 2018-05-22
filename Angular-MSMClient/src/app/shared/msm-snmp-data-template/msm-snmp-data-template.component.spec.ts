import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmSnmpDataTemplateComponent } from './msm-snmp-data-template.component';

describe('MsmSitegroupComponent', () => {
  let component: MsmSnmpDataTemplateComponent;
  let fixture: ComponentFixture<MsmSnmpDataTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [MsmSnmpDataTemplateComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmSnmpDataTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

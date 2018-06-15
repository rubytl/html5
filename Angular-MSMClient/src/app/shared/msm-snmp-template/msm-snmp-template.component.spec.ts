import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { MsmSnmpTemplateComponent } from './msm-snmp-template.component';

describe('MsmSitegroupComponent', () => {
  let component: MsmSnmpTemplateComponent;
  let fixture: ComponentFixture<MsmSnmpTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ReactiveFormsModule],
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

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmMonitorComponent } from './msm-monitor.component';

describe('MsmMonitorComponent', () => {
  let component: MsmMonitorComponent;
  let fixture: ComponentFixture<MsmMonitorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmMonitorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmMonitorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

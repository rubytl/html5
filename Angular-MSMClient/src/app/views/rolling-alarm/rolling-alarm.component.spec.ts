import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RollingAlarmComponent } from './rolling-alarm.component';

describe('RollingAlarmComponent', () => {
  let component: RollingAlarmComponent;
  let fixture: ComponentFixture<RollingAlarmComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RollingAlarmComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RollingAlarmComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

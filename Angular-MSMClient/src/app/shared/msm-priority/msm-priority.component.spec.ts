import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmPriorityComponent } from './msm-priority.component';

describe('MsmPriorityComponent', () => {
  let component: MsmPriorityComponent;
  let fixture: ComponentFixture<MsmPriorityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmPriorityComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmPriorityComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

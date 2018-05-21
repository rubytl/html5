import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmControllerTypeComponent } from './msm-controller-type.component';

describe('MsmControllerTypeComponent', () => {
  let component: MsmControllerTypeComponent;
  let fixture: ComponentFixture<MsmControllerTypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmControllerTypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmControllerTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

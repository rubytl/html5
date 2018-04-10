import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmHeaderComponent } from './msm-header.component';

describe('MsmHeaderComponent', () => {
  let component: MsmHeaderComponent;
  let fixture: ComponentFixture<MsmHeaderComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmHeaderComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmHeaderComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

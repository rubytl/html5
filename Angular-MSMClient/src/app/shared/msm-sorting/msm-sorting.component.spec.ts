import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmSortingComponent } from './msm-sorting.component';

describe('MsmSortingComponent', () => {
  let component: MsmSortingComponent;
  let fixture: ComponentFixture<MsmSortingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmSortingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmSortingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

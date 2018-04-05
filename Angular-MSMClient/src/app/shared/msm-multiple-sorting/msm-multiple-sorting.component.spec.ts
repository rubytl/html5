import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmMultipleSortingComponent } from './msm-multiple-sorting.component';

describe('MsmMultipleSortingComponent', () => {
  let component: MsmMultipleSortingComponent;
  let fixture: ComponentFixture<MsmMultipleSortingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmMultipleSortingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmMultipleSortingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { MsmSortingComponent } from './msm-sorting.component';

describe('MsmSortingComponent', () => {
  let component: MsmSortingComponent;
  let fixture: ComponentFixture<MsmSortingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ReactiveFormsModule],
      declarations: [ MsmSortingComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmSortingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should beccreated', () => {
    expect(component).toBeTruthy();
  });

  it('asc sort should work', () => {
    expect(component.ascSort).toBeTruthy();
  });

  it('desc sort should work', () => {
    expect(component.descSort).toBeTruthy();
  });
});

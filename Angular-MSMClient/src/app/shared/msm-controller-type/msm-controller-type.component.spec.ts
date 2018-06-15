import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MsmControllerTypeComponent } from './msm-controller-type.component';

describe('MsmControllerTypeComponent', () => {
  let component: MsmControllerTypeComponent;
  let fixture: ComponentFixture<MsmControllerTypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ReactiveFormsModule],
      declarations: [MsmControllerTypeComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmControllerTypeComponent);
    component = fixture.componentInstance;
    component.templateList = [];
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

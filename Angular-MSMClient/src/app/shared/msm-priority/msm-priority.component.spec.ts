import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { MsmPriorityComponent } from './msm-priority.component';

describe('MsmPriorityComponent', () => {
  let component: MsmPriorityComponent;
  let fixture: ComponentFixture<MsmPriorityComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ReactiveFormsModule],
      declarations: [MsmPriorityComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmPriorityComponent);
    component = fixture.componentInstance;
    component.templateList = [];
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

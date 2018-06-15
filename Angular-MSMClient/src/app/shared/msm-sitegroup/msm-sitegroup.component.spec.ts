import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';
import { MsmSitegroupComponent } from './msm-sitegroup.component';

describe('MsmSitegroupComponent', () => {
  let component: MsmSitegroupComponent;
  let fixture: ComponentFixture<MsmSitegroupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ReactiveFormsModule],
      declarations: [MsmSitegroupComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmSitegroupComponent);
    component = fixture.componentInstance;
    component.templateList = [];
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmAsideComponent } from './msm-aside.component';

describe('MsmAsideComponent', () => {
  let component: MsmAsideComponent;
  let fixture: ComponentFixture<MsmAsideComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmAsideComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmAsideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

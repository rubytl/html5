import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmFooterComponent } from './msm-footer.component';

describe('MsmFooterComponent', () => {
  let component: MsmFooterComponent;
  let fixture: ComponentFixture<MsmFooterComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmFooterComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmFooterComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

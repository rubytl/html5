import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmDialogComponent } from './msm-dialog.component';

describe('MsmDialogComponent', () => {
  let component: MsmDialogComponent;
  let fixture: ComponentFixture<MsmDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

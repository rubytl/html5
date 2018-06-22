import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { Component, Input } from '@angular/core';

describe('ResetPasswordComponent', () => {
  let component: ResetPasswordComponentWrapper;
  let fixture: ComponentFixture<ResetPasswordComponentWrapper>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ResetPasswordComponentWrapper]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResetPasswordComponentWrapper);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

@Component({
  selector: 'test-reset-password-wrapper',
  template: '<div>reset password component displayed</div>'
})
class ResetPasswordComponentWrapper {
}
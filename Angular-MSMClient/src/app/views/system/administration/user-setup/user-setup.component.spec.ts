import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { Component, Input } from '@angular/core';

describe('UserSetupComponent', () => {
  let component: UserSetupComponentWrapper;
  let fixture: ComponentFixture<UserSetupComponentWrapper>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [UserSetupComponentWrapper],
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserSetupComponentWrapper);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

@Component({
  selector: 'test-user-setup-wrapper',
  template: '<div>user setup component displayed</div>'
})
class UserSetupComponentWrapper {
}
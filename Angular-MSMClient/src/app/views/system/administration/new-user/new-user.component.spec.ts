import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { Component, Input } from '@angular/core';

describe('NewUserComponent', () => {
  let component: NewUserComponentWrapper;
  let fixture: ComponentFixture<NewUserComponentWrapper>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [NewUserComponentWrapper],
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewUserComponentWrapper);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

@Component({
  selector: 'test-new-user-wrapper',
  template: '<div>new user displayed</div>'
})
class NewUserComponentWrapper {
}
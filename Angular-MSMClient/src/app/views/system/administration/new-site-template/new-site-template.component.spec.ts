import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NewSiteTemplateComponent } from './new-site-template.component';

describe('NewSiteTemplateComponent', () => {
  let component: NewSiteTemplateComponent;
  let fixture: ComponentFixture<NewSiteTemplateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NewSiteTemplateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NewSiteTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmSitegroupComponent } from './msm-sitegroup.component';

describe('MsmSitegroupComponent', () => {
  let component: MsmSitegroupComponent;
  let fixture: ComponentFixture<MsmSitegroupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmSitegroupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmSitegroupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

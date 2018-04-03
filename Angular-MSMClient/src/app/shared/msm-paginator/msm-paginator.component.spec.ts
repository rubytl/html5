import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmPaginatorComponent } from './msm-paginator.component';

describe('MsmPaginatorComponent', () => {
  let component: MsmPaginatorComponent;
  let fixture: ComponentFixture<MsmPaginatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MsmPaginatorComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmPaginatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

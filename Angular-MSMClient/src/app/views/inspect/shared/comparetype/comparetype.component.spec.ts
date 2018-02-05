import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ComparetypeComponent } from './comparetype.component';

describe('ComparetypeComponent', () => {
  let component: ComparetypeComponent;
  let fixture: ComponentFixture<ComparetypeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ComparetypeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ComparetypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MsmPaginatorComponent } from './msm-paginator.component';

describe('MsmPaginatorComponent', () => {
  let component: MsmPaginatorComponent;
  let fixture: ComponentFixture<MsmPaginatorComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [MsmPaginatorComponent]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MsmPaginatorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });

  it('increment page should work', () => {
    component.pageIndex = 0;    
    component.increment();
    expect(component.pageIndex === 1).toBeTruthy();
  });

  it('decrement page should work', () => {
    component.pageIndex = 10;    
    component.decrement();
    expect(component.pageIndex === 9).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ChartsModule } from 'ng2-charts/ng2-charts';

import { EnergySingleComponent } from './energy.component';
import {
  TimeframeComponent, ComparetypeComponent,
  ActionComponent
} from '..';


describe('EnergySingleComponent', () => {
  let component: EnergySingleComponent;
  let fixture: ComponentFixture<EnergySingleComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ChartsModule],
      declarations: [
        EnergySingleComponent,
        TimeframeComponent,
        ComparetypeComponent,
        ActionComponent
      ]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EnergySingleComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});

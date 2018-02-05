import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { ChartsModule } from 'ng2-charts/ng2-charts';

import { EcbComponent } from './ecb.component';
import {
  TimeframeComponent, ComparetypeComponent,
  ActionComponent
} from '..';

describe('EcbComponent', () => {
  let component: EcbComponent;
  let fixture: ComponentFixture<EcbComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      imports: [ChartsModule],
      declarations: [
        EcbComponent,
        TimeframeComponent,
        ComparetypeComponent,
        ActionComponent
      ]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EcbComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});

import { Component, OnInit, OnDestroy } from '@angular/core';
import { NgRedux, DevToolsExtension } from 'ng2-redux';
import { IAppState, rootReducer, enhancers } from './store/index';
import { createLogger } from 'redux-logger';
import { Subscription } from 'rxjs/Subscription';

@Component({
  selector: 'body',
  templateUrl: './app.component.html',  
  styleUrls: ['./app.component.scss']  
})
export class AppComponent implements OnInit, OnDestroy {
  isRequesting: boolean;
  inProgressSub: Subscription;
  constructor(
    private ngRedux: NgRedux<IAppState>,
    private devTool: DevToolsExtension) {

    this.ngRedux.configureStore(
      rootReducer,
      {},
      [createLogger()],
      [...enhancers, devTool.isEnabled() ? devTool.enhancer() : f => f]);
  }

  ngOnInit() {
    this.inProgressSub = this.ngRedux.select(state => state.inProgress)
      .subscribe(value => this.isRequesting = value);
  }

  ngOnDestroy() {
    if (this.inProgressSub) {
      this.inProgressSub.unsubscribe();
    }
  }
}

import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { LocationStrategy, HashLocationStrategy } from '@angular/common';
import { NgReduxModule, DevToolsExtension } from 'ng2-redux';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';

import { AppComponent } from './app.component';

// Routing Module
import { AppRoutingModule } from './app.routing';
import { FullLayoutModule } from './layouts/full-layout.module';
import { RequestInterceptorService, SharedServiceModule } from './services';

import { ACTION_PROVIDERS } from './actions';
import { SharedModule } from './shared/shared.module';

@NgModule({
  imports: [
    AppRoutingModule,
    NgReduxModule,
    BrowserModule,
    SharedModule,
    FullLayoutModule,
    HttpClientModule,
    SharedServiceModule.forRoot()
  ],
  declarations: [
    AppComponent,
  ],
  providers: [
    {
      provide: LocationStrategy,
      useClass: HashLocationStrategy,
    },
    {
      provide: HTTP_INTERCEPTORS,
      useClass: RequestInterceptorService,
      multi: true
    },
    DevToolsExtension,
    ACTION_PROVIDERS
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }

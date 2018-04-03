import { NgModule, ModuleWithProviders } from '@angular/core';
import { RestrictedSiteApiService } from './restricted-site.service';
import { UserService } from './user.service';
import { AuthGuard } from './auth.service';
import { RequestInterceptorService } from './request-interceptor.service';
import { AlarmService } from './alarm.service';

export {
    RequestInterceptorService,
    RestrictedSiteApiService,
    UserService,
    AuthGuard,
    AlarmService
};
  
@NgModule({})
export class SharedServiceModule {
    static forRoot(): ModuleWithProviders {
        return {
            ngModule: SharedServiceModule,
            providers: [RestrictedSiteApiService, UserService,
                AuthGuard, AlarmService]
        };
    }
}

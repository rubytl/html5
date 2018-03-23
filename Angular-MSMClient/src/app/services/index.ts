import { NgModule, ModuleWithProviders } from '@angular/core';
import { RestrictedSiteApiService } from './restricted-site.service';
// import { AuthenticateXHRBackend } from './auth-xhr.backend';
import { UserService } from './user.service';
import { AuthGuard } from './auth.service';
import { RequestInterceptorService } from './request-interceptor.service';

export {
    RequestInterceptorService,
    // AuthenticateXHRBackend,
    RestrictedSiteApiService,
    UserService,
    AuthGuard
};

@NgModule({})
export class SharedServiceModule {
    static forRoot(): ModuleWithProviders {
        return {
            ngModule: SharedServiceModule,
            providers: [RestrictedSiteApiService, UserService, AuthGuard]
        };
    }
}

import { NgModule, ModuleWithProviders } from '@angular/core';
import { RestrictedSiteService } from './restricted-site.service';
import { UserService } from './user.service';
import { AuthGuard } from './auth.service';
import { RequestInterceptorService } from './request-interceptor.service';
import { AlarmService } from './alarm.service';
import { SiteService } from './site.service';
import { TemplateService } from './template.service';
import { SnmpConfigService } from './snmp.config.service';
import { SnmpDataService } from './snmp.data.service';
import { MsmDictionaryService } from './msm.dictionary.service';
import { RestrictedGroupService } from './restricted-group.service';
import { RoleService } from './role.service';
import { UserLoginService } from './user-login.service';

export {
    RequestInterceptorService,
    RestrictedSiteService,
    UserService,
    AuthGuard,
    AlarmService,
    SiteService,
    TemplateService,
    SnmpConfigService,
    SnmpDataService,
    MsmDictionaryService,
    RestrictedGroupService,
    RoleService,
    UserLoginService
};

@NgModule({})
export class SharedServiceModule {
    static forRoot(): ModuleWithProviders {
        return {
            ngModule: SharedServiceModule,
            providers: [RestrictedSiteService, UserService,
                AuthGuard, AlarmService, SiteService,
                TemplateService, SnmpConfigService, SnmpDataService,
                MsmDictionaryService, RestrictedGroupService,
                RoleService, UserLoginService]
        };
    }
}

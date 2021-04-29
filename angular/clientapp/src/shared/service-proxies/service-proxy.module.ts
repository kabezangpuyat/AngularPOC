import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { NgModule } from '@angular/core';
import * as ApiServiceProxies from './service-proxies';

@NgModule({
    providers:[
        ApiServiceProxies.AccountServiceProxy,
        ApiServiceProxies.DepartmentServiceProxy,
        ApiServiceProxies.UserServiceProxy
    ]
})

export class ServiceProxyModule { }
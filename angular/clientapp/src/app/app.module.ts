import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { AppuserComponent } from './appuser/appuser.component';
import { ShowUserComponent } from './appuser/show-user/show-user.component';
import { DepartmentComponent } from './department/department.component';
import { AddEditUserComponent } from './appuser/add-edit-user/add-edit-user.component';
import { ShowDepartmentComponent } from './department/show-department/show-department.component';
import { AddEditDepartmentComponent } from './department/add-edit-department/add-edit-department.component';
import { SharedService } from './shared.service';

import { HttpClientModule } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    AppuserComponent,
    ShowUserComponent,
    DepartmentComponent,
    AddEditUserComponent,
    ShowDepartmentComponent,
    AddEditDepartmentComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule, 
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [SharedService],
  bootstrap: [AppComponent]
})
export class AppModule { }

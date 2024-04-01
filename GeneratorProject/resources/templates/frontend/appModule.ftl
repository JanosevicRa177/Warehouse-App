import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http'
import { ToastrModule } from 'ngx-toastr';
<#list classes as class>
import { ${class.name}Component } from './components/${class.name?lower_case}/${class.name?lower_case}.component';    
</#list>

@NgModule({
  declarations: [
    AppComponent,
    <#list classes as class>
		${class.name}Component,  
	</#list>
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    ToastrModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
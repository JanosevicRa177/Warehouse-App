import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
<#list classes as class>
import { ${class.name}Component } from './components/${class.name}/${class.name?lower_case}.component';    
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
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
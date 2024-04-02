import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

<#list classes as class>
import { ${class.name}Component } from './components/${class.name?lower_case}/${class.name?lower_case}.component';    
</#list>

const routes: Routes = [
<#list classes as class>
	{
		path: '${class.name?lower_case}',
		component: ${class.name}Component
	},    
</#list>
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
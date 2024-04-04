<main class="main">
  <div class="content">
  <#list classes as class> 
<div (click)="navigateTo('/${class.name?lower_case}')">
   	${class.name}
   </div>  
	</#list>
  </div>
</main>
<router-outlet></router-outlet>
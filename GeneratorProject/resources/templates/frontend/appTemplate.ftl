<main class="main">
  <div class="navbar">
  <#list classes as class> 
    <div class="nav-item" (click)="navigateTo('/${class.name?lower_case}')">${class.name}</div>  
  </#list>
  </div>
</main>
<router-outlet></router-outlet>
<div class="wrapper">
  <div class="table-container">
    <table class="data-table">
	  <thead>
	    <tr>
	      <th>Id</th>
	      <#list properties as property>
	      <th>${property.name}</th>   
		  </#list>
		  <th></th>
		  <th></th>
	    </tr>
	  </thead>
	  <tbody>
	    <tr *ngFor="let item of data">
	      <td>{{ item.id }}</td>
	    <#list properties as property>
			<#if property.upper == 1 && property.isClass> 
		  <td>{{ item.${property.type.name?uncap_first}Id }}</td>
			 </#if>
	   		 <#if property.upper == 1 && !property.isClass>  
	      <td>{{ item.${property.name?uncap_first} }}</td>
  			 </#if>
		     <#if property.upper == -1 > 
		  <td><div class="ids"><div *ngFor="let id of item.${property.name?uncap_first}Ids">{{ id }}</div></div></td>
		     </#if>     
		</#list>
		  <td><button class="submit-btn" (click)="selectedItem = item">Edit</button></td>
		  <td><button class="delete-btn" (click)="delete(item.id)">Delete</button></td>
	    </tr>
	  </tbody>
	</table>
  </div>
  <div class="form-container">
  	<div class="create-btn-wrapper">
	  <button class="submit-btn" (click)="selectedItem = null">Open create form</button>
	</div>
	<h2 *ngIf="!selectedItem">Create form</h2>
	<h2 *ngIf="selectedItem">Edit form</h2>
	<form #entityForm="ngForm" (ngSubmit)="selectedItem ? edit(entityForm.value) : create(entityForm.value)">		
		<#list properties as property>
			<#if property.upper == 1 && property.isClass> 
	      <label for="${property.type.name?uncap_first}">${property.name}:</label>
		  <select id="${property.type.name?uncap_first}" name="${property.type.name?uncap_first}" [ngModel]="selectedItem ? selectedItem.${property.name?uncap_first}Id : null">
			  <option *ngFor="let item of <#if property.type.name?ends_with("s")>${property.type.name?uncap_first}es<#elseif property.type.name?ends_with("y")>${property.type.name?uncap_first?substring(0, property.type.name?length - 1)}ies<#else>${property.type.name?uncap_first}s</#if>" [value]="item.id">{{ item.id }}</option>
		  </select> 
			 </#if>
	   		 <#if property.upper == 1 && !property.isClass>  
	      <label for="${property.name?uncap_first}">${property.name}:</label>
    	  <input type="text" id="${property.name?uncap_first}" name="${property.name?uncap_first}" [ngModel]="selectedItem ? selectedItem.${property.name?uncap_first} : null" required>
  			 </#if>
		     <#if property.upper == -1 > 
		   <label for="${property.type.name?uncap_first}"><#if property.type.name?ends_with("s")>${property.type.name}es<#elseif property.type.name?ends_with("y")>${property.type.name?substring(0, property.type.name?length - 1)}ies<#else>${property.type.name}s</#if>:</label>
		   <select id="${property.type.name?uncap_first}" name="${property.type.name?uncap_first}" multiple [ngModel]="selectedItem ? selectedItem.${property.name?uncap_first}Ids : null">
		      <option *ngFor="let item of <#if property.type.name?ends_with("s")>${property.type.name?uncap_first}es<#elseif property.type.name?ends_with("y")>${property.type.name?uncap_first?substring(0, property.type.name?length - 1)}ies<#else>${property.type.name?uncap_first}s</#if>" [value]="item.id">{{ item.id }}</option>
		   </select> 
		    </#if>     
		</#list>
	<div *ngIf="!selectedItem">
	  <button class="submit-btn" type="submit">Create</button>
	</div>
	<div *ngIf="selectedItem">
	  <button class="submit-btn">Edit</button>
	</div>
	</form>
  <div>
</div>
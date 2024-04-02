<div class="wrapper">
  <div class="table-container">
    <table class="data-table">
	  <thead>
	    <tr>
	    <#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager'>
	      <th>Email</th>
	      <th>First name</th>
	      <th>Contact</th>
	      <th>Address</th>
	      <#if '${class.name}' == 'Worker'>
	      <th>Warehouse</th>
	      </#if>
	    </#if>
	    <#if '${class.name}' == 'Warehouse'>
	      <th>Name</th>
	      <th>Size</th>
	      <th>Address</th>
	    </#if>
	    <#if '${class.name}' == 'Address'>
	      <th>Street</th>
	      <th>Street number</th>
  	      <th>City</th>
  	      <th>Country</th>
  	      <th>User</th>
	    </#if>
	    <#if '${class.name}' == 'Product'>
	      <th>Price</th>
	      <th>Warehouse</th>
	    </#if>
	      <th></th>
	      <th></th>
	    </tr>
	  </thead>
	  <tbody>
	    <tr *ngFor="let item of data">
	    <#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager'>
	  	  <td>{{ item.email }}</td>
	  	  <td>{{ item.firstName }}</td>
	  	  <td>{{ item.contact }}</td>
	  	  <td>{{ item.address?.street}} {{ item.address?.streetNumber }} {{ item.address?.city }} {{ item.address?.country }}</td>
	  	  <#if '${class.name}' == 'Worker'>
	  	  <td>{{ item.warehouse?.name }}</td>
	  	  </#if>
	    </#if>
	    <#if '${class.name}' == 'Warehouse'>
	      <td>{{ item.name }}</td>
	      <td>{{ item.size }}</td>
	      <td>{{ item.address?.street}} {{ item.address?.streetNumber }} {{ item.address?.city }} {{ item.address?.country }}</td>
	    </#if>
	    <#if '${class.name}' == 'Address'>
	  	  <td>{{ item.street }}</td>
	  	  <td>{{ item.streetNumber }}</td>
	  	  <td>{{ item.city }}</td>
	  	  <td>{{ item.country }}</td>
	  	  <td>{{ item.user.email }}</td>
	    </#if>
	    <#if '${class.name}' == 'Product'>
	  	  <td>{{ item.price }}</td>
	  	  <td>{{ item.warehouse?.name }}</td>
	    </#if>
	      <td><button class="delete-btn" (click)="delete(item.id)">Delete</button></td>
	      <td><button class="submit-btn" (click)="selectedItem = item">Edit</button></td>
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
		${property.isClass}
			<#if property.upper == 1 && property.isClass> 
	      <label for="${property.type.name?uncap_first}">${property.type.name}:</label>
		  <select id="${property.type.name?uncap_first}" name="${property.type.name?uncap_first}">
			  <option *ngFor="let item of ${property.type.name?uncap_first}s" [value]="item.id">{{ item.id }}</option>
		  </select> 
			 </#if>
	   		 <#if property.upper == 1 && !property.isClass>  
	      <label for="${property.name?uncap_first}">${property.name}:</label>
    	  <input type="text" id="${property.name?uncap_first}" name="${property.name?uncap_first}" [ngModel]="selectedItem ? selectedItem.${property.name?uncap_first} : null" required>
  			 </#if>
		     <#if property.upper == -1 > 
		   <label for="${property.type.name?uncap_first}">${property.type.name}:</label>
		   <select id="${property.type.name?uncap_first}" name="${property.type.name?uncap_first}" multiple>
		      <option *ngFor="let item of ${property.type.name?uncap_first}s" [value]="item.id">{{ item.id }}</option>
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
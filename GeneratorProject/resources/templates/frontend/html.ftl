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
	<#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager'>
	  <label for="email">Email:</label>
	  <input type="email" id="email" name="email" [ngModel]="selectedItem ? selectedItem.email : null" required>
	
	  <label for="firstName">First Name:</label>
	  <input type="text" id="firstName" name="firstName" [ngModel]="selectedItem ? selectedItem.firstName : null" required>

	  <label for="contact">Contact:</label>
	  <input type="text" id="contact" name="contact" [ngModel]="selectedItem ? selectedItem.contact : null" required>
	  
	  <label for="address">Address:</label>
      <select id="address" name="addressId" [ngModel]="selectedItem ? selectedItem.address?.id : null" required>
        <option *ngFor="let address of addresses" [value]="address.id">{{ address.street }} {{address.streetNumber}} {{address.city}} {{address.country}}</option>
      </select>
      
      <#if '${class.name}' == 'Worker'>
  	  <label for="warehouse">Warehouse:</label>
      <select id="warehouse" name="warehouseId" [ngModel]="selectedItem ? selectedItem.warehouse?.id : null" required>
        <option *ngFor="let warehouse of warehouses" [value]="warehouse.id">{{ warehouse.name }}</option>
      </select>
      </#if>
      
      <#if '${class.name}' == 'Manager'>
      <label for="warehouses">Warehouses:</label>
	  <select id="warehouses" name="warehouseIds" multiple [ngModel]="selectedItem ? selectedItem.warehouseIds : null" required>
	    <option *ngFor="let warehouse of warehouses" [value]="warehouse.id">{{ warehouse.name }}</option>
	  </select>
      </#if>
      
	</#if>
	<#if '${class.name}' == 'Warehouse'>
	  <label for="name">Name:</label>
	  <input type="text" id="name" name="name" [ngModel]="selectedItem ? selectedItem.name : null" required>
	
	  <label for="size">Size:</label>
	  <input type="number" id="size" name="size" [ngModel]="selectedItem ? selectedItem.size : null" required>

	  <label for="address">Address:</label>
      <select id="address" name="addressId" [ngModel]="selectedItem ? selectedItem.address?.id : null" required>
        <option *ngFor="let address of addresses" [value]="address.id">{{ address.street }} {{address.streetNumber}} {{address.city}} {{address.country}}</option>
      </select>
	</#if>
	<#if '${class.name}' == 'Address'>
	  <label for="street">Street:</label>
	  <input type="text" id="street" name="street" [ngModel]="selectedItem ? selectedItem.street : null" required>
	
	  <label for="streetNumber">StreetNumber:</label>
	  <input type="text" id="streetNumber" name="streetNumber" [ngModel]="selectedItem ? selectedItem.streetNumber : null" required>
	  
	  <label for="city">City:</label>
	  <input type="text" id="city" name="city" [ngModel]="selectedItem ? selectedItem.city : null" required>
	  
	  <label for="Country">Country:</label>
	  <input type="text" id="country" name="country" [ngModel]="selectedItem ? selectedItem.country : null" required>

	</#if>
	<#if '${class.name}' == 'Product'>
	  <label for="price">Price:</label>
	  <input type="number" id="price" name="price" [ngModel]="selectedItem ? selectedItem.price : null" required>
	  
	  <label for="warehouse">Warehouse:</label>
      <select id="warehouse" name="warehouseId" [ngModel]="selectedItem ? selectedItem.warehouse?.id : null" required>
        <option *ngFor="let warehouse of warehouses" [value]="warehouse.id">{{ warehouse?.name }}</option>
      </select>
	</#if>
	
	<div *ngIf="!selectedItem">
	  <button class="submit-btn" type="submit">Create</button>
	</div>
	<div *ngIf="selectedItem">
	  <button class="submit-btn">Edit</button>
	</div>
	</form>
  <div>
</div>
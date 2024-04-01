<div class="wrapper">
  <div class="table-container">
    <table class="data-table">
	  <thead>
	    <tr>
	    <#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager'>
	      <th>Email</th>
	      <th>First name</th>
	      <th>Contact</th>
	    </#if>
	    <#if '${class.name}' == 'Warehouse'>
	      <th>Name</th>
	      <th>Size</th>
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
	    </#if>
	    <#if '${class.name}' == 'Warehouse'>
	      <th>{{ item.name }}</th>
	      <th>{{ item.size }}</th>
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
	</#if>
	<#if '${class.name}' == 'Warehouse'>
	  <label for="name">Name:</label>
	  <input type="text" id="name" name="name" [ngModel]="selectedItem ? selectedItem.name : null" required>
	
	  <label for="size">Size:</label>
	  <input type="number" id="size" name="size" [ngModel]="selectedItem ? selectedItem.size : null" required>

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
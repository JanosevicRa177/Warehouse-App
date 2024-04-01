import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ${class.name}Service } from '../../services/${class.name}.service';
<#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Warehouse'>
import { AddressService } from '../../services/Address.service'
</#if>
<#if '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Product'>
import { WarehouseService } from '../../services/Warehouse.service'
</#if>
//import { ${class.name} } from '../../models/${class.name}'

@Component({
  selector: 'app-${class.name?lower_case}',
  templateUrl: './${class.name?lower_case}.component.html',
  styleUrl: './${class.name?lower_case}.component.css'
})

export class ${class.name}Component implements OnInit {
	//data: ${class.name}[] = []
	data: any[] = []
	selectedItem: any = null
	<#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Warehouse'>
	addresses: any = []
	</#if>  
	<#if '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Product'>
	warehouses: any = []
	</#if>  
	
	constructor(private ${class.name?lower_case}Service: ${class.name}Service<#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Warehouse'>, private addressService: AddressService</#if> <#if '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Product'>, private warehouseService: WarehouseService</#if>) { } 
	
	ngOnInit(): void {
		this.${class.name?lower_case}Service.get${class.name}().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		<#if '${class.name}' == 'User' || '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Warehouse'>
		this.addressService.getAddress().subscribe(
			(data) => {
				this.addresses = data
			} 
		)
		</#if>
		
		<#if '${class.name}' == 'Worker' || '${class.name}' == 'Manager' || '${class.name}' == 'Product'>
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.warehouses = data
			} 
		)
		</#if>
	}
  
    <#if class.crud.delete == true >
	delete(id: number) : void {
	    this.${class.name?lower_case}Service.delete${class.name}(id).subscribe(
	  		() => {
	  			//this.toastr.success('${class.name} is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete ${class.name}')
	  		} 
  		);
	}
	</#if>  
	
	<#if class.crud.create == true >
	create(entity: any) : void {
	    this.${class.name?lower_case}Service.create${class.name}(entity).subscribe(
	  		() => {
	  			//this.toastr.success('${class.name} created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create ${class.name}')
	  		} 
  		);
	}
	</#if> 
	
	<#if class.crud.update == true >
	edit(entity: any) : void {
	    this.${class.name?lower_case}Service.update${class.name}(entity).subscribe(
	  		() => {
	  			//this.toastr.success('${class.name} edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit ${class.name}')
	  		} 
  		);
	}
	</#if> 
	
  
}

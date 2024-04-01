import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ManagerService } from '../../services/Manager.service';
import { AddressService } from '../../services/Address.service'
import { WarehouseService } from '../../services/Warehouse.service'
//import { Manager } from '../../models/Manager'

@Component({
  selector: 'app-manager',
  templateUrl: './manager.component.html',
  styleUrl: './manager.component.css'
})

export class ManagerComponent implements OnInit {
	//data: Manager[] = []
	data: any[] = []
	selectedItem: any = null
	addresses: any = []
	warehouses: any = []
	
	constructor(private managerService: ManagerService, private addressService: AddressService , private warehouseService: WarehouseService) { } 
	
	ngOnInit(): void {
		this.managerService.getManager().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		this.addressService.getAddress().subscribe(
			(data) => {
				this.addresses = data
			} 
		)
		
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.warehouses = data
			} 
		)
	}
  
	delete(id: number) : void {
	    this.managerService.deleteManager(id).subscribe(
	  		() => {
	  			//this.toastr.success('Manager is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Manager')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.managerService.createManager(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Manager created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Manager')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.managerService.updateManager(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Manager edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Manager')
	  		} 
  		);
	}
	
  
}
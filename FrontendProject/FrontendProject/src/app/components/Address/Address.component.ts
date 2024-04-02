import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AddressService } from '../../services/Address.service';
import { WarehouseService } from '../../services/Warehouse.service'
import { UserService } from '../../services/User.service'

//import { Address } from '../../models/Address'

@Component({
  selector: 'app-address',
  templateUrl: './address.component.html',
  styleUrl: './address.component.css'
})

export class AddressComponent implements OnInit {
	//data: Address[] = []
	data: any[] = []
	selectedItem: any = null
	warehouses : any = []	
	users : any = []	
	
	constructor(private addressService: AddressService, private warehouseService : WarehouseService, private userService : UserService) { } 
	
	ngOnInit(): void {
		this.addressService.getAddress().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.warehouses = data
			} 
		)
		this.userService.getUser().subscribe(
			(data) => {
				this.users = data
			} 
		)
		
	}
  
	delete(id: number) : void {
	    this.addressService.deleteAddress(id).subscribe(
	  		() => {
	  			//this.toastr.success('Address is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Address')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.addressService.createAddress(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Address created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Address')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.addressService.updateAddress(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Address edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Address')
	  		} 
  		);
	}
	
  
}

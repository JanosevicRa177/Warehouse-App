import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserService } from '../../services/User.service';
import { AddressService } from '../../services/Address.service'
import { WarehouseService } from '../../services/Warehouse.service'

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})

export class UserComponent implements OnInit {
	data: any[] = []
	selectedItem: any = null
	addresses : any = []	
	warehouses : any = []	
	
	constructor(private userService: UserService, private addressService : AddressService, private warehouseService : WarehouseService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.userService.getUser().subscribe(
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
	    this.userService.deleteUser(id).subscribe(
	  		() => {
	  			this.toastr.success('User is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete User')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.userService.createUser(entity).subscribe(
	  		() => {
	  			this.toastr.success('User created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create User')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.userService.updateUser(entity).subscribe(
	  		() => {
	  			this.toastr.success('User edited!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to edit User')
	  		} 
  		);
	}
	
  
}

import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AddressService } from '../../services/Address.service';
//import { Address } from '../../models/Address'

@Component({
  selector: 'app-address',
  templateUrl: './Address.component.html',
  styleUrl: './Address.component.css'
})

export class AddressComponent implements OnInit {
	//data: Address[] = []
	data: any[] = []
	
	constructor(private addressService: AddressService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.addressService.getAddress().subscribe(
			(data) => {
				this.data = data
			} 
		)
	}
  
	delete(id: number) : void {
	    this.addressService.deleteAddress(id).subscribe(
	  		() => {
	  			this.toastr.success('Address is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Address')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.addressService.createAddress(entity).subscribe(
	  		() => {
	  			this.toastr.success('Address created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create Address')
	  		} 
  		);
	}
  
}

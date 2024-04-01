import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { AddressService } from '../services/Address.service';
import { Address } from '../models/Address'

@Component({
  selector: 'app-address',
  templateUrl: './Address.component.html',
  stylesUrl: ['./Address.component.css']
})

export class AddressComponent implements OnInit {
	data: Address[] = []
	
	constructor(private addressService: AddressService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.addressService.getAddress()
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
  
}

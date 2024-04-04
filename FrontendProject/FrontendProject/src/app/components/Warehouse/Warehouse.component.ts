import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WarehouseService } from '../../services/Warehouse.service';
import { ReceiptItemService } from '../../services/ReceiptItem.service'
import { AddressService } from '../../services/Address.service'
import { ProductService } from '../../services/Product.service'
import { UserService } from '../../services/User.service'

@Component({
  selector: 'app-warehouse',
  templateUrl: './warehouse.component.html',
  styleUrl: './warehouse.component.css'
})

export class WarehouseComponent implements OnInit {
	data: any[] = []
	selectedItem: any = null
	receiptItems : any = []	
	addresses : any = []	
	products : any = []	
	users : any = []	
	
	constructor(private warehouseService: WarehouseService, private receiptItemService : ReceiptItemService, private addressService : AddressService, private productService : ProductService, private userService : UserService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.receiptItemService.getReceiptItem().subscribe(
			(data) => {
				this.receiptItems = data
			} 
		)
		this.addressService.getAddress().subscribe(
			(data) => {
				this.addresses = data
			} 
		)
		this.productService.getProduct().subscribe(
			(data) => {
				this.products = data
			} 
		)
		this.userService.getUser().subscribe(
			(data) => {
				this.users = data
			} 
		)
		
	}
  
	delete(id: number) : void {
	    this.warehouseService.deleteWarehouse(id).subscribe(
	  		() => {
	  			this.toastr.success('Warehouse is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Warehouse')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.warehouseService.createWarehouse(entity).subscribe(
	  		() => {
	  			this.toastr.success('Warehouse created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create Warehouse')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.warehouseService.updateWarehouse(entity).subscribe(
	  		() => {
	  			this.toastr.success('Warehouse edited!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to edit Warehouse')
	  		} 
  		);
	}
	
  
}

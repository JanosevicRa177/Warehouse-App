import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WarehouseService } from '../../services/Warehouse.service';
import { ManagerService } from '../../services/Manager.service'
import { WorkerService } from '../../services/Worker.service'
import { ReceiptItemService } from '../../services/ReceiptItem.service'
import { AddressService } from '../../services/Address.service'
import { ProductService } from '../../services/Product.service'

//import { Warehouse } from '../../models/Warehouse'

@Component({
  selector: 'app-warehouse',
  templateUrl: './warehouse.component.html',
  styleUrl: './warehouse.component.css'
})

export class WarehouseComponent implements OnInit {
	//data: Warehouse[] = []
	data: any[] = []
	selectedItem: any = null
	managers : any = []	
	workers : any = []	
	receiptItems : any = []	
	addresses : any = []	
	products : any = []	
	
	constructor(private warehouseService: WarehouseService, private managerService : ManagerService, private workerService : WorkerService, private receiptItemService : ReceiptItemService, private addressService : AddressService, private productService : ProductService) { } 
	
	ngOnInit(): void {
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.managerService.getManager().subscribe(
			(data) => {
				this.managers = data
			} 
		)
		this.workerService.getWorker().subscribe(
			(data) => {
				this.workers = data
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
		
	}
  
	delete(id: number) : void {
	    this.warehouseService.deleteWarehouse(id).subscribe(
	  		() => {
	  			//this.toastr.success('Warehouse is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Warehouse')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.warehouseService.createWarehouse(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Warehouse created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Warehouse')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.warehouseService.updateWarehouse(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Warehouse edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Warehouse')
	  		} 
  		);
	}
	
  
}

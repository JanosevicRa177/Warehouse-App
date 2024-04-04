import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ReceiptItemService } from '../../services/ReceiptItem.service';
import { ItemService } from '../../services/Item.service'
import { ReceiptService } from '../../services/Receipt.service'
import { WarehouseService } from '../../services/Warehouse.service'

@Component({
  selector: 'app-receiptitem',
  templateUrl: './receiptitem.component.html',
  styleUrl: './receiptitem.component.css'
})

export class ReceiptItemComponent implements OnInit {
	data: any[] = []
	selectedItem: any = null
	items : any = []	
	receipts : any = []	
	warehouses : any = []	
	
	constructor(private receiptItemService: ReceiptItemService, private itemService : ItemService, private receiptService : ReceiptService, private warehouseService : WarehouseService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.receiptItemService.getReceiptItem().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.itemService.getItem().subscribe(
			(data) => {
				this.items = data
			} 
		)
		this.receiptService.getReceipt().subscribe(
			(data) => {
				this.receipts = data
			} 
		)
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.warehouses = data
			} 
		)
		
	}
  
	delete(id: number) : void {
	    this.receiptItemService.deleteReceiptItem(id).subscribe(
	  		() => {
	  			this.toastr.success('ReceiptItem is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete ReceiptItem')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.receiptItemService.createReceiptItem(entity).subscribe(
	  		() => {
	  			this.toastr.success('ReceiptItem created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create ReceiptItem')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.receiptItemService.updateReceiptItem(entity).subscribe(
	  		() => {
	  			this.toastr.success('ReceiptItem edited!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to edit ReceiptItem')
	  		} 
  		);
	}
	
  
}

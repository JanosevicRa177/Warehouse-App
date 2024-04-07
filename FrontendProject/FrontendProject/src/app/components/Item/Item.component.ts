import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ItemService } from '../../services/Item.service';
import { ProductService } from '../../services/Product.service'
import { ReceiptItemService } from '../../services/ReceiptItem.service'

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrl: './item.component.css'
})

export class ItemComponent implements OnInit {
	data: any[] = []
	selectedItem: any = null
	products : any = []	
	receiptItems : any = []	
	
	constructor(private itemService: ItemService, private productService : ProductService, private receiptItemService : ReceiptItemService, private toastr: ToastrService) { } 
	
	getAll() : void {
		this.itemService.getItem().subscribe(
			(data) => {
				this.data = data
			} 
		)
	}
	
	ngOnInit(): void {
		this.getAll();
		
		this.productService.getProduct().subscribe(
			(data) => {
				this.products = data
			} 
		)
		this.receiptItemService.getReceiptItem().subscribe(
			(data) => {
				this.receiptItems = data
			} 
		)
		
	}
  
	delete(id: number) : void {
	    this.itemService.deleteItem(id).subscribe(
	  		() => {
	  			this.getAll();
	  			this.toastr.success('Item is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Item')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.itemService.createItem(entity).subscribe(
	  		() => {
  				this.getAll();
	  			this.toastr.success('Item created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create Item')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.itemService.updateItem(entity).subscribe(
	  		() => {
	  			this.getAll();
	  			this.toastr.success('Item edited!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to edit Item')
	  		} 
  		);
	}
	
  
}

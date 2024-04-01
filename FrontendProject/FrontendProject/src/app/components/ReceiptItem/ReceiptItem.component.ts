import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ReceiptItemService } from '../../services/ReceiptItem.service';
//import { ReceiptItem } from '../../models/ReceiptItem'

@Component({
  selector: 'app-receiptitem',
  templateUrl: './receiptitem.component.html',
  styleUrl: './receiptitem.component.css'
})

export class ReceiptItemComponent implements OnInit {
	//data: ReceiptItem[] = []
	data: any[] = []
	selectedItem: any = null
	
	constructor(private receiptitemService: ReceiptItemService) { } 
	
	ngOnInit(): void {
		this.receiptitemService.getReceiptItem().subscribe(
			(data) => {
				this.data = data
			} 
		)
	}
  
	delete(id: number) : void {
	    this.receiptitemService.deleteReceiptItem(id).subscribe(
	  		() => {
	  			//this.toastr.success('ReceiptItem is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete ReceiptItem')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.receiptitemService.createReceiptItem(entity).subscribe(
	  		() => {
	  			//this.toastr.success('ReceiptItem created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create ReceiptItem')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.receiptitemService.updateReceiptItem(entity).subscribe(
	  		() => {
	  			//this.toastr.success('ReceiptItem edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit ReceiptItem')
	  		} 
  		);
	}
	
  
}

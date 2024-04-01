import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ReceiptItemService } from '../../services/ReceiptItem.service';
//import { ReceiptItem } from '../../models/ReceiptItem'

@Component({
  selector: 'app-receiptitem',
  templateUrl: './ReceiptItem.component.html',
  styleUrl: './ReceiptItem.component.css'
})

export class ReceiptItemComponent implements OnInit {
	//data: ReceiptItem[] = []
	data: any[] = []
	
	constructor(private receiptitemService: ReceiptItemService, private toastr: ToastrService) { } 
	
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
	  			this.toastr.success('ReceiptItem is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete ReceiptItem')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.receiptitemService.createReceiptItem(entity).subscribe(
	  		() => {
	  			this.toastr.success('ReceiptItem created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create ReceiptItem')
	  		} 
  		);
	}
  
}

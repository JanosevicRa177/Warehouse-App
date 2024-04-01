import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ReceiptItemService } from '../services/ReceiptItem.service';
import { ReceiptItem } from '../models/ReceiptItem'

@Component({
  selector: 'app-receiptitem',
  templateUrl: './ReceiptItem.component.html',
  stylesUrl: ['./ReceiptItem.component.css']
})

export class ReceiptItemComponent implements OnInit {
	data: ReceiptItem[] = []
	
	constructor(private receiptitemService: ReceiptItemService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.receiptitemService.getReceiptItem()
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
  
}

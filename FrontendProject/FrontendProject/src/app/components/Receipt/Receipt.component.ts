import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ReceiptService } from '../../services/Receipt.service';
import { ReceiptItemService } from '../../services/ReceiptItem.service'

//import { Receipt } from '../../models/Receipt'

@Component({
  selector: 'app-receipt',
  templateUrl: './receipt.component.html',
  styleUrl: './receipt.component.css'
})

export class ReceiptComponent implements OnInit {
	//data: Receipt[] = []
	data: any[] = []
	selectedItem: any = null
	receiptItems : any = []	
	
	constructor(private receiptService: ReceiptService, private receiptItemService : ReceiptItemService) { } 
	
	ngOnInit(): void {
		this.receiptService.getReceipt().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.receiptItemService.getReceiptItem().subscribe(
			(data) => {
				this.receiptItems = data
			} 
		)
		
	}
  
	delete(id: number) : void {
	    this.receiptService.deleteReceipt(id).subscribe(
	  		() => {
	  			//this.toastr.success('Receipt is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Receipt')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.receiptService.createReceipt(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Receipt created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Receipt')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.receiptService.updateReceipt(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Receipt edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Receipt')
	  		} 
  		);
	}
	
  
}

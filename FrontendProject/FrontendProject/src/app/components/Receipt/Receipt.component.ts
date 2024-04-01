import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ReceiptService } from '../services/Receipt.service';
import { Receipt } from '../models/Receipt'

@Component({
  selector: 'app-receipt',
  templateUrl: './Receipt.component.html',
  stylesUrl: ['./Receipt.component.css']
})

export class ReceiptComponent implements OnInit {
	data: Receipt[] = []
	
	constructor(private receiptService: ReceiptService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.receiptService.getReceipt()
	}
  
	delete(id: number) : void {
	    this.receiptService.deleteReceipt(id).subscribe(
	  		() => {
	  			this.toastr.success('Receipt is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Receipt')
	  		} 
  		);
	}
  
}

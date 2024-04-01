import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ItemService } from '../services/Item.service';
import { Item } from '../models/Item'

@Component({
  selector: 'app-item',
  templateUrl: './Item.component.html',
  stylesUrl: ['./Item.component.css']
})

export class ItemComponent implements OnInit {
	data: Item[] = []
	
	constructor(private itemService: ItemService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.itemService.getItem()
	}
  
	delete(id: number) : void {
	    this.itemService.deleteItem(id).subscribe(
	  		() => {
	  			this.toastr.success('Item is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Item')
	  		} 
  		);
	}
  
}

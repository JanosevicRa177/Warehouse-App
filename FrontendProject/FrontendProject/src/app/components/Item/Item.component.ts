import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ItemService } from '../../services/Item.service';
//import { Item } from '../../models/Item'

@Component({
  selector: 'app-item',
  templateUrl: './Item.component.html',
  styleUrl: './Item.component.css'
})

export class ItemComponent implements OnInit {
	//data: Item[] = []
	data: any[] = []
	
	constructor(private itemService: ItemService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.itemService.getItem().subscribe(
			(data) => {
				this.data = data
			} 
		)
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
	
	create(entity: any) : void {
	    this.itemService.createItem(entity).subscribe(
	  		() => {
	  			this.toastr.success('Item created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create Item')
	  		} 
  		);
	}
  
}

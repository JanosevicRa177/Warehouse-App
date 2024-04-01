import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ItemService } from '../../services/Item.service';
//import { Item } from '../../models/Item'

@Component({
  selector: 'app-item',
  templateUrl: './item.component.html',
  styleUrl: './item.component.css'
})

export class ItemComponent implements OnInit {
	//data: Item[] = []
	data: any[] = []
	selectedItem: any = null
	
	constructor(private itemService: ItemService ) { } 
	
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
	  			//this.toastr.success('Item is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Item')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.itemService.createItem(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Item created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Item')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.itemService.updateItem(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Item edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Item')
	  		} 
  		);
	}
	
  
}

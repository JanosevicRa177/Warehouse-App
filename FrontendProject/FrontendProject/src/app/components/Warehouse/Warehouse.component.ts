import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WarehouseService } from '../services/Warehouse.service';
import { Warehouse } from '../models/Warehouse'

@Component({
  selector: 'app-warehouse',
  templateUrl: './Warehouse.component.html',
  stylesUrl: ['./Warehouse.component.css']
})

export class WarehouseComponent implements OnInit {
	data: Warehouse[] = []
	
	constructor(private warehouseService: WarehouseService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.warehouseService.getWarehouse()
	}
  
	delete(id: number) : void {
	    this.warehouseService.deleteWarehouse(id).subscribe(
	  		() => {
	  			this.toastr.success('Warehouse is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Warehouse')
	  		} 
  		);
	}
  
}

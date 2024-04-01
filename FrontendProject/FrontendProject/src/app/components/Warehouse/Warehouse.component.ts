import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WarehouseService } from '../../services/Warehouse.service';
//import { Warehouse } from '../../models/Warehouse'

@Component({
  selector: 'app-warehouse',
  templateUrl: './Warehouse.component.html',
  styleUrl: './Warehouse.component.css'
})

export class WarehouseComponent implements OnInit {
	//data: Warehouse[] = []
	data: any[] = []
	
	constructor(private warehouseService: WarehouseService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.data = data
			} 
		)
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
	
	create(entity: any) : void {
	    this.warehouseService.createWarehouse(entity).subscribe(
	  		() => {
	  			this.toastr.success('Warehouse created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create Warehouse')
	  		} 
  		);
	}
  
}

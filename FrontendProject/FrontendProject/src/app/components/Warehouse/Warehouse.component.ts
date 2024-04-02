import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WarehouseService } from '../../services/Warehouse.service';
import { ManagerService } from '../../services/Manager.service'

//import { Warehouse } from '../../models/Warehouse'

@Component({
  selector: 'app-warehouse',
  templateUrl: './warehouse.component.html',
  styleUrl: './warehouse.component.css'
})

export class WarehouseComponent implements OnInit {
	//data: Warehouse[] = []
	data: any[] = []
	selectedItem: any = null
	
	managers : any = []	
	
	constructor(private warehouseService: WarehouseService
	, private managerService : ManagerService	
							) { } 
	
	ngOnInit(): void {
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.managerService.getManager().subscribe(
			(data) => {
				this.managers = data
			} 
		)
		
	}
  
	delete(id: number) : void {
	    this.warehouseService.deleteWarehouse(id).subscribe(
	  		() => {
	  			//this.toastr.success('Warehouse is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Warehouse')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.warehouseService.createWarehouse(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Warehouse created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Warehouse')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.warehouseService.updateWarehouse(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Warehouse edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Warehouse')
	  		} 
  		);
	}
	
  
}

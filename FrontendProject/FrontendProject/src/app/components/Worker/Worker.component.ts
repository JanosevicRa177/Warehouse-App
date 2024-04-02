import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WorkerService } from '../../services/Worker.service';
import { WarehouseService } from '../../services/Warehouse.service'
import { AddressService } from '../../services/Address.service'

//import { Worker } from '../../models/Worker'

@Component({
  selector: 'app-worker',
  templateUrl: './worker.component.html',
  styleUrl: './worker.component.css'
})

export class WorkerComponent implements OnInit {
	//data: Worker[] = []
	data: any[] = []
	selectedItem: any = null
	warehouses : any = []	
	addresses : any = []	
	
	constructor(private workerService: WorkerService, private warehouseService : WarehouseService, private addressService : AddressService) { } 
	
	ngOnInit(): void {
		this.workerService.getWorker().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.warehouses = data
			} 
		)
		this.addressService.getAddress().subscribe(
			(data) => {
				this.addresses = data
			} 
		)
		
	}
  
	delete(id: number) : void {
	    this.workerService.deleteWorker(id).subscribe(
	  		() => {
	  			//this.toastr.success('Worker is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Worker')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.workerService.createWorker(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Worker created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Worker')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.workerService.updateWorker(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Worker edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Worker')
	  		} 
  		);
	}
	
  
}

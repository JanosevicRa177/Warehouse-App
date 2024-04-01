import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WorkerService } from '../../services/Worker.service';
//import { Worker } from '../../models/Worker'

@Component({
  selector: 'app-worker',
  templateUrl: './Worker.component.html',
  styleUrl: './Worker.component.css'
})

export class WorkerComponent implements OnInit {
	//data: Worker[] = []
	data: any[] = []
	
	constructor(private workerService: WorkerService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.workerService.getWorker().subscribe(
			(data) => {
				this.data = data
			} 
		)
	}
  
	delete(id: number) : void {
	    this.workerService.deleteWorker(id).subscribe(
	  		() => {
	  			this.toastr.success('Worker is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Worker')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.workerService.createWorker(entity).subscribe(
	  		() => {
	  			this.toastr.success('Worker created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create Worker')
	  		} 
  		);
	}
  
}

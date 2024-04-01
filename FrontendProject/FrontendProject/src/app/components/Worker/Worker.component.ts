import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { WorkerService } from '../services/Worker.service';
import { Worker } from '../models/Worker'

@Component({
  selector: 'app-worker',
  templateUrl: './Worker.component.html',
  stylesUrl: ['./Worker.component.css']
})

export class WorkerComponent implements OnInit {
	data: Worker[] = []
	
	constructor(private workerService: WorkerService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.workerService.getWorker()
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
  
}

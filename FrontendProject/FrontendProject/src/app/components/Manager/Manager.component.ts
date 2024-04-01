import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ManagerService } from '../../services/Manager.service';
//import { Manager } from '../../models/Manager'

@Component({
  selector: 'app-manager',
  templateUrl: './Manager.component.html',
  styleUrl: './Manager.component.css'
})

export class ManagerComponent implements OnInit {
	//data: Manager[] = []
	data: any[] = []
	
	constructor(private managerService: ManagerService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.managerService.getManager().subscribe(
			(data) => {
				this.data = data
			} 
		)
	}
  
	delete(id: number) : void {
	    this.managerService.deleteManager(id).subscribe(
	  		() => {
	  			this.toastr.success('Manager is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Manager')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.managerService.createManager(entity).subscribe(
	  		() => {
	  			this.toastr.success('Manager created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create Manager')
	  		} 
  		);
	}
  
}

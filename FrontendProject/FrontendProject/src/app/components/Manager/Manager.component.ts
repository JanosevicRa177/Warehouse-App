import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ManagerService } from '../services/Manager.service';
import { Manager } from '../models/Manager'

@Component({
  selector: 'app-manager',
  templateUrl: './Manager.component.html',
  stylesUrl: ['./Manager.component.css']
})

export class ManagerComponent implements OnInit {
	data: Manager[] = []
	
	constructor(private managerService: ManagerService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.managerService.getManager()
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
  
}

import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserService } from '../services/User.service';
import { User } from '../models/User'

@Component({
  selector: 'app-user',
  templateUrl: './User.component.html',
  stylesUrl: ['./User.component.css']
})

export class UserComponent implements OnInit {
	data: User[] = []
	
	constructor(private userService: UserService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.userService.getUser()
	}
  
	delete(id: number) : void {
	    this.userService.deleteUser(id).subscribe(
	  		() => {
	  			this.toastr.success('User is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete User')
	  		} 
  		);
	}
  
}

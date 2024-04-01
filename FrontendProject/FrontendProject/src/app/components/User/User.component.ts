import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserService } from '../../services/User.service';
//import { User } from '../../models/User'

@Component({
  selector: 'app-user',
  templateUrl: './User.component.html',
  styleUrl: './User.component.css'
})

export class UserComponent implements OnInit {
	//data: User[] = []
	data: any[] = []
	
	constructor(private userService: UserService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.userService.getUser().subscribe(
			(data) => {
				this.data = data
			} 
		)
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
	
	create(entity: any) : void {
	    this.userService.createUser(entity).subscribe(
	  		() => {
	  			this.toastr.success('User created!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to create User')
	  		} 
  		);
	}
  
}

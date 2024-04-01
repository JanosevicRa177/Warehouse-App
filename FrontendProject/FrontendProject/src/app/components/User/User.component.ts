import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { UserService } from '../../services/User.service';
//import { User } from '../../models/User'

@Component({
  selector: 'app-user',
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})

export class UserComponent implements OnInit {
	//data: User[] = []
	data: any[] = []
	selectedItem: any = null
	
	constructor(private userService: UserService) { } 
	
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
	  			//this.toastr.success('User is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete User')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.userService.createUser(entity).subscribe(
	  		() => {
	  			//this.toastr.success('User created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create User')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.userService.updateUser(entity).subscribe(
	  		() => {
	  			//this.toastr.success('User edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit User')
	  		} 
  		);
	}
	
  
}

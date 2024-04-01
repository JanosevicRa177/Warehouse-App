import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ${class.name}Service } from '../../services/${class.name}.service';
//import { ${class.name} } from '../../models/${class.name}'

@Component({
  selector: 'app-${class.name?lower_case}',
  templateUrl: './${class.name?lower_case}.component.html',
  styleUrl: './${class.name?lower_case}.component.css'
})

export class ${class.name}Component implements OnInit {
	//data: ${class.name}[] = []
	data: any[] = []
	selectedItem: any = null
	
	constructor(private ${class.name?lower_case}Service: ${class.name}Service) { } 
	
	ngOnInit(): void {
		this.${class.name?lower_case}Service.get${class.name}().subscribe(
			(data) => {
				this.data = data
			} 
		)
	}
  
    <#if class.crud.delete == true >
	delete(id: number) : void {
	    this.${class.name?lower_case}Service.delete${class.name}(id).subscribe(
	  		() => {
	  			//this.toastr.success('${class.name} is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete ${class.name}')
	  		} 
  		);
	}
	</#if>  
	
	<#if class.crud.create == true >
	create(entity: any) : void {
	    this.${class.name?lower_case}Service.create${class.name}(entity).subscribe(
	  		() => {
	  			//this.toastr.success('${class.name} created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create ${class.name}')
	  		} 
  		);
	}
	</#if> 
	
	<#if class.crud.update == true >
	edit(entity: any) : void {
	    this.${class.name?lower_case}Service.update${class.name}(entity).subscribe(
	  		() => {
	  			//this.toastr.success('${class.name} edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit ${class.name}')
	  		} 
  		);
	}
	</#if> 
	
  
}

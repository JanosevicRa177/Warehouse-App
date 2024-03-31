import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ${class.name}Service } from '../services/${class.name}.service';
import { ${class.name} } from '../models/${class.name}'

@Component({
  selector: 'app-${class.name?lower_case}',
  templateUrl: './${class.name}.component.html',
  stylesUrl: ['./${class.name}.component.css']
})

export class ${class.name}Component implements OnInit {
	data: ${class.name}[] = []
	
	constructor(private ${class.name?lower_case}Service: ${class.name}Service, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.${class.name?lower_case}Service.get${class.name}()
	}
  
    <#if class.crud.delete == true >
	delete(id: number) : void {
	    this.${class.name?lower_case}Service.delete${class.name}(id).subscribe(
	  		() => {
	  			this.toastr.success('${class.name} is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete ${class.name}')
	  		} 
  		);
	}
	</#if>  
  
}

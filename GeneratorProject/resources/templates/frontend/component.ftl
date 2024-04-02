import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ${class.name}Service } from '../../services/${class.name}.service';
<#list properties as property>
	<#if property.isClass >   
import { ${property.type.name}Service } from '../../services/${property.type.name}.service'
	</#if>    
</#list>

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
	
	<#list properties as property><#if property.isClass >   
	<#if property.type.name?ends_with("s")>${property.type.name?uncap_first}es<#elseif property.type.name?ends_with("y")>${property.type.name?uncap_first?substring(0, property.type.name?length - 1)}ies<#else>${property.type.name?uncap_first}s</#if> : any = []	
	</#if></#list>
	
	constructor(private ${class.name?uncap_first}Service: ${class.name}Service
	<#list properties as property>
				<#if property.isClass >   
	, private ${property.type.name?lower_case}Service : ${property.type.name}Service	
			</#if>    
	</#list>) { } 
	
	ngOnInit(): void {
		this.${class.name?uncap_first}Service.get${class.name}().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		<#list properties as property>
				<#if property.isClass >   
		this.${property.type.name?uncap_first}Service.get${property.type.name}().subscribe(
			(data) => {
				this.${property.type.name?uncap_first}s = data
			} 
		)
			</#if>    
		</#list>
		
	}
  
    <#if class.crud.delete == true >
	delete(id: number) : void {
	    this.${class.name?uncap_first}Service.delete${class.name}(id).subscribe(
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
	    this.${class.name?uncap_first}Service.create${class.name}(entity).subscribe(
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
	    this.${class.name?uncap_first}Service.update${class.name}(entity).subscribe(
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

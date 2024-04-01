import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ProductService } from '../../services/Product.service';
import { WarehouseService } from '../../services/Warehouse.service'
//import { Product } from '../../models/Product'

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrl: './product.component.css'
})

export class ProductComponent implements OnInit {
	//data: Product[] = []
	data: any[] = []
	selectedItem: any = null
	warehouses: any = []
	
	constructor(private productService: ProductService , private warehouseService: WarehouseService) { } 
	
	ngOnInit(): void {
		this.productService.getProduct().subscribe(
			(data) => {
				this.data = data
			} 
		)
		
		
		this.warehouseService.getWarehouse().subscribe(
			(data) => {
				this.warehouses = data
			} 
		)
	}
  
	delete(id: number) : void {
	    this.productService.deleteProduct(id).subscribe(
	  		() => {
	  			//this.toastr.success('Product is deleted!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to delete Product')
	  		} 
  		);
	}
	
	create(entity: any) : void {
	    this.productService.createProduct(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Product created!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to create Product')
	  		} 
  		);
	}
	
	edit(entity: any) : void {
	    this.productService.updateProduct(entity).subscribe(
	  		() => {
	  			//this.toastr.success('Product edited!');
	  		},
	  		(error : any) => {
	  			//this.toastr.error('Failed to edit Product')
	  		} 
  		);
	}
	
  
}
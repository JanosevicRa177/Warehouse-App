import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { ProductService } from '../services/Product.service';
import { Product } from '../models/Product'

@Component({
  selector: 'app-product',
  templateUrl: './Product.component.html',
  stylesUrl: ['./Product.component.css']
})

export class ProductComponent implements OnInit {
	data: Product[] = []
	
	constructor(private productService: ProductService, private toastr: ToastrService) { } 
	
	ngOnInit(): void {
		this.data = this.productService.getProduct()
	}
  
	delete(id: number) : void {
	    this.productService.deleteProduct(id).subscribe(
	  		() => {
	  			this.toastr.success('Product is deleted!');
	  		},
	  		(error : any) => {
	  			this.toastr.error('Failed to delete Product')
	  		} 
  		);
	}
  
}

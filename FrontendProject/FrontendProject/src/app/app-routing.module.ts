import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { WarehouseComponent } from './components/warehouse/warehouse.component';    
import { ProductComponent } from './components/product/product.component';    
import { ItemComponent } from './components/item/item.component';    
import { ReceiptComponent } from './components/receipt/receipt.component';    
import { UserComponent } from './components/user/user.component';    
import { ReceiptItemComponent } from './components/receiptitem/receiptitem.component';    
import { AddressComponent } from './components/address/address.component';    

const routes: Routes = [
	{
		path: 'warehouse',
		component: WarehouseComponent
	},    
	{
		path: 'product',
		component: ProductComponent
	},    
	{
		path: 'item',
		component: ItemComponent
	},    
	{
		path: 'receipt',
		component: ReceiptComponent
	},    
	{
		path: 'user',
		component: UserComponent
	},    
	{
		path: 'receiptitem',
		component: ReceiptItemComponent
	},    
	{
		path: 'address',
		component: AddressComponent
	},    
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
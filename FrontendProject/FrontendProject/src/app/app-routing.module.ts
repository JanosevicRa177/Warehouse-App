import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { WarehouseComponent } from './components/Warehouse/warehouse.component';    
import { ManagerComponent } from './components/Manager/manager.component';    
import { ProductComponent } from './components/Product/product.component';    
import { ItemComponent } from './components/Item/item.component';    
import { ReceiptComponent } from './components/Receipt/receipt.component';    
import { WorkerComponent } from './components/Worker/worker.component';    
import { UserComponent } from './components/User/user.component';    
import { ReceiptItemComponent } from './components/ReceiptItem/receiptitem.component';    
import { AddressComponent } from './components/Address/address.component';    

const routes: Routes = [
	{
		path: 'warehouse',
		component: WarehouseComponent
	},    
	{
		path: 'manager',
		component: ManagerComponent
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
		path: 'worker',
		component: WorkerComponent
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
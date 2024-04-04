import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { WarehouseComponent } from './components/Warehouse/warehouse.component';    
import { ProductComponent } from './components/Product/product.component';    
import { ItemComponent } from './components/Item/item.component';    
import { ReceiptComponent } from './components/Receipt/receipt.component';    
import { UserComponent } from './components/User/user.component';    
import { ReceiptItemComponent } from './components/ReceiptItem/receiptitem.component';    
import { AddressComponent } from './components/Address/address.component';    

@NgModule({
  declarations: [
    AppComponent,
		WarehouseComponent,  
		ProductComponent,  
		ItemComponent,  
		ReceiptComponent,  
		UserComponent,  
		ReceiptItemComponent,  
		AddressComponent,  
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
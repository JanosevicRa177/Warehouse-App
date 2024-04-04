import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms'
import { HttpClientModule } from '@angular/common/http'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'; 
import { ToastrModule } from 'ngx-toastr';
import { WarehouseComponent } from './components/warehouse/warehouse.component';    
import { ProductComponent } from './components/product/product.component';    
import { ItemComponent } from './components/item/item.component';    
import { ReceiptComponent } from './components/receipt/receipt.component';    
import { UserComponent } from './components/user/user.component';    
import { ReceiptItemComponent } from './components/receiptitem/receiptitem.component';    
import { AddressComponent } from './components/address/address.component';    

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
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot({
      positionClass:'toast-top-right',
      preventDuplicates:true
    })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
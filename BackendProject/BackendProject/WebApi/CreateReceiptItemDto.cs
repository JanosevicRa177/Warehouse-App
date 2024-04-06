using BackendProject.Model;



class CreateReceiptItemDto {
  	public Item Item {get; public set;}  
  	public Receipt Receipts {get; public set;}  
  	public Warehouse Warehouse {get; public set;}  
  	public int Price {get; public set;}   
		
	public ReceiptItem toEntity() {
		ReceiptItem obj = new ReceiptItem();
      	obj.Item = Item; 
      	obj.Receipts = Receipts; 
      	obj.Warehouse = Warehouse; 
      	obj.Price = Price;  
	}
}


using BackendProject.Model;



class CreateProductDto {
  	public Item Item {get; public set;}  
  	public int Price {get; public set;}   
  	public Warehouse Warehouse {get; public set;}  
		
	public Product toEntity() {
		Product obj = new Product();
      	obj.Item = Item; 
      	obj.Price = Price;  
      	obj.Warehouse = Warehouse; 
	}
}


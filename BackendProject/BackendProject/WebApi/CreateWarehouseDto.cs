using BackendProject.Model;



class CreateWarehouseDto {
  	public Address Address {get; public set;}  
  	public string Name {get; public set;}   
  	public int SizeInM2 {get; public set;}   
		
	public Warehouse toEntity() {
		Warehouse obj = new Warehouse();
      	obj.Address = Address; 
      	obj.Name = Name;  
      	obj.SizeInM2 = SizeInM2;  
	}
}


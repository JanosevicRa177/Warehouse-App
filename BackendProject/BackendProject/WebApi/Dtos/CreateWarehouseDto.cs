using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;

public class CreateWarehouseDto {
      public List<ReceiptItem> ReceiptItems {get; set;} = new();
      public int AddressId {get; set;}
      public Address Address {get; set;}  
      public string Name {get; set;}   
      public int SizeInM2 {get; set;}   
      public List<Product> Products {get; set;} = new();
      public List<User> Workers {get; set;} = new();
		
	public Warehouse ToEntity() {
		var warehouse = new Warehouse(AddressId , Name, SizeInM2);
		return warehouse;
	}
}


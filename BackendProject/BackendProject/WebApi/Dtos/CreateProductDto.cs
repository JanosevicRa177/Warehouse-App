using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;

public class CreateProductDto {
      public int ItemId {get; set;}
      public Item Item {get; set;}  
      public int Price {get; set;}   
      public int WarehouseId {get; set;}
      public Warehouse Warehouse {get; set;}  
		
	public Product ToEntity() {
		var product = new Product(ItemId , Price, WarehouseId );
		return product;
	}
}


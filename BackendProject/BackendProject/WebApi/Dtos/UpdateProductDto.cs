using BackendProject.Model;

namespace BackendProject.WebApi.Dtos;


public class UpdateProductDto {
      public int ItemId {get; set;}
      public int Price {get; set;}   
      public int WarehouseId {get; set;}
	
	public Product ToEntity() {
		var product = new Product(ItemId , Price, WarehouseId );
		
		return product;
	}
}

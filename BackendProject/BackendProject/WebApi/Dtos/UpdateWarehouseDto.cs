using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;


public class UpdateWarehouseDto {
      public List<int> ReceiptItemsIds {get; set;} = new();
      public int AddressId {get; set;}
      public string Name {get; set;}   
      public int SizeInM2 {get; set;}   
      public List<int> ProductsIds {get; set;} = new();
      public List<int> WorkersIds {get; set;} = new();
	
	public Warehouse ToEntity() {
		var warehouse = new Warehouse(AddressId , Name, SizeInM2);
		warehouse.ReceiptItems = ReceiptItemsIds.Select(id => new ReceiptItem
		{
			Id = id
		}).ToList();
		warehouse.Products = ProductsIds.Select(id => new Product
		{
			Id = id
		}).ToList();
		warehouse.Workers = WorkersIds.Select(id => new User
		{
			Id = id
		}).ToList();
		
		return warehouse;
	}
}

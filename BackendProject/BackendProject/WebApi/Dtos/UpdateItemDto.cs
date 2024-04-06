using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;


public class UpdateItemDto {
      public List<int> ProductsIds {get; set;} = new();
      public List<int> ReceiptItemsIds {get; set;} = new();
      public ItemType ItemType {get; set;}   
      public string ItemName {get; set;}   
	
	public Item ToEntity() {
		var item = new Item(ItemType, ItemName);
		item.Products = ProductsIds.Select(id => new Product
		{
			Id = id
		}).ToList();
		item.ReceiptItems = ReceiptItemsIds.Select(id => new ReceiptItem
		{
			Id = id
		}).ToList();
		
		return item;
	}
}

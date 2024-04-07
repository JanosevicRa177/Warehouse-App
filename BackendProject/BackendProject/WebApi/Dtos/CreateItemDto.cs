using BackendProject.Model;

namespace BackendProject.WebApi.Dtos;

public class CreateItemDto {
      public List<int> ProductsIds {get; set;} = new();
      public List<int> ReceiptItemsIds {get; set;} = new();
      public string ItemName {get; set;}   
		
	public Item ToEntity() {
		var item = new Item(ItemName);
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


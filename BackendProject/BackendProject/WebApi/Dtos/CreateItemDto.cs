using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;

public class CreateItemDto {
      public List<Product> Products {get; set;} = new();
      public List<ReceiptItem> ReceiptItems {get; set;} = new();
      public ItemType ItemType {get; set;}   
      public string ItemName {get; set;}   
		
	public Item ToEntity() {
		var item = new Item(ItemType, ItemName);
		return item;
	}
}


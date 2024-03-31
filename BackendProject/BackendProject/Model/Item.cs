using BackendProject.Model.Enum;

namespace BackendProject.Model;

public class Item : Entity
{  
      public List<Product> Products {get; private set;} = new();
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      public ItemType ItemType {get; private set;}
	public Item(){ }
	public Item(ItemType itemType) 
	{
      	ItemType = itemType;
	}
}
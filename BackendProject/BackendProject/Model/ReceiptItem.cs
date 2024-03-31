
namespace BackendProject.Model;

public class ReceiptItem : Entity
{  
      public Guid ItemId {get; private set;} 
      public Item Item {get; private set;}
      public Receipt Receipts {get; private set;}
      public Warehouse Warehouse {get; private set;}
      public int Price {get; private set;}
	public ReceiptItem(){ }
	public ReceiptItem(Guid itemId , Receipt receipts, Warehouse warehouse, int price) 
	{
      	ItemId = itemId;
      	Receipts = receipts;
      	Warehouse = warehouse;
      	Price = price;
	}
}

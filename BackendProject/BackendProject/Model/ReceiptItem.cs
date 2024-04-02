
namespace BackendProject.Model;

public class ReceiptItem : Entity
{  
      public Guid ItemId {get; private set;} 
      public Item Item {get; private set;}
      public Guid ReceiptsId {get; private set;} 
      public Receipt Receipts {get; private set;}
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
      public int Price {get; private set;}
	public ReceiptItem(){ }
	public ReceiptItem(Guid itemId , Guid receiptsId , Guid warehouseId , int price) 
	{
      	ItemId = itemId;
      	ReceiptsId = receiptsId;
      	WarehouseId = warehouseId;
      	Price = price;
	}
}

using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("receipt_item")]
public class ReceiptItem : Entity
{  
	 [Column("item_id")] 
      public Guid ItemId {get; private set;}
      public Item Item {get; private set;}  
	 [Column("receipt_id")] 
      public Guid ReceiptsId {get; private set;}
      public Receipt Receipts {get; private set;}  
	 [Column("warehouse_id")] 
      public Guid WarehouseId {get; private set;}
      public Warehouse Warehouse {get; private set;}  
      [Column("receipt_price")] 
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

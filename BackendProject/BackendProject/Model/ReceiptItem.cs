using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("receipt_item")]
public class ReceiptItem
{  
	[Column("id")] 
	public int Id {get; set;}
	[Column("item_id")] 
    public int ItemId {get; set;}
    public Item Item {get; set;}  
	[Column("receipt_id")] 
    public int ReceiptsId {get; set;}
    public Receipt Receipts {get; set;}  
	[Column("warehouse_id")] 
    public int WarehouseId {get; set;}
    public Warehouse Warehouse {get; set;}  
    [Column("receipt_price")] 
    public int Price {get; set;}   
	public ReceiptItem(){ }
	public ReceiptItem(int itemId , int receiptsId , int warehouseId , int price) 
	{
      	ItemId = itemId;
      	ReceiptsId = receiptsId;
      	WarehouseId = warehouseId;
      	Price = price;
	}


	public void Update(ReceiptItem entity) {
		Price = entity.Price;
	}
}

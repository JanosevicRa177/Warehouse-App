using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("product")]
public class Product
{  
	[Column("id")] 
	public int Id {get; set;}
	[Column("item_id")] 
    public int ItemId {get; set;}
    public Item Item {get; set;}  
    [Column("price")] 
    public int Price {get; set;}   
	[Column("warehouse_id")] 
    public int WarehouseId {get; set;}
    public Warehouse Warehouse {get; set;}  
	public Product(){ }
	public Product(int itemId , int price, int warehouseId ) 
	{
      	ItemId = itemId;
      	Price = price;
      	WarehouseId = warehouseId;
	}


	public void Update(Product entity) {
		Price = entity.Price;
	}
}

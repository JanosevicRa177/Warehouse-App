using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("product")]
public class Product : Entity
{  
	 [Column("item_id")] 
      public Guid ItemId {get; private set;}
      public Item Item {get; private set;}  
      [Column("price")] 
      public int Price {get; private set;}   
	 [Column("warehouse_id")] 
      public Guid WarehouseId {get; private set;}
      public Warehouse Warehouse {get; private set;}  
	public Product(){ }
	public Product(Guid itemId , int price, Guid warehouseId ) 
	{
      	ItemId = itemId;
      	Price = price;
      	WarehouseId = warehouseId;
	}


public void Update(Product entity) {
	Price = entity.Price;
}
}

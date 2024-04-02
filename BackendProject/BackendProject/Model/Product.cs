
namespace BackendProject.Model;

public class Product : Entity
{  
      public Guid ItemId {get; private set;} 
      public Item Item {get; private set;}
      public int Price {get; private set;}
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
	public Product(){ }
	public Product(Guid itemId , int price, Guid warehouseId ) 
	{
      	ItemId = itemId;
      	Price = price;
      	WarehouseId = warehouseId;
	}
}

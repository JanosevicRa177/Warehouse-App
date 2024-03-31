
namespace BackendProject.Model;

public class Worker : Entity
{  
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
	public Worker(){ }
	public Worker(Guid warehouseId ) 
	{
      	WarehouseId = warehouseId;
	}
}

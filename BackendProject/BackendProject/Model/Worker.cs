
namespace BackendProject.Model;

public class Worker 
{  
      public Guid Id {get; private set;}
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
}

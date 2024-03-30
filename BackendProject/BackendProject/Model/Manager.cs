
namespace BackendProject.Model;

public class Manager 
{  
      public Guid Id {get; private set;}
      public List<Warehouse> Warehouses {get; private set;} = new();
}

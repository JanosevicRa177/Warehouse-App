
namespace BackendProject.Model;

public class Manager : Entity
{  
      public List<Warehouse> Warehouses {get; private set;} = new();
	public Manager(){ }
}

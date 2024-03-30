
namespace BackendProject.Model;

public class Product 
{  
      public Guid Id {get; private set;}
      public Guid ItemId {get; private set;} 
      public Item Item {get; private set;}
      public int Price {get; private set;}
      public Warehouse Warehouse {get; private set;}
}

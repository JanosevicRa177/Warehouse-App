
namespace BackendProject.Model;

public class Address 
{  
      public Guid Id {get; private set;}
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
      public User User {get; private set;}
      public string Country {get; private set;}
      public string City {get; private set;}
      public string Street {get; private set;}
      public int StreetNumber {get; private set;}
}

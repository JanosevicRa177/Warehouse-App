
namespace BackendProject.Model;

public class Worker : Entity
{  
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
      public string FirstName {get; private set;}
      public string Contact {get; private set;}
      public Guid AddressId {get; private set;} 
      public Address Address {get; private set;}
      public string Email {get; private set;}
	public Worker(){ }
	public Worker(Guid warehouseId , string firstName, string contact, Guid addressId , string email) 
	{
      	WarehouseId = warehouseId;
      	FirstName = firstName;
      	Contact = contact;
      	AddressId = addressId;
      	Email = email;
	}
}

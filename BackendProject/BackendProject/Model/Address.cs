
namespace BackendProject.Model;

public class Address : Entity
{  
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
      public Guid UserId {get; private set;} 
      public User User {get; private set;}
      public string Country {get; private set;}
      public string City {get; private set;}
      public string Street {get; private set;}
      public int StreetNumber {get; private set;}
	public Address(){ }
	public Address(Guid warehouseId , Guid userId , string country, string city, string street, int streetNumber) 
	{
      	WarehouseId = warehouseId;
      	UserId = userId;
      	Country = country;
      	City = city;
      	Street = street;
      	StreetNumber = streetNumber;
	}
}

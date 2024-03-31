
namespace BackendProject.Model;

public class Address : Entity
{  
      public Guid WarehouseId {get; private set;} 
      public Warehouse Warehouse {get; private set;}
      public User User {get; private set;}
      public string Country {get; private set;}
      public string City {get; private set;}
      public string Street {get; private set;}
      public int StreetNumber {get; private set;}
	public Address(){ }
	public Address(Guid warehouseId , User user, string country, string city, string street, int streetNumber) 
	{
      	WarehouseId = warehouseId;
      	User = user;
      	Country = country;
      	City = city;
      	Street = street;
      	StreetNumber = streetNumber;
	}
}

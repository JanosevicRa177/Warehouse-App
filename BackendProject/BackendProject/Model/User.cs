using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("")]
public class User : Entity
{  
      [Column("first_name")] 
      public string FirstName {get; private set;}   
      [Column("contact")] 
      public string Contact {get; private set;}   
	 [Column("address_id")] 
      public Guid AddressId {get; private set;}
      public Address Address {get; private set;}  
      [Column("email")] 
      public string Email {get; private set;}   
	 [Column("warehouse_id")] 
      public Guid WarehouseId {get; private set;}
      public Warehouse Warehouse {get; private set;}  
	public User(){ }
	public User(string firstName, string contact, Guid addressId , string email, Guid warehouseId ) 
	{
      	FirstName = firstName;
      	Contact = contact;
      	AddressId = addressId;
      	Email = email;
      	WarehouseId = warehouseId;
	}
}

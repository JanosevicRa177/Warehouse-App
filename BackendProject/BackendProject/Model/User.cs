using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("")]
public class User : Entity
{  
      [Column("first_name")] 
      public string FirstName {get; set;}   
      [Column("contact")] 
      public string Contact {get; set;}   
	 [Column("address_id")] 
      public int AddressId {get; set;}
      public Address Address {get; set;}  
      [Column("email")] 
      public string Email {get; set;}   
	 [Column("warehouse_id")] 
      public int WarehouseId {get; set;}
      public Warehouse Warehouse {get; set;}  
	public User(){ }
	public User(string firstName, string contact, int addressId , string email, int warehouseId ) 
	{
      	FirstName = firstName;
      	Contact = contact;
      	AddressId = addressId;
      	Email = email;
      	WarehouseId = warehouseId;
	}


public void Update(User entity) {
	FirstName = entity.FirstName;
	Contact = entity.Contact;
	Email = entity.Email;
}
}

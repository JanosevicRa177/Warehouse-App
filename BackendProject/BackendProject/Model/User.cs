using System.ComponentModel.DataAnnotations.Schema;   
using BackendProject.WebApi.Dtos;

namespace BackendProject.Model;


[Table("user")]
public class User
{  
	[Column("id")] 
	public int Id {get; set;}
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
	public void Update(UpdateUserDto updateUserDto) {
		FirstName = updateUserDto.FirstName;
		Contact = updateUserDto.Contact;
		Email = updateUserDto.Email;
	}
}

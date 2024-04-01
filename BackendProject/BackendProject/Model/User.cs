
namespace BackendProject.Model;

public class User : Entity
{  
      public string FirstName {get; private set;}
      public string Contact {get; private set;}
      public Guid AddressId {get; private set;} 
      public Address Address {get; private set;}
      public string Email {get; private set;}
	public User(){ }
	public User(string firstName, string contact, Guid addressId , string email) 
	{
      	FirstName = firstName;
      	Contact = contact;
      	AddressId = addressId;
      	Email = email;
	}
}

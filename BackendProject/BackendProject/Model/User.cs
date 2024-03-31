
namespace BackendProject.Model;

public class User : Entity
{  
      public string Email {get; private set;}
      public string FirstName {get; private set;}
      public Guid AddressId {get; private set;} 
      public Address Address {get; private set;}
      public string Contact {get; private set;}
	public User(){ }
	public User(string email, string firstName, Guid addressId , string contact) 
	{
      	Email = email;
      	FirstName = firstName;
      	AddressId = addressId;
      	Contact = contact;
	}
}

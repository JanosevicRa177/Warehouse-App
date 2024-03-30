
namespace BackendProject.Model;

public class User 
{  
      public Guid Id {get; private set;}
      public string Email {get; private set;}
      public string FirstName {get; private set;}
      public Guid AddressId {get; private set;} 
      public Address Address {get; private set;}
      public string Contact {get; private set;}
}

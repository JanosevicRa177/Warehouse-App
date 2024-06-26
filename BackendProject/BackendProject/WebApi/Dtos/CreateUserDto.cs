using BackendProject.Model;

namespace BackendProject.WebApi.Dtos;

public class CreateUserDto {
      public string FirstName {get; set;}   
      public string Contact {get; set;}   
      public int AddressId {get; set;}
      public string Email {get; set;}   
      public int WarehouseId {get; set;}
		
	public User ToEntity() {
		var user = new User(FirstName, Contact, AddressId , Email, WarehouseId );
		return user;
	}
}


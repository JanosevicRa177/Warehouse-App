using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;


public class UpdateUserDto {
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

using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;


public class UpdateAddressDto {
      public string Country {get; set;}   
      public string City {get; set;}   
      public string Street {get; set;}   
      public int StreetNumber {get; set;}   
	
	public Address ToEntity() {
		var address = new Address(Country, City, Street, StreetNumber);
		
		return address;
	}
}

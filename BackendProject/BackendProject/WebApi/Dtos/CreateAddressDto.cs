using BackendProject.Model;

namespace BackendProject.WebApi.Dtos;

public class CreateAddressDto {
      public string Country {get; set;}   
      public string City {get; set;}   
      public string Street {get; set;}   
      public int StreetNumber {get; set;}   
		
	public Address ToEntity() {
		var address = new Address(Country, City, Street, StreetNumber);
		return address;
	}
}


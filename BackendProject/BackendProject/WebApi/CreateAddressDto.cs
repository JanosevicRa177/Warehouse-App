using BackendProject.Model;



class CreateAddressDto {
		      public string Country {get; private set;}   
		      public string City {get; private set;}   
		      public string Street {get; private set;}   
		      public int StreetNumber {get; private set;}   
		
	public Address toEntity() {
		Address obj = new Address();
		      	obj.Country = Country;  
		      	obj.City = City;  
		      	obj.Street = Street;  
		      	obj.StreetNumber = StreetNumber;  
	}
}


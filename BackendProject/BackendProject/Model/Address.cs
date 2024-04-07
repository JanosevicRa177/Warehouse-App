using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("address")]
public class Address
{  
	[Column("id")] 
	public int Id {get; set;}
    [Column("country")] 
    public string Country {get; set;}   
    [Column("city")] 
    public string City {get; set;}   
    [Column("street")] 
    public string Street {get; set;}   
    [Column("street_number")] 
    public int StreetNumber {get; set;}   
	public Address(){ }
	public Address(string country, string city, string street, int streetNumber) 
	{
      	Country = country;
      	City = city;
      	Street = street;
      	StreetNumber = streetNumber;
	}


	public void Update(Address entity) {
		Country = entity.Country;
		City = entity.City;
		Street = entity.Street;
		StreetNumber = entity.StreetNumber;
	}
}

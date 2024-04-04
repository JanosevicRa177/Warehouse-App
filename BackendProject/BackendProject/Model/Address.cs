using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("address")]
public class Address : Entity
{  
      [Column("country")] 
      public string Country {get; private set;}   
      [Column("city")] 
      public string City {get; private set;}   
      [Column("street")] 
      public string Street {get; private set;}   
      [Column("street_number")] 
      public int StreetNumber {get; private set;}   
	public Address(){ }
	public Address(string country, string city, string street, int streetNumber) 
	{
      	Country = country;
      	City = city;
      	Street = street;
      	StreetNumber = streetNumber;
	}
}

using System.ComponentModel.DataAnnotations.Schema;   
using BackendProject.WebApi.Dtos;

namespace BackendProject.Model;


[Table("warehouse")]
public class Warehouse
{  
	[Column("id")] 
	public int Id {get; set;}
    public List<ReceiptItem> ReceiptItems {get; set;} = new();
	[Column("address_id")] 
    public int AddressId {get; set;}
    public Address Address {get; set;}  
    [Column("warehouse_name")] 
    public string Name {get; set;}   
    [Column("warehouse_size")] 
    public int SizeInM2 {get; set;}   
    public List<Product> Products {get; set;} = new();
    public List<User> Workers {get; set;} = new();
	public Warehouse(){ }
	public Warehouse(int addressId , string name, int sizeInM2) 
	{
      	AddressId = addressId;
      	Name = name;
      	SizeInM2 = sizeInM2;
	}
	public void Update(UpdateWarehouseDto updateWarehouseDto) {
		Name = updateWarehouseDto.Name;
		SizeInM2 = updateWarehouseDto.SizeInM2;
	}
}

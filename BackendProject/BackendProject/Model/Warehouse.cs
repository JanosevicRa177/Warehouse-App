using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("warehouse")]
public class Warehouse : Entity
{  
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
	 [Column("address_id")] 
      public Guid AddressId {get; private set;}
      public Address Address {get; private set;}  
      [Column("warehouse_name")] 
      public string Name {get; private set;}   
      [Column("warehouse_size")] 
      public int SizeInM2 {get; private set;}   
      public List<Product> Products {get; private set;} = new();
      public List<User> Workers {get; private set;} = new();
	public Warehouse(){ }
	public Warehouse(Guid addressId , string name, int sizeInM2) 
	{
      	AddressId = addressId;
      	Name = name;
      	SizeInM2 = sizeInM2;
	}


public void Update(Warehouse entity) {
	Name = entity.Name;
	SizeInM2 = entity.SizeInM2;
}
}

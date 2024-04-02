
namespace BackendProject.Model;

public class Warehouse : Entity
{  
      public List<Manager> Managers {get; private set;} = new();
      public List<Worker> Workers {get; private set;} = new();
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      public Guid AddressId {get; private set;} 
      public Address Address {get; private set;}
      public string Name {get; private set;}
      public int SizeInM2 {get; private set;}
      public List<Product> Products {get; private set;} = new();
	public Warehouse(){ }
	public Warehouse(Guid addressId , string name, int sizeInM2) 
	{
      	AddressId = addressId;
      	Name = name;
      	SizeInM2 = sizeInM2;
	}
}

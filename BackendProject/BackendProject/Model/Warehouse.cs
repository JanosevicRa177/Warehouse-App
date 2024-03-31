
namespace BackendProject.Model;

public class Warehouse : Entity
{  
      public List<Manager> Managers {get; private set;} = new();
      public List<Worker> Workers {get; private set;} = new();
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      public Address Address {get; private set;}
      public string Name {get; private set;}
      public int SizeInM2 {get; private set;}
      public List<Product> Products {get; private set;} = new();
	public Warehouse(){ }
	public Warehouse(Address address, string name, int sizeInM2) 
	{
      	Address = address;
      	Name = name;
      	SizeInM2 = sizeInM2;
	}
}


namespace BackendProject.Model;

public class Warehouse 
{  
      public Guid Id {get; private set;}
      public List<Manager> Managers {get; private set;} = new();
      public List<Worker> Workers {get; private set;} = new();
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      public Address Address {get; private set;}
      public string Name {get; private set;}
      public int SizeInM2 {get; private set;}
      public List<Product> Products {get; private set;} = new();
}


namespace BackendProject.Model;

public class Warehouse 
{  
      private List<Manager> Managers {get; set;} = new();
      private List<Worker> Workers {get; set;} = new();
      private List<ReceiptItem> ReceiptItems {get; set;} = new();
      private Address Address {get; set;}
      private string Name {get; set;}
      private int SizeInM2 {get; set;}
      private List<Product> Products {get; set;} = new();
}

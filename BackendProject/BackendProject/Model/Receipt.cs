
namespace BackendProject.Model;

public class Receipt 
{  
      public Guid Id {get; private set;}
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      public int FullPrice {get; private set;}
}

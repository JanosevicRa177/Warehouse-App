
namespace BackendProject.Model;

public class Receipt 
{  
      private List<ReceiptItem> ReceiptItems {get; set;} = new();
      private int FullPrice {get; set;}
}

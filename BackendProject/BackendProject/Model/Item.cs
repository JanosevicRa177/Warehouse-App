using BackendProject.Model.Enum;

namespace BackendProject.Model;

public class Item 
{  
      private List<Product> Products {get; set;} = new();
      private List<ReceiptItem> ReceiptItems {get; set;} = new();
      private ItemType ItemType {get; set;}
}

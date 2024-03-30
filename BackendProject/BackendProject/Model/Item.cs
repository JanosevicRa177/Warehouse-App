using BackendProject.Model.Enum;

namespace BackendProject.Model;

public class Item 
{  
      public Guid Id {get; private set;}
      public List<Product> Products {get; private set;} = new();
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      public ItemType ItemType {get; private set;}
}

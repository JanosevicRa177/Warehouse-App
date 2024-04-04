using BackendProject.Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("item")]
public class Item : Entity
{  
      public List<Product> Products {get; private set;} = new();
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      [Column("item_type")] 
      public ItemType ItemType {get; private set;}   
      [Column("item_name")] 
      public string ItemName {get; private set;}   
	public Item(){ }
	public Item(ItemType itemType, string itemName) 
	{
      	ItemType = itemType;
      	ItemName = itemName;
	}
}

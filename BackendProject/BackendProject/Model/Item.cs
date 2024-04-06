using BackendProject.Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("item")]
public class Item : Entity
{  
      public List<Product> Products {get; set;} = new();
      public List<ReceiptItem> ReceiptItems {get; set;} = new();
      [Column("item_type")] 
      public ItemType ItemType {get; set;}   
      [Column("item_name")] 
      public string ItemName {get; set;}   
	public Item(){ }
	public Item(ItemType itemType, string itemName) 
	{
      	ItemType = itemType;
      	ItemName = itemName;
	}


public void Update(Item entity) {
	ItemType = entity.ItemType;
	ItemName = entity.ItemName;
}
}

using BackendProject.Model.Enum;
using System.ComponentModel.DataAnnotations.Schema;   
using BackendProject.WebApi.Dtos;

namespace BackendProject.Model;


[Table("item")]
public class Item
{  
	[Column("id")] 
	public int Id {get; set;}
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
	public void Update(UpdateItemDto updateItemDto) {
		ItemType = updateItemDto.ItemType;
		ItemName = updateItemDto.ItemName;
	}
}

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
    [Column("item_name")] 
    public string ItemName {get; set;}   
	public Item(){ }
	public Item(string itemName) 
	{
      	ItemName = itemName;
	}
	public void Update(UpdateItemDto updateItemDto) {
		Products = updateItemDto.ProductsIds.Select(id => new Product
		{
			Id = id
		}).ToList();
		ReceiptItems = updateItemDto.ReceiptItemsIds.Select(id => new ReceiptItem
		{
			Id = id
		}).ToList();
		ItemName = updateItemDto.ItemName;
	}
}

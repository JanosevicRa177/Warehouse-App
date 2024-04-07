using System.ComponentModel.DataAnnotations.Schema;   
using BackendProject.WebApi.Dtos;

namespace BackendProject.Model;


[Table("receipt")]
public class Receipt
{  
	[Column("id")] 
	public int Id {get; set;}
    public List<ReceiptItem> ReceiptItems {get; set;} = new();
    [Column("full_price")] 
    public int FullPrice {get; set;}   
	public Receipt(){ }
	public Receipt(int fullPrice) 
	{
      	FullPrice = fullPrice;
	}
	public void Update(UpdateReceiptDto updateReceiptDto) {
		FullPrice = updateReceiptDto.FullPrice;
	}
}

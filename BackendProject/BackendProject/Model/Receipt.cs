using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("receipt")]
public class Receipt : Entity
{  
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      [Column("full_price")] 
      public int FullPrice {get; private set;}   
	public Receipt(){ }
	public Receipt(int fullPrice) 
	{
      	FullPrice = fullPrice;
	}
}

using System.ComponentModel.DataAnnotations.Schema;   

namespace BackendProject.Model;


[Table("receipt")]
public class Receipt : Entity
{  
      public List<ReceiptItem> ReceiptItems {get; set;} = new();
      [Column("full_price")] 
      public int FullPrice {get; set;}   
	public Receipt(){ }
	public Receipt(int fullPrice) 
	{
      	FullPrice = fullPrice;
	}


public void Update(Receipt entity) {
	FullPrice = entity.FullPrice;
}
}

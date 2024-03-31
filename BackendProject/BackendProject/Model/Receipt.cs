
namespace BackendProject.Model;

public class Receipt : Entity
{  
      public List<ReceiptItem> ReceiptItems {get; private set;} = new();
      public int FullPrice {get; private set;}
	public Receipt(){ }
	public Receipt(int fullPrice) 
	{
      	FullPrice = fullPrice;
	}
}

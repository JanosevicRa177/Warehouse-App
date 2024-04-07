using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;

public class CreateReceiptDto {
      public List<int> ReceiptItemsIds {get; set;} = new();
      public int FullPrice {get; set;}   
		
	public Receipt ToEntity() {
		var receipt = new Receipt(FullPrice);
		receipt.ReceiptItems = ReceiptItemsIds.Select(id => new ReceiptItem
		{
			Id = id
		}).ToList();
		return receipt;
	}
}


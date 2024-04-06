using BackendProject.Model;
using BackendProject.Model.Enum;

namespace BackendProject.WebApi.Dtos;

public class CreateReceiptDto {
      public List<ReceiptItem> ReceiptItems {get; set;} = new();
      public int FullPrice {get; set;}   
		
	public Receipt ToEntity() {
		var receipt = new Receipt(FullPrice);
		return receipt;
	}
}


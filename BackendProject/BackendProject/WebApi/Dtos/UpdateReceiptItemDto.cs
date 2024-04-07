using BackendProject.Model;

namespace BackendProject.WebApi.Dtos;


public class UpdateReceiptItemDto {
      public int ItemId {get; set;}
      public int ReceiptsId {get; set;}
      public int WarehouseId {get; set;}
      public int Price {get; set;}   
	
	public ReceiptItem ToEntity() {
		var receiptItem = new ReceiptItem(ItemId , ReceiptsId , WarehouseId , Price);
		
		return receiptItem;
	}
}

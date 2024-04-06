using BackendProject.Model;



class CreateReceiptDto {
  	public int FullPrice {get; public set;}   
		
	public Receipt toEntity() {
		Receipt obj = new Receipt();
      	obj.FullPrice = FullPrice;  
	}
}


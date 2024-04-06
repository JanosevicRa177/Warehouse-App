using BackendProject.Model;



class CreateItemDto {
  	public ItemType ItemType {get; public set;}   
  	public string ItemName {get; public set;}   
		
	public Item toEntity() {
		Item obj = new Item();
      	obj.ItemType = ItemType;  
      	obj.ItemName = ItemName;  
	}
}


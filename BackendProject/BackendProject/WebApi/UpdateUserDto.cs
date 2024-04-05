using BackendProject.Model;




class UpdateUserDto {
	public string FirstName {get; public set;}   
	public string Contact {get; public set;}   
    public Address Address {get; public set;}  
	public string Email {get; public set;}   
    public Warehouse Warehouse {get; public set;}  
	
	public User toEntity() {
		User obj = new User();
      	obj.FirstName = FirstName;  
      	obj.Contact = Contact;  
      	obj.Address = Address; 
      	obj.Email = Email;  
      	obj.Warehouse = Warehouse; 
	}
}

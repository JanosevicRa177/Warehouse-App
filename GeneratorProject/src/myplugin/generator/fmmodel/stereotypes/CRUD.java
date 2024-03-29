package myplugin.generator.fmmodel.stereotypes;

public class CRUD {
	private Boolean create;
	private Boolean update;
	private Boolean delete;
	private Boolean read;
	private String path;
	
	public CRUD() {
		super();
	}
	public CRUD(Boolean create, Boolean update, Boolean delete, Boolean read, String path) {
		super();
		this.create = create;
		this.update = update;
		this.delete = delete;
		this.read = read;
		this.path = path;
	}
	public String getPath() {
		return path;
	}
	public void setPath(String path) {
		this.path = path;
	}
	public Boolean getCreate() {
		return create;
	}
	public void setCreate(Boolean create) {
		this.create = create;
	}
	public Boolean getUpdate() {
		return update;
	}
	public void setUpdate(Boolean update) {
		this.update = update;
	}
	public Boolean getDelete() {
		return delete;
	}
	public void setDelete(Boolean delete) {
		this.delete = delete;
	}
	public Boolean getRead() {
		return read;
	}
	public void setRead(Boolean read) {
		this.read = read;
	}
}

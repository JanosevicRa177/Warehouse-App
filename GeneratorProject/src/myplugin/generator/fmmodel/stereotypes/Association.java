package myplugin.generator.fmmodel.stereotypes;

import myplugin.generator.fmmodel.FMProperty;

public class Association {
	private FMProperty owner;
	private FMProperty notOwner;
	
	public Association(FMProperty owner, FMProperty notOwner) {
		super();
		this.owner = owner;
		this.notOwner = notOwner;
	}
	
	public FMProperty getOwner() {
		return owner;
	}
	public void setOwner(FMProperty owner) {
		this.owner = owner;
	}
	public FMProperty getNotOwner() {
		return notOwner;
	}
	public void setNotOwner(FMProperty notOwner) {
		this.notOwner = notOwner;
	}
	
	
}

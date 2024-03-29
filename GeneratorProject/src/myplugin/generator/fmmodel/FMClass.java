package myplugin.generator.fmmodel;

import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

import myplugin.generator.fmmodel.stereotypes.CRUD;
import myplugin.generator.fmmodel.stereotypes.Entity;


public class FMClass extends FMType {

	private Entity entity;
	
	private CRUD crud;

	private String visibility;
	
	private Boolean hasEnum;

	//Class properties
	private List<FMProperty> FMProperties = new ArrayList<FMProperty>();
	
	//list of packages (for import declarations) 
	private List<String> importedPackages = new ArrayList<String>();
	
	/** @ToDo: add list of methods */
	
	public FMClass(String name, String classPackage, String visibility) {
		super(name, classPackage);		
		this.visibility = visibility;
		this.hasEnum = false;
	}	
	
	public List<FMProperty> getProperties(){
		return FMProperties;
	}
	
	public Iterator<FMProperty> getPropertyIterator(){
		return FMProperties.iterator();
	}
	
	public void addProperty(FMProperty property){
		FMProperties.add(property);		
	}
	
	public CRUD getCrud() {
		return crud;
	}

	public void setCrud(CRUD crud) {
		this.crud = crud;
	}
	
	public int getPropertyCount(){
		return FMProperties.size();
	}
	
	public List<String> getImportedPackages(){
		return importedPackages;
	}

	public Iterator<String> getImportedIterator(){
		return importedPackages.iterator();
	}
	
	public void addImportedPackage(String importedPackage){
		importedPackages.add(importedPackage);		
	}
	
	public int getImportedCount(){
		return FMProperties.size();
	}
	
	public String getVisibility() {
		return visibility;
	}

	public void setVisibility(String visibility) {
		this.visibility = visibility;
	}	
	
	public Entity getEntity() {
		return entity;
	}

	public void setEntity(Entity entity) {
		this.entity = entity;
	}
	
	public Boolean getHasEnum() {
		return hasEnum;
	}

	public void setHasEnum(Boolean hasEnum) {
		this.hasEnum = hasEnum;
	}

	
	
}

package myplugin.generator.fmmodel;

import myplugin.generator.fmmodel.stereotypes.Field;
import myplugin.generator.fmmodel.stereotypes.PropertyStereotype;

public class FMProperty extends FMElement  {
	//Property type
	private FMType type;
	// Property visibility (public, private, protected, package)
	private String visibility;
	//Multiplicity (lower value)
	private Integer lower;
	//Multiplicity (upper value) 
	private Integer upper;
	
	private PropertyStereotype property;
	
	private Field field;
	
	public FMProperty(String name, FMType type, String visibility, int lower, int upper) {
		super(name);
		this.type = type;
		this.visibility = visibility;
		
		this.lower = lower;
		this.upper = upper;		
	}
	
	public Field getField() {
		return field;
	}
	public void setField(Field field) {
		this.field = field;
	}
	public FMType getType() {
		return type;
	}
	public void setType(FMType type) {
		this.type = type;
	}
	public String getVisibility() {
		return visibility;
	}
	public void setVisibility(String visibility) {
		this.visibility = visibility;
	}
	
	public Integer getLower() {
		return lower;
	}

	public void setLower(Integer lower) {
		this.lower = lower;
	}

	public Integer getUpper() {
		return upper;
	}

	public void setUpper(Integer upper) {
		this.upper = upper;
	}

	public PropertyStereotype getProperty() {
		return property;
	}

	public void setProperty(PropertyStereotype property) {
		this.property = property;
	}
	
}

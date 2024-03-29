package myplugin.generator.fmmodel.stereotypes;

public class PropertyStereotype {
	private String columnName;
	
	public PropertyStereotype(String columnName) {
		super();
		this.columnName = columnName;
	}

	public String getColumnName() {
		return columnName;
	}

	public void setColumnName(String columnName) {
		this.columnName = columnName;
	}
	
}

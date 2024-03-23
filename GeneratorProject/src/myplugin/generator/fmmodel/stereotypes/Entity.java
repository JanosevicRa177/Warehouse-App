package myplugin.generator.fmmodel.stereotypes;

public class Entity {
	String tableName;
	
	public Entity() {
		
	}
	public Entity(String tableName) {
		this.tableName = tableName;
	}

	public String getTableName() {
		return tableName;
	}

	public void setTableName(String tableName) {
		this.tableName = tableName;
	}
}

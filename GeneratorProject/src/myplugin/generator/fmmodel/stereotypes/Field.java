package myplugin.generator.fmmodel.stereotypes;

public class Field {
	private String label;
	private Component component;
	private boolean editable;
	
	public Field(String label, Component component, boolean editable) {
		super();
		this.label = label;
		this.component = component;
		this.editable = editable;
	}

	public String getLabel() {
		return label;
	}

	public void setLabel(String label) {
		this.label = label;
	}

	public Component getComponent() {
		return component;
	}

	public void setComponent(Component component) {
		this.component = component;
	}

	public boolean isEditable() {
		return editable;
	}

	public void setEditable(boolean editable) {
		this.editable = editable;
	}
	
}

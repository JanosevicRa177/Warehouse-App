package myplugin.generator.fmmodel.stereotypes;

public enum Component {
	TEXT_FIELD,
	COMBO_BOX,
	CHECK_BOX,
	NUMBER;
	
    public static Component valueOfStr(String value) {
        if(value.equals("TextField"))
        	return TEXT_FIELD;
        if(value.equals("ComboBox"))
        	return COMBO_BOX;
        if(value.equals("CheckBox"))
        	return CHECK_BOX;
        return NUMBER;
    }
}

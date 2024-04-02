package myplugin.generator.fmmodel;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.swing.JOptionPane;

/** FMModel: Singleton class. This is intermediate data structure that keeps metadata
 * extracted from MagicDraw model. Data structure should be optimized for code generation
 * using freemarker
 */

public class FMModel {
	
	private List<FMClass> classes = new ArrayList<FMClass>();
	private List<FMEnumeration> enumerations = new ArrayList<FMEnumeration>();
	
	//....
	/** @ToDo: Add lists of other elements, if needed */
	private FMModel() {
		
	}
	
	private static FMModel model;
	
	public static FMModel getInstance() {
		if (model == null) {
			model = new FMModel();			
		}
		return model;
	}
	
	public List<FMClass> getClasses() {
		return classes;
	}
	public void setClasses(List<FMClass> classes) {
		this.classes = classes;
	}
	public List<FMEnumeration> getEnumerations() {
		return enumerations;
	}
	public void setEnumerations(List<FMEnumeration> enumerations) {
		this.enumerations = enumerations;
	}

	public void setIsPropertyAClass() {
	    Map<String, FMClass> classMap = new HashMap<>();
	    for (FMClass aClass : classes) {
	        classMap.put(aClass.getName(), aClass);
	    }
	    for (FMClass aClass : classes) {
	        for (FMProperty prop : aClass.getProperties()) {
	            if (classMap.containsKey(prop.getType().getName())) {
	                prop.setIsClass(true);
	            }
	        }
	    }
	}


}

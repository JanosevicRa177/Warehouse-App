package myplugin.analyzer;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Iterator;
import java.util.List;
import java.util.Optional;

import javax.swing.JOptionPane;

import myplugin.generator.fmmodel.FMClass;
import myplugin.generator.fmmodel.FMEnumeration;
import myplugin.generator.fmmodel.FMModel;
import myplugin.generator.fmmodel.FMProperty;
import myplugin.generator.fmmodel.FMType;
import myplugin.generator.fmmodel.stereotypes.CRUD;
import myplugin.generator.fmmodel.stereotypes.Component;
import myplugin.generator.fmmodel.stereotypes.Entity;
import myplugin.generator.fmmodel.stereotypes.Field;
import myplugin.generator.fmmodel.stereotypes.PropertyStereotype;

import com.nomagic.uml2.ext.jmi.helpers.ModelHelper;
import com.nomagic.uml2.ext.jmi.helpers.StereotypesHelper;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Element;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.EnumerationLiteral;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Package;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Association;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Class;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Enumeration;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Property;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Type;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.TypedElement;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.impl.EnumerationLiteralImpl;
import com.nomagic.uml2.ext.magicdraw.mdprofiles.Stereotype;


/** Model Analyzer takes necessary metadata from the MagicDraw model and puts it in 
 * the intermediate data structure (@see myplugin.generator.fmmodel.FMModel) optimized
 * for code generation using freemarker. Model Analyzer now takes metadata only for ejb code 
 * generation

// * @ToDo: Enhance (or completely rewrite) myplugin.generator.fmmodel classes and  
 * Model Analyzer methods in order to support GUI generation. */ 


public class ModelAnalyzer {	
	//root model package
	private Package root;
	
	//java root package for generated code
	private String filePackage;
	
	public ModelAnalyzer(Package root, String filePackage) {
		super();
		this.root = root;
		this.filePackage = filePackage;
	}

	public Package getRoot() {
		return root;
	}
	
	public void prepareModel() throws AnalyzeException {
		FMModel.getInstance().getClasses().clear();
		FMModel.getInstance().getEnumerations().clear();
		processPackage(root, filePackage);
		FMModel.getInstance().setIsPropertyAClass();
		
	}
	
	private void processPackage(Package pack, String packageOwner) throws AnalyzeException {
		//Recursive procedure that extracts data from package elements and stores it in the 
		// intermediate data structure
		
		
		if (pack.getName() == null) throw  
			new AnalyzeException("Packages must have names!");
		
		String packageName = packageOwner;
		if (pack != root) {
			packageName += "." + pack.getName();
		}
		
		if (pack.hasOwnedElement()) {
			
			for (Iterator<Element> it = pack.getOwnedElement().iterator(); it.hasNext();) {
				Element ownedElement = it.next();
				
				if (ownedElement instanceof Enumeration) {
					Enumeration en = (Enumeration)ownedElement;
					if(en.getName().equals("Component")) continue;
					FMEnumeration fmEnumeration = getEnumerationData(en, packageName);
					FMModel.getInstance().getEnumerations().add(fmEnumeration);
				}	
											
			}
			
			for (Iterator<Element> it = pack.getOwnedElement().iterator(); it.hasNext();) {
				Element ownedElement = it.next();
				if (ownedElement instanceof Stereotype) 
					continue;
				
				if (ownedElement instanceof Class) {
					Class cl = (Class)ownedElement;
					FMClass fmClass = getClassData(cl, packageName);
					FMModel.getInstance().getClasses().add(fmClass);
				}
										
			}
		}
	}
	
	private FMEnumeration getEnumerationData(Enumeration enumeration, String packageName) throws AnalyzeException {
		FMEnumeration fmEnum = new FMEnumeration(enumeration.getName(), packageName);
		List<EnumerationLiteral> list = enumeration.getOwnedLiteral();
		for (int i = 0; i < list.size(); i++) {
			EnumerationLiteral literal = list.get(i);
			if (literal.getName() == null)  
				throw new AnalyzeException("Items of the enumeration " + enumeration.getName() +
				" must have names!");
			fmEnum.addValue(literal.getName());
		}
		return fmEnum;
	}	
	
	private boolean doesClassHaveEnum(String enumName) {
		for(FMEnumeration aEnum: FMModel.getInstance().getEnumerations()){
			if(aEnum.getName().equals(enumName))
				return true;
		}
		return false;
	}
	
	private FMClass getClassData(Class cl, String packageName) throws AnalyzeException {
		if (cl.getName() == null) 
			throw new AnalyzeException("Classes must have names!");
		
		FMClass fmClass = new FMClass(cl.getName(), packageName, cl.getVisibility().toString());
		
		List<FMProperty> classProperties = getClassProperties(fmClass, cl);
		for(FMProperty property: classProperties){
			fmClass.addProperty(property);
		}
		
		Collection<Class> superClasses = cl.getSuperClass();
		
		for(Class cla: superClasses) {
			List<FMProperty> superClassProperties = getClassProperties(null, cla);
			for(FMProperty property: superClassProperties){
				fmClass.addProperty(property);
			}
		}
		
		Stereotype entityStereotype = StereotypesHelper.getAppliedStereotypeByString(cl, "Entity");
		if (entityStereotype != null) {
			Entity entity = getEntity(entityStereotype, cl);
			fmClass.setEntity(entity);
		}
		
		Stereotype crudStereotype = StereotypesHelper.getAppliedStereotypeByString(cl, "Controller");
		if (crudStereotype != null) {

			CRUD crud = getCRUD(crudStereotype, cl);
			fmClass.setCrud(crud);
		}	
		
		return fmClass;
	}
	
	private List<FMProperty> getClassProperties(FMClass fmClass, Class cl) throws AnalyzeException {
		List<FMProperty> properties = new ArrayList<FMProperty>();
		Iterator<Property> it = ModelHelper.pureAttributes(cl);
		
		while (it.hasNext()) {
			Property p = it.next();
			FMProperty prop = getPropertyData(p, cl);
//			Iterator<Association> associations = ModelHelper.associations(cl);
//			while (associations.hasNext()) {
//				Association association = associations.next();
//				
//				Stereotype associationStereotype = StereotypesHelper.getAppliedStereotypeByString(association, "Configuration");
//				if(associationStereotype != null) {
//					JOptionPane.showMessageDialog(null, fmClass.getName() + ":" + prop.getType().getName() + getIsConfigOwner(associationStereotype,cl));
//					prop.setIsOwnerOf(getIsConfigOwner(associationStereotype,cl));
//				}
//			}
			if(doesClassHaveEnum(prop.getType().getName()) && fmClass != null)
				fmClass.setHasEnum(true);
			properties.add(prop);
		}
		return properties;
	}
	
	private Boolean getIsConfigOwner(Stereotype associationStereotype, Class aClass) {
		List<Property> entityTags = associationStereotype.getOwnedAttribute();
		Property tagDef = entityTags.get(0);
		String tagName = tagDef.getName();
		List<Object> value = StereotypesHelper.getStereotypePropertyValue(aClass, associationStereotype, tagName);
		return value.size() > 0 && ((String) value.get(0)).equals(aClass.getName());
	}
	
	private CRUD getCRUD(Stereotype crudStereotype, Class aClass) {
		List<Property> entityTags = crudStereotype.getOwnedAttribute();
		Boolean create = true;
		Boolean update = true;
		Boolean getAll = true;
		Boolean details = true;
		String path = "";
		for (int j = 0; j < entityTags.size(); ++j) {
			Property tagDef = entityTags.get(j);
			String tagName = tagDef.getName();
			List<Object> value = StereotypesHelper.getStereotypePropertyValue(aClass, crudStereotype, tagName);
			if(value.size() > 0) {
				switch(tagName) {
					case "create":
						create = (Boolean) value.get(0);
						break;
					case "update":
						update = (Boolean) value.get(0);
						break;
					case "getAll":
						getAll = (Boolean) value.get(0);
						break;
					case "details":
						details = (Boolean) value.get(0);
						break;
					case "path":
						path = (String) value.get(0);
				}
			}
		}	
		return new CRUD(create, update, getAll, details,path);
	}
	
	private Entity getEntity(Stereotype entityStereotype, Class aClass) {
		List<Property> entitytags = entityStereotype.getOwnedAttribute();
		Property tableName = entitytags.get(0);
		String tagName = tableName.getName();
		List<Object> value = StereotypesHelper.getStereotypePropertyValue(aClass, entityStereotype, tagName);
		if(value.size() > 0) {
			return new Entity((String)value.get(0));
		}
		return null;
	}
	
	private FMProperty getPropertyData(Property p, Class cl) throws AnalyzeException {
		String attName = p.getName();
		if (attName == null) 
			throw new AnalyzeException("Properties of the class: " + cl.getName() +
					" must have names!");
		Type attType = p.getType();
		if (attType == null)
			throw new AnalyzeException("Property " + cl.getName() + "." +
			p.getName() + " must have type!");
		
		String typeName = attType.getName();
		String typePackage = attType.getPackage().getName();
		if (typeName == null)
			throw new AnalyzeException("Type ot the property " + cl.getName() + "." +
			p.getName() + " must have name!");		
			
		int lower = p.getLower();
		int upper = p.getUpper();
		if(typeName.equals("String")) typeName = "string";
		
		FMProperty prop = new FMProperty(attName, new FMType(typeName, typePackage), p.getVisibility().toString(),
				lower, upper);
		
		Stereotype fieldStereotype = StereotypesHelper.getAppliedStereotypeByString(p, "Field");
		if (fieldStereotype != null) {

			Field field = getField(fieldStereotype, p);
			prop.setField(field);
		}	
		
		Stereotype propertyStereotype = StereotypesHelper.getAppliedStereotypeByString(p, "Field");
		if (propertyStereotype != null) {

			PropertyStereotype fmPropertyStereotype = getPropertyStereotype(propertyStereotype, p);
			prop.setProperty(fmPropertyStereotype);
		}
		
		return prop;		
	}
	
	private PropertyStereotype getPropertyStereotype(Stereotype propertyStereotype, Property p) {
		List<Property> entitytags = propertyStereotype.getOwnedAttribute();
		Property tableName = entitytags.get(0);
		String tagName = tableName.getName();
		List<Object> value = StereotypesHelper.getStereotypePropertyValue(p, propertyStereotype, tagName);
		if(value.size() > 0) {
			return new PropertyStereotype((String)value.get(0));
		}
		return null;
	}
	
	private Field getField(Stereotype fieldStereotype, Property p) {
		List<Property> entityTags = fieldStereotype.getOwnedAttribute();
		String label = "";
		Component component = Component.TEXT_FIELD;
		Boolean editable = true;
		
		for (int j = 0; j < entityTags.size(); ++j) {
			Property tagDef = entityTags.get(j);
			String tagName = tagDef.getName();
			List<Object> value = StereotypesHelper.getStereotypePropertyValue(p, fieldStereotype, tagName);
			if(value.size() > 0) {
				switch(tagName) {
					case "label":
						label = (String) value.get(0);
						break;
					case "component":
						EnumerationLiteralImpl aEnum = ((EnumerationLiteralImpl) value.get(0));
						component = Component.valueOfStr(aEnum.getName());
						break;
					case "editable":
						editable = (Boolean) value.get(0);
				}
			}
		}	
		return new Field(label,component,editable);
	}
	
	
}

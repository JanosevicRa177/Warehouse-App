package testTemplates;

import java.util.List;

import myplugin.generator.EJBGenerator;
import myplugin.generator.fmmodel.FMClass;
import myplugin.generator.fmmodel.FMModel;
import myplugin.generator.fmmodel.FMProperty;
import myplugin.generator.options.GeneratorOptions;
import myplugin.generator.options.ProjectOptions;

/** TestPackageGeneration: Class for package generation testing
 * @ToDo: Create another test class that loads metadata saved by MagicDraw plugin 
 * ( @see myplugin.GenerateAction#exportToXml() ) and activate code generation. 
 * This is the way to perform code generation testing without
 *  need to restart MagicDraw 
 *  */

public class TestPackageGeneration {
	
	public TestPackageGeneration(){
		
	}
	
	private void initModel() {		
		
		List<FMClass> classes = FMModel.getInstance().getClasses();
		
		classes.clear();
		
		FMClass cl = new FMClass ("Preduzece", "ejb.orgsema", "public");
		classes.add(cl);		
	}
	
	public void testGenerator() {
		initModel();		
		GeneratorOptions go = ProjectOptions.getProjectOptions().getGeneratorOptions().get("EJBGenerator");	
		EJBGenerator g = new EJBGenerator(go);
		g.generate();
	}
	
	public static void main(String[] args) {
		TestPackageGeneration tg = new TestPackageGeneration();
		/** @Todo: load project options from xml file */
		
		//for test purpose only:
		GeneratorOptions ejbOptions = new GeneratorOptions("c:/temp", "ejbclass", "./resources/templates/", "{0}.java", true, "ejb"); 				
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("EJBGenerator", ejbOptions);
				
		tg.testGenerator();
	}
	
	
	
	
}

package testTemplates;

import java.util.List;

import myplugin.generator.fmmodel.FMClass;
import myplugin.generator.fmmodel.FMModel;

public class TestPackageGeneration {
	
	public TestPackageGeneration(){
		
	}
	
	private void initModel() {		
		
		List<FMClass> classes = FMModel.getInstance().getClasses();
		
		classes.clear();		
	}
	
	public void testGenerator() {
		initModel();		
	}
	
	public static void main(String[] args) {
		TestPackageGeneration tg = new TestPackageGeneration();
				
		tg.testGenerator();
	}
	
	
	
	
}

package myplugin;

import java.awt.event.ActionEvent;
import javax.swing.JOptionPane;

import com.nomagic.magicdraw.actions.MDAction;
import com.nomagic.magicdraw.core.Application;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Package;

import myplugin.analyzer.AnalyzeException;
import myplugin.analyzer.ModelAnalyzer;
import myplugin.generator.BackendEntityGenerator;
import myplugin.generator.BackendEnumGenerator;
import myplugin.generator.DbContextGenerator;
import myplugin.generator.RepositoryGenerator;
import myplugin.generator.RepositoryInterfaceGenerator;
import myplugin.generator.options.GeneratorOptions;
import myplugin.generator.options.ProjectOptions;

/** Action that activate code generation */
@SuppressWarnings("serial")
class GenerateAction extends MDAction{
	
	
	public GenerateAction(String name) {			
		super("", name, null, null);		
	}

	public void actionPerformed(ActionEvent evt) {
		
		if (Application.getInstance().getProject() == null) return;
		try {
			generateBackendModel();
			generateBackendEnum();
			generateDbContext();
			generateRepositories();
			generateRepositoryInterfaces();
			

		} catch (AnalyzeException e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		}
					
	}
	
	private void generateBackendModel()
			throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Model");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("BackendEntityGenerator");
		BackendEntityGenerator generator = new BackendEntityGenerator(generatorOptions);
		generator.generate();
	}
	
	
	private void generateBackendEnum()
			throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Enum");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("BackendEnumGenerator");
		BackendEnumGenerator generator = new BackendEnumGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateDbContext()
			throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Persistence");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("DbContextGenerator");
		DbContextGenerator generator = new DbContextGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateRepositories()
			throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Repositories");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("RepositoryGenerator");
		RepositoryGenerator generator = new RepositoryGenerator(generatorOptions);
		generator.generate();
	}
	private void generateRepositoryInterfaces()
			throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Interfaces");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("RepositoryInterfaceGenerator");
		RepositoryInterfaceGenerator generator = new RepositoryInterfaceGenerator(generatorOptions);
		generator.generate();
	}

}
package myplugin;

import java.awt.event.ActionEvent;
import java.io.IOException;

import javax.swing.JOptionPane;

import com.nomagic.magicdraw.actions.MDAction;
import com.nomagic.magicdraw.core.Application;
import com.nomagic.uml2.ext.magicdraw.classes.mdkernel.Package;

import myplugin.analyzer.AnalyzeException;
import myplugin.analyzer.ModelAnalyzer;
import myplugin.generator.AppComponentGenerator;
import myplugin.generator.AppModuleGenerator;
import myplugin.generator.AppTemplateGenerator;
import myplugin.generator.BackendEntityGenerator;
import myplugin.generator.BackendEnumGenerator;
import myplugin.generator.ConfigGenerator;
import myplugin.generator.DbContextGenerator;
import myplugin.generator.RepositoryGenerator;
import myplugin.generator.RepositoryInterfaceGenerator;
import myplugin.generator.RoutingGenerator;
import myplugin.generator.ServiceGenerator;
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
			generateAppModule();
			generateAppComponent();
			generateAppTemplate();
			generateService();
			generateRouter();
			generateConfig();
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
	
	private void generateConfig()
			throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Configuration");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("ConfigGenerator");
		ConfigGenerator generator = new ConfigGenerator(generatorOptions);
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
	
	private void generateAppModule() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("AppModuleGenerator");
		AppModuleGenerator generator = new AppModuleGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateAppComponent() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("AppComponentGenerator");
		AppComponentGenerator generator = new AppComponentGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateAppTemplate() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("AppTemplateGenerator");
		AppTemplateGenerator generator = new AppTemplateGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateService() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("ServiceGenerator");
		ServiceGenerator generator = new ServiceGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateRouter() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("RoutingGenerator");
		RoutingGenerator generator = new RoutingGenerator(generatorOptions);
		generator.generate();
	}

}
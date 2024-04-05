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
import myplugin.generator.AppCssGenerator;
import myplugin.generator.AppModuleGenerator;
import myplugin.generator.AppTemplateGenerator;
import myplugin.generator.BackendEntityGenerator;
import myplugin.generator.BackendEnumGenerator;
import myplugin.generator.ComponentGenerator;
import myplugin.generator.CssGenerator;
import myplugin.generator.ConfigGenerator;
import myplugin.generator.DbContextGenerator;
import myplugin.generator.HtmlGenerator;
import myplugin.generator.RepositoryGenerator;
import myplugin.generator.RepositoryInterfaceGenerator;
import myplugin.generator.RoutingGenerator;
import myplugin.generator.ServiceGenerator;
import myplugin.generator.options.GeneratorOptions;
import myplugin.generator.CRUDCommandGenerator;
import myplugin.generator.CommandHandlerGenerator;
import myplugin.generator.QueryGenerator;
import myplugin.generator.QueryHandlerGenerator;
import myplugin.generator.CRUDControllerGenerator;
import myplugin.generator.options.ProjectOptions;

/** Action that activate code generation */
@SuppressWarnings("serial")
class GenerateAction extends MDAction{
	
	
	public GenerateAction(String name) {			
		super("", name, null, null);		
	}

	public void actionPerformed(ActionEvent evt) {
		
		JOptionPane.showMessageDialog(null, "Starting the generation");
		if (Application.getInstance().getProject() == null) return;
		try {
			generateBackendModel();
			generateBackendEnum();
			generateDbContext();
			generateRepositories();
			generateRepositoryInterfaces();
			generateCRUDCommands();
			generateCommandHandler();
			generateQuery();
			generateQueryHandler();
			generateController();
			
			
			generateAppModule();
			generateAppComponent();
			generateAppTemplate();
			generateAppCss();
			generateService();
			generateComponent();
			generateHtml();
			generateCss();
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
	
	private void generateRepositories()			throws AnalyzeException {
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
	
	private void generateAppCss() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("AppCssGenerator");
		AppCssGenerator generator = new AppCssGenerator(generatorOptions);
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

	private void generateComponent() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("ComponentGenerator");
		ComponentGenerator generator = new ComponentGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateHtml() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("HtmlGenerator");
		HtmlGenerator generator = new HtmlGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateCss() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("CssGenerator");
		CssGenerator generator = new CssGenerator(generatorOptions);
	}
	
	private void generateCRUDCommands() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Commands");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("CRUDCommandGenerator");
		CRUDCommandGenerator generator = new CRUDCommandGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateCommandHandler() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Commands");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("CommandHandlerGenerator");
		CommandHandlerGenerator generator = new CommandHandlerGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateQuery() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Queries");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("QueryGenerator");
		QueryGenerator generator = new QueryGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateQueryHandler() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "Queries");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("QueryHandlerGenerator");
		QueryHandlerGenerator generator = new QueryHandlerGenerator(generatorOptions);
		generator.generate();
	}
	
	private void generateController() throws AnalyzeException {
		Package root = Application.getInstance().getProject().getModel();
		ModelAnalyzer analyzer = new ModelAnalyzer(root, "");
		analyzer.prepareModel();
		GeneratorOptions generatorOptions = ProjectOptions.getProjectOptions().getGeneratorOptions().get("ControllerGenerator");
		CRUDControllerGenerator generator = new CRUDControllerGenerator(generatorOptions);
		generator.generate();
	}

}
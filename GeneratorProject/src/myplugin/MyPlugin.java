package myplugin;

import java.io.File;

import myplugin.generator.options.GeneratorOptions;
import myplugin.generator.options.ProjectOptions;


import com.nomagic.actions.NMAction;
import com.nomagic.magicdraw.actions.ActionsConfiguratorsManager;

/** MagicDraw plugin that performes code generation */
public class MyPlugin extends com.nomagic.magicdraw.plugins.Plugin {
	
	String pluginDir = null; 
	String dusan = "D:/Faks/master/1 semestar/MBRS/Projekat/";
	String sara = "C:/Users/sara1/Desktop/master/MBRS-projekat/Warehouse-App/";
	String ana = "C:/Users/smvul/OneDrive/Desktop/Warehouse-App/";
	
	public void init() {
		pluginDir = getDescriptor().getPluginDirectory().getPath();
		ActionsConfiguratorsManager manager = ActionsConfiguratorsManager.getInstance();
		manager.addMainMenuConfigurator(new MainMenuConfigurator(getSubmenuActions()));

		modelOptions();
		enumOptions();
		dbContextOptions();
		repositoryInterfaceOptions();
		repositoryOptions();
		appModuleOptions();
		appComponentOptions();
		appTemplateOptions();
		serviceOptions();
		componentOptions();
		htmlOptions();
		cssOptions();
		routingOptions();
		//configOptions();
	}
	
	private void modelOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "BackendProject/BackendProject", "entity", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("BackendEntityGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void configOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "BackendProject/BackendProject", "config", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("BackendEntityGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void enumOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "BackendProject/BackendProject/Model/", "enum", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("BackendEnumGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	

	private void dbContextOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "BackendProject/BackendProject/Infrastructure/", "dbContext", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("DbContextGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void repositoryOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "BackendProject/BackendProject/Infrastructure/", "repository", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("RepositoryGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void repositoryInterfaceOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "BackendProject/BackendProject/Infrastructure/", "repositoryInterface", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("RepositoryInterfaceGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void appModuleOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app", "appModule", "templates", "{0}.ts", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("AppModuleGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void appComponentOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app", "appComponent", "templates", "{0}.ts", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("AppComponentGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void appTemplateOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app", "appTemplate", "templates", "{0}.html", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("AppTemplateGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void serviceOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app/services", "service", "templates", "{0}.ts", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("ServiceGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	

	private void componentOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app/components", "component", "templates", "{0}.ts", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("ComponentGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
    }
	
	private void routingOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app", "routing", "templates", "{0}.ts", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("RoutingGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}

	private void htmlOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app/components", "html", "templates", "{0}.html", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("HtmlGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void cssOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(ana + "FrontendProject/FrontendProject/src/app/components", "css", "templates", "{0}.css", true, "FrontendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("CssGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private NMAction[] getSubmenuActions()
	{
	   return new NMAction[]{
			new GenerateAction("Generate"),
	   };
	}
	
	public boolean close() {
		return true;
	}
	
	public boolean isSupported() {				
		return true;
	}
}
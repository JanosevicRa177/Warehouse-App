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
	
	public void init() {
		pluginDir = getDescriptor().getPluginDirectory().getPath();
		ActionsConfiguratorsManager manager = ActionsConfiguratorsManager.getInstance();
		manager.addMainMenuConfigurator(new MainMenuConfigurator(getSubmenuActions()));

		modelOptions();
		enumOptions();
		dbContextOptions();
		repositoryInterfaceOptions();
		repositoryOptions();
	}
	
	private void modelOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(dusan + "BackendProject/BackendProject/", "entity", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("BackendEntityGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void enumOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(dusan + "BackendProject/BackendProject/Model/", "enum", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("BackendEnumGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void dbContextOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(dusan + "BackendProject/BackendProject/Infrastructure/", "dbContext", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("DbContextGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void repositoryOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(dusan + "BackendProject/BackendProject/Infrastructure/", "repository", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("RepositoryGenerator", generatorOptions);
		generatorOptions.setTemplateDir(pluginDir + File.separator + generatorOptions.getTemplateDir());
	}
	
	private void repositoryInterfaceOptions() {
		GeneratorOptions generatorOptions = new GeneratorOptions(dusan + "BackendProject/BackendProject/Infrastructure/", "repositoryInterface", "templates", "{0}.cs", true, "BackendProject");
		ProjectOptions.getProjectOptions().getGeneratorOptions().put("RepositoryInterfaceGenerator", generatorOptions);
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
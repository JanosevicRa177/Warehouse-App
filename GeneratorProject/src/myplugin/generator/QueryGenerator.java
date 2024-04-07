package myplugin.generator;

import java.io.IOException;
import java.io.Writer;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.swing.JOptionPane;

import freemarker.template.TemplateException;
import myplugin.generator.fmmodel.FMClass;
import myplugin.generator.fmmodel.FMModel;
import myplugin.generator.options.GeneratorOptions;
import myplugin.generator.options.PluralUtil;

public class QueryGenerator extends BasicGenerator {

	public QueryGenerator(GeneratorOptions generatorOptions) {
		super(generatorOptions);
	}

	public void generate() {
		try {
			super.generate();
		} catch (IOException e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		}

		List<FMClass> classes = FMModel.getInstance().getClasses();
		for (int i = 0; i < classes.size(); i++) {
			FMClass cl = classes.get(i);
			
			if(cl.getCrud() == null) {
				continue;
			}
			
			if(cl.getCrud().getRead()) {
				String name = "ReadAll" +  PluralUtil.translateToPlural(cl.getName()) + "Query";
				write(name, cl, "readAll");
			}
			String name = "ReadOne" + cl.getName() + "Query";
			write(name, cl, "read");
		}
	}
	
	
	private void write(String filename, FMClass cl, String type) {
		try {
			Map<String, Object> context = new HashMap<String, Object>();
			Writer out = getWriter(filename, cl.getTypePackage());
			if (out != null) {
				context.clear();
				context.put("name", filename);
				context.put("type", type);
				context.put("classname", cl.getName());
				getTemplate().process(context, out);
				out.flush();
			}
		} catch (TemplateException e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		} catch (IOException e) {
			JOptionPane.showMessageDialog(null, e.getMessage());
		}
	}
}

package myplugin.generator;

import java.io.IOException;
import java.io.Writer;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import javax.swing.JOptionPane;

import freemarker.template.TemplateException;
import myplugin.generator.fmmodel.FMClass;
import myplugin.generator.fmmodel.FMModel;
import myplugin.generator.fmmodel.FMProperty;
import myplugin.generator.fmmodel.stereotypes.Association;
import myplugin.generator.options.GeneratorOptions;

/**
 * EJB generator that now generates incomplete ejb classes based on MagicDraw
 * class model
 * 
 * @ToDo: enhance resources/templates/ejbclass.ftl template and intermediate
 *        data structure (@see myplugin.generator.fmmodel) in order to generate
 *        complete ejb classes
 */

public class ConfigGenerator extends BasicGenerator {

	public ConfigGenerator(GeneratorOptions generatorOptions) {
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
			Writer out;
			if(cl.getEntity() == null) continue;
			Map<String, Object> context = new HashMap<String, Object>();
			List<Association> associations = new ArrayList<Association>();
			for(FMProperty prop : cl.getProperties()) {
				for(FMClass clInner : classes) {
					if(clInner.getName().equals(prop.getType().getName())) {
						for(FMProperty propInner : clInner.getProperties()) {
							if(cl.getName().equals(propInner.getType().getName())) {
								JOptionPane.showMessageDialog(null, cl.getName()+clInner.getName() +prop.getIsOwnerOf());
								associations.add(new Association(propInner, prop));
								break;
							}
						}
						break;
					}
				}
			}
			try {
				out = getWriter(cl.getName() + "Configuration", cl.getTypePackage());
				if (out != null) {
					context.clear();
					context.put("class", cl);
					context.put("properties", cl.getProperties());
					context.put("associations", associations);
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
}

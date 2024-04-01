import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class UserService {

  constructor(private http: HttpClient) { } 
  
FreeMarker template error (DEBUG mode; use RETHROW in production!):
The following has evaluated to null or missing:
==> class.crud  [in template "service.ftl" at line 13, column 8]

----
Tip: It's the step after the last dot that caused this error, not those before it.
----
Tip: If the failing expression is known to legally refer to something that's sometimes null or missing, either specify a default value like myOptionalVar!myDefault, or use <#if myOptionalVar??>when-present<#else>when-missing</#if>. (These only cover the last step of the expression; to cover the whole expression, use parenthesis: (myOptionalVar.foo)!myDefault, (myOptionalVar.foo)??
----

----
FTL stack trace ("~" means nesting-related):
	- Failed at: #if class.crud.read == true  [in template "service.ftl" at line 13, column 3]
----

Java stack trace (for programmers):
----
freemarker.core.InvalidReferenceException: [... Exception message was already printed; see it above ...]
	at freemarker.core.InvalidReferenceException.getInstance(InvalidReferenceException.java:134)
	at freemarker.core.UnexpectedTypeException.newDescriptionBuilder(UnexpectedTypeException.java:85)
	at freemarker.core.UnexpectedTypeException.<init>(UnexpectedTypeException.java:48)
	at freemarker.core.NonHashException.<init>(NonHashException.java:49)
	at freemarker.core.Dot._eval(Dot.java:48)
	at freemarker.core.Expression.eval(Expression.java:101)
	at freemarker.core.EvalUtil.compare(EvalUtil.java:113)
	at freemarker.core.ComparisonExpression.evalToBoolean(ComparisonExpression.java:78)
	at freemarker.core.ConditionalBlock.accept(ConditionalBlock.java:48)
	at freemarker.core.Environment.visit(Environment.java:334)
	at freemarker.core.Environment.visit(Environment.java:340)
	at freemarker.core.Environment.process(Environment.java:313)
	at freemarker.template.Template.process(Template.java:383)
	at myplugin.generator.ServiceGenerator.generate(ServiceGenerator.java:41)
	at myplugin.GenerateAction.generateService(GenerateAction.java:138)
	at myplugin.GenerateAction.actionPerformed(GenerateAction.java:48)
	at javax.swing.AbstractButton.fireActionPerformed(Unknown Source)
	at javax.swing.AbstractButton$Handler.actionPerformed(Unknown Source)
	at javax.swing.DefaultButtonModel.fireActionPerformed(Unknown Source)
	at javax.swing.DefaultButtonModel.setPressed(Unknown Source)
	at javax.swing.AbstractButton.doClick(Unknown Source)
	at com.jidesoft.plaf.vsnet.VsnetMenuItemUI.doClick(Unknown Source)
	at com.jidesoft.plaf.vsnet.VsnetMenuItemUI$MouseInputHandler.mouseReleased(Unknown Source)
	at java.awt.Component.processMouseEvent(Unknown Source)
	at javax.swing.JComponent.processMouseEvent(Unknown Source)
	at java.awt.Component.processEvent(Unknown Source)
	at java.awt.Container.processEvent(Unknown Source)
	at java.awt.Component.dispatchEventImpl(Unknown Source)
	at java.awt.Container.dispatchEventImpl(Unknown Source)
	at java.awt.Component.dispatchEvent(Unknown Source)
	at java.awt.LightweightDispatcher.retargetMouseEvent(Unknown Source)
	at java.awt.LightweightDispatcher.processMouseEvent(Unknown Source)
	at java.awt.LightweightDispatcher.dispatchEvent(Unknown Source)
	at java.awt.Container.dispatchEventImpl(Unknown Source)
	at java.awt.Window.dispatchEventImpl(Unknown Source)
	at java.awt.Component.dispatchEvent(Unknown Source)
	at java.awt.EventQueue.dispatchEventImpl(Unknown Source)
	at java.awt.EventQueue.access$200(Unknown Source)
	at java.awt.EventQueue$3.run(Unknown Source)
	at java.awt.EventQueue$3.run(Unknown Source)
	at java.security.AccessController.doPrivileged(Native Method)
	at java.security.ProtectionDomain$1.doIntersectionPrivilege(Unknown Source)
	at java.security.ProtectionDomain$1.doIntersectionPrivilege(Unknown Source)
	at java.awt.EventQueue$4.run(Unknown Source)
	at java.awt.EventQueue$4.run(Unknown Source)
	at java.security.AccessController.doPrivileged(Native Method)
	at java.security.ProtectionDomain$1.doIntersectionPrivilege(Unknown Source)
	at java.awt.EventQueue.dispatchEvent(Unknown Source)
	at com.nomagic.utils.EventTracker.dispatchEvent(EventTracker.java:33)
	at java.awt.EventDispatchThread.pumpOneEventForFilters(Unknown Source)
	at java.awt.EventDispatchThread.pumpEventsForFilter(Unknown Source)
	at java.awt.EventDispatchThread.pumpEventsForHierarchy(Unknown Source)
	at java.awt.EventDispatchThread.pumpEvents(Unknown Source)
	at java.awt.EventDispatchThread.pumpEvents(Unknown Source)
	at java.awt.EventDispatchThread.run(Unknown Source)

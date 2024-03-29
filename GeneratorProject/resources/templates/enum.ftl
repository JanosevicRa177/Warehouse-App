namespace BackendProject.Model.${enum.typePackage};

public enum ${enum.name}
{  
<#list enum.values as value>
      ${value?upper_case},
</#list>
}
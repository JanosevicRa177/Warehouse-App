using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

<#if type == "create">
public class ${name}Handler : ICommandHandler<${name}, int> {

	private readonly I${classname}Repository _repository;
	
	public ${name}Handler (I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task<int> Handle(${name} request, CancellationToken cancellationToken) {
	   var ${classname[0]?lower_case + classname[1..]} = await _repository.Create(request.${classname});
	   return ${classname[0]?lower_case + classname[1..]}.Id;
	}
}
</#if>
<#if type == "update">
public class ${name}Handler : ICommandHandler<${name}> {
	private I${classname}Repository _repository;
	
	public ${name}Handler (I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task Handle(${name} request, CancellationToken cancellationToken) {
		var ${classname[0]?lower_case + classname[1..]} = _repository.Find(request.Id);
		if(${classname[0]?lower_case + classname[1..]} is null) return;
		${classname[0]?lower_case + classname[1..]}.Update(request.Update${classname}Dto);
		_repository.Update(${classname[0]?lower_case + classname[1..]});
	}
}
</#if>
<#if type == "delete">
public class ${name}Handler : ICommandHandler<${name}> {
		private I${classname}Repository _repository;
	
	public ${name}Handler (I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task Handle(${name} request, CancellationToken cancellationToken) {
		var ${classname[0]?lower_case + classname[1..]} = _repository.Find(request.Id);
		if(${classname[0]?lower_case + classname[1..]} is null) return;
		_repository.Delete(${classname[0]?lower_case + classname[1..]});
	}
}
</#if>

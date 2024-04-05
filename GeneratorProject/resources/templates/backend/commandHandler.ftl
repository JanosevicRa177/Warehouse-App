using BackendProject.Infrastructure.Interfaces;


<#if type == "create">
class ${name}Handler : ICommandHandler<${name}, Guid> {

	private I${classname}Repository _repository;
	
	public ${name}(I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(${name} request, CancellationToken cancellationToken) {
	   ${classname} obj = await _repository.Create(request.obj);
	   return obj.Id;
	}
}
</#if>


<#if type == "update">
class ${name}Handler : ICommandHandler<${name}, Guid> {
	private I${classname}Repository _repository;
	
	public ${name}(I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(${name} request, CancellationToken cancellationToken) {
		${classname} existingObj = await _repository.Find(request.obj.Id);
		if(obj is null) return;
		await existingObj.Update(request.obj);
		return existingObj.Id;
	}
}
</#if>

<#if type == "delete">
class ${name}Handler : ICommandHandler<${name}> {
		private I${classname}Repository _repository;
	
	public ${name}(I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task<Guid> Handle(${name} request, CancellationToken cancellationToken) {
		await _repository.Delete(request.Id);
	}
}
</#if>

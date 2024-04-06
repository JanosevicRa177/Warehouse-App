using BackendProject.Infrastructure.Interfaces;


<#if type == "readAll">
class ${name}Handler : IQueryHandler<${name}, List<${classname}>> {

	private I${classname}Repository _repository;
	
	public ${name}(I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task<List<${classname}>> Handle(${name} request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}
</#if>


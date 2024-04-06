using BackendProject.Application.Interfaces;
using BackendProject.Infrastructure.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Queries;


<#if type == "readAll">
public class ${name}Handler : IQueryHandler<${name}, IEnumerable<${classname}>> {

	private readonly I${classname}Repository _repository;
	
	public ${name}Handler (I${classname}Repository repository) {
		_repository = repository;
	}
	
	public async Task<IEnumerable<${classname}>> Handle(${name} request, CancellationToken cancellationToken) {
	   return _repository.FindAll();
	}
}
</#if>


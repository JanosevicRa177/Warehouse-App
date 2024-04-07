using BackendProject.Application.Interfaces;
using BackendProject.WebApi.Dtos;

namespace BackendProject.Application.Commands;

public sealed record UpdateReceiptCommand(UpdateReceiptDto UpdateReceiptDto, int Id) : ICommand;

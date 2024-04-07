using BackendProject.Application.Interfaces;
using BackendProject.WebApi.Dtos;

namespace BackendProject.Application.Commands;

public sealed record UpdateReceiptItemCommand(UpdateReceiptItemDto UpdateReceiptItemDto, int Id) : ICommand;

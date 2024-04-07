using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;

public sealed record UpdateReceiptCommand(Receipt Receipt) : ICommand;

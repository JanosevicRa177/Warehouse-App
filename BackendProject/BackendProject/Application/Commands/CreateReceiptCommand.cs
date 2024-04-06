using BackendProject.Application.Interfaces;
using BackendProject.Model;

namespace BackendProject.Application.Commands;



public sealed record CreateReceiptCommand(Receipt Receipt) : ICommand<int>;



using dotnet_banking_api.Domain;
using dotnet_banking_api.Dtos;
using dotnet_banking_api.Repositories;

namespace dotnet_banking_api.Services;

public interface IContaService
{
    
}

public class ContaService : IContaService
{
    private readonly IContaRepository _repo;

    public ContaService(IContaRepository repo) => _repo = repo;

    //preciso criar os metodos 
    // listar as contas, criar, atualizar e remover
    
}

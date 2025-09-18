using dotnetBanking.Api.Domain;
using dotnetBanking.Api.Dtos;
using dotnetBanking.Api.Repositories;
namespace dotnetBanking.Api.Services;

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

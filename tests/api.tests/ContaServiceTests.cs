using System.Threading;
using System.Threading.Tasks;
using dotnetBanking.Api.Domain;
using dotnetBanking.Api.Dtos;
using dotnetBanking.Api.Repositories;
using dotnetBanking.Api.Services;
using Moq;
using Xunit;

namespace api.tests;

public class ContaServiceTests
{
    [Fact]
    public async Task Criar()
    {
        
        var repo = new Mock<IContaRepository>();
        //estudar como isso aqui funcionna
        
    }
}

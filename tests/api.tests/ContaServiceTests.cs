using System.Threading;
using System.Threading.Tasks;
using api.Domain;
using api.Dtos;
using api.Repositories;
using api.Services;
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

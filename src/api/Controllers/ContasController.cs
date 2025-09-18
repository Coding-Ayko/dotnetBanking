using dotnetBanking.Api.Dtos;
using dotnetBanking.Api.Services;
using Microsoft.AspNetCore.Mvc;
namespace dotnetBanking.Api.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class ContasController : ControllerBase
{
    private readonly IContaService _service;
    public ContasController(IContaService service) => _service = service;

    [HttpGet]


    [HttpGet("{id:int}")]


    [HttpPost]


    [HttpPut("{id:int}")]
   

    [HttpDelete("{id:int}")]
    
}

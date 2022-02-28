using Microsoft.AspNetCore.Mvc;

namespace APISaudacoes.Controllers;

[ApiController]
[Route("[controller]")]
public class SaudacoesController : ControllerBase
{
    private readonly ILogger<SaudacoesController> _logger;

    public SaudacoesController(ILogger<SaudacoesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public ActionResult<Saudacao> Get(string? nome = null)
    {
        _logger.LogInformation($"Valor recebido: {nome}");

        if (String.IsNullOrWhiteSpace(nome))
            return BadRequest();

        return new Saudacao()
        {
            Mensagem = $"Boa noite {nome}!!!"
        };
    }
}
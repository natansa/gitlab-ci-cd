using CiCd.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CiCd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get")]
        public IActionResult GetPessoa([FromQuery] int id)
        {
            _logger.LogInformation("Obter Pessoa: {0}", id);

            var pessoa = new Pessoa(id, "Nome da Pessoa", new Endereco("Nome da Rua", "Nome da Cidade"), true);

            return Ok(pessoa);
        }

        [HttpPost("create")]
        public IActionResult CreatePessoa([FromBody] Pessoa pessoa)
        {
            var pessoaString = JsonSerializer.Serialize(pessoa);
            _logger.LogInformation($"Criar Pessoa: {pessoaString}");
            var uri = $"{Request.Scheme}://{Request.Host}/pessoa/get?id={1}";
            return Created(new Uri(uri), pessoa);
        }
    }
}
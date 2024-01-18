using Domain.Commands;
using Domain.Enum;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        private readonly IVeiculoService _veiculoService;
        public VeiculoController(IVeiculoService veiculoService)
        {
            _veiculoService = veiculoService;
        }
        [HttpPost]
        [Route("CadastrarVeiculos")]
        public async Task<IActionResult> PostAsync([FromBody] VeiculoCommand command)
        {
            return Ok(await _veiculoService.PostAsync(command));
        }
        [HttpGet]
        [Route("SimularAluguel")]
        public async Task< IActionResult> GetAsync(int DiasSimulacaoAluguel, ETipoVeiculo tipoVeiculo)
        { 
            return Ok(_veiculoService.SImularVeiculoAluguel(DiasSimulacaoAluguel, tipoVeiculo));
        }
        [HttpGet]
        [Route("VeiculosAlugados")]
        public async Task<IActionResult> GetVeiculosAlugadosAsync()
        {
            return Ok(await _veiculoService.GetVeiculosAlugadosAsync());
        }

    }
}

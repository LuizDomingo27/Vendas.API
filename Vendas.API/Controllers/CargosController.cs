using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Vendas.API.Model;
using Vendas.API.Repository;

namespace Vendas.API.Controllers
{
	[Authorize]
	[Route("[controller]")]
	[ApiController]
	public class CargosController : ControllerBase
	{
		private readonly IEmployeRepository _employeRepository;
		public CargosController(IEmployeRepository employe)
		{
			_employeRepository = employe;
		}

		[HttpGet("{Cargo}")]
		public async Task<ActionResult<List<Employes>>> GetPorCargo(string cargo)
		{
			var cargos = await _employeRepository.GetCargo(cargo);
			return cargos;
		}
	}
}

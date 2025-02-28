using Microsoft.AspNetCore.Mvc;

using Vendas.API.Model;
using Vendas.API.Repository;

namespace Vendas.API.Controllers;

[Route("[controller]")]
[ApiController]
public class SalesController : Controller
{
	private readonly IEmployeRepository _employeRepository;
	public SalesController(IEmployeRepository employeRepository)
	{
		_employeRepository = employeRepository;
	}

	[HttpGet("{cargo}")]
	public async Task<ActionResult<List<Employes>>> GetPorCargo(string cargo)
	{
		var employesCargo = await _employeRepository.GetCargo(cargo);
		return employesCargo;
	}

	[HttpGet]
	public async Task<ActionResult<List<Employes>>> GetEmployeHigh()
	{
		var employesSalary = await _employeRepository.GetSalesHigherThen();
		return employesSalary;
	}
}

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
	[ProducesResponseType(typeof(Employes), StatusCodes.Status404NotFound)]
	[ProducesResponseType(typeof(Employes), StatusCodes.Status200OK)]
	public async Task<ActionResult<List<Employes>>> GetPorCargo(string cargo)
	{
		var employesCargo = await _employeRepository.GetCargo(cargo);

		if (employesCargo.Count == 0)
			return NotFound();
		else return employesCargo;
	}

	[HttpGet("{valueOne}/{valueTwo}")]
	public async Task<ActionResult<List<Employes>>> GetEmployeHigh(int valueOne, int valueTwo)
	{
		var employesSalary = await _employeRepository.GetSalesHigherThen(valueOne, valueTwo);
		return employesSalary;
	}

	[HttpGet]
	public async Task<ActionResult<List<Employes>>> GetAllEmployes()
	{
		var employes = await _employeRepository.GetAllSales();
		return employes;
	}
}

using Microsoft.AspNetCore.Mvc;

using Vendas.API.Interface;
using Vendas.API.Model;

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

	[HttpGet("{Estado:alpha}")]
	public async Task<ActionResult<List<Employes>>> GetEstate(string Estado)
	{
		var emp = await _employeRepository.GetSalesByState(Estado);
		return emp;
	}
}

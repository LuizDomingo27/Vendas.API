using Microsoft.EntityFrameworkCore;

using Vendas.API.DataContex;
using Vendas.API.Model;

namespace Vendas.API.Repository;

public class EmployeRepository : IEmployeRepository
{
	private readonly EmployesContext _context;

	public EmployeRepository(EmployesContext context) => _context = context;

	public async Task<List<Employes>> GetAllSales()
	{
		return await _context.Employes.ToListAsync();
	}

	public async Task<List<Employes>> GetSalesHigherThen(int valueOne, int valueTwo)
	{
		return await _context.Employes.Where(v => v.Salario > valueOne && v.Salario < valueTwo).ToListAsync();
	}

	public async Task<List<Employes>> GetCargo(string cargo)
	{
		return await _context.Employes.Where(c => c.Cargo!.StartsWith(cargo)).ToListAsync();
	}

	public async Task<List<Employes>> GetSalesByState(string state)
	{
		return await _context.Employes.Where(s => s.Estado!.Equals(state.Trim())).ToListAsync();
	}
}
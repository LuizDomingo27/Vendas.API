using Microsoft.EntityFrameworkCore;

using Vendas.API.DataContex;
using Vendas.API.Model;

namespace Vendas.API.Repository;

public class EmployeRepository : IEmployeRepository
{
	//Criamos a injeção de dependência para usarmos a class SaleContext
	private readonly EmployesContext _context;

	public EmployeRepository(EmployesContext context) => _context = context;

	public async Task<List<Employes>> GetAllSales()
	{
		return await _context.Employes.ToListAsync();
	}

	public async Task<List<Employes>> GetSalesHigherThen()
	{
		return await _context.Employes.Where(v => v.Salario > 2250 && v.Salario < 8000).ToListAsync();
	}

	public async Task<List<Employes>> GetCargo(string cargo)
	{
		return await _context.Employes.Where(c => c.Cargo!.Equals(cargo)).ToListAsync();
	}
}
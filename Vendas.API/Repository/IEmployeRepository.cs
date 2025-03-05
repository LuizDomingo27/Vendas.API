using Vendas.API.Model;

namespace Vendas.API.Repository;

public interface IEmployeRepository
{
	//Quero retornar todas os sales -> vendas
	Task<List<Employes>> GetAllSales();

	//Retornar sales com criterios
	Task<List<Employes>> GetCargo(string cargo);

	Task<List<Employes>> GetSalesHigherThen(int valueOne, int valueTwo);

	Task<List<Employes>> GetSalesByState(string state);
}
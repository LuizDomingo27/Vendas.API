using Vendas.API.Model;

namespace Vendas.API.Interface;

public interface IEmployeRepository
{
	//Quero retornar todas os sales -> vendas
	Task<List<Employes>> GetAllSales();

	//Retornar sales com criterios
	Task<List<Employes>> GetCargo(string cargo);

	Task<List<Employes>> GetSalesHigherThen(int valueOne, int valueTwo);

	Task<List<Employes>> GetSalesByState(string state);

	Task<List<Employes>> GetWithVariousCriteriau(string state, string cargo, int valueOne, int valueTwho);
}
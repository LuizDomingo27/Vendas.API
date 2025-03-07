using Vendas.API.Model;
using Vendas.API.Repository;

namespace FrontVendas.Services;

public class SearchDadosApi
{
	private readonly string _urlBaseApi = UrlBaseApi.UrlBaseSales;
	public SearchDadosApi() { }

	public async Task<List<Employes>?> GetAllEmployAsync()
	{
		List<Employes> lista = [];
		return await DeserialiseJson.GetT(lista, _urlBaseApi + "Sales");

		/*
			var cliente = new RestClient();
			var request = new RestRequest(urlBaseApi, Method.Get);
			RestResponse response = await cliente.ExecuteAsync(request);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				return JsonConvert.DeserializeObject<List<Employes>>(response.Content!);
			}
			else { return null; }
		*/
	}

	public async Task<List<Employes>?> GetEmployAsyncCargo(string cargo)
	{
		List<Employes> lista = [];
		return await DeserialiseJson.GetT(lista, $"{_urlBaseApi}Cargos/{cargo}");
		/*
			var cliente = new RestClient();
			var request = new RestRequest($"{urlBaseApi}/{cargo}", Method.Get);
			RestResponse response = await cliente.ExecuteAsync(request);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				return JsonConvert.DeserializeObject<List<Employes>>(response.Content!);
			}
			else { return null; }
		*/
	}

	public async Task<List<Employes>?> GetEmployesSalary(int valueOne, int valueTwo)
	{
		List<Employes> lista = [];
		return await DeserialiseJson.GetT(lista, $"{_urlBaseApi}Sales/{valueOne}/{valueTwo}");
	}

	public async Task<List<Employes>?> GetEmployesState(string estado)
	{
		List<Employes> lista = [];
		return await DeserialiseJson.GetT(lista, $"{_urlBaseApi}Sales/{estado}");
	}
}
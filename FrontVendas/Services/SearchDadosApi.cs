using Vendas.API.Model;

namespace FrontVendas.Services;

public class SearchDadosApi
{
	private readonly string urlBaseApi = "https://localhost:7237/Sales";
	public SearchDadosApi() { }

	public async Task<List<Employes>?> GetAllEmployAsync()
	{
		List<Employes> lista = [];
		return await DeserialiseJson.GetT(lista, urlBaseApi);

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

	//Buscando os colaboradores por cargo
	public async Task<List<Employes>?> GetEmployAsyncCargo(string cargo)
	{
		List<Employes> lista = [];
		return await DeserialiseJson.GetT(lista, $"{urlBaseApi}/{cargo}");
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
}
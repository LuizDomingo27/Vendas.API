using System.Collections.Generic;
using System.Threading.Tasks;

using FrontEndDeskTop.Model;

namespace FrontEndDeskTop.Service
{
	class SearchDadosAPI
	{
		private const string _urlBaseApi = "https://localhost:7237/";
		public SearchDadosAPI() { }

		public async Task<List<EmployesDesk>> GetAllEmployAsync()
		{
			List<EmployesDesk> lista = new List<EmployesDesk>();
			return await JsonDeserializerDeskTop.GetDeserialize(lista, _urlBaseApi + "Sales");

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

		public async Task<List<EmployesDesk>> GetEmployAsyncCargo(string cargo)
		{
			List<EmployesDesk> lista = new List<EmployesDesk>();
			return await JsonDeserializerDeskTop.GetDeserialize(lista, $"{_urlBaseApi}Cargos/{cargo}");
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

		public async Task<List<EmployesDesk>> GetEmployesSalary(int valueOne, int valueTwo)
		{
			List<EmployesDesk> lista = new List<EmployesDesk>();
			return await JsonDeserializerDeskTop.GetDeserialize(lista, $"{_urlBaseApi}Sales/{valueOne}/{valueTwo}");
		}
		
		public async Task<List<EmployesDesk>> GetEmployesState(string estado)
		{
			List<EmployesDesk> lista = new List<EmployesDesk>();
			return await JsonDeserializerDeskTop.GetDeserialize(lista, $"{_urlBaseApi}Sales/{estado}");
		}

		public async Task<List<UsersDesk>> GetUsers()
		{
			List<UsersDesk> lista = new List<UsersDesk>();
			return await JsonDeserializerDeskTop.GetDeserialize(lista, $"{_urlBaseApi}User");
		}
	}
}

using System.Text;

using Newtonsoft.Json;

using Vendas.API.Repository;

namespace FrontVendas.Services;

public class JsonSerializer
{
	private readonly HttpClient _client = new HttpClient();
	private readonly string _urlBaseApi = UrlBaseApi.UrlBaseSales;

	public async Task SerializeObject<T>(T obj)
	{
		var json = JsonConvert.SerializeObject(obj);
		var contente = new StringContent(json, Encoding.UTF8, "application/json");
		var response = await _client.PostAsync($"{_urlBaseApi}User/register", contente);
		response.EnsureSuccessStatusCode();
	}
}

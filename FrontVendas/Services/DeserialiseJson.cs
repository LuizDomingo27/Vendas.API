using Newtonsoft.Json;

using RestSharp;

namespace FrontVendas.Services;

public class DeserialiseJson
{
	public static async Task<T?> GetT<T>(T obj, string url = null!)
	{
		var cliente = new RestClient();
		var request = new RestRequest(url, Method.Get);
		RestResponse response = await cliente.ExecuteAsync(request);

		if (response.StatusCode == System.Net.HttpStatusCode.OK)
		{
			return JsonConvert.DeserializeObject<T>(response.Content!);
		}
		else { return obj; }
	}
}

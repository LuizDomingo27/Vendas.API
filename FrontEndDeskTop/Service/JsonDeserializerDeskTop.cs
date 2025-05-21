using Newtonsoft.Json;

using RestSharp;

using System.Threading.Tasks;

namespace FrontEndDeskTop.Service
{
	public class JsonDeserializerDeskTop
	{
		public static async Task<T> GetDeserialize<T>(T obj, string url = null)
		{
			var cliente = new RestClient();
			var request = new RestRequest(url, Method.Get);
			RestResponse response = await cliente.ExecuteAsync(request);

			if (response.StatusCode == System.Net.HttpStatusCode.OK)
			{
				return JsonConvert.DeserializeObject<T>(response.Content);
			}
			else { return obj; }
		}
	}
}

using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace FrontEndDeskTop.Service
{
	public class JsonSerializerDeskTop
	{
		private const string _urlBaseApi = "https://localhost:7237/";
		private readonly HttpClient _client = new HttpClient();

		public async Task SerializeObject<T>(T obj)
		{
			var json = JsonConvert.SerializeObject(obj);
			var contente = new StringContent(json, Encoding.UTF8, "application/json");
			var response = await _client.PostAsync($"{_urlBaseApi}User/register", contente);
			response.EnsureSuccessStatusCode();
		}
	}
}

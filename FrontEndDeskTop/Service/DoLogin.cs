using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FrontEndDeskTop.Model;

namespace FrontEndDeskTop.Service
{
	public class DoLogin
	{
		public DoLogin() { }

		public async Task<bool> Login(string email, string password)
		{
			SearchDadosAPI dadosAPI = new SearchDadosAPI();
			List<UsersDesk> dados = await dadosAPI.GetUsers();
			bool res = dados.Any(x => x.Email == email && CryptyPassword.Verify(password, x.Password));
			return res;
		}
	}
}

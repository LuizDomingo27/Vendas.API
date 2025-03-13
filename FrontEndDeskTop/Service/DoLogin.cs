using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrontEndDeskTop.Model;

namespace FrontEndDeskTop.Service
{
	public class DoLogin
	{
		public object Encrypt { get; private set; }

		public async Task<bool> Login(string email, string password)
		{
			SearchDadosAPI search = new SearchDadosAPI();
			List<UsersDesk> use = await search.GetUsers();

			if (email == string.Empty || password == string.Empty)
			{
				MessageBox.Show("Preencha todos os campos!");
				return false;
			}

			if (use.Any(u => u.Email == email && CryptyPassword.Verify(password, u.Password)))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}

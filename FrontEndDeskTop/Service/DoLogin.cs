using System.Threading.Tasks;
using System.Windows.Forms;

using FrontEndDeskTop.Model;

namespace FrontEndDeskTop.Service
{
	public class DoLogin
	{
		public DoLogin() { }

		public async Task<bool> Login(string email, string password)
		{
			if (email == string.Empty || password == string.Empty)
			{
				MessageBox.Show("Preencha todos os campos!");
				return false;
			}

			LoginUser loginUser = new LoginUser
			{
				Email = email,
				Password = password
			};

			var res = await JsonSerializerDeskTop.SerializeEmail(loginUser);
			return res;
		}
	}
}

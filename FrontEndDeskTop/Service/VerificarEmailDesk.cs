using System.Threading.Tasks;

namespace FrontEndDeskTop.Service
{
	public class VerificarEmailDesk
	{
		public async Task<bool> Verificar(string email)
		{
			SearchDadosAPI dados = new SearchDadosAPI();
			var users = await dados.GetUsers();
			bool emailValid = false;

			for (int i = 0; i < users.Count; i++)
			{
				if (users[i].Email == email)
				{
					emailValid = true;
					break;
				}
			}
			return emailValid;
		}
	}
}
namespace FrontVendas.Services;

public class VerificarEmail
{
	public async Task<bool> Verificar(string email)
	{
		SearchDadosApi dados = new();
		var users = await dados.GetUsers();
		bool emailValid = false;

		for (int i = 0; i < users!.Count; i++)
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

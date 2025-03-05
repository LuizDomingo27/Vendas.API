namespace Vendas.API.Repository;

public class EncryptyPasword : IEncryptyPassword
{
	public string Encrypty(string password)
	{
		return BCrypt.Net.BCrypt.HashPassword(password);
	}
}

using Vendas.API.Repository;

namespace Vendas.API.Criptographia;

public class EncryptyPasword : IEncryptyPassword
{
	public string Encrypty(string password)
	{
		return BCrypt.Net.BCrypt.HashPassword(password);
	}
}

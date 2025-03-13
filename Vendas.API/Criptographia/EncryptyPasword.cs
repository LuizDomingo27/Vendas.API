using Vendas.API.Repository;

namespace Vendas.API.Criptographia;

public class EncryptyPasword : IEncryptyPassword
{
	public string Encrypty(string password) => BCrypt.Net.BCrypt.HashPassword(password);

	public bool Verify(string password, string hash) => BCrypt.Net.BCrypt.Verify(password, hash);

}

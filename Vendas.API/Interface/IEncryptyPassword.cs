namespace Vendas.API.Repository;

public interface IEncryptyPassword
{
	public string Encrypty(string password);
	public bool Verify(string password, string has);
}

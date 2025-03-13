namespace Vendas.API.Interface;

public interface IGeneratorToken
{
	public string GenerateToken(Guid userIdentier);
}

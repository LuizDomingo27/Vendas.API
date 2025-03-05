namespace Vendas.API.Domain;

public interface IGeneratorToken
{
	public string GenerateToken(Guid userIdentier);
}

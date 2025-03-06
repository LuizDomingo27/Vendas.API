namespace Vendas.API.Model;

public class ResponseUserRegister
{
	public string? Email { get; set; }
	public string? Token { get; set; }
	public Guid UserIdentifier { get; set; }
}

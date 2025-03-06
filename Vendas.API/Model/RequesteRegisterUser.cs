namespace Vendas.API.Model;

public class RequesteRegisterUser
{
	public string? Email { get; set; }
	public string? Password { get; set; } = null;
	public string? ConfirmPassword { get; set; } = null;
}

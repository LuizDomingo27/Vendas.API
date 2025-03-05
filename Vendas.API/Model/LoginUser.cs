using System.ComponentModel.DataAnnotations;

namespace Vendas.API.Model;

public class LoginUser
{
	[Required(ErrorMessage = "O campo {0} é obrigatório.")]
	[EmailAddress(ErrorMessage = "O campo {0} está em formato inválido.")]
	public string Email { get; set; } = string.Empty;

	[Required(ErrorMessage = "O campo {0} é obrigatório.")]
	[StringLength(100, ErrorMessage = "O campo {0} deve ter entre {2} e {1} caracteres.", MinimumLength = 6)]
	public string Password { get; set; } = string.Empty;
}

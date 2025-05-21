using FluentValidation;

using FrontEndDeskTop.Model;

namespace FrontEndDeskTop.Validator
{
	public class ValidatorLogin : AbstractValidator<LoginUser>
	{
		public ValidatorLogin()
		{
			RuleFor(atributo => atributo.Email).EmailAddress().WithMessage("E-mail inválido");
			RuleFor(atributo => atributo.Password.Length).GreaterThanOrEqualTo(6).WithMessage("Caractere insuficiente");
		}
	}
}

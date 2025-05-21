using FluentValidation;

using FrontEndDeskTop.Model;

namespace FrontEndDeskTop.Validator
{
	public class ValidateUser : AbstractValidator<RequesteRegisterUser>
	{
		public ValidateUser()
		{
			RuleFor(atributo => atributo.Email).EmailAddress().WithMessage("E-mail inválido");
			RuleFor(atributo => atributo.Email).Empty().WithMessage("Campo e-mail está vazio.");
			RuleFor(atributo => atributo.Password.Length).GreaterThanOrEqualTo(6).WithMessage("Caractere insuficiente");
			RuleFor(atributo => atributo.Password).Equal(a => a.ConfirmPassword).WithMessage("Senhas não confere");
		}
	}
}

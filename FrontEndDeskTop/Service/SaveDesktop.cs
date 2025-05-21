using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrontEndDeskTop.Model;
using FrontEndDeskTop.Validator;

namespace FrontEndDeskTop.Service
{
	public class SaveDesktop
	{
		private readonly VerificarEmailDesk _verificarEmailDesk = new VerificarEmailDesk();
		private readonly ValidateUser _validateUser = new ValidateUser();
		public SaveDesktop() { }

		public async Task Save(string email, string password, string confirmPass)
		{
			bool emailValid = await _verificarEmailDesk.Verificar(email);

			if (emailValid)
			{
				MessageBox.Show("Email já cadastrado");
				return;
			}

			var user = new RequesteRegisterUser
			{
				Email = email,
				Password = password,
				ConfirmPassword = confirmPass
			};

			var result = _validateUser.Validate(user);

			if (result.IsValid == false)
			{
				IEnumerable<string> messageErro = result.Errors.Select(e => e.ErrorMessage);
				MessageBox.Show(string.Join("\nou ", messageErro));
				return;
			}

			await JsonSerializerDeskTop.SerializeObject(user);
			MessageBox.Show("Usuário cadastrado com sucesso");
		}
	}
}

using System.Threading.Tasks;
using System.Windows.Forms;

using FrontEndDeskTop.Model;

namespace FrontEndDeskTop.Service
{
	public class SaveDesktop
	{
		private readonly VerificarEmailDesk _verificarEmailDesk = new VerificarEmailDesk();
		public SaveDesktop() { }

		public async Task Save(string email, string password, string confirmPass)
		{
			if (email == string.Empty || password == string.Empty || password != confirmPass)
			{
				MessageBox.Show("Preencha todos os campos corretamente\n Verifique se a senha são iguais.");
				return;
			}

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

			await JsonSerializerDeskTop.SerializeObject(user);
			MessageBox.Show("Usuário cadastrado com sucesso");
		}
	}
}

using Vendas.API.Interface;
using Vendas.API.Model;
using Vendas.API.Repository;

namespace FrontVendas.Services;

public class SaveUser
{
	private readonly VerificarEmail _verificarEmail = new();
	
	public SaveUser()
	{
	}
	
	public async Task Save(string email, string password, string confirmPass)
	{
		if (email == string.Empty || password == string.Empty || password != confirmPass)
		{
			MessageBox.Show("Preencha todos os campos corretamente\n Verifique se a senha são iguais.");
			return;
		}

		bool emailValid = await _verificarEmail.Verificar(email);

		if (emailValid)
		{
			MessageBox.Show("Email já cadastrado");
			return;
		}

		var user = new RequesteRegisterUser()
		{
			Email = email,
			Password = password,
			ConfirmPassword = confirmPass
		};
		JsonSerializer json = new();
		await json.SerializeObject(user);
		MessageBox.Show("Usuário cadastrado com sucesso");
	}
}

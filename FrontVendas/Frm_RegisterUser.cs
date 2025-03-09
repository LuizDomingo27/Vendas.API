using FrontVendas.Services;

using Vendas.API.Controllers;
using Vendas.API.Interface;

namespace FrontVendas;

public partial class Frm_RegisterUser : Form
{
	private readonly JsonSerializer? _jsonSerializer;
	public Frm_RegisterUser()
	{
		InitializeComponent();
		this._jsonSerializer = new JsonSerializer();
	}

	private void Btn_Voltar_Login_Click(object sender, EventArgs e)
	{
		this.Close();
		Thread thread = new(() => Application.Run(new Frm_Login()));
		thread.Start();
	}

	private void guna2ControlBox1_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private async void Btn_Creat_User_Click(object sender, EventArgs e)
	{
		string email = TxtEmail_Cad.Text;
		string password = Txt_PassCreate.Text;
		string confirmPass = TxtPassConfirm_Create.Text;

		SaveUser save = new();
		await save.Save(email, password, confirmPass);
		LimparCampos();
	}

	public void LimparCampos()
	{
		TxtEmail_Cad.ResetText();
		Txt_PassCreate.ResetText();
		TxtPassConfirm_Create.ResetText();
	}
}

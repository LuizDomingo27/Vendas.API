using Vendas.API.Interface;

namespace FrontVendas;

public partial class Frm_Login : Form
{
	private readonly IUserRepository? _userRepository;
	public Frm_Login()
	{
		InitializeComponent();
	}

	private void BtnCreate_Click(object sender, EventArgs e)
	{
		this.Close();
		Thread thread = new(() => Application.Run(new Frm_RegisterUser()));
		thread.Start();
	}

	private void guna2ControlBox1_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}
}

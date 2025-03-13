using System;
using System.Threading;
using System.Windows.Forms;

using FrontEndDeskTop.Service;

namespace FrontEndDeskTop.Views
{
	public partial class Frm_Login : Form
	{
		private DoLogin _login;

		public Frm_Login()
		{
			InitializeComponent();
			_login = new DoLogin();
		}

		private void Btn_createAcount_Click(object sender, EventArgs e)
		{
			this.Close();
			Thread thread = new Thread(() => Application.Run(new FrmCadUser()));
			thread.Start();
		}

		private async void Btn_Login_Click(object sender, EventArgs e)
		{
			bool result = await _login.Login(txt_email_login.Text, Txt_passLogin.Text);

			if (result == true)
			{
				MessageBox.Show("Login efetuado com sucesso!");
				this.Close();
				Thread thread = new Thread(() => Application.Run(new FrmEmployes()));
				thread.Start();
			}
			else
			{
				MessageBox.Show("Email ou senha incorretos!");
				return;
			}
		}
	}
}

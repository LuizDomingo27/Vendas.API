using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

using FluentValidation.Results;

using FrontEndDeskTop.Model;
using FrontEndDeskTop.Service;
using FrontEndDeskTop.Validator;

namespace FrontEndDeskTop.Views
{
	public partial class Frm_Login : Form
	{
		private readonly DoLogin _login;
		private readonly ValidatorLogin _validateLogin = new ValidatorLogin();

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

			LoginUser loginUser = new LoginUser
			{
				Email = txt_email_login.Text,
				Password = Txt_passLogin.Text
			};

			ValidationResult result = _validateLogin.Validate(loginUser);

			if (result.IsValid == false)
			{
				IEnumerable<string> messageErro = result.Errors.Select(er => er.ErrorMessage);
				MessageBox.Show(string.Join("\nou ", messageErro));
				return;
			}

			bool res = await _login.Login(txt_email_login.Text, Txt_passLogin.Text);

			if (res == true)
			{
				MessageBox.Show("Login efetuado com sucesso!");
				this.Close();
				Thread thread = new Thread(() => Application.Run(new FrmEmployes()));
				thread.Start();
			}
			else { MessageBox.Show("Email ou senha incorretos!"); }
		}
	}
}

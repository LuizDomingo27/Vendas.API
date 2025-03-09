using System;
using System.Windows.Forms;

using FrontEndDeskTop.Model;
using FrontEndDeskTop.Service;

namespace FrontEndDeskTop.Views
{
	public partial class FrmCadUser : Form
	{
		public FrmCadUser()
		{
			InitializeComponent();
		}

		private async void BtnSalvarUser_Click(object sender, EventArgs e)
		{
			string email = TxtEmailUser.Text;
			string password = TxtPassUser.Text;
			string confirmPass = TxtConfirmPass.Text;

			SaveDesktop save = new SaveDesktop();
			await save.Save(email, password, confirmPass);
			LimparCampos();
		}

		public void LimparCampos()
		{
			TxtEmailUser.ResetText();
			TxtConfirmPass.ResetText();
			TxtPassUser.ResetText();
		}
	}
}

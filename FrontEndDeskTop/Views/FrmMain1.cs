using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrontEndDeskTop.Views;

namespace FrontEndDeskTop
{
	public partial class FrmMain1 : Form
	{
		public FrmMain1()
		{
			InitializeComponent();
			CaregarProges();
		}

		private async Task CaregarProges()
		{
			ProgresMain.Value = 0;
			ProgresMain.Maximum = 100;

			for (int i = 0; i <= 100; i++)
			{
				ProgresMain.Value = i;
				ProgresMain.Refresh();
				await Task.Delay(50);
				if (i == 100)
				{
					this.Close();
					Thread t = new Thread(() => Application.Run(new Frm_Login()));
					t.Start();
				}
			}
		}
	}
}

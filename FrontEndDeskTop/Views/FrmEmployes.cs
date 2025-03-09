using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrontEndDeskTop.Service;

namespace FrontEndDeskTop.Views
{
	public partial class FrmEmployes : Form
	{
		private readonly SearchDadosAPI _searchDados;
		public FrmEmployes()
		{
			InitializeComponent();
			_searchDados = new SearchDadosAPI();
			AddDataInConboBox();
		}

		#region Operacoes
		private async Task AddDataInConboBox()
		{
			var allEmployes = await _searchDados.GetAllEmployAsync();
			var cargos = allEmployes.Select(c => c.Cargo).Distinct().ToList();
			var estados = allEmployes.Select(e => e.Estado).Distinct().ToList();
			cargos.ForEach(c => CbbCargo.Items.Add(c));
			estados.ForEach(e => CbbEstado.Items.Add(e));
		}

		private async Task GetAllEmployes()
		{
			var dados = await _searchDados.GetAllEmployAsync();
			Dgv_Dados.DataSource = dados;
			Lbl_totalResult.Text = $"Total de Resultados: {dados.Count}";
		}

		private async Task GetEmployesCargo()
		{
			if (CbbCargo.SelectedItem != null)
			{
				string cargo = CbbCargo.SelectedItem.ToString();
				var dados = await _searchDados.GetEmployAsyncCargo(cargo);
				Dgv_Dados.DataSource = dados;
				Lbl_totalResult.Text = $"Total de Resultados: {dados.Count}";
			}
			else
			{
				MessageBox.Show("Selecione um cargo para a pesquisa");
				return;
			}

		}

		private async Task GetEmployesSalary()
		{
			if (TxtValoeTwo.Text == string.Empty && TxtValorOne.Text == string.Empty)
			{
				MessageBox.Show("Os campos de valores estão vazios...");
				return;
			}
			else
			{
				int valueOne = int.Parse(TxtValorOne.Text);
				int valueTwo = int.Parse(TxtValoeTwo.Text);
				var dados = await _searchDados.GetEmployesSalary(valueOne, valueTwo);
				Dgv_Dados.DataSource = dados;
				Lbl_totalResult.Text = $"Total de Resultados: {dados.Count}";
			}
		}

		private async Task GetEmployesState()
		{
			if (CbbEstado.SelectedItem == null)
			{
				MessageBox.Show("Selecione um estado para a pesquisa");
				return;
			}

			string estado = CbbEstado.SelectedItem.ToString();
			var dados = await _searchDados.GetEmployesState(estado);
			Dgv_Dados.DataSource = dados;
			Lbl_totalResult.Text = $"Total de Resultados: {dados.Count}";
		}

		#endregion

		private async void Btn_Todos_Click(object sender, System.EventArgs e)
		{
			await GetAllEmployes();
		}

		private async void Btn_Estates_Click(object sender, System.EventArgs e)
		{
			await GetEmployesState();
		}

		private async void Btn_Position_Click(object sender, System.EventArgs e)
		{
			await GetEmployesCargo();
		}

		private async void Btn_Values_Click(object sender, System.EventArgs e)
		{
			await GetEmployesSalary();
		}
	}
}

using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using FrontEndDeskTop.Model;
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
			_ = AddDataInComboBox();
		}

		#region Operacoes
		private void CreatListView(ListView lista, List<EmployesDesk> emp)
		{
			lista.View = View.Details;
			lista.GridLines = true;
			lista.FullRowSelect = true;
			lista.HideSelection = false;
			lista.MultiSelect = false;
			lista.Columns.Clear();
			lista.Columns.Add("Nome", 150, HorizontalAlignment.Left);
			lista.Columns.Add("Estado Civil", 150, HorizontalAlignment.Left);
			lista.Columns.Add("Escolaridade", 150, HorizontalAlignment.Left);
			lista.Columns.Add("Gênero", 60, HorizontalAlignment.Left);
			lista.Columns.Add("Idade", 60, HorizontalAlignment.Left);
			lista.Columns.Add("Status", 100, HorizontalAlignment.Left);
			lista.Columns.Add("Cargo", 100, HorizontalAlignment.Left);
			lista.Columns.Add("Setor", 100, HorizontalAlignment.Left);
			lista.Columns.Add("Sálario Base", 120, HorizontalAlignment.Left);
			lista.Columns.Add("Cidade", 100, HorizontalAlignment.Left);
			lista.Columns.Add("Estado", 100, HorizontalAlignment.Left);
			lista.Items.Clear();

			foreach (var item in emp)
			{
				ListViewItem listViewItem = new ListViewItem(item.Nome);
				listViewItem.SubItems.Add(item.EstadoCivil);
				listViewItem.SubItems.Add(item.Escolaridade);
				listViewItem.SubItems.Add(item.Genero);
				listViewItem.SubItems.Add(item.Idade.ToString());
				listViewItem.SubItems.Add(item.Status);
				listViewItem.SubItems.Add(item.Cargo);
				listViewItem.SubItems.Add(item.Setor);
				listViewItem.SubItems.Add(item.Salario.ToString("C2", CultureInfo.CurrentCulture));
				listViewItem.SubItems.Add(item.Cidade);
				listViewItem.SubItems.Add(item.Estado);
				lista.Items.Add(listViewItem);
			}
		}

		private async Task AddDataInComboBox()
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
			CreatListView(List_view, dados);
			Lbl_totalResult.Text = $"Total de Resultados: {dados.Count}";
		}

		private async Task GetEmployesCargo()
		{
			if (CbbCargo.SelectedItem != null)
			{
				string cargo = CbbCargo.SelectedItem.ToString();
				var dados = await _searchDados.GetEmployAsyncCargo(cargo);
				CreatListView(List_view, dados);
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
				CreatListView(List_view, dados);
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
			CreatListView(List_view, dados);
			Lbl_totalResult.Text = $"Total de Resultados: {dados.Count}";
		}

		private async Task GetAllCriterial()
		{
			if (CbbCargo.SelectedItem == null || CbbEstado.SelectedItem == null && TxtValoeTwo.Text == string.Empty
				&& TxtValorOne.Text == string.Empty)
			{
				MessageBox.Show("Preencha todos os campos para a pesquisa");
				return;
			}

			string estado = CbbEstado.SelectedItem.ToString();
			string cargo = CbbCargo.SelectedItem.ToString();
			int valueOne = int.Parse(TxtValorOne.Text);
			int valueTwo = int.Parse(TxtValoeTwo.Text);

			var dados = await _searchDados.GetAllCriterial(estado, cargo, valueOne, valueTwo);
			CreatListView(List_view, dados);
			Lbl_totalResult.Text = $"Total de Resultados: {dados.Count}";
		}

		#endregion

		#region EventosDeClick
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

		private async void Btn_AllCriterial_Click(object sender, System.EventArgs e)
		{
			await GetAllCriterial();
		}

		#endregion
	}
}

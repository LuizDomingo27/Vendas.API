using FrontVendas.Services;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FrontVendas;

public partial class FrmMain : Form
{
	public FrmMain()
	{
		InitializeComponent();
		AddDataInConboBox();
	}

	private async void btnOne_Click(object sender, EventArgs e)
	{
		SearchDadosApi dados = new();
		var allEmployes = await dados.GetAllEmployAsync();
		dgv_dados.DataSource = allEmployes;
		this.Text = $"Total de Colaboradores | {dgv_dados.RowCount}";
	}

	private async void Btn_Cargo_Click(object sender, EventArgs e)
	{
		if (Cbb_Cargo.SelectedItem != null)
		{
			string cargo = Cbb_Cargo.SelectedItem!.ToString()!;
			SearchDadosApi dadosCargos = new();
			var searchCargos = await dadosCargos.GetEmployAsyncCargo(cargo);
			dgv_dados.DataSource = searchCargos;
		}
		else
		{
			MessageBox.Show("Selecione um cargo para a pesquisa");
			return;
		}
	}
	private async void Btn_Values_Click(object sender, EventArgs e)
	{
		if (TxtValueOne.Text != string.Empty && TxtValueTwo.Text != string.Empty)
		{
			int valueOne = Convert.ToInt32(TxtValueOne.Text);
			int valueTwo = Convert.ToInt32(TxtValueTwo.Text);

			SearchDadosApi dadosSalario = new();
			var result = await dadosSalario.GetEmployesSalary(valueOne, valueTwo);
			dgv_dados.DataSource = result;
			this.Text = $"Total de colaboradores | {result!.Count}";
		}
		else
		{
			MessageBox.Show("Digite os valores para a pesquisa");
		}
	}

	private async Task AddDataInConboBox()
	{
		SearchDadosApi dados = new();
		var allEmployes = await dados.GetAllEmployAsync();
		var cargos = allEmployes!.Select(c => c.Cargo).Distinct().ToList();
		cargos.ForEach(c => Cbb_Cargo.Items.Add(c!));
	}

}

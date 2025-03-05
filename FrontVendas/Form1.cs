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

	private async Task AddDataInConboBox()
	{
		SearchDadosApi dados = new();
		var allEmployes = await dados.GetAllEmployAsync();
		var cargos = allEmployes!.Select(c => c.Cargo).Distinct().ToList();
		var estados = allEmployes!.Select(e => e.Estado).Distinct().ToList();
		cargos.ForEach(c => Cbb_Cargo.Items.Add(c!));
		estados.ForEach(e => Cbb_Estado.Items.Add(e!));
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

	private async void btnOne_Click(object sender, EventArgs e)
	{
		SearchDadosApi dados = new();
		var allEmployes = await dados.GetAllEmployAsync();
		dgv_dados.DataSource = allEmployes;
		this.Text = $"Total de Colaboradores | {dgv_dados.RowCount}";
	}

	private async void Btn_Estado_Click(object sender, EventArgs e)
	{
		if (Cbb_Estado.SelectedItem != null)
		{
			SearchDadosApi dados = new();
			string estado = Cbb_Estado.SelectedItem!.ToString()!;
			var estados = await dados.GetEmployesState(estado);
			dgv_dados.DataSource = estados;
		}
		else
		{
			MessageBox.Show("Selecione um estado para a pesquisa");
			return;
		}
	}
}
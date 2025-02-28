using FrontVendas.Services;

namespace FrontVendas;

public partial class FrmMain : Form
{
	public FrmMain()
	{
		InitializeComponent();
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
		string cargo = "Analista II";
		SearchDadosApi dadosCargos = new();
		var searchCargos = await dadosCargos.GetEmployAsyncCargo(cargo);
		dgv_dados.DataSource = searchCargos;
	}
}

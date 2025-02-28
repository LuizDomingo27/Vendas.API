namespace FrontVendas;

partial class FrmMain
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		dgv_dados = new DataGridView();
		btnOne = new Button();
		Btn_Cargo = new Button();
		((System.ComponentModel.ISupportInitialize)dgv_dados).BeginInit();
		SuspendLayout();
		// 
		// dgv_dados
		// 
		dgv_dados.AllowUserToAddRows = false;
		dgv_dados.AllowUserToDeleteRows = false;
		dgv_dados.AllowUserToOrderColumns = true;
		dgv_dados.BackgroundColor = SystemColors.ButtonHighlight;
		dgv_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgv_dados.Location = new Point(12, 12);
		dgv_dados.Name = "dgv_dados";
		dgv_dados.ReadOnly = true;
		dgv_dados.Size = new Size(776, 385);
		dgv_dados.TabIndex = 0;
		// 
		// btnOne
		// 
		btnOne.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnOne.Location = new Point(689, 403);
		btnOne.Name = "btnOne";
		btnOne.Size = new Size(99, 41);
		btnOne.TabIndex = 1;
		btnOne.Text = "Search All";
		btnOne.UseVisualStyleBackColor = true;
		btnOne.Click += btnOne_Click;
		// 
		// Btn_Cargo
		// 
		Btn_Cargo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Cargo.Location = new Point(581, 403);
		Btn_Cargo.Name = "Btn_Cargo";
		Btn_Cargo.Size = new Size(102, 41);
		Btn_Cargo.TabIndex = 2;
		Btn_Cargo.Text = "Search Cargo";
		Btn_Cargo.UseVisualStyleBackColor = true;
		Btn_Cargo.Click += Btn_Cargo_Click;
		// 
		// FrmMain
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(800, 450);
		Controls.Add(Btn_Cargo);
		Controls.Add(btnOne);
		Controls.Add(dgv_dados);
		Name = "FrmMain";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "-";
		((System.ComponentModel.ISupportInitialize)dgv_dados).EndInit();
		ResumeLayout(false);
	}

	#endregion

	private DataGridView dgv_dados;
	private Button btnOne;
	private Button Btn_Cargo;
}

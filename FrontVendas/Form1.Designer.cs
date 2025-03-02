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
		TxtValueOne = new TextBox();
		TxtValueTwo = new TextBox();
		Btn_Values = new Button();
		Cbb_Cargo = new ComboBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		((System.ComponentModel.ISupportInitialize)dgv_dados).BeginInit();
		SuspendLayout();
		// 
		// dgv_dados
		// 
		dgv_dados.AllowUserToAddRows = false;
		dgv_dados.AllowUserToDeleteRows = false;
		dgv_dados.AllowUserToOrderColumns = true;
		dgv_dados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		dgv_dados.BackgroundColor = SystemColors.ButtonHighlight;
		dgv_dados.BorderStyle = BorderStyle.Fixed3D;
		dgv_dados.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
		dgv_dados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dgv_dados.Location = new Point(12, 12);
		dgv_dados.Name = "dgv_dados";
		dgv_dados.ReadOnly = true;
		dgv_dados.RowHeadersVisible = false;
		dgv_dados.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
		dgv_dados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
		dgv_dados.Size = new Size(1056, 404);
		dgv_dados.TabIndex = 0;
		// 
		// btnOne
		// 
		btnOne.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		btnOne.Location = new Point(969, 474);
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
		Btn_Cargo.Location = new Point(861, 474);
		Btn_Cargo.Name = "Btn_Cargo";
		Btn_Cargo.Size = new Size(102, 41);
		Btn_Cargo.TabIndex = 2;
		Btn_Cargo.Text = "Search Cargo";
		Btn_Cargo.UseVisualStyleBackColor = true;
		Btn_Cargo.Click += Btn_Cargo_Click;
		// 
		// TxtValueOne
		// 
		TxtValueOne.BorderStyle = BorderStyle.FixedSingle;
		TxtValueOne.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
		TxtValueOne.Location = new Point(9, 487);
		TxtValueOne.Name = "TxtValueOne";
		TxtValueOne.Size = new Size(67, 27);
		TxtValueOne.TabIndex = 3;
		TxtValueOne.TextAlign = HorizontalAlignment.Center;
		// 
		// TxtValueTwo
		// 
		TxtValueTwo.BorderStyle = BorderStyle.FixedSingle;
		TxtValueTwo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
		TxtValueTwo.Location = new Point(82, 488);
		TxtValueTwo.Name = "TxtValueTwo";
		TxtValueTwo.Size = new Size(78, 27);
		TxtValueTwo.TabIndex = 4;
		TxtValueTwo.TextAlign = HorizontalAlignment.Center;
		// 
		// Btn_Values
		// 
		Btn_Values.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Btn_Values.Location = new Point(745, 474);
		Btn_Values.Name = "Btn_Values";
		Btn_Values.Size = new Size(110, 41);
		Btn_Values.TabIndex = 5;
		Btn_Values.Text = "Search Values";
		Btn_Values.UseVisualStyleBackColor = true;
		Btn_Values.Click += Btn_Values_Click;
		// 
		// Cbb_Cargo
		// 
		Cbb_Cargo.Cursor = Cursors.Hand;
		Cbb_Cargo.DropDownHeight = 100;
		Cbb_Cargo.DropDownStyle = ComboBoxStyle.DropDownList;
		Cbb_Cargo.DropDownWidth = 120;
		Cbb_Cargo.FlatStyle = FlatStyle.System;
		Cbb_Cargo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
		Cbb_Cargo.FormattingEnabled = true;
		Cbb_Cargo.IntegralHeight = false;
		Cbb_Cargo.ItemHeight = 20;
		Cbb_Cargo.Location = new Point(185, 488);
		Cbb_Cargo.Name = "Cbb_Cargo";
		Cbb_Cargo.Size = new Size(154, 28);
		Cbb_Cargo.TabIndex = 6;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
		label1.Location = new Point(9, 469);
		label1.Name = "label1";
		label1.Size = new Size(45, 15);
		label1.TabIndex = 7;
		label1.Text = "Valor 1:";
		// 
		// label2
		// 
		label2.AutoSize = true;
		label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
		label2.Location = new Point(82, 469);
		label2.Name = "label2";
		label2.Size = new Size(47, 15);
		label2.TabIndex = 7;
		label2.Text = "Valor 2:";
		// 
		// label3
		// 
		label3.AutoSize = true;
		label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label3.Location = new Point(185, 470);
		label3.Name = "label3";
		label3.Size = new Size(102, 15);
		label3.TabIndex = 7;
		label3.Text = "Selecione o Cargo";
		// 
		// FrmMain
		// 
		AutoScaleDimensions = new SizeF(7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size(1080, 521);
		Controls.Add(label3);
		Controls.Add(label2);
		Controls.Add(label1);
		Controls.Add(Cbb_Cargo);
		Controls.Add(Btn_Values);
		Controls.Add(TxtValueTwo);
		Controls.Add(TxtValueOne);
		Controls.Add(Btn_Cargo);
		Controls.Add(btnOne);
		Controls.Add(dgv_dados);
		MaximizeBox = false;
		Name = "FrmMain";
		StartPosition = FormStartPosition.CenterScreen;
		Text = "-";
		((System.ComponentModel.ISupportInitialize)dgv_dados).EndInit();
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private DataGridView dgv_dados;
	private Button btnOne;
	private Button Btn_Cargo;
	private TextBox TxtValueOne;
	private TextBox TxtValueTwo;
	private Button Btn_Values;
	private ComboBox Cbb_Cargo;
	private Label label1;
	private Label label2;
	private Label label3;
}

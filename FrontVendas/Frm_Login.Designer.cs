namespace FrontVendas;

partial class Frm_Login
{
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	/// Clean up any resources being used.
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
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		button1 = new Button();
		button2 = new Button();
		label1 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		button3 = new Button();
		SuspendLayout();
		// 
		// button1
		// 
		button1.BackColor = Color.Transparent;
		button1.FlatStyle = FlatStyle.Popup;
		button1.ForeColor = SystemColors.ButtonFace;
		button1.Location = new Point(74, 241);
		button1.Name = "button1";
		button1.Size = new Size(93, 35);
		button1.TabIndex = 0;
		button1.Text = "Singn In";
		button1.UseVisualStyleBackColor = false;
		// 
		// button2
		// 
		button2.AutoEllipsis = true;
		button2.BackColor = Color.Transparent;
		button2.FlatStyle = FlatStyle.Popup;
		button2.ForeColor = SystemColors.ButtonFace;
		button2.Location = new Point(173, 241);
		button2.Name = "button2";
		button2.Size = new Size(93, 35);
		button2.TabIndex = 1;
		button2.Text = "Sing Up";
		button2.UseVisualStyleBackColor = false;
		// 
		// label1
		// 
		label1.AutoSize = true;
		label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
		label1.ForeColor = SystemColors.ButtonFace;
		label1.Location = new Point(49, 9);
		label1.Name = "label1";
		label1.Size = new Size(256, 32);
		label1.TabIndex = 2;
		label1.Text = "Bém vindo , faça login";
		// 
		// textBox1
		// 
		textBox1.BackColor = Color.FromArgb(56, 56, 56);
		textBox1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
		textBox1.ForeColor = SystemColors.MenuBar;
		textBox1.Location = new Point(73, 168);
		textBox1.Name = "textBox1";
		textBox1.PlaceholderText = "Digite sua senha";
		textBox1.Size = new Size(208, 31);
		textBox1.TabIndex = 3;
		// 
		// textBox2
		// 
		textBox2.AccessibleRole = AccessibleRole.None;
		textBox2.BackColor = Color.FromArgb(56, 56, 56);
		textBox2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
		textBox2.ForeColor = SystemColors.MenuBar;
		textBox2.Location = new Point(73, 92);
		textBox2.Name = "textBox2";
		textBox2.PlaceholderText = "Digite seu e-mail";
		textBox2.Size = new Size(208, 31);
		textBox2.TabIndex = 3;
		// 
		// button3
		// 
		button3.AutoEllipsis = true;
		button3.BackColor = Color.FromArgb(56, 56, 56);
		button3.Cursor = Cursors.Hand;
		button3.FlatAppearance.BorderColor = Color.Red;
		button3.FlatAppearance.BorderSize = 0;
		button3.FlatStyle = FlatStyle.Flat;
		button3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
		button3.ForeColor = SystemColors.ButtonFace;
		button3.Location = new Point(328, -1);
		button3.Name = "button3";
		button3.Size = new Size(26, 25);
		button3.TabIndex = 4;
		button3.Text = "X";
		button3.TextAlign = ContentAlignment.MiddleRight;
		button3.UseVisualStyleBackColor = false;
		// 
		// Frm_Login
		// 
		AutoScaleDimensions = new SizeF(9F, 20F);
		AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.FromArgb(56, 56, 56);
		ClientSize = new Size(355, 282);
		Controls.Add(button3);
		Controls.Add(textBox2);
		Controls.Add(textBox1);
		Controls.Add(label1);
		Controls.Add(button2);
		Controls.Add(button1);
		Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
		FormBorderStyle = FormBorderStyle.None;
		Margin = new Padding(4);
		MaximizeBox = false;
		MinimizeBox = false;
		Name = "Frm_Login";
		ShowIcon = false;
		StartPosition = FormStartPosition.CenterScreen;
		ResumeLayout(false);
		PerformLayout();
	}

	#endregion

	private Button button1;
	private Button button2;
	private Label label1;
	private TextBox textBox1;
	private TextBox textBox2;
	private Button button3;
}
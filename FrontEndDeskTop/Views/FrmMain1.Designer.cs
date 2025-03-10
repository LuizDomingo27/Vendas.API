namespace FrontEndDeskTop
{
	partial class FrmMain1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
			this.ProgresMain = new Guna.UI2.WinForms.Guna2CircleProgressBar();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ProgresMain
			// 
			this.ProgresMain.Animated = true;
			this.ProgresMain.AutoScroll = true;
			this.ProgresMain.BackColor = System.Drawing.Color.Transparent;
			this.ProgresMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ProgresMain.FillColor = System.Drawing.Color.Transparent;
			this.ProgresMain.FillThickness = 30;
			this.ProgresMain.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ProgresMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.ProgresMain.ImageSize = new System.Drawing.Size(150, 150);
			this.ProgresMain.Location = new System.Drawing.Point(39, 12);
			this.ProgresMain.Name = "ProgresMain";
			this.ProgresMain.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.ProgresMain.ProgressColor2 = System.Drawing.Color.DodgerBlue;
			this.ProgresMain.ProgressStartCap = System.Drawing.Drawing2D.LineCap.Round;
			this.ProgresMain.ProgressThickness = 30;
			this.ProgresMain.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.ProgresMain.ShadowDecoration.Parent = this.ProgresMain;
			this.ProgresMain.ShowPercentage = true;
			this.ProgresMain.Size = new System.Drawing.Size(257, 263);
			this.ProgresMain.TabIndex = 0;
			this.ProgresMain.UseTransparentBackground = true;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.TargetControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(70, 306);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 25);
			this.label1.TabIndex = 1;
			this.label1.Text = "Wait while it charges ....";
			// 
			// FrmMain1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
			this.ClientSize = new System.Drawing.Size(355, 345);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ProgresMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmMain1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
		private Guna.UI2.WinForms.Guna2CircleProgressBar ProgresMain;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private System.Windows.Forms.Label label1;
	}
}


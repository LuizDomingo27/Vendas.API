﻿using System;
using System.Windows.Forms;

using FrontEndDeskTop.Views;

namespace FrontEndDeskTop
{
	static class Program
	{
		/// <summary>
		/// Ponto de entrada principal para o aplicativo.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmMain1());
		}
	}
}

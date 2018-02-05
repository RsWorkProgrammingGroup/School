using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MissingFileDownloader
{
	public partial class MainWindow : RsWork.UI.Windows.ModernDialogBase
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void modernButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}

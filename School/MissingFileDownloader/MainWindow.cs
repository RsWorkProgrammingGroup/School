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
			dataGridView1.Rows[0].Cells[1].Value = "XTest0";
			dataGridView1.Rows[0].Cells[2].Value = "XTest1";
			dataGridView1.Rows[0].Cells[3].Value = "XTest2";
		}

		private void modernButton1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}
	}
}

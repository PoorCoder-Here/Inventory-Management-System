using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Client_V1
{
	public partial class Inventory : Form
	{
		public Inventory()
		{
			InitializeComponent();
		}

		private void Inventory_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'PandiyanDataSet1.Stock' table. You can move, or remove it, as needed.
			this.StockTableAdapter.Fill(this.PandiyanDataSet1.Stock);

			this.reportViewer1.RefreshReport();
			
		}
	}
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Billing_Client_V1
{
	public partial class Bill_History : Form
	{
		int order_no;
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";
		public Bill_History()
		{
			InitializeComponent();
		}

		private void Bill_History_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'inv_His.Transac_Details' table. You can move, or remove it, as needed.
			this.transac_DetailsTableAdapter.Fill(this.inv_His.Transac_Details);

			this.CenterToParent();

			this.MaximizeBox = false;
		}
        //Updating the bill history of cancelled order in the database.
		private void Cancel_Click(object sender, EventArgs e)
		{
			

			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("UPDATE Transac_Details SET Status = 'Cancelled' WHERE OrderNumber ='"+order_no+"' AND Date ='"+DateTime.Today.ToShortDateString()+"'")
			{
				Connection = con
			};
			cmd.ExecuteNonQuery();
           
			SqlCommand cmd1 = new SqlCommand("UPDATE dbo.Item_Transac SET Status = 'Cancelled' WHERE Order_Num ='" + order_no + "' AND Date ='" + DateTime.Today.ToShortDateString() + "'")
			{
				Connection = con
			};
			cmd1.ExecuteNonQuery();

			MessageBox.Show("Order Number " + order_no + " Cancelled","Cancelled" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
			con.Close();

		}
        //to click the item in the report viewer.
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			order_no =Convert.ToInt32(row.Cells[0].Value.ToString());
		}
        //to show the history of bills on the respective date chosen.
		private void button1_Click(object sender, EventArgs e)
		{
			var select = "SELECT * FROM Transac_Details where Date ='"+ dateTimePicker1.Value.ToShortDateString() + "' ORDER BY OrderNumber "; ;
			var c = new SqlConnection(ConnectionString); // Your Connection String here
			var dataAdapter = new SqlDataAdapter(select, c);

			var commandBuilder = new SqlCommandBuilder(dataAdapter);
			var ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];

		}
	}
}

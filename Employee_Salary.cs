using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Client_V1
{
	public partial class Employee_Salary : Form
	{
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";

		public Employee_Salary()
		{
			InitializeComponent();
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void Employee_Salary_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'pandiyanDataSet_Salary.Emp_Salary' table. You can move, or remove it, as needed.
			this.emp_SalaryTableAdapter.Fill(this.pandiyanDataSet_Salary.Emp_Salary);
			// TODO: This line of code loads data into the 'pandiyanDataSet_Salary.Emp_Salary' table. You can move, or remove it, as needed.
			this.emp_SalaryTableAdapter.Fill(this.pandiyanDataSet_Salary.Emp_Salary);
			// TODO: This line of code loads data into the 'pandiyanDataSet_Salary.Emp_Salary' table. You can move, or remove it, as needed.
			this.emp_SalaryTableAdapter.Fill(this.pandiyanDataSet_Salary.Emp_Salary);
			// TODO: This line of code loads data into the 'pandiyanDataSet_Emp_Salary.Emp_Salary' table. You can move, or remove it, as needed.

			Refresh_Dgv();
		}

		private void Refresh_Dgv()
		{
			var select = "SELECT * FROM Emp_Salary where Sal_Date ='" + DateTime.Today.ToShortDateString() + "'";
			var c = new SqlConnection(ConnectionString); // Your Connection String here
			c.Open();
			var dataAdapter = new SqlDataAdapter(select, c);

			var commandBuilder = new SqlCommandBuilder(dataAdapter);
			var ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)

		{
			switch (keyData)
			{
				case Keys.Enter:
					if (Text_Other_Details.Focused != true)
					{
						SendKeys.Send("{TAB}");

					}
					else
					{
						button1.PerformClick();
					}
					return true;

				default:
					return base.ProcessCmdKey(ref msg, keyData);
			}
		}
		int S_Num;
		string date;
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			S_Num = Convert.ToInt32(row.Cells[0].Value.ToString());
			date = Convert.ToString(row.Cells[3].Value.ToString());
		}

		public int Update_Ordrno()
		{
			int ordr = 0;
			System.Data.SqlClient.SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("SELECT MAX(S_No) from Emp_Salary where (Sal_Date ='" + DateTime.Today.ToShortDateString() + "')")
			{
				Connection = con
			};

			SqlDataReader data = cmd.ExecuteReader();
			while (data.Read())
			{
				try
				{
					ordr = data.GetInt32(0) + 1;
				}
				catch (Exception ex)
				{
					if (ex.Message.Contains("Data is Null. This method or property cannot be called on Null values."))
					{
						ordr = 1;
					}
				}
			}

			con.Close();
			return ordr;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Text_Emp_name.Text != "" & Text_Salary.Text != "")
			{
				if (Text_Other_Details.Text == "")
					Text_Other_Details.Text = "null";

				SqlConnection con = new SqlConnection(ConnectionString);
				con.Open();

				SqlCommand cmd = new SqlCommand("INSERT into Emp_Salary(S_No,Emp_Name,Salary,Sal_Date,Sal_Time,Other_Details,Status) VALUES(@SNo,@Emp_Name,@Salary,@Sal_Date,@Sal_Time,@Other_Details,'Success')")
				{
					Connection = con
				};
				try
				{
					cmd.Parameters.AddWithValue("@SNo", Update_Ordrno());
					cmd.Parameters.AddWithValue("@Emp_Name", Text_Emp_name.Text);
					cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(Text_Salary.Text));
					cmd.Parameters.AddWithValue("@Sal_Date", DateTime.Today.ToShortDateString());
					cmd.Parameters.AddWithValue("@Sal_Time", DateTime.Now.ToShortTimeString());
					cmd.Parameters.AddWithValue("@Other_Details", Text_Other_Details.Text);
					
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString());
				}


				con.Close();
				MessageBox.Show("Bill Added Successfully");

				Text_Emp_name.ResetText();
				Text_Salary.ResetText();
				Text_Other_Details.ResetText();
				Refresh_Dgv();


			}
			else
			{
				MessageBox.Show("Please Fill All Details", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

		}

		private void Button_Cancel_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
			{
				SqlConnection con = new SqlConnection(ConnectionString);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE Emp_Salary SET Status='Cancelled',Cancel_Reason='" + textBox1.Text + "'" + "WHERE Sal_Date ='" + date + "'AND S_No ='" + S_Num + "'")
				{
					Connection = con
				};
				cmd.ExecuteNonQuery();
				Refresh_Dgv();
				MessageBox.Show("Bill Cancelled Successfully");
				textBox1.ResetText();
				Refresh_Dgv();
			}
			else
			{
				MessageBox.Show("Please Enter the Reason for Cancelling");
			}
		}
	}
}

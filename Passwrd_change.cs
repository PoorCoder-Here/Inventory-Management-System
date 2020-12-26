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
	public partial class Passwrd_change : Form
	{
		string user;
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";
		public Passwrd_change(string uid)
		{
			InitializeComponent();
			user = uid;
		}

		

			private void button1_Click(object sender, EventArgs e)
		{
			if(textBox1.Text == textBox2.Text)
			{
				
				SqlConnection con = new SqlConnection(ConnectionString);
				con.Open();
				SqlCommand cmd = new SqlCommand("UPDATE UserIds SET  Password = @pwd WHERE UserId = '" + user + "'")
				{
					Connection = con
				};
				cmd.Parameters.AddWithValue("@pwd", textBox1.Text);
				cmd.ExecuteNonQuery();
				con.Close();
				MessageBox.Show("Password Changed Successfully!");
				this.Close();
			}
		}

		private void Passwrd_change_Load(object sender, EventArgs e)
		{
			this.CenterToParent();
		}
	}
}

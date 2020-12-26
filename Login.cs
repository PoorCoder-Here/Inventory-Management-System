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
	public partial class Login : Form
	{
		string temp,Pw;
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";
		public Login()
		{
			InitializeComponent();
		}

		private void Login_Load(object sender, EventArgs e)
		{
			this.CenterToParent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{

				
				SqlConnection con = new SqlConnection(ConnectionString);
				con.Open();
				SqlCommand cmd = new SqlCommand("SELECT Password from UserIds WHERE UserId = '" + User_name.Text + "'")
				{
					Connection = con
				};

				SqlDataReader data = cmd.ExecuteReader();
				while (data.Read())
				temp = data.GetString(0);
				Pw = (string)temp;
				con.Close();
				if (pwd.Text == (String)Pw)

				{
					if (User_name.Text == "Admin"| User_name.Text == "admin")
					{
						
						this.Hide();
						Main_Page next = new Main_Page(User_name.Text);
						next.Closed += (s, args) => this.Close();

						next.Show();
					}
					else
					{
						KOT_Billing next_kot = new KOT_Billing(User_name.Text);
						this.Hide();
						next_kot.Closed += (s, args) => this.Close();
						next_kot.Show();
					}
				}
				else
				{
					MessageBox.Show("Please Enter Valid User name and Password");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(Convert.ToString(ex));
			}
		}
	}
}

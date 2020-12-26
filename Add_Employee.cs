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
	public partial class Add_Employee : Form
	{
		string User_Id;
		public Add_Employee(string uid)
		{
			InitializeComponent();
			User_Id = uid;
		}
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";

		private void button1_Click(object sender, EventArgs e)
		{
			
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("INSERT into UserIds(UserId,Password,Name,Date_of_Birth,Phone,Address_Line1,Address_Line2,City,State,Pin,cby,Id_Proof_Type,Id_Proof_Number) VALUES(@userid,@pass,@name,@dob,@phone,@adl1,@adl2,@city,@state,@pin,@by,@idt,@idn)", con)
			{
				Connection = con
			};
			cmd.Parameters.AddWithValue("@userid", userid.Text);
			cmd.Parameters.AddWithValue("@pass", password.Text);
			cmd.Parameters.AddWithValue("@name",name.Text);
			cmd.Parameters.AddWithValue("@dob", dob.Text);
			cmd.Parameters.AddWithValue("@phone", phone.Text);
			cmd.Parameters.AddWithValue("@adl1", ad1.Text);
			cmd.Parameters.AddWithValue("@adl2", ad2.Text);
			cmd.Parameters.AddWithValue("@city", city.Text);
			cmd.Parameters.AddWithValue("@state", state.Text);
			cmd.Parameters.AddWithValue("@pin", pin.Text);
			cmd.Parameters.AddWithValue("@by", User_Id);
			cmd.Parameters.AddWithValue("@idt", comboBox1.SelectedItem.ToString());
			cmd.Parameters.AddWithValue("@idn", idnum.Text);

			cmd.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Employee Added Successfully");
		}

		private void Add_Employee_Load(object sender, EventArgs e)
		{
			this.CenterToParent();
		}
	}
}

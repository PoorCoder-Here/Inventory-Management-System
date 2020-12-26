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
	public partial class Main_Page : Form
	{
        static string user;
        static bool kot_open = false;
        public Main_Page(string uid)
		{
			InitializeComponent();
            user = uid;
            userid.Text = user;
		}

        KOT_Billing next_Kot = new KOT_Billing(user);
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.B:
                   

                    foreach (Form f in Application.OpenForms)
                    {
                        if (f.Name == "KOT_Billing")
                        {
                            f.BringToFront();
                            kot_open = true;
                        }
                        else
                        {
                            kot_open = false;
                        }
                    }

                    if (kot_open == false)
                    {
                        KOT_Billing next_Kot = new KOT_Billing(user);
                        next_Kot.Show();
                       
                    }
                  
                    return base.ProcessCmdKey(ref msg, keyData);
                    

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

      
        private void toolStrip_Logout_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login prev = new Login();
			prev.Closed += (s, args) => this.Close();
			prev.Show();
		}

		private void exitToolStrip_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void productToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Product next = new Product(userid.Text);
			next.Show();
		}

		private void kOTBillingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form f in Application.OpenForms)
			{
				if (f.Name == "KOT_Billing")
				{
					f.BringToFront();
					kot_open = true;
				}
				else
				{
					kot_open = false;
				}
			}

			if (kot_open == false)
			{
				KOT_Billing next_Kot = new KOT_Billing(user);
				next_Kot.Show();

			}
		}

		private void billHistoryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Bill_History next = new Bill_History();
			next.Show();
		}

		private void cancelledInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
		{
            Cancelled_Inv next = new Cancelled_Inv();
			next.Show();
		}

		private void dailySalesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Daily_report next = new Daily_report();
			next.Show();
		}

		private void itemwiseSalesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Item_Sale next = new Item_Sale();
			next.Show();
		}

		private void productListingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Product_Listing next = new Product_Listing();
			next.Show();
		}

		private void Main_Page_Load(object sender, EventArgs e)
		{
			
		}

		private void profileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Profile next = new Profile(userid.Text);
			next.Show();
		}

		private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Add_Employee next = new Add_Employee(userid.Text);
			next.Show();
		}

		private void markAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Purchase next = new Purchase();
			next.Show();
		}

		private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Purchase_Report next = new Purchase_Report();
			next.Show();
		}

		private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Employee_Salary next = new Employee_Salary();
			next.Show();
		}

		private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Salary_report next = new Salary_report();
			next.Show();
		}
	}
}

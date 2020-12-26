//generating daily report.
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Billing_Client_V1
{
	public partial class Daily_report : Form
	{
		public Daily_report()
		{
			InitializeComponent();
		}
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";
		private void Daily_report_Load(object sender, EventArgs e)
		{
			this.CenterToParent();
			try
			{
				// TODO: This line of code loads data into the 'Daily_rprt.Transac_Details' table. You can move, or remove it, as needed.
				this.Transac_DetailsTableAdapter.Fill(this.Daily_rprt.Transac_Details);
				// TODO: This line of code loads data into the 'Daily_rprt.Transac_Details' table. You can move, or remove it, as needed.
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			this.MaximizeBox = false;

			
			//this.reportViewer1.RefreshReport();
		}

		private void reportViewer1_Load(object sender, EventArgs e)
		{
			
		}
		double sum1;
		private void button1_Click(object sender, EventArgs e)
		{
			string qry = "SELECT * from Transac_Details WHERE Date ='" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'";

			this.Transac_DetailsTableAdapter.SetSQL(qry);
			this.Transac_DetailsTableAdapter.Fill(this.Daily_rprt.Transac_Details);
			
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'")
			{
				Connection = con
			};

			SqlDataReader dt = cmd.ExecuteReader();
			while (dt.Read())
			{
				try
				{
					sum1 = dt.GetDouble(0);
				}
				catch (Exception ex)
				{
					sum1 = 0;
				}
			}
			con.Close();
			textBox1.Text = sum1.ToString();

			this.reportViewer1.RefreshReport();
		}
        double sum, card, cash, upi;
        int count;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Space:
                   
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'")
                    {
                        Connection = con
                    };

                    SqlDataReader dt = cmd.ExecuteReader();
                    while (dt.Read())
                    {
                        try
                        {
                            sum = dt.GetDouble(0);
                        }
                        catch (Exception ex)
                        {
                            sum = 0;
                        }
                    }
                    con.Close();
					
                    con.Open();

                    SqlCommand cmd1 = new SqlCommand("select count(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'")
                    {
                        Connection = con
                    };

                    SqlDataReader dt1 = cmd1.ExecuteReader();
                    while (dt1.Read())
                    {
                        try
                        {
                            count = dt1.GetInt32(0);
                        }
                        catch (Exception ex)
                        {
                            count = 0;
                        }
                    }
                    con.Close();
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND PaymentMode = 'Cash' AND Status = 'Success'")
                    {
                        Connection = con
                    };

                    SqlDataReader dt2 = cmd2.ExecuteReader();
                    while (dt2.Read())
                    {
                        try
                        {
                            cash = dt2.GetDouble(0);
                        }
                        catch (Exception ex)
                        {
                            cash = 0;
                        }
                    }
                    con.Close();
                    con.Open();
                    SqlCommand cmd3 = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND PaymentMode = 'Card' AND Status = 'Success'")
                    {
                        Connection = con
                    };

                    SqlDataReader dt3 = cmd3.ExecuteReader();
                    while (dt3.Read())
                    {
                        try
                        {
                            card = dt3.GetDouble(0);
                        }
                        catch (Exception ex)
                        {
                            card = 0;
                        }
                    }
                    con.Close();
                    con.Open();
                    SqlCommand cmd4 = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND PaymentMode = 'UPI' AND Status = 'Success'")
                    {
                        Connection = con
                    };

                    SqlDataReader dt4 = cmd4.ExecuteReader();
                    while (dt4.Read())
                    {
                        try
                        {
                            upi = dt4.GetDouble(0);
                        }
                        catch (Exception ex)
                        {
                            upi = 0;
                        }
                    }
                    con.Close();
                    PrintDialog printDialog = new PrintDialog();

                    PrintDocument printDocument = new PrintDocument();

                    printDialog.Document = printDocument;

                    printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill);
                    printDocument.Print();
                    return base.ProcessCmdKey(ref msg, keyData);
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }
        private void Print_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'")
            {
                Connection = con
            };

            SqlDataReader dt = cmd.ExecuteReader();
            while (dt.Read())
            {
                try
                {
                    sum = dt.GetDouble(0);
                }
                catch(Exception ex)
                {
                    sum = 0;
                }
            }
            con.Close();
            con.Open();

            SqlCommand cmd1 = new SqlCommand("select count(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'")
            {
                Connection = con
            };

            SqlDataReader dt1 = cmd1.ExecuteReader();
            while (dt1.Read())
            {
                try
                {
                    count = dt1.GetInt32(0);
                }
                catch(Exception ex)
                {
                    count = 0;
                }
            }
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND PaymentMode = 'Cash' AND Status = 'Success'")
            {
                Connection = con
            };

            SqlDataReader dt2 = cmd2.ExecuteReader();
            while (dt2.Read())
            {
                try
                {
                    cash = dt2.GetDouble(0);
                }
                catch(Exception ex)
                {
                    cash = 0;
                }
            }
            con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND PaymentMode = 'Card' AND Status = 'Success'")
            {
                Connection = con
            };

            SqlDataReader dt3 = cmd3.ExecuteReader();
            while (dt3.Read())
            {
                try
                {
                    card = dt3.GetDouble(0);
                }
                catch(Exception ex)
                {
                    card = 0;
                }
            }
            con.Close();
            con.Open();
            SqlCommand cmd4 = new SqlCommand("select sum(Total) from Transac_Details where Date = '" + dateTimePicker1.Value.ToShortDateString() + "' AND PaymentMode = 'UPI' AND Status = 'Success'")
            {
                Connection = con
            };

            SqlDataReader dt4 = cmd4.ExecuteReader();
            while (dt4.Read())
            {
                try
                {
                    upi = dt4.GetDouble(0);
                }
                catch(Exception ex)
                {
                    upi = 0;
                }
            }
            con.Close();

            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument;

            printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill);
            printDocument.Print();
        }

        public void CreateBill(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 14, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;


            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("Date: " + DateTime.Now.ToString(), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(5 * fontHeight));

            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            graphic.DrawString("Daily Report", font, new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            graphic.DrawString("Bill Count : " + count.ToString(), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + (int)(9.5 * fontHeight));

            graphic.DrawString("Total Sale : " + sum.ToString(), new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(16.5 * fontHeight));

            graphic.DrawString("Total Tax  : " + Convert.ToString(sum * 0.05), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + (int)(11.5 * fontHeight));

            graphic.DrawString("Cash       : " + Convert.ToString(cash), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + (int)(12.5 * fontHeight));

            graphic.DrawString("Card       : " + Convert.ToString(card), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + (int)(13.5 * fontHeight));

            graphic.DrawString("UPI        : " + Convert.ToString(upi), new Font("Courier New", 12), new SolidBrush(Color.Black), startX, startY + (int)(14.5 * fontHeight));

            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(15.5 * fontHeight));
            
            graphic.DrawString("Gross Sale : " + Convert.ToString(sum - (sum * 0.05)), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(10.5 * fontHeight));

            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(17.5 * fontHeight));

			count = 0;
			sum = 0;
			cash = 0;
			card = 0;
			upi = 0;
        }
    }
}

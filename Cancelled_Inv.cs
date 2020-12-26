//to load the historical data of cancelled invoice.
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Billing_Client_V1
{
	public partial class Cancelled_Inv : Form
	{
		public Cancelled_Inv()
		{
			InitializeComponent();
		}
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";
        //loading the details from database.
		private void Cancelled_Inv_Load(object sender, EventArgs e)
		{
			this.CenterToParent();
			// TODO: This line of code loads data into the 'masterDataSet2.Transac_Details' table. You can move, or remove it, as needed.
			this.transac_DetailsTableAdapter.Fill(this.masterDataSet2.Transac_Details);
			this.MaximizeBox = false;

		}
        //initilization.
        int[] order = new int[50];
        double[] total = new double[50];
        string[] Pay_mode = new string[50];
        string[] Del_mode = new string[50];
        double total_all;
        int i = 0,size;
        //displaying the historical data of cancelled invoice from database for the respective date selected.
        private void button1_Click(object sender, EventArgs e)
		{
			var select = "SELECT * FROM Transac_Details where Date ='" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Cancelled'" ;
			var c = new SqlConnection(ConnectionString); // Your Connection String here
            c.Open();
			var dataAdapter = new SqlDataAdapter(select, c);

			var commandBuilder = new SqlCommandBuilder(dataAdapter);
			var ds = new DataSet();
			dataAdapter.Fill(ds);
			dataGridView1.ReadOnly = true;
			dataGridView1.DataSource = ds.Tables[0];
            //for the purpose of printing the bill.
            try
			{
				SqlCommand cmd = new SqlCommand("SELECT * FROM Transac_Details where Date ='" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Cancelled'", c);
				SqlDataReader dt = cmd.ExecuteReader();
				while (dt.Read())
				{
					order[i] = Convert.ToInt32(dt["OrderNumber"].ToString());
					total[i] = Convert.ToDouble(dt["Total"].ToString());
					Pay_mode[i] = dt["PaymentMode"].ToString();
					Del_mode[i] = dt["DeliveryMode"].ToString();
					i++;
				}
			}
			catch
			{

			}
            c.Close();
            c.Open();
			size = i;
			i = 0;
            //to find the total amount of sales on respective bill date selected.
            try
			{
				SqlCommand cmd1 = new SqlCommand("SELECT sum(Total) FROM Transac_Details where Date ='" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Cancelled'", c);
				SqlDataReader dt1 = cmd1.ExecuteReader();
				while (dt1.Read())
				{
					total_all = Convert.ToDouble(dt1[0].ToString());
				}
			}
			catch
			{

			}
            c.Close();
        //to print the bill.
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Space:
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


            graphic.DrawString("Pandiyan Heritage Restraunts", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("Mannurpet , Chennai - 98", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(2 * fontHeight));
            graphic.DrawString("Date: " + dateTimePicker1.Value.ToShortDateString(), new Font("Courier New", 12, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(3 * fontHeight));

            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(4 * fontHeight));
            graphic.DrawString("Cancelled Bill Report", font, new SolidBrush(Color.Black), startX, startY + (int)(5 * fontHeight));
            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));

            string top = "OrderNo. ".PadRight(6) + " Total ".PadRight(6) + " Payment Mode ".PadRight(6) + " Delviery";
            graphic.DrawString(top, new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));
            int j = 9;
            for (int k = 0; k < size; k++)
            {
                //string bil = order[k].ToString().PadRight(8) + total[k].ToString().PadRight(10)+ Pay_mode[k] + Del_mode[k];
                graphic.DrawString(order[k].ToString(), new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX + 10, startY + (int)(j * fontHeight));
                graphic.DrawString(total[k].ToString(), new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX + 70, startY + (int)(j * fontHeight));
                graphic.DrawString(Pay_mode[k], new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX + 130, startY + (int)(j * fontHeight));
                graphic.DrawString(Del_mode[k], new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX + 220, startY + (int)(j * fontHeight));

                j++;
            }

            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(j++ * fontHeight));
            graphic.DrawString("Total :" + total_all.ToString(), font, new SolidBrush(Color.Black), startX, startY + (int)(j++ * fontHeight));
            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(j++ * fontHeight));

            clearall();
        }
        //to clear the previous data of bill selected from the database.
        private void clearall()
        {
            for(int ind=0;ind<50;ind++)
            {
                
                order[ind] =0;
                total[ind] = 0;
                Pay_mode[ind] = null;
                Del_mode[ind] = null;
            }
            i = 0;
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

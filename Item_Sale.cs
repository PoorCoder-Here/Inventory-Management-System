using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing_Client_V1
{
    public partial class Item_Sale : Form
    {
        string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";
        int i;
        bool update = false;
        List<string> Item_Name = new List<string>();
        List<int> Total_Quant = new List<int>();
        List<double> Total_Price = new List<double>();
        List<string> Item_date = new List<string>();

        public Item_Sale()
        {
            InitializeComponent();
        }

        private void Item_Sale_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            // TODO: This line of code loads data into the 'masterDataSet3.Item_Transac' table. You can move, or remove it, as needed.
            this.Item_TransacTableAdapter.Fill(this.masterDataSet7.Item_Transac);



            this.reportViewer1.RefreshReport();
            this.MaximizeBox = false;
            try
            {

                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Item_Name from Menu")
                {
                    Connection = con
                };
                i = 0;
                SqlDataReader data = cmd.ExecuteReader();
                while (data.Read())
                {

                    comboBox1.Items.Add(data[0]);
                    i++;

                }
                data.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                try

                {
                    //string qry = "SELECT * from Item_Transac WHERE Item_Name ='" + comboBox1.SelectedItem.ToString() + "' AND Date ='" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'";
                    //string qry = "SELECT * from Item_Transac WHERE  Date ='" + dateTimePicker1.Value.ToShortDateString() + "' AND Status = 'Success'";

                    string qry = "Select Item_Name,SUM(Quantity) as Quantity,SUM(Price) as Price,Date from Item_Transac WHERE  (Date >='" + dateTimePicker1.Value.ToShortDateString() + "' AND Date <='" + dateTimePicker2.Value.ToShortDateString() + "') AND Status = 'Success' group by Item_Name,Date";

                    this.Item_TransacTableAdapter.SetSQL(qry);
                    this.Item_TransacTableAdapter.Fill(this.masterDataSet7.Item_Transac);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("Please Select both Item and Date");
                    MessageBox.Show(ex.ToString());
                }
            }
            if (update == true)
            {
                try
                {
                    string qry = "Select Item_Name,SUM(Quantity) as Quantity,SUM(Price) as Price,Date from Item_Transac WHERE  (Date >='" + dateTimePicker1.Value.ToShortDateString() + "' AND Date <='" + dateTimePicker2.Value.ToShortDateString() + "') AND Status = 'Success' AND " + "Item_Name ='" + comboBox1.SelectedItem.ToString() + "' group by Item_Name,Date";

                    this.Item_TransacTableAdapter.SetSQL(qry);
                    this.Item_TransacTableAdapter.Fill(this.masterDataSet7.Item_Transac);
                    this.reportViewer1.RefreshReport();
                }
                catch (Exception ex)
                {
                    string qry = "Select Item_Name,SUM(Quantity) as Quantity,SUM(Price) as Price,Date from Item_Transac WHERE  (Date >='" + dateTimePicker1.Value.ToShortDateString() + "' AND Date <='" + dateTimePicker2.Value.ToShortDateString() + "') AND Status = 'Success' group by Item_Name,Date";

                    this.Item_TransacTableAdapter.SetSQL(qry);
                    this.Item_TransacTableAdapter.Fill(this.masterDataSet7.Item_Transac);
                    this.reportViewer1.RefreshReport();
                }
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            update = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Item_Name,SUM(Quantity) as Quantity,SUM(Price) as Price,Date from Item_Transac WHERE  (Date >='" + dateTimePicker1.Value.ToShortDateString() + "' AND Date <='" + dateTimePicker2.Value.ToShortDateString() + "') AND Status = 'Success' group by Item_Name,Date")
                {
                    Connection = con
                };


                try
                {
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        try
                        {
                            Item_Name.Add(data[0].ToString());
                            Total_Quant.Add(Convert.ToInt32(data[1].ToString()));
                            Total_Price.Add(Convert.ToDouble(data[2].ToString()));
                            Item_date.Add(data[3].ToString());
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                con.Close();
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill1);
                printDocument.Print();

                if (Item_Name.Count >= 55)
                {
                    PrintDocument printDocument1 = new PrintDocument();
                    printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill2);
                    printDocument1.Print();
                }

                if (Item_Name.Count >= 110)
                {
                    PrintDocument printDocument2 = new PrintDocument();
                    printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill3);
                    printDocument2.Print();
                }

                if (Item_Name.Count >= 165)
                {
                    PrintDocument printDocument3 = new PrintDocument();
                    printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill4);
                    printDocument3.Print();
                }

                if (Item_Name.Count >= 220)
                {
                    PrintDocument printDocument5 = new PrintDocument();
                    printDocument5.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill5);
                    printDocument5.Print();
                }

                if (Item_Name.Count >= 275)
                {
                    PrintDocument printDocument6 = new PrintDocument();
                    printDocument6.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill6);
                    printDocument6.Print();
                }

                if (Item_Name.Count >= 330)
                {
                    PrintDocument printDocument7 = new PrintDocument();
                    printDocument7.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill7);
                    printDocument7.Print();
                }

                if (Item_Name.Count >= 385)
                {
                    PrintDocument printDocument8 = new PrintDocument();
                    printDocument8.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill8);
                    printDocument8.Print();
                }
                if (Item_Name.Count >= 440)
                {
                    PrintDocument printDocument9 = new PrintDocument();
                    printDocument9.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill9);
                    printDocument9.Print();
                }

                if (Item_Name.Count >= 495)
                {
                    PrintDocument printDocument4 = new PrintDocument();
                    printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill10);
                    printDocument4.Print();
                }

                if (Item_Name.Count >= 550)
                {
                    PrintDocument printDocument4 = new PrintDocument();
                    printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill11);
                    printDocument4.Print();
                }
				ClearAll();

			}
            if (update == true)
            {
                try
                {
                    string qry = "Select Item_Name,SUM(Quantity) as Quantity,SUM(Price) as Price,Date from Item_Transac WHERE  (Date >='" + dateTimePicker1.Value.ToShortDateString() + "' AND Date <='" + dateTimePicker2.Value.ToShortDateString() + "') AND Status = 'Success' AND " + "Item_Name ='" + comboBox1.SelectedItem.ToString() + "' group by Item_Name,Date";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry)
                    {
                        Connection = con
                    };
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        Item_Name.Add(data[0].ToString());
                        Total_Quant.Add(Convert.ToInt32(data[1].ToString()));
                        Total_Price.Add(Convert.ToDouble(data[2].ToString()));
                        Item_date.Add(data[3].ToString());
                    }
                    con.Close();
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill1);
                    printDocument.Print();
                }
                catch (Exception ex)
                {
                    string qry = "Select Item_Name,SUM(Quantity) as Quantity,SUM(Price) as Price,Date from Item_Transac WHERE  (Date >='" + dateTimePicker1.Value.ToShortDateString() + "' AND Date <='" + dateTimePicker2.Value.ToShortDateString() + "') AND Status = 'Success' AND " + "Item_Name ='" + comboBox1.SelectedItem.ToString() + "' group by Item_Name,Date";
                    SqlConnection con = new SqlConnection(ConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry)
                    {
                        Connection = con
                    };
                    SqlDataReader data = cmd.ExecuteReader();
                    while (data.Read())
                    {
                        Item_Name.Add(data[0].ToString());
                        Total_Quant.Add(Convert.ToInt32(data[1].ToString()));
                        Total_Price.Add(Convert.ToDouble(data[2].ToString()));
                        Item_date.Add(data[3].ToString());
                    }
                    con.Close();
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill1);
                    printDocument.Print();

                    if (Item_Name.Count >= 55)
                    {
                        PrintDocument printDocument1 = new PrintDocument();
                        printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill2);
                        printDocument1.Print();
                    }

                    if (Item_Name.Count >= 110)
                    {
                        PrintDocument printDocument2 = new PrintDocument();
                        printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill3);
                        printDocument2.Print();
                    }

                    if (Item_Name.Count >= 165)
                    {
                        PrintDocument printDocument3 = new PrintDocument();
                        printDocument3.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill4);
                        printDocument3.Print();
                    }

                    if (Item_Name.Count >= 220)
                    {
                        PrintDocument printDocument5 = new PrintDocument();
                        printDocument5.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill5);
                        printDocument5.Print();
                    }

                    if (Item_Name.Count >= 275)
                    {
                        PrintDocument printDocument6 = new PrintDocument();
                        printDocument6.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill6);
                        printDocument6.Print();
                    }

                    if (Item_Name.Count >= 330)
                    {
                        PrintDocument printDocument7 = new PrintDocument();
                        printDocument7.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill7);
                        printDocument7.Print();
                    }

                    if (Item_Name.Count >= 385)
                    {
                        PrintDocument printDocument8 = new PrintDocument();
                        printDocument8.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill8);
                        printDocument8.Print();
                    }
                    if (Item_Name.Count >= 440)
                    {
                        PrintDocument printDocument9 = new PrintDocument();
                        printDocument9.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill9);
                        printDocument9.Print();
                    }

                    if (Item_Name.Count >= 495)
                    {
                        PrintDocument printDocument4 = new PrintDocument();
                        printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill10);
                        printDocument4.Print();
                    }

                    if (Item_Name.Count >= 550)
                    {
                        PrintDocument printDocument4 = new PrintDocument();
                        printDocument4.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill11);
                        printDocument4.Print();
                    }
                    ClearAll();


                }

            }

        }

        public void ClearAll()
        {
            Item_Name.Clear();
            Total_Quant.Clear();
            Total_Price.Clear();
            Item_date.Clear();

        }

		public void CreateBill1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics graphic = e.Graphics;

			Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

			float fontHeight = font.GetHeight();


			int startX = 10;
			int startY = 10;

			graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
			graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
			graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
			graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
			graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
			graphic.DrawString("ITEM WISE LIST 1", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
			string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12)+"Date";
			graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
			//offset = offset + (int)fontHeight; //make the spacing consistent
			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

			int i = 9, j;

			for(j=0;j<55; j++)
			{
				try
				{
					graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

					graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New",6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

					graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

					graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
					i++;
				}
				catch
				{
					continue;
				}
			}

			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
			graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

			graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

			graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString((Total_Price.Sum()+(Total_Price.Sum()*0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			//graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
			

		}

		public void CreateBill2(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics graphic = e.Graphics;

			Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

			float fontHeight = font.GetHeight();


			int startX = 10;
			int startY = 10;

			graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
			graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
			graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
			graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
			graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
			graphic.DrawString("ITEM WISE LIST 2", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
			string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
			graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
			//offset = offset + (int)fontHeight; //make the spacing consistent
			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

			int i = 9, j;

			for (j = 55; j < 110; j++)
			{
				try
				{
					graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

					graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

					graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

					graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
					i++;
				}
				catch
				{
					continue;
				}
			}

			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
			graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

			graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

			graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
			graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
			//graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
			

		}

        public void CreateBill3(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 3", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 110; j < 165; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
            

        }

        public void CreateBill4(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 4", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 165; j < 220; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
            

        }

        public void CreateBill5(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 5", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 220; j < 275; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 6, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 6), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 6, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 6), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
            

        }

        public void CreateBill6(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 6", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 275; j < 330; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
            

        }

        public void CreateBill7(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 7", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 330; j < 385; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
           

        }

        public void CreateBill8(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 8", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 385; j < 440; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
            

        }

        public void CreateBill9(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 9", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 440; j < 495; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
            

        }

        public void CreateBill10(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 10", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 495; j < 550; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
            

        }

        public void CreateBill11(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 10, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();


            int startX = 10;
            int startY = 10;

            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("ITEM WISE LIST 11", new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY + (int)(5 * fontHeight));

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));
            string top = " Item Name".PadRight(19) + "Qty".PadRight(5) + "Price(Rs)".PadRight(12) + "Date";
            graphic.DrawString(top, new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(7 * fontHeight));
            //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8 * fontHeight));

            int i = 9, j;

            for (j = 550; j < 610; j++)
            {
                try
                {
                    graphic.DrawString(Item_Name[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 5, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Quant[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 120, startY + (int)(i * fontHeight));

                    graphic.DrawString(Total_Price[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 160, startY + (int)(i * fontHeight));

                    graphic.DrawString(Item_date[j].ToString(), new Font("Courier New", 6), new SolidBrush(Color.Black), startX + 210, startY + (int)(i * fontHeight));
                    i++;
                }
                catch
                {
                    continue;
                }
            }

            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(i * fontHeight));
            graphic.DrawString("Total", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString(Total_Price.Sum().ToString(), font, new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("CGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 7, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 7), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));

            graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            graphic.DrawString((Total_Price.Sum() + (Total_Price.Sum() * 0.05)).ToString(), new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 210, startY + (int)(i * fontHeight));
            graphic.DrawString("-------------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(++i * fontHeight));
            //graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(++i * fontHeight));
           
        }
    }
	}

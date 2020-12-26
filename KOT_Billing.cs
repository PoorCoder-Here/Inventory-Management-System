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
	public partial class KOT_Billing : Form
	{
		public string[] Item_Name_load = new string[1000];
		public string[] Item_Sel = new string[70];
		public int[] Qty_Sel = new int[70];
		public int[] Item_Code_load = new int[1000];
		public double[] Price_load = new double[1000];
		public double[] Price_swiggy = new double[1000];
		public double[] Price_zomato = new double[1000];
		public double[] Price_uber = new double[1000];
		public double[] Price_fp = new double[1000];
		public double[] Price_parcel = new double[1000];
		public double[] Price_del = new double[1000];
		public double[] Price_print = new double[70];
		public string[] Item_Sel_reprint = new string[70];
		public int[] Qty_Sel_reprint = new int[70];
		public double[] Price_print_reprint = new double[70];
		List<string> Itm_sel = new List<string>();
		List<int> Quan = new List<int>();
		List<Double> Price_sel = new List<Double>();
		int index = 0,ordr,row_index,count=0;
        bool chk = false;
		double totl;
		public KOT_Billing(string uid)
		{
			InitializeComponent();
			userid.Text = uid;

		}
		string ConnectionString = @"Server=.;Database=Pandiyan;Trusted_Connection=True;";


		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
            switch (comboBox2.Text)
            {
                case "1":
                    comboBox2.SelectedItem = "DineIn";
                   
                    break;
                case "2":
                    comboBox2.SelectedItem = "TakeAway";
                    totl = 0;
                    dataGridView1.Rows.Clear();
                    Itm_sel.Clear(); ;
                    Quan.Clear();
                    Price_sel.Clear();
                    break;
                case "3":
                    comboBox2.SelectedItem = "Swiggy";
                    break;
                case "4":
                    comboBox2.SelectedItem = "Zomato";
                    break;
                case "5":
                    comboBox2.SelectedItem = "FoodPanda";
                    break;
                case "6":
                    comboBox2.SelectedItem = "UberEats";
                    break;
                case "7":
                    comboBox2.SelectedItem = "Delivery";
                    break;

                default:
                    break;
            }
        }

		private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
		{
			
		}

		private void KOT_Billing_Load(object sender, EventArgs e)
		{
			this.CenterToParent();
			// TODO: This line of code loads data into the 'masterDataSet5.Transac_Details' table. You can move, or remove it, as needed.
			this.transac_DetailsTableAdapter.Fill(this.masterDataSet5.Transac_Details);
            // TODO: This line of code loads data into the 'transac_His.Transac_Details' table. You can move, or remove it, as needed.
            //this.transac_DetailsTableAdapter.Fill(this.transac_His.Transac_Details);
            comboBox2.SelectedItem = "DineIn" ;
            Main_Page nxt = new Main_Page(userid.Text);
            

			
            comboBox3.SelectedItem = "Cash";
            string qry = "SELECT * from Transac_Details WHERE Date ='" + DateTime.Today.ToShortDateString() + "' ORDER BY Date DESC";

            this.MinimizeBox = false;
			ordr = Update_Ordrno() + 1;
			OrderNo.Text = Convert.ToString(ordr);
			
			try
			{

				int i = 0, j = 0,k=0,l=0,m=0,n=0,p=0,q=0,r=0;

				
				SqlConnection con = new SqlConnection(ConnectionString);
				con.Open();
				SqlCommand cmd = new SqlCommand("SELECT Item_Name from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data = cmd.ExecuteReader();
				while (data.Read())
				{
					Item_Name_load[i] = Convert.ToString(data[0]);
					comboBox4.Items.Add(data[0]);
					i++;

				}
				data.Close();

				SqlCommand cmd1 = new SqlCommand("SELECT Price from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data1 = cmd1.ExecuteReader();

				while (data1.Read())
				{
					Price_load[j] = Convert.ToDouble(data1[0]);
					j++;
				}
				data1.Close();


				SqlCommand cmd2 = new SqlCommand("SELECT Item_Code from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data2 = cmd2.ExecuteReader();

				while (data2.Read())
				{
					Item_Code_load[k] = Convert.ToInt32(data2[0]);
					k++;
				}
				data2.Close();

				SqlCommand cmd3 = new SqlCommand("select Parcel_Price from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data3 = cmd3.ExecuteReader();

				while (data3.Read())
				{
					Price_parcel[l] = Convert.ToDouble(data3[0]);
					l++;
				}
				data3.Close();

				SqlCommand cmd4 = new SqlCommand("SELECT Delivery_Price from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data4 = cmd4.ExecuteReader();

				while (data4.Read())
				{
					Price_del[m] = Convert.ToDouble(data4[0]);
					m++;
				}
				data4.Close();

				SqlCommand cmd5 = new SqlCommand("SELECT Swiggy_Price from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data5 = cmd5.ExecuteReader();

				while (data5.Read())
				{
					Price_swiggy[n] = Convert.ToDouble(data5[0]);
					n++;
				}
				data5.Close();

				SqlCommand cmd6 = new SqlCommand("SELECT Zomato_Price from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data6 = cmd6.ExecuteReader();

				while (data6.Read())
				{
					Price_zomato[p] = Convert.ToDouble(data6[0]);
					p++;
				}
				data6.Close();

				SqlCommand cmd7 = new SqlCommand("SELECT UberEats_Price from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data7 = cmd7.ExecuteReader();

				while (data7.Read())
				{
					Price_uber[q] = Convert.ToDouble(data7[0]);
					q++;
				}
				data7.Close();

				SqlCommand cmd8 = new SqlCommand("SELECT FoodPanda_Price from Menu where Status = 'Active'")
				{
					Connection = con
				};

				SqlDataReader data8 = cmd8.ExecuteReader();

				while (data8.Read())
				{
					Price_fp[r] = Convert.ToDouble(data8[0]);
					r++;
				}
				data8.Close();

				con.Close();
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(Convert.ToString(ex));
			}

			comboBox2.Focus();
		}

		private void Add_Click(object sender, EventArgs e)
		{
			Add_Item();
		}

		private void selectall(object sender, EventArgs e)
		{
			Itm_Code.SelectAll();
			textBox2.SelectAll();
		}

		private void Itm_Code_TextChanged(object sender, EventArgs e)
		{
			
				Itm_Code.DeselectAll();
				chk = true;
				if(Itm_Code.Text == "0")
				Itm_Code.ResetText();
			try
			{
				for (int i = 0; i < 1000; i++)
				{
					if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
					{
						comboBox4.Text = Item_Name_load[i];
						break;
					}
				}
			}
			catch (Exception ex)
			{
					
			}
			
		}


		int temp;
		public int Update_Ordrno()
		{
			
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("SELECT MAX(OrderNumber) from Transac_Details where (Date ='" + DateTime.Today.ToShortDateString() + "')")
			{
				Connection = con
			};

			SqlDataReader data = cmd.ExecuteReader();
			while (data.Read())
			{
				try
				{
					temp = data.GetInt32(0);
				}
				catch (Exception ex)
				{
					if (ex.Equals("Data is Null. This method or property cannot be called on Null values."))
					{
						temp = 1;
					}
				}
			}
			con.Close();
			return temp;
		}

		

		private void Delete_Click(object sender, EventArgs e)
		{
			try
			{
                DataGridViewRow row = this.dataGridView1.Rows[row_index];
                totl -= (Convert.ToDouble(dataGridView1.Rows[row_index].Cells[3].Value)+ Convert.ToDouble(dataGridView1.Rows[row_index].Cells[3].Value)*0.05);
				
				Amount.Text = Convert.ToString(totl);
				dataGridView1.Rows.Remove(row);
				//for (int ind = 0; ind < 70; ind++)
				//{
				//    Item_Sel[ind] = null;
				//    Qty_Sel[ind] = 0;
				//    Price_print[ind] = 0;

				//}
				Itm_sel.RemoveAt(row_index);
				Quan.RemoveAt(row_index);
				Price_sel.RemoveAt(row_index);
			}
			catch(Exception ex)
			{

			}
			//try
			//{
			//	count--;
			//}
			//catch
			//{
			//	count = 0;
			//}
		}

		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)

		{
			switch (keyData)
			{
				case Keys.Space:
					if (dataGridView1.RowCount != 1)
					{
										

						
						SqlConnection con = new SqlConnection(ConnectionString);
						con.Open();
						SqlCommand cmd = new SqlCommand("INSERT into dbo.Transac_Details (OrderNumber,Total,Date,DeliveryMode,PaymentMode,Status) VALUES ('" + ordr + "'," + "'" + totl + "','" + DateTime.Today.ToShortDateString() + "','" + Convert.ToString(comboBox2.SelectedItem) + "'," + "'" + Convert.ToString(comboBox3.SelectedItem) + "','Success')")
						{
							Connection = con
						};
						cmd.ExecuteNonQuery();
						con.Close();
						con.Open();


						for (int i = 0; i < Itm_sel.Count; i++)
						{

							SqlCommand cmd1 = new SqlCommand("INSERT into dbo.Item_Transac (Order_Num,Item_Name,Quantity,Date,STatus,Price,Mode) VALUES ('" + ordr + "'," + "'" + Itm_sel.ElementAt(i) + "'," + "'" + Quan.ElementAt(i) + "'," + "'" + DateTime.Today.ToShortDateString() + "','Success','" + Price_sel.ElementAt(i) + "','" + comboBox2.SelectedItem.ToString() + "')")
							{
								Connection = con
							};
							cmd1.ExecuteNonQuery();
						}
						con.Close();
						PrintDialog printDialog = new PrintDialog();

						PrintDocument printDocument = new PrintDocument();

						printDialog.Document = printDocument;

						printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill);
						printDocument.Print();

						if (comboBox2.SelectedItem.ToString() == "TakeAway")
						{
							PrintDocument printDocument1 = new PrintDocument();
							printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill_Takeaway);
							printDocument1.Print();
						}


					}
					else
					{
						MessageBox.Show("Please Add Items to the Bill");
					}
					return base.ProcessCmdKey(ref msg, keyData);
				case Keys.Delete:
					try
					{
                        DataGridViewRow row = this.dataGridView1.Rows[row_index];
                        totl -= (Convert.ToDouble(dataGridView1.Rows[row_index].Cells[3].Value) + Convert.ToDouble(dataGridView1.Rows[row_index].Cells[3].Value) * 0.05);
						
						Amount.Text = Convert.ToString(totl);
                        dataGridView1.Rows.Remove(row);
                        Itm_sel.RemoveAt(row_index);
						Quan.RemoveAt(row_index);
						Price_sel.RemoveAt(row_index);
                    }
					catch (Exception ex)
					{
						
					}
					
					return base.ProcessCmdKey(ref msg, keyData);

				case Keys.Right :
                    comboBox4.Focus();
                    return true;
                case Keys.Left:
                    comboBox2.Focus();
                    return true;

                case Keys.Enter:
                    if (comboBox4.Focused != true)
                    {
                        SendKeys.Send("{TAB}");
                        if (Itm_Code.Focused != true & comboBox2.Focused != true)
                            Add_Item();
                    }
                    else
                    {
                        textBox2.Focus();
                    }
                    return true;

                default:
					return base.ProcessCmdKey(ref msg, keyData);
			}
		}

		private void refresh_Click(object sender, EventArgs e)
		{
			this.transac_DetailsTableAdapter.Fill(this.masterDataSet5.Transac_Details);
		}

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                if (Item_Name_load[i] == comboBox4.SelectedItem.ToString())
                {
                    Itm_Code.Text = Item_Code_load[i].ToString();
                }
            }
        }

		private void fillByToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				//this.transac_DetailsTableAdapter.FillBy(this.masterDataSet5.Transac_Details);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				//this.transac_DetailsTableAdapter.FillBy1(this.masterDataSet5.Transac_Details);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}
		int recent_sel;
		string recent_date;
		private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
			recent_sel = Convert.ToInt32(row.Cells[0].Value.ToString());
			recent_date = Convert.ToString(row.Cells[2].Value.ToString());
		}
		

		private void reprint_Click(object sender, EventArgs e)
		{
			int rep_i = 0, rep_j = 0, rep_k = 0;
			
			SqlConnection con = new SqlConnection(ConnectionString);
			con.Open();
			SqlCommand cmd = new SqlCommand("SELECT Item_Name from Item_Transac where Order_Num = '" + recent_sel+"' AND Date ='"+ recent_date + "'")
			{
				Connection = con
			};
			SqlDataReader data = cmd.ExecuteReader();
			while (data.Read())
			{
				Item_Sel_reprint[rep_i] = Convert.ToString(data[0]);
				rep_i++;
			}
			data.Close();

			SqlCommand cmd1 = new SqlCommand("SELECT Quantity from Item_Transac where Order_Num = '" + recent_sel + "' AND Date ='" + recent_date + "'")
			{
				Connection = con
			};
			SqlDataReader data1 = cmd1.ExecuteReader();
			while (data1.Read())
			{
				Qty_Sel_reprint[rep_j] = Convert.ToInt32(data1[0]);
				rep_j++;
			}
			data1.Close();

			SqlCommand cmd2 = new SqlCommand("SELECT Price from Item_Transac where Order_Num = '" + recent_sel + "' AND Date ='" + recent_date + "'")
			{
				Connection = con
			};
			SqlDataReader data2 = cmd2.ExecuteReader();
			while (data2.Read())
			{
				Price_print_reprint[rep_k] = Convert.ToDouble(data2[0]);
				rep_k++;
			}
			data2.Close();
			//PrintDialog printDialog = new PrintDialog();

			PrintDocument printDocument = new PrintDocument();

			//printDialog.Document = printDocument;

			printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill_reprint);
			printDocument.Print();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
			row_index = row.Index;
		}

		private void Print_Click(object sender, EventArgs e)
		{
            
            if (dataGridView1.RowCount != 1)
			{
				this.dataGridView1.Rows.Clear();
				comboBox1.ResetText();
				comboBox4.ResetText();
				Itm_Code.ResetText();
				textBox2.ResetText();
				Amount.ResetText();
               

              
				SqlConnection con = new SqlConnection(ConnectionString);
				con.Open();
				SqlCommand cmd = new SqlCommand("INSERT into dbo.Transac_Details (OrderNumber,Total,Date,DeliveryMode,PaymentMode,Status) VALUES ('" + ordr + "'," + "'" + totl + "','" +DateTime.Today.ToShortDateString() + "','" + Convert.ToString(comboBox2.SelectedItem) + "'," + "'" + Convert.ToString(comboBox3.SelectedItem) + "','Success')")
				{
					Connection = con
				};
				cmd.ExecuteNonQuery();

				

				for (int i = 0; i < Itm_sel.Count; i++)
				{
					
					SqlCommand cmd1 = new SqlCommand("INSERT into dbo.Item_Transac (Order_Num,Item_Name,Quantity,Date,STatus,Price,Mode) VALUES ('" + ordr + "'," + "'" + Itm_sel.ElementAt(i) + "'," + "'" +Quan.ElementAt(i) + "'," + "'" +DateTime.Today.ToShortDateString()+ "','Success','"+Price_sel.ElementAt(i)+"','"+comboBox2.SelectedItem.ToString()+"')")
					{
						Connection = con
					};
					cmd1.ExecuteNonQuery();
				}
				con.Close();
				PrintDialog printDialog = new PrintDialog();

				PrintDocument printDocument = new PrintDocument();

				printDialog.Document = printDocument;

				printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill);
				printDocument.Print();
		/*		if(comboBox2.SelectedItem.ToString() == "TakeAway")
				{
					

					PrintDocument printDocument1 = new PrintDocument();

					

					printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(CreateBill_Takeaway);
					printDocument1.Print();
				}
				*/
				
                
			}
			else
			{
				MessageBox.Show("Please Add Items to the Bill");
			}


			
		}


		public void CreateBill(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
            Graphics graphic = e.Graphics;

            Font font = new Font("Courier New", 12, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

            float fontHeight = font.GetHeight();

            int startX = 10;
            int startY = 10;
            int offset = 40;


            graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY);
            graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)fontHeight);
            graphic.DrawString("3/PC18 MMDA,", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2 * fontHeight));
            graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(3 * fontHeight));
            graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(4 * fontHeight));
            graphic.DrawString("Date: " + DateTime.Now.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + (int)(5 * fontHeight));
            graphic.DrawString("Payment Mode:" + Convert.ToString(comboBox3.SelectedItem), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));

            graphic.DrawString( Convert.ToString(ordr), new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), 200, startY + (int)(6.8 * fontHeight));

			//graphic.DrawString(Convert.ToString(9999), new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), 200, startY + (int)(6.8 * fontHeight));
			graphic.DrawString(Convert.ToString(comboBox2.SelectedItem), new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(6.8 * fontHeight));

			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(8.2 * fontHeight));
			string top = "Item Name".PadRight(17) + "Qty".PadRight(6) + "Price(Rs)";
            graphic.DrawString(top, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(8.9 * fontHeight));
           //offset = offset + (int)fontHeight; //make the spacing consistent
            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(9.5 * fontHeight));

			int itm_i = 11, qtyy_i = 11, pri_i = 11;

			foreach (string Itm in Itm_sel)
			{
				if (Itm != null)
				{
					graphic.DrawString(Itm, new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + (int)(itm_i * fontHeight));
					itm_i++;
				}
			}
			foreach (int qtyy in Quan)
			{
				if (qtyy != 0)
				{
					graphic.DrawString(Convert.ToString(qtyy), new Font("Courier New", 8), new SolidBrush(Color.Black), 160, startY + (int)(qtyy_i * fontHeight));
					qtyy_i++;
				}
			}
			foreach (int pri in Price_sel)
			{
				if (pri != 0)
				{
					graphic.DrawString(Convert.ToString(pri), new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i * fontHeight));
					pri_i++;
				}
			}


			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(pri_i++ * fontHeight));

            graphic.DrawString("CGST", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i++ * fontHeight));

            graphic.DrawString("SGST", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
            graphic.DrawString("2.5%", new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i++ * fontHeight));

            graphic.DrawString("Total", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
			graphic.DrawString("(Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX+70, startY + (int)(pri_i * fontHeight)+7);
			graphic.DrawString(Convert.ToString(Convert.ToInt32(totl)), new Font("Courier New", 18, FontStyle.Bold), new SolidBrush(Color.Black), 215, startY + (int)(pri_i++ * fontHeight)-3);
            graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(pri_i++ * fontHeight));
            graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(pri_i++ * fontHeight));

			//for (int ind = 0; ind < 70; ind++)
			//{
			//	Item_Sel[ind] = null;
			//	Qty_Sel[ind] = 0;
			//	Price_print[ind] = 0;

			//}
			//count = 0;
			
			if (!(comboBox2.SelectedItem.ToString() == "TakeAway"))
			{
				comboBox2.SelectedItem = "DineIn";
				comboBox3.SelectedItem = "Cash";
                comboBox1.SelectedItem = "1";
				Itm_sel.Clear();
				Quan.Clear();
				Price_sel.Clear();
				totl = 0;
				ordr += 1;
				OrderNo.Text = Convert.ToString(ordr);
				this.dataGridView1.Rows.Clear();
				comboBox1.ResetText();
				//comboBox4.ResetText();
				Itm_Code.ResetText();
				textBox2.ResetText();
				Amount.ResetText();
				Itm_Code.ResetText();
				comboBox4.ResetText();
				textBox2.ResetText();
				comboBox2.Focus();

			}

			this.Show();
			dataGridView2.Refresh();

		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void Button_Logout_Click(object sender, EventArgs e)
		{
			this.Hide();
			Login prev = new Login();
			prev.Closed += (s, args) => this.Close();
			prev.Show();
		}
		bool _purchase_flag = false;
		private void Button_Purchase_Click(object sender, EventArgs e)
		{
			foreach (Form f in Application.OpenForms)
			{
				if (f.Name == "Purchase")
				{
					f.BringToFront();
					_purchase_flag = true;
				}
				else
				{
					_purchase_flag = false;
				}

			}
			if (_purchase_flag == false)
			{
				
				Purchase next = new Purchase();
				next.Show();
				_purchase_flag = true;
			}
			
		}
		bool _salary_flag = false;
		private void button_Salary_Click(object sender, EventArgs e)
		{
			foreach (Form f in Application.OpenForms)
			{
				if (f.Name == "Employee_Salary")
				{
					f.BringToFront();
					_salary_flag = true;
				}
				else
				{
					_salary_flag = false;
				}

			}
			if (_salary_flag == false)
			{

				Employee_Salary next = new Employee_Salary();
				next.Show();
				_salary_flag = true;
			}

		}

		public void CreateBill_reprint(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics graphic = e.Graphics;
			float tot_reprint=0;

			Font font = new Font("Courier New", 12, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

			float fontHeight = font.GetHeight();

			int startX = 10;
			int startY = 10;
			int offset = 40;


			
			graphic.DrawString("REPRINT", new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), 85, startY);

			graphic.DrawString("Pandiyan Heritage Restaurants", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 30, startY + (int)(1.5 * fontHeight));
			graphic.DrawString("Private Limited", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 90, startY + (int)(2.5 * fontHeight));

			graphic.DrawString("3 / PC18 MMDA", new Font("Courier New", 10), new SolidBrush(Color.Black), 90, startY + (int)(3.5 * fontHeight));

			//graphic.DrawString(Convert.ToString(9999), new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), 200, startY + (int)(6.8 * fontHeight));
			graphic.DrawString("J.J. Nagar,Moggapair West-37", new Font("Courier New", 10), new SolidBrush(Color.Black), 30, startY + (int)(4.5 * fontHeight));

			graphic.DrawString("GSTIN:33AAJCP3942N121  ", new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), 60, startY + (int)(5.5 * fontHeight));
			graphic.DrawString("Date: " + DateTime.Now.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + (int)(6.5 * fontHeight));

			graphic.DrawString("Order No:" + Convert.ToString(recent_sel), new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)( 8.2* fontHeight));

			graphic.DrawString("Order Type:" + Convert.ToString(comboBox2.SelectedItem), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + (int)(7.5 * fontHeight));

			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(9.5 * fontHeight));

			string top = "Item Name".PadRight(17) + "Qty".PadRight(6) + "Price(Rs)";
			graphic.DrawString(top, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(10.3 * fontHeight));
			//offset = offset + (int)fontHeight; //make the spacing consistent
			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(11 * fontHeight));

			int itm_i = 12, qtyy_i = 12, pri_i = 12;

			foreach (string Itm in Item_Sel_reprint)
			{
				if (Itm != null)
				{
					graphic.DrawString(Itm, new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + (int)(itm_i * fontHeight));
					itm_i++;
				}
			}
			foreach (int qtyy in Qty_Sel_reprint)
			{
				if (qtyy != 0)
				{
					graphic.DrawString(Convert.ToString(qtyy), new Font("Courier New", 8), new SolidBrush(Color.Black), 160, startY + (int)(qtyy_i * fontHeight));
					qtyy_i++;
				}
			}
			foreach (int pri in Price_print_reprint)
			{
				if (pri != 0)
				{
					graphic.DrawString(Convert.ToString(pri), new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i * fontHeight));
					tot_reprint += pri;
					pri_i++;
				}
			}
			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(pri_i++ * fontHeight));

			graphic.DrawString("CGST", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i++ * fontHeight));

			graphic.DrawString("SGST", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i++ * fontHeight));

			graphic.DrawString("Total", new Font("Courier New", 16, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
			graphic.DrawString("(Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX + 70, startY + (int)(pri_i * fontHeight) + 7);
			graphic.DrawString(Convert.ToString(Convert.ToInt32(tot_reprint+ tot_reprint*0.05)), new Font("Courier New", 18, FontStyle.Bold), new SolidBrush(Color.Black), 215, startY + (int)(pri_i++ * fontHeight) - 3);
			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(pri_i++ * fontHeight));
			graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(pri_i++ * fontHeight));

			for (int ind = 0; ind < 70; ind++)
			{
				Item_Sel_reprint[ind] = null;
				Qty_Sel_reprint[ind] = 0;
				Price_print_reprint[ind] = 0;

			}
			

			this.Show();
			dataGridView2.Refresh();

		}

		public void CreateBill_Takeaway(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			Graphics graphic = e.Graphics;

			Font font = new Font("Courier New", 12, FontStyle.Bold); //must use a mono spaced font as the spaces need to line up

			float fontHeight = font.GetHeight();

			int startX = 10;
			int startY = 10;
			int offset = 40;


			graphic.DrawString("TAKE AWAY", new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), 50, startY);

			graphic.DrawString("Date: " + DateTime.Now.ToString(), new Font("Courier New", 10), new SolidBrush(Color.Black), startX, startY + (int)(1.5 * fontHeight));
			graphic.DrawString("KITCHEN COPY", new Font("Courier New", 12, FontStyle.Bold),  new SolidBrush(Color.Black), startX, startY + (int)(2.1 * fontHeight));

			graphic.DrawString(Convert.ToString(ordr), new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), 200, startY + (int)(3 * fontHeight));

			//graphic.DrawString(Convert.ToString(9999), new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), 200, startY + (int)(6.8 * fontHeight));
			graphic.DrawString("Order No:" , new Font("Courier New", 20, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(3 * fontHeight));

			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(4.5 * fontHeight));
			string top = "Item Name".PadRight(17) + "Qty".PadRight(6) + "Price(Rs)";
			graphic.DrawString(top, new Font("Courier New", 10, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(5.4 * fontHeight));
			//offset = offset + (int)fontHeight; //make the spacing consistent
			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(6 * fontHeight));

			int itm_i = 7, qtyy_i = 7, pri_i = 7;

			foreach (string Itm in Itm_sel)
			{
				if (Itm != null)
				{
					graphic.DrawString(Itm, new Font("Courier New", 8), new SolidBrush(Color.Black), startX, startY + (int)(itm_i * fontHeight));
					itm_i++;
				}
			}
			foreach (int qtyy in Quan)
			{
				if (qtyy != 0)
				{
					graphic.DrawString(Convert.ToString(qtyy), new Font("Courier New", 8), new SolidBrush(Color.Black), 160, startY + (int)(qtyy_i * fontHeight));
					qtyy_i++;
				}
			}
			foreach (int pri in Price_sel)
			{
				if (pri != 0)
				{
					graphic.DrawString(Convert.ToString(pri), new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i * fontHeight));
					pri_i++;
				}
			}


			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(pri_i++ * fontHeight));

			graphic.DrawString("CGST", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i++ * fontHeight));

			graphic.DrawString("SGST", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
			graphic.DrawString("2.5%", new Font("Courier New", 8), new SolidBrush(Color.Black), 220, startY + (int)(pri_i++ * fontHeight));

			graphic.DrawString("Total (Incl. of all Taxes)", new Font("Courier New", 8, FontStyle.Bold), new SolidBrush(Color.Black), startX, startY + (int)(pri_i * fontHeight));
			graphic.DrawString(Convert.ToString(Convert.ToInt32(totl)), new Font("Courier New", 11, FontStyle.Bold), new SolidBrush(Color.Black), 220, startY + (int)(pri_i++ * fontHeight));
			graphic.DrawString("----------------------------", font, new SolidBrush(Color.Black), startX, startY + (int)(pri_i++ * fontHeight));
			graphic.DrawString("Thank You, Visit Again!!", font, new SolidBrush(Color.Black), 35, startY + (int)(pri_i++ * fontHeight));

			for (int ind = 0; ind < 70; ind++)
			{
				Item_Sel[ind] = null;
				Qty_Sel[ind] = 0;
				Price_print[ind] = 0;

			}
			//count = 0;
			Itm_sel.Clear();
			Quan.Clear();
			Price_sel.Clear();
			totl = 0;
			ordr += 1;
			OrderNo.Text = Convert.ToString(ordr);
			this.dataGridView1.Rows.Clear();
			comboBox1.SelectedItem = "1";
			//comboBox4.ResetText();
			Itm_Code.ResetText();
			textBox2.ResetText();
			Amount.ResetText();
			Itm_Code.ResetText();
			comboBox4.ResetText();
			textBox2.ResetText();
			comboBox2.Focus();
			comboBox2.SelectedItem = "DineIn";
			comboBox3.SelectedItem = "Cash";

			this.Show();
			dataGridView2.Refresh();

		}

		public void Add_Item()
		{ 
			if (!string.IsNullOrEmpty(Itm_Code.Text))
			{
               // index = dataGridView1.Rows.Add();
                //count += 1;

                if (textBox2.Text == "")
				{
					textBox2.Text = "1";
					
				}

				if (index <= 45 & chk == true)
				{
					chk = false;
					try
					{
						if (comboBox2.SelectedItem.ToString() == "DineIn")
						{
							for (int i = 0; i< 1000; i++)
							{
								if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
								{

                                    index = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[index].Cells[0].Value = Itm_Code.Text; //Item Code
									dataGridView1.Rows[index].Cells[1].Value = comboBox4.Text; // Item Name
									dataGridView1.Rows[index].Cells[2].Value = textBox2.Text; //Quantity
									dataGridView1.Rows[index].Cells[3].Value = Convert.ToDouble(textBox2.Text) * Price_load[i];

									Itm_sel.Add(comboBox4.Text);
									Quan.Add(Convert.ToInt32(textBox2.Text));
									Price_sel.Add(Convert.ToDouble(textBox2.Text) * Price_load[i]);

									totl += (Convert.ToDouble(textBox2.Text) * Price_load[i]) + (Convert.ToDouble(textBox2.Text) * Price_load[i] * 0.05);
									//totl += 0.12 * totl;
									break;

								}

							}
						}

						if (comboBox2.SelectedItem.ToString() == "TakeAway")
						{
							for (int i = 0; i< 1000; i++)
							{
								if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
								{

                                    index = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[index].Cells[0].Value = Itm_Code.Text; //Item Code
									dataGridView1.Rows[index].Cells[1].Value = comboBox4.Text; // Item Name
									dataGridView1.Rows[index].Cells[2].Value = textBox2.Text; //Quantity
									dataGridView1.Rows[index].Cells[3].Value = Convert.ToDouble(textBox2.Text) * Price_parcel[i];



									Itm_sel.Add(comboBox4.Text);
									Quan.Add(Convert.ToInt32(textBox2.Text));
									Price_sel.Add(Convert.ToDouble(textBox2.Text) * Price_parcel[i]);

									totl += (Convert.ToDouble(textBox2.Text) * Price_parcel[i]) + (Convert.ToDouble(textBox2.Text) * Price_parcel[i] * 0.05);
									//totl += 0.12 * totl;
									break;

								}

							}
						}

						if (comboBox2.SelectedItem.ToString() == "Delivery")
						{
							for (int i = 0; i< 1000; i++)
							{
								if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
								{

                                    index = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[index].Cells[0].Value = Itm_Code.Text; //Item Code
									dataGridView1.Rows[index].Cells[1].Value = comboBox4.Text; // Item Name
									dataGridView1.Rows[index].Cells[2].Value = textBox2.Text; //Quantity
									dataGridView1.Rows[index].Cells[3].Value = Convert.ToDouble(textBox2.Text) * Price_del[i];



									Itm_sel.Add(comboBox4.Text);
									Quan.Add(Convert.ToInt32(textBox2.Text));
									Price_sel.Add(Convert.ToDouble(textBox2.Text) * Price_del[i]);

									totl += (Convert.ToDouble(textBox2.Text) * Price_del[i]) + (Convert.ToDouble(textBox2.Text) * Price_del[i] * 0.05);
									//totl += 0.12 * totl;
									break;

								}

							}
						}

						if (comboBox2.SelectedItem.ToString() == "Swiggy")
						{
							for (int i = 0; i< 1000; i++)
							{
								if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
								{

                                    index = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[index].Cells[0].Value = Itm_Code.Text; //Item Code
									dataGridView1.Rows[index].Cells[1].Value = comboBox4.Text; // Item Name
									dataGridView1.Rows[index].Cells[2].Value = textBox2.Text; //Quantity
									dataGridView1.Rows[index].Cells[3].Value = Convert.ToDouble(textBox2.Text) * Price_swiggy[i];



									Itm_sel.Add(comboBox4.Text);
									Quan.Add(Convert.ToInt32(textBox2.Text));
									Price_sel.Add(Convert.ToDouble(textBox2.Text) * Price_swiggy[i]);

									totl += (Convert.ToDouble(textBox2.Text) * Price_swiggy[i]) + (Convert.ToDouble(textBox2.Text) * Price_swiggy[i] * 0.05);
									//totl += 0.12 * totl;
									break;

								}

							}
						}

						if (comboBox2.SelectedItem.ToString() == "Zomato")
						{
							for (int i = 0; i< 1000; i++)
							{
								if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
								{
                                    index = dataGridView1.Rows.Add();

                                    dataGridView1.Rows[index].Cells[0].Value = Itm_Code.Text; //Item Code
									dataGridView1.Rows[index].Cells[1].Value = comboBox4.Text; // Item Name
									dataGridView1.Rows[index].Cells[2].Value = textBox2.Text; //Quantity
									dataGridView1.Rows[index].Cells[3].Value = Convert.ToDouble(textBox2.Text) * Price_zomato[i];



									Itm_sel.Add(comboBox4.Text);
									Quan.Add(Convert.ToInt32(textBox2.Text));
									Price_sel.Add(Convert.ToDouble(textBox2.Text) * Price_zomato[i]);

									totl += (Convert.ToDouble(textBox2.Text) * Price_zomato[i]) + (Convert.ToDouble(textBox2.Text) * Price_zomato[i] * 0.05);
									//totl += 0.12 * totl;
									break;

								}

							}
						}

						if (comboBox2.SelectedItem.ToString() == "UberEats")
						{
							for (int i = 0; i< 1000; i++)
							{
								if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
								{

                                    index = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[index].Cells[0].Value = Itm_Code.Text; //Item Code
									dataGridView1.Rows[index].Cells[1].Value = comboBox4.Text; // Item Name
									dataGridView1.Rows[index].Cells[2].Value = textBox2.Text; //Quantity
									dataGridView1.Rows[index].Cells[3].Value = Convert.ToDouble(textBox2.Text) * Price_uber[i];



									Itm_sel.Add(comboBox4.Text);
									Quan.Add(Convert.ToInt32(textBox2.Text));
									Price_sel.Add(Convert.ToDouble(textBox2.Text) * Price_uber[i]);

									totl += (Convert.ToDouble(textBox2.Text) * Price_uber[i]) + (Convert.ToDouble(textBox2.Text) * Price_uber[i] * 0.05);
									//totl += 0.12 * totl;
									break;

								}

							}
						}

						if (comboBox2.SelectedItem.ToString() == "FoodPanda")
						{
							for (int i = 0; i< 1000; i++)
							{
								if (Item_Code_load[i] == Convert.ToInt32(Itm_Code.Text))
								{

                                    index = dataGridView1.Rows.Add();
                                    dataGridView1.Rows[index].Cells[0].Value = Itm_Code.Text; //Item Code
									dataGridView1.Rows[index].Cells[1].Value = comboBox4.Text; // Item Name
									dataGridView1.Rows[index].Cells[2].Value = textBox2.Text; //Quantity
									dataGridView1.Rows[index].Cells[3].Value = Convert.ToDouble(textBox2.Text) * Price_fp[i];

//Item_Sel[index] = Convert.ToString(comboBox4.Text);
//Qty_Sel[index] = Convert.ToInt32(textBox2.Text);
//Price_print[index] = Convert.ToDouble(textBox2.Text) * Price_fp[i];

									Itm_sel.Add(comboBox4.Text);
									Quan.Add(Convert.ToInt32(textBox2.Text));
									Price_sel.Add(Convert.ToDouble(textBox2.Text) * Price_fp[i]);

									totl += (Convert.ToDouble(textBox2.Text) * Price_fp[i]) + (Convert.ToDouble(textBox2.Text) * Price_fp[i] * 0.05);
									//totl += 0.12 * totl;
									break;

								}

							}
						}

					}
					catch (Exception ex)
					{

					}
					Amount.Text = Convert.ToString(totl);
				}
				else
				{
					if (index >= 45)
					{
						MessageBox.Show("Maximum Item per Bill Reached");
					}
				}
			}
            
			Itm_Code.ResetText();
			comboBox4.ResetText();
			textBox2.ResetText();
			

		}
	}
}

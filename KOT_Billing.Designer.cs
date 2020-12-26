namespace Billing_Client_V1
{
	partial class KOT_Billing
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KOT_Billing));
			this.label1 = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.comboBox3 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.OrderNo = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.Add = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.Itm_Code = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Item_Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.label11 = new System.Windows.Forms.Label();
			this.Amount = new System.Windows.Forms.Label();
			this.refresh = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.transacDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.masterDataSet5 = new Billing_Client_V1.masterDataSet5();
			this.label10 = new System.Windows.Forms.Label();
			this.Print = new System.Windows.Forms.Button();
			this.Delete = new System.Windows.Forms.Button();
			this.userid = new System.Windows.Forms.Label();
			this.transac_DetailsTableAdapter = new Billing_Client_V1.masterDataSet5TableAdapters.Transac_DetailsTableAdapter();
			this.reprint = new System.Windows.Forms.Button();
			this.Button_Logout = new System.Windows.Forms.Button();
			this.Button_Purchase = new System.Windows.Forms.Button();
			this.button_Salary = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transacDetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.masterDataSet5)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(219, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kitchen Order Token";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.splitContainer1.Location = new System.Drawing.Point(31, 60);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.comboBox3);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox2);
			this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.OrderNo);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.comboBox4);
			this.splitContainer1.Panel2.Controls.Add(this.Add);
			this.splitContainer1.Panel2.Controls.Add(this.textBox2);
			this.splitContainer1.Panel2.Controls.Add(this.Itm_Code);
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
			this.splitContainer1.Panel2.Controls.Add(this.label9);
			this.splitContainer1.Panel2.Controls.Add(this.label8);
			this.splitContainer1.Panel2.Controls.Add(this.label7);
			this.splitContainer1.Size = new System.Drawing.Size(637, 494);
			this.splitContainer1.SplitterDistance = 107;
			this.splitContainer1.TabIndex = 1;
			this.splitContainer1.TabStop = false;
			// 
			// comboBox3
			// 
			this.comboBox3.FormattingEnabled = true;
			this.comboBox3.Items.AddRange(new object[] {
            "Cash",
            "Card",
            "UPI"});
			this.comboBox3.Location = new System.Drawing.Point(452, 45);
			this.comboBox3.Name = "comboBox3";
			this.comboBox3.Size = new System.Drawing.Size(108, 21);
			this.comboBox3.TabIndex = 0;
			this.comboBox3.TabStop = false;
			this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Items.AddRange(new object[] {
            "DineIn",
            "TakeAway",
            "Swiggy",
            "Zomato",
            "FoodPanda",
            "UberEats",
            "Delivery"});
			this.comboBox2.Location = new System.Drawing.Point(182, 51);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(108, 21);
			this.comboBox2.TabIndex = 1;
			this.comboBox2.TabStop = false;
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
			this.comboBox1.Location = new System.Drawing.Point(458, 9);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(58, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.TabStop = false;
			this.comboBox1.Text = "1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(74, 7);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "Order No.";
			// 
			// OrderNo
			// 
			this.OrderNo.AutoSize = true;
			this.OrderNo.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OrderNo.ForeColor = System.Drawing.Color.Green;
			this.OrderNo.Location = new System.Drawing.Point(170, 5);
			this.OrderNo.Name = "OrderNo";
			this.OrderNo.Size = new System.Drawing.Size(0, 27);
			this.OrderNo.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(322, 49);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(124, 17);
			this.label6.TabIndex = 0;
			this.label6.Text = "Payment Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(74, 51);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 17);
			this.label4.TabIndex = 0;
			this.label4.Text = "Order Type:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(362, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(84, 17);
			this.label5.TabIndex = 0;
			this.label5.Text = "Table No.";
			// 
			// comboBox4
			// 
			this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(195, 7);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(235, 21);
			this.comboBox4.TabIndex = 0;
			this.comboBox4.TabStop = false;
			this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
			// 
			// Add
			// 
			this.Add.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Add.Location = new System.Drawing.Point(574, 5);
			this.Add.Name = "Add";
			this.Add.Size = new System.Drawing.Size(49, 28);
			this.Add.TabIndex = 0;
			this.Add.TabStop = false;
			this.Add.Text = "Add";
			this.Add.UseVisualStyleBackColor = true;
			this.Add.Click += new System.EventHandler(this.Add_Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(501, 8);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(59, 21);
			this.textBox2.TabIndex = 4;
			this.textBox2.TabStopChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// Itm_Code
			// 
			this.Itm_Code.AcceptsTab = true;
			this.Itm_Code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Itm_Code.Location = new System.Drawing.Point(96, 5);
			this.Itm_Code.Name = "Itm_Code";
			this.Itm_Code.Size = new System.Drawing.Size(44, 21);
			this.Itm_Code.TabIndex = 2;
			this.Itm_Code.TextChanged += new System.EventHandler(this.Itm_Code_TextChanged);
			this.Itm_Code.Enter += new System.EventHandler(this.selectall);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Code,
            this.Item_Name,
            this.Qty,
            this.Price});
			this.dataGridView1.Location = new System.Drawing.Point(3, 39);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(634, 341);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.TabStop = false;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Item_Code
			// 
			this.Item_Code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Item_Code.HeaderText = "Code";
			this.Item_Code.Name = "Item_Code";
			this.Item_Code.ReadOnly = true;
			this.Item_Code.Width = 57;
			// 
			// Item_Name
			// 
			this.Item_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Item_Name.HeaderText = "Item Name";
			this.Item_Name.Name = "Item_Name";
			this.Item_Name.ReadOnly = true;
			// 
			// Qty
			// 
			this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Qty.HeaderText = "Quantity";
			this.Qty.Name = "Qty";
			this.Qty.ReadOnly = true;
			this.Qty.Width = 71;
			// 
			// Price
			// 
			this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.Price.HeaderText = "Price   ";
			this.Price.Name = "Price";
			this.Price.ReadOnly = true;
			this.Price.Width = 65;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(458, 11);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(40, 15);
			this.label9.TabIndex = 0;
			this.label9.Text = "Qty :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(146, 10);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(50, 15);
			this.label8.TabIndex = 0;
			this.label8.Text = "Name :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(11, 10);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(79, 15);
			this.label7.TabIndex = 0;
			this.label7.Text = "Item Code :";
			// 
			// splitContainer2
			// 
			this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer2.Location = new System.Drawing.Point(727, 60);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.label11);
			this.splitContainer2.Panel1.Controls.Add(this.Amount);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.AutoScroll = true;
			this.splitContainer2.Panel2.Controls.Add(this.refresh);
			this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
			this.splitContainer2.Panel2.Controls.Add(this.label10);
			this.splitContainer2.Size = new System.Drawing.Size(531, 497);
			this.splitContainer2.SplitterDistance = 107;
			this.splitContainer2.TabIndex = 2;
			this.splitContainer2.TabStop = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Lucida Fax", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(106, 35);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(245, 33);
			this.label11.TabIndex = 0;
			this.label11.Text = "Total Amount :";
			// 
			// Amount
			// 
			this.Amount.AutoSize = true;
			this.Amount.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Amount.ForeColor = System.Drawing.Color.Red;
			this.Amount.Location = new System.Drawing.Point(357, 33);
			this.Amount.Name = "Amount";
			this.Amount.Size = new System.Drawing.Size(38, 38);
			this.Amount.TabIndex = 0;
			this.Amount.Text = "0";
			// 
			// refresh
			// 
			this.refresh.BackColor = System.Drawing.Color.AliceBlue;
			this.refresh.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.refresh.Location = new System.Drawing.Point(441, 8);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(75, 23);
			this.refresh.TabIndex = 1;
			this.refresh.TabStop = false;
			this.refresh.Text = "Refresh";
			this.refresh.UseVisualStyleBackColor = false;
			this.refresh.Click += new System.EventHandler(this.refresh_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AutoGenerateColumns = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.statusDataGridViewTextBoxColumn});
			this.dataGridView2.DataSource = this.transacDetailsBindingSource;
			this.dataGridView2.Location = new System.Drawing.Point(4, 40);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(524, 343);
			this.dataGridView2.TabIndex = 0;
			this.dataGridView2.TabStop = false;
			this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			this.dataGridView2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderNumber";
			this.dataGridViewTextBoxColumn1.HeaderText = "OrderNumber";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Total";
			this.dataGridViewTextBoxColumn2.HeaderText = "Total";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Date";
			this.dataGridViewTextBoxColumn3.HeaderText = "Date";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "DeliveryMode";
			this.dataGridViewTextBoxColumn4.HeaderText = "DeliveryMode";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "PaymentMode";
			this.dataGridViewTextBoxColumn5.HeaderText = "PaymentMode";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// transacDetailsBindingSource
			// 
			this.transacDetailsBindingSource.DataMember = "Transac_Details";
			this.transacDetailsBindingSource.DataSource = this.masterDataSet5;
			// 
			// masterDataSet5
			// 
			this.masterDataSet5.DataSetName = "masterDataSet5";
			this.masterDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(3, 10);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(130, 17);
			this.label10.TabIndex = 0;
			this.label10.Text = "Recent Orders :";
			// 
			// Print
			// 
			this.Print.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Print.BackColor = System.Drawing.Color.MintCream;
			this.Print.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Print.Location = new System.Drawing.Point(483, 619);
			this.Print.Name = "Print";
			this.Print.Size = new System.Drawing.Size(93, 34);
			this.Print.TabIndex = 3;
			this.Print.TabStop = false;
			this.Print.Text = "Print";
			this.Print.UseVisualStyleBackColor = false;
			this.Print.Click += new System.EventHandler(this.Print_Click);
			// 
			// Delete
			// 
			this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Delete.BackColor = System.Drawing.Color.MintCream;
			this.Delete.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Delete.Location = new System.Drawing.Point(356, 619);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(93, 34);
			this.Delete.TabIndex = 4;
			this.Delete.TabStop = false;
			this.Delete.Text = "Delete";
			this.Delete.UseVisualStyleBackColor = false;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// userid
			// 
			this.userid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userid.AutoSize = true;
			this.userid.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userid.Location = new System.Drawing.Point(1105, 18);
			this.userid.Name = "userid";
			this.userid.Size = new System.Drawing.Size(0, 18);
			this.userid.TabIndex = 5;
			// 
			// transac_DetailsTableAdapter
			// 
			this.transac_DetailsTableAdapter.ClearBeforeFill = true;
			// 
			// reprint
			// 
			this.reprint.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.reprint.BackColor = System.Drawing.Color.MintCream;
			this.reprint.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.reprint.Location = new System.Drawing.Point(879, 619);
			this.reprint.Name = "reprint";
			this.reprint.Size = new System.Drawing.Size(93, 34);
			this.reprint.TabIndex = 0;
			this.reprint.TabStop = false;
			this.reprint.Text = "Reprint";
			this.reprint.UseVisualStyleBackColor = false;
			this.reprint.Click += new System.EventHandler(this.reprint_Click);
			// 
			// Button_Logout
			// 
			this.Button_Logout.BackColor = System.Drawing.Color.MintCream;
			this.Button_Logout.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button_Logout.Location = new System.Drawing.Point(228, 619);
			this.Button_Logout.Name = "Button_Logout";
			this.Button_Logout.Size = new System.Drawing.Size(93, 34);
			this.Button_Logout.TabIndex = 6;
			this.Button_Logout.TabStop = false;
			this.Button_Logout.Text = "Logout";
			this.Button_Logout.UseVisualStyleBackColor = false;
			this.Button_Logout.Click += new System.EventHandler(this.Button_Logout_Click);
			// 
			// Button_Purchase
			// 
			this.Button_Purchase.BackColor = System.Drawing.Color.MintCream;
			this.Button_Purchase.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button_Purchase.Location = new System.Drawing.Point(1012, 619);
			this.Button_Purchase.Name = "Button_Purchase";
			this.Button_Purchase.Size = new System.Drawing.Size(93, 34);
			this.Button_Purchase.TabIndex = 6;
			this.Button_Purchase.TabStop = false;
			this.Button_Purchase.Text = "Purchase";
			this.Button_Purchase.UseVisualStyleBackColor = false;
			this.Button_Purchase.Click += new System.EventHandler(this.Button_Purchase_Click);
			// 
			// button_Salary
			// 
			this.button_Salary.BackColor = System.Drawing.Color.MintCream;
			this.button_Salary.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Salary.Location = new System.Drawing.Point(1138, 619);
			this.button_Salary.Name = "button_Salary";
			this.button_Salary.Size = new System.Drawing.Size(93, 34);
			this.button_Salary.TabIndex = 7;
			this.button_Salary.Text = "Salary";
			this.button_Salary.UseVisualStyleBackColor = false;
			this.button_Salary.Click += new System.EventHandler(this.button_Salary_Click);
			// 
			// KOT_Billing
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1350, 729);
			this.Controls.Add(this.button_Salary);
			this.Controls.Add(this.Button_Purchase);
			this.Controls.Add(this.Button_Logout);
			this.Controls.Add(this.reprint);
			this.Controls.Add(this.userid);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.Print);
			this.Controls.Add(this.splitContainer2);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KOT_Billing";
			this.Text = "KOT_Billing";
			this.Load += new System.EventHandler(this.KOT_Billing_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel1.PerformLayout();
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transacDetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.masterDataSet5)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label OrderNo;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.ComboBox comboBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ComboBox comboBox4;
		private System.Windows.Forms.Button Add;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox Itm_Code;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Item_Code;
		private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Price;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label Amount;
		//private Transac_HistoryTableAdapters.Transac_DetailsTableAdapter transac_DetailsTableAdapter;
		private System.Windows.Forms.Button Print;
		private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn deliveryModeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn paymentModeDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button Delete;
		private System.Windows.Forms.Button refresh;
		private masterDataSet5 masterDataSet5;
		private System.Windows.Forms.BindingSource transacDetailsBindingSource;
		private masterDataSet5TableAdapters.Transac_DetailsTableAdapter transac_DetailsTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label userid;
		private System.Windows.Forms.Button reprint;
		private System.Windows.Forms.Button Button_Logout;
		private System.Windows.Forms.Button Button_Purchase;
		private System.Windows.Forms.Button button_Salary;
	}
}
namespace Billing_Client_V1
{
	partial class Employee_Salary
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee_Salary));
			this.label1 = new System.Windows.Forms.Label();
			this.Lbl_Emp_name = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Text_Emp_name = new System.Windows.Forms.TextBox();
			this.Text_Salary = new System.Windows.Forms.TextBox();
			this.Text_Other_Details = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Button_Cancel = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.pandiyanDataSet_Salary = new Billing_Client_V1.PandiyanDataSet_Salary();
			this.empSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.emp_SalaryTableAdapter = new Billing_Client_V1.PandiyanDataSet_SalaryTableAdapters.Emp_SalaryTableAdapter();
			this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.empNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.salTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.otherDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cancelReasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pandiyanDataSet_Salary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.empSalaryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Fax", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Salary :";
			// 
			// Lbl_Emp_name
			// 
			this.Lbl_Emp_name.AutoSize = true;
			this.Lbl_Emp_name.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbl_Emp_name.Location = new System.Drawing.Point(20, 95);
			this.Lbl_Emp_name.Name = "Lbl_Emp_name";
			this.Lbl_Emp_name.Size = new System.Drawing.Size(244, 32);
			this.Lbl_Emp_name.TabIndex = 1;
			this.Lbl_Emp_name.Text = "Employee Name";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(527, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(102, 32);
			this.label2.TabIndex = 2;
			this.label2.Text = "Salary";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(863, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(208, 32);
			this.label3.TabIndex = 3;
			this.label3.Text = "Other Details";
			// 
			// Text_Emp_name
			// 
			this.Text_Emp_name.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Text_Emp_name.Location = new System.Drawing.Point(26, 142);
			this.Text_Emp_name.Name = "Text_Emp_name";
			this.Text_Emp_name.Size = new System.Drawing.Size(336, 32);
			this.Text_Emp_name.TabIndex = 4;
			// 
			// Text_Salary
			// 
			this.Text_Salary.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Text_Salary.Location = new System.Drawing.Point(476, 142);
			this.Text_Salary.Name = "Text_Salary";
			this.Text_Salary.Size = new System.Drawing.Size(200, 32);
			this.Text_Salary.TabIndex = 5;
			// 
			// Text_Other_Details
			// 
			this.Text_Other_Details.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Text_Other_Details.Location = new System.Drawing.Point(791, 142);
			this.Text_Other_Details.Name = "Text_Other_Details";
			this.Text_Other_Details.Size = new System.Drawing.Size(343, 32);
			this.Text_Other_Details.TabIndex = 6;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MintCream;
			this.button1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(1184, 142);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(108, 32);
			this.button1.TabIndex = 7;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNoDataGridViewTextBoxColumn,
            this.empNameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.salDateDataGridViewTextBoxColumn,
            this.salTimeDataGridViewTextBoxColumn,
            this.otherDetailsDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.cancelReasonDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.empSalaryBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(31, 220);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1261, 396);
			this.dataGridView1.TabIndex = 8;
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// Button_Cancel
			// 
			this.Button_Cancel.BackColor = System.Drawing.Color.MintCream;
			this.Button_Cancel.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Button_Cancel.Location = new System.Drawing.Point(1184, 643);
			this.Button_Cancel.Name = "Button_Cancel";
			this.Button_Cancel.Size = new System.Drawing.Size(99, 37);
			this.Button_Cancel.TabIndex = 9;
			this.Button_Cancel.Text = "Cancel";
			this.Button_Cancel.UseVisualStyleBackColor = false;
			this.Button_Cancel.Click += new System.EventHandler(this.Button_Cancel_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(476, 646);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(658, 32);
			this.textBox1.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(201, 649);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(269, 24);
			this.label4.TabIndex = 11;
			this.label4.Text = "Reason For Cancelling :";
			// 
			// pandiyanDataSet_Salary
			// 
			this.pandiyanDataSet_Salary.DataSetName = "PandiyanDataSet_Salary";
			this.pandiyanDataSet_Salary.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// empSalaryBindingSource
			// 
			this.empSalaryBindingSource.DataMember = "Emp_Salary";
			this.empSalaryBindingSource.DataSource = this.pandiyanDataSet_Salary;
			// 
			// emp_SalaryTableAdapter
			// 
			this.emp_SalaryTableAdapter.ClearBeforeFill = true;
			// 
			// sNoDataGridViewTextBoxColumn
			// 
			this.sNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.sNoDataGridViewTextBoxColumn.DataPropertyName = "S_No";
			this.sNoDataGridViewTextBoxColumn.HeaderText = "S/No  ";
			this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
			this.sNoDataGridViewTextBoxColumn.Width = 64;
			// 
			// empNameDataGridViewTextBoxColumn
			// 
			this.empNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.empNameDataGridViewTextBoxColumn.DataPropertyName = "Emp_Name";
			this.empNameDataGridViewTextBoxColumn.HeaderText = "Name";
			this.empNameDataGridViewTextBoxColumn.Name = "empNameDataGridViewTextBoxColumn";
			// 
			// salaryDataGridViewTextBoxColumn
			// 
			this.salaryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
			this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary        ";
			this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
			this.salaryDataGridViewTextBoxColumn.Width = 85;
			// 
			// salDateDataGridViewTextBoxColumn
			// 
			this.salDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.salDateDataGridViewTextBoxColumn.DataPropertyName = "Sal_Date";
			this.salDateDataGridViewTextBoxColumn.HeaderText = "Date        ";
			this.salDateDataGridViewTextBoxColumn.Name = "salDateDataGridViewTextBoxColumn";
			this.salDateDataGridViewTextBoxColumn.Width = 79;
			// 
			// salTimeDataGridViewTextBoxColumn
			// 
			this.salTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.salTimeDataGridViewTextBoxColumn.DataPropertyName = "Sal_Time";
			this.salTimeDataGridViewTextBoxColumn.HeaderText = "Time        ";
			this.salTimeDataGridViewTextBoxColumn.Name = "salTimeDataGridViewTextBoxColumn";
			this.salTimeDataGridViewTextBoxColumn.Width = 79;
			// 
			// otherDetailsDataGridViewTextBoxColumn
			// 
			this.otherDetailsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.otherDetailsDataGridViewTextBoxColumn.DataPropertyName = "Other_Details";
			this.otherDetailsDataGridViewTextBoxColumn.HeaderText = "Details";
			this.otherDetailsDataGridViewTextBoxColumn.Name = "otherDetailsDataGridViewTextBoxColumn";
			// 
			// statusDataGridViewTextBoxColumn
			// 
			this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
			this.statusDataGridViewTextBoxColumn.HeaderText = "Status        ";
			this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
			this.statusDataGridViewTextBoxColumn.Width = 86;
			// 
			// cancelReasonDataGridViewTextBoxColumn
			// 
			this.cancelReasonDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.cancelReasonDataGridViewTextBoxColumn.DataPropertyName = "Cancel_Reason";
			this.cancelReasonDataGridViewTextBoxColumn.HeaderText = "Cancel Reason";
			this.cancelReasonDataGridViewTextBoxColumn.Name = "cancelReasonDataGridViewTextBoxColumn";
			// 
			// Employee_Salary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(1350, 729);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.Button_Cancel);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Text_Other_Details);
			this.Controls.Add(this.Text_Salary);
			this.Controls.Add(this.Text_Emp_name);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Lbl_Emp_name);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Employee_Salary";
			this.Text = "Employee_Salary";
			this.Load += new System.EventHandler(this.Employee_Salary_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pandiyanDataSet_Salary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.empSalaryBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Lbl_Emp_name;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Text_Emp_name;
		private System.Windows.Forms.TextBox Text_Salary;
		private System.Windows.Forms.TextBox Text_Other_Details;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button Button_Cancel;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label4;
		private PandiyanDataSet_Salary pandiyanDataSet_Salary;
		private System.Windows.Forms.BindingSource empSalaryBindingSource;
		private PandiyanDataSet_SalaryTableAdapters.Emp_SalaryTableAdapter emp_SalaryTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn empNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn salTimeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn otherDetailsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn cancelReasonDataGridViewTextBoxColumn;
	}
}
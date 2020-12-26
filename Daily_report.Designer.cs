namespace Billing_Client_V1
{
	partial class Daily_report
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Daily_report));
			this.Transac_DetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Daily_rprt = new Billing_Client_V1.Daily_rprt();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.Transac_DetailsTableAdapter = new Billing_Client_V1.Daily_rprtTableAdapters.Transac_DetailsTableAdapter();
			this.label2 = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Print = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Transac_DetailsBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Daily_rprt)).BeginInit();
			this.SuspendLayout();
			// 
			// Transac_DetailsBindingSource
			// 
			this.Transac_DetailsBindingSource.DataMember = "Transac_Details";
			this.Transac_DetailsBindingSource.DataSource = this.Daily_rprt;
			// 
			// Daily_rprt
			// 
			this.Daily_rprt.DataSetName = "Daily_rprt";
			this.Daily_rprt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DailyReport";
			reportDataSource1.Value = this.Transac_DetailsBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "Billing_Client_V1.Daily_report.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 78);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(981, 415);
			this.reportViewer1.TabIndex = 0;
			// 
			// Transac_DetailsTableAdapter
			// 
			this.Transac_DetailsTableAdapter.ClearBeforeFill = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Fax", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(272, 40);
			this.label2.TabIndex = 3;
			this.label2.Text = "Daily Report :";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(463, 34);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(382, 32);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 24);
			this.label3.TabIndex = 5;
			this.label3.Text = "Date :";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.MintCream;
			this.button1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(688, 31);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 28);
			this.button1.TabIndex = 6;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Print
			// 
			this.Print.BackColor = System.Drawing.Color.MintCream;
			this.Print.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Print.Location = new System.Drawing.Point(778, 31);
			this.Print.Name = "Print";
			this.Print.Size = new System.Drawing.Size(75, 28);
			this.Print.TabIndex = 7;
			this.Print.Text = "Print";
			this.Print.UseVisualStyleBackColor = false;
			this.Print.Click += new System.EventHandler(this.Print_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(562, 517);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 22);
			this.label1.TabIndex = 8;
			this.label1.Text = "Total :";
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.textBox1.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.ForeColor = System.Drawing.Color.Blue;
			this.textBox1.Location = new System.Drawing.Point(642, 513);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(165, 32);
			this.textBox1.TabIndex = 9;
			// 
			// Daily_report
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Print);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.reportViewer1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Daily_report";
			this.Text = "Daily_report";
			this.Load += new System.EventHandler(this.Daily_report_Load);
			((System.ComponentModel.ISupportInitialize)(this.Transac_DetailsBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Daily_rprt)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource Transac_DetailsBindingSource;
		private Daily_rprt Daily_rprt;
		private Daily_rprtTableAdapters.Transac_DetailsTableAdapter Transac_DetailsTableAdapter;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button Print;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
	}
}
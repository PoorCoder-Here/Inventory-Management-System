namespace Billing_Client_V1
{
	partial class Inventory
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
			this.StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.PandiyanDataSet1 = new Billing_Client_V1.PandiyanDataSet1();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.StockTableAdapter = new Billing_Client_V1.PandiyanDataSet1TableAdapters.StockTableAdapter();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PandiyanDataSet1)).BeginInit();
			this.SuspendLayout();
			// 
			// StockBindingSource
			// 
			this.StockBindingSource.DataMember = "Stock";
			this.StockBindingSource.DataSource = this.PandiyanDataSet1;
			// 
			// PandiyanDataSet1
			// 
			this.PandiyanDataSet1.DataSetName = "PandiyanDataSet1";
			this.PandiyanDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			reportDataSource1.Name = "DataSet1_inv";
			reportDataSource1.Value = this.StockBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "Billing_Client_V1.Report2.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 66);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(979, 403);
			this.reportViewer1.TabIndex = 0;
			// 
			// StockTableAdapter
			// 
			this.StockTableAdapter.ClearBeforeFill = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Fax", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "Inventory Report";
			// 
			// Inventory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "Inventory";
			this.Text = "Inventory";
			this.Load += new System.EventHandler(this.Inventory_Load);
			((System.ComponentModel.ISupportInitialize)(this.StockBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PandiyanDataSet1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource StockBindingSource;
		private PandiyanDataSet1 PandiyanDataSet1;
		private PandiyanDataSet1TableAdapters.StockTableAdapter StockTableAdapter;
		private System.Windows.Forms.Label label1;
	}
}
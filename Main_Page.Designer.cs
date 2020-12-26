namespace Billing_Client_V1
{
	partial class Main_Page
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Page));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip_Logout = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStrip_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kOTBillingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cancelledInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.billHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.listingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productListingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salesReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dailySalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.itemwiseSalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.purchaseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.salaryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.profileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.markAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.userid = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.masterToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.listingReportToolStripMenuItem,
            this.salesReportToolStripMenuItem,
            this.administrationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.menuStrip1.Size = new System.Drawing.Size(1264, 26);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Logout,
            this.exitToolStrip_Exit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// toolStrip_Logout
			// 
			this.toolStrip_Logout.Image = global::Billing_Client_V1.Properties.Resources.Logout;
			this.toolStrip_Logout.Name = "toolStrip_Logout";
			this.toolStrip_Logout.Size = new System.Drawing.Size(134, 22);
			this.toolStrip_Logout.Text = "Logout";
			this.toolStrip_Logout.Click += new System.EventHandler(this.toolStrip_Logout_Click);
			// 
			// exitToolStrip_Exit
			// 
			this.exitToolStrip_Exit.Image = global::Billing_Client_V1.Properties.Resources.EXIT;
			this.exitToolStrip_Exit.Name = "exitToolStrip_Exit";
			this.exitToolStrip_Exit.Size = new System.Drawing.Size(134, 22);
			this.exitToolStrip_Exit.Text = "Exit";
			this.exitToolStrip_Exit.Click += new System.EventHandler(this.exitToolStrip_Exit_Click);
			// 
			// masterToolStripMenuItem
			// 
			this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.employeeToolStripMenuItem});
			this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
			this.masterToolStripMenuItem.Size = new System.Drawing.Size(78, 22);
			this.masterToolStripMenuItem.Text = "Master";
			// 
			// productToolStripMenuItem
			// 
			this.productToolStripMenuItem.Image = global::Billing_Client_V1.Properties.Resources.Product_1;
			this.productToolStripMenuItem.Name = "productToolStripMenuItem";
			this.productToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.productToolStripMenuItem.Text = "Product";
			this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
			// 
			// employeeToolStripMenuItem
			// 
			this.employeeToolStripMenuItem.Image = global::Billing_Client_V1.Properties.Resources.Employee_1;
			this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
			this.employeeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
			this.employeeToolStripMenuItem.Text = "Employee Salary";
			this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
			// 
			// salesToolStripMenuItem
			// 
			this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kOTBillingToolStripMenuItem,
            this.cancelledInvoiceToolStripMenuItem,
            this.billHistoryToolStripMenuItem,
            this.purchaseToolStripMenuItem});
			this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
			this.salesToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
			this.salesToolStripMenuItem.Text = "Sales";
			// 
			// kOTBillingToolStripMenuItem
			// 
			this.kOTBillingToolStripMenuItem.Image = global::Billing_Client_V1.Properties.Resources.images;
			this.kOTBillingToolStripMenuItem.Name = "kOTBillingToolStripMenuItem";
			this.kOTBillingToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.kOTBillingToolStripMenuItem.Text = "KOT Billing";
			this.kOTBillingToolStripMenuItem.Click += new System.EventHandler(this.kOTBillingToolStripMenuItem_Click);
			// 
			// cancelledInvoiceToolStripMenuItem
			// 
			this.cancelledInvoiceToolStripMenuItem.Name = "cancelledInvoiceToolStripMenuItem";
			this.cancelledInvoiceToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.cancelledInvoiceToolStripMenuItem.Text = "Cancelled Invoice";
			this.cancelledInvoiceToolStripMenuItem.Click += new System.EventHandler(this.cancelledInvoiceToolStripMenuItem_Click);
			// 
			// billHistoryToolStripMenuItem
			// 
			this.billHistoryToolStripMenuItem.Name = "billHistoryToolStripMenuItem";
			this.billHistoryToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.billHistoryToolStripMenuItem.Text = "Bill History";
			this.billHistoryToolStripMenuItem.Click += new System.EventHandler(this.billHistoryToolStripMenuItem_Click);
			// 
			// purchaseToolStripMenuItem
			// 
			this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
			this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
			this.purchaseToolStripMenuItem.Text = "Purchase";
			this.purchaseToolStripMenuItem.Click += new System.EventHandler(this.purchaseToolStripMenuItem_Click);
			// 
			// listingReportToolStripMenuItem
			// 
			this.listingReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productListingToolStripMenuItem});
			this.listingReportToolStripMenuItem.Name = "listingReportToolStripMenuItem";
			this.listingReportToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.listingReportToolStripMenuItem.Text = "Listing Report";
			// 
			// productListingToolStripMenuItem
			// 
			this.productListingToolStripMenuItem.Name = "productListingToolStripMenuItem";
			this.productListingToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
			this.productListingToolStripMenuItem.Text = "Product Listing";
			this.productListingToolStripMenuItem.Click += new System.EventHandler(this.productListingToolStripMenuItem_Click);
			// 
			// salesReportToolStripMenuItem
			// 
			this.salesReportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailySalesToolStripMenuItem,
            this.itemwiseSalesToolStripMenuItem,
            this.purchaseToolStripMenuItem1,
            this.salaryReportToolStripMenuItem});
			this.salesReportToolStripMenuItem.Name = "salesReportToolStripMenuItem";
			this.salesReportToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.salesReportToolStripMenuItem.Text = "Sales Report";
			// 
			// dailySalesToolStripMenuItem
			// 
			this.dailySalesToolStripMenuItem.Name = "dailySalesToolStripMenuItem";
			this.dailySalesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.dailySalesToolStripMenuItem.Text = "Daily Sales";
			this.dailySalesToolStripMenuItem.Click += new System.EventHandler(this.dailySalesToolStripMenuItem_Click);
			// 
			// itemwiseSalesToolStripMenuItem
			// 
			this.itemwiseSalesToolStripMenuItem.Name = "itemwiseSalesToolStripMenuItem";
			this.itemwiseSalesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.itemwiseSalesToolStripMenuItem.Text = "Itemwise Sales";
			this.itemwiseSalesToolStripMenuItem.Click += new System.EventHandler(this.itemwiseSalesToolStripMenuItem_Click);
			// 
			// purchaseToolStripMenuItem1
			// 
			this.purchaseToolStripMenuItem1.Name = "purchaseToolStripMenuItem1";
			this.purchaseToolStripMenuItem1.Size = new System.Drawing.Size(215, 22);
			this.purchaseToolStripMenuItem1.Text = "Purchase Report";
			this.purchaseToolStripMenuItem1.Click += new System.EventHandler(this.purchaseToolStripMenuItem1_Click);
			// 
			// salaryReportToolStripMenuItem
			// 
			this.salaryReportToolStripMenuItem.Name = "salaryReportToolStripMenuItem";
			this.salaryReportToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
			this.salaryReportToolStripMenuItem.Text = "Salary Report";
			this.salaryReportToolStripMenuItem.Click += new System.EventHandler(this.salaryReportToolStripMenuItem_Click);
			// 
			// administrationToolStripMenuItem
			// 
			this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem,
            this.addUserToolStripMenuItem,
            this.markAttendanceToolStripMenuItem});
			this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
			this.administrationToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
			this.administrationToolStripMenuItem.Text = "Administration";
			// 
			// profileToolStripMenuItem
			// 
			this.profileToolStripMenuItem.Name = "profileToolStripMenuItem";
			this.profileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.profileToolStripMenuItem.Text = "Profile";
			this.profileToolStripMenuItem.Click += new System.EventHandler(this.profileToolStripMenuItem_Click);
			// 
			// addUserToolStripMenuItem
			// 
			this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
			this.addUserToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.addUserToolStripMenuItem.Text = "Add Employee";
			this.addUserToolStripMenuItem.Click += new System.EventHandler(this.addUserToolStripMenuItem_Click);
			// 
			// markAttendanceToolStripMenuItem
			// 
			this.markAttendanceToolStripMenuItem.Name = "markAttendanceToolStripMenuItem";
			this.markAttendanceToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
			this.markAttendanceToolStripMenuItem.Text = "Mark Attendance";
			this.markAttendanceToolStripMenuItem.Click += new System.EventHandler(this.markAttendanceToolStripMenuItem_Click);
			// 
			// userid
			// 
			this.userid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userid.AutoSize = true;
			this.userid.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.userid.Location = new System.Drawing.Point(1129, 9);
			this.userid.Name = "userid";
			this.userid.Size = new System.Drawing.Size(0, 18);
			this.userid.TabIndex = 1;
			// 
			// Main_Page
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.BackgroundImage = global::Billing_Client_V1.Properties.Resources.bg___Copy;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1264, 761);
			this.Controls.Add(this.userid);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Main_Page";
			this.Text = "Billing";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Main_Page_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStrip_Logout;
		private System.Windows.Forms.ToolStripMenuItem exitToolStrip_Exit;
		private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kOTBillingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cancelledInvoiceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem billHistoryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem listingReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productListingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salesReportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dailySalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem itemwiseSalesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem markAttendanceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
		private System.Windows.Forms.Label userid;
		private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem salaryReportToolStripMenuItem;
	}
}


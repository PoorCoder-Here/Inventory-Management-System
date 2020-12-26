namespace Billing_Client_V1
{
	partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.pwd = new System.Windows.Forms.TextBox();
			this.User_name = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(547, 299);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 22);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(559, 343);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 22);
			this.label2.TabIndex = 0;
			this.label2.Text = "Password";
			// 
			// pwd
			// 
			this.pwd.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pwd.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pwd.Location = new System.Drawing.Point(689, 343);
			this.pwd.Name = "pwd";
			this.pwd.PasswordChar = '*';
			this.pwd.Size = new System.Drawing.Size(174, 26);
			this.pwd.TabIndex = 1;
			// 
			// User_name
			// 
			this.User_name.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.User_name.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.User_name.Location = new System.Drawing.Point(689, 299);
			this.User_name.Name = "User_name";
			this.User_name.Size = new System.Drawing.Size(174, 26);
			this.User_name.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.Font = new System.Drawing.Font("Lucida Fax", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(650, 396);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 25);
			this.button1.TabIndex = 2;
			this.button1.Text = "SignIn";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.AcceptButton = this.button1;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Billing_Client_V1.Properties.Resources.bg___Copy;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1264, 761);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.User_name);
			this.Controls.Add(this.pwd);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Login";
			this.Text = "Welcome";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox pwd;
		private System.Windows.Forms.TextBox User_name;
		private System.Windows.Forms.Button button1;
	}
}
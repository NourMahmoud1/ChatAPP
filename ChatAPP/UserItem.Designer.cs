namespace ChatAPP
{
	partial class UserItem
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserItem));
			this.bunifuColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
			this.lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblUserMail = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuColorTransition1
			// 
			this.bunifuColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.SpringGreen};
			this.bunifuColorTransition1.EndColor = System.Drawing.Color.White;
			this.bunifuColorTransition1.Interval = 4;
			this.bunifuColorTransition1.ProgressValue = 50;
			this.bunifuColorTransition1.StartColor = System.Drawing.Color.PaleGreen;
			// 
			// lblUserName
			// 
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblUserName.ForeColor = System.Drawing.Color.White;
			this.lblUserName.Location = new System.Drawing.Point(82, 8);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(112, 25);
			this.lblUserName.TabIndex = 3;
			this.lblUserName.Text = "User Name";
			// 
			// lblUserMail
			// 
			this.lblUserMail.BackColor = System.Drawing.Color.Transparent;
			this.lblUserMail.Font = new System.Drawing.Font("Georgia", 12F);
			this.lblUserMail.ForeColor = System.Drawing.Color.White;
			this.lblUserMail.Location = new System.Drawing.Point(82, 39);
			this.lblUserMail.Name = "lblUserMail";
			this.lblUserMail.Size = new System.Drawing.Size(34, 20);
			this.lblUserMail.TabIndex = 4;
			this.lblUserMail.Text = "Mail";
			// 
			// guna2PictureBox1
			// 
			this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
			this.guna2PictureBox1.ImageRotate = 0F;
			this.guna2PictureBox1.Location = new System.Drawing.Point(13, 8);
			this.guna2PictureBox1.Name = "guna2PictureBox1";
			this.guna2PictureBox1.Size = new System.Drawing.Size(63, 71);
			this.guna2PictureBox1.TabIndex = 5;
			this.guna2PictureBox1.TabStop = false;
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 15;
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2ColorTransition1
			// 
			this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.SpringGreen};
			this.guna2ColorTransition1.EndColor = System.Drawing.Color.White;
			this.guna2ColorTransition1.Interval = 4;
			this.guna2ColorTransition1.StartColor = System.Drawing.Color.PaleGreen;
			// 
			// UserItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
			this.Controls.Add(this.guna2PictureBox1);
			this.Controls.Add(this.lblUserMail);
			this.Controls.Add(this.lblUserName);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "UserItem";
			this.Size = new System.Drawing.Size(336, 83);
			this.Load += new System.EventHandler(this.UserItem_Load);
			this.Click += new System.EventHandler(this.UserItem_Click);
			((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2HtmlLabel lblUserMail;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblUserName;
		private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
		private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
		public Guna.UI2.WinForms.Guna2ColorTransition bunifuColorTransition1;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
	}
}

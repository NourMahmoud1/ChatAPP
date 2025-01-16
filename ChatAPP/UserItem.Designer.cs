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
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.lblUserName = new Bunifu.UI.WinForms.BunifuLabel();
			this.lblUserMail = new Bunifu.UI.WinForms.BunifuLabel();
			this.ColorTransitionDefault = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
			this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
			this.bunifuColorTransition1 = new Bunifu.UI.WinForms.BunifuColorTransition(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 25;
			this.bunifuElipse1.TargetControl = this;
			// 
			// lblUserName
			// 
			this.lblUserName.AllowParentOverrides = false;
			this.lblUserName.AutoEllipsis = false;
			this.lblUserName.CursorType = null;
			this.lblUserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblUserName.Location = new System.Drawing.Point(82, 10);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblUserName.Size = new System.Drawing.Size(109, 23);
			this.lblUserName.TabIndex = 0;
			this.lblUserName.Text = "User Name";
			this.lblUserName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblUserName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// lblUserMail
			// 
			this.lblUserMail.AllowParentOverrides = false;
			this.lblUserMail.AutoEllipsis = false;
			this.lblUserMail.CursorType = null;
			this.lblUserMail.Font = new System.Drawing.Font("Georgia", 12F);
			this.lblUserMail.Location = new System.Drawing.Point(82, 39);
			this.lblUserMail.Name = "lblUserMail";
			this.lblUserMail.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblUserMail.Size = new System.Drawing.Size(31, 18);
			this.lblUserMail.TabIndex = 1;
			this.lblUserMail.Text = "Mail";
			this.lblUserMail.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblUserMail.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// ColorTransitionDefault
			// 
			this.ColorTransitionDefault.AutoTransition = false;
			this.ColorTransitionDefault.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.Orange,
        System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(49)))), ((int)(((byte)(183)))))};
			this.ColorTransitionDefault.EndColor = System.Drawing.Color.DimGray;
			this.ColorTransitionDefault.Interval = 5;
			this.ColorTransitionDefault.ProgessValue = 0;
			this.ColorTransitionDefault.StartColor = System.Drawing.Color.IndianRed;
			this.ColorTransitionDefault.TransitionControl = this;
			// 
			// bunifuPictureBox1
			// 
			this.bunifuPictureBox1.AllowFocused = false;
			this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.bunifuPictureBox1.AutoSizeHeight = true;
			this.bunifuPictureBox1.BorderRadius = 30;
			this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
			this.bunifuPictureBox1.IsCircle = true;
			this.bunifuPictureBox1.Location = new System.Drawing.Point(16, 7);
			this.bunifuPictureBox1.Name = "bunifuPictureBox1";
			this.bunifuPictureBox1.Size = new System.Drawing.Size(60, 60);
			this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuPictureBox1.TabIndex = 2;
			this.bunifuPictureBox1.TabStop = false;
			this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
			this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
			// 
			// bunifuColorTransition1
			// 
			this.bunifuColorTransition1.AutoTransition = false;
			this.bunifuColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.SeaGreen,
        System.Drawing.Color.SpringGreen};
			this.bunifuColorTransition1.EndColor = System.Drawing.Color.White;
			this.bunifuColorTransition1.Interval = 4;
			this.bunifuColorTransition1.ProgessValue = 0;
			this.bunifuColorTransition1.StartColor = System.Drawing.Color.White;
			this.bunifuColorTransition1.TransitionControl = this;
			this.bunifuColorTransition1.ColorChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuColorTransition.ColorChangedEventArgs>(this.bunifuColorTransition1_ColorChanged);
			// 
			// UserItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
			this.Controls.Add(this.bunifuPictureBox1);
			this.Controls.Add(this.lblUserMail);
			this.Controls.Add(this.lblUserName);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "UserItem";
			this.Size = new System.Drawing.Size(336, 83);
			this.Load += new System.EventHandler(this.UserItem_Load);
			this.Click += new System.EventHandler(this.UserItem_Click);
			((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.UI.WinForms.BunifuLabel lblUserName;
		private Bunifu.UI.WinForms.BunifuLabel lblUserMail;
		private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
		private Bunifu.UI.WinForms.BunifuColorTransition bunifuColorTransition1;
		private Bunifu.UI.WinForms.BunifuColorTransition ColorTransitionDefault;
	}
}

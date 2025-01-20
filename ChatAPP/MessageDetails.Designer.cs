namespace ChatAPP
{
	partial class MessageDetails
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageDetails));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.lblUserName = new Bunifu.UI.WinForms.BunifuLabel();
			this.lblTime = new Bunifu.UI.WinForms.BunifuLabel();
			this.lblSubject = new Bunifu.UI.WinForms.BunifuLabel();
			this.btnMessageData = new Guna.UI2.WinForms.Guna2Button();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 15;
			this.bunifuElipse1.TargetControl = this;
			// 
			// lblUserName
			// 
			this.lblUserName.AllowParentOverrides = false;
			this.lblUserName.AutoEllipsis = false;
			this.lblUserName.CursorType = null;
			this.lblUserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblUserName.ForeColor = System.Drawing.Color.White;
			this.lblUserName.Location = new System.Drawing.Point(15, 3);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblUserName.Size = new System.Drawing.Size(109, 23);
			this.lblUserName.TabIndex = 2;
			this.lblUserName.Text = "User Name";
			this.lblUserName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblUserName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// lblTime
			// 
			this.lblTime.AllowParentOverrides = false;
			this.lblTime.AutoEllipsis = false;
			this.lblTime.CursorType = null;
			this.lblTime.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(15, 31);
			this.lblTime.Name = "lblTime";
			this.lblTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblTime.Size = new System.Drawing.Size(45, 23);
			this.lblTime.TabIndex = 4;
			this.lblTime.Text = "time";
			this.lblTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
			this.lblTime.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// lblSubject
			// 
			this.lblSubject.AllowParentOverrides = false;
			this.lblSubject.AutoEllipsis = true;
			this.lblSubject.AutoSize = false;
			this.lblSubject.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSubject.CursorType = System.Windows.Forms.Cursors.Hand;
			this.lblSubject.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblSubject.ForeColor = System.Drawing.Color.Transparent;
			this.lblSubject.Location = new System.Drawing.Point(15, 54);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblSubject.Size = new System.Drawing.Size(314, 43);
			this.lblSubject.TabIndex = 6;
			this.lblSubject.Text = "Subject";
			this.lblSubject.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblSubject.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
			// 
			// btnMessageData
			// 
			this.btnMessageData.BorderColor = System.Drawing.Color.Transparent;
			this.btnMessageData.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnMessageData.DisabledState.BorderColor = System.Drawing.Color.Transparent;
			this.btnMessageData.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnMessageData.DisabledState.FillColor = System.Drawing.Color.Transparent;
			this.btnMessageData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnMessageData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.btnMessageData.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnMessageData.ForeColor = System.Drawing.Color.Transparent;
			this.btnMessageData.HoverState.BorderColor = System.Drawing.Color.Transparent;
			this.btnMessageData.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
			this.btnMessageData.HoverState.FillColor = System.Drawing.Color.Transparent;
			this.btnMessageData.HoverState.ForeColor = System.Drawing.Color.Transparent;
			this.btnMessageData.Location = new System.Drawing.Point(0, 0);
			this.btnMessageData.Name = "btnMessageData";
			this.btnMessageData.PressedColor = System.Drawing.Color.Transparent;
			this.btnMessageData.PressedDepth = 0;
			this.btnMessageData.ShadowDecoration.Color = System.Drawing.Color.Transparent;
			this.btnMessageData.Size = new System.Drawing.Size(329, 97);
			this.btnMessageData.TabIndex = 11;
			this.btnMessageData.Click += new System.EventHandler(this.btnMessageData_Click);
			// 
			// MessageDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblSubject);
			this.Controls.Add(this.btnMessageData);
			this.Name = "MessageDetails";
			this.Size = new System.Drawing.Size(329, 97);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private Bunifu.UI.WinForms.BunifuLabel lblUserName;
		private Bunifu.UI.WinForms.BunifuLabel lblTime;
		private Bunifu.UI.WinForms.BunifuLabel lblSubject;
		private Guna.UI2.WinForms.Guna2Button btnMessageData;
	}
}

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
			this.btnMessageData = new Guna.UI2.WinForms.Guna2Button();
			this.lblUserName = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.lblSubject = new System.Windows.Forms.Label();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.SuspendLayout();
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
			// lblUserName
			// 
			this.lblUserName.BackColor = System.Drawing.Color.Transparent;
			this.lblUserName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblUserName.ForeColor = System.Drawing.Color.White;
			this.lblUserName.Location = new System.Drawing.Point(15, 3);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(112, 25);
			this.lblUserName.TabIndex = 12;
			this.lblUserName.Text = "User Name";
			// 
			// lblTime
			// 
			this.lblTime.BackColor = System.Drawing.Color.Transparent;
			this.lblTime.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTime.ForeColor = System.Drawing.Color.White;
			this.lblTime.Location = new System.Drawing.Point(15, 30);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(39, 24);
			this.lblTime.TabIndex = 13;
			this.lblTime.Text = "time";
			this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
			// 
			// lblSubject
			// 
			this.lblSubject.AutoEllipsis = true;
			this.lblSubject.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblSubject.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
			this.lblSubject.ForeColor = System.Drawing.Color.White;
			this.lblSubject.Location = new System.Drawing.Point(11, 58);
			this.lblSubject.Name = "lblSubject";
			this.lblSubject.Size = new System.Drawing.Size(304, 32);
			this.lblSubject.TabIndex = 14;
			this.lblSubject.Text = "label1";
			this.lblSubject.Click += new System.EventHandler(this.lblSubject_Click);
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.TargetControl = this;
			// 
			// MessageDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
			this.Controls.Add(this.lblSubject);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.btnMessageData);
			this.Name = "MessageDetails";
			this.Size = new System.Drawing.Size(329, 97);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2Button btnMessageData;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
		private Guna.UI2.WinForms.Guna2HtmlLabel lblUserName;
		private System.Windows.Forms.Label lblSubject;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
	}
}

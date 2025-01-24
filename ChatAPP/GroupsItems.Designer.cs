namespace ChatAPP
{
	partial class GroupsItems
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
			this.lblGroupName = new Guna.UI2.WinForms.Guna2HtmlLabel();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.SuspendLayout();
			// 
			// lblGroupName
			// 
			this.lblGroupName.BackColor = System.Drawing.Color.Transparent;
			this.lblGroupName.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold);
			this.lblGroupName.ForeColor = System.Drawing.Color.White;
			this.lblGroupName.Location = new System.Drawing.Point(13, 26);
			this.lblGroupName.Name = "lblGroupName";
			this.lblGroupName.Size = new System.Drawing.Size(128, 25);
			this.lblGroupName.TabIndex = 6;
			this.lblGroupName.Text = "Group Name";
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 15;
			this.guna2Elipse1.TargetControl = this;
			// 
			// GroupsItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
			this.Controls.Add(this.lblGroupName);
			this.Name = "GroupsItems";
			this.Size = new System.Drawing.Size(333, 83);
			this.Load += new System.EventHandler(this.GroupsItems_Load);
			this.Click += new System.EventHandler(this.GroupsItems_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Guna.UI2.WinForms.Guna2HtmlLabel lblGroupName;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
	}
}

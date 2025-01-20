namespace ChatAPP
{
	partial class MessageInformation
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageInformation));
			this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panelSubject = new Guna.UI2.WinForms.Guna2Panel();
			this.panelTime = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
			this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// bunifuElipse1
			// 
			this.bunifuElipse1.ElipseRadius = 5;
			this.bunifuElipse1.TargetControl = this;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panelSubject, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panelTime, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.txtMessage, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(496, 122);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panelSubject
			// 
			this.panelSubject.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelSubject.Location = new System.Drawing.Point(3, 3);
			this.panelSubject.Name = "panelSubject";
			this.panelSubject.Size = new System.Drawing.Size(490, 24);
			this.panelSubject.TabIndex = 0;
			// 
			// panelTime
			// 
			this.panelTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelTime.Location = new System.Drawing.Point(3, 105);
			this.panelTime.Name = "panelTime";
			this.panelTime.Size = new System.Drawing.Size(490, 14);
			this.panelTime.TabIndex = 2;
			// 
			// guna2ContextMenuStrip1
			// 
			this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
			this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
			this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
			this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
			this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
			this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// txtMessage
			// 
			this.txtMessage.AutoScroll = true;
			this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtMessage.DefaultText = resources.GetString("txtMessage.DefaultText");
			this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMessage.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold);
			this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtMessage.Location = new System.Drawing.Point(6, 35);
			this.txtMessage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.txtMessage.Modified = true;
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.PasswordChar = '\0';
			this.txtMessage.PlaceholderText = "";
			this.txtMessage.ReadOnly = true;
			this.txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtMessage.SelectedText = "";
			this.txtMessage.Size = new System.Drawing.Size(484, 62);
			this.txtMessage.TabIndex = 3;
			// 
			// MessageInformation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MessageInformation";
			this.Size = new System.Drawing.Size(496, 122);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private Guna.UI2.WinForms.Guna2Panel panelSubject;
		private Guna.UI2.WinForms.Guna2Panel panelTime;
		private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
		private Guna.UI2.WinForms.Guna2TextBox txtMessage;
	}
}

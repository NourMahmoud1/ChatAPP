using ChatAPP.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP
{
	public partial class LogIN : Form
	{
		public LogIN()
		{
			InitializeComponent();
		}

		private void btnExitApp_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}

		private async void btnLogin_Click(object sender, EventArgs e)
		{
			// Validate that both text boxes are not empty
			if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			prograssin.Visible = true;
			btnLogin.Enabled = false;
			// Simulate a delay to show the progress indicator (for demonstration purposes)
			//await Task.Delay(500);

			// Check if the user credentials are correct
			var user = await Task.Run(() => LoginBL.CheckUser(txtUserName.Text, txtPassword.Text));
			if (user != null)
			{
				Home home = new Home();
				home.Show();
				this.Hide(); // Optionally hide the login form
			}
			else
			{
				MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
				prograssin.Visible = false;
				btnLogin.Enabled = true;
			}
		}

		private void txtPassword_IconRightClick(object sender, EventArgs e)
		{
			if(txtPassword.UseSystemPasswordChar == true)
			{
				txtPassword.UseSystemPasswordChar = false;
			}
			else
			{
				txtPassword.UseSystemPasswordChar = true;
			}
		}

		private void LogIN_Load(object sender, EventArgs e)
		{
			txtPassword.UseSystemPasswordChar = true;
		}

		private void txt_clear_Click(object sender, EventArgs e)
		{
			txtPassword.Clear();
			txtUserName.Clear();
		}
	}
}

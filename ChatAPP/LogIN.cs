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

		
		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Validate that both text boxes are not empty
			if (string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
			{
				MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			// Check if the user credentials are correct
			var user = LoginBL.CheckUser(txtUserName.Text, txtPassword.Text);
			if (user != null)
			{
				Home home = new Home();
				home.Show();
				this.Hide(); // Optionally hide the login form
			}
			else
			{
				MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		

		private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatAPP.BL;

namespace ChatAPP
{
	public partial class Home : Form
	{
		public Home()
		{
			InitializeComponent();
		}
		

		private void tabPage1_Click(object sender, EventArgs e)
		{

		}
		private void GenerateDynamicUserControlAllUsers()
		{
			flowLayoutAllUsers.Controls.Clear();
			DataTable dt = NewMessageBL.GetAllUsers();

			if (dt != null || dt.Rows.Count > 0)
			{
				UserItem[] listItems = new UserItem[5];

				for (int i = 0; i < 1; i++)
				{
					foreach (DataRow row in dt.Rows)
					{
						listItems[i] = new UserItem();
						
						listItems[i].UserName = row["UserName"].ToString();
						listItems[i].UserEmail = row["Email"].ToString();
						listItems[i].UserID = row["UserId"].ToString();
						flowLayoutAllUsers.Controls.Add(listItems[i]);
					}
				}
			}


				
        }
		private void Home_Load(object sender, EventArgs e)
		{
			GenerateDynamicUserControlAllUsers();
		}

		private void btnSendMessage_Click(object sender, EventArgs e)
		{
			//check if user is selected
			if (SharedData.UsersSelected.Count == 0)
			{
				MessageBox.Show("Please select a user to send message");
			}
			//chech the message and subject
			else if (txtMessage.Text == "" || txtSubject.Text == "")
			{
				MessageBox.Show("Please enter the message and subject");
			}
			else
			{
				//send message
				if (NewMessageBL.NewMessage(txtMessage.Text, txtSubject.Text) == 1)
				{
					MessageBox.Show("Message Sent Successfully");
				}
				else
				{
					MessageBox.Show("Message Sending Failed");
				}
			}
		}
	}
}

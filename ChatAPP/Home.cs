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
		private void GenerateDynamicUserControlAllMessages()
		{
			flowLayoutInbox.Controls.Clear();
			DataTable dt = InboxBL.GetLatestMessagesForRecipient();
			if (dt != null || dt.Rows.Count > 0)
			{
				MessageDetails[] listItems = new MessageDetails[5];

				for (int i = 0; i < 1; i++)
				{
					foreach (DataRow row in dt.Rows)
					{
						// get the sender data
						DataTable dt1 = InboxBL.GetSenderData(row["SenderID"].ToString());
						listItems[i] = new MessageDetails();
						listItems[i].UserName = dt1.Rows[0]["UserName"].ToString();
						listItems[i].Time = row["DateSent"].ToString();
						listItems[i].Subject = row["Subject"].ToString();
						flowLayoutInbox.Controls.Add(listItems[i]);
					}
				}
			}

		}
		private void UserResivedMessages()
		{
			flowLayoutInbox.Controls.Clear();
			MessageDetails[] listItems = new MessageDetails[5];
			for (int i = 0; i < 5; i++)
			{
				listItems[i] = new MessageDetails();
				flowLayoutInbox.Controls.Add(listItems[i]);
			}
		}
		private void Home_Load(object sender, EventArgs e)
		{
			GenerateDynamicUserControlAllUsers();
			GenerateDynamicUserControlAllMessages();
			//UserResivedMessages();
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

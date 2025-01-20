using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
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
		private void testflowlayout()
		{
			flowLayoutInbox.Controls.Clear();
			MessageDetails[] listItems = new MessageDetails[5];

			for (int i = 0; i < 5; i++)
			{
				// get the sender data
				listItems[i] = new MessageDetails();
				//listItems[i].DataSent += LoadMessages4;
				//this.Controls.Add(listItems[i]);
				listItems[i].UserName = "name";
				listItems[i].Time = "time";
				listItems[i].Subject = "subject space";
				flowLayoutInbox.Controls.Add(listItems[i]);
			}

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
						string sendid = row["SenderID"].ToString();
						DataTable dt1;
						if (sendid == SharedData.UserId)
						{
							dt1 = InboxBL.GetSenderData(row["RecipientID"].ToString());
						}
						else
						{
							dt1 = InboxBL.GetSenderData(row["SenderID"].ToString());
						}
						listItems[i] = new MessageDetails();
						listItems[i].UserName = dt1.Rows[0]["UserName"].ToString();
						listItems[i].SenderID = row["SenderID"].ToString();
						listItems[i].Time = row["DateSent"].ToString();
						listItems[i].Subject = row["Subject"].ToString();
						listItems[i].DataSent += LoadMessages;
						this.Controls.Add(listItems[i]);
						flowLayoutInbox.Controls.Add(listItems[i]);
					}
				}
			}

		}
		private void LoadMessages(object sender, string sendID)
		{
			flowLayoutMessages.Controls.Clear();
			flowLayoutMessages.FlowDirection = FlowDirection.BottomUp;
			flowLayoutMessages.WrapContents = false;
			flowLayoutMessages.HorizontalScroll.Maximum = 0;
			flowLayoutMessages.HorizontalScroll.Visible = false;
			flowLayoutMessages.AutoScroll = true;

			DataTable dt = InboxBL.GetMessagesForSenderAndRecipient(sendID);

			foreach (DataRow row in dt.Rows)
			{
				// Create a panel to hold the message details
				Panel messagePanel = new Panel();
				messagePanel.AutoSize = true;
				messagePanel.Padding = new Padding(10);
				messagePanel.Margin = new Padding(5);
				messagePanel.BorderStyle = BorderStyle.FixedSingle;

				// Create a TableLayoutPanel to organize the labels
				TableLayoutPanel tableLayoutPanel = new TableLayoutPanel();
				tableLayoutPanel.ColumnCount = 1;
				tableLayoutPanel.RowCount = 3;
				tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
				tableLayoutPanel.AutoSize = true;
				tableLayoutPanel.Dock = DockStyle.Fill;

				// Create a label for the subject
				Label subjectLabel = new Label();
				subjectLabel.Text = row["Subject"].ToString();
				subjectLabel.Font = new Font(subjectLabel.Font.FontFamily, 12.2f, FontStyle.Regular);
				subjectLabel.AutoSize = true;
				subjectLabel.ForeColor = Color.DarkBlue;
				subjectLabel.MaximumSize = new Size(flowLayoutMessages.Width - 50, 0);

				// Create a label for the date sent
				Label dateSentLabel = new Label();
				dateSentLabel.Text =  row["DateSent"].ToString();
				dateSentLabel.Font = new Font(dateSentLabel.Font.FontFamily, 10f, FontStyle.Regular);
				dateSentLabel.AutoSize = true;
				dateSentLabel.MaximumSize = new Size(flowLayoutMessages.Width - 50, 0);
				//dateSentLabel.TextAlign = ContentAlignment.MiddleRight;
				dateSentLabel.Dock = DockStyle.Right;
				// Create a label for the message body
				Label messageLabel = new Label();
				messageLabel.Text = row["Body"].ToString();
				messageLabel.Font = new Font(messageLabel.Font.FontFamily, 11f, FontStyle.Regular);
				messageLabel.AutoSize = true;
				messageLabel.MaximumSize = new Size(flowLayoutMessages.Width - 50, 0);

				// Check if the message is from the sender or the logged-in user
				if (row["SenderID"].ToString() == SharedData.UserId)
				{
					// Message from the logged-in user
					messagePanel.BackColor = Color.LightBlue;
					messageLabel.TextAlign = ContentAlignment.MiddleLeft;
				}
				else
				{
					// Message from the sender
					messagePanel.BackColor = Color.LightGreen;
					messageLabel.TextAlign = ContentAlignment.MiddleLeft;
				}

				// Add the labels to the TableLayoutPanel
				tableLayoutPanel.Controls.Add(subjectLabel, 0, 0);
				tableLayoutPanel.Controls.Add(messageLabel, 0, 1);
				tableLayoutPanel.Controls.Add(dateSentLabel, 0, 2);

				// Add the TableLayoutPanel to the panel
				messagePanel.Controls.Add(tableLayoutPanel);

				// Insert the panel in the flow layout
				flowLayoutMessages.Controls.Add(messagePanel);
			}

			// Scroll to the bottom
			flowLayoutMessages.AutoScrollPosition = new Point(0, flowLayoutMessages.DisplayRectangle.Height);
		}


		private void Home_Load(object sender, EventArgs e)
		{
			GenerateDynamicUserControlAllUsers();
			GenerateDynamicUserControlAllMessages();
			//LoadMessages("9");
			//testflowlayout();
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

		private void messageDetails1_Load(object sender, EventArgs e)
		{

		}

		private void btnLogOUT_Click(object sender, EventArgs e)
		{
			LogIN logIN = new LogIN();
			logIN.Show();
			this.Hide();
		}
	}
}

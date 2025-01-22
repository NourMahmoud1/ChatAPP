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
		public bool ValidationTextBoxSetting()
		{
			if (string.IsNullOrWhiteSpace(txtUserNameSetting.Text) || string.IsNullOrWhiteSpace(txtFullNameSetting.Text) || string.IsNullOrWhiteSpace(txtEmailSetting.Text) || string.IsNullOrWhiteSpace(txtPhoneSetting.Text) || string.IsNullOrWhiteSpace(txtPhoneSetting.Text))
			{
				MessageBox.Show("Please Fill All the Field.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}
			return true;
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
		private void LoadUserDataInSettingPage()
		{
			DataTable dt = SettingBL.GetUserData();
			if (dt != null || dt.Rows.Count > 0)
			{
				txtUserNameSetting.Text = dt.Rows[0]["UserName"].ToString();
				txtFullNameSetting.Text = dt.Rows[0]["FullName"].ToString();
				txtPhoneSetting.Text = dt.Rows[0]["Phone"].ToString();
				txtEmailSetting.Text = dt.Rows[0]["Email"].ToString();
				txtPasswordSetting.Text = dt.Rows[0]["password"].ToString();
				try
				{
					DataTable dtGroup = SettingBL.GetGroupName(dt.Rows[0]["GroupId"].ToString());
					txtGroupSetting.Text = dtGroup.Rows[0]["GroupName"].ToString();

				}
				catch (Exception)
				{
					MessageBox.Show("You are not in any group");
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
						listItems[i] = new MessageDetails();
						if (sendid == SharedData.UserId)
						{
							dt1 = InboxBL.GetSenderData(row["RecipientID"].ToString());
							listItems[i].SenderID = row["RecipientID"].ToString();

						}
						else
						{
							dt1 = InboxBL.GetSenderData(row["SenderID"].ToString());
							listItems[i].SenderID = row["SenderID"].ToString();
						}
						listItems[i].UserName = dt1.Rows[0]["UserName"].ToString();
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
				//subjectLabel.Font = new Font(subjectLabel.Font.FontFamily, 13.2f, FontStyle.Bold);
				//set font family to Segoe UI
				subjectLabel.Font = new Font("Segoe UI", 12.2f, FontStyle.Regular);
				subjectLabel.AutoSize = true;
				subjectLabel.ForeColor = Color.DarkBlue;
				subjectLabel.MaximumSize = new Size(flowLayoutMessages.Width - 50, 0);

				// Create a label for the date sent
				Label dateSentLabel = new Label();
				dateSentLabel.Text = row["DateSent"].ToString();
				//dateSentLabel.Font = new Font(dateSentLabel.Font.FontFamily, 10f, FontStyle.Regular);
				dateSentLabel.Font = new Font("Segoe UI", 12.2f, FontStyle.Regular);

				dateSentLabel.AutoSize = true;
				dateSentLabel.MaximumSize = new Size(flowLayoutMessages.Width - 50, 0);
				dateSentLabel.Dock = DockStyle.Right;

				// Create a label for the message body
				Label messageLabel = new Label();
				messageLabel.Text = row["Body"].ToString();
				//messageLabel.Font = new Font(messageLabel.Font.FontFamily, 11f, FontStyle.Regular);
				messageLabel.Font = new Font("Segoe UI", 11f, FontStyle.Regular);
				messageLabel.AutoSize = true;
				messageLabel.MaximumSize = new Size(flowLayoutMessages.Width - 50, 0);
				messageLabel.Margin = new Padding(0, 10, 0, 10);

				// Check if the message is from the sender or the logged-in user
				if (row["SenderID"].ToString() == SharedData.UserId)
				{
					// Message from the logged-in user
					messagePanel.BackColor = Color.LightBlue;
					messageLabel.TextAlign = ContentAlignment.MiddleLeft;
					//flowLayoutMessages.FlowDirection = FlowDirection.LeftToRight;
				}
				else
				{
					// Message from the sender
					//flowLayoutMessages.FlowDirection = FlowDirection.RightToLeft;

					messagePanel.BackColor = Color.LightGreen;
					messageLabel.TextAlign = ContentAlignment.MiddleLeft;
					subjectLabel.Font = new Font("Segoe UI", 12.2f, FontStyle.Bold);

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
			LoadUserDataInSettingPage();

			DataTable dtmessage = messagesBL.GetAllMessages();
			dataGridViewMessages.DataSource = dtmessage;
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
			//chech the message and subjectNour
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
					//clear the textboxes
					txtMessage.Text = "";
					txtSubject.Text = "";
					GenerateDynamicUserControlAllMessages();

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

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			DataTable dt = messagesBL.Searchmessage(txtSearch.Text);

			if (dt.Rows.Count > 0)
			{
				dataGridViewMessages.DataSource = dt;
				//MessageBox.Show("Done");
			}
			else
			{
				//MessageBox.Show("No Books Found");
			}
			if (string.IsNullOrWhiteSpace(txtSearch.Text))
			{
				DataTable dtmessage = messagesBL.GetAllMessages();
				dataGridViewMessages.DataSource = dtmessage;
			}
		}

		private void btnEditSetting_Click(object sender, EventArgs e)
		{
			if (ValidationTextBoxSetting())
			{
				try
				{
					if (SettingBL.UpdateUserData(txtUserNameSetting.Text, txtFullNameSetting.Text, txtEmailSetting.Text, txtPasswordSetting.Text, txtPhoneSetting.Text) > 0)
					{
						MessageBox.Show("Your Data Updated Successfully");
					}
					else
					{
						MessageBox.Show("Failed to Update Your Data");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void SentCheckBox_Click(object sender, EventArgs e)
		{
			if (SentCheckBox.Checked)
			{
				SharedData.sentCheckStatus = true;
			}
			else
			{
				SharedData.sentCheckStatus = false;
			}
			DataTable dtmessage = messagesBL.GetAllMessages();
			dataGridViewMessages.DataSource = dtmessage;
		}

		private void RecivedCheckBox_Click(object sender, EventArgs e)
		{
			if (RecivedCheckBox.Checked)
			{
				SharedData.reciveCheckStatus = true;
			}
			else
			{
				SharedData.reciveCheckStatus = false;
			}
			DataTable dtmessage = messagesBL.GetAllMessages();
			dataGridViewMessages.DataSource = dtmessage;
		}
	}
}

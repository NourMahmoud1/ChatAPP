using ChatAPP.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP.BL
{
	internal class InboxBL
	{
		
		public static DataTable GetLatestMessagesForRecipient()
		{
			DataTable items = new DataTable();
			try
			{
				string storedProcedureName = "GetLatestMessagesForRecipient";
				SqlCommand cmd = new SqlCommand(storedProcedureName);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@RecipientID", SharedData.UserId);

				return ChatDL.Select(cmd);
			}
			catch (Exception e)
			{
				// Show the error message in a MessageBox
				MessageBox.Show(e.Message.ToString());
				return null;
			}
		}
		// get all the messages for a specific sender and recipient
		public static DataTable GetMessagesForSenderAndRecipient(string senderID)
		{
			DataTable items = new DataTable();
			try
			{
				// Query to get all the messages for a specific sender and recipient
				string query = "SELECT * FROM Messages where SenderID = @senderID AND RecipientID = @recipientID or  SenderID = @recipientID AND RecipientID = @senderID order by DateSent desc";

				SqlCommand cmd = new SqlCommand(query);
				cmd.Parameters.AddWithValue("@senderID", senderID);
				cmd.Parameters.AddWithValue("@recipientID", SharedData.UserId);

				return ChatDL.Select(cmd);
			}
			catch (Exception e)
			{
				DialogResult result = MessageBox.Show(e.Message.ToString());
				return null;
			}
		}

		public static DataTable GetSenderData(string senderID)
		{
			DataTable items = new DataTable();
			try
			{
				string query = "SELECT * FROM Users where UserID = " + senderID;
				SqlCommand cmd = new SqlCommand(query);
				return ChatDL.Select(cmd);
			}
			catch (Exception e)
			{
				DialogResult result = MessageBox.Show(e.Message.ToString());
				return null;
			}
		}
	}
}

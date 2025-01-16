using ChatAPP.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP.BL
{
	internal static class NewMessageBL
	{
		public static DataTable GetAllUsers()
		{
			DataTable items = new DataTable();
			try
			{

				string query = "SELECT * FROM Users";
				SqlCommand cmd = new SqlCommand(query);
				return ChatDL.Select(cmd);
			}
			catch (Exception e)
			{
				DialogResult result = MessageBox.Show(e.Message.ToString());
				return null;
			}
		}


		/// <summary>
		/// Sends a new message to all users selected in the SharedData.UsersSelected list.
		/// Inserts a new record into the Messages table for each recipient.
		/// </summary>
		/// <param name="message">The body of the message to be sent.</param>
		/// <param name="subject">The subject of the message to be sent.</param>
		/// <returns>Returns 1 if the message was successfully sent to all recipients, otherwise returns 0.</returns>
		public static int NewMessage(string message, string subject)
		{
			try
			{
				foreach (var recipientId in SharedData.UsersSelected)
				{
					string query = "INSERT INTO Messages(Body,Subject,DateSent,SenderID,RecipientID,IsRead) values(@Body,@Subject,@DateSent,@SenderID,@RecipientID,@IsRead)";
					SqlCommand cmd = new SqlCommand(query);
					cmd.Parameters.AddWithValue("@Body", message);
					cmd.Parameters.AddWithValue("@Subject", subject);
					cmd.Parameters.AddWithValue("@DateSent", DateTime.Now);
					cmd.Parameters.AddWithValue("@SenderID", SharedData.UserId);
					cmd.Parameters.AddWithValue("@RecipientID", recipientId);
					cmd.Parameters.AddWithValue("@IsRead", 0);
					ChatDL.DML(cmd);
				}
			}
			catch (Exception e)
			{
				DialogResult result = MessageBox.Show(e.Message.ToString());
				return 0;
			}
			return 1;
			//string query = "INSERT INTO Messages(Body,Subject,DateSent,SenderID,RecipientID,IsRead) values(@Body,@Subject,@DateSent,@SenderID,@RecipientID,@IsRead)";
		}


	}
}

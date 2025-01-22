using ChatAPP.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPP.BL
{
	internal static class messagesBL
	{
		private static string ConstructQuery(bool isSearch, string searchValue = "")
		{
			string query = "SELECT Messages.Subject, Messages.Body, Users_1.UserName as Sender, Users.UserName AS Recipient, Messages.IsRead, Messages.DateSent " +
						   "FROM Messages " +
						   "INNER JOIN Users ON Messages.RecipientID = Users.UserId " +
						   "INNER JOIN Users AS Users_1 ON Messages.SenderID = Users_1.UserId " +
						   "WHERE ";

			if (SharedData.sentCheckStatus && SharedData.reciveCheckStatus)
			{
				query += "(Messages.SenderID = @senderID OR Messages.RecipientID = @recipientid) ";
			}
			else if (SharedData.sentCheckStatus)
			{
				query += "Messages.SenderID = @senderID ";
			}
			else if (SharedData.reciveCheckStatus)
			{
				query += "Messages.RecipientID = @recipientid ";
			}
			else
			{
				return null;
			}

			if (isSearch)
			{
				query += "AND (Messages.Subject LIKE @value OR Messages.Body LIKE @value)";
			}

			return query;
		}

		public static DataTable GetAllMessages()
		{
			string query = ConstructQuery(false);
			if (query == null)
				return null;

			SqlCommand cmd = new SqlCommand(query);
			cmd.Parameters.AddWithValue("@senderID", SharedData.UserId);
			cmd.Parameters.AddWithValue("@recipientid", SharedData.UserId);
			return ChatDL.Select(cmd);
		}

		public static DataTable Searchmessage(string value)
		{
			string query = ConstructQuery(true, value);
			if (query == null)
				return null;

			SqlCommand cmd = new SqlCommand(query);
			cmd.Parameters.AddWithValue("@senderID", SharedData.UserId);
			cmd.Parameters.AddWithValue("@recipientid", SharedData.UserId);
			cmd.Parameters.AddWithValue("@value", "%" + value + "%");
			return ChatDL.Select(cmd);
		}
		//public static DataTable GetAllMessages()
		//{
		//	string query = "";
		//	if (!SharedData.sentCheckStatus && !SharedData.reciveCheckStatus)
		//		return null;
		//	if (SharedData.sentCheckStatus && SharedData.reciveCheckStatus)
		//	{
		//		query = "SELECT Messages.Subject, Messages.Body, Users_1.UserName as Sender, Users.UserName AS Recipient,  Messages.IsRead, Messages.DateSent FROM Messages INNER JOIN Users ON Messages.RecipientID = Users.UserId INNER JOIN Users AS Users_1 ON Messages.SenderID = Users_1.UserId where Messages.SenderID = @senderID or Messages.RecipientID = @recipientid";
		//	}
		//	else if (SharedData.sentCheckStatus == true && SharedData.reciveCheckStatus == false)
		//	{
		//		query = "SELECT Messages.Subject, Messages.Body, Users_1.UserName as Sender, Users.UserName AS Recipient,  Messages.IsRead, Messages.DateSent FROM Messages INNER JOIN Users ON Messages.RecipientID = Users.UserId INNER JOIN Users AS Users_1 ON Messages.SenderID = Users_1.UserId where Messages.SenderID = @senderID";
		//	}
		//	else if (SharedData.sentCheckStatus == false && SharedData.reciveCheckStatus == true)
		//	{
		//		query = "SELECT Messages.Subject, Messages.Body, Users_1.UserName as Sender, Users.UserName AS Recipient,  Messages.IsRead, Messages.DateSent FROM Messages INNER JOIN Users ON Messages.RecipientID = Users.UserId INNER JOIN Users AS Users_1 ON Messages.SenderID = Users_1.UserId where  Messages.RecipientID = @recipientid";
		//	}

		//	SqlCommand cmd = new SqlCommand(query);
		//	cmd.Parameters.AddWithValue("@senderID", SharedData.UserId);
		//	cmd.Parameters.AddWithValue("@recipientid", SharedData.UserId);
		//	return ChatDL.Select(cmd);
		//}
		//public static DataTable Searchmessage(string value)
		//{
		//	string query = "";
		//	if (!SharedData.sentCheckStatus && !SharedData.reciveCheckStatus)
		//		return null;

		//	if (SharedData.sentCheckStatus && SharedData.reciveCheckStatus)
		//	{
		//		query = "SELECT Messages.Subject, Messages.Body, Users_1.UserName as Sender, Users.UserName AS Recipient, Messages.IsRead, Messages.DateSent " +
		//				"FROM Messages " +
		//				"INNER JOIN Users ON Messages.RecipientID = Users.UserId " +
		//				"INNER JOIN Users AS Users_1 ON Messages.SenderID = Users_1.UserId " +
		//				"WHERE (Messages.SenderID = @senderID OR Messages.RecipientID = @recipientid) " +
		//				"AND (Messages.Subject LIKE @value OR Messages.Body LIKE @value)";
		//	}
		//	else if (SharedData.sentCheckStatus == true && SharedData.reciveCheckStatus == false)
		//	{
		//		query = "SELECT Messages.Subject, Messages.Body, Users_1.UserName as Sender, Users.UserName AS Recipient, Messages.IsRead, Messages.DateSent " +
		//				"FROM Messages " +
		//				"INNER JOIN Users ON Messages.RecipientID = Users.UserId " +
		//				"INNER JOIN Users AS Users_1 ON Messages.SenderID = Users_1.UserId " +
		//				"WHERE Messages.SenderID = @senderID " +
		//				"AND (Messages.Subject LIKE @value OR Messages.Body LIKE @value)";
		//	}
		//	else if (SharedData.sentCheckStatus == false && SharedData.reciveCheckStatus == true)
		//	{
		//		query = "SELECT Messages.Subject, Messages.Body, Users_1.UserName as Sender, Users.UserName AS Recipient, Messages.IsRead, Messages.DateSent " +
		//				"FROM Messages " +
		//				"INNER JOIN Users ON Messages.RecipientID = Users.UserId " +
		//				"INNER JOIN Users AS Users_1 ON Messages.SenderID = Users_1.UserId " +
		//				"WHERE Messages.RecipientID = @recipientid " +
		//				"AND (Messages.Subject LIKE @value OR Messages.Body LIKE @value)";
		//	}

		//	SqlCommand cmd = new SqlCommand(query);
		//	cmd.Parameters.AddWithValue("@senderID", SharedData.UserId);
		//	cmd.Parameters.AddWithValue("@recipientid", SharedData.UserId);
		//	cmd.Parameters.AddWithValue("@value", "%" + value + "%");
		//	return ChatDL.Select(cmd);
		//}


	}
}


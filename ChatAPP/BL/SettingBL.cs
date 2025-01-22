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
	internal class SettingBL
	{
		public static int UpdateUserData(string userName, string fullName, string email, string password, string phone)
		{
			string query = "update Users set UserName=@userName,FullName=@fullName,Email=@email,Password=@password,Phone=@phone where UserID=@id";
			SqlCommand cmd = new SqlCommand(query);
			cmd.Parameters.AddWithValue("@id", SharedData.UserId);
			cmd.Parameters.AddWithValue("@userName", userName);
			cmd.Parameters.AddWithValue("@fullName", fullName);
			cmd.Parameters.AddWithValue("@email", email);
			cmd.Parameters.AddWithValue("@password", password);
			cmd.Parameters.AddWithValue("@phone", phone);
			return ChatDL.DML(cmd);
		}
		public static DataTable GetUserData()
		{
			try
			{
				string querry = "select * from Users Where UserID ='" + SharedData.UserId + "' ";
				SqlCommand cmd = new SqlCommand(querry);
				return ChatDL.Select(cmd);
			}
			catch (Exception e)
			{
				DialogResult result = MessageBox.Show(e.Message.ToString());
				return null;
			}
		}
		public static DataTable GetGroupName(string groupId) {
			try
			{
				string querry = "select * from Groups Where GroupId ='" + groupId + "' ";
				SqlCommand cmd = new SqlCommand(querry);
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

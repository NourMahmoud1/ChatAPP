using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP.BL
{
	internal static class LoginBL
	{
		public static string UserId = "0";
		public static string CheckUser(string UserName, string Password)
		{
			string querry = "select * from Users where UserName = '" + UserName + "' and Password = '" + Password + "'";
			string userId = DAL.ChatDL.GetValue(querry);
			if(userId == null)
			{
				return null;
			}
			else
			{
				//MessageBox.Show(userId);
				UserId = userId;
				return userId;
			}
		}
	}
}

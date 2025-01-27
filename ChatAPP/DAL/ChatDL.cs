﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP.DAL
{
	internal static class ChatDL
	{
		private static string connectionString = "Data Source=SQL1002.site4now.net;Initial Catalog=db_ab1b63_chatapp;User Id=db_ab1b63_chatapp_admin;Password=Nour1234";
		private static SqlConnection con = new SqlConnection(connectionString);
		private static SqlCommand SqlCommand = new SqlCommand();
		public static DataTable Select(SqlCommand cmd)
		{
			try
			{
				DataTable dt = new DataTable();
				cmd.Connection = con;
				SqlDataAdapter adapter = new SqlDataAdapter(cmd);
				adapter.Fill(dt);


				return dt;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				DataTable errortable = new DataTable();
				return errortable;
			}
		}
		/// <summary>
		/// 
		/// </summary>
		/// <param name="cmd"></param>
		/// <returns></returns>
		public static int DML(SqlCommand cmd)
		{
			try
			{
				cmd.Connection = con;
				con.Open();
				int result = cmd.ExecuteNonQuery();
				//con.Close();
				return result;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return 0;
			}
			finally
			{

				con.Close();
			}

		}
		public static async Task<string> GetValue(string sl)
		{
			string result = null;
			try
			{
				SqlCommand.CommandText = sl;
				SqlCommand.Connection = con;
				await con.OpenAsync();
				var scalarResult = await SqlCommand.ExecuteScalarAsync();
				if (scalarResult != null)
				{
					result = scalarResult.ToString();
				}
				return result;

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return null;
			}
			finally
			{
				con.Close();
			}

		}
	}
}

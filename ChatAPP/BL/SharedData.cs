﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatAPP.BL
{
	internal static class SharedData
	{
		public static List<int> UsersSelected { get; set; } = new List<int>();
		public static string UserId = "0";

	}
}

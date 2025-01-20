using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatAPP
{
	public partial class MessageDetails : UserControl
	{
		public MessageDetails()
		{
			InitializeComponent();
		}

		private string _userName;
		private string _subject;
		private string _time;
		//public string _userID = "1";

		[Category("Custom Props")]
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; lblUserName.Text = value; }
		}
		[Category("Custom Props")]
		public string Subject
		{
			get { return _subject; }
			set { _subject = value; lblSubject.Text = value; }
		}
		[Category("Custom Props")]
		public string Time
		{
			get { return _time; }
			set { _time = value; lblTime.Text = value; }
		}
        public string SenderID { get; set; }
		public event EventHandler<string> DataSent;
		private void btnMessageData_Click(object sender, EventArgs e)
		{

			string data = SenderID; // Example of user input
			DataSent?.Invoke(this, data);   // Trigger the event
		}
	}
}

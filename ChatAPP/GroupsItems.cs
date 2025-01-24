using ChatAPP.BL;
using Microsoft.VisualBasic.ApplicationServices;
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
	public partial class GroupsItems : UserControl
	{
		public GroupsItems()
		{
			InitializeComponent();
		}

		private bool _isSelected = false;
		public string _groupID = "0";

		private string _groupName;
		[Category("Custom Props")]
		public string GroupName
		{
			get { return _groupName; }
			set { _groupName = value; lblGroupName.Text = value; }
		}
		[Category("Custom Props")]
		public string GroupID
		{
			get { return _groupID; }
			set { _groupID = value; }
		}
		private void GroupsItems_Load(object sender, EventArgs e)
		{
			
		}

		private void GroupsItems_Click(object sender, EventArgs e)
		{
			if (_isSelected == false)
			{
				_isSelected = true;
				//ColorTransition1.AutoTransition = true;
				this.BackColor = Color.SeaGreen;
				SharedData.GroupsSelected.Add(Convert.ToInt32(GroupID));



				//style the user item
				//change the lable font 
				//this.lblUserName.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
			}
			// handle if the user is not selected
			else if (_isSelected == true)
			{
				_isSelected = false;
				this.BackColor = Color.FromArgb(51, 65, 92);
				//ColorTransition1.AutoTransition = false;
				SharedData.GroupsSelected.Remove(Convert.ToInt32(GroupID));
			}
		}
	}
}

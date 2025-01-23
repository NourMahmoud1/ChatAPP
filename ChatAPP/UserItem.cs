using ChatAPP.BL;
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


	public partial class UserItem : UserControl
	{
		public UserItem()
		{
			InitializeComponent();
		}
		private bool _isSelected = false;
		#region Getter & setter for Label
		private string _userName;
		private string _userEmail;
		public string _userID = "1";

		[Category("Custom Props")]
		public string UserName
		{
			get { return _userName; }
			set { _userName = value; lblUserName.Text = value; }
		}
		[Category("Custom Props")]
		public string UserEmail
		{
			get { return _userEmail; }
			set { _userEmail = value; lblUserMail.Text = value; }
		}
		public string UserID
		{
			get { return _userID; }
			set { _userID = value; }
		}
		#endregion
		public List<int> usersSelected;
		private void UserItem_Load(object sender, EventArgs e)
		{

		}

		private void UserItem_Click(object sender, EventArgs e)
		{

			// handle if the user is selected 
			//if (bunifuColorTransition1.AutoTransition == false)
			if (_isSelected == false)
			{
				_isSelected = true;
				// set the color to the UserItems
				

				//bunifuColorTransition1.AutoTransition = true;
				this.BackColor = Color.SeaGreen;
				SharedData.UsersSelected.Add(Convert.ToInt32(UserID));



				//style the user item
				//change the lable font 
				//this.lblUserName.Font = new Font("Microsoft Sans Serif", 18, FontStyle.Bold);
			}
			// handle if the user is not selected
			else if (_isSelected == true)
			{
				_isSelected = false;
				this.BackColor = Color.FromArgb(51, 65, 92);
				bunifuColorTransition1.AutoTransition = false;
				SharedData.UsersSelected.Remove(Convert.ToInt32(UserID));
			}
		}

	}
}

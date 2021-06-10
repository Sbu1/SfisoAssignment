using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
	public partial class Login : Form
	{

		SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB; Initial catalog=atm; integrated security=true");

		public Login()
		{
			InitializeComponent();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.ToLower();
			string password = txtpassword.Text;


			if (username.Count() < 3 || password.Count() < 4)
			{
				MessageBox.Show("Username should be greater 2 and password greater than 4");
				return;
			}

			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select 1 FROM UserInfo WHERE Username = @username AND Password = @password";
			cmd.Parameters.AddWithValue("@username", username);
			cmd.Parameters.AddWithValue("@password", password);
			
			try
			{
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				if (dt.Rows.Count == 1)
				{
					MessageBox.Show("You have successful logged in");
					MainMenu mainMenu = new MainMenu();
					mainMenu.Username = txtUsername.Text;
					mainMenu.Show();
					this.Hide();
				}
				else
				{
					MessageBox.Show("Invalid username or password");
				}
			}

			catch
			{
				MessageBox.Show("Something went wrong while try to login you in. Please try again");
			}
		}
	}
}

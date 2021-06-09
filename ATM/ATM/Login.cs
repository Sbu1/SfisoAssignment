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
			string username = txtUsername.Text;
			string password = txtpassword.Text;

			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select 1 FROM UserInfo WHERE Username = @username AND Password = @password";
			cmd.Parameters.AddWithValue("@username", username);
			cmd.Parameters.AddWithValue("@password", password);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);

			try
			{
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
				MessageBox.Show("Invalid username or password");
			}
		}
	}
}

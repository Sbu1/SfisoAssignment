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
	public partial class Withdrawal : Form
	{
		SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB; Initial catalog=atm; integrated security=true");

		public string Username { get; set; }
		public double balance { get; set; }
		public Withdrawal()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int amount;
			try
			{
				amount = Convert.ToInt32(txtAmount.Text);
			}

			catch
			{
				MessageBox.Show("Please enter a valid amount");
				return;
			}


			if (amount > balance)
			{
				MessageBox.Show("You have insufficient funds");
				return;
			}

			double newBalance = balance - amount;

			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "UPDATE UserBalance SET Balance = @newBalance WHERE UserName = @UserName";
			cmd.Parameters.AddWithValue("@newBalance", newBalance);
			cmd.Parameters.AddWithValue("@UserName", Username);

			try
			{
				SqlDataAdapter da = new SqlDataAdapter(cmd);
				DataTable dt = new DataTable();
				da.Fill(dt);
				MessageBox.Show("You have successful withdrawn " + amount + ". Your new balance is " + newBalance);
				MainMenu mainMenu = new MainMenu();
				mainMenu.Username = Username;
				mainMenu.Show();
				this.Hide();
			}
			catch
			{
				MessageBox.Show("Something went wrong while trying to withdraw your money. Please try again later");
				MainMenu mainMenu = new MainMenu();
				mainMenu.Username = Username;
				mainMenu.Show();
			}				
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}

		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
			mainMenu.Username = Username;
			this.Hide();
		}
	}
}

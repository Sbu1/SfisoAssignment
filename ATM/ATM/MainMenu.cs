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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ATM
{
	public partial class MainMenu : Form
	{

		SqlConnection connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB; Initial catalog=atm; integrated security=true");
		public string Username { get; set; }
		public MainMenu()
		{
			InitializeComponent();
		}

		private void btnWithdrawal_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "Select Balance FROM UserBalance WHERE Username = @username";
			cmd.Parameters.AddWithValue("@username", Username);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);


			if (dt.Rows.Count == 1)
			{
				var balance = Convert.ToDouble(dt.Rows[0].ItemArray[0]);
				Withdrawal withdrawal = new Withdrawal();
				withdrawal.Username = Username;
				withdrawal.balance = balance;
				withdrawal.Show();
				this.Hide();
			}
		}

		private void btnLogOut_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			SqlCommand cmd = connection.CreateCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "SELECT username, B.Name, balance FROM UserBalance UB INNER JOIN Bank B on B.Name = ub.Name WHERE Username = @username";
			cmd.Parameters.AddWithValue("@username", Username);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);


			if (dt.Rows.Count == 1)
			{
				var username = dt.Rows[0].ItemArray[0].ToString();
				var bankname = dt.Rows[0].ItemArray[1].ToString();
				var balance = Convert.ToDouble(dt.Rows[0].ItemArray[2]);

				AccountDetails accountDetails = new AccountDetails();
				accountDetails.Username = username;
				accountDetails.BankName = bankname;
				accountDetails.Balance = balance;
				accountDetails.ManualInitialize();
				accountDetails.Show();
				this.Hide();

			}
		}
	}
}

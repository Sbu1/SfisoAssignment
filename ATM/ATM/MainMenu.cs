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
	}
}

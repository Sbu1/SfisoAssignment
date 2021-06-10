using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
	public partial class AccountDetails : Form
	{
		public string Username { get; set; }
		public string BankName { get; set; }
		public double Balance { get; set; }
		public AccountDetails()
		{
			InitializeComponent();
		}

		public void ManualInitialize()
		{
			lblBalanceResponse.Text = Balance.ToString();
			lblBankResponse.Text = BankName;
			lblUserNResponse.Text = Username;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void btnPrint_Click(object sender, EventArgs e)
		{
			try
			{
				PrintDocument pd = new PrintDocument();
				pd.PrintPage += new PrintPageEventHandler(pd_PrintPage);
				pd.Print();
			}
			catch (Exception ex)
			{
				
			}
		}
		void pd_PrintPage(object sender, PrintPageEventArgs e)
		{
			e.Graphics.DrawString("Acount Details", new System.Drawing.Font("Arial", 20), new SolidBrush(Color.Black), 200, 10);
			e.Graphics.DrawString(lblUserName.Text, new System.Drawing.Font("Arial", 12), new SolidBrush(Color.Black), 10, 100);
			e.Graphics.DrawString(lblBank.Text, new System.Drawing.Font("Arial", 12), new SolidBrush(Color.Black), 10, 140);
			e.Graphics.DrawString(lblBalance.Text, new System.Drawing.Font("Arial", 12), new SolidBrush(Color.Black), 10, 180);
			e.Graphics.DrawString(lblUserNResponse.Text, new System.Drawing.Font("Arial", 12), new SolidBrush(Color.Blue), 200, 100);
			e.Graphics.DrawString(lblBankResponse.Text, new System.Drawing.Font("Arial", 12), new SolidBrush(Color.Blue), 200, 140);
			e.Graphics.DrawString(lblBalanceResponse.Text, new System.Drawing.Font("Arial", 12), new SolidBrush(Color.Blue), 200, 180);
		}

		private void btnMainMenu_Click(object sender, EventArgs e)
		{
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
			mainMenu.Username = Username;
			this.Hide();
		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			Login login = new Login();
			login.Show();
			this.Hide();
		}
	}
}

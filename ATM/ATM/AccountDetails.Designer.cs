
namespace ATM
{
	partial class AccountDetails
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.btnPrint = new System.Windows.Forms.Button();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblBank = new System.Windows.Forms.Label();
			this.lblBalance = new System.Windows.Forms.Label();
			this.lblUserNResponse = new System.Windows.Forms.Label();
			this.lblBalanceResponse = new System.Windows.Forms.Label();
			this.lblBankResponse = new System.Windows.Forms.Label();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(571, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(249, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Account Details ";
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(527, 787);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(319, 75);
			this.btnPrint.TabIndex = 2;
			this.btnPrint.Text = "Print";
			this.btnPrint.UseVisualStyleBackColor = true;
			this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(155, 246);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(492, 111);
			this.lblUserName.TabIndex = 3;
			this.lblUserName.Text = "Username";
			// 
			// lblBank
			// 
			this.lblBank.AutoSize = true;
			this.lblBank.Location = new System.Drawing.Point(155, 387);
			this.lblBank.Name = "lblBank";
			this.lblBank.Size = new System.Drawing.Size(270, 111);
			this.lblBank.TabIndex = 4;
			this.lblBank.Text = "Bank";
			// 
			// lblBalance
			// 
			this.lblBalance.AutoSize = true;
			this.lblBalance.Location = new System.Drawing.Point(155, 537);
			this.lblBalance.Name = "lblBalance";
			this.lblBalance.Size = new System.Drawing.Size(396, 111);
			this.lblBalance.TabIndex = 5;
			this.lblBalance.Text = "Balance";
			// 
			// lblUserNResponse
			// 
			this.lblUserNResponse.AutoSize = true;
			this.lblUserNResponse.Location = new System.Drawing.Point(1013, 262);
			this.lblUserNResponse.Name = "lblUserNResponse";
			this.lblUserNResponse.Size = new System.Drawing.Size(102, 37);
			this.lblUserNResponse.TabIndex = 6;
			this.lblUserNResponse.Text = "label2";
			// 
			// lblBalanceResponse
			// 
			this.lblBalanceResponse.AutoSize = true;
			this.lblBalanceResponse.Location = new System.Drawing.Point(1013, 568);
			this.lblBalanceResponse.Name = "lblBalanceResponse";
			this.lblBalanceResponse.Size = new System.Drawing.Size(102, 37);
			this.lblBalanceResponse.TabIndex = 7;
			this.lblBalanceResponse.Text = "label3";
			// 
			// lblBankResponse
			// 
			this.lblBankResponse.AutoSize = true;
			this.lblBankResponse.Location = new System.Drawing.Point(1013, 423);
			this.lblBankResponse.Name = "lblBankResponse";
			this.lblBankResponse.Size = new System.Drawing.Size(102, 37);
			this.lblBankResponse.TabIndex = 8;
			this.lblBankResponse.Text = "label5";
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Location = new System.Drawing.Point(114, 1052);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(268, 96);
			this.btnMainMenu.TabIndex = 9;
			this.btnMainMenu.Text = "Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(1097, 1046);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(261, 108);
			this.btnLogout.TabIndex = 10;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// AccountDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1492, 1236);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.lblBankResponse);
			this.Controls.Add(this.lblBalanceResponse);
			this.Controls.Add(this.lblUserNResponse);
			this.Controls.Add(this.lblBalance);
			this.Controls.Add(this.lblBank);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.label1);
			this.Name = "AccountDetails";
			this.Text = "AccountDetails";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblBank;
		private System.Windows.Forms.Label lblBalance;
		private System.Windows.Forms.Label lblUserNResponse;
		private System.Windows.Forms.Label lblBalanceResponse;
		private System.Windows.Forms.Label lblBankResponse;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.Button btnLogout;
	}
}
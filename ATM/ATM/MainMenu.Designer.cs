
namespace ATM
{
	partial class MainMenu
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
			this.btnWithdrawal = new System.Windows.Forms.Button();
			this.btnPrint = new System.Windows.Forms.Button();
			this.btnLogOut = new System.Windows.Forms.Button();
			this.printDialog1 = new System.Windows.Forms.PrintDialog();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnWithdrawal
			// 
			this.btnWithdrawal.Location = new System.Drawing.Point(866, 414);
			this.btnWithdrawal.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.btnWithdrawal.Name = "btnWithdrawal";
			this.btnWithdrawal.Size = new System.Drawing.Size(716, 131);
			this.btnWithdrawal.TabIndex = 0;
			this.btnWithdrawal.Text = "Withdrawal ";
			this.btnWithdrawal.UseVisualStyleBackColor = true;
			this.btnWithdrawal.Click += new System.EventHandler(this.btnWithdrawal_Click);
			// 
			// btnPrint
			// 
			this.btnPrint.Location = new System.Drawing.Point(880, 688);
			this.btnPrint.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.btnPrint.Name = "btnPrint";
			this.btnPrint.Size = new System.Drawing.Size(716, 125);
			this.btnPrint.TabIndex = 1;
			this.btnPrint.Text = "Print Acount Details";
			this.btnPrint.UseVisualStyleBackColor = true;
			// 
			// btnLogOut
			// 
			this.btnLogOut.Location = new System.Drawing.Point(880, 974);
			this.btnLogOut.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.btnLogOut.Name = "btnLogOut";
			this.btnLogOut.Size = new System.Drawing.Size(716, 114);
			this.btnLogOut.TabIndex = 2;
			this.btnLogOut.Text = "Logout";
			this.btnLogOut.UseVisualStyleBackColor = true;
			this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
			// 
			// printDialog1
			// 
			this.printDialog1.UseEXDialog = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(1123, 153);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(174, 37);
			this.label1.TabIndex = 3;
			this.label1.Text = "Main Menu";
			// 
			// MainMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(2411, 1523);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLogOut);
			this.Controls.Add(this.btnPrint);
			this.Controls.Add(this.btnWithdrawal);
			this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.Name = "MainMenu";
			this.Text = "MainMenu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnWithdrawal;
		private System.Windows.Forms.Button btnPrint;
		private System.Windows.Forms.Button btnLogOut;
		private System.Windows.Forms.PrintDialog printDialog1;
		private System.Windows.Forms.Label label1;
	}
}
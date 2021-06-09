
namespace ATM
{
	partial class Withdrawal
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
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAmount = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.btnMainMenu = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(782, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "ATM";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(706, 712);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(336, 105);
			this.button1.TabIndex = 3;
			this.button1.Text = "Withdraw";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(202, 373);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(301, 37);
			this.label3.TabIndex = 4;
			this.label3.Text = "Amount to withdraw";
			// 
			// txtAmount
			// 
			this.txtAmount.Location = new System.Drawing.Point(1165, 355);
			this.txtAmount.Name = "txtAmount";
			this.txtAmount.Size = new System.Drawing.Size(428, 44);
			this.txtAmount.TabIndex = 5;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(782, 640);
			this.lblResult.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(0, 37);
			this.lblResult.TabIndex = 6;
			// 
			// btnMainMenu
			// 
			this.btnMainMenu.Location = new System.Drawing.Point(136, 914);
			this.btnMainMenu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.btnMainMenu.Name = "btnMainMenu";
			this.btnMainMenu.Size = new System.Drawing.Size(367, 85);
			this.btnMainMenu.TabIndex = 7;
			this.btnMainMenu.Text = "Go to Main Menu";
			this.btnMainMenu.UseVisualStyleBackColor = true;
			this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Location = new System.Drawing.Point(1226, 914);
			this.btnLogout.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(367, 85);
			this.btnLogout.TabIndex = 8;
			this.btnLogout.Text = "Logout";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// Withdrawal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1859, 1062);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.btnMainMenu);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.txtAmount);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Name = "Withdrawal";
			this.Text = "Form2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAmount;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Button btnMainMenu;
		private System.Windows.Forms.Button btnLogout;
	}
}
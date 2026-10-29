using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // Title Bar Controls
        private Panel panelTitleBar;
        private Label lblBusIcon;
        private Label lblAppTitle;
        private Button btnMinimize;
        private Button btnClose;

        // Main Login Container
        private Panel panelMain;
        private ProfileAvatar avatarProfile;
        private Label lblWelcome;
        private Label lblSubWelcome;
        private Label lblEmailLabel;
        private ModernTextBox txtEmail;
        private Label lblPasswordLabel;
        private ModernTextBox txtPassword;
        private Label lblForgotPassword;
        private ModernButton btnLogin;
        private Panel panelDivider;
        private Label lblOrText;
        private ModernButton btnGuest;
        private ModernButton btnDriver;
        private FlowLayoutPanel flowRegister;
        private Label lblNoAccount;
        private Label lblRegisterNow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblBusIcon = new System.Windows.Forms.Label();
            this.lblAppTitle = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelMain = new System.Windows.Forms.Panel();
            this.avatarProfile = new Bus_Ticket_mgmt.ProfileAvatar();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblSubWelcome = new System.Windows.Forms.Label();
            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new Bus_Ticket_mgmt.ModernTextBox();
            this.lblPasswordLabel = new System.Windows.Forms.Label();
            this.txtPassword = new Bus_Ticket_mgmt.ModernTextBox();
            this.lblForgotPassword = new System.Windows.Forms.Label();
            this.btnLogin = new Bus_Ticket_mgmt.ModernButton();
            this.panelDivider = new System.Windows.Forms.Panel();
            this.lblOrText = new System.Windows.Forms.Label();
            this.btnGuest = new Bus_Ticket_mgmt.ModernButton();
            this.btnDriver = new Bus_Ticket_mgmt.ModernButton();
            this.flowRegister = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNoAccount = new System.Windows.Forms.Label();
            this.lblRegisterNow = new System.Windows.Forms.Label();

            this.panelTitleBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelDivider.SuspendLayout();
            this.flowRegister.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.White;
            this.panelTitleBar.Controls.Add(this.lblBusIcon);
            this.panelTitleBar.Controls.Add(this.lblAppTitle);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Height = 36;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(460, 36);
            this.panelTitleBar.TabIndex = 0;

            // 
            // lblBusIcon
            // 
            this.lblBusIcon.Location = new System.Drawing.Point(12, 0);
            this.lblBusIcon.Name = "lblBusIcon";
            this.lblBusIcon.Size = new System.Drawing.Size(28, 36);
            this.lblBusIcon.TabIndex = 0;

            // 
            // lblAppTitle
            // 
            this.lblAppTitle.AutoSize = true;
            this.lblAppTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAppTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblAppTitle.Location = new System.Drawing.Point(44, 10);
            this.lblAppTitle.Name = "lblAppTitle";
            this.lblAppTitle.Size = new System.Drawing.Size(138, 15);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "Bus Ticket Management";

            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnMinimize.Location = new System.Drawing.Point(368, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;

            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnClose.Location = new System.Drawing.Point(414, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.avatarProfile);
            this.panelMain.Controls.Add(this.lblWelcome);
            this.panelMain.Controls.Add(this.lblSubWelcome);
            this.panelMain.Controls.Add(this.lblEmailLabel);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.lblPasswordLabel);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.lblForgotPassword);
            this.panelMain.Controls.Add(this.btnLogin);
            this.panelMain.Controls.Add(this.panelDivider);
            this.panelMain.Controls.Add(this.btnGuest);
            this.panelMain.Controls.Add(this.btnDriver);
            this.panelMain.Controls.Add(this.flowRegister);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 36);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(460, 564);
            this.panelMain.TabIndex = 1;

            // 
            // avatarProfile
            // 
            this.avatarProfile.Location = new System.Drawing.Point(196, 20);
            this.avatarProfile.Name = "avatarProfile";
            this.avatarProfile.Size = new System.Drawing.Size(68, 68);
            this.avatarProfile.TabIndex = 0;

            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblWelcome.Location = new System.Drawing.Point(10, 94);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(440, 38);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome Back!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblSubWelcome
            // 
            this.lblSubWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubWelcome.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubWelcome.Location = new System.Drawing.Point(10, 134);
            this.lblSubWelcome.Name = "lblSubWelcome";
            this.lblSubWelcome.Size = new System.Drawing.Size(440, 24);
            this.lblSubWelcome.TabIndex = 2;
            this.lblSubWelcome.Text = "Please login to your account";
            this.lblSubWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblEmailLabel.Location = new System.Drawing.Point(40, 172);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(126, 17);
            this.lblEmailLabel.TabIndex = 3;
            this.lblEmailLabel.Text = "Email or Username";

            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(40, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(380, 44);
            this.txtEmail.TabIndex = 4;

            // 
            // lblPasswordLabel
            // 
            this.lblPasswordLabel.AutoSize = true;
            this.lblPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPasswordLabel.Location = new System.Drawing.Point(40, 250);
            this.lblPasswordLabel.Name = "lblPasswordLabel";
            this.lblPasswordLabel.Size = new System.Drawing.Size(66, 17);
            this.lblPasswordLabel.TabIndex = 5;
            this.lblPasswordLabel.Text = "Password";

            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(40, 274);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(380, 44);
            this.txtPassword.TabIndex = 6;

            // 
            // lblForgotPassword
            // 
            this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgotPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForgotPassword.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblForgotPassword.Location = new System.Drawing.Point(290, 324);
            this.lblForgotPassword.Name = "lblForgotPassword";
            this.lblForgotPassword.Size = new System.Drawing.Size(130, 20);
            this.lblForgotPassword.TabIndex = 7;
            this.lblForgotPassword.Text = "Forgot Password?";
            this.lblForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // btnLogin
            // 
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(40, 354);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(380, 46);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;

            // 
            // panelDivider
            // 
            this.panelDivider.Controls.Add(this.lblOrText);
            this.panelDivider.Location = new System.Drawing.Point(40, 412);
            this.panelDivider.Name = "panelDivider";
            this.panelDivider.Size = new System.Drawing.Size(380, 24);
            this.panelDivider.TabIndex = 9;

            // 
            // lblOrText
            // 
            this.lblOrText.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrText.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.lblOrText.Location = new System.Drawing.Point(165, 0);
            this.lblOrText.Name = "lblOrText";
            this.lblOrText.Size = new System.Drawing.Size(50, 24);
            this.lblOrText.TabIndex = 0;
            this.lblOrText.Text = "OR";
            this.lblOrText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnGuest
            // 
            this.btnGuest.FlatAppearance.BorderSize = 0;
            this.btnGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuest.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGuest.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnGuest.Location = new System.Drawing.Point(40, 444);
            this.btnGuest.Name = "btnGuest";
            this.btnGuest.Size = new System.Drawing.Size(380, 46);
            this.btnGuest.TabIndex = 10;
            this.btnGuest.Text = "Login as Passenger";
            this.btnGuest.UseVisualStyleBackColor = true;

            // 
            // btnDriver
            // 
            this.btnDriver.FlatAppearance.BorderSize = 0;
            this.btnDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriver.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDriver.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnDriver.Location = new System.Drawing.Point(40, 498);
            this.btnDriver.Name = "btnDriver";
            this.btnDriver.Size = new System.Drawing.Size(380, 46);
            this.btnDriver.TabIndex = 11;
            this.btnDriver.Text = "Login as Driver";
            this.btnDriver.UseVisualStyleBackColor = true;

            // 
            // flowRegister
            // 
            this.flowRegister.Controls.Add(this.lblNoAccount);
            this.flowRegister.Controls.Add(this.lblRegisterNow);
            this.flowRegister.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowRegister.Location = new System.Drawing.Point(40, 554);
            this.flowRegister.Name = "flowRegister";
            this.flowRegister.Size = new System.Drawing.Size(380, 30);
            this.flowRegister.TabIndex = 12;

            // 
            // lblNoAccount
            // 
            this.lblNoAccount.AutoSize = true;
            this.lblNoAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNoAccount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblNoAccount.Location = new System.Drawing.Point(65, 4);
            this.lblNoAccount.Margin = new System.Windows.Forms.Padding(65, 4, 0, 0);
            this.lblNoAccount.Name = "lblNoAccount";
            this.lblNoAccount.Size = new System.Drawing.Size(148, 17);
            this.lblNoAccount.TabIndex = 0;
            this.lblNoAccount.Text = "Don't have an account? ";

            // 
            // lblRegisterNow
            // 
            this.lblRegisterNow.AutoSize = true;
            this.lblRegisterNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRegisterNow.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegisterNow.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblRegisterNow.Location = new System.Drawing.Point(213, 4);
            this.lblRegisterNow.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblRegisterNow.Name = "lblRegisterNow";
            this.lblRegisterNow.Size = new System.Drawing.Size(90, 17);
            this.lblRegisterNow.TabIndex = 1;
            this.lblRegisterNow.Text = "Register Now";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(460, 650);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 650);
            this.MinimumSize = new System.Drawing.Size(460, 650);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Ticket Management - Login";

            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelDivider.ResumeLayout(false);
            this.flowRegister.ResumeLayout(false);
            this.flowRegister.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

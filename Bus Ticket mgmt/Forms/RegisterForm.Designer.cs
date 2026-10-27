using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;

        // Title Bar
        private Panel panelTitleBar;
        private Label lblBusIcon;
        private Label lblAppTitle;
        private Button btnMinimize;
        private Button btnClose;

        // Main Content
        private Panel panelMain;
        private ProfileAvatar avatarProfile;
        private Label lblTitle;
        private Label lblSubtitle;

        private Label lblFullNameLabel;
        private ModernTextBox txtFullName;

        private Label lblEmailLabel;
        private ModernTextBox txtEmail;

        private Label lblPhoneLabel;
        private ModernTextBox txtPhone;

        private Label lblPasswordLabel;
        private ModernTextBox txtPassword;

        private Label lblConfirmPasswordLabel;
        private ModernTextBox txtConfirmPassword;

        private ModernButton btnRegister;

        private FlowLayoutPanel flowLoginLink;
        private Label lblHaveAccount;
        private Label lblLoginNow;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();

            this.lblFullNameLabel = new System.Windows.Forms.Label();
            this.txtFullName = new Bus_Ticket_mgmt.ModernTextBox();

            this.lblEmailLabel = new System.Windows.Forms.Label();
            this.txtEmail = new Bus_Ticket_mgmt.ModernTextBox();

            this.lblPhoneLabel = new System.Windows.Forms.Label();
            this.txtPhone = new Bus_Ticket_mgmt.ModernTextBox();

            this.lblPasswordLabel = new System.Windows.Forms.Label();
            this.txtPassword = new Bus_Ticket_mgmt.ModernTextBox();

            this.lblConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new Bus_Ticket_mgmt.ModernTextBox();

            this.btnRegister = new Bus_Ticket_mgmt.ModernButton();

            this.flowLoginLink = new System.Windows.Forms.FlowLayoutPanel();
            this.lblHaveAccount = new System.Windows.Forms.Label();
            this.lblLoginNow = new System.Windows.Forms.Label();

            this.panelTitleBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flowLoginLink.SuspendLayout();
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
            this.panelTitleBar.Size = new System.Drawing.Size(480, 36);
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
            this.lblAppTitle.Size = new System.Drawing.Size(188, 15);
            this.lblAppTitle.TabIndex = 1;
            this.lblAppTitle.Text = "Bus Ticket Management - Register";

            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnMinimize.Location = new System.Drawing.Point(388, 0);
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
            this.btnClose.Location = new System.Drawing.Point(434, 0);
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
            this.panelMain.Controls.Add(this.lblTitle);
            this.panelMain.Controls.Add(this.lblSubtitle);
            this.panelMain.Controls.Add(this.lblFullNameLabel);
            this.panelMain.Controls.Add(this.txtFullName);
            this.panelMain.Controls.Add(this.lblEmailLabel);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Controls.Add(this.lblPhoneLabel);
            this.panelMain.Controls.Add(this.txtPhone);
            this.panelMain.Controls.Add(this.lblPasswordLabel);
            this.panelMain.Controls.Add(this.txtPassword);
            this.panelMain.Controls.Add(this.lblConfirmPasswordLabel);
            this.panelMain.Controls.Add(this.txtConfirmPassword);
            this.panelMain.Controls.Add(this.btnRegister);
            this.panelMain.Controls.Add(this.flowLoginLink);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 36);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(480, 684);
            this.panelMain.TabIndex = 1;

            // 
            // avatarProfile
            // 
            this.avatarProfile.Location = new System.Drawing.Point(208, 14);
            this.avatarProfile.Name = "avatarProfile";
            this.avatarProfile.Size = new System.Drawing.Size(64, 64);
            this.avatarProfile.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTitle.Location = new System.Drawing.Point(10, 82);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(460, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Create an Account";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblSubtitle.Location = new System.Drawing.Point(10, 116);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(460, 20);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Sign up to book and manage your trips easily";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblFullNameLabel
            // 
            this.lblFullNameLabel.AutoSize = true;
            this.lblFullNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFullNameLabel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblFullNameLabel.Location = new System.Drawing.Point(45, 146);
            this.lblFullNameLabel.Name = "lblFullNameLabel";
            this.lblFullNameLabel.Size = new System.Drawing.Size(62, 15);
            this.lblFullNameLabel.TabIndex = 3;
            this.lblFullNameLabel.Text = "Full Name";

            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.White;
            this.txtFullName.Location = new System.Drawing.Point(45, 166);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(390, 42);
            this.txtFullName.TabIndex = 4;

            // 
            // lblEmailLabel
            // 
            this.lblEmailLabel.AutoSize = true;
            this.lblEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailLabel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblEmailLabel.Location = new System.Drawing.Point(45, 218);
            this.lblEmailLabel.Name = "lblEmailLabel";
            this.lblEmailLabel.Size = new System.Drawing.Size(84, 15);
            this.lblEmailLabel.TabIndex = 5;
            this.lblEmailLabel.Text = "Email Address";

            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Location = new System.Drawing.Point(45, 238);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(390, 42);
            this.txtEmail.TabIndex = 6;

            // 
            // lblPhoneLabel
            // 
            this.lblPhoneLabel.AutoSize = true;
            this.lblPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPhoneLabel.Location = new System.Drawing.Point(45, 290);
            this.lblPhoneLabel.Name = "lblPhoneLabel";
            this.lblPhoneLabel.Size = new System.Drawing.Size(91, 15);
            this.lblPhoneLabel.TabIndex = 7;
            this.lblPhoneLabel.Text = "Phone Number";

            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(45, 310);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(390, 42);
            this.txtPhone.TabIndex = 8;

            // 
            // lblPasswordLabel
            // 
            this.lblPasswordLabel.AutoSize = true;
            this.lblPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPasswordLabel.Location = new System.Drawing.Point(45, 362);
            this.lblPasswordLabel.Name = "lblPasswordLabel";
            this.lblPasswordLabel.Size = new System.Drawing.Size(59, 15);
            this.lblPasswordLabel.TabIndex = 9;
            this.lblPasswordLabel.Text = "Password";

            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(45, 382);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(390, 42);
            this.txtPassword.TabIndex = 10;

            // 
            // lblConfirmPasswordLabel
            // 
            this.lblConfirmPasswordLabel.AutoSize = true;
            this.lblConfirmPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConfirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblConfirmPasswordLabel.Location = new System.Drawing.Point(45, 434);
            this.lblConfirmPasswordLabel.Name = "lblConfirmPasswordLabel";
            this.lblConfirmPasswordLabel.Size = new System.Drawing.Size(107, 15);
            this.lblConfirmPasswordLabel.TabIndex = 11;
            this.lblConfirmPasswordLabel.Text = "Confirm Password";

            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.White;
            this.txtConfirmPassword.Location = new System.Drawing.Point(45, 454);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(390, 42);
            this.txtConfirmPassword.TabIndex = 12;

            // 
            // btnRegister
            // 
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(45, 520);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(390, 46);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Create Account";
            this.btnRegister.UseVisualStyleBackColor = true;

            // 
            // flowLoginLink
            // 
            this.flowLoginLink.Controls.Add(this.lblHaveAccount);
            this.flowLoginLink.Controls.Add(this.lblLoginNow);
            this.flowLoginLink.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLoginLink.Location = new System.Drawing.Point(45, 586);
            this.flowLoginLink.Name = "flowLoginLink";
            this.flowLoginLink.Size = new System.Drawing.Size(390, 30);
            this.flowLoginLink.TabIndex = 14;

            // 
            // lblHaveAccount
            // 
            this.lblHaveAccount.AutoSize = true;
            this.lblHaveAccount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHaveAccount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHaveAccount.Location = new System.Drawing.Point(75, 4);
            this.lblHaveAccount.Margin = new System.Windows.Forms.Padding(75, 4, 0, 0);
            this.lblHaveAccount.Name = "lblHaveAccount";
            this.lblHaveAccount.Size = new System.Drawing.Size(161, 17);
            this.lblHaveAccount.TabIndex = 0;
            this.lblHaveAccount.Text = "Already have an account? ";

            // 
            // lblLoginNow
            // 
            this.lblLoginNow.AutoSize = true;
            this.lblLoginNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLoginNow.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginNow.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblLoginNow.Location = new System.Drawing.Point(236, 4);
            this.lblLoginNow.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.lblLoginNow.Name = "lblLoginNow";
            this.lblLoginNow.Size = new System.Drawing.Size(46, 17);
            this.lblLoginNow.TabIndex = 1;
            this.lblLoginNow.Text = "Log In";

            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(480, 720);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 720);
            this.MinimumSize = new System.Drawing.Size(480, 720);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Ticket Management - Register";

            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.flowLoginLink.ResumeLayout(false);
            this.flowLoginLink.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

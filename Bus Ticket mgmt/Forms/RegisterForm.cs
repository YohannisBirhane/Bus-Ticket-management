using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            InitializeCustomUI();
            SetupEvents();
        }

        private void InitializeCustomUI()
        {
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.IconType = InputIconType.User;

            txtEmail.PlaceholderText = "Enter your email address";
            txtEmail.IconType = InputIconType.Email;

            txtPhone.PlaceholderText = "+251 911 123 456";
            txtPhone.IconType = InputIconType.Phone;

            txtPassword.PlaceholderText = "Create a password";
            txtPassword.IconType = InputIconType.Lock;
            txtPassword.IsPassword = true;

            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.IconType = InputIconType.Lock;
            txtConfirmPassword.IsPassword = true;

            btnRegister.NormalColor = Color.FromArgb(13, 94, 234);
            btnRegister.HoverColor = Color.FromArgb(11, 79, 196);
            btnRegister.PressedColor = Color.FromArgb(9, 66, 166);
            btnRegister.ButtonIcon = ButtonIconType.Register;

            // Draw vector bus icon
            lblBusIcon.Paint += (s, e) =>
            {
                IconRenderer.DrawBusIcon(e.Graphics, 2, 8, 20, Color.FromArgb(30, 58, 138));
            };

            // Window close button hover transitions
            btnClose.MouseEnter += (s, e) => { btnClose.BackColor = Color.FromArgb(239, 68, 68); btnClose.ForeColor = Color.White; };
            btnClose.MouseLeave += (s, e) => { btnClose.BackColor = Color.White; btnClose.ForeColor = Color.FromArgb(71, 85, 105); };

            btnMinimize.MouseEnter += (s, e) => { btnMinimize.BackColor = Color.FromArgb(241, 245, 249); };
            btnMinimize.MouseLeave += (s, e) => { btnMinimize.BackColor = Color.White; };
        }

        private void SetupEvents()
        {
            // Allow dragging the window from Title Bar or Background
            panelTitleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            lblAppTitle.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            panelMain.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            // Window control actions
            btnClose.Click += (s, e) => this.Close();
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            // Redirect back to Login
            lblLoginNow.Click += (s, e) =>
            {
                this.Close();
            };

            // Register button action
            btnRegister.Click += (s, e) =>
            {
                string fullName = txtFullName.InputText.Trim();
                string email = txtEmail.InputText.Trim();
                string phone = txtPhone.InputText.Trim();
                string pass = txtPassword.InputText;
                string confirmPass = txtConfirmPassword.InputText;

                if (string.IsNullOrEmpty(fullName))
                {
                    MessageBox.Show("Please enter your full name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(email))
                {
                    MessageBox.Show("Please enter your email address.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(phone))
                {
                    MessageBox.Show("Please enter your phone number.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please enter a password.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pass.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (pass != confirmPass)
                {
                    MessageBox.Show("Passwords do not match. Please re-enter your password.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Account created successfully for {fullName}!\nYou can now log in.", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen borderPen = new Pen(Color.FromArgb(203, 213, 225), 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

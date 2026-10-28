using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            InitializeCustomUI();
            SetupEvents();
        }

        private void InitializeCustomUI()
        {
            // Configure email & password custom inputs
            txtEmail.PlaceholderText = "Enter email or username";
            txtEmail.IconType = InputIconType.User;

            txtPassword.PlaceholderText = "Enter password";
            txtPassword.IconType = InputIconType.Lock;
            txtPassword.IsPassword = true;

            // Configure Login button
            btnLogin.NormalColor = Color.FromArgb(13, 94, 234);
            btnLogin.HoverColor = Color.FromArgb(11, 79, 196);
            btnLogin.PressedColor = Color.FromArgb(9, 66, 166);
            btnLogin.ButtonIcon = ButtonIconType.Login;

            // Configure Continue as Guest button
            btnGuest.NormalColor = Color.White;
            btnGuest.HoverColor = Color.FromArgb(239, 246, 255);
            btnGuest.PressedColor = Color.FromArgb(219, 234, 254);
            btnGuest.ForeColor = Color.FromArgb(13, 94, 234);
            btnGuest.BorderLineColor = Color.FromArgb(13, 94, 234);
            btnGuest.BorderSize = 1.4f;
            btnGuest.ButtonIcon = ButtonIconType.GuestUser;

            // Draw vector bus icon on Title Bar
            lblBusIcon.Paint += (s, e) =>
            {
                IconRenderer.DrawBusIcon(e.Graphics, 2, 8, 20, Color.FromArgb(30, 58, 138));
            };

            // Window close button hover transitions
            btnClose.MouseEnter += (s, e) => { btnClose.BackColor = Color.FromArgb(239, 68, 68); btnClose.ForeColor = Color.White; };
            btnClose.MouseLeave += (s, e) => { btnClose.BackColor = Color.White; btnClose.ForeColor = Color.FromArgb(71, 85, 105); };

            btnMinimize.MouseEnter += (s, e) => { btnMinimize.BackColor = Color.FromArgb(241, 245, 249); };
            btnMinimize.MouseLeave += (s, e) => { btnMinimize.BackColor = Color.White; };

            // Draw divider lines around "OR"
            panelDivider.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    int lineY = panelDivider.Height / 2;
                    e.Graphics.DrawLine(pen, 0, lineY, 160, lineY);
                    e.Graphics.DrawLine(pen, 220, lineY, 380, lineY);
                }
            };
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
            btnClose.Click += (s, e) => Application.Exit();
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;

            // Login button action
            btnLogin.Click += (s, e) =>
            {
                string user = txtEmail.InputText.Trim();
                string pass = txtPassword.InputText;

                if (string.IsNullOrEmpty(user))
                {
                    MessageBox.Show("Please enter your email or username.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(pass))
                {
                    MessageBox.Show("Please enter your password.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.Hide();
                using (var adminDashboard = new Bus_Ticket_mgmt.Forms.AdminDashboardForm())
                {
                    adminDashboard.ShowDialog(this);
                }
                this.Show();
            };

            // Passenger demo access uses in-memory trip and booking data.
            btnGuest.Click += (s, e) =>
            {
                this.Hide();
                using (var passengerDashboard = new Bus_Ticket_mgmt.Forms.PassengerDashboardForm())
                {
                    passengerDashboard.ShowDialog(this);
                }
                this.Show();
            };

            // Forgot password click action
            lblForgotPassword.Click += (s, e) =>
            {
                MessageBox.Show("Password reset instructions will be sent to your registered email.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Register now click action - redirect directly to RegisterForm
            lblRegisterNow.Click += (s, e) =>
            {
                this.Hide();
                using (var registerForm = new Bus_Ticket_mgmt.Forms.RegisterForm())
                {
                    registerForm.ShowDialog(this);
                }
                this.Show();
            };
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw crisp 1px border around the entire frameless window
            using (Pen borderPen = new Pen(Color.FromArgb(203, 213, 225), 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

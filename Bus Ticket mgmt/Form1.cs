using System;
using System.Drawing;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Services;

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
            txtEmail.PlaceholderText = "e.g. admin@gmail.com";
            txtEmail.IconType = InputIconType.User;

            txtPassword.PlaceholderText = "Enter password";
            txtPassword.IconType = InputIconType.Lock;
            txtPassword.IsPassword = true;

            // Configure Login button
            btnLogin.NormalColor = Color.FromArgb(13, 94, 234);
            btnLogin.HoverColor = Color.FromArgb(11, 79, 196);
            btnLogin.PressedColor = Color.FromArgb(9, 66, 166);
            btnLogin.ButtonIcon = ButtonIconType.Login;

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

            // Single unified Login button action
            btnLogin.Click += (s, e) => PerformLogin();

            // Support Enter key press inside text inputs
            txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    PerformLogin();
                }
            };
            txtEmail.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    PerformLogin();
                }
            };

            // Forgot password click action
            lblForgotPassword.Click += (s, e) =>
            {
                MessageBox.Show(
                    "Demo Passwords for all accounts:\n\n" +
                    "• Password: pass1234\n\n" +
                    "Registered User Portals:\n" +
                    "• Administrator:    admin@gmail.com\n" +
                    "• Ticket Officer:   officer@gmail.com\n" +
                    "• Bus Manager:      manager@gmail.com",
                    "System Credentials Guide",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            };

            // Register now click action
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

        private void PerformLogin()
        {
            string email = txtEmail.InputText;
            string pass = txtPassword.InputText;

            // Delegate authentication to the modular AuthService
            var authResult = AuthService.Authenticate(email, pass);
            if (!authResult.IsSuccess)
            {
                MessageBox.Show(authResult.ErrorMessage, "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            // Route to appropriate role portal based on authenticated role
            switch (authResult.Role)
            {
                case UserRole.Administrator:
                case UserRole.BusManager:
                    this.Hide();
                    using (var adminDashboard = new Bus_Ticket_mgmt.Forms.AdminDashboardForm())
                    {
                        adminDashboard.ShowDialog(this);
                    }
                    this.Show();
                    txtPassword.InputText = "";
                    break;

                case UserRole.TicketOfficer:
                    this.Hide();
                    using (var officerDashboard = new Bus_Ticket_mgmt.Forms.TicketOfficerDashboardForm())
                    {
                        officerDashboard.ShowDialog(this);
                    }
                    this.Show();
                    txtPassword.InputText = "";
                    break;

                default:
                    MessageBox.Show("Unknown user role or access restricted.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
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

using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class UserDialogForm : Form
    {
        private User? _existingUser = null;
        private bool _isEditMode = false;

        public UserDialogForm(User? userToEdit = null)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            _existingUser = userToEdit;
            _isEditMode = userToEdit != null;

            InitializeFormMode();
            SetupEvents();
        }

        private void InitializeFormMode()
        {
            if (_isEditMode && _existingUser != null)
            {
                lblDialogTitle.Text = $"Edit User Account ({_existingUser.UserId})";
                lblHeaderTitle.Text = $"Edit User: {_existingUser.FullName}";
                lblHeaderSubtitle.Text = "Modify user details, role permissions, or account status.";
                btnSave.Text = "Update Account";

                txtFullName.Text = _existingUser.FullName;
                txtUsername.Text = _existingUser.Username;
                txtEmail.Text = _existingUser.Email;
                txtPhone.Text = _existingUser.Phone;
                txtAddress.Text = _existingUser.Address;

                cmbRole.SelectedItem = _existingUser.Role;
                cmbStatus.SelectedItem = _existingUser.Status;

                lblPassword.Text = "New Password (Leave blank to keep)";
                lblConfirmPassword.Text = "Confirm New Password";
            }
            else
            {
                lblDialogTitle.Text = "Add New System User";
                lblHeaderTitle.Text = "Add New User";
                lblHeaderSubtitle.Text = "Fill in user personal details and assign role permissions.";
                btnSave.Text = "Create User";

                cmbRole.SelectedIndex = 1; // Default to Passenger
                cmbStatus.SelectedIndex = 0; // Default to Active
            }
        }

        private void SetupEvents()
        {
            // Title bar dragging
            panelTitleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            lblDialogTitle.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            // Close & cancel
            btnClose.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            btnClose.MouseEnter += (s, e) => { btnClose.BackColor = Color.FromArgb(239, 68, 68); btnClose.ForeColor = Color.White; };
            btnClose.MouseLeave += (s, e) => { btnClose.BackColor = Color.FromArgb(15, 23, 42); btnClose.ForeColor = Color.FromArgb(148, 163, 184); };

            // Save user button
            btnSave.Click += (s, e) => SaveUser();
        }

        private void SaveUser()
        {
            string fullName = txtFullName.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string address = txtAddress.Text.Trim();
            string role = cmbRole.SelectedItem?.ToString() ?? "";
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            string? excludeId = _isEditMode ? _existingUser?.UserId : null;

            // 1. Full name validation
            if (string.IsNullOrWhiteSpace(fullName))
            {
                MessageBox.Show("Full Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            // 2. Username validation
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (!UserStore.IsUsernameUnique(username, excludeId))
            {
                MessageBox.Show($"The username '{username}' is already in use by another account. Please choose a unique username.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            // 3. Email validation
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email Address cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Please enter a valid email address format (e.g. name@domain.com).", "Invalid Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (!UserStore.IsEmailUnique(email, excludeId))
            {
                MessageBox.Show($"The email address '{email}' is already registered to another account. Please enter a different email.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            // 4. Phone validation
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Phone Number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
                return;
            }

            // 5. Role selection validation
            if (string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("Please select an authorized role for this user account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }

            // 6. Password validation
            if (!_isEditMode)
            {
                if (string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Password is required when creating a new user account.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (password.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Passwords do not match. Please ensure both passwords match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtConfirmPassword.Focus();
                    return;
                }
            }
            else
            {
                // In edit mode, password is only updated if entered
                if (!string.IsNullOrEmpty(password))
                {
                    if (password.Length < 6)
                    {
                        MessageBox.Show("New password must be at least 6 characters long.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Focus();
                        return;
                    }

                    if (password != confirmPassword)
                    {
                        MessageBox.Show("New passwords do not match. Please re-enter.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtConfirmPassword.Focus();
                        return;
                    }
                }
            }

            // Perform Save / Update
            if (_isEditMode && _existingUser != null)
            {
                _existingUser.FullName = fullName;
                _existingUser.Username = username;
                _existingUser.Email = email;
                _existingUser.Phone = phone;
                _existingUser.Address = address;
                _existingUser.Role = role;
                _existingUser.Status = status;

                if (!string.IsNullOrEmpty(password))
                {
                    _existingUser.Password = password;
                }

                UserStore.Update(_existingUser);
                MessageBox.Show($"User account '{fullName}' ({_existingUser.UserId}) updated successfully!", "Account Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                User newUser = new User(
                    id: UserStore.GenerateNextId(),
                    name: fullName,
                    username: username,
                    email: email,
                    phone: phone,
                    address: address,
                    password: password,
                    role: role,
                    status: status,
                    createdDate: DateTime.Now
                );

                UserStore.Add(newUser);
                MessageBox.Show($"New account for '{fullName}' created successfully with User ID: {newUser.UserId}!", "User Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen borderPen = new Pen(Color.FromArgb(15, 23, 42), 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

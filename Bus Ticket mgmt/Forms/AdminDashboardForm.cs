using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class AdminDashboardForm : Form
    {
        private bool isMaximized = false;
        private Point normalLocation;
        private Size normalSize;

        public AdminDashboardForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            InitializeCustomUI();
            SetupEvents();
            SetupUserManagementEvents();
            SetupBusManagementEvents();

            PopulateTripsTable();
            PopulateUsersList();
            PopulateBusesList();
        }

        private void InitializeCustomUI()
        {
            txtTicketNumber.PlaceholderText = "e.g. ET-88219";
            txtTicketNumber.IconType = InputIconType.None;

            btnVerifyTicket.NormalColor = Color.FromArgb(13, 94, 234);
            btnVerifyTicket.HoverColor = Color.FromArgb(11, 79, 196);
            btnVerifyTicket.PressedColor = Color.FromArgb(9, 66, 166);

            // Vector Bus icon on title bar
            lblAppIcon.Paint += (s, e) =>
            {
                IconRenderer.DrawBusIcon(e.Graphics, 2, 8, 22, Color.White);
            };

            // Window control hover transitions
            btnClose.MouseEnter += (s, e) => { btnClose.BackColor = Color.FromArgb(239, 68, 68); btnClose.ForeColor = Color.White; };
            btnClose.MouseLeave += (s, e) => { btnClose.BackColor = Color.FromArgb(15, 23, 42); btnClose.ForeColor = Color.FromArgb(148, 163, 184); };

            btnMaximize.MouseEnter += (s, e) => { btnMaximize.BackColor = Color.FromArgb(30, 41, 59); };
            btnMaximize.MouseLeave += (s, e) => { btnMaximize.BackColor = Color.FromArgb(15, 23, 42); };

            btnMinimize.MouseEnter += (s, e) => { btnMinimize.BackColor = Color.FromArgb(30, 41, 59); };
            btnMinimize.MouseLeave += (s, e) => { btnMinimize.BackColor = Color.FromArgb(15, 23, 42); };

            // Setup filters default selection
            cmbRoleFilter.SelectedIndex = 0; // All Roles
            cmbStatusFilter.SelectedIndex = 0; // All Statuses
            cmbBusTypeFilter.SelectedIndex = 0; // All Bus Types
            cmbBusStatusFilter.SelectedIndex = 0; // All Statuses

            // Sidebar navigation buttons hover effect
            SetupSidebarButton(btnNavRoutes, "Route Management", "Manage departure locations, destinations, distances, and travel times.");
            SetupSidebarButton(btnNavTrips, "Trip & Schedule Management", "Create trips, assign buses and drivers, and update trip status.");
            SetupSidebarButton(btnNavBookings, "Booking Management", "View bookings, search reservations, and assist with permitted changes.");
            SetupSidebarButton(btnNavTickets, "Ticket Management", "Search tickets and verify ticket information.");
            SetupSidebarButton(btnNavPayments, "Payment Management", "View payment records, payment statuses, and eligible refunds.");
            SetupSidebarButton(btnNavStaff, "Driver & Staff Management", "Register drivers and staff, manage details, and assign drivers.");
            SetupSidebarButton(btnNavFares, "Fare Management", "Set and update ticket prices and applicable discounts.");
            SetupSidebarButton(btnNavReports, "Reports", "Review ticket sales, revenue, trip counts, and bus utilization.");
            SetupSidebarButton(btnNavFeedback, "Feedback & Complaints", "Review and manage passenger feedback and complaints.");
            SetupSidebarButton(btnNavSettings, "Settings", "Manage system preferences and configured policies.");

            // Quick actions buttons on dashboard
            btnQuickAddBus.Click += (s, e) => { ShowBusManagementView(); OpenAddBusDialog(); };
            btnQuickNewTrip.Click += (s, e) => ShowSectionInfo("Trip Scheduling", "Assign drivers, buses, departure gates and times for new routes.");
            btnQuickUpdateFares.Click += (s, e) => ShowSectionInfo("Fare Management", "Adjust standard tariffs, seasonal price discounts and luggage fees.");
            btnQuickSalesReport.Click += (s, e) => ShowSectionInfo("Sales & Revenue Reports", "Export daily reconciliation statements, revenue breakdown and fleet utilization.");
            btnQuickFeedback.Click += (s, e) => ShowSectionInfo("Feedback & Complaints", "Review 14 unresolved customer requests and trip inquiries.");

            // Navigation between Dashboard, User Management, and Bus Management
            btnNavDashboard.Click += (s, e) => ShowDashboardView();
            btnNavUsers.Click += (s, e) => ShowUserManagementView();
            btnNavBuses.Click += (s, e) => ShowBusManagementView();
        }

        private void ShowDashboardView()
        {
            flowDashboard.Visible = true;
            panelHeaderInfo.Visible = true;
            panelUserManagement.Visible = false;
            panelBusManagement.Visible = false;

            btnNavDashboard.BackColor = Color.FromArgb(13, 94, 234);
            btnNavDashboard.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            btnNavUsers.BackColor = Color.FromArgb(30, 41, 59);
            btnNavUsers.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            btnNavBuses.BackColor = Color.FromArgb(30, 41, 59);
            btnNavBuses.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
        }

        private void ShowUserManagementView()
        {
            flowDashboard.Visible = false;
            panelHeaderInfo.Visible = false;
            panelUserManagement.Visible = true;
            panelBusManagement.Visible = false;

            btnNavUsers.BackColor = Color.FromArgb(13, 94, 234);
            btnNavUsers.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            btnNavDashboard.BackColor = Color.FromArgb(30, 41, 59);
            btnNavDashboard.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            btnNavBuses.BackColor = Color.FromArgb(30, 41, 59);
            btnNavBuses.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            PopulateUsersList();
        }

        private void ShowBusManagementView()
        {
            flowDashboard.Visible = false;
            panelHeaderInfo.Visible = false;
            panelUserManagement.Visible = false;
            panelBusManagement.Visible = true;

            btnNavBuses.BackColor = Color.FromArgb(13, 94, 234);
            btnNavBuses.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);

            btnNavDashboard.BackColor = Color.FromArgb(30, 41, 59);
            btnNavDashboard.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            btnNavUsers.BackColor = Color.FromArgb(30, 41, 59);
            btnNavUsers.Font = new Font("Segoe UI", 9f, FontStyle.Regular);

            PopulateBusesList();
        }

        private void SetupUserManagementEvents()
        {
            // Add user
            btnAddUser.Click += (s, e) =>
            {
                using (var dialog = new UserDialogForm())
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        PopulateUsersList();
                    }
                }
            };

            // Edit user
            btnEditUser.Click += (s, e) => EditSelectedUser();
            lvUsers.DoubleClick += (s, e) => EditSelectedUser();

            // View details
            btnViewUserDetails.Click += (s, e) => ViewSelectedUserDetails();

            // Toggle active/inactive
            btnToggleUserStatus.Click += (s, e) => ToggleSelectedUserStatus();

            // Reset password
            btnResetUserPassword.Click += (s, e) => ResetSelectedUserPassword();

            // Delete user
            btnDeleteUser.Click += (s, e) => DeleteSelectedUser();

            // Refresh & search filters
            btnRefreshUsers.Click += (s, e) =>
            {
                txtSearchUser.Text = "";
                cmbRoleFilter.SelectedIndex = 0;
                cmbStatusFilter.SelectedIndex = 0;
                PopulateUsersList();
            };

            txtSearchUser.TextChanged += (s, e) => PopulateUsersList();
            cmbRoleFilter.SelectedIndexChanged += (s, e) => PopulateUsersList();
            cmbStatusFilter.SelectedIndexChanged += (s, e) => PopulateUsersList();
        }

        public void PopulateUsersList()
        {
            var allUsers = UserStore.GetAll();
            string search = txtSearchUser.Text.Trim().ToLower();
            string selectedRole = cmbRoleFilter.SelectedItem?.ToString() ?? "All Roles";
            string selectedStatus = cmbStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var filtered = allUsers.Where(u =>
            {
                // Search filter
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                    u.UserId.ToLower().Contains(search) ||
                    u.FullName.ToLower().Contains(search) ||
                    u.Username.ToLower().Contains(search) ||
                    u.Email.ToLower().Contains(search) ||
                    u.Phone.ToLower().Contains(search);

                // Role filter
                bool matchesRole = selectedRole == "All Roles" || u.Role.Equals(selectedRole, StringComparison.OrdinalIgnoreCase);

                // Status filter
                bool matchesStatus = selectedStatus == "All Statuses" || u.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase);

                return matchesSearch && matchesRole && matchesStatus;
            }).ToList();

            lvUsers.BeginUpdate();
            lvUsers.Items.Clear();

            foreach (var user in filtered)
            {
                ListViewItem item = new ListViewItem(user.UserId);
                item.SubItems.Add(user.FullName);
                item.SubItems.Add(user.Username);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Phone);
                item.SubItems.Add(user.Role);
                item.SubItems.Add(user.Status);
                item.SubItems.Add(user.CreatedDate.ToString("yyyy-MM-dd"));

                // Status row color hint
                if (user.Status == "Inactive")
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184);
                }
                else if (user.Role == "Administrator")
                {
                    item.Font = new Font(lvUsers.Font, FontStyle.Bold);
                }

                item.Tag = user;
                lvUsers.Items.Add(item);
            }

            lvUsers.EndUpdate();
            lblUserCount.Text = $"Showing {filtered.Count} of {allUsers.Count} accounts";
        }

        private User? GetSelectedUser()
        {
            if (lvUsers.SelectedItems.Count > 0 && lvUsers.SelectedItems[0].Tag is User user)
            {
                return user;
            }
            return null;
        }

        private void EditSelectedUser()
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user from the table to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new UserDialogForm(user))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateUsersList();
                }
            }
        }

        private void ViewSelectedUserDetails()
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user from the table to view details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string details = $"=====================================\n" +
                             $"       USER ACCOUNT DETAILS          \n" +
                             $"=====================================\n\n" +
                             $"User ID:       {user.UserId}\n" +
                             $"Full Name:     {user.FullName}\n" +
                             $"Username:      {user.Username}\n" +
                             $"Email:         {user.Email}\n" +
                             $"Phone:         {user.Phone}\n" +
                             $"Address:       {(string.IsNullOrEmpty(user.Address) ? "N/A" : user.Address)}\n" +
                             $"Role:          {user.Role}\n" +
                             $"Status:        {user.Status}\n" +
                             $"Created Date:  {user.CreatedDate:yyyy-MM-dd HH:mm}\n\n" +
                             $"Permissions:   Role-based access as configured for {user.Role}.";

            MessageBox.Show(details, $"Account Profile - {user.FullName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToggleSelectedUserStatus()
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user to activate or deactivate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string newStatus = (user.Status == "Active") ? "Inactive" : "Active";
            string prompt = (newStatus == "Inactive")
                ? $"Are you sure you want to DEACTIVATE the account for '{user.FullName}' ({user.UserId})?\n\nDeactivated users cannot log into the system, but their past bookings and transaction history are preserved."
                : $"Are you sure you want to ACTIVATE the account for '{user.FullName}' ({user.UserId})?";

            var result = MessageBox.Show(prompt, "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                UserStore.ToggleStatus(user.UserId);
                PopulateUsersList();
                MessageBox.Show($"Account for '{user.FullName}' is now {newStatus}.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ResetSelectedUserPassword()
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user account to reset their password.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tempPassword = "Pass@" + new Random().Next(1000, 9999);
            var confirm = MessageBox.Show(
                $"Reset password for '{user.FullName}' ({user.Username}) to temporary password:\n\n" +
                $"Temporary Password: {tempPassword}\n\n" +
                $"Do you want to apply this reset?",
                "Reset Password Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                UserStore.ResetPassword(user.UserId, tempPassword);
                MessageBox.Show($"Password has been reset successfully!\n\nProvide the user with their temporary password:\n{tempPassword}", "Password Reset Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteSelectedUser()
        {
            var user = GetSelectedUser();
            if (user == null)
            {
                MessageBox.Show("Please select a user account to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (user.Role == "Administrator" && user.Username == "admin")
            {
                MessageBox.Show("The primary System Administrator account cannot be deleted.", "Operation Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to PERMANENTLY DELETE the account for:\n\n" +
                $"Name: {user.FullName}\n" +
                $"ID:   {user.UserId}\n" +
                $"Role: {user.Role}\n\n" +
                $"WARNING: This will remove the account completely. (Consider Deactivating instead to preserve booking audit records.)",
                "Confirm Permanent Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                UserStore.Delete(user.UserId);
                PopulateUsersList();
                MessageBox.Show($"User account '{user.FullName}' ({user.UserId}) has been deleted.", "Account Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Bus Management Logic

        private void SetupBusManagementEvents()
        {
            // Add bus
            btnAddBus.Click += (s, e) => OpenAddBusDialog();

            // Edit bus
            btnEditBus.Click += (s, e) => EditSelectedBus();
            lvBuses.DoubleClick += (s, e) => EditSelectedBus();

            // View bus details
            btnViewBusDetails.Click += (s, e) => ViewSelectedBusDetails();

            // Change status
            btnChangeBusStatus.Click += (s, e) => ChangeSelectedBusStatus();

            // Delete bus
            btnDeleteBus.Click += (s, e) => DeleteSelectedBus();

            // Refresh & search filters
            btnRefreshBuses.Click += (s, e) =>
            {
                txtSearchBus.Text = "";
                cmbBusTypeFilter.SelectedIndex = 0;
                cmbBusStatusFilter.SelectedIndex = 0;
                PopulateBusesList();
            };

            txtSearchBus.TextChanged += (s, e) => PopulateBusesList();
            cmbBusTypeFilter.SelectedIndexChanged += (s, e) => PopulateBusesList();
            cmbBusStatusFilter.SelectedIndexChanged += (s, e) => PopulateBusesList();
        }

        public void PopulateBusesList()
        {
            // 1. Update summary card metric counts dynamically from BusStore
            int totalBuses = BusStore.GetTotalCount();
            int activeBuses = BusStore.GetActiveCount();
            int maintBuses = BusStore.GetMaintenanceCount();
            int inactiveBuses = BusStore.GetInactiveCount();

            lblMetricTotalBusesVal.Text = totalBuses.ToString();
            lblMetricActiveBusesVal.Text = activeBuses.ToString();
            lblMetricMaintBusesVal.Text = maintBuses.ToString();
            lblMetricInactiveBusesVal.Text = inactiveBuses.ToString();

            // Also keep dashboard overview card in sync
            lblMetricBusesVal.Text = totalBuses.ToString();

            // 2. Filter bus list
            var allBuses = BusStore.GetAll();
            string search = txtSearchBus.Text.Trim().ToLower();
            string selectedType = cmbBusTypeFilter.SelectedItem?.ToString() ?? "All Bus Types";
            string selectedStatus = cmbBusStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var filtered = allBuses.Where(b =>
            {
                // Search filter: plate number, ID, manufacturer, model
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                    b.BusId.ToLower().Contains(search) ||
                    b.PlateNumber.ToLower().Contains(search) ||
                    b.Manufacturer.ToLower().Contains(search) ||
                    b.Model.ToLower().Contains(search);

                // Type filter
                bool matchesType = selectedType == "All Bus Types" || b.BusType.Equals(selectedType, StringComparison.OrdinalIgnoreCase);

                // Status filter
                bool matchesStatus = selectedStatus == "All Statuses" || b.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase);

                return matchesSearch && matchesType && matchesStatus;
            }).ToList();

            // 3. Populate ListView
            lvBuses.BeginUpdate();
            lvBuses.Items.Clear();

            foreach (var bus in filtered)
            {
                ListViewItem item = new ListViewItem(bus.BusId);
                item.SubItems.Add(bus.PlateNumber);
                item.SubItems.Add(bus.FullModelName);
                item.SubItems.Add(bus.BusType);
                item.SubItems.Add(bus.Capacity.ToString());
                item.SubItems.Add(bus.RegistrationDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(bus.Status);
                item.SubItems.Add(bus.AssignedTrip);

                // Status color styling
                if (bus.Status == "Inactive")
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184); // Muted slate
                }
                else if (bus.Status == "Maintenance")
                {
                    item.ForeColor = Color.FromArgb(180, 83, 9); // Amber orange
                }
                else
                {
                    item.ForeColor = Color.FromArgb(15, 23, 42); // Active dark
                }

                item.Tag = bus;
                lvBuses.Items.Add(item);
            }

            lvBuses.EndUpdate();
            lblBusCount.Text = $"Showing {filtered.Count} of {allBuses.Count} buses";
        }

        private Bus? GetSelectedBus()
        {
            if (lvBuses.SelectedItems.Count > 0 && lvBuses.SelectedItems[0].Tag is Bus bus)
            {
                return bus;
            }
            return null;
        }

        private void OpenAddBusDialog()
        {
            using (var dialog = new BusDialogForm())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateBusesList();
                }
            }
        }

        private void EditSelectedBus()
        {
            var bus = GetSelectedBus();
            if (bus == null)
            {
                MessageBox.Show("Please select a bus from the list to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new BusDialogForm(bus))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateBusesList();
                }
            }
        }

        private void ViewSelectedBusDetails()
        {
            var bus = GetSelectedBus();
            if (bus == null)
            {
                MessageBox.Show("Please select a bus from the table to view specifications.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string details = $"========================================\n" +
                             $"       BUS FLEET SPECIFICATIONS        \n" +
                             $"========================================\n\n" +
                             $"• Bus ID:           {bus.BusId}\n" +
                             $"• Plate Number:     {bus.PlateNumber}\n" +
                             $"• Manufacturer:     {bus.Manufacturer}\n" +
                             $"• Model:            {bus.Model}\n" +
                             $"• Bus Category:     {bus.BusType}\n" +
                             $"• Seating Capacity: {bus.Capacity} passengers\n" +
                             $"• Reg. Date:        {bus.RegistrationDate:yyyy-MM-dd}\n" +
                             $"• Reg. Document:    {bus.RegistrationInfo}\n" +
                             $"• Fleet Status:     {bus.Status}\n" +
                             $"• Assigned Trip:    {bus.AssignedTrip}\n\n" +
                             $"Operational Notes:\n{(string.IsNullOrWhiteSpace(bus.Notes) ? "(No operational notes logged)" : bus.Notes)}";

            MessageBox.Show(details, $"Fleet Details - {bus.BusId} ({bus.PlateNumber})", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChangeSelectedBusStatus()
        {
            var bus = GetSelectedBus();
            if (bus == null)
            {
                MessageBox.Show("Please select a bus from the table to change status.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var prompt = new Form())
            {
                prompt.Width = 380;
                prompt.Height = 220;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = $"Change Status - {bus.BusId}";
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;
                prompt.BackColor = Color.White;

                Label lblPrompt = new Label() { Left = 20, Top = 20, Width = 320, Text = $"Select operational status for {bus.PlateNumber} ({bus.FullModelName}):", Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
                ComboBox cmb = new ComboBox() { Left = 20, Top = 55, Width = 320, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 9.5f) };
                cmb.Items.AddRange(new object[] { "Active", "Maintenance", "Inactive" });
                cmb.SelectedItem = bus.Status;

                Button btnOk = new Button() { Text = "Update Status", Left = 120, Width = 110, Top = 110, DialogResult = DialogResult.OK, BackColor = Color.FromArgb(13, 94, 234), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                btnOk.FlatAppearance.BorderSize = 0;
                Button btnCancel = new Button() { Text = "Cancel", Left = 240, Width = 100, Top = 110, DialogResult = DialogResult.Cancel, FlatStyle = FlatStyle.Flat, BackColor = Color.FromArgb(241, 245, 249) };
                btnCancel.FlatAppearance.BorderSize = 0;

                prompt.Controls.Add(lblPrompt);
                prompt.Controls.Add(cmb);
                prompt.Controls.Add(btnOk);
                prompt.Controls.Add(btnCancel);
                prompt.AcceptButton = btnOk;
                prompt.CancelButton = btnCancel;

                if (prompt.ShowDialog(this) == DialogResult.OK)
                {
                    string newStatus = cmb.SelectedItem?.ToString() ?? bus.Status;
                    if (newStatus == bus.Status) return;

                    // Business rule: if setting to Maintenance or Inactive and bus has an active trip assignment
                    if ((newStatus == "Maintenance" || newStatus == "Inactive") &&
                        !bus.AssignedTrip.StartsWith("None", StringComparison.OrdinalIgnoreCase))
                    {
                        var confirm = MessageBox.Show(
                            $"Bus '{bus.BusId}' is currently assigned to trip:\n'{bus.AssignedTrip}'\n\nSetting status to '{newStatus}' will unassign this bus from its scheduled route.\n\nDo you want to proceed with this status change?",
                            "Warning: Active Trip Assignment",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning
                        );

                        if (confirm != DialogResult.Yes)
                        {
                            return;
                        }
                    }

                    BusStore.SetStatus(bus.BusId, newStatus);
                    PopulateBusesList();
                    MessageBox.Show($"Bus '{bus.BusId}' status changed from '{bus.Status}' to '{newStatus}'.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeleteSelectedBus()
        {
            var bus = GetSelectedBus();
            if (bus == null)
            {
                MessageBox.Show("Please select a bus from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Business rule: Prevent permanent deletion if bus is currently assigned to an active trip
            if (!bus.AssignedTrip.StartsWith("None", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show(
                    $"Cannot delete bus '{bus.BusId}' ({bus.PlateNumber}) because it is actively assigned to:\n'{bus.AssignedTrip}'.\n\nPlease unassign or complete the trip before deleting, or deactivate the bus instead.",
                    "Deletion Blocked - Active Dependency",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete bus '{bus.BusId}' ({bus.FullModelName}, Plate: {bus.PlateNumber})?\n\nThis record will be permanently removed from the system fleet.",
                "Confirm Fleet Bus Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                BusStore.Delete(bus.BusId);
                PopulateBusesList();
                MessageBox.Show($"Bus '{bus.BusId}' ({bus.PlateNumber}) has been permanently removed from the fleet.", "Bus Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void SetupSidebarButton(Button btn, string sectionTitle, string responsibility)
        {
            btn.MouseEnter += (s, e) =>
            {
                if (btn != btnNavDashboard && btn != btnNavUsers && btn != btnNavBuses)
                {
                    btn.BackColor = Color.FromArgb(51, 65, 85);
                }
            };
            btn.MouseLeave += (s, e) =>
            {
                if (btn != btnNavDashboard && btn != btnNavUsers && btn != btnNavBuses)
                {
                    btn.BackColor = Color.FromArgb(30, 41, 59);
                }
            };
            btn.Click += (s, e) =>
            {
                ShowSectionInfo(sectionTitle, responsibility);
            };
        }

        private void ShowSectionInfo(string title, string details)
        {
            MessageBox.Show(
                $"{details}\n\n[Status: Section modules loaded and accessible]",
                $"Admin: {title}",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void SetupEvents()
        {
            // Drag window from Top Bar
            panelTopBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            lblPortalTitle.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            // Window control buttons
            btnClose.Click += (s, e) => Application.Exit();
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            btnMaximize.Click += (s, e) => ToggleMaximize();

            // Sign out
            btnNavLogout.Click += (s, e) =>
            {
                var confirm = MessageBox.Show("Are you sure you want to log out of the Administrator Portal?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    this.Close();
                }
            };

            // Ticket verification button
            btnVerifyTicket.Click += (s, e) =>
            {
                string ticketId = txtTicketNumber.InputText.Trim();
                if (string.IsNullOrEmpty(ticketId))
                {
                    lblVerifyResult.ForeColor = Color.FromArgb(225, 29, 72);
                    lblVerifyResult.Text = "⚠️ Please enter a ticket or booking reference number.";
                    return;
                }

                lblVerifyResult.ForeColor = Color.FromArgb(22, 163, 74);
                lblVerifyResult.Text = $"✅ Ticket [{ticketId.ToUpper()}] is VALID: Addis Ababa ➔ Bahir Dar (Seat 14, Paid 1,150 ETB).";
            };
        }

        private void PopulateTripsTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Trip ID", typeof(string));
            dt.Columns.Add("Route (Origin ➔ Destination)", typeof(string));
            dt.Columns.Add("Bus Plate", typeof(string));
            dt.Columns.Add("Assigned Driver", typeof(string));
            dt.Columns.Add("Departure", typeof(string));
            dt.Columns.Add("Occupancy", typeof(string));
            dt.Columns.Add("Trip Status", typeof(string));

            dt.Rows.Add("TRP-101", "Addis Ababa ➔ Bahir Dar", "ET-3-4812", "Dawit Alemu", "06:00 AM", "49 / 51 (96%)", "On Route");
            dt.Rows.Add("TRP-102", "Addis Ababa ➔ Hawassa", "ET-3-9201", "Bekele Tadesse", "07:30 AM", "51 / 51 (100%)", "Departed");
            dt.Rows.Add("TRP-103", "Addis Ababa ➔ Gondar", "ET-3-1184", "Henok Girma", "08:00 AM", "42 / 51 (82%)", "Boarding");
            dt.Rows.Add("TRP-104", "Addis Ababa ➔ Dire Dawa", "ET-3-7723", "Yared Solomon", "09:30 AM", "38 / 49 (77%)", "Scheduled");
            dt.Rows.Add("TRP-105", "Mekelle ➔ Addis Ababa", "ET-3-5509", "Fitsum Berhe", "10:00 AM", "47 / 51 (92%)", "Scheduled");
            dt.Rows.Add("TRP-106", "Jimma ➔ Addis Ababa", "ET-3-6310", "Tariku Kebede", "11:15 AM", "33 / 49 (67%)", "Scheduled");

            dgvTrips.DataSource = dt;

            dgvTrips.DefaultCellStyle.Font = new Font("Segoe UI", 9.2f, FontStyle.Regular);
            dgvTrips.DefaultCellStyle.ForeColor = Color.FromArgb(15, 23, 42);
            dgvTrips.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvTrips.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);
            dgvTrips.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.2f, FontStyle.Bold);
            dgvTrips.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvTrips.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvTrips.EnableHeadersVisualStyles = false;
            dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ToggleMaximize()
        {
            if (!isMaximized)
            {
                normalLocation = this.Location;
                normalSize = this.Size;
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
                isMaximized = true;
                btnMaximize.Text = "❐";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = normalLocation;
                this.Size = normalSize;
                isMaximized = false;
                btnMaximize.Text = "□";
            }
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

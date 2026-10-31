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
            SetupRouteManagementEvents();
            SetupBookingManagementEvents();
            SetupTicketManagementEvents();

            InitializeTripManagement();
            InitializePaymentManagement();
            InitializeStaffManagement();
            InitializeFareManagement();
            InitializeReportManagement();
            InitializeSettingsManagement();

            PopulateTripsTable();
            PopulateUsersList();
            PopulateBusesList();
            PopulateRoutesList();
            PopulateBookingsList();
            PopulateTicketsList();
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
            cmbRouteStatusFilter.SelectedIndex = 0; // All Statuses
            cmbBookingStatusFilter.SelectedIndex = 0; // All Statuses
            cmbTicketStatusFilter.SelectedIndex = 0; // All Statuses

            // Setup sidebar button hover effects
            SetupSidebarButton(btnNavDashboard);
            SetupSidebarButton(btnNavUsers);
            SetupSidebarButton(btnNavBuses);
            SetupSidebarButton(btnNavRoutes);
            SetupSidebarButton(btnNavTrips);
            SetupSidebarButton(btnNavBookings);
            SetupSidebarButton(btnNavTickets);
            SetupSidebarButton(btnNavPayments);
            SetupSidebarButton(btnNavStaff);
            SetupSidebarButton(btnNavFares);
            SetupSidebarButton(btnNavReports);
            SetupSidebarButton(btnNavSettings);

            // Quick actions buttons on dashboard
            btnQuickAddBus.Click += (s, e) => { ShowBusManagementView(); OpenAddBusDialog(); };
            btnQuickNewTrip.Click += (s, e) => { ShowTripManagementView(); OpenNewTripDialog(); };
            btnQuickUpdateFares.Click += (s, e) => ShowFareManagementView();
            btnQuickSalesReport.Click += (s, e) => ShowReportManagementView();
           

            // Sidebar right-edge divider line
            panelSidebar.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(borderPen, panelSidebar.Width - 1, 0, panelSidebar.Width - 1, panelSidebar.Height);
                }
            };

            // Sign out button hover transition
            btnNavLogout.MouseEnter += (s, e) => { btnNavLogout.BackColor = Color.FromArgb(254, 226, 226); };
            btnNavLogout.MouseLeave += (s, e) => { btnNavLogout.BackColor = Color.FromArgb(254, 242, 242); };

            // Full Sidebar Navigation Wiring for ALL modules
            btnNavDashboard.Click += (s, e) => ShowDashboardView();
            btnNavUsers.Click += (s, e) => ShowUserManagementView();
            btnNavBuses.Click += (s, e) => ShowBusManagementView();
            btnNavRoutes.Click += (s, e) => ShowRouteManagementView();
            btnNavTrips.Click += (s, e) => ShowTripManagementView();
            btnNavBookings.Click += (s, e) => ShowBookingManagementView();
            btnNavTickets.Click += (s, e) => ShowTicketManagementView();
            btnNavPayments.Click += (s, e) => ShowPaymentManagementView();
            btnNavStaff.Click += (s, e) => ShowStaffManagementView();
            btnNavFares.Click += (s, e) => ShowFareManagementView();
            btnNavReports.Click += (s, e) => ShowReportManagementView();
            
            btnNavSettings.Click += (s, e) => ShowSettingsManagementView();
        }

        private void SetActiveSidebarButton(Button activeButton)
        {
            Button[] allNavButtons = new[]
            {
                btnNavDashboard, btnNavUsers, btnNavBuses, btnNavRoutes, btnNavTrips,
                btnNavBookings, btnNavTickets, btnNavPayments, btnNavStaff,
              
            };

            foreach (var btn in allNavButtons)
            {
                if (btn == null) continue;
                if (btn == activeButton)
                {
                    btn.BackColor = Color.FromArgb(13, 94, 234);
                    btn.ForeColor = Color.White;
                    btn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
                }
                else
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(51, 65, 85);
                    btn.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
                }
            }
        }

        private void HideAllPanels()
        {
            flowDashboard.Visible = false;
            panelHeaderInfo.Visible = false;
            panelUserManagement.Visible = false;
            panelBusManagement.Visible = false;
            panelRouteManagement.Visible = false;
            panelBookingManagement.Visible = false;
            panelTicketManagement.Visible = false;

            if (panelTripManagement != null) panelTripManagement.Visible = false;
            if (panelPaymentManagement != null) panelPaymentManagement.Visible = false;
            if (panelStaffManagement != null) panelStaffManagement.Visible = false;
            if (panelFareManagement != null) panelFareManagement.Visible = false;
            if (panelReportManagement != null) panelReportManagement.Visible = false;
            
            if (panelSettingsManagement != null) panelSettingsManagement.Visible = false;
        }

        private void ShowDashboardView()
        {
            HideAllPanels();
            flowDashboard.Visible = true;
            panelHeaderInfo.Visible = true;
            flowDashboard.BringToFront();
            SetActiveSidebarButton(btnNavDashboard);
            lblPageHeading.Text = "System Overview";
            lblPageSubHeading.Text = "Welcome back, System Administrator. Here is today's transportation activity summary.";
            PopulateTripsTable();
        }

        private void ShowUserManagementView()
        {
            HideAllPanels();
            panelUserManagement.Visible = true;
            panelUserManagement.BringToFront();
            SetActiveSidebarButton(btnNavUsers);
            lblPageHeading.Text = "User Account Management";
            lblPageSubHeading.Text = "Manage system users, passengers, drivers, and assign roles & credentials.";
            PopulateUsersList();
        }

        private void ShowBusManagementView()
        {
            HideAllPanels();
            panelBusManagement.Visible = true;
            panelBusManagement.BringToFront();
            SetActiveSidebarButton(btnNavBuses);
            lblPageHeading.Text = "Bus Fleet Management";
            lblPageSubHeading.Text = "Register new buses, track maintenance statuses, and assign buses to routes.";
            PopulateBusesList();
        }

        private void ShowRouteManagementView()
        {
            HideAllPanels();
            panelRouteManagement.Visible = true;
            panelRouteManagement.BringToFront();
            SetActiveSidebarButton(btnNavRoutes);
            lblPageHeading.Text = "Route Management";
            lblPageSubHeading.Text = "Define departure and destination corridors, intermediate stops, distance, and base fares.";
            PopulateRoutesList();
        }

        private void ShowBookingManagementView()
        {
            HideAllPanels();
            panelBookingManagement.Visible = true;
            panelBookingManagement.BringToFront();
            SetActiveSidebarButton(btnNavBookings);
            lblPageHeading.Text = "Booking & Reservation Management";
            lblPageSubHeading.Text = "Manage passenger reservations, confirm booking references, and handle cancellations.";
            PopulateBookingsList();
        }

        private void ShowTicketManagementView()
        {
            HideAllPanels();
            panelTicketManagement.Visible = true;
            panelTicketManagement.BringToFront();
            SetActiveSidebarButton(btnNavTickets);
            lblPageHeading.Text = "Ticket & Boarding Management";
            lblPageSubHeading.Text = "Search, issue, verify boarding passes, and prevent duplicate ticket reuse.";
            PopulateTicketsList();
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

        #region Route Management Logic

        private void SetupRouteManagementEvents()
        {
            // Add route
            btnAddRoute.Click += (s, e) => OpenAddRouteDialog();

            // Edit route
            btnEditRoute.Click += (s, e) => EditSelectedRoute();
            lvRoutes.DoubleClick += (s, e) => EditSelectedRoute();

            // View route details
            btnViewRouteDetails.Click += (s, e) => ViewSelectedRouteDetails();

            // Activate / Deactivate
            btnToggleRouteStatus.Click += (s, e) => ToggleSelectedRouteStatus();

            // Delete route
            btnDeleteRoute.Click += (s, e) => DeleteSelectedRoute();

            // Refresh & search filters
            btnRefreshRoutes.Click += (s, e) =>
            {
                txtSearchRoute.Text = "";
                cmbRouteStatusFilter.SelectedIndex = 0;
                PopulateRoutesList();
            };

            txtSearchRoute.TextChanged += (s, e) => PopulateRoutesList();
            cmbRouteStatusFilter.SelectedIndexChanged += (s, e) => PopulateRoutesList();
        }

        public void PopulateRoutesList()
        {
            // 1. Recalculate and update summary cards dynamically from RouteStore
            int totalRoutes = RouteStore.GetTotalCount();
            int activeRoutes = RouteStore.GetActiveCount();
            int inactiveRoutes = RouteStore.GetInactiveCount();
            double totalDistance = RouteStore.GetTotalDistanceKm();

            lblMetricTotalRoutesVal.Text = totalRoutes.ToString();
            lblMetricActiveRoutesVal.Text = activeRoutes.ToString();
            lblMetricInactiveRoutesVal.Text = inactiveRoutes.ToString();
            lblMetricTotalDistanceVal.Text = $"{totalDistance:N0} km";

            // 2. Filter routes
            var allRoutes = RouteStore.GetAll();
            string search = txtSearchRoute.Text.Trim().ToLower();
            string selectedStatus = cmbRouteStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var filtered = allRoutes.Where(r =>
            {
                // Search filter: ID, Name, Source, Destination, Intermediate Stops
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                    r.RouteId.ToLower().Contains(search) ||
                    r.RouteName.ToLower().Contains(search) ||
                    r.Source.ToLower().Contains(search) ||
                    r.Destination.ToLower().Contains(search) ||
                    r.IntermediateStops.ToLower().Contains(search);

                // Status filter
                bool matchesStatus = selectedStatus == "All Statuses" || r.Status.Equals(selectedStatus, StringComparison.OrdinalIgnoreCase);

                return matchesSearch && matchesStatus;
            }).ToList();

            // 3. Populate ListView
            lvRoutes.BeginUpdate();
            lvRoutes.Items.Clear();

            foreach (var route in filtered)
            {
                ListViewItem item = new ListViewItem(route.RouteId);
                item.SubItems.Add(route.RouteName);
                item.SubItems.Add(route.Source);
                item.SubItems.Add(route.Destination);
                item.SubItems.Add($"{route.DistanceKm:N0} km");
                item.SubItems.Add(route.EstimatedTime);
                item.SubItems.Add($"{route.BaseFare:N0} ETB");
                item.SubItems.Add(route.Status);
                item.SubItems.Add(string.IsNullOrWhiteSpace(route.IntermediateStops) ? "Direct Route" : route.IntermediateStops);

                // Status color styling
                if (route.Status == "Inactive")
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184); // Muted slate
                }
                else
                {
                    item.ForeColor = Color.FromArgb(15, 23, 42); // Active dark
                }

                item.Tag = route;
                lvRoutes.Items.Add(item);
            }

            lvRoutes.EndUpdate();
            lblRouteCount.Text = $"Showing {filtered.Count} of {allRoutes.Count} routes";
        }

        private Route? GetSelectedRoute()
        {
            if (lvRoutes.SelectedItems.Count > 0 && lvRoutes.SelectedItems[0].Tag is Route route)
            {
                return route;
            }
            return null;
        }

        private void OpenAddRouteDialog()
        {
            using (var dialog = new RouteDialogForm())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateRoutesList();
                }
            }
        }

        private void EditSelectedRoute()
        {
            var route = GetSelectedRoute();
            if (route == null)
            {
                MessageBox.Show("Please select a route from the table to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new RouteDialogForm(route))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateRoutesList();
                }
            }
        }

        private void ViewSelectedRouteDetails()
        {
            var route = GetSelectedRoute();
            if (route == null)
            {
                MessageBox.Show("Please select a route from the table to view details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string details = $"========================================\n" +
                             $"       BUS ROUTE SPECIFICATIONS        \n" +
                             $"========================================\n\n" +
                             $"• Route ID:           {route.RouteId}\n" +
                             $"• Route Name:         {route.RouteName}\n" +
                             $"• Departure Point:    {route.Source}\n" +
                             $"• Destination Point:  {route.Destination}\n" +
                             $"• Stops En Route:     {(string.IsNullOrWhiteSpace(route.IntermediateStops) ? "Direct (No intermediate stops)" : route.IntermediateStops)}\n" +
                             $"• Network Distance:   {route.DistanceKm:N0} km\n" +
                             $"• Est. Travel Time:   {route.EstimatedTime}\n" +
                             $"• Base Standard Fare: {route.BaseFare:N0} ETB\n" +
                             $"• Operational Status: {route.Status}\n" +
                             $"• Registered On:      {route.CreatedDate:yyyy-MM-dd HH:mm}\n\n" +
                             $"Route Description & Advisory:\n{(string.IsNullOrWhiteSpace(route.Description) ? "(No route notes or advisories logged)" : route.Description)}";

            MessageBox.Show(details, $"Route Specifications - {route.RouteId} ({route.RouteName})", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToggleSelectedRouteStatus()
        {
            var route = GetSelectedRoute();
            if (route == null)
            {
                MessageBox.Show("Please select a route from the table to activate or deactivate.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string newStatus = (route.Status == "Active") ? "Inactive" : "Active";
            string prompt = (newStatus == "Inactive")
                ? $"Are you sure you want to DEACTIVATE route '{route.RouteName}' ({route.RouteId})?\n\nBusiness Rule Notice:\nInactive routes cannot be selected when creating new trips or schedules.\nExisting trips and booking histories are preserved."
                : $"Are you sure you want to ACTIVATE route '{route.RouteName}' ({route.RouteId})?\n\nThis route will become available for new trip scheduling.";

            var result = MessageBox.Show(prompt, "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                RouteStore.ToggleStatus(route.RouteId);
                PopulateRoutesList();
                MessageBox.Show($"Route '{route.RouteName}' ({route.RouteId}) status changed to '{newStatus}'.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DeleteSelectedRoute()
        {
            var route = GetSelectedRoute();
            if (route == null)
            {
                MessageBox.Show("Please select a route from the table to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Business rule: Deleting a route must not corrupt existing trips and booking history
            var confirm = MessageBox.Show(
                $"Are you sure you want to permanently delete route:\n\n" +
                $"• Route ID: {route.RouteId}\n" +
                $"• Name:     {route.RouteName}\n" +
                $"• Journey:  {route.Source} ➔ {route.Destination}\n\n" +
                $"WARNING: Permanent deletion will remove this route configuration.\n" +
                $"Tip: Consider Deactivating instead to preserve trip and booking history audits.",
                "Confirm Route Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                RouteStore.Delete(route.RouteId);
                PopulateRoutesList();
                MessageBox.Show($"Route '{route.RouteName}' ({route.RouteId}) has been removed.", "Route Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region Booking Management Logic

        private void SetupBookingManagementEvents()
        {
            // Open Add Booking Form
            btnNewBooking.Click += (s, e) => OpenAddBookingDialog();

            // Edit Selected Booking
            btnModifyBooking.Click += (s, e) => EditSelectedBooking();
            lvBookings.DoubleClick += (s, e) => EditSelectedBooking();

            // View Details
            btnViewBookingDetails.Click += (s, e) => ViewSelectedBookingDetails();

            // Cancel Booking
            btnCancelBookingAction.Click += (s, e) => CancelSelectedBooking();

            // Print / View Ticket
            btnPrintTicket.Click += (s, e) => PrintOrViewSelectedTicket();

            // Search filter
            txtSearchBooking.TextChanged += (s, e) => PopulateBookingsList();

            // Status filter
            cmbBookingStatusFilter.SelectedIndexChanged += (s, e) => PopulateBookingsList();

            // Route filter
            cmbBookingRouteFilter.SelectedIndexChanged += (s, e) => PopulateBookingsList();

            // Date filter
            chkEnableDateFilter.CheckedChanged += (s, e) =>
            {
                dtpBookingFilterDate.Enabled = chkEnableDateFilter.Checked;
                PopulateBookingsList();
            };
            dtpBookingFilterDate.ValueChanged += (s, e) =>
            {
                if (chkEnableDateFilter.Checked)
                {
                    PopulateBookingsList();
                }
            };

            // Reset filters
            btnResetBookingFilters.Click += (s, e) =>
            {
                txtSearchBooking.Text = string.Empty;
                cmbBookingStatusFilter.SelectedIndex = 0;
                cmbBookingRouteFilter.SelectedIndex = 0;
                chkEnableDateFilter.Checked = false;
                dtpBookingFilterDate.Value = DateTime.Today;
                PopulateBookingsList();
            };
        }

        private void PopulateBookingsList()
        {
            // 1. Refresh Summary Cards from BookingStore
            int totalCount = BookingStore.GetTotalCount();
            int confirmedCount = BookingStore.GetConfirmedCount();
            int pendingCount = BookingStore.GetPendingCount();
            int cancelledCount = BookingStore.GetCancelledCount();
            int todayCount = BookingStore.GetTodayCount();

            lblMetricTotalBookingsVal.Text = totalCount.ToString("N0");
            lblMetricTotalBookingsSub.Text = $"{confirmedCount} active passengers";

            lblMetricConfirmedBookingsVal.Text = confirmedCount.ToString("N0");
            lblMetricConfirmedBookingsSub.Text = totalCount > 0 ? $"{(confirmedCount * 100.0 / totalCount):F0}% of total volume" : "0%";

            lblMetricPendingBookingsVal.Text = pendingCount.ToString("N0");
            lblMetricPendingBookingsSub.Text = "Awaiting fare clearance";

            lblMetricCancelledBookingsVal.Text = cancelledCount.ToString("N0");
            lblMetricCancelledBookingsSub.Text = "Seats released to pool";

            lblMetricTodayBookingsVal.Text = todayCount.ToString("N0");
            lblMetricTodayBookingsSub.Text = "Reservations for today";

            // Also keep top dashboard metric synced
            if (lblMetricBookingsVal != null)
            {
                lblMetricBookingsVal.Text = $"{totalCount:N0} Bookings";
            }

            // 2. Synchronize route dropdown items if needed
            if (cmbBookingRouteFilter.Items.Count <= 1)
            {
                cmbBookingRouteFilter.Items.Clear();
                cmbBookingRouteFilter.Items.Add("All Routes / Trips");
                var activeRoutes = RouteStore.GetAll();
                foreach (var r in activeRoutes)
                {
                    cmbBookingRouteFilter.Items.Add($"{r.RouteId}: {r.RouteName}");
                }
                cmbBookingRouteFilter.SelectedIndex = 0;
            }

            // 3. Filter Bookings
            string search = txtSearchBooking.Text.Trim().ToLower();
            string statusFilter = cmbBookingStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            string selectedRouteFilter = cmbBookingRouteFilter.SelectedItem?.ToString() ?? "All Routes / Trips";
            bool filterByDate = chkEnableDateFilter.Checked;
            DateTime targetDate = dtpBookingFilterDate.Value.Date;

            var allBookings = BookingStore.GetAll();
            var filtered = allBookings.Where(b =>
            {
                // Search condition
                bool matchSearch = string.IsNullOrEmpty(search) ||
                    b.BookingId.ToLower().Contains(search) ||
                    b.PassengerName.ToLower().Contains(search) ||
                    b.PassengerPhone.ToLower().Contains(search) ||
                    b.RouteName.ToLower().Contains(search) ||
                    b.Source.ToLower().Contains(search) ||
                    b.Destination.ToLower().Contains(search) ||
                    b.AssignedBus.ToLower().Contains(search);

                if (!matchSearch) return false;

                // Status condition
                if (statusFilter != "All Statuses" && !b.BookingStatus.Equals(statusFilter, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                // Route condition
                if (selectedRouteFilter != "All Routes / Trips")
                {
                    string routeIdPrefix = selectedRouteFilter.Split(':')[0].Trim();
                    if (!b.RouteId.Equals(routeIdPrefix, StringComparison.OrdinalIgnoreCase) &&
                        !b.RouteName.Equals(selectedRouteFilter, StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }

                // Date condition
                if (filterByDate && b.TravelDate.Date != targetDate)
                {
                    return false;
                }

                return true;
            }).OrderByDescending(b => b.TravelDate).ThenByDescending(b => b.BookingDate).ToList();

            // 4. Populate ListView
            lvBookings.BeginUpdate();
            lvBookings.Items.Clear();

            foreach (var b in filtered)
            {
                var item = new ListViewItem(b.BookingId);
                item.SubItems.Add(b.PassengerName);
                item.SubItems.Add(b.PassengerPhone);
                item.SubItems.Add(b.FullRouteDisplay);
                item.SubItems.Add(b.TravelDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(b.DepartureTime);
                item.SubItems.Add(b.SeatNumbersDisplay);
                item.SubItems.Add($"{b.TotalAmount:N0} ETB");
                item.SubItems.Add(b.BookingStatus);
                item.SubItems.Add(b.PaymentStatus);

                item.Tag = b;

                // Visual row styling
                if (b.BookingStatus == "Cancelled")
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184); // Slate muted
                }
                else if (b.BookingStatus == "Pending")
                {
                    item.ForeColor = Color.FromArgb(180, 83, 9); // Amber
                }
                else
                {
                    item.ForeColor = Color.FromArgb(15, 23, 42); // Normal
                }

                lvBookings.Items.Add(item);
            }

            lvBookings.EndUpdate();
            lblBookingCount.Text = $"Showing {filtered.Count} of {allBookings.Count} bookings";
        }

        private Booking? GetSelectedBooking()
        {
            if (lvBookings.SelectedItems.Count > 0 && lvBookings.SelectedItems[0].Tag is Booking booking)
            {
                return booking;
            }
            return null;
        }

        private void OpenAddBookingDialog()
        {
            using (var dialog = new BookingDialogForm())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateBookingsList();
                }
            }
        }

        private void EditSelectedBooking()
        {
            var booking = GetSelectedBooking();
            if (booking == null)
            {
                MessageBox.Show("Please select a booking reservation from the table to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (booking.BookingStatus == "Cancelled")
            {
                MessageBox.Show(
                    $"Booking '{booking.BookingId}' is marked as CANCELLED.\n\n" +
                    $"Business Rule Notice:\n" +
                    $"Cancelled reservations cannot be modified because their assigned seats have been released back to the general inventory.\n" +
                    $"If the passenger wishes to travel, please create a New Booking.",
                    "Modification Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            using (var dialog = new BookingDialogForm(booking))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateBookingsList();
                }
            }
        }

        private void ViewSelectedBookingDetails()
        {
            var booking = GetSelectedBooking();
            if (booking == null)
            {
                MessageBox.Show("Please select a booking from the table to view details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string details = $"====================================================\n" +
                             $"          RESERVATION & BOOKING DETAILS             \n" +
                             $"====================================================\n\n" +
                             $"• Booking Reference:  {booking.BookingId}\n" +
                             $"• Reservation Date:   {booking.BookingDate:yyyy-MM-dd HH:mm}\n" +
                             $"• Booking Status:      {booking.BookingStatus}\n" +
                             $"• Payment Status:      {booking.PaymentStatus}\n\n" +
                             $"--- PASSENGER INFORMATION ---\n" +
                             $"• Full Name:          {booking.PassengerName}\n" +
                             $"• Contact Phone:      {booking.PassengerPhone}\n" +
                             $"• Email Address:      {(string.IsNullOrWhiteSpace(booking.PassengerEmail) ? "N/A" : booking.PassengerEmail)}\n\n" +
                             $"--- TRIP & VEHICLE SPECIFICATIONS ---\n" +
                             $"• Route:              {booking.FullRouteDisplay} ({booking.RouteName})\n" +
                             $"• Travel Date:        {booking.TravelDate:dddd, MMMM dd, yyyy}\n" +
                             $"• Departure Time:     {booking.DepartureTime}\n" +
                             $"• Assigned Bus:       {booking.AssignedBus}\n\n" +
                             $"--- SEAT & FARE CALCULATION ---\n" +
                             $"• Assigned Seat(s):   {booking.SeatNumbersDisplay} ({booking.NumberOfSeats} seat{(booking.NumberOfSeats > 1 ? "s" : "")})\n" +
                             $"• Fare Per Seat:      {booking.FarePerSeat:N0} ETB\n" +
                             $"• Total Amount:       {booking.TotalAmount:N0} ETB\n" +
                             $"• Amount Paid:        {booking.AmountPaid:N0} ETB\n" +
                             $"• Outstanding Due:    {booking.Balance:N0} ETB\n\n" +
                             $"--- NOTES & SPECIAL REQUESTS ---\n" +
                             $"{(string.IsNullOrWhiteSpace(booking.Notes) ? "(No extra notes recorded for this passenger reservation)" : booking.Notes)}";

            MessageBox.Show(details, $"Booking Dossier - {booking.BookingId} ({booking.PassengerName})", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelSelectedBooking()
        {
            var booking = GetSelectedBooking();
            if (booking == null)
            {
                MessageBox.Show("Please select a booking reservation to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (booking.BookingStatus == "Cancelled")
            {
                MessageBox.Show($"Booking '{booking.BookingId}' is already Cancelled.", "Already Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to CANCEL booking '{booking.BookingId}'?\n\n" +
                $"Passenger:  {booking.PassengerName}\n" +
                $"Route:      {booking.FullRouteDisplay}\n" +
                $"Date:       {booking.TravelDate:yyyy-MM-dd} at {booking.DepartureTime}\n" +
                $"Seat(s):    {booking.SeatNumbersDisplay}\n" +
                $"Fare:       {booking.TotalAmount:N0} ETB\n\n" +
                $"Business Rule Enforcement:\n" +
                $"• Cancelling will release seat(s) {booking.SeatNumbersDisplay} back to the available inventory pool.\n" +
                $"• The payment status will be updated accordingly.",
                "Confirm Reservation Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool success = BookingStore.CancelBooking(booking.BookingId);
                if (success)
                {
                    PopulateBookingsList();
                    MessageBox.Show(
                        $"Booking '{booking.BookingId}' was successfully CANCELLED.\n\n" +
                        $"The seats ({booking.SeatNumbersDisplay}) are now released and available for new reservations.",
                        "Cancellation Confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("Failed to cancel the booking. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PrintOrViewSelectedTicket()
        {
            var booking = GetSelectedBooking();
            if (booking == null)
            {
                MessageBox.Show("Please select a booking reservation from the table to preview or print ticket.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (booking.BookingStatus == "Cancelled")
            {
                MessageBox.Show(
                    $"Cannot generate or print a ticket for booking '{booking.BookingId}' because it has been CANCELLED.\n\n" +
                    $"Only confirmed or active bookings can produce valid passenger boarding passes.",
                    "Invalid Ticket Request",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string ticketPreview =
                "============================================================\n" +
                "       ETHIOPIAN BUS TRANSPORT SYSTEM - BOARDING PASS       \n" +
                "============================================================\n\n" +
                $" TICKET / BOOKING REF:  {booking.BookingId}\n" +
                $" PASSENGER NAME:        {booking.PassengerName.ToUpper()}\n" +
                $" CONTACT PHONE:         {booking.PassengerPhone}\n" +
                "------------------------------------------------------------\n" +
                $" ROUTE:                 {booking.Source} ➔ {booking.Destination}\n" +
                $" TRAVEL DATE:           {booking.TravelDate:dddd, MMMM dd, yyyy}\n" +
                $" SCHEDULED DEPARTURE:   {booking.DepartureTime}\n" +
                $" ASSIGNED COACH:        {booking.AssignedBus}\n" +
                $" SEAT ASSIGNMENT:       {booking.SeatNumbersDisplay}\n" +
                "------------------------------------------------------------\n" +
                $" TOTAL FARE:            {booking.TotalAmount:N0} ETB (PAID IN FULL)\n" +
                $" PAYMENT STATUS:        {booking.PaymentStatus.ToUpper()}\n" +
                $" ISSUED ON:             {booking.BookingDate:yyyy-MM-dd HH:mm:ss}\n" +
                "============================================================\n" +
                " BOARDING INSTRUCTIONS:\n" +
                " 1. Please arrive at the departure terminal 30 minutes before departure.\n" +
                " 2. Present this boarding pass along with your Kebele ID or Passport.\n" +
                " 3. Standard luggage allowance is 25 kg per ticket.\n" +
                "============================================================";

            MessageBox.Show(ticketPreview, $"Boarding Pass - {booking.BookingId} ({booking.PassengerName})", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Ticket Management Logic

        private void SetupTicketManagementEvents()
        {
            // Issue New Ticket
            btnNewTicket.Click += (s, e) => OpenIssueTicketDialog();

            // Boarding Scanner modal
            btnVerifyBoardModal.Click += (s, e) => OpenBoardingScannerDialog();

            // Verify & Board selected ticket
            btnVerifyAndBoard.Click += (s, e) => QuickVerifyAndBoardSelectedTicket();

            // View details
            btnViewTicketDetails.Click += (s, e) => ViewSelectedTicketDetails();
            lvTickets.DoubleClick += (s, e) => ViewSelectedTicketDetails();

            // Print Boarding Pass
            btnPrintTicketPass.Click += (s, e) => PrintSelectedBoardingPass();

            // Cancel Ticket
            btnCancelTicketAction.Click += (s, e) => CancelSelectedTicket();

            // Filters
            txtSearchTicketFilter.TextChanged += (s, e) => PopulateTicketsList();
            cmbTicketStatusFilter.SelectedIndexChanged += (s, e) => PopulateTicketsList();
            cmbTicketRouteFilter.SelectedIndexChanged += (s, e) => PopulateTicketsList();
            chkEnableTicketDateFilter.CheckedChanged += (s, e) =>
            {
                dtpTicketFilterDate.Enabled = chkEnableTicketDateFilter.Checked;
                PopulateTicketsList();
            };
            dtpTicketFilterDate.ValueChanged += (s, e) =>
            {
                if (chkEnableTicketDateFilter.Checked)
                {
                    PopulateTicketsList();
                }
            };

            btnResetTicketFilters.Click += (s, e) =>
            {
                txtSearchTicketFilter.Text = string.Empty;
                cmbTicketStatusFilter.SelectedIndex = 0;
                cmbTicketRouteFilter.SelectedIndex = 0;
                chkEnableTicketDateFilter.Checked = false;
                dtpTicketFilterDate.Value = DateTime.Today;
                PopulateTicketsList();
            };
        }

        private void PopulateTicketsList()
        {
            // 1. Refresh Summary Cards
            int total = TicketStore.GetTotalCount();
            int valid = TicketStore.GetValidCount();
            int boarded = TicketStore.GetBoardedCount();
            int cancelled = TicketStore.GetCancelledCount();
            int today = TicketStore.GetTodayBoardingCount();

            lblMetricTotalTicketsVal.Text = total.ToString("N0");
            lblMetricTotalTicketsSub.Text = $"{valid} ready for boarding";

            lblMetricValidTicketsVal.Text = valid.ToString("N0");
            lblMetricValidTicketsSub.Text = total > 0 ? $"{(valid * 100.0 / total):F0}% of total issued" : "0%";

            lblMetricBoardedTicketsVal.Text = boarded.ToString("N0");
            lblMetricBoardedTicketsSub.Text = "Passengers cleared";

            lblMetricCancelledTicketsVal.Text = cancelled.ToString("N0");
            lblMetricCancelledTicketsSub.Text = "Voided or refunded";

            lblMetricTodayTicketsVal.Text = today.ToString("N0");
            lblMetricTodayTicketsSub.Text = "Departures today";

            // 2. Synchronize route dropdown items if needed
            if (cmbTicketRouteFilter.Items.Count <= 1)
            {
                cmbTicketRouteFilter.Items.Clear();
                cmbTicketRouteFilter.Items.Add("All Routes / Trips");
                var activeRoutes = RouteStore.GetAll();
                foreach (var r in activeRoutes)
                {
                    cmbTicketRouteFilter.Items.Add($"{r.RouteId}: {r.RouteName}");
                }
                cmbTicketRouteFilter.SelectedIndex = 0;
            }

            // 3. Filter Tickets
            string search = txtSearchTicketFilter.Text.Trim().ToLower();
            string statusFilter = cmbTicketStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            string routeFilter = cmbTicketRouteFilter.SelectedItem?.ToString() ?? "All Routes / Trips";
            bool filterDate = chkEnableTicketDateFilter.Checked;
            DateTime targetDate = dtpTicketFilterDate.Value.Date;

            var all = TicketStore.GetAll();
            var filtered = all.Where(t =>
            {
                // Search condition
                bool match = string.IsNullOrEmpty(search) ||
                    t.TicketId.ToLower().Contains(search) ||
                    t.BookingId.ToLower().Contains(search) ||
                    t.PassengerName.ToLower().Contains(search) ||
                    t.PassengerPhone.ToLower().Contains(search) ||
                    t.RouteName.ToLower().Contains(search) ||
                    t.Source.ToLower().Contains(search) ||
                    t.Destination.ToLower().Contains(search) ||
                    t.AssignedBusPlate.ToLower().Contains(search) ||
                    t.GateNumber.ToLower().Contains(search) ||
                    t.SecurityVerificationCode.ToLower().Contains(search);

                if (!match) return false;

                // Status
                if (statusFilter != "All Statuses" && !t.Status.Equals(statusFilter, StringComparison.OrdinalIgnoreCase))
                {
                    return false;
                }

                // Route
                if (routeFilter != "All Routes / Trips")
                {
                    string routeIdPrefix = routeFilter.Split(':')[0].Trim();
                    if (!t.RouteId.Equals(routeIdPrefix, StringComparison.OrdinalIgnoreCase) &&
                        !t.RouteName.Equals(routeFilter, StringComparison.OrdinalIgnoreCase))
                    {
                        return false;
                    }
                }

                // Date
                if (filterDate && t.TravelDate.Date != targetDate)
                {
                    return false;
                }

                return true;
            }).OrderByDescending(t => t.TravelDate).ThenByDescending(t => t.IssuedDate).ToList();

            // 4. Populate ListView
            lvTickets.BeginUpdate();
            lvTickets.Items.Clear();

            foreach (var t in filtered)
            {
                var item = new ListViewItem(t.TicketId);
                item.SubItems.Add(t.BookingId);
                item.SubItems.Add(t.PassengerName);
                item.SubItems.Add(t.PassengerPhone);
                item.SubItems.Add(t.FullRouteDisplay);
                item.SubItems.Add(t.TravelDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add($"{t.DepartureTime} ({t.GateNumber})");
                item.SubItems.Add(t.SeatDisplay);
                item.SubItems.Add(t.AssignedBusPlate);
                item.SubItems.Add(t.Status);

                item.Tag = t;

                // Visual row styling
                if (t.Status == "Cancelled")
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184); // Slate muted
                }
                else if (t.Status == "Boarded")
                {
                    item.ForeColor = Color.FromArgb(22, 101, 52); // Dark Green
                }
                else
                {
                    item.ForeColor = Color.FromArgb(15, 23, 42); // Normal
                }

                lvTickets.Items.Add(item);
            }

            lvTickets.EndUpdate();
            lblTicketCount.Text = $"Showing {filtered.Count} of {all.Count} tickets";
        }

        private Ticket? GetSelectedTicket()
        {
            if (lvTickets.SelectedItems.Count > 0 && lvTickets.SelectedItems[0].Tag is Ticket ticket)
            {
                return ticket;
            }
            return null;
        }

        private void OpenIssueTicketDialog(Booking? booking = null)
        {
            using (var dialog = new TicketDialogForm())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateTicketsList();
                }
            }
        }

        private void OpenBoardingScannerDialog(string? initialLookup = null)
        {
            using (var scanner = new TicketVerifyDialogForm(initialLookup))
            {
                scanner.ShowDialog(this);
                PopulateTicketsList();
            }
        }

        private void QuickVerifyAndBoardSelectedTicket()
        {
            var ticket = GetSelectedTicket();
            if (ticket == null)
            {
                MessageBox.Show("Please select a ticket from the table to verify and board passenger.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool success = TicketStore.VerifyAndBoard(ticket.TicketId, "Gate Officer / Admin", out string msg, out var updatedTicket);
            if (success)
            {
                PopulateTicketsList();
                MessageBox.Show(
                    $"BOARDING VERIFIED SUCCESSFULLY!\n\n" +
                    $"• Ticket:    {ticket.TicketId}\n" +
                    $"• Passenger: {ticket.PassengerName}\n" +
                    $"• Journey:   {ticket.FullRouteDisplay}\n" +
                    $"• Seat:      {ticket.SeatDisplay}\n" +
                    $"• Coach:     {ticket.AssignedBusPlate} ({ticket.GateNumber})\n\n" +
                    $"Passenger is authorized to board.",
                    "Boarding Verified",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(msg, "Boarding Verification Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ViewSelectedTicketDetails()
        {
            var ticket = GetSelectedTicket();
            if (ticket == null)
            {
                MessageBox.Show("Please select a ticket from the table to view details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string details = $"====================================================\n" +
                             $"             OFFICIAL PASSENGER TICKET             \n" +
                             $"====================================================\n\n" +
                             $"• Ticket Reference:    {ticket.TicketId}\n" +
                             $"• Linked Booking ID:   {ticket.BookingId}\n" +
                             $"• Security Hash:       {ticket.SecurityVerificationCode}\n" +
                             $"• Ticket Status:       {ticket.Status.ToUpper()}\n" +
                             $"• Issue Date:          {ticket.IssuedDate:yyyy-MM-dd HH:mm:ss}\n\n" +
                             $"--- PASSENGER DETAILS ---\n" +
                             $"• Full Name:           {ticket.PassengerName}\n" +
                             $"• Contact Phone:       {ticket.PassengerPhone}\n" +
                             $"• Email Address:       {(string.IsNullOrWhiteSpace(ticket.PassengerEmail) ? "N/A" : ticket.PassengerEmail)}\n\n" +
                             $"--- JOURNEY & VEHICLE SPECIFICATIONS ---\n" +
                             $"• Route:               {ticket.FullRouteDisplay} ({ticket.RouteName})\n" +
                             $"• Departure Date:      {ticket.TravelDate:dddd, MMMM dd, yyyy}\n" +
                             $"• Departure Time:      {ticket.DepartureTime}\n" +
                             $"• Assigned Gate:       {ticket.GateNumber}\n" +
                             $"• Coach Vehicle:       {ticket.AssignedBusPlate} ({ticket.BusModel})\n" +
                             $"• Allocated Seat:      {ticket.SeatDisplay}\n\n" +
                             $"--- BOARDING & VERIFICATION STATUS ---\n" +
                             $"• Boarding Time:       {(ticket.BoardedTime.HasValue ? ticket.BoardedTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "Not Boarded Yet")}\n" +
                             $"• Verified By:         {(string.IsNullOrWhiteSpace(ticket.VerifiedBy) ? "Pending Gate Check-in" : ticket.VerifiedBy)}\n" +
                             $"• Fare Paid:           {ticket.FareAmount:N0} ETB\n" +
                             $"• Luggage Allowance:   {ticket.LuggageAllowance}\n\n" +
                             $"--- INSTRUCTIONS & REMARKS ---\n" +
                             $"{(string.IsNullOrWhiteSpace(ticket.Notes) ? "(No extra remarks logged)" : ticket.Notes)}";

            MessageBox.Show(details, $"Ticket Dossier - {ticket.TicketId} ({ticket.PassengerName})", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintSelectedBoardingPass()
        {
            var ticket = GetSelectedTicket();
            if (ticket == null)
            {
                MessageBox.Show("Please select a ticket from the table to preview or print boarding pass.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ticket.Status == "Cancelled")
            {
                MessageBox.Show(
                    $"Cannot generate or print a boarding pass for ticket '{ticket.TicketId}' because it has been CANCELLED.",
                    "Invalid Request",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string passPreview =
                "============================================================\n" +
                "       ETHIOPIAN INTERCITY TRANSPORT - BOARDING PASS        \n" +
                "============================================================\n\n" +
                $" BOARDING PASS NO:     {ticket.TicketId}\n" +
                $" BOOKING REFERENCE:    {ticket.BookingId}\n" +
                $" SECURITY BARCODE:     {ticket.SecurityVerificationCode}\n" +
                "------------------------------------------------------------\n" +
                $" PASSENGER NAME:       {ticket.PassengerName.ToUpper()}\n" +
                $" CONTACT PHONE:        {ticket.PassengerPhone}\n" +
                $" JOURNEY:              {ticket.Source} ➔ {ticket.Destination}\n" +
                $" SERVICE ROUTE:        {ticket.RouteName}\n" +
                $" DEPARTURE DATE:       {ticket.TravelDate:dddd, MMMM dd, yyyy}\n" +
                $" SCHEDULED TIME:       {ticket.DepartureTime}\n" +
                $" DEPARTURE GATE:       {ticket.GateNumber}\n" +
                $" COACH ASSIGNED:       {ticket.AssignedBusPlate} ({ticket.BusModel})\n" +
                $" ALLOCATED SEAT:       {ticket.SeatDisplay}\n" +
                "------------------------------------------------------------\n" +
                $" TOTAL FARE PAID:      {ticket.FareAmount:N0} ETB (PAID IN FULL)\n" +
                $" LUGGAGE ALLOWANCE:    {ticket.LuggageAllowance}\n" +
                $" TICKET STATUS:        {ticket.Status.ToUpper()}\n" +
                $" ISSUED TIMESTAMP:     {ticket.IssuedDate:yyyy-MM-dd HH:mm}\n" +
                "============================================================\n" +
                " SECURITY NOTICE & PASSENGER OBLIGATIONS:\n" +
                " 1. Please arrive at departure gate 30 minutes before departure.\n" +
                " 2. Official Ethiopian ID (Kebele ID / Passport) is strictly required.\n" +
                " 3. Tickets are non-transferable once verified at the boarding gate.\n" +
                "============================================================";

            MessageBox.Show(passPreview, $"Boarding Pass - {ticket.TicketId} ({ticket.PassengerName})", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelSelectedTicket()
        {
            var ticket = GetSelectedTicket();
            if (ticket == null)
            {
                MessageBox.Show("Please select a ticket from the table to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ticket.Status == "Cancelled")
            {
                MessageBox.Show($"Ticket '{ticket.TicketId}' is already Cancelled.", "Already Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (ticket.Status == "Boarded")
            {
                MessageBox.Show(
                    $"Ticket '{ticket.TicketId}' CANNOT be cancelled because the passenger has already verified and boarded the coach.\n\n" +
                    $"Business Rule:\n" +
                    $"Boarded tickets are locked and cannot be voided without administrative security clearance.",
                    "Cancellation Forbidden",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to CANCEL ticket '{ticket.TicketId}'?\n\n" +
                $"Passenger:  {ticket.PassengerName}\n" +
                $"Route:      {ticket.FullRouteDisplay}\n" +
                $"Seat:       {ticket.SeatDisplay}\n" +
                $"Fare:       {ticket.FareAmount:N0} ETB\n\n" +
                $"This will void the boarding pass and mark the ticket as Cancelled.",
                "Confirm Ticket Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool success = TicketStore.CancelTicket(ticket.TicketId, out string msg);
                if (success)
                {
                    PopulateTicketsList();
                    MessageBox.Show(
                        $"Ticket '{ticket.TicketId}' was successfully CANCELLED.",
                        "Cancellation Confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show(msg, "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        private void SetupSidebarButton(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                if (btn.BackColor != Color.FromArgb(13, 94, 234))
                {
                    btn.BackColor = Color.FromArgb(226, 232, 240);
                    btn.ForeColor = Color.FromArgb(15, 23, 42);
                }
            };
            btn.MouseLeave += (s, e) =>
            {
                if (btn.BackColor != Color.FromArgb(13, 94, 234))
                {
                    btn.BackColor = Color.Transparent;
                    btn.ForeColor = Color.FromArgb(51, 65, 85);
                }
            };
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

                using (var scanner = new TicketVerifyDialogForm(ticketId))
                {
                    scanner.ShowDialog(this);
                    PopulateTicketsList();
                }
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

            var trips = TripScheduleStore.GetAll();
            foreach (var t in trips)
            {
                dt.Rows.Add(t.TripId, t.RouteName, t.BusPlate, t.DriverName, t.DepartureTime, t.OccupancyText, t.Status);
            }

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

        private void btnNavBuses_Click(object sender, EventArgs e)
        {

        }

        private void btnNavBookings_Click(object sender, EventArgs e)
        {

        }

        private void btnNavUsers_Click(object sender, EventArgs e)
        {

        }
    }
}

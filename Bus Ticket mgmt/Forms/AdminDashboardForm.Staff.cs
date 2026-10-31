using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class AdminDashboardForm
    {
        private Panel panelStaffManagement = null!;
        private DataGridView dgvStaff = null!;
        private TextBox txtSearchStaff = null!;
        private ComboBox cmbStaffRoleFilter = null!;
        private ComboBox cmbStaffStatusFilter = null!;
        private Label lblStaffMetricTotalVal = null!;
        private Label lblStaffMetricDriversVal = null!;
        private Label lblStaffMetricOfficersVal = null!;
        private Label lblStaffMetricActiveVal = null!;
        private Label lblStaffCount = null!;

        private void InitializeStaffManagement()
        {
            panelStaffManagement = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 250, 252),
                AutoScroll = true,
                Visible = false
            };

            // 1. Header
            Panel header = new Panel { Dock = DockStyle.Top, Height = 56, BackColor = Color.White, Padding = new Padding(24, 8, 24, 8) };
            header.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(pen, 0, header.Height - 1, header.Width, header.Height - 1);
                }
            };

            Label title = new Label
            {
                Text = "Driver & Staff Management",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                AutoSize = true
            };

            Button btnAddStaff = new Button
            {
                Text = "+ Register New Staff",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(13, 94, 234),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 36),
                Location = new Point(header.Width - 210, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand
            };
            btnAddStaff.FlatAppearance.BorderSize = 0;
            btnAddStaff.Click += (s, e) => OpenRegisterStaffDialog();

            header.Controls.Add(title);
            header.Controls.Add(btnAddStaff);
            panelStaffManagement.Controls.Add(header);

            // 2. Metrics Bar
            FlowLayoutPanel flowMetrics = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 80,
                Padding = new Padding(20, 8, 20, 4),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            var (m1, _, l1) = CreateMetricCard("Total Staff", "0", "All operations workforce", Color.FromArgb(13, 94, 234));
            lblStaffMetricTotalVal = l1;
            flowMetrics.Controls.Add(m1);

            var (m2, _, l2) = CreateMetricCard("Certified Drivers", "0", "Highway licensed captains", Color.FromArgb(16, 185, 129));
            lblStaffMetricDriversVal = l2;
            flowMetrics.Controls.Add(m2);

            var (m3, _, l3) = CreateMetricCard("Ticket Officers", "0", "Terminal counter staff", Color.FromArgb(99, 102, 241));
            lblStaffMetricOfficersVal = l3;
            flowMetrics.Controls.Add(m3);

            var (m4, _, l4) = CreateMetricCard("Active On-Duty", "0", "Ready for deployment", Color.FromArgb(245, 158, 11));
            lblStaffMetricActiveVal = l4;
            flowMetrics.Controls.Add(m4);

            panelStaffManagement.Controls.Add(flowMetrics);

            // 3. Toolbar
            Panel toolbar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                Padding = new Padding(24, 8, 24, 8),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            txtSearchStaff = new TextBox
            {
                Font = new Font("Segoe UI", 10f),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                Width = 260,
                PlaceholderText = "Search staff name, role, phone..."
            };
            txtSearchStaff.TextChanged += (s, e) => PopulateStaffList();

            cmbStaffRoleFilter = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(296, 12),
                Width = 150
            };
            cmbStaffRoleFilter.Items.AddRange(new object[] { "All Staff Roles", "Driver", "Ticket Officer", "Bus Manager", "Administrator" });
            cmbStaffRoleFilter.SelectedIndex = 0;
            cmbStaffRoleFilter.SelectedIndexChanged += (s, e) => PopulateStaffList();

            cmbStaffStatusFilter = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(456, 12),
                Width = 130
            };
            cmbStaffStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Inactive" });
            cmbStaffStatusFilter.SelectedIndex = 0;
            cmbStaffStatusFilter.SelectedIndexChanged += (s, e) => PopulateStaffList();

            Button btnResetStaff = new Button
            {
                Text = "Reset Filters",
                Font = new Font("Segoe UI", 9f),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(596, 11),
                Size = new Size(100, 28)
            };
            btnResetStaff.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetStaff.Click += (s, e) =>
            {
                txtSearchStaff.Text = "";
                cmbStaffRoleFilter.SelectedIndex = 0;
                cmbStaffStatusFilter.SelectedIndex = 0;
                PopulateStaffList();
            };

            lblStaffCount = new Label
            {
                Text = "Showing 0 staff members",
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(toolbar.Width - 190, 16),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true
            };

            toolbar.Controls.Add(txtSearchStaff);
            toolbar.Controls.Add(cmbStaffRoleFilter);
            toolbar.Controls.Add(cmbStaffStatusFilter);
            toolbar.Controls.Add(btnResetStaff);
            toolbar.Controls.Add(lblStaffCount);
            panelStaffManagement.Controls.Add(toolbar);

            // 4. DataGridView
            Panel gridContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 4, 24, 60),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            dgvStaff = new DataGridView
            {
                Dock = DockStyle.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                RowHeadersVisible = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                EnableHeadersVisualStyles = false
            };
            dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.2f, FontStyle.Bold);
            dgvStaff.DefaultCellStyle.Font = new Font("Segoe UI", 9.2f);
            dgvStaff.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvStaff.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

            gridContainer.Controls.Add(dgvStaff);
            panelStaffManagement.Controls.Add(gridContainer);

            // 5. Action Bar
            Panel actionBar = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 52,
                BackColor = Color.White,
                Padding = new Padding(24, 8, 24, 8)
            };
            actionBar.Paint += (s, e) =>
            {
                using (Pen p = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(p, 0, 0, actionBar.Width, 0);
                }
            };

            Button btnProfile = new Button
            {
                Text = "👤 Staff Dossier & Rating",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 36),
                Location = new Point(24, 8),
                Cursor = Cursors.Hand
            };
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnProfile.Click += (s, e) => ViewSelectedStaffProfile();

            Button btnToggleStatus = new Button
            {
                Text = "🔄 Toggle Active / Inactive",
                Font = new Font("Segoe UI", 9f),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 36),
                Location = new Point(214, 8),
                Cursor = Cursors.Hand
            };
            btnToggleStatus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnToggleStatus.Click += (s, e) => ToggleSelectedStaffStatus();

            actionBar.Controls.Add(btnProfile);
            actionBar.Controls.Add(btnToggleStatus);
            panelStaffManagement.Controls.Add(actionBar);

            this.panelMain.Controls.Add(panelStaffManagement);
        }

        public void ShowStaffManagementView()
        {
            HideAllPanels();
            panelStaffManagement.Visible = true;
            panelStaffManagement.BringToFront();
            SetActiveSidebarButton(btnNavStaff);
            lblPageHeading.Text = "Driver & Staff Management";
            lblPageSubHeading.Text = "Manage drivers, ticket officers, fleet dispatchers, and monitor workforce readiness.";
            PopulateStaffList();
        }

        public void PopulateStaffList()
        {
            if (dgvStaff == null) return;

            // Get all non-passenger staff
            var staffList = UserStore.GetAll().Where(u => u.Role != "Passenger").ToList();

            // Search
            string search = txtSearchStaff?.Text.Trim().ToLowerInvariant() ?? "";
            if (!string.IsNullOrEmpty(search))
            {
                staffList = staffList.Where(u => u.FullName.ToLowerInvariant().Contains(search) ||
                                                 u.Role.ToLowerInvariant().Contains(search) ||
                                                 u.Phone.ToLowerInvariant().Contains(search) ||
                                                 u.Email.ToLowerInvariant().Contains(search) ||
                                                 u.Address.ToLowerInvariant().Contains(search)).ToList();
            }

            // Role filter
            string roleFilter = cmbStaffRoleFilter?.SelectedItem?.ToString() ?? "All Staff Roles";
            if (roleFilter != "All Staff Roles")
            {
                staffList = staffList.Where(u => u.Role.Equals(roleFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Status filter
            string statusFilter = cmbStaffStatusFilter?.SelectedItem?.ToString() ?? "All Statuses";
            if (statusFilter != "All Statuses")
            {
                staffList = staffList.Where(u => u.Status.Equals(statusFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Metrics
            int total = UserStore.GetAll().Count(u => u.Role != "Passenger");
            int drivers = UserStore.GetAll().Count(u => u.Role == "Driver");
            int officers = UserStore.GetAll().Count(u => u.Role == "Ticket Officer");
            int active = UserStore.GetAll().Count(u => u.Role != "Passenger" && u.Status == "Active");

            if (lblStaffMetricTotalVal != null) lblStaffMetricTotalVal.Text = total.ToString();
            if (lblStaffMetricDriversVal != null) lblStaffMetricDriversVal.Text = drivers.ToString();
            if (lblStaffMetricOfficersVal != null) lblStaffMetricOfficersVal.Text = officers.ToString();
            if (lblStaffMetricActiveVal != null) lblStaffMetricActiveVal.Text = active.ToString();
            if (lblStaffCount != null) lblStaffCount.Text = $"Showing {staffList.Count} staff members";

            var dtTable = new System.Data.DataTable();
            dtTable.Columns.Add("Staff ID");
            dtTable.Columns.Add("Full Name");
            dtTable.Columns.Add("Role / Position");
            dtTable.Columns.Add("Contact Phone");
            dtTable.Columns.Add("Official Email");
            dtTable.Columns.Add("Base Terminal / Station");
            dtTable.Columns.Add("Status");
            dtTable.Columns.Add("Registration Date");

            foreach (var s in staffList)
            {
                dtTable.Rows.Add(
                    s.UserId,
                    s.FullName,
                    s.Role,
                    s.Phone,
                    s.Email,
                    s.Address,
                    s.Status,
                    s.CreatedDate.ToString("yyyy-MM-dd")
                );
            }

            dgvStaff.DataSource = dtTable;
        }

        private void ViewSelectedStaffProfile()
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member from the table.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string staffId = dgvStaff.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var staff = UserStore.GetById(staffId);
            if (staff == null) return;

            string licenseInfo = (staff.Role == "Driver") ?
                "Commercial Driving License: Grade 4 (Heavy Passenger Coach)\n" +
                "Driver Safety Record: 100% (No safety infractions recorded)\n" +
                "Emergency First-Aid: Certified (Red Cross Ethiopia)\n" :
                "Terminal Clearance: Level 2 Cashier & Manifest Authority\n" +
                "System Access: Ticket Officer & Customer Support Desk\n";

            string profile =
                $"==============================================\n" +
                $"          OFFICIAL STAFF DOSSIER\n" +
                $"==============================================\n\n" +
                $"Staff ID:         {staff.UserId}\n" +
                $"Full Name:        {staff.FullName}\n" +
                $"Assigned Role:    {staff.Role}\n" +
                $"Contact Phone:    {staff.Phone}\n" +
                $"System Email:     {staff.Email}\n" +
                $"Base Station:     {staff.Address}\n" +
                $"Employment Status:{staff.Status.ToUpper()}\n" +
                $"Date Onboarded:   {staff.CreatedDate:yyyy-MM-dd}\n\n" +
                $"QUALIFICATIONS & LICENSING:\n" +
                $"{licenseInfo}\n" +
                $"==============================================\n";

            MessageBox.Show(profile, $"Dossier - {staff.FullName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToggleSelectedStaffStatus()
        {
            if (dgvStaff.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a staff member from the table.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string staffId = dgvStaff.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var staff = UserStore.GetById(staffId);
            if (staff == null) return;

            string newStatus = (staff.Status == "Active") ? "Inactive" : "Active";
            staff.Status = newStatus;
            UserStore.Update(staff);

            MessageBox.Show($"Staff member {staff.FullName} is now marked as '{newStatus}'.", "Status Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateStaffList();
        }

        private void OpenRegisterStaffDialog()
        {
            using (var form = new Form())
            {
                form.Text = "Register Staff Member";
                form.Size = new Size(460, 480);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.BackColor = Color.White;

                Label lblN = new Label { Text = "Full Name:", Location = new Point(24, 20), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtN = new TextBox { Location = new Point(24, 42), Width = 390 };

                Label lblR = new Label { Text = "Operational Role:", Location = new Point(24, 80), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbR = new ComboBox { Location = new Point(24, 102), Width = 390, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbR.Items.AddRange(new object[] { "Driver", "Ticket Officer", "Bus Manager" });
                cmbR.SelectedIndex = 0;

                Label lblP = new Label { Text = "Phone Number:", Location = new Point(24, 140), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtP = new TextBox { Location = new Point(24, 162), Width = 180, Text = "+251 9" };

                Label lblE = new Label { Text = "Email Address:", Location = new Point(234, 140), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtE = new TextBox { Location = new Point(234, 162), Width = 180, Text = "@busbook.et" };

                Label lblA = new Label { Text = "Terminal Station / City:", Location = new Point(24, 200), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtA = new TextBox { Location = new Point(24, 222), Width = 390, Text = "Autobus Tera Hub, Addis Ababa" };

                Label lblPass = new Label { Text = "Initial Password:", Location = new Point(24, 260), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtPass = new TextBox { Location = new Point(24, 282), Width = 390, Text = "pass1234" };

                Button btnSave = new Button
                {
                    Text = "Register Staff",
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(13, 94, 234),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(160, 38),
                    Location = new Point(140, 350),
                    Cursor = Cursors.Hand
                };
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Click += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(txtN.Text) || string.IsNullOrWhiteSpace(txtP.Text))
                    {
                        MessageBox.Show("Please enter staff name and phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newUser = new User(
                        UserStore.GenerateNextId(),
                        txtN.Text.Trim(),
                        txtN.Text.Trim().ToLower().Replace(" ", "."),
                        txtE.Text.Trim(),
                        txtP.Text.Trim(),
                        txtA.Text.Trim(),
                        txtPass.Text.Trim(),
                        cmbR.SelectedItem?.ToString() ?? "Driver",
                        "Active",
                        DateTime.Now
                    );

                    UserStore.Add(newUser);
                    MessageBox.Show($"Staff member '{newUser.FullName}' registered successfully with ID {newUser.UserId}!", "Staff Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.Controls.Add(lblN); form.Controls.Add(txtN);
                form.Controls.Add(lblR); form.Controls.Add(cmbR);
                form.Controls.Add(lblP); form.Controls.Add(txtP);
                form.Controls.Add(lblE); form.Controls.Add(txtE);
                form.Controls.Add(lblA); form.Controls.Add(txtA);
                form.Controls.Add(lblPass); form.Controls.Add(txtPass);
                form.Controls.Add(btnSave);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateStaffList();
                }
            }
        }
    }
}

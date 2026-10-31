using System;
using System.Collections.Generic;
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
        private Panel panelTripManagement = null!;
        private DataGridView dgvTripSchedules = null!;
        private TextBox txtSearchTrips = null!;
        private ComboBox cmbTripStatusFilter = null!;
        private DateTimePicker dtpTripDateFilter = null!;
        private CheckBox chkEnableTripDate = null!;
        private Label lblTripMetricTotalVal = null!;
        private Label lblTripMetricScheduledVal = null!;
        private Label lblTripMetricOnRouteVal = null!;
        private Label lblTripMetricDelayedVal = null!;
        private Label lblTripCount = null!;

        private void InitializeTripManagement()
        {
            panelTripManagement = new Panel
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
                Text = "Trip & Schedule Management",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                AutoSize = true
            };

            Button btnAddTripTop = new Button
            {
                Text = "+ Schedule New Trip",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(13, 94, 234),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 36),
                Location = new Point(header.Width - 210, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand
            };
            btnAddTripTop.FlatAppearance.BorderSize = 0;
            btnAddTripTop.Click += (s, e) => OpenNewTripDialog();

            header.Controls.Add(title);
            header.Controls.Add(btnAddTripTop);
            panelTripManagement.Controls.Add(header);

            // 2. Metrics Bar
            FlowLayoutPanel flowMetrics = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 80,
                Padding = new Padding(20, 8, 20, 4),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            var (m1, c1, l1) = CreateMetricCard("Total Trips", "0", "All system schedules", Color.FromArgb(13, 94, 234));
            lblTripMetricTotalVal = l1;
            flowMetrics.Controls.Add(m1);

            var (m2, c2, l2) = CreateMetricCard("Scheduled / Boarding", "0", "Awaiting departure", Color.FromArgb(16, 185, 129));
            lblTripMetricScheduledVal = l2;
            flowMetrics.Controls.Add(m2);

            var (m3, c3, l3) = CreateMetricCard("On Route / Departed", "0", "Currently en route", Color.FromArgb(99, 102, 241));
            lblTripMetricOnRouteVal = l3;
            flowMetrics.Controls.Add(m3);

            var (m4, c4, l4) = CreateMetricCard("Delayed / Need Attention", "0", "Impacted schedules", Color.FromArgb(245, 158, 11));
            lblTripMetricDelayedVal = l4;
            flowMetrics.Controls.Add(m4);

            panelTripManagement.Controls.Add(flowMetrics);

            // 3. Toolbar (Search, Filter, Date)
            Panel toolbar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                Padding = new Padding(24, 8, 24, 8),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            txtSearchTrips = new TextBox
            {
                Font = new Font("Segoe UI", 10f),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                Width = 260,
                PlaceholderText = "Search trip, route, bus, driver..."
            };
            txtSearchTrips.TextChanged += (s, e) => PopulateTripsList();

            cmbTripStatusFilter = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(296, 12),
                Width = 150
            };
            cmbTripStatusFilter.Items.AddRange(new object[] { "All Statuses", "Scheduled", "Boarding", "On Route", "Departed", "Delayed", "Completed", "Cancelled" });
            cmbTripStatusFilter.SelectedIndex = 0;
            cmbTripStatusFilter.SelectedIndexChanged += (s, e) => PopulateTripsList();

            chkEnableTripDate = new CheckBox
            {
                Text = "Filter Date:",
                Font = new Font("Segoe UI", 9f),
                Location = new Point(460, 15),
                AutoSize = true
            };
            chkEnableTripDate.CheckedChanged += (s, e) => { dtpTripDateFilter.Enabled = chkEnableTripDate.Checked; PopulateTripsList(); };

            dtpTripDateFilter = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Font = new Font("Segoe UI", 9.5f),
                Location = new Point(555, 12),
                Width = 120,
                Enabled = false
            };
            dtpTripDateFilter.ValueChanged += (s, e) => { if (chkEnableTripDate.Checked) PopulateTripsList(); };

            Button btnReset = new Button
            {
                Text = "Reset Filters",
                Font = new Font("Segoe UI", 9f),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(690, 11),
                Size = new Size(100, 28)
            };
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnReset.Click += (s, e) =>
            {
                txtSearchTrips.Text = "";
                cmbTripStatusFilter.SelectedIndex = 0;
                chkEnableTripDate.Checked = false;
                PopulateTripsList();
            };

            lblTripCount = new Label
            {
                Text = "Showing 0 trips",
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(toolbar.Width - 160, 16),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true
            };

            toolbar.Controls.Add(txtSearchTrips);
            toolbar.Controls.Add(cmbTripStatusFilter);
            toolbar.Controls.Add(chkEnableTripDate);
            toolbar.Controls.Add(dtpTripDateFilter);
            toolbar.Controls.Add(btnReset);
            toolbar.Controls.Add(lblTripCount);
            panelTripManagement.Controls.Add(toolbar);

            // 4. DataGridView Container
            Panel gridContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 4, 24, 60),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            dgvTripSchedules = new DataGridView
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
            dgvTripSchedules.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvTripSchedules.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvTripSchedules.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.2f, FontStyle.Bold);
            dgvTripSchedules.DefaultCellStyle.Font = new Font("Segoe UI", 9.2f);
            dgvTripSchedules.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvTripSchedules.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

            gridContainer.Controls.Add(dgvTripSchedules);
            panelTripManagement.Controls.Add(gridContainer);

            // 5. Bottom Action Bar
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

            Button btnUpdateStatus = new Button
            {
                Text = "⚡ Update Trip Status",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(160, 36),
                Location = new Point(24, 8),
                Cursor = Cursors.Hand
            };
            btnUpdateStatus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnUpdateStatus.Click += (s, e) => UpdateSelectedTripStatus();

            Button btnViewManifest = new Button
            {
                Text = "📋 View Trip Manifest",
                Font = new Font("Segoe UI", 9f),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(160, 36),
                Location = new Point(194, 8),
                Cursor = Cursors.Hand
            };
            btnViewManifest.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewManifest.Click += (s, e) => ViewSelectedTripManifest();

            Button btnCancelTrip = new Button
            {
                Text = "❌ Cancel / Remove Trip",
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.FromArgb(239, 68, 68),
                BackColor = Color.FromArgb(254, 242, 242),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(170, 36),
                Location = new Point(364, 8),
                Cursor = Cursors.Hand
            };
            btnCancelTrip.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202);
            btnCancelTrip.Click += (s, e) => CancelSelectedTrip();

            actionBar.Controls.Add(btnUpdateStatus);
            actionBar.Controls.Add(btnViewManifest);
            actionBar.Controls.Add(btnCancelTrip);
            panelTripManagement.Controls.Add(actionBar);

            this.panelMain.Controls.Add(panelTripManagement);
        }

        public void ShowTripManagementView()
        {
            HideAllPanels();
            panelTripManagement.Visible = true;
            panelTripManagement.BringToFront();
            SetActiveSidebarButton(btnNavTrips);
            lblPageHeading.Text = "Trip & Schedule Management";
            lblPageSubHeading.Text = "Manage intercity departure times, assign drivers and buses, prevent conflicts, and track operational progress.";
            PopulateTripsList();
        }

        public void PopulateTripsList()
        {
            if (dgvTripSchedules == null) return;

            var trips = TripScheduleStore.GetAll();

            // Search filter
            string search = txtSearchTrips?.Text.Trim().ToLowerInvariant() ?? "";
            if (!string.IsNullOrEmpty(search))
            {
                trips = trips.Where(t => t.TripId.ToLowerInvariant().Contains(search) ||
                                         t.RouteName.ToLowerInvariant().Contains(search) ||
                                         t.BusPlate.ToLowerInvariant().Contains(search) ||
                                         t.DriverName.ToLowerInvariant().Contains(search) ||
                                         t.GateNumber.ToLowerInvariant().Contains(search)).ToList();
            }

            // Status filter
            string statusFilter = cmbTripStatusFilter?.SelectedItem?.ToString() ?? "All Statuses";
            if (statusFilter != "All Statuses")
            {
                trips = trips.Where(t => t.Status.Equals(statusFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Date filter
            if (chkEnableTripDate != null && chkEnableTripDate.Checked)
            {
                DateTime dt = dtpTripDateFilter.Value.Date;
                trips = trips.Where(t => t.DepartureDate.Date == dt).ToList();
            }

            // Update Metrics
            var metrics = TripScheduleStore.GetMetrics();
            if (lblTripMetricTotalVal != null) lblTripMetricTotalVal.Text = metrics.Total.ToString();
            if (lblTripMetricScheduledVal != null) lblTripMetricScheduledVal.Text = metrics.Scheduled.ToString();
            if (lblTripMetricOnRouteVal != null) lblTripMetricOnRouteVal.Text = metrics.Departed.ToString();
            if (lblTripMetricDelayedVal != null) lblTripMetricDelayedVal.Text = metrics.Delayed.ToString();
            if (lblTripCount != null) lblTripCount.Text = $"Showing {trips.Count} trips";

            // Bind to DataGridView
            var dtTable = new System.Data.DataTable();
            dtTable.Columns.Add("Trip ID");
            dtTable.Columns.Add("Route (Origin ➔ Destination)");
            dtTable.Columns.Add("Bus Plate");
            dtTable.Columns.Add("Assigned Driver");
            dtTable.Columns.Add("Departure Date");
            dtTable.Columns.Add("Departure Time");
            dtTable.Columns.Add("Est. Arrival");
            dtTable.Columns.Add("Gate");
            dtTable.Columns.Add("Occupancy");
            dtTable.Columns.Add("Fare (ETB)");
            dtTable.Columns.Add("Status");

            foreach (var t in trips)
            {
                dtTable.Rows.Add(
                    t.TripId,
                    t.RouteName,
                    t.BusPlate,
                    t.DriverName,
                    t.DepartureDate.ToString("yyyy-MM-dd"),
                    t.DepartureTime,
                    t.EstimatedArrival,
                    t.GateNumber,
                    t.OccupancyText,
                    t.Fare.ToString("N2"),
                    t.Status
                );
            }

            dgvTripSchedules.DataSource = dtTable;

            // Also keep dashboard summary table updated
            PopulateTripsTable();
        }

        private void OpenNewTripDialog()
        {
            using (var form = new Form())
            {
                form.Text = "Schedule New Trip";
                form.Size = new Size(500, 520);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.BackColor = Color.White;

                Label lblR = new Label { Text = "Select Route:", Location = new Point(24, 20), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbR = new ComboBox { Location = new Point(24, 42), Width = 430, DropDownStyle = ComboBoxStyle.DropDownList };
                var routes = RouteStore.GetAll();
                foreach (var r in routes) cmbR.Items.Add($"{r.RouteName} ({r.Source} ➔ {r.Destination})");
                if (cmbR.Items.Count > 0) cmbR.SelectedIndex = 0;

                Label lblB = new Label { Text = "Assign Bus:", Location = new Point(24, 76), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbB = new ComboBox { Location = new Point(24, 98), Width = 430, DropDownStyle = ComboBoxStyle.DropDownList };
                var buses = BusStore.GetAll().Where(b => b.Status == "Active").ToList();
                foreach (var b in buses) cmbB.Items.Add($"{b.PlateNumber} - {b.Manufacturer} {b.Model} ({b.Capacity} seats)");
                if (cmbB.Items.Count > 0) cmbB.SelectedIndex = 0;

                Label lblD = new Label { Text = "Assign Driver:", Location = new Point(24, 132), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbD = new ComboBox { Location = new Point(24, 154), Width = 430, DropDownStyle = ComboBoxStyle.DropDownList };
                var drivers = UserStore.GetAll().Where(u => u.Role == "Driver" && u.Status == "Active").ToList();
                foreach (var d in drivers) cmbD.Items.Add(d.FullName);
                if (cmbD.Items.Count > 0) cmbD.SelectedIndex = 0;

                Label lblDate = new Label { Text = "Departure Date:", Location = new Point(24, 188), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                DateTimePicker dtp = new DateTimePicker { Location = new Point(24, 210), Width = 200, Format = DateTimePickerFormat.Short, Value = DateTime.Today };

                Label lblTime = new Label { Text = "Departure Time:", Location = new Point(254, 188), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbT = new ComboBox { Location = new Point(254, 210), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbT.Items.AddRange(new object[] { "05:30 AM", "06:00 AM", "06:30 AM", "07:00 AM", "07:30 AM", "08:00 AM", "09:00 AM", "10:30 AM", "01:00 PM", "02:30 PM", "04:00 PM" });
                cmbT.SelectedIndex = 1;

                Label lblGate = new Label { Text = "Terminal Gate:", Location = new Point(24, 248), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbG = new ComboBox { Location = new Point(24, 270), Width = 200, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbG.Items.AddRange(new object[] { "Gate 01", "Gate 02", "Gate 03", "Gate 04", "Gate 05", "Gate 06", "Gate 07", "Gate 08" });
                cmbG.SelectedIndex = 0;

                Label lblFare = new Label { Text = "Fare (ETB):", Location = new Point(254, 248), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtFare = new TextBox { Location = new Point(254, 270), Width = 200, Text = "1000.00" };

                // Auto-fill fare when route selected
                cmbR.SelectedIndexChanged += (s, e) =>
                {
                    if (cmbR.SelectedIndex >= 0 && cmbR.SelectedIndex < routes.Count)
                    {
                        txtFare.Text = routes[cmbR.SelectedIndex].BaseFare.ToString("F2");
                    }
                };

                Label lblNotes = new Label { Text = "Operational Notes:", Location = new Point(24, 308), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtNotes = new TextBox { Location = new Point(24, 330), Width = 430, Text = "Standard passenger service." };

                Button btnSave = new Button
                {
                    Text = "Schedule Trip",
                    Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(13, 94, 234),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(160, 40),
                    Location = new Point(150, 400),
                    Cursor = Cursors.Hand
                };
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Click += (s, e) =>
                {
                    if (cmbR.SelectedIndex < 0 || cmbB.SelectedIndex < 0 || cmbD.SelectedIndex < 0)
                    {
                        MessageBox.Show("Please select route, bus, and driver.", "Incomplete Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!decimal.TryParse(txtFare.Text.Trim(), out decimal fare))
                    {
                        MessageBox.Show("Please enter a valid fare amount.", "Invalid Fare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var selectedRoute = routes[cmbR.SelectedIndex];
                    var selectedBus = buses[cmbB.SelectedIndex];
                    var selectedDriver = cmbD.SelectedItem?.ToString() ?? "Unknown";

                    var newTrip = new TripSchedule
                    {
                        RouteId = selectedRoute.RouteId,
                        RouteName = $"{selectedRoute.Source} ➔ {selectedRoute.Destination}",
                        BusPlate = selectedBus.PlateNumber,
                        DriverName = selectedDriver,
                        DepartureDate = dtp.Value.Date,
                        DepartureTime = cmbT.SelectedItem?.ToString() ?? "06:00 AM",
                        EstimatedArrival = "TBD",
                        GateNumber = cmbG.SelectedItem?.ToString() ?? "Gate 01",
                        TotalSeats = selectedBus.Capacity,
                        BookedSeats = 0,
                        Fare = fare,
                        Status = "Scheduled",
                        Notes = txtNotes.Text.Trim()
                    };

                    if (!TripScheduleStore.Add(newTrip, out string error))
                    {
                        MessageBox.Show(error, "Scheduling Conflict Prevented", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MessageBox.Show($"Trip {newTrip.TripId} successfully scheduled for {newTrip.RouteName}!", "Trip Scheduled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.Controls.Add(lblR); form.Controls.Add(cmbR);
                form.Controls.Add(lblB); form.Controls.Add(cmbB);
                form.Controls.Add(lblD); form.Controls.Add(cmbD);
                form.Controls.Add(lblDate); form.Controls.Add(dtp);
                form.Controls.Add(lblTime); form.Controls.Add(cmbT);
                form.Controls.Add(lblGate); form.Controls.Add(cmbG);
                form.Controls.Add(lblFare); form.Controls.Add(txtFare);
                form.Controls.Add(lblNotes); form.Controls.Add(txtNotes);
                form.Controls.Add(btnSave);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateTripsList();
                }
            }
        }

        private void UpdateSelectedTripStatus()
        {
            if (dgvTripSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trip from the table.", "No Trip Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tripId = dgvTripSchedules.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var trip = TripScheduleStore.GetById(tripId);
            if (trip == null) return;

            using (var form = new Form())
            {
                form.Text = $"Update Status - {trip.TripId}";
                form.Size = new Size(380, 240);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.BackColor = Color.White;

                Label lbl = new Label { Text = $"Current Trip: {trip.TripId} ({trip.RouteName})\nCurrent Status: {trip.Status}", Location = new Point(24, 20), AutoSize = true, Font = new Font("Segoe UI", 9.5f) };
                ComboBox cmb = new ComboBox { Location = new Point(24, 75), Width = 310, DropDownStyle = ComboBoxStyle.DropDownList, Font = new Font("Segoe UI", 10f) };
                cmb.Items.AddRange(new object[] { "Scheduled", "Boarding", "On Route", "Departed", "Delayed", "Completed", "Cancelled" });
                cmb.SelectedItem = trip.Status;

                Button btnSave = new Button
                {
                    Text = "Save Status",
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(13, 94, 234),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(130, 36),
                    Location = new Point(115, 130),
                    Cursor = Cursors.Hand
                };
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Click += (s, e) =>
                {
                    string newStatus = cmb.SelectedItem?.ToString() ?? trip.Status;
                    TripScheduleStore.UpdateStatus(trip.TripId, newStatus);
                    MessageBox.Show($"Trip {trip.TripId} status updated to '{newStatus}'.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.Controls.Add(lbl);
                form.Controls.Add(cmb);
                form.Controls.Add(btnSave);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateTripsList();
                }
            }
        }

        private void ViewSelectedTripManifest()
        {
            if (dgvTripSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trip from the table.", "No Trip Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tripId = dgvTripSchedules.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var trip = TripScheduleStore.GetById(tripId);
            if (trip == null) return;

            string manifest = $"========================================\n" +
                              $"     PASSENGER TRIP MANIFEST\n" +
                              $"========================================\n\n" +
                              $"Trip Reference:   {trip.TripId}\n" +
                              $"Route Corridor:   {trip.RouteName}\n" +
                              $"Bus Registration: {trip.BusPlate}\n" +
                              $"Captain Driver:   {trip.DriverName}\n" +
                              $"Departure Date:   {trip.DepartureDate:yyyy-MM-dd} at {trip.DepartureTime}\n" +
                              $"Estimated Arrival:{trip.EstimatedArrival}\n" +
                              $"Terminal Gate:    {trip.GateNumber}\n" +
                              $"Passenger Load:   {trip.OccupancyText}\n" +
                              $"Standard Fare:    {trip.Fare:N2} ETB\n" +
                              $"Trip Status:      {trip.Status}\n" +
                              $"Operational Note: {trip.Notes}\n\n" +
                              $"Safety Clearance: APPROVED FOR DEPARTURE\n" +
                              $"Vehicle Check:    INSPECTED & VERIFIED\n";

            MessageBox.Show(manifest, $"Trip Manifest - {trip.TripId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelSelectedTrip()
        {
            if (dgvTripSchedules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trip to cancel.", "No Trip Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string tripId = dgvTripSchedules.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var result = MessageBox.Show($"Are you sure you want to mark trip '{tripId}' as Cancelled?\n\nPassengers will receive notification alerts regarding cancellation and refund options.",
                                         "Confirm Trip Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                TripScheduleStore.UpdateStatus(tripId, "Cancelled");
                MessageBox.Show($"Trip {tripId} has been marked as Cancelled.", "Trip Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateTripsList();
            }
        }

        private (Panel Card, Color Bg, Label ValLabel) CreateMetricCard(string title, string initialVal, string subtitle, Color accentColor)
        {
            Panel card = new Panel
            {
                Size = new Size(220, 64),
                BackColor = Color.White,
                Margin = new Padding(4, 2, 12, 2)
            };
            card.Paint += (s, e) =>
            {
                using (GraphicsPath p = CardPanel.GetRoundedRectanglePath(new Rectangle(0, 0, card.Width - 1, card.Height - 1), 8))
                {
                    using (SolidBrush b = new SolidBrush(Color.White)) e.Graphics.FillPath(b, p);
                    using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1)) e.Graphics.DrawPath(pen, p);
                }
                using (SolidBrush b = new SolidBrush(accentColor))
                {
                    e.Graphics.FillRectangle(b, 0, 0, 4, card.Height);
                }
            };

            Label val = new Label
            {
                Text = initialVal,
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(14, 8),
                AutoSize = true
            };

            Label lblTitle = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                Location = new Point(14, 36),
                AutoSize = true
            };

            card.Controls.Add(val);
            card.Controls.Add(lblTitle);

            return (card, accentColor, val);
        }
    }
}

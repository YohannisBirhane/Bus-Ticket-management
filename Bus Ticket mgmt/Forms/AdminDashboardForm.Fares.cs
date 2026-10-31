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
        private Panel panelFareManagement = null!;
        private DataGridView dgvFares = null!;
        private TextBox txtSearchFares = null!;
        private ComboBox cmbFareStatusFilter = null!;
        private Label lblFareMetricAvgVal = null!;
        private Label lblFareMetricMinVal = null!;
        private Label lblFareMetricMaxVal = null!;
        private Label lblFareMetricTotalVal = null!;
        private Label lblFareCount = null!;

        private void InitializeFareManagement()
        {
            panelFareManagement = new Panel
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
                Text = "Fare & Tariff Management",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                AutoSize = true
            };

            Button btnDiscounts = new Button
            {
                Text = "Concession Discounts",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(15, 23, 42),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(190, 36),
                Location = new Point(header.Width - 220, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand
            };
            btnDiscounts.FlatAppearance.BorderSize = 0;
            btnDiscounts.Click += (s, e) => ShowDiscountsDialog();

            header.Controls.Add(title);
            header.Controls.Add(btnDiscounts);
            panelFareManagement.Controls.Add(header);

            // 2. Metrics Bar
            FlowLayoutPanel flowMetrics = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 80,
                Padding = new Padding(20, 8, 20, 4),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            var (m1, _, l1) = CreateMetricCard("Avg Route Tariff", "0 ETB", "Mean standard fare", Color.FromArgb(13, 94, 234));
            lblFareMetricAvgVal = l1;
            flowMetrics.Controls.Add(m1);

            var (m2, _, l2) = CreateMetricCard("Lowest Fare", "0 ETB", "Short corridor shuttle", Color.FromArgb(16, 185, 129));
            lblFareMetricMinVal = l2;
            flowMetrics.Controls.Add(m2);

            var (m3, _, l3) = CreateMetricCard("Highest Fare", "0 ETB", "Cross-country express", Color.FromArgb(245, 158, 11));
            lblFareMetricMaxVal = l3;
            flowMetrics.Controls.Add(m3);

            var (m4, _, l4) = CreateMetricCard("Priced Routes", "0", "Standardized tariffs", Color.FromArgb(99, 102, 241));
            lblFareMetricTotalVal = l4;
            flowMetrics.Controls.Add(m4);

            panelFareManagement.Controls.Add(flowMetrics);

            // 3. Toolbar
            Panel toolbar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                Padding = new Padding(24, 8, 24, 8),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            txtSearchFares = new TextBox
            {
                Font = new Font("Segoe UI", 10f),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                Width = 260,
                PlaceholderText = "Search route, origin, destination..."
            };
            txtSearchFares.TextChanged += (s, e) => PopulateFaresList();

            cmbFareStatusFilter = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(296, 12),
                Width = 140
            };
            cmbFareStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Inactive" });
            cmbFareStatusFilter.SelectedIndex = 0;
            cmbFareStatusFilter.SelectedIndexChanged += (s, e) => PopulateFaresList();

            Button btnResetFares = new Button
            {
                Text = "Reset Filters",
                Font = new Font("Segoe UI", 9f),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(446, 11),
                Size = new Size(100, 28)
            };
            btnResetFares.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetFares.Click += (s, e) =>
            {
                txtSearchFares.Text = "";
                cmbFareStatusFilter.SelectedIndex = 0;
                PopulateFaresList();
            };

            lblFareCount = new Label
            {
                Text = "Showing 0 routes",
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(toolbar.Width - 170, 16),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true
            };

            toolbar.Controls.Add(txtSearchFares);
            toolbar.Controls.Add(cmbFareStatusFilter);
            toolbar.Controls.Add(btnResetFares);
            toolbar.Controls.Add(lblFareCount);
            panelFareManagement.Controls.Add(toolbar);

            // 4. DataGridView
            Panel gridContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 4, 24, 60),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            dgvFares = new DataGridView
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
            dgvFares.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvFares.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvFares.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.2f, FontStyle.Bold);
            dgvFares.DefaultCellStyle.Font = new Font("Segoe UI", 9.2f);
            dgvFares.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvFares.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

            gridContainer.Controls.Add(dgvFares);
            panelFareManagement.Controls.Add(gridContainer);

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

            Button btnEditFare = new Button
            {
                Text = "Edit Route Base Fare",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 36),
                Location = new Point(24, 8),
                Cursor = Cursors.Hand
            };
            btnEditFare.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnEditFare.Click += (s, e) => EditSelectedRouteFare();

            Button btnBulkTariff = new Button
            {
                Text = "Apply Seasonal Tariff Adjustment (%)",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(250, 36),
                Location = new Point(214, 8),
                Cursor = Cursors.Hand
            };
            btnBulkTariff.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnBulkTariff.Click += (s, e) => ApplyBulkTariffAdjustment();

            actionBar.Controls.Add(btnEditFare);
            actionBar.Controls.Add(btnBulkTariff);
            panelFareManagement.Controls.Add(actionBar);

            this.panelMain.Controls.Add(panelFareManagement);
        }

        public void ShowFareManagementView()
        {
            HideAllPanels();
            panelFareManagement.Visible = true;
            panelFareManagement.BringToFront();
            SetActiveSidebarButton(btnNavFares);
            lblPageHeading.Text = "Fare & Tariff Management";
            lblPageSubHeading.Text = "Manage route ticket tariffs, configure seasonal price rules, and maintain fare transparency.";
            PopulateFaresList();
        }

        public void PopulateFaresList()
        {
            if (dgvFares == null) return;

            var routes = RouteStore.GetAll();

            // Search
            string search = txtSearchFares?.Text.Trim().ToLowerInvariant() ?? "";
            if (!string.IsNullOrEmpty(search))
            {
                routes = routes.Where(r => r.RouteName.ToLowerInvariant().Contains(search) ||
                                           r.Source.ToLowerInvariant().Contains(search) ||
                                           r.Destination.ToLowerInvariant().Contains(search)).ToList();
            }

            // Status filter
            string statusFilter = cmbFareStatusFilter?.SelectedItem?.ToString() ?? "All Statuses";
            if (statusFilter != "All Statuses")
            {
                routes = routes.Where(r => r.Status.Equals(statusFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Metrics
            var allRoutes = RouteStore.GetAll();
            decimal avg = allRoutes.Any() ? allRoutes.Average(r => r.BaseFare) : 0;
            decimal min = allRoutes.Any() ? allRoutes.Min(r => r.BaseFare) : 0;
            decimal max = allRoutes.Any() ? allRoutes.Max(r => r.BaseFare) : 0;

            if (lblFareMetricAvgVal != null) lblFareMetricAvgVal.Text = $"{avg:N0} ETB";
            if (lblFareMetricMinVal != null) lblFareMetricMinVal.Text = $"{min:N0} ETB";
            if (lblFareMetricMaxVal != null) lblFareMetricMaxVal.Text = $"{max:N0} ETB";
            if (lblFareMetricTotalVal != null) lblFareMetricTotalVal.Text = allRoutes.Count.ToString();
            if (lblFareCount != null) lblFareCount.Text = $"Showing {routes.Count} routes";

            var dtTable = new System.Data.DataTable();
            dtTable.Columns.Add("Route ID");
            dtTable.Columns.Add("Route Name");
            dtTable.Columns.Add("Origin (Source)");
            dtTable.Columns.Add("Destination");
            dtTable.Columns.Add("Distance (km)");
            dtTable.Columns.Add("Travel Duration");
            dtTable.Columns.Add("Base Fare (ETB)");
            dtTable.Columns.Add("Per-KM Rate (ETB)");
            dtTable.Columns.Add("Tariff Status");

            foreach (var r in routes)
            {
                decimal ratePerKm = (r.DistanceKm > 0) ? (r.BaseFare / r.DistanceKm) : 0;
                dtTable.Rows.Add(
                    r.RouteId,
                    r.RouteName,
                    r.Source,
                    r.Destination,
                    $"{r.DistanceKm} km",
                    r.EstimatedTime,
                    r.BaseFare.ToString("N2"),
                    $"{ratePerKm:N2} ETB/km",
                    r.Status
                );
            }

            dgvFares.DataSource = dtTable;
        }

        private void EditSelectedRouteFare()
        {
            if (dgvFares.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a route from the table to adjust fare.", "No Route Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string routeId = dgvFares.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var route = RouteStore.GetById(routeId);
            if (route == null) return;

            using (var form = new Form())
            {
                form.Text = $"Adjust Fare - {route.RouteName}";
                form.Size = new Size(380, 240);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.BackColor = Color.White;

                Label lbl = new Label { Text = $"Route: {route.RouteName}\nCurrent Base Fare: {route.BaseFare:N2} ETB", Location = new Point(24, 20), AutoSize = true, Font = new Font("Segoe UI", 9.5f) };
                Label lblNew = new Label { Text = "Enter New Standard Fare (ETB):", Location = new Point(24, 65), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtNew = new TextBox { Location = new Point(24, 90), Width = 310, Text = route.BaseFare.ToString("F2"), Font = new Font("Segoe UI", 10f) };

                Button btnSave = new Button
                {
                    Text = "Update Fare",
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(15, 23, 42),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(130, 36),
                    Location = new Point(115, 140),
                    Cursor = Cursors.Hand
                };
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Click += (s, e) =>
                {
                    if (!decimal.TryParse(txtNew.Text.Trim(), out decimal newFare) || newFare <= 0)
                    {
                        MessageBox.Show("Please enter a valid positive fare amount.", "Invalid Fare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    route.BaseFare = newFare;
                    RouteStore.Update(route);

                    MessageBox.Show($"Base fare for '{route.RouteName}' updated to {newFare:N2} ETB.", "Fare Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.Controls.Add(lbl);
                form.Controls.Add(lblNew);
                form.Controls.Add(txtNew);
                form.Controls.Add(btnSave);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateFaresList();
                    PopulateRoutesList();
                }
            }
        }

        private void ApplyBulkTariffAdjustment()
        {
            using (var form = new Form())
            {
                form.Text = "Seasonal Tariff Percentage Adjustment";
                form.Size = new Size(400, 260);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.BackColor = Color.White;

                Label lbl = new Label { Text = "Adjust all active route fares by percentage (%):", Location = new Point(24, 20), AutoSize = true, Font = new Font("Segoe UI", 9.5f, FontStyle.Bold) };
                Label lblSub = new Label { Text = "Example: Enter +10 for a 10% holiday increase,\nor -5 for a 5% promotional discount.", Location = new Point(24, 45), AutoSize = true, Font = new Font("Segoe UI", 8.5f), ForeColor = Color.FromArgb(100, 116, 139) };

                TextBox txtPct = new TextBox { Location = new Point(24, 95), Width = 330, Text = "+5", Font = new Font("Segoe UI", 10f) };

                Button btnApply = new Button
                {
                    Text = "Apply to All Routes",
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(15, 23, 42),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(160, 36),
                    Location = new Point(110, 150),
                    Cursor = Cursors.Hand
                };
                btnApply.FlatAppearance.BorderSize = 0;
                btnApply.Click += (s, e) =>
                {
                    string raw = txtPct.Text.Trim().Replace("+", "");
                    if (!decimal.TryParse(raw, out decimal pct))
                    {
                        MessageBox.Show("Please enter a valid percentage number.", "Invalid Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var routes = RouteStore.GetAll();
                    foreach (var r in routes)
                    {
                        decimal change = r.BaseFare * (pct / 100m);
                        r.BaseFare = Math.Round(r.BaseFare + change, 0);
                        RouteStore.Update(r);
                    }

                    MessageBox.Show($"Adjusted {routes.Count} route tariffs by {pct:+0.##;-0.##}%!", "Tariff Adjusted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.Controls.Add(lbl);
                form.Controls.Add(lblSub);
                form.Controls.Add(txtPct);
                form.Controls.Add(btnApply);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateFaresList();
                    PopulateRoutesList();
                }
            }
        }

        private void ShowDiscountsDialog()
        {
            string matrix =
                "================================================\n" +
                "     CONCESSION & DISCOUNT POLICY MATRIX\n" +
                "================================================\n\n" +
                "• Student Discount:       15% Off (Valid Student ID)\n" +
                "• Senior Citizen (60+):   20% Off (Kebele ID / Passport)\n" +
                "• Child Passenger (<7):   50% Off (Accompanied by Adult)\n" +
                "• Round-Trip Booking:     10% Off (On Return Sector)\n" +
                "• Luggage Allowance:      25 kg Free per passenger\n" +
                "• Excess Baggage Surcharge: 50.00 ETB per additional kg\n\n" +
                "Discounts are automatically calculated at ticket desk\n" +
                "and online passenger checkout upon verification.\n" +
                "================================================\n";

            MessageBox.Show(matrix, "Concession & Pricing Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

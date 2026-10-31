using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class AdminDashboardForm
    {
        private Panel panelPaymentManagement = null!;
        private DataGridView dgvPayments = null!;
        private TextBox txtSearchPayments = null!;
        private ComboBox cmbPaymentMethodFilter = null!;
        private ComboBox cmbPaymentStatusFilter = null!;
        private Label lblPayMetricTotalVal = null!;
        private Label lblPayMetricCashVal = null!;
        private Label lblPayMetricDigitalVal = null!;
        private Label lblPayMetricRefundVal = null!;
        private Label lblPaymentsCount = null!;

        private void InitializePaymentManagement()
        {
            panelPaymentManagement = new Panel
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
                Text = "Payment & Transaction Management",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                AutoSize = true
            };

            Button btnRecordPay = new Button
            {
                Text = "Record Transaction",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(15, 23, 42),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 36),
                Location = new Point(header.Width - 210, 10),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Cursor = Cursors.Hand
            };
            btnRecordPay.FlatAppearance.BorderSize = 0;
            btnRecordPay.Click += (s, e) => OpenRecordPaymentDialog();

            header.Controls.Add(title);
            header.Controls.Add(btnRecordPay);
            panelPaymentManagement.Controls.Add(header);

            // 2. Metrics Bar
            FlowLayoutPanel flowMetrics = new FlowLayoutPanel
            {
                Dock = DockStyle.Top,
                Height = 80,
                Padding = new Padding(20, 8, 20, 4),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            var (m1, _, l1) = CreateMetricCard("Total Collections", "0 ETB", "All cleared revenues", Color.FromArgb(16, 185, 129));
            lblPayMetricTotalVal = l1;
            flowMetrics.Controls.Add(m1);

            var (m2, _, l2) = CreateMetricCard("Cash Receipts", "0 ETB", "Counter drawer cash", Color.FromArgb(13, 94, 234));
            lblPayMetricCashVal = l2;
            flowMetrics.Controls.Add(m2);

            var (m3, _, l3) = CreateMetricCard("Digital (Telebirr/CBE)", "0 ETB", "Electronic banking", Color.FromArgb(99, 102, 241));
            lblPayMetricDigitalVal = l3;
            flowMetrics.Controls.Add(m3);

            var (m4, _, l4) = CreateMetricCard("Refunds Disbursed", "0 ETB", "Returned to passengers", Color.FromArgb(239, 68, 68));
            lblPayMetricRefundVal = l4;
            flowMetrics.Controls.Add(m4);

            panelPaymentManagement.Controls.Add(flowMetrics);

            // 3. Toolbar
            Panel toolbar = new Panel
            {
                Dock = DockStyle.Top,
                Height = 56,
                Padding = new Padding(24, 8, 24, 8),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            txtSearchPayments = new TextBox
            {
                Font = new Font("Segoe UI", 10f),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                Width = 260,
                PlaceholderText = "Search receipt #, passenger, booking..."
            };
            txtSearchPayments.TextChanged += (s, e) => PopulatePaymentsList();

            cmbPaymentMethodFilter = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(296, 12),
                Width = 140
            };
            cmbPaymentMethodFilter.Items.AddRange(new object[] { "All Methods", "Cash", "Telebirr", "CBE Birr", "Card" });
            cmbPaymentMethodFilter.SelectedIndex = 0;
            cmbPaymentMethodFilter.SelectedIndexChanged += (s, e) => PopulatePaymentsList();

            cmbPaymentStatusFilter = new ComboBox
            {
                Font = new Font("Segoe UI", 9.5f),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Location = new Point(446, 12),
                Width = 140
            };
            cmbPaymentStatusFilter.Items.AddRange(new object[] { "All Statuses", "Paid", "Pending", "Refunded" });
            cmbPaymentStatusFilter.SelectedIndex = 0;
            cmbPaymentStatusFilter.SelectedIndexChanged += (s, e) => PopulatePaymentsList();

            Button btnResetPay = new Button
            {
                Text = "Reset Filters",
                Font = new Font("Segoe UI", 9f),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(596, 11),
                Size = new Size(100, 28)
            };
            btnResetPay.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetPay.Click += (s, e) =>
            {
                txtSearchPayments.Text = "";
                cmbPaymentMethodFilter.SelectedIndex = 0;
                cmbPaymentStatusFilter.SelectedIndex = 0;
                PopulatePaymentsList();
            };

            lblPaymentsCount = new Label
            {
                Text = "Showing 0 records",
                Font = new Font("Segoe UI", 9f),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(toolbar.Width - 170, 16),
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                AutoSize = true
            };

            toolbar.Controls.Add(txtSearchPayments);
            toolbar.Controls.Add(cmbPaymentMethodFilter);
            toolbar.Controls.Add(cmbPaymentStatusFilter);
            toolbar.Controls.Add(btnResetPay);
            toolbar.Controls.Add(lblPaymentsCount);
            panelPaymentManagement.Controls.Add(toolbar);

            // 4. DataGridView
            Panel gridContainer = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(24, 4, 24, 60),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            dgvPayments = new DataGridView
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
            dgvPayments.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            dgvPayments.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(30, 41, 59);
            dgvPayments.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.2f, FontStyle.Bold);
            dgvPayments.DefaultCellStyle.Font = new Font("Segoe UI", 9.2f);
            dgvPayments.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvPayments.DefaultCellStyle.SelectionForeColor = Color.FromArgb(15, 23, 42);

            gridContainer.Controls.Add(dgvPayments);
            panelPaymentManagement.Controls.Add(gridContainer);

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

            Button btnViewReceipt = new Button
            {
                Text = "View Official Receipt",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(170, 36),
                Location = new Point(24, 8),
                Cursor = Cursors.Hand
            };
            btnViewReceipt.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewReceipt.Click += (s, e) => ViewSelectedPaymentReceipt();

            Button btnRefund = new Button
            {
                Text = "Process Refund",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 65, 85),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(150, 36),
                Location = new Point(204, 8),
                Cursor = Cursors.Hand
            };
            btnRefund.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefund.Click += (s, e) => ProcessSelectedPaymentRefund();

            actionBar.Controls.Add(btnViewReceipt);
            actionBar.Controls.Add(btnRefund);
            panelPaymentManagement.Controls.Add(actionBar);

            this.panelMain.Controls.Add(panelPaymentManagement);
        }

        public void ShowPaymentManagementView()
        {
            HideAllPanels();
            panelPaymentManagement.Visible = true;
            panelPaymentManagement.BringToFront();
            SetActiveSidebarButton(btnNavPayments);
            lblPageHeading.Text = "Payment & Financial Transactions";
            lblPageSubHeading.Text = "Audit payment records, verify cashless remittances, and execute refund authorizations.";
            PopulatePaymentsList();
        }

        public void PopulatePaymentsList()
        {
            if (dgvPayments == null) return;

            var records = PaymentStore.GetAll();

            // Search
            string search = txtSearchPayments?.Text.Trim().ToLowerInvariant() ?? "";
            if (!string.IsNullOrEmpty(search))
            {
                records = records.Where(p => p.ReceiptNumber.ToLowerInvariant().Contains(search) ||
                                             p.BookingId.ToLowerInvariant().Contains(search) ||
                                             p.TicketId.ToLowerInvariant().Contains(search) ||
                                             p.PassengerName.ToLowerInvariant().Contains(search) ||
                                             p.RouteName.ToLowerInvariant().Contains(search)).ToList();
            }

            // Method filter
            string methodFilter = cmbPaymentMethodFilter?.SelectedItem?.ToString() ?? "All Methods";
            if (methodFilter != "All Methods")
            {
                records = records.Where(p => p.PaymentMethod.Equals(methodFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Status filter
            string statusFilter = cmbPaymentStatusFilter?.SelectedItem?.ToString() ?? "All Statuses";
            if (statusFilter != "All Statuses")
            {
                records = records.Where(p => p.PaymentStatus.Equals(statusFilter, StringComparison.OrdinalIgnoreCase)).ToList();
            }

            // Update Metrics
            decimal totalPaid = PaymentStore.GetTotalCollectionsToday();
            decimal cashPaid = PaymentStore.GetCashTotalToday();
            decimal digiPaid = PaymentStore.GetDigitalTotalToday();
            decimal refundPaid = PaymentStore.GetRefundsTotalToday();

            if (lblPayMetricTotalVal != null) lblPayMetricTotalVal.Text = $"{totalPaid:N0} ETB";
            if (lblPayMetricCashVal != null) lblPayMetricCashVal.Text = $"{cashPaid:N0} ETB";
            if (lblPayMetricDigitalVal != null) lblPayMetricDigitalVal.Text = $"{digiPaid:N0} ETB";
            if (lblPayMetricRefundVal != null) lblPayMetricRefundVal.Text = $"{refundPaid:N0} ETB";
            if (lblPaymentsCount != null) lblPaymentsCount.Text = $"Showing {records.Count} records";

            var dtTable = new System.Data.DataTable();
            dtTable.Columns.Add("Receipt #");
            dtTable.Columns.Add("Booking Ref");
            dtTable.Columns.Add("Ticket ID");
            dtTable.Columns.Add("Passenger Name");
            dtTable.Columns.Add("Route Name");
            dtTable.Columns.Add("Amount (ETB)");
            dtTable.Columns.Add("Method");
            dtTable.Columns.Add("Payment Status");
            dtTable.Columns.Add("Transaction Time");
            dtTable.Columns.Add("Cashier / Officer");

            foreach (var r in records)
            {
                dtTable.Rows.Add(
                    r.ReceiptNumber,
                    r.BookingId,
                    r.TicketId,
                    r.PassengerName,
                    r.RouteName,
                    r.Amount.ToString("N2"),
                    r.PaymentMethod,
                    r.PaymentStatus,
                    r.TransactionDate.ToString("yyyy-MM-dd HH:mm"),
                    r.CashierName
                );
            }

            dgvPayments.DataSource = dtTable;
        }

        private void ViewSelectedPaymentReceipt()
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to view receipt.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string receiptNo = dgvPayments.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var p = PaymentStore.GetAll().FirstOrDefault(x => x.ReceiptNumber.Equals(receiptNo, StringComparison.OrdinalIgnoreCase));
            if (p == null) return;

            string receiptText =
                "================================================\n" +
                "         ETHIO BUS TRANSPORTATION SYSTEM\n" +
                "            OFFICIAL PAYMENT RECEIPT\n" +
                "================================================\n\n" +
                $"Receipt Number:   {p.ReceiptNumber}\n" +
                $"Transaction Date: {p.TransactionDate:yyyy-MM-dd HH:mm:ss}\n" +
                $"Cashier / Agent:  {p.CashierName}\n" +
                "------------------------------------------------\n" +
                $"Passenger Name:   {p.PassengerName}\n" +
                $"Booking Ref ID:   {p.BookingId}\n" +
                $"Ticket Number:    {p.TicketId}\n" +
                $"Travel Route:     {p.RouteName}\n" +
                "------------------------------------------------\n" +
                $"Amount Payable:   {p.Amount:N2} ETB\n" +
                $"Payment Channel:  {p.PaymentMethod}\n" +
                $"Payment Status:   {p.PaymentStatus.ToUpper()}\n" +
                "------------------------------------------------\n" +
                $"Remarks:          {p.Notes}\n\n" +
                "         Thank you for choosing Ethio Bus!\n" +
                "   Keep this receipt for security & tax purposes.\n" +
                "================================================\n";

            MessageBox.Show(receiptText, $"Receipt - {p.ReceiptNumber}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ProcessSelectedPaymentRefund()
        {
            if (dgvPayments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a transaction to refund.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string receiptNo = dgvPayments.SelectedRows[0].Cells[0].Value?.ToString() ?? "";
            var p = PaymentStore.GetAll().FirstOrDefault(x => x.ReceiptNumber.Equals(receiptNo, StringComparison.OrdinalIgnoreCase));
            if (p == null) return;

            if (p.PaymentStatus == "Refunded")
            {
                MessageBox.Show($"This receipt {receiptNo} has already been refunded.", "Already Processed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal deduction = p.Amount * 0.10m; // 10% policy cancellation fee
            decimal refundAmount = p.Amount - deduction;

            var confirm = MessageBox.Show(
                $"Confirm processing refund for Receipt {p.ReceiptNumber}?\n\n" +
                $"Passenger: {p.PassengerName}\n" +
                $"Original Amount: {p.Amount:N2} ETB\n" +
                $"Cancellation Fee (10%): -{deduction:N2} ETB\n" +
                $"Net Refund Payable: {refundAmount:N2} ETB\n\n" +
                "Proceed with refund?",
                "Authorize Refund",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                p.PaymentStatus = "Refunded";
                p.Notes = $"Refunded {refundAmount:N2} ETB after 10% deduction on {DateTime.Now:yyyy-MM-dd HH:mm}";

                // Also cancel the ticket in store if exists
                if (!string.IsNullOrEmpty(p.TicketId))
                {
                    TicketStore.CancelTicket(p.TicketId, out _);
                }

                MessageBox.Show($"Refund of {refundAmount:N2} ETB successfully disbursed to {p.PassengerName}.", "Refund Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulatePaymentsList();
            }
        }

        private void OpenRecordPaymentDialog()
        {
            using (var form = new Form())
            {
                form.Text = "Record Payment Transaction";
                form.Size = new Size(460, 420);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.BackColor = Color.White;

                Label lblP = new Label { Text = "Passenger Name:", Location = new Point(24, 20), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtP = new TextBox { Location = new Point(24, 42), Width = 390 };

                Label lblR = new Label { Text = "Route Name:", Location = new Point(24, 80), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbR = new ComboBox { Location = new Point(24, 102), Width = 390, DropDownStyle = ComboBoxStyle.DropDownList };
                foreach (var r in RouteStore.GetAll()) cmbR.Items.Add(r.RouteName);
                if (cmbR.Items.Count > 0) cmbR.SelectedIndex = 0;

                Label lblA = new Label { Text = "Amount (ETB):", Location = new Point(24, 140), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtA = new TextBox { Location = new Point(24, 162), Width = 180, Text = "1150.00" };

                Label lblM = new Label { Text = "Payment Method:", Location = new Point(234, 140), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbM = new ComboBox { Location = new Point(234, 162), Width = 180, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbM.Items.AddRange(new object[] { "Cash", "Telebirr", "CBE Birr", "Card" });
                cmbM.SelectedIndex = 0;

                Label lblN = new Label { Text = "Transaction Notes / Reference:", Location = new Point(24, 200), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtN = new TextBox { Location = new Point(24, 222), Width = 390, Text = "Manual walk-in cashier receipt." };

                Button btnSave = new Button
                {
                    Text = "Save Transaction",
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    ForeColor = Color.White,
                    BackColor = Color.FromArgb(15, 23, 42),
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(160, 38),
                    Location = new Point(140, 290),
                    Cursor = Cursors.Hand
                };
                btnSave.FlatAppearance.BorderSize = 0;
                btnSave.Click += (s, e) =>
                {
                    if (string.IsNullOrWhiteSpace(txtP.Text) || !decimal.TryParse(txtA.Text, out decimal amt))
                    {
                        MessageBox.Show("Please enter passenger name and valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var rec = new PaymentRecord(
                        PaymentStore.GenerateNextReceiptNo(),
                        $"BK-{new Random().Next(1000, 9999)}",
                        $"TK-{new Random().Next(1000, 9999)}",
                        txtP.Text.Trim(),
                        cmbR.SelectedItem?.ToString() ?? "Addis Express",
                        amt,
                        cmbM.SelectedItem?.ToString() ?? "Cash",
                        "Paid",
                        DateTime.Now,
                        "System Administrator",
                        txtN.Text.Trim()
                    );

                    PaymentStore.Add(rec);
                    MessageBox.Show($"Transaction {rec.ReceiptNumber} saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    form.DialogResult = DialogResult.OK;
                    form.Close();
                };

                form.Controls.Add(lblP); form.Controls.Add(txtP);
                form.Controls.Add(lblR); form.Controls.Add(cmbR);
                form.Controls.Add(lblA); form.Controls.Add(txtA);
                form.Controls.Add(lblM); form.Controls.Add(cmbM);
                form.Controls.Add(lblN); form.Controls.Add(txtN);
                form.Controls.Add(btnSave);

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    PopulatePaymentsList();
                }
            }
        }
    }
}

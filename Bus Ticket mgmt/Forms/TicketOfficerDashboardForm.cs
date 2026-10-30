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
    public partial class TicketOfficerDashboardForm : Form
    {
        private bool isMaximized = false;
        private Point normalLocation;
        private Size normalSize;

        private Ticket? _activeScannedTicket = null;
        private readonly string _officerName = "Marta Tadesse (Desk 01)";

        public TicketOfficerDashboardForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            InitializeCustomUI();
            SetupNavigation();
            SetupDashboardEvents();
            SetupIssueTicketEvents();
            SetupVerifyBoardingEvents();
            SetupBookingManagementEvents();
            SetupTicketManagementEvents();
            SetupManifestEvents();
            SetupPaymentEvents();
            SetupFeedbackEvents();

            // Populate Initial Data
            PopulateTripsTable();
            PopulateDashboardMetrics();
            PopulateIssueDropdowns();
            PopulateBookingsList();
            PopulateTicketsList();
            PopulateManifestRoutes();
            PopulatePaymentsList();
            PopulateInquiriesList();

            ShowDashboardView();
        }

        private void InitializeCustomUI()
        {
            txtTicketNumber.PlaceholderText = "e.g. TK1001, BK0001, VER-94812";
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

            // Title bar dragging
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

            // Window buttons actions
            btnClose.Click += (s, e) => this.Close();
            btnMinimize.Click += (s, e) => this.WindowState = FormWindowState.Minimized;
            btnMaximize.Click += (s, e) => ToggleMaximize();

            // Sign out button hover transition
            btnNavLogout.MouseEnter += (s, e) => { btnNavLogout.BackColor = Color.FromArgb(254, 226, 226); };
            btnNavLogout.MouseLeave += (s, e) => { btnNavLogout.BackColor = Color.FromArgb(254, 242, 242); };
            btnNavLogout.Click += (s, e) =>
            {
                var res = MessageBox.Show("Are you sure you want to log out of the Ticket Officer terminal?", "Confirm Sign Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    this.Close();
                }
            };

            // Sidebar border divider
            panelSidebar.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(borderPen, panelSidebar.Width - 1, 0, panelSidebar.Width - 1, panelSidebar.Height);
                }
            };
        }

        private void ToggleMaximize()
        {
            if (isMaximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = normalLocation;
                this.Size = normalSize;
                btnMaximize.Text = "□";
                isMaximized = false;
            }
            else
            {
                normalLocation = this.Location;
                normalSize = this.Size;
                this.MaximumSize = Screen.FromControl(this).WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
                btnMaximize.Text = "❐";
                isMaximized = true;
            }
        }

        #region Navigation Handling

        private void SetupNavigation()
        {
            btnNavDashboard.Click += (s, e) => ShowDashboardView();
            btnNavIssueTicket.Click += (s, e) => ShowIssueTicketView();
            btnNavVerifyTicket.Click += (s, e) => ShowVerifyTicketView();
            btnNavBookings.Click += (s, e) => ShowBookingsView();
            btnNavTickets.Click += (s, e) => ShowTicketsView();
            btnNavManifest.Click += (s, e) => ShowManifestView();
            btnNavPayments.Click += (s, e) => ShowPaymentsView();
            btnNavFeedback.Click += (s, e) => ShowFeedbackView();
        }

        private void ResetNavButtons()
        {
            Button[] navs = { btnNavDashboard, btnNavIssueTicket, btnNavVerifyTicket, btnNavBookings, btnNavTickets, btnNavManifest, btnNavPayments, btnNavFeedback };
            foreach (var b in navs)
            {
                b.BackColor = Color.Transparent;
                b.ForeColor = Color.FromArgb(51, 65, 85);
                b.Font = new Font("Segoe UI", 9f, FontStyle.Regular);
            }
        }

        private void SetActiveNavButton(Button activeBtn)
        {
            ResetNavButtons();
            activeBtn.BackColor = Color.FromArgb(13, 94, 234);
            activeBtn.ForeColor = Color.White;
            activeBtn.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        private void HideAllViews()
        {
            flowDashboard.Visible = false;
            panelIssueTicket.Visible = false;
            panelVerifyBoarding.Visible = false;
            panelBookingManagement.Visible = false;
            panelTicketManagement.Visible = false;
            panelManifest.Visible = false;
            panelPayments.Visible = false;
            panelFeedback.Visible = false;
        }

        private void ShowDashboardView()
        {
            HideAllViews();
            flowDashboard.Visible = true;
            panelHeaderInfo.Visible = true;
            lblPageHeading.Text = "Ticket Counter Overview & Boarding Desk";
            lblPageSubHeading.Text = "Terminal Desk 01  •  Ethiopian Intercity Bus Terminal  •  Live Passenger Services & Boarding Verification";
            SetActiveNavButton(btnNavDashboard);
            PopulateDashboardMetrics();
            PopulateTripsTable();
        }

        private void ShowIssueTicketView()
        {
            HideAllViews();
            panelIssueTicket.Visible = true;
            panelHeaderInfo.Visible = false;
            SetActiveNavButton(btnNavIssueTicket);
            UpdateTicketPreview();
        }

        private void ShowVerifyTicketView()
        {
            HideAllViews();
            panelVerifyBoarding.Visible = true;
            panelHeaderInfo.Visible = false;
            SetActiveNavButton(btnNavVerifyTicket);
            txtVerifySearch.Focus();
        }

        private void ShowBookingsView()
        {
            HideAllViews();
            panelBookingManagement.Visible = true;
            panelHeaderInfo.Visible = false;
            SetActiveNavButton(btnNavBookings);
            PopulateBookingsList();
        }

        private void ShowTicketsView()
        {
            HideAllViews();
            panelTicketManagement.Visible = true;
            panelHeaderInfo.Visible = false;
            SetActiveNavButton(btnNavTickets);
            PopulateTicketsList();
        }

        private void ShowManifestView()
        {
            HideAllViews();
            panelManifest.Visible = true;
            panelHeaderInfo.Visible = false;
            SetActiveNavButton(btnNavManifest);
            LoadSelectedManifest();
        }

        private void ShowPaymentsView()
        {
            HideAllViews();
            panelPayments.Visible = true;
            panelHeaderInfo.Visible = false;
            SetActiveNavButton(btnNavPayments);
            PopulatePaymentsList();
        }

        private void ShowFeedbackView()
        {
            HideAllViews();
            panelFeedback.Visible = true;
            panelHeaderInfo.Visible = false;
            SetActiveNavButton(btnNavFeedback);
            PopulateInquiriesList();
        }

        #endregion

        #region 1. Dashboard Overview Logic

        private void SetupDashboardEvents()
        {
            btnQuickIssue.Click += (s, e) => ShowIssueTicketView();
            btnQuickScanner.Click += (s, e) => OpenModalScannerDialog();
            btnQuickManifest.Click += (s, e) => ShowManifestView();
            btnQuickReceipt.Click += (s, e) => ShowPaymentsView();
            btnQuickHelpdesk.Click += (s, e) => ShowFeedbackView();

            btnVerifyTicket.Click += (s, e) => QuickVerifyFromDashboard();
            txtTicketNumber.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    QuickVerifyFromDashboard();
                }
            };
        }

        private void PopulateDashboardMetrics()
        {
            var allTickets = TicketStore.GetAll();
            DateTime today = DateTime.Today;

            int ticketsToday = allTickets.Count(t => t.TravelDate.Date == today || t.IssuedDate.Date == today);
            int boardedCount = allTickets.Count(t => t.Status == "Boarded");
            int pendingBoarding = allTickets.Count(t => t.Status == "Valid" && t.TravelDate.Date == today);
            decimal revenueToday = PaymentStore.GetTotalCollectionsToday();

            lblMetricTicketsTodayVal.Text = $"{ticketsToday} Tickets";
            lblMetricBoardedVal.Text = $"{boardedCount} Boarded";
            lblMetricPendingVal.Text = $"{pendingBoarding} Pending";
            lblMetricRevenueTodayVal.Text = $"{revenueToday:N0} ETB";
        }

        private void PopulateTripsTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Trip Code", typeof(string));
            dt.Columns.Add("Route Name", typeof(string));
            dt.Columns.Add("Departure", typeof(string));
            dt.Columns.Add("Gate", typeof(string));
            dt.Columns.Add("Coach Plate", typeof(string));
            dt.Columns.Add("Booked Seats", typeof(string));
            dt.Columns.Add("Trip Status", typeof(string));

            var routes = RouteStore.GetAll().Take(6).ToList();
            var buses = BusStore.GetAll().ToList();

            string[] times = { "06:00 AM", "07:30 AM", "08:00 AM", "09:30 AM", "11:00 AM", "01:30 PM" };
            string[] gates = { "Gate 01", "Gate 02", "Gate 03", "Gate 04", "Gate 01", "Gate 05" };
            string[] statuses = { "Boarding", "Boarding", "Scheduled", "Scheduled", "Scheduled", "Scheduled" };

            for (int i = 0; i < routes.Count; i++)
            {
                var r = routes[i];
                string plate = (i < buses.Count) ? buses[i].PlateNumber : "ET-3-8821";
                int capacity = (i < buses.Count) ? buses[i].Capacity : 49;
                int booked = Math.Min(capacity, 35 + i * 2);

                dt.Rows.Add(
                    $"TRP-0{i + 1}",
                    $"{r.Source} ➔ {r.Destination} ({r.RouteName})",
                    times[i % times.Length],
                    gates[i % gates.Length],
                    plate,
                    $"{booked} / {capacity} seats",
                    statuses[i % statuses.Length]
                );
            }

            dgvTrips.DataSource = dt;
            dgvTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTrips.RowTemplate.Height = 32;

            if (dgvTrips.Columns.Count > 0)
            {
                dgvTrips.Columns[0].FillWeight = 55;
                dgvTrips.Columns[1].FillWeight = 140;
                dgvTrips.Columns[2].FillWeight = 65;
                dgvTrips.Columns[3].FillWeight = 55;
                dgvTrips.Columns[4].FillWeight = 75;
                dgvTrips.Columns[5].FillWeight = 75;
                dgvTrips.Columns[6].FillWeight = 65;
            }
        }

        private void QuickVerifyFromDashboard()
        {
            string query = txtTicketNumber.InputText.Trim();
            if (string.IsNullOrWhiteSpace(query))
            {
                lblVerifyResult.ForeColor = Color.FromArgb(239, 68, 68);
                lblVerifyResult.Text = "⚠️ Please enter a Ticket ID, Booking Ref, or Security Code.";
                return;
            }

            bool success = TicketStore.VerifyAndBoard(query, _officerName, out string message, out Ticket? ticket);

            if (success && ticket != null)
            {
                lblVerifyResult.ForeColor = Color.FromArgb(16, 185, 129);
                lblVerifyResult.Text = $"✅ {ticket.TicketId} VALIDATED! Passenger '{ticket.PassengerName}' ({ticket.SeatDisplay}) cleared for departure on {ticket.GateNumber}.";
                PopulateDashboardMetrics();
                PopulateTicketsList();
                PopulateBookingsList();
                LoadSelectedManifest();
            }
            else
            {
                lblVerifyResult.ForeColor = Color.FromArgb(220, 38, 38);
                lblVerifyResult.Text = message;
            }
        }

        #endregion

        #region 2. Issue Walk-In Ticket Logic

        private void PopulateIssueDropdowns()
        {
            cmbIssueRoute.Items.Clear();
            var routes = RouteStore.GetAll().Where(r => r.Status == "Active").ToList();
            foreach (var r in routes)
            {
                cmbIssueRoute.Items.Add($"{r.RouteId}: {r.RouteName} ({r.Source} ➔ {r.Destination})");
            }
            if (cmbIssueRoute.Items.Count > 0) cmbIssueRoute.SelectedIndex = 0;

            cmbIssueBus.Items.Clear();
            var buses = BusStore.GetAll().Where(b => b.Status == "Active").ToList();
            foreach (var b in buses)
            {
                cmbIssueBus.Items.Add($"{b.PlateNumber} - {b.FullModelName}");
            }
            if (cmbIssueBus.Items.Count > 0) cmbIssueBus.SelectedIndex = 0;

            cmbIssueTime.SelectedIndex = 0;
            cmbIssueGate.SelectedIndex = 1; // Gate 02
            cmbIssuePaymentMethod.SelectedIndex = 0; // Cash
            cmbIssuePaymentStatus.SelectedIndex = 0; // Paid
            dtpIssueDate.Value = DateTime.Today;

            UpdateFareFromSelectedRoute();
        }

        private void SetupIssueTicketEvents()
        {
            cmbIssueRoute.SelectedIndexChanged += (s, e) =>
            {
                UpdateFareFromSelectedRoute();
                UpdateTicketPreview();
            };

            dtpIssueDate.ValueChanged += (s, e) => UpdateTicketPreview();
            cmbIssueTime.SelectedIndexChanged += (s, e) => UpdateTicketPreview();
            cmbIssueBus.SelectedIndexChanged += (s, e) => UpdateTicketPreview();
            cmbIssueGate.SelectedIndexChanged += (s, e) => UpdateTicketPreview();
            numIssueSeat.ValueChanged += (s, e) => UpdateTicketPreview();
            numIssueFare.ValueChanged += (s, e) => UpdateTicketPreview();
            cmbIssuePaymentMethod.SelectedIndexChanged += (s, e) => UpdateTicketPreview();
            txtIssueName.TextChanged += (s, e) => UpdateTicketPreview();
            txtIssuePhone.TextChanged += (s, e) => UpdateTicketPreview();

            btnConfirmIssueTicket.Click += (s, e) => ProcessIssueTicket();
            btnClearIssueForm.Click += (s, e) => ClearIssueForm();
            btnOpenAdvancedBooking.Click += (s, e) =>
            {
                using (var dlg = new BookingDialogForm())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        PopulateBookingsList();
                        PopulateTicketsList();
                        PopulateDashboardMetrics();
                        ShowBookingsView();
                    }
                }
            };
        }

        private void UpdateFareFromSelectedRoute()
        {
            if (cmbIssueRoute.SelectedItem == null) return;
            string selectedStr = cmbIssueRoute.SelectedItem.ToString() ?? "";
            string routeId = selectedStr.Split(':')[0].Trim();

            var route = RouteStore.GetById(routeId);
            if (route != null)
            {
                numIssueFare.Value = route.BaseFare;
            }
        }

        private void UpdateTicketPreview()
        {
            string passName = string.IsNullOrWhiteSpace(txtIssueName.Text) ? "[PASSENGER NAME]" : txtIssueName.Text.Trim().ToUpper();
            string phone = string.IsNullOrWhiteSpace(txtIssuePhone.Text) ? "+251 9XX XXXXXX" : txtIssuePhone.Text.Trim();
            string routeText = cmbIssueRoute.SelectedItem?.ToString() ?? "Addis Ababa ➔ Regional Hub";
            string travelDate = dtpIssueDate.Value.ToString("dddd, yyyy-MM-dd");
            string time = cmbIssueTime.SelectedItem?.ToString() ?? "06:00 AM";
            string bus = cmbIssueBus.SelectedItem?.ToString() ?? "ET-3-XXXX Coach";
            string gate = cmbIssueGate.SelectedItem?.ToString() ?? "Gate 01";
            int seat = (int)numIssueSeat.Value;
            decimal fare = numIssueFare.Value;
            string method = cmbIssuePaymentMethod.SelectedItem?.ToString() ?? "Cash";

            lblSummaryDetails.Text =
                $"• Route:     {routeText}\n" +
                $"• Schedule:  {travelDate} at {time}\n" +
                $"• Departure: {gate} | Assigned: {bus}\n" +
                $"• Seat:      Seat {seat:D2} | Standard Fare: {fare:N0} ETB\n" +
                $"• Payment:   {method} (Terminal Desk 01)";

            txtTicketPreview.Text =
                "================================================\n" +
                "    ETHIOPIAN BUS TRANSPORT - BOARDING PASS     \n" +
                "================================================\n\n" +
                $" TICKET ID:    [GENERATING UPON ISSUE]\n" +
                $" PASSENGER:    {passName}\n" +
                $" PHONE:        {phone}\n" +
                "------------------------------------------------\n" +
                $" ROUTE:        {routeText}\n" +
                $" TRAVEL DATE:  {travelDate}\n" +
                $" TIME & GATE:  {time}  |  {gate}\n" +
                $" COACH PLATE:  {bus}\n" +
                $" SEAT NUMBER:  SEAT {seat:D2}\n" +
                "------------------------------------------------\n" +
                $" FARE AMOUNT:  {fare:N0} ETB (INCL. VAT)\n" +
                $" PAYMENT:      {method.ToUpper()} (CONFIRMED)\n" +
                $" ISSUED BY:    {_officerName}\n" +
                $" TIMESTAMP:    {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n" +
                "================================================\n" +
                " BOARDING NOTICE:\n" +
                " 1. Please arrive at the terminal 30 min before trip.\n" +
                " 2. Present Kebele ID or Passport alongside this pass.\n" +
                " 3. Standard baggage allowance: 25 kg.\n" +
                "================================================";
        }

        private void ProcessIssueTicket()
        {
            string name = txtIssueName.Text.Trim();
            string phone = txtIssuePhone.Text.Trim();
            string email = txtIssueEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter the passenger's full name.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIssueName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Please enter the passenger's contact phone number.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIssuePhone.Focus();
                return;
            }

            if (cmbIssueRoute.SelectedItem == null)
            {
                MessageBox.Show("Please select a route for this booking.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string routeFull = cmbIssueRoute.SelectedItem.ToString() ?? "";
            string routeId = routeFull.Split(':')[0].Trim();
            var route = RouteStore.GetById(routeId);

            string source = route?.Source ?? "Addis Ababa";
            string dest = route?.Destination ?? "Destination";
            string rName = route?.RouteName ?? routeFull;

            DateTime travelDate = dtpIssueDate.Value.Date;
            string time = cmbIssueTime.SelectedItem?.ToString() ?? "06:00 AM";
            string busFull = cmbIssueBus.SelectedItem?.ToString() ?? "ET-3-4812";
            string busPlate = busFull.Split('-')[0].Trim();
            if (busPlate.Length < 3) busPlate = "ET-3-4812";
            string busModel = busFull.Contains("-") ? busFull.Substring(busFull.IndexOf('-') + 1).Trim() : "Intercity Coach";
            string gate = cmbIssueGate.SelectedItem?.ToString() ?? "Gate 01";
            int seat = (int)numIssueSeat.Value;
            decimal fare = numIssueFare.Value;
            string method = cmbIssuePaymentMethod.SelectedItem?.ToString() ?? "Cash";
            string payStatus = cmbIssuePaymentStatus.SelectedItem?.ToString() ?? "Paid";
            string luggage = txtIssueLuggage.Text.Trim();
            string notes = txtIssueNotes.Text.Trim();

            // 1. Generate IDs
            string ticketId = TicketStore.GenerateNextId();
            string bookingId = BookingStore.GenerateNextId();

            // 2. Add Booking
            var booking = new Booking(
                bookingId,
                name,
                phone,
                email,
                routeId,
                rName,
                source,
                dest,
                travelDate,
                time,
                busPlate,
                new List<int> { seat },
                fare,
                "Confirmed",
                payStatus,
                $"Walk-in counter booking issued at Terminal Desk 01. {notes}"
            );
            BookingStore.Add(booking);

            // 3. Add Ticket
            var ticket = new Ticket(
                ticketId,
                bookingId,
                name,
                phone,
                email,
                routeId,
                rName,
                source,
                dest,
                travelDate,
                time,
                gate,
                busPlate,
                busModel,
                seat,
                fare,
                "Valid",
                $"VER-{new Random().Next(10000, 99999)}-{ticketId}",
                $"Walk-in counter ticket. {notes}"
            )
            {
                LuggageAllowance = string.IsNullOrWhiteSpace(luggage) ? "25 kg (1 Piece Cargo + 1 Handbag)" : luggage
            };
            TicketStore.Add(ticket);

            // 4. Record Payment
            if (payStatus == "Paid")
            {
                var paymentRec = new PaymentRecord(
                    PaymentStore.GenerateNextReceiptNo(),
                    bookingId,
                    ticketId,
                    name,
                    rName,
                    fare,
                    method,
                    "Paid",
                    DateTime.Now,
                    _officerName,
                    $"Walk-in counter cashier intake for seat {seat:D2}."
                );
                PaymentStore.Add(paymentRec);
            }

            // 5. Refresh stores & UI
            PopulateDashboardMetrics();
            PopulateBookingsList();
            PopulateTicketsList();
            PopulatePaymentsList();
            LoadSelectedManifest();

            string ticketSummary =
                "============================================================\n" +
                "       TICKET & BOARDING PASS ISSUED SUCCESSFULLY!          \n" +
                "============================================================\n\n" +
                $"• TICKET NUMBER:       {ticket.TicketId}\n" +
                $"• BOOKING REFERENCE:   {ticket.BookingId}\n" +
                $"• PASSENGER NAME:      {ticket.PassengerName}\n" +
                $"• CONTACT PHONE:       {ticket.PassengerPhone}\n" +
                $"• JOURNEY ROUTE:       {ticket.FullRouteDisplay}\n" +
                $"• TRAVEL DATE & TIME:  {ticket.TravelDate:yyyy-MM-dd} at {ticket.DepartureTime}\n" +
                $"• DEPARTURE TERMINAL:  {ticket.GateNumber} (Coach: {ticket.AssignedBusPlate})\n" +
                $"• SEAT ALLOCATION:     {ticket.SeatDisplay}\n" +
                $"• TOTAL FARE COLLECTED:{ticket.FareAmount:N0} ETB via {method}\n" +
                $"• SECURITY CODE:       {ticket.SecurityVerificationCode}\n\n" +
                $"Boarding pass has been generated and ready for print or passenger collection.";

            MessageBox.Show(ticketSummary, "Ticket Issued Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearIssueForm();
        }

        private void ClearIssueForm()
        {
            txtIssueName.Text = string.Empty;
            txtIssuePhone.Text = string.Empty;
            txtIssueEmail.Text = string.Empty;
            txtIssueNotes.Text = string.Empty;
            numIssueSeat.Value = Math.Min(numIssueSeat.Maximum, numIssueSeat.Value + 1);
            UpdateTicketPreview();
        }

        #endregion

        #region 3. Verification & Boarding Station Logic

        private void SetupVerifyBoardingEvents()
        {
            btnVerifyLookup.Click += (s, e) => PerformVerificationLookup();
            txtVerifySearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    PerformVerificationLookup();
                }
            };

            btnOpenModalScanner.Click += (s, e) => OpenModalScannerDialog();
            btnMarkBoardedAction.Click += (s, e) => ConfirmActiveTicketBoarding();
            btnPrintVerificationPass.Click += (s, e) => PrintActiveTicketPass();
            btnReportDiscrepancy.Click += (s, e) => ReportActiveTicketIssue();
        }

        private void PerformVerificationLookup()
        {
            string query = txtVerifySearch.Text.Trim();
            if (string.IsNullOrWhiteSpace(query))
            {
                SetVerificationState("empty", "ENTER BOARDING REFERENCE", "Please type or scan Ticket ID, Booking Reference, or QR Verification Code.");
                ResetDossierDisplay();
                return;
            }

            var all = TicketStore.GetAll();
            _activeScannedTicket = all.FirstOrDefault(t =>
                t.TicketId.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                t.BookingId.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                t.SecurityVerificationCode.Equals(query, StringComparison.OrdinalIgnoreCase));

            if (_activeScannedTicket == null)
            {
                SetVerificationState("notfound", "TICKET REFERENCE NOT FOUND", $"No boarding pass matching '{query}' exists in the active terminal database.");
                ResetDossierDisplay();
                return;
            }

            DisplayDossierDetails(_activeScannedTicket);

            if (_activeScannedTicket.Status == "Valid")
            {
                SetVerificationState("valid", "✅ PASSENGER AUTHORIZED FOR BOARDING",
                    $"Scheduled for departure today on {_activeScannedTicket.AssignedBusPlate} via {_activeScannedTicket.GateNumber}. Please check Kebele ID.");
                btnMarkBoardedAction.Enabled = true;
                btnPrintVerificationPass.Enabled = true;
            }
            else if (_activeScannedTicket.Status == "Boarded")
            {
                string boardedInfo = _activeScannedTicket.BoardedTime.HasValue
                    ? $"{_activeScannedTicket.BoardedTime.Value:yyyy-MM-dd HH:mm}"
                    : "earlier today";
                string officer = string.IsNullOrWhiteSpace(_activeScannedTicket.VerifiedBy) ? "Gate Agent" : _activeScannedTicket.VerifiedBy;

                SetVerificationState("boarded", "⚠️ ALREADY CHECKED-IN & BOARDED",
                    $"This boarding ticket was already validated and boarded on {boardedInfo} by {officer}. Duplicate entry prohibited!");
                btnMarkBoardedAction.Enabled = false;
                btnPrintVerificationPass.Enabled = true;
            }
            else if (_activeScannedTicket.Status == "Cancelled")
            {
                SetVerificationState("cancelled", "❌ VOID: TICKET CANCELLED & REFUNDED",
                    "This ticket was formally cancelled and cannot be used for coach boarding.");
                btnMarkBoardedAction.Enabled = false;
                btnPrintVerificationPass.Enabled = false;
            }
            else
            {
                SetVerificationState("unknown", $"STATUS: {_activeScannedTicket.Status.ToUpper()}",
                    "Review passenger reservation with terminal shift manager before clearance.");
                btnMarkBoardedAction.Enabled = false;
                btnPrintVerificationPass.Enabled = false;
            }
        }

        private void SetVerificationState(string state, string title, string subtitle)
        {
            lblVerifyBannerTitle.Text = title;
            lblVerifyBannerSub.Text = subtitle;

            switch (state.ToLower())
            {
                case "valid":
                    panelVerifyBanner.BackColor = Color.FromArgb(236, 253, 245);
                    lblVerifyBannerTitle.ForeColor = Color.FromArgb(5, 150, 105);
                    lblVerifyBannerSub.ForeColor = Color.FromArgb(4, 120, 87);
                    break;
                case "boarded":
                    panelVerifyBanner.BackColor = Color.FromArgb(254, 243, 199);
                    lblVerifyBannerTitle.ForeColor = Color.FromArgb(180, 83, 9);
                    lblVerifyBannerSub.ForeColor = Color.FromArgb(146, 64, 14);
                    break;
                case "cancelled":
                case "notfound":
                    panelVerifyBanner.BackColor = Color.FromArgb(254, 242, 242);
                    lblVerifyBannerTitle.ForeColor = Color.FromArgb(220, 38, 38);
                    lblVerifyBannerSub.ForeColor = Color.FromArgb(185, 28, 28);
                    break;
                default:
                    panelVerifyBanner.BackColor = Color.FromArgb(241, 245, 249);
                    lblVerifyBannerTitle.ForeColor = Color.FromArgb(15, 23, 42);
                    lblVerifyBannerSub.ForeColor = Color.FromArgb(71, 85, 105);
                    break;
            }
        }

        private void DisplayDossierDetails(Ticket t)
        {
            string checkIn = t.BoardedTime.HasValue ? t.BoardedTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "Not Checked-In Yet";
            string officer = string.IsNullOrWhiteSpace(t.VerifiedBy) ? "Awaiting Gate Clearance" : t.VerifiedBy;

            lblDossierContent.Text =
                $"• TICKET NUMBER:       {t.TicketId}\n" +
                $"• BOOKING REFERENCE:   {t.BookingId}\n" +
                $"• PASSENGER NAME:      {t.PassengerName}\n" +
                $"• CONTACT PHONE:       {t.PassengerPhone}\n" +
                $"• EMAIL ADDRESS:       {(string.IsNullOrWhiteSpace(t.PassengerEmail) ? "N/A" : t.PassengerEmail)}\n" +
                $"• JOURNEY ROUTE:       {t.FullRouteDisplay} ({t.RouteName})\n" +
                $"• TRAVEL DATE & TIME:  {t.TravelDate:dddd, yyyy-MM-dd} at {t.DepartureTime}\n" +
                $"• DEPARTURE GATE:      {t.GateNumber}\n" +
                $"• ASSIGNED COACH:      {t.AssignedBusPlate} ({t.BusModel})\n" +
                $"• SEAT ALLOCATION:     {t.SeatDisplay}\n" +
                $"• TICKET FARE AMOUNT:  {t.FareAmount:N0} ETB (PAID)\n" +
                $"• SECURITY CODE:       {t.SecurityVerificationCode}\n" +
                $"• BAGGAGE ALLOWANCE:   {t.LuggageAllowance}\n" +
                $"• BOARDING STATUS:     {t.Status.ToUpper()}\n" +
                $"• CHECK-IN TIMESTAMP:  {checkIn}\n" +
                $"• VERIFIED BY:         {officer}\n" +
                $"• SPECIAL NOTES:       {(string.IsNullOrWhiteSpace(t.Notes) ? "(None)" : t.Notes)}";
        }

        private void ResetDossierDisplay()
        {
            _activeScannedTicket = null;
            btnMarkBoardedAction.Enabled = false;
            btnPrintVerificationPass.Enabled = false;
            lblDossierContent.Text = "No ticket loaded yet. Enter reference to inspect passenger details, coach assignment, and security clearance.";
        }

        private void ConfirmActiveTicketBoarding()
        {
            if (_activeScannedTicket == null) return;

            bool success = TicketStore.VerifyAndBoard(_activeScannedTicket.TicketId, _officerName, out string message, out Ticket? ticket);

            if (success && ticket != null)
            {
                _activeScannedTicket = ticket;
                SetVerificationState("boarded", "✅ BOARDING COMPLETED SUCCESSFULLY!",
                    $"Passenger '{ticket.PassengerName}' checked-in at {ticket.GateNumber}. Departure logged at {DateTime.Now:HH:mm}.");
                DisplayDossierDetails(ticket);
                btnMarkBoardedAction.Enabled = false;

                PopulateDashboardMetrics();
                PopulateTicketsList();
                PopulateBookingsList();
                LoadSelectedManifest();

                MessageBox.Show(message, "Boarding Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Boarding Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintActiveTicketPass()
        {
            if (_activeScannedTicket == null) return;
            PrintSingleTicket(_activeScannedTicket);
        }

        private void ReportActiveTicketIssue()
        {
            if (_activeScannedTicket == null)
            {
                MessageBox.Show("Please load a ticket to report an issue or cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Do you want to CANCEL and VOID Ticket '{_activeScannedTicket.TicketId}' for passenger '{_activeScannedTicket.PassengerName}'?",
                "Confirm Ticket Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool cancelled = TicketStore.CancelTicket(_activeScannedTicket.TicketId, out string msg);
                if (cancelled)
                {
                    PerformVerificationLookup();
                    PopulateDashboardMetrics();
                    PopulateTicketsList();
                    PopulateBookingsList();
                    LoadSelectedManifest();
                    MessageBox.Show(msg, "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msg, "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void OpenModalScannerDialog()
        {
            using (var dlg = new TicketVerifyDialogForm())
            {
                dlg.ShowDialog(this);
                PopulateDashboardMetrics();
                PopulateTicketsList();
                PopulateBookingsList();
                LoadSelectedManifest();
            }
        }

        #endregion

        #region 4. Bookings Desk Logic

        private void SetupBookingManagementEvents()
        {
            btnNewBooking.Click += (s, e) =>
            {
                using (var dlg = new BookingDialogForm())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        PopulateBookingsList();
                        PopulateTicketsList();
                        PopulateDashboardMetrics();
                    }
                }
            };

            btnModifyBooking.Click += (s, e) => EditSelectedBooking();
            lvBookings.DoubleClick += (s, e) => EditSelectedBooking();
            btnViewBookingDetails.Click += (s, e) => ViewSelectedBookingDossier();
            btnCancelBookingAction.Click += (s, e) => CancelSelectedBookingReservation();
            btnPrintTicket.Click += (s, e) => PrintSelectedBookingPass();

            txtSearchBooking.TextChanged += (s, e) => PopulateBookingsList();
            cmbBookingStatusFilter.SelectedIndexChanged += (s, e) => PopulateBookingsList();
            cmbBookingRouteFilter.SelectedIndexChanged += (s, e) => PopulateBookingsList();

            chkEnableDateFilter.CheckedChanged += (s, e) =>
            {
                dtpBookingFilterDate.Enabled = chkEnableDateFilter.Checked;
                PopulateBookingsList();
            };
            dtpBookingFilterDate.ValueChanged += (s, e) =>
            {
                if (chkEnableDateFilter.Checked) PopulateBookingsList();
            };

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
            int total = BookingStore.GetTotalCount();
            int confirmed = BookingStore.GetConfirmedCount();
            int pending = BookingStore.GetPendingCount();
            int cancelled = BookingStore.GetCancelledCount();
            int today = BookingStore.GetTodayCount();

            lblMetricTotalBookingsVal.Text = total.ToString("N0");
            lblMetricConfirmedBookingsVal.Text = confirmed.ToString("N0");
            lblMetricPendingBookingsVal.Text = pending.ToString("N0");
            lblMetricCancelledBookingsVal.Text = cancelled.ToString("N0");
            lblMetricTodayBookingsVal.Text = today.ToString("N0");

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

            string search = txtSearchBooking.Text.Trim().ToLower();
            string statusFilter = cmbBookingStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            string routeFilter = cmbBookingRouteFilter.SelectedItem?.ToString() ?? "All Routes / Trips";
            bool filterDate = chkEnableDateFilter.Checked;
            DateTime targetDate = dtpBookingFilterDate.Value.Date;

            var all = BookingStore.GetAll();
            var filtered = all.Where(b =>
            {
                bool match = string.IsNullOrEmpty(search) ||
                    b.BookingId.ToLower().Contains(search) ||
                    b.PassengerName.ToLower().Contains(search) ||
                    b.PassengerPhone.ToLower().Contains(search) ||
                    b.RouteName.ToLower().Contains(search) ||
                    b.AssignedBus.ToLower().Contains(search);

                if (!match) return false;
                if (statusFilter != "All Statuses" && !b.BookingStatus.Equals(statusFilter, StringComparison.OrdinalIgnoreCase)) return false;

                if (routeFilter != "All Routes / Trips")
                {
                    string routePrefix = routeFilter.Split(':')[0].Trim();
                    if (!b.RouteId.Equals(routePrefix, StringComparison.OrdinalIgnoreCase) && !b.RouteName.Equals(routeFilter, StringComparison.OrdinalIgnoreCase))
                        return false;
                }

                if (filterDate && b.TravelDate.Date != targetDate) return false;

                return true;
            }).OrderByDescending(b => b.TravelDate).ToList();

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
                item.SubItems.Add(b.TotalAmount.ToString("N0"));
                item.SubItems.Add(b.BookingStatus);
                item.SubItems.Add(b.PaymentStatus);

                if (b.BookingStatus == "Cancelled")
                    item.ForeColor = Color.FromArgb(239, 68, 68);
                else if (b.BookingStatus == "Pending")
                    item.ForeColor = Color.FromArgb(234, 88, 12);
                else
                    item.ForeColor = Color.FromArgb(15, 23, 42);

                item.Tag = b;
                lvBookings.Items.Add(item);
            }

            lvBookings.EndUpdate();
            lblBookingCount.Text = $"Showing {filtered.Count} of {all.Count} bookings";
        }

        private Booking? GetSelectedBooking()
        {
            if (lvBookings.SelectedItems.Count > 0 && lvBookings.SelectedItems[0].Tag is Booking b)
                return b;
            return null;
        }

        private void EditSelectedBooking()
        {
            var b = GetSelectedBooking();
            if (b == null)
            {
                MessageBox.Show("Please select a booking to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dlg = new BookingDialogForm(b))
            {
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateBookingsList();
                    PopulateTicketsList();
                    PopulateDashboardMetrics();
                }
            }
        }

        private void ViewSelectedBookingDossier()
        {
            var b = GetSelectedBooking();
            if (b == null)
            {
                MessageBox.Show("Please select a booking from the list to view dossier.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string dossier =
                "====================================================\n" +
                "         PASSENGER BOOKING RESERVATION DOSSIER      \n" +
                "====================================================\n\n" +
                $"• BOOKING REFERENCE:  {b.BookingId}\n" +
                $"• PASSENGER NAME:     {b.PassengerName}\n" +
                $"• CONTACT PHONE:      {b.PassengerPhone}\n" +
                $"• EMAIL ADDRESS:      {(string.IsNullOrWhiteSpace(b.PassengerEmail) ? "N/A" : b.PassengerEmail)}\n" +
                $"• ROUTE:              {b.FullRouteDisplay} ({b.RouteName})\n" +
                $"• TRAVEL DATE:        {b.TravelDate:dddd, yyyy-MM-dd}\n" +
                $"• DEPARTURE TIME:     {b.DepartureTime}\n" +
                $"• ASSIGNED COACH:     {b.AssignedBus}\n" +
                $"• SEATS ALLOCATED:    {b.SeatNumbersDisplay} ({b.NumberOfSeats} Seat{(b.NumberOfSeats > 1 ? "s" : "")})\n" +
                $"• FARE PER SEAT:      {b.FarePerSeat:N0} ETB\n" +
                $"• TOTAL FARE AMOUNT:  {b.TotalAmount:N0} ETB\n" +
                $"• BOOKING STATUS:     {b.BookingStatus.ToUpper()}\n" +
                $"• PAYMENT STATUS:     {b.PaymentStatus.ToUpper()}\n" +
                $"• RESERVATION TIME:   {b.BookingDate:yyyy-MM-dd HH:mm}\n" +
                $"• SPECIAL NOTES:      {(string.IsNullOrWhiteSpace(b.Notes) ? "(None)" : b.Notes)}";

            MessageBox.Show(dossier, $"Booking Dossier - {b.BookingId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelSelectedBookingReservation()
        {
            var b = GetSelectedBooking();
            if (b == null)
            {
                MessageBox.Show("Please select a booking to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (b.BookingStatus == "Cancelled")
            {
                MessageBox.Show("This booking is already cancelled.", "Already Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to CANCEL booking '{b.BookingId}' for passenger '{b.PassengerName}'?\n\n" +
                $"Seats ({b.SeatNumbersDisplay}) will be released immediately back to the availability pool.",
                "Confirm Reservation Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool success = BookingStore.CancelBooking(b.BookingId);
                if (success)
                {
                    PopulateBookingsList();
                    PopulateTicketsList();
                    PopulateDashboardMetrics();
                    MessageBox.Show($"Booking '{b.BookingId}' cancelled and seats released.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void PrintSelectedBookingPass()
        {
            var b = GetSelectedBooking();
            if (b == null)
            {
                MessageBox.Show("Please select a booking to print boarding pass.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (b.BookingStatus == "Cancelled")
            {
                MessageBox.Show("Cannot print boarding pass for a cancelled booking.", "Cancelled Reservation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passText =
                "============================================================\n" +
                "       ETHIOPIAN BUS TRANSPORT SYSTEM - BOARDING PASS       \n" +
                "============================================================\n\n" +
                $" TICKET / BOOKING REF:  {b.BookingId}\n" +
                $" PASSENGER NAME:        {b.PassengerName.ToUpper()}\n" +
                $" CONTACT PHONE:         {b.PassengerPhone}\n" +
                "------------------------------------------------------------\n" +
                $" ROUTE:                 {b.Source} ➔ {b.Destination}\n" +
                $" TRAVEL DATE:           {b.TravelDate:dddd, MMMM dd, yyyy}\n" +
                $" SCHEDULED DEPARTURE:   {b.DepartureTime}\n" +
                $" ASSIGNED COACH:        {b.AssignedBus}\n" +
                $" SEAT ASSIGNMENT:       {b.SeatNumbersDisplay}\n" +
                "------------------------------------------------------------\n" +
                $" TOTAL FARE:            {b.TotalAmount:N0} ETB (PAID)\n" +
                $" PAYMENT STATUS:        {b.PaymentStatus.ToUpper()}\n" +
                $" ISSUED AT:             {_officerName} on {DateTime.Now:yyyy-MM-dd HH:mm}\n" +
                "============================================================\n" +
                " 1. Please arrive at the departure terminal 30 minutes before.\n" +
                " 2. Present this boarding pass along with your Kebele ID.\n" +
                " 3. Standard baggage allowance: 25 kg per ticket.\n" +
                "============================================================";

            MessageBox.Show(passText, $"Boarding Pass - {b.BookingId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region 5. Tickets Directory Logic

        private void SetupTicketManagementEvents()
        {
            btnNewTicket.Click += (s, e) =>
            {
                using (var dlg = new TicketDialogForm())
                {
                    if (dlg.ShowDialog(this) == DialogResult.OK)
                    {
                        PopulateTicketsList();
                        PopulateBookingsList();
                        PopulateDashboardMetrics();
                    }
                }
            };

            btnVerifyBoardModal.Click += (s, e) => OpenModalScannerDialog();
            btnVerifyAndBoard.Click += (s, e) => QuickVerifyAndBoardSelectedTicket();
            btnViewTicketDetails.Click += (s, e) => ViewSelectedTicketDetails();
            lvTickets.DoubleClick += (s, e) => ViewSelectedTicketDetails();
            btnPrintTicketPass.Click += (s, e) => PrintSelectedTicketPass();
            btnCancelTicketAction.Click += (s, e) => CancelSelectedTicket();

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
                if (chkEnableTicketDateFilter.Checked) PopulateTicketsList();
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
            int total = TicketStore.GetTotalCount();
            int valid = TicketStore.GetValidCount();
            int boarded = TicketStore.GetBoardedCount();
            int cancelled = TicketStore.GetCancelledCount();
            int today = TicketStore.GetTodayBoardingCount();

            lblMetricTotalTicketsVal.Text = total.ToString("N0");
            lblMetricValidTicketsVal.Text = valid.ToString("N0");
            lblMetricBoardedTicketsVal.Text = boarded.ToString("N0");
            lblMetricCancelledTicketsVal.Text = cancelled.ToString("N0");
            lblMetricTodayTicketsVal.Text = today.ToString("N0");

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

            string search = txtSearchTicketFilter.Text.Trim().ToLower();
            string status = cmbTicketStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            string route = cmbTicketRouteFilter.SelectedItem?.ToString() ?? "All Routes / Trips";
            bool filterDate = chkEnableTicketDateFilter.Checked;
            DateTime targetDate = dtpTicketFilterDate.Value.Date;

            var all = TicketStore.GetAll();
            var filtered = all.Where(t =>
            {
                bool match = string.IsNullOrEmpty(search) ||
                    t.TicketId.ToLower().Contains(search) ||
                    t.BookingId.ToLower().Contains(search) ||
                    t.PassengerName.ToLower().Contains(search) ||
                    t.PassengerPhone.ToLower().Contains(search) ||
                    t.RouteName.ToLower().Contains(search) ||
                    t.SecurityVerificationCode.ToLower().Contains(search);

                if (!match) return false;
                if (status != "All Statuses" && !t.Status.Equals(status, StringComparison.OrdinalIgnoreCase)) return false;

                if (route != "All Routes / Trips")
                {
                    string routePrefix = route.Split(':')[0].Trim();
                    if (!t.RouteId.Equals(routePrefix, StringComparison.OrdinalIgnoreCase) && !t.RouteName.Equals(route, StringComparison.OrdinalIgnoreCase))
                        return false;
                }

                if (filterDate && t.TravelDate.Date != targetDate) return false;

                return true;
            }).OrderByDescending(t => t.TravelDate).ToList();

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

                if (t.Status == "Boarded")
                    item.ForeColor = Color.FromArgb(16, 185, 129);
                else if (t.Status == "Cancelled")
                    item.ForeColor = Color.FromArgb(239, 68, 68);
                else
                    item.ForeColor = Color.FromArgb(15, 23, 42);

                item.Tag = t;
                lvTickets.Items.Add(item);
            }

            lvTickets.EndUpdate();
            lblTicketCount.Text = $"Showing {filtered.Count} of {all.Count} tickets";
        }

        private Ticket? GetSelectedTicket()
        {
            if (lvTickets.SelectedItems.Count > 0 && lvTickets.SelectedItems[0].Tag is Ticket t)
                return t;
            return null;
        }

        private void QuickVerifyAndBoardSelectedTicket()
        {
            var t = GetSelectedTicket();
            if (t == null)
            {
                MessageBox.Show("Please select a ticket from the table to verify and board.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool success = TicketStore.VerifyAndBoard(t.TicketId, _officerName, out string msg, out Ticket? updated);
            if (success && updated != null)
            {
                PopulateTicketsList();
                PopulateDashboardMetrics();
                LoadSelectedManifest();
                MessageBox.Show(msg, "Passenger Boarded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msg, "Boarding Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ViewSelectedTicketDetails()
        {
            var t = GetSelectedTicket();
            if (t == null)
            {
                MessageBox.Show("Please select a ticket to view specifications.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string checkIn = t.BoardedTime.HasValue ? t.BoardedTime.Value.ToString("yyyy-MM-dd HH:mm:ss") : "Not Boarded";
            string officer = string.IsNullOrWhiteSpace(t.VerifiedBy) ? "Awaiting Gate Clearance" : t.VerifiedBy;

            string details =
                "============================================================\n" +
                "               PASSENGER TICKET DOSSIER                     \n" +
                "============================================================\n\n" +
                $"• TICKET ID:           {t.TicketId}\n" +
                $"• BOOKING REFERENCE:   {t.BookingId}\n" +
                $"• PASSENGER NAME:      {t.PassengerName}\n" +
                $"• PHONE NUMBER:        {t.PassengerPhone}\n" +
                $"• EMAIL ADDRESS:       {(string.IsNullOrWhiteSpace(t.PassengerEmail) ? "N/A" : t.PassengerEmail)}\n\n" +
                $"--- JOURNEY SPECIFICATIONS ---\n" +
                $"• ROUTE:              {t.FullRouteDisplay} ({t.RouteName})\n" +
                $"• TRAVEL DATE:        {t.TravelDate:dddd, yyyy-MM-dd}\n" +
                $"• DEPARTURE TIME:     {t.DepartureTime}\n" +
                $"• TERMINAL GATE:      {t.GateNumber}\n" +
                $"• COACH ASSIGNED:     {t.AssignedBusPlate} ({t.BusModel})\n" +
                $"• SEAT NUMBER:        {t.SeatDisplay}\n" +
                $"• TICKET FARE:        {t.FareAmount:N0} ETB\n\n" +
                $"--- SECURITY & BOARDING ---\n" +
                $"• TICKET STATUS:      {t.Status.ToUpper()}\n" +
                $"• SECURITY CODE:      {t.SecurityVerificationCode}\n" +
                $"• BOARDED TIMESTAMP:  {checkIn}\n" +
                $"• VERIFIED BY:        {officer}\n" +
                $"• LUGGAGE ALLOWANCE:  {t.LuggageAllowance}\n\n" +
                $"OPERATIONAL NOTES:\n{(string.IsNullOrWhiteSpace(t.Notes) ? "(No extra notes logged)" : t.Notes)}";

            MessageBox.Show(details, $"Ticket Dossier - {t.TicketId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintSelectedTicketPass()
        {
            var t = GetSelectedTicket();
            if (t == null)
            {
                MessageBox.Show("Please select a ticket from the list to print.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            PrintSingleTicket(t);
        }

        private void PrintSingleTicket(Ticket t)
        {
            if (t.Status == "Cancelled")
            {
                MessageBox.Show("Cannot print boarding pass for a cancelled ticket.", "Cancelled Ticket", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string pass =
                "============================================================\n" +
                "    ETHIOPIAN BUS TRANSPORT SYSTEM - OFFICIAL BOARDING PASS  \n" +
                "============================================================\n\n" +
                $" TICKET ID:         {t.TicketId}\n" +
                $" BOOKING REF:       {t.BookingId}\n" +
                $" PASSENGER NAME:    {t.PassengerName.ToUpper()}\n" +
                $" CONTACT PHONE:     {t.PassengerPhone}\n" +
                "------------------------------------------------------------\n" +
                $" ROUTE:             {t.FullRouteDisplay}\n" +
                $" TRAVEL DATE:       {t.TravelDate:dddd, MMMM dd, yyyy}\n" +
                $" DEPARTURE TIME:    {t.DepartureTime}\n" +
                $" TERMINAL GATE:     {t.GateNumber}\n" +
                $" COACH ASSIGNED:    {t.AssignedBusPlate} ({t.BusModel})\n" +
                $" SEAT ASSIGNMENT:   {t.SeatDisplay}\n" +
                "------------------------------------------------------------\n" +
                $" FARE AMOUNT:       {t.FareAmount:N0} ETB (PAID IN FULL)\n" +
                $" SECURITY CODE:     {t.SecurityVerificationCode}\n" +
                $" BOARDING STATUS:   {t.Status.ToUpper()}\n" +
                $" ISSUED BY:         {_officerName} on {DateTime.Now:yyyy-MM-dd HH:mm}\n" +
                "============================================================\n" +
                " BOARDING NOTICE:\n" +
                " 1. Please arrive at the departure terminal 30 min before trip.\n" +
                " 2. Present Kebele ID or Passport alongside this boarding pass.\n" +
                " 3. Baggage allowance: 25 kg.\n" +
                "============================================================";

            MessageBox.Show(pass, $"Boarding Pass - {t.TicketId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CancelSelectedTicket()
        {
            var t = GetSelectedTicket();
            if (t == null)
            {
                MessageBox.Show("Please select a ticket from the table to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to CANCEL ticket '{t.TicketId}' for passenger '{t.PassengerName}'?\n\n" +
                $"Seat {t.SeatDisplay} will be released.",
                "Confirm Ticket Cancellation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                bool success = TicketStore.CancelTicket(t.TicketId, out string msg);
                if (success)
                {
                    PopulateTicketsList();
                    PopulateDashboardMetrics();
                    LoadSelectedManifest();
                    MessageBox.Show(msg, "Cancellation Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(msg, "Cannot Cancel", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        #endregion

        #region 6. Passenger Manifest Logic

        private void PopulateManifestRoutes()
        {
            cmbManifestRoute.Items.Clear();
            var routes = RouteStore.GetAll().Where(r => r.Status == "Active").ToList();
            foreach (var r in routes)
            {
                cmbManifestRoute.Items.Add($"{r.RouteId}: {r.RouteName} ({r.Source} ➔ {r.Destination})");
            }
            if (cmbManifestRoute.Items.Count > 0) cmbManifestRoute.SelectedIndex = 0;
            dtpManifestDate.Value = DateTime.Today;
        }

        private void SetupManifestEvents()
        {
            btnLoadManifest.Click += (s, e) => LoadSelectedManifest();
            cmbManifestRoute.SelectedIndexChanged += (s, e) => LoadSelectedManifest();
            dtpManifestDate.ValueChanged += (s, e) => LoadSelectedManifest();

            btnManifestMarkBoarded.Click += (s, e) => ManifestMarkSelectedBoarded();
            btnManifestMarkAbsent.Click += (s, e) => ManifestMarkSelectedAbsent();
            btnPrintManifest.Click += (s, e) => PrintFullTripManifest();
            btnVerifyManifestPassenger.Click += (s, e) => VerifyManifestPassenger();
        }

        private void LoadSelectedManifest()
        {
            if (cmbManifestRoute.SelectedItem == null) return;
            string selected = cmbManifestRoute.SelectedItem.ToString() ?? "";
            string routeId = selected.Split(':')[0].Trim();
            DateTime targetDate = dtpManifestDate.Value.Date;

            var all = TicketStore.GetAll();
            var manifestTickets = all.Where(t =>
                t.RouteId.Equals(routeId, StringComparison.OrdinalIgnoreCase) &&
                t.TravelDate.Date == targetDate &&
                t.Status != "Cancelled"
            ).OrderBy(t => t.SeatNumber).ToList();

            int total = manifestTickets.Count;
            int boarded = manifestTickets.Count(t => t.Status == "Boarded");
            int pending = manifestTickets.Count(t => t.Status == "Valid");
            int absent = manifestTickets.Count(t => t.Status == "Absent" || t.Status == "No-Show");

            lblManifestTotalVal.Text = total.ToString();
            lblManifestBoardedVal.Text = boarded.ToString();
            lblManifestPendingVal.Text = pending.ToString();
            lblManifestNoShowVal.Text = absent.ToString();

            lvManifest.BeginUpdate();
            lvManifest.Items.Clear();

            foreach (var t in manifestTickets)
            {
                var item = new ListViewItem(t.SeatDisplay);
                item.SubItems.Add(t.PassengerName);
                item.SubItems.Add(t.PassengerPhone);
                item.SubItems.Add(t.TicketId);
                item.SubItems.Add(t.BookingId);
                item.SubItems.Add(t.GateNumber);
                item.SubItems.Add(t.Status);
                item.SubItems.Add(t.BoardedTime.HasValue ? t.BoardedTime.Value.ToString("HH:mm:ss") : "Pending");
                item.SubItems.Add(string.IsNullOrWhiteSpace(t.VerifiedBy) ? "—" : t.VerifiedBy);

                if (t.Status == "Boarded")
                    item.ForeColor = Color.FromArgb(16, 185, 129);
                else if (t.Status == "Absent" || t.Status == "No-Show")
                    item.ForeColor = Color.FromArgb(239, 68, 68);
                else
                    item.ForeColor = Color.FromArgb(15, 23, 42);

                item.Tag = t;
                lvManifest.Items.Add(item);
            }

            lvManifest.EndUpdate();
            lblManifestCount.Text = $"Trip Manifest: {manifestTickets.Count} passengers";
        }

        private Ticket? GetSelectedManifestTicket()
        {
            if (lvManifest.SelectedItems.Count > 0 && lvManifest.SelectedItems[0].Tag is Ticket t)
                return t;
            return null;
        }

        private void ManifestMarkSelectedBoarded()
        {
            var t = GetSelectedManifestTicket();
            if (t == null)
            {
                MessageBox.Show("Please select a passenger from the manifest table to check-in.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool success = TicketStore.VerifyAndBoard(t.TicketId, _officerName, out string msg, out Ticket? updated);
            if (success)
            {
                LoadSelectedManifest();
                PopulateDashboardMetrics();
                PopulateTicketsList();
                MessageBox.Show($"Passenger '{t.PassengerName}' marked as BOARDED.", "Check-In Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(msg, "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManifestMarkSelectedAbsent()
        {
            var t = GetSelectedManifestTicket();
            if (t == null)
            {
                MessageBox.Show("Please select a passenger from the manifest table.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (t.Status == "Boarded")
            {
                MessageBox.Show("Cannot mark a passenger who has already boarded as absent.", "Already Boarded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            t.Status = "No-Show";
            t.VerifiedBy = _officerName;
            LoadSelectedManifest();
            PopulateTicketsList();
            MessageBox.Show($"Passenger '{t.PassengerName}' ({t.SeatDisplay}) recorded as ABSENT / NO-SHOW.", "Marked as No-Show", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void VerifyManifestPassenger()
        {
            var t = GetSelectedManifestTicket();
            if (t == null)
            {
                MessageBox.Show("Please select a passenger from the manifest table to verify identity.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string verInfo =
                "============================================================\n" +
                "         PASSENGER IDENTITY & MANIFEST CLEARANCE           \n" +
                "============================================================\n\n" +
                $"• PASSENGER NAME:       {t.PassengerName}\n" +
                $"• CONTACT PHONE:        {t.PassengerPhone}\n" +
                $"• ASSIGNED SEAT:        {t.SeatDisplay}\n" +
                $"• TICKET NUMBER:        {t.TicketId}\n" +
                $"• BOOKING REFERENCE:    {t.BookingId}\n" +
                $"• SECURITY VERIFICATION:{t.SecurityVerificationCode}\n" +
                $"• BOARDING STATUS:      {t.Status.ToUpper()}\n" +
                $"• GATE ALLOCATION:      {t.GateNumber}\n" +
                $"• COACH ASSIGNED:       {t.AssignedBusPlate}\n\n" +
                "INSTRUCTIONS FOR GATE AGENT:\n" +
                "Please verify the passenger's National ID or Kebele Identification matches the name registered above before permitting boarding.";

            MessageBox.Show(verInfo, "Identity Verification Check", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PrintFullTripManifest()
        {
            if (cmbManifestRoute.SelectedItem == null) return;
            string selected = cmbManifestRoute.SelectedItem.ToString() ?? "";
            string routeId = selected.Split(':')[0].Trim();
            DateTime targetDate = dtpManifestDate.Value.Date;

            var manifestTickets = TicketStore.GetAll().Where(t =>
                t.RouteId.Equals(routeId, StringComparison.OrdinalIgnoreCase) &&
                t.TravelDate.Date == targetDate &&
                t.Status != "Cancelled"
            ).OrderBy(t => t.SeatNumber).ToList();

            int total = manifestTickets.Count;
            int boarded = manifestTickets.Count(t => t.Status == "Boarded");
            int pending = manifestTickets.Count(t => t.Status == "Valid");
            int noShow = manifestTickets.Count(t => t.Status == "No-Show" || t.Status == "Absent");

            string manifestHeader =
                "========================================================================================\n" +
                "                    ETHIOPIAN BUS TRANSPORT SYSTEM - TRIP MANIFEST                      \n" +
                "========================================================================================\n" +
                $" ROUTE:           {selected}\n" +
                $" TRAVEL DATE:     {targetDate:dddd, MMMM dd, yyyy}\n" +
                $" SUMMARY:         TOTAL BOOKED: {total}  |  BOARDED: {boarded}  |  PENDING: {pending}  |  NO-SHOW: {noShow}\n" +
                $" GENERATED BY:    {_officerName} on {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n" +
                "----------------------------------------------------------------------------------------\n" +
                string.Format("{0,-7} {1,-22} {2,-15} {3,-10} {4,-10} {5,-12}\n", "SEAT", "PASSENGER NAME", "PHONE", "TICKET #", "GATE", "STATUS") +
                "----------------------------------------------------------------------------------------\n";

            string manifestBody = "";
            foreach (var t in manifestTickets)
            {
                manifestBody += string.Format("{0,-7} {1,-22} {2,-15} {3,-10} {4,-10} {5,-12}\n",
                    t.SeatDisplay,
                    t.PassengerName.Length > 20 ? t.PassengerName.Substring(0, 20) : t.PassengerName,
                    t.PassengerPhone,
                    t.TicketId,
                    t.GateNumber,
                    t.Status);
            }

            if (manifestTickets.Count == 0)
            {
                manifestBody = " (No passengers booked on this coach for the selected date)\n";
            }

            manifestBody +=
                "========================================================================================\n" +
                " DISPATCH CLEARANCE:\n" +
                " Driver Signature: __________________________   Terminal Officer: __________________________\n" +
                "========================================================================================";

            MessageBox.Show(manifestHeader + manifestBody, "Official Trip Manifest", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region 7. Counter Payments & Cashier Logic

        private void SetupPaymentEvents()
        {
            btnPrintReceipt.Click += (s, e) => PrintSelectedReceipt();
            btnRecordPayment.Click += (s, e) => RecordCounterPaymentAction();
            btnProcessRefund.Click += (s, e) => ProcessSelectedRefund();
            btnRefreshPayments.Click += (s, e) => PopulatePaymentsList();

            txtSearchPayments.TextChanged += (s, e) => PopulatePaymentsList();
            cmbPaymentMethodFilter.SelectedIndexChanged += (s, e) => PopulatePaymentsList();
            cmbPaymentStatusFilter.SelectedIndexChanged += (s, e) => PopulatePaymentsList();

            cmbPaymentMethodFilter.SelectedIndex = 0;
            cmbPaymentStatusFilter.SelectedIndex = 0;
        }

        private void PopulatePaymentsList()
        {
            decimal total = PaymentStore.GetTotalCollectionsToday();
            decimal cash = PaymentStore.GetCashTotalToday();
            decimal digital = PaymentStore.GetDigitalTotalToday();
            decimal refunds = PaymentStore.GetRefundsTotalToday();

            lblPayTotalVal.Text = $"{total:N0} ETB";
            lblPayCashVal.Text = $"{cash:N0} ETB";
            lblPayDigitalVal.Text = $"{digital:N0} ETB";
            lblPayRefundsVal.Text = $"{refunds:N0} ETB";

            string search = txtSearchPayments.Text.Trim().ToLower();
            string method = cmbPaymentMethodFilter.SelectedItem?.ToString() ?? "All Methods";
            string status = cmbPaymentStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var all = PaymentStore.GetAll();
            var filtered = all.Where(p =>
            {
                bool match = string.IsNullOrEmpty(search) ||
                    p.ReceiptNumber.ToLower().Contains(search) ||
                    p.BookingId.ToLower().Contains(search) ||
                    p.TicketId.ToLower().Contains(search) ||
                    p.PassengerName.ToLower().Contains(search) ||
                    p.RouteName.ToLower().Contains(search);

                if (!match) return false;
                if (method != "All Methods" && !p.PaymentMethod.Equals(method, StringComparison.OrdinalIgnoreCase)) return false;
                if (status != "All Statuses" && !p.PaymentStatus.Equals(status, StringComparison.OrdinalIgnoreCase)) return false;

                return true;
            }).OrderByDescending(p => p.TransactionDate).ToList();

            lvPayments.BeginUpdate();
            lvPayments.Items.Clear();

            foreach (var p in filtered)
            {
                var item = new ListViewItem(p.ReceiptNumber);
                item.SubItems.Add(p.BookingId);
                item.SubItems.Add(p.TicketId);
                item.SubItems.Add(p.PassengerName);
                item.SubItems.Add(p.RouteName);
                item.SubItems.Add(p.Amount.ToString("N0"));
                item.SubItems.Add(p.PaymentMethod);
                item.SubItems.Add(p.PaymentStatus);
                item.SubItems.Add(p.TransactionDate.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(p.CashierName);

                if (p.PaymentStatus == "Paid")
                    item.ForeColor = Color.FromArgb(16, 185, 129);
                else if (p.PaymentStatus == "Refunded")
                    item.ForeColor = Color.FromArgb(239, 68, 68);
                else
                    item.ForeColor = Color.FromArgb(234, 88, 12);

                item.Tag = p;
                lvPayments.Items.Add(item);
            }

            lvPayments.EndUpdate();
            lblPaymentCount.Text = $"Showing {filtered.Count} of {all.Count} transactions";
        }

        private PaymentRecord? GetSelectedPayment()
        {
            if (lvPayments.SelectedItems.Count > 0 && lvPayments.SelectedItems[0].Tag is PaymentRecord p)
                return p;
            return null;
        }

        private void PrintSelectedReceipt()
        {
            var p = GetSelectedPayment();
            if (p == null)
            {
                MessageBox.Show("Please select a transaction to print receipt.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string receipt =
                "============================================================\n" +
                "       ETHIOPIAN BUS TRANSPORT - OFFICIAL PAYMENT RECEIPT   \n" +
                "============================================================\n\n" +
                $" OFFICIAL RECEIPT #:   {p.ReceiptNumber}\n" +
                $" BOOKING REFERENCE:    {p.BookingId}\n" +
                $" TICKET NUMBER:        {p.TicketId}\n" +
                $" PASSENGER NAME:       {p.PassengerName.ToUpper()}\n" +
                "------------------------------------------------------------\n" +
                $" TRAVEL ROUTE:         {p.RouteName}\n" +
                $" PAYMENT METHOD:       {p.PaymentMethod.ToUpper()}\n" +
                $" TRANSACTION STATUS:   {p.PaymentStatus.ToUpper()}\n" +
                $" TOTAL AMOUNT (ETB):   {p.Amount:N2} ETB\n" +
                $" (VAT INCLUSIVE 15%):  {(p.Amount * 0.15m / 1.15m):N2} ETB\n" +
                "------------------------------------------------------------\n" +
                $" CASHIER / AGENT:      {p.CashierName}\n" +
                $" TRANSACTION DATE:     {p.TransactionDate:yyyy-MM-dd HH:mm:ss}\n" +
                $" AUDIT NOTES:          {(string.IsNullOrWhiteSpace(p.Notes) ? "None" : p.Notes)}\n" +
                "============================================================\n" +
                " Thank you for choosing Ethiopian Intercity Bus Service!\n" +
                "============================================================";

            MessageBox.Show(receipt, $"Receipt - {p.ReceiptNumber}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RecordCounterPaymentAction()
        {
            var p = GetSelectedPayment();
            if (p != null && p.PaymentStatus == "Pending")
            {
                p.PaymentStatus = "Paid";
                p.TransactionDate = DateTime.Now;
                p.CashierName = _officerName;
                p.Notes = "Cleared and collected in cash at Terminal Desk 01.";
                PopulatePaymentsList();
                PopulateDashboardMetrics();
                MessageBox.Show($"Payment for receipt '{p.ReceiptNumber}' marked as PAID in cash.", "Payment Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a 'Pending' payment from the table to record cashier payment clearance.", "Cash Clearance", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ProcessSelectedRefund()
        {
            var p = GetSelectedPayment();
            if (p == null)
            {
                MessageBox.Show("Please select a transaction to process refund.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (p.PaymentStatus == "Refunded")
            {
                MessageBox.Show("This transaction is already marked as refunded.", "Already Refunded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to process a refund of {p.Amount:N0} ETB for receipt '{p.ReceiptNumber}' ({p.PassengerName})?\n\n" +
                $"Authorized refund per ticket cancellation policy.",
                "Confirm Cash Refund",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                p.PaymentStatus = "Refunded";
                p.Notes += $" | Refund of {p.Amount:N0} ETB processed by {_officerName} on {DateTime.Now:yyyy-MM-dd HH:mm}.";
                PopulatePaymentsList();
                PopulateDashboardMetrics();
                MessageBox.Show($"Refund for {p.PassengerName} ({p.Amount:N0} ETB) completed successfully.", "Refund Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region 8. Customer Helpdesk & Inquiries Logic

        private void SetupFeedbackEvents()
        {
            btnNewInquiry.Click += (s, e) => LogNewInquiryDialog();
            btnResolveInquiry.Click += (s, e) => ResolveSelectedInquiry();
            btnViewInquiryDetails.Click += (s, e) => ViewSelectedInquiryDetails();
            lvInquiries.DoubleClick += (s, e) => ViewSelectedInquiryDetails();

            btnRefreshInquiries.Click += (s, e) => PopulateInquiriesList();
            txtSearchInquiries.TextChanged += (s, e) => PopulateInquiriesList();
            cmbInquiryStatusFilter.SelectedIndexChanged += (s, e) => PopulateInquiriesList();

            cmbInquiryStatusFilter.SelectedIndex = 0;
        }

        private void PopulateInquiriesList()
        {
            int total = CustomerHelpdeskStore.GetTotalCount();
            int pending = CustomerHelpdeskStore.GetPendingCount();
            int resolved = CustomerHelpdeskStore.GetResolvedCount();

            lblInqTotalVal.Text = total.ToString();
            lblInqPendingVal.Text = pending.ToString();
            lblInqResolvedVal.Text = resolved.ToString();

            string search = txtSearchInquiries.Text.Trim().ToLower();
            string status = cmbInquiryStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var all = CustomerHelpdeskStore.GetAll();
            var filtered = all.Where(i =>
            {
                bool match = string.IsNullOrEmpty(search) ||
                    i.InquiryId.ToLower().Contains(search) ||
                    i.PassengerName.ToLower().Contains(search) ||
                    i.ContactPhone.ToLower().Contains(search) ||
                    i.Category.ToLower().Contains(search) ||
                    i.Subject.ToLower().Contains(search);

                if (!match) return false;
                if (status != "All Statuses" && !i.Status.Equals(status, StringComparison.OrdinalIgnoreCase)) return false;

                return true;
            }).OrderByDescending(i => i.RecordedDate).ToList();

            lvInquiries.BeginUpdate();
            lvInquiries.Items.Clear();

            foreach (var inq in filtered)
            {
                var item = new ListViewItem(inq.InquiryId);
                item.SubItems.Add(inq.PassengerName);
                item.SubItems.Add(inq.ContactPhone);
                item.SubItems.Add(inq.Category);
                item.SubItems.Add(inq.Subject);
                item.SubItems.Add(inq.Status);
                item.SubItems.Add(inq.RecordedDate.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(inq.AttendedBy);

                if (inq.Status == "Resolved")
                    item.ForeColor = Color.FromArgb(16, 185, 129);
                else
                    item.ForeColor = Color.FromArgb(234, 88, 12);

                item.Tag = inq;
                lvInquiries.Items.Add(item);
            }

            lvInquiries.EndUpdate();
            lblInquiryCount.Text = $"Showing {filtered.Count} of {all.Count} inquiries";
        }

        private CustomerInquiry? GetSelectedInquiry()
        {
            if (lvInquiries.SelectedItems.Count > 0 && lvInquiries.SelectedItems[0].Tag is CustomerInquiry inq)
                return inq;
            return null;
        }

        private void ViewSelectedInquiryDetails()
        {
            var inq = GetSelectedInquiry();
            if (inq == null)
            {
                MessageBox.Show("Please select an inquiry from the table to view details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string details =
                "============================================================\n" +
                "       CUSTOMER INQUIRY & SERVICE DOSSIER                   \n" +
                "============================================================\n\n" +
                $"• INQUIRY ID:      {inq.InquiryId}\n" +
                $"• PASSENGER NAME:  {inq.PassengerName}\n" +
                $"• CONTACT PHONE:   {inq.ContactPhone}\n" +
                $"• CATEGORY:        {inq.Category}\n" +
                $"• SUBJECT:         {inq.Subject}\n" +
                $"• STATUS:          {inq.Status.ToUpper()}\n" +
                $"• RECORDED DATE:   {inq.RecordedDate:yyyy-MM-dd HH:mm}\n" +
                $"• ATTENDED BY:     {inq.AttendedBy}\n\n" +
                $"--- INQUIRY DETAILS / CUSTOMER REQUEST ---\n" +
                $"{inq.Details}\n\n" +
                $"--- RESOLUTION NOTES ---\n" +
                $"{(string.IsNullOrWhiteSpace(inq.ResolutionNotes) ? "(Awaiting resolution)" : inq.ResolutionNotes)}";

            MessageBox.Show(details, $"Helpdesk Inquiry - {inq.InquiryId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ResolveSelectedInquiry()
        {
            var inq = GetSelectedInquiry();
            if (inq == null)
            {
                MessageBox.Show("Please select an inquiry to mark as resolved.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (inq.Status == "Resolved")
            {
                MessageBox.Show("This inquiry has already been resolved.", "Already Resolved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            inq.Status = "Resolved";
            inq.ResolutionNotes = $"Resolved by {_officerName} at Terminal Desk 01 on {DateTime.Now:yyyy-MM-dd HH:mm}. Passenger satisfied with assistance.";
            PopulateInquiriesList();
            MessageBox.Show($"Inquiry '{inq.InquiryId}' has been marked as RESOLVED.", "Inquiry Resolved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LogNewInquiryDialog()
        {
            // Simple prompt dialog
            using (Form prompt = new Form())
            {
                prompt.Width = 460;
                prompt.Height = 380;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.Text = "Log New Customer Inquiry / Request";
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;

                Label lblName = new Label() { Left = 20, Top = 20, Text = "Passenger Name:", Width = 130 };
                TextBox txtName = new TextBox() { Left = 160, Top = 18, Width = 260 };

                Label lblPhone = new Label() { Left = 20, Top = 60, Text = "Phone Number:", Width = 130 };
                TextBox txtPhone = new TextBox() { Left = 160, Top = 58, Width = 260 };

                Label lblCat = new Label() { Left = 20, Top = 100, Text = "Category:", Width = 130 };
                ComboBox cmbCat = new ComboBox() { Left = 160, Top = 98, Width = 260, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbCat.Items.AddRange(new object[] { "Schedule Inquiry", "Ticket Change", "Special Assistance", "Lost Property", "Complaint" });
                cmbCat.SelectedIndex = 0;

                Label lblSubj = new Label() { Left = 20, Top = 140, Text = "Subject:", Width = 130 };
                TextBox txtSubj = new TextBox() { Left = 160, Top = 138, Width = 260 };

                Label lblDet = new Label() { Left = 20, Top = 180, Text = "Details / Request:", Width = 130 };
                TextBox txtDet = new TextBox() { Left = 160, Top = 178, Width = 260, Multiline = true, Height = 70 };

                Button btnSave = new Button() { Text = "Save Inquiry", Left = 160, Width = 120, Top = 270, DialogResult = DialogResult.OK, BackColor = Color.FromArgb(13, 94, 234), ForeColor = Color.White, FlatStyle = FlatStyle.Flat };
                Button btnCancel = new Button() { Text = "Cancel", Left = 290, Width = 100, Top = 270, DialogResult = DialogResult.Cancel, BackColor = Color.White, FlatStyle = FlatStyle.Flat };

                prompt.Controls.Add(lblName); prompt.Controls.Add(txtName);
                prompt.Controls.Add(lblPhone); prompt.Controls.Add(txtPhone);
                prompt.Controls.Add(lblCat); prompt.Controls.Add(cmbCat);
                prompt.Controls.Add(lblSubj); prompt.Controls.Add(txtSubj);
                prompt.Controls.Add(lblDet); prompt.Controls.Add(txtDet);
                prompt.Controls.Add(btnSave); prompt.Controls.Add(btnCancel);
                prompt.AcceptButton = btnSave;
                prompt.CancelButton = btnCancel;

                if (prompt.ShowDialog(this) == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSubj.Text))
                    {
                        MessageBox.Show("Passenger name and subject are required.", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var inq = new CustomerInquiry(
                        CustomerHelpdeskStore.GenerateNextId(),
                        txtName.Text.Trim(),
                        txtPhone.Text.Trim(),
                        cmbCat.SelectedItem?.ToString() ?? "Schedule Inquiry",
                        txtSubj.Text.Trim(),
                        txtDet.Text.Trim(),
                        "Pending",
                        DateTime.Now,
                        _officerName,
                        ""
                    );
                    CustomerHelpdeskStore.Add(inq);
                    PopulateInquiriesList();
                    MessageBox.Show($"Customer inquiry '{inq.InquiryId}' recorded successfully.", "Inquiry Logged", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Crisp 1px border around the entire frameless window
            using (Pen borderPen = new Pen(Color.FromArgb(203, 213, 225), 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

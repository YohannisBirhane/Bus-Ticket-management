using System;
using System.Drawing;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class TicketVerifyDialogForm : Form
    {
        private Ticket? _currentTicket = null;

        public TicketVerifyDialogForm(string? initialLookup = null)
        {
            InitializeComponent();

            panelTitleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            btnClose.Click += (s, e) => this.Close();

            btnSearch.Click += (s, e) => PerformLookup();
            txtSearchTicket.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;
                    PerformLookup();
                }
            };

            btnConfirmBoard.Click += (s, e) => ConfirmBoarding();
            btnPrintPass.Click += (s, e) => PrintBoardingPass();

            if (!string.IsNullOrWhiteSpace(initialLookup))
            {
                txtSearchTicket.Text = initialLookup.Trim();
                PerformLookup();
            }
        }

        private void PerformLookup()
        {
            string query = txtSearchTicket.Text.Trim();
            if (string.IsNullOrWhiteSpace(query))
            {
                SetBannerState("empty", "Please enter a Ticket ID or Booking Reference.", "Scan a barcode or type reference (e.g. TK1001, BK0001)");
                ResetDetailsDisplay();
                return;
            }

            // Find ticket from TicketStore
            var all = TicketStore.GetAll();
            _currentTicket = all.Find(t =>
                t.TicketId.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                t.BookingId.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                t.SecurityVerificationCode.Equals(query, StringComparison.OrdinalIgnoreCase));

            if (_currentTicket == null)
            {
                SetBannerState("notfound", "Ticket Reference Not Found", $"No ticket matching '{query}' exists in the system database.");
                ResetDetailsDisplay();
                return;
            }

            // Populate Details
            lblValTicketNo.Text = _currentTicket.TicketId;
            lblValBookingRef.Text = _currentTicket.BookingId;
            lblValPassenger.Text = _currentTicket.PassengerName;
            lblValPhone.Text = _currentTicket.PassengerPhone;
            lblValRoute.Text = $"{_currentTicket.FullRouteDisplay} ({_currentTicket.RouteName})";
            lblValSchedule.Text = $"{_currentTicket.TravelDate:dddd, yyyy-MM-dd} at {_currentTicket.DepartureTime}";
            lblValBus.Text = $"{_currentTicket.AssignedBusPlate} - {_currentTicket.BusModel}";
            lblValSeat.Text = _currentTicket.SeatDisplay;
            lblValGate.Text = _currentTicket.GateNumber;
            lblValSecurityCode.Text = _currentTicket.SecurityVerificationCode;

            btnPrintPass.Enabled = (_currentTicket.Status != "Cancelled");

            // Check Status
            if (_currentTicket.Status == "Valid")
            {
                SetBannerState("valid", "PASSENGER AUTHORIZED TO BOARD",
                    $"Scheduled for departure today on {_currentTicket.AssignedBusPlate}. Please confirm Kebele ID.");
                btnConfirmBoard.Enabled = true;
            }
            else if (_currentTicket.Status == "Boarded")
            {
                string boardedInfo = _currentTicket.BoardedTime.HasValue
                    ? $"{_currentTicket.BoardedTime.Value:yyyy-MM-dd HH:mm}"
                    : "Today";
                string agent = string.IsNullOrWhiteSpace(_currentTicket.VerifiedBy) ? "Gate Staff" : _currentTicket.VerifiedBy;
                SetBannerState("boarded", "ALREADY CHECKED-IN & BOARDED",
                    $"This ticket was validated on {boardedInfo} by {agent}. Do not allow duplicate boarding!");
                btnConfirmBoard.Enabled = false;
            }
            else if (_currentTicket.Status == "Cancelled")
            {
                SetBannerState("cancelled", "CANCELLED / VOID TICKET",
                    "This ticket or parent reservation was cancelled. Passenger has been refunded and cannot travel.");
                btnConfirmBoard.Enabled = false;
            }
        }

        private void SetBannerState(string type, string heading, string subheading)
        {
            lblStatusHeading.Text = heading;
            lblStatusSubheading.Text = subheading;

            switch (type)
            {
                case "valid":
                    panelStatusBanner.BackColor = Color.FromArgb(220, 252, 231); // Green-100
                    lblStatusIcon.Text = "✅";
                    lblStatusHeading.ForeColor = Color.FromArgb(22, 101, 52); // Green-800
                    lblStatusSubheading.ForeColor = Color.FromArgb(21, 128, 61); // Green-700
                    break;
                case "boarded":
                    panelStatusBanner.BackColor = Color.FromArgb(254, 243, 199); // Amber-100
                    lblStatusIcon.Text = "⚠️";
                    lblStatusHeading.ForeColor = Color.FromArgb(146, 64, 14); // Amber-800
                    lblStatusSubheading.ForeColor = Color.FromArgb(180, 83, 9); // Amber-700
                    break;
                case "cancelled":
                    panelStatusBanner.BackColor = Color.FromArgb(254, 226, 226); // Red-100
                    lblStatusIcon.Text = "❌";
                    lblStatusHeading.ForeColor = Color.FromArgb(153, 27, 27); // Red-800
                    lblStatusSubheading.ForeColor = Color.FromArgb(185, 28, 28); // Red-700
                    break;
                default:
                    panelStatusBanner.BackColor = Color.FromArgb(241, 245, 249); // Slate-100
                    lblStatusIcon.Text = "ℹ️";
                    lblStatusHeading.ForeColor = Color.FromArgb(30, 41, 59);
                    lblStatusSubheading.ForeColor = Color.FromArgb(100, 116, 139);
                    break;
            }
        }

        private void ResetDetailsDisplay()
        {
            lblValTicketNo.Text = "---";
            lblValBookingRef.Text = "---";
            lblValPassenger.Text = "---";
            lblValPhone.Text = "---";
            lblValRoute.Text = "---";
            lblValSchedule.Text = "---";
            lblValBus.Text = "---";
            lblValSeat.Text = "---";
            lblValGate.Text = "---";
            lblValSecurityCode.Text = "---";
            btnConfirmBoard.Enabled = false;
            btnPrintPass.Enabled = false;
        }

        private void ConfirmBoarding()
        {
            if (_currentTicket == null) return;

            bool success = TicketStore.VerifyAndBoard(_currentTicket.TicketId, "Gate Officer / Admin", out string message, out var updatedTicket);
            if (success)
            {
                MessageBox.Show(
                    $"PASSENGER BOARDING VERIFIED!\n\n" +
                    $"• Ticket:    {_currentTicket.TicketId}\n" +
                    $"• Passenger: {_currentTicket.PassengerName}\n" +
                    $"• Route:     {_currentTicket.FullRouteDisplay}\n" +
                    $"• Coach:     {_currentTicket.AssignedBusPlate}\n" +
                    $"• Seat:      {_currentTicket.SeatDisplay}\n" +
                    $"• Boarded:   {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n" +
                    $"Passenger is cleared to enter gate {_currentTicket.GateNumber}.",
                    "Boarding Verified",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                this.DialogResult = DialogResult.OK;
                PerformLookup(); // Refresh UI state
            }
            else
            {
                MessageBox.Show(message, "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintBoardingPass()
        {
            if (_currentTicket == null) return;

            string pass =
                "============================================================\n" +
                "       ETHIOPIAN INTERCITY TRANSPORT - BOARDING PASS        \n" +
                "============================================================\n\n" +
                $" BOARDING PASS NO:     {_currentTicket.TicketId}\n" +
                $" BOOKING REFERENCE:    {_currentTicket.BookingId}\n" +
                $" SECURITY BARCODE:     {_currentTicket.SecurityVerificationCode}\n" +
                "------------------------------------------------------------\n" +
                $" PASSENGER NAME:       {_currentTicket.PassengerName.ToUpper()}\n" +
                $" CONTACT PHONE:        {_currentTicket.PassengerPhone}\n" +
                $" JOURNEY:              {_currentTicket.Source} ➔ {_currentTicket.Destination}\n" +
                $" SERVICE ROUTE:        {_currentTicket.RouteName}\n" +
                $" DEPARTURE DATE:       {_currentTicket.TravelDate:dddd, MMMM dd, yyyy}\n" +
                $" SCHEDULED TIME:       {_currentTicket.DepartureTime}\n" +
                $" DEPARTURE GATE:       {_currentTicket.GateNumber}\n" +
                $" COACH ASSIGNED:       {_currentTicket.AssignedBusPlate} ({_currentTicket.BusModel})\n" +
                $" ALLOCATED SEAT:       {_currentTicket.SeatDisplay}\n" +
                "------------------------------------------------------------\n" +
                $" TOTAL FARE PAID:      {_currentTicket.FareAmount:N0} ETB\n" +
                $" LUGGAGE ALLOWANCE:    {_currentTicket.LuggageAllowance}\n" +
                $" TICKET STATUS:        {_currentTicket.Status.ToUpper()}\n" +
                $" ISSUED TIMESTAMP:     {_currentTicket.IssuedDate:yyyy-MM-dd HH:mm}\n" +
                "============================================================\n" +
                " SECURITY NOTICE & PASSENGER OBLIGATIONS:\n" +
                " 1. Please be present at the gate 30 minutes prior to departure.\n" +
                " 2. Official Ethiopian ID (Kebele ID / Passport) is strictly required.\n" +
                " 3. Tickets are non-transferable once verified at the boarding gate.\n" +
                "============================================================";

            MessageBox.Show(pass, $"Boarding Pass - {_currentTicket.TicketId} ({_currentTicket.PassengerName})", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

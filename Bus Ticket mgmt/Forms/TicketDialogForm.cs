using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class TicketDialogForm : Form
    {
        private readonly bool _isEditMode = false;
        private readonly Ticket? _editingTicket = null;

        public TicketDialogForm()
        {
            InitializeComponent();
            _isEditMode = false;
            txtTicketId.Text = TicketStore.GenerateNextId();

            InitializeCommonControls();
            LoadBookingsDropdown();
            cmbStatus.SelectedItem = "Valid";
            cmbGateNumber.SelectedIndex = 0;
        }

        public TicketDialogForm(Ticket ticket)
        {
            InitializeComponent();
            _isEditMode = true;
            _editingTicket = ticket;

            InitializeCommonControls();
            LoadBookingsDropdown();

            // Set dialog texts for edit mode
            lblDialogTitle.Text = $"✏️ Edit Ticket - {ticket.TicketId}";
            lblHeaderTitle.Text = $"Modify Ticket [{ticket.TicketId}]";
            btnSave.Text = "Save Changes";

            // Fill values
            txtTicketId.Text = ticket.TicketId;
            txtPassengerName.Text = ticket.PassengerName;
            txtPassengerPhone.Text = ticket.PassengerPhone;
            txtPassengerEmail.Text = ticket.PassengerEmail;
            dtpTravelDate.Value = ticket.TravelDate;
            cmbDepartureTime.SelectedItem = ticket.DepartureTime;
            cmbGateNumber.SelectedItem = ticket.GateNumber;
            numSeatNumber.Value = Math.Max(numSeatNumber.Minimum, Math.Min(numSeatNumber.Maximum, ticket.SeatNumber));
            numFareAmount.Value = Math.Max(numFareAmount.Minimum, Math.Min(numFareAmount.Maximum, ticket.FareAmount));
            cmbStatus.SelectedItem = ticket.Status;
            txtLuggage.Text = ticket.LuggageAllowance;
            txtNotes.Text = ticket.Notes;

            // Route selection
            for (int i = 0; i < cmbRoute.Items.Count; i++)
            {
                string? itemStr = cmbRoute.Items[i]?.ToString();
                if (itemStr != null && itemStr.StartsWith(ticket.RouteId))
                {
                    cmbRoute.SelectedIndex = i;
                    break;
                }
            }

            // Bus selection
            for (int i = 0; i < cmbAssignedBus.Items.Count; i++)
            {
                string? busStr = cmbAssignedBus.Items[i]?.ToString();
                if (busStr != null && busStr.Contains(ticket.AssignedBusPlate))
                {
                    cmbAssignedBus.SelectedIndex = i;
                    break;
                }
            }
        }

        private void InitializeCommonControls()
        {
            panelTitleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            btnClose.Click += (s, e) => this.Close();
            btnSave.Click += (s, e) => SaveTicket();

            // Populate Routes
            cmbRoute.Items.Clear();
            var routes = RouteStore.GetAll().Where(r => r.Status == "Active").ToList();
            foreach (var r in routes)
            {
                cmbRoute.Items.Add($"{r.RouteId}: {r.RouteName} ({r.Source} ➔ {r.Destination})");
            }
            if (cmbRoute.Items.Count > 0) cmbRoute.SelectedIndex = 0;

            // Populate Buses
            cmbAssignedBus.Items.Clear();
            var buses = BusStore.GetAll().Where(b => b.Status != "Decommissioned").ToList();
            foreach (var b in buses)
            {
                cmbAssignedBus.Items.Add($"{b.PlateNumber} - {b.Model} ({b.Capacity} seats)");
            }
            if (cmbAssignedBus.Items.Count > 0) cmbAssignedBus.SelectedIndex = 0;

            if (cmbDepartureTime.SelectedIndex < 0) cmbDepartureTime.SelectedIndex = 0;
            if (cmbGateNumber.SelectedIndex < 0) cmbGateNumber.SelectedIndex = 0;
        }

        private void LoadBookingsDropdown()
        {
            cmbBookingSelect.Items.Clear();
            cmbBookingSelect.Items.Add("-- Manual Issuance / Direct Walk-In Passenger --");

            var bookings = BookingStore.GetAll()
                .Where(b => b.BookingStatus != "Cancelled")
                .OrderByDescending(b => b.BookingDate)
                .ToList();

            foreach (var b in bookings)
            {
                cmbBookingSelect.Items.Add($"{b.BookingId} - {b.PassengerName} | {b.Source} ➔ {b.Destination} ({b.SeatNumbersDisplay})");
            }

            cmbBookingSelect.SelectedIndex = 0;

            cmbBookingSelect.SelectedIndexChanged += (s, e) =>
            {
                if (cmbBookingSelect.SelectedIndex > 0)
                {
                    string selectedText = cmbBookingSelect.SelectedItem?.ToString() ?? "";
                    string bookingId = selectedText.Split('-')[0].Trim();
                    var booking = BookingStore.GetById(bookingId);
                    if (booking != null)
                    {
                        txtPassengerName.Text = booking.PassengerName;
                        txtPassengerPhone.Text = booking.PassengerPhone;
                        txtPassengerEmail.Text = booking.PassengerEmail;
                        dtpTravelDate.Value = booking.TravelDate;

                        // Match departure time
                        int timeIdx = cmbDepartureTime.FindString(booking.DepartureTime);
                        if (timeIdx >= 0) cmbDepartureTime.SelectedIndex = timeIdx;

                        // Match route
                        for (int i = 0; i < cmbRoute.Items.Count; i++)
                        {
                            string? routeStr = cmbRoute.Items[i]?.ToString();
                            if (routeStr != null && routeStr.StartsWith(booking.RouteId))
                            {
                                cmbRoute.SelectedIndex = i;
                                break;
                            }
                        }

                        // Match bus
                        for (int i = 0; i < cmbAssignedBus.Items.Count; i++)
                        {
                            string? busPlate = cmbAssignedBus.Items[i]?.ToString()?.Split('-')[0].Trim();
                            if (!string.IsNullOrEmpty(busPlate) && !string.IsNullOrEmpty(booking.AssignedBus) && booking.AssignedBus.Contains(busPlate))
                            {
                                cmbAssignedBus.SelectedIndex = i;
                                break;
                            }
                        }

                        // Set Seat & Fare
                        if (booking.Seats.Count > 0)
                        {
                            numSeatNumber.Value = booking.Seats[0];
                        }
                        numFareAmount.Value = booking.FarePerSeat > 0 ? booking.FarePerSeat : (booking.TotalAmount / Math.Max(1, booking.NumberOfSeats));
                    }
                }
            };
        }

        private void SaveTicket()
        {
            string ticketId = txtTicketId.Text.Trim();
            string passengerName = txtPassengerName.Text.Trim();
            string phone = txtPassengerPhone.Text.Trim();
            string email = txtPassengerEmail.Text.Trim();
            int seatNumber = (int)numSeatNumber.Value;
            decimal fare = numFareAmount.Value;
            DateTime travelDate = dtpTravelDate.Value.Date;
            string departureTime = cmbDepartureTime.SelectedItem?.ToString() ?? "06:00 AM";
            string gateNumber = cmbGateNumber.SelectedItem?.ToString() ?? "Gate 01";
            string status = cmbStatus.SelectedItem?.ToString() ?? "Valid";
            string luggage = string.IsNullOrWhiteSpace(txtLuggage.Text) ? "25 kg" : txtLuggage.Text.Trim();
            string notes = txtNotes.Text.Trim();

            // Linked booking ref
            string bookingId = "DIRECT-WALKIN";
            if (cmbBookingSelect.SelectedIndex > 0)
            {
                bookingId = cmbBookingSelect.SelectedItem?.ToString()?.Split('-')[0].Trim() ?? "DIRECT";
            }
            else if (_isEditMode && _editingTicket != null)
            {
                bookingId = _editingTicket.BookingId;
            }

            // Validations
            if (string.IsNullOrWhiteSpace(passengerName))
            {
                MessageBox.Show("Passenger Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassengerName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Passenger contact phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassengerPhone.Focus();
                return;
            }

            // Route parsing
            string selectedRouteText = cmbRoute.SelectedItem?.ToString() ?? "";
            string routeId = "RT001";
            string routeName = "Standard Route";
            string source = "Addis Ababa";
            string destination = "Regional Destination";

            if (!string.IsNullOrWhiteSpace(selectedRouteText))
            {
                routeId = selectedRouteText.Split(':')[0].Trim();
                var r = RouteStore.GetById(routeId);
                if (r != null)
                {
                    routeName = r.RouteName;
                    source = r.Source;
                    destination = r.Destination;
                }
            }

            // Bus parsing
            string selectedBusText = cmbAssignedBus.SelectedItem?.ToString() ?? "";
            string busPlate = "ET-3-4812";
            string busModel = "Standard Coach";
            if (!string.IsNullOrWhiteSpace(selectedBusText))
            {
                var parts = selectedBusText.Split('-');
                busPlate = parts[0].Trim();
                if (parts.Length > 1)
                {
                    busModel = parts[1].Split('(')[0].Trim();
                }
            }

            // Business rule: Seat collision check
            var existingTickets = TicketStore.GetAll();
            bool seatTaken = existingTickets.Any(t =>
                (!_isEditMode || !t.TicketId.Equals(ticketId, StringComparison.OrdinalIgnoreCase)) &&
                t.Status != "Cancelled" &&
                t.RouteId.Equals(routeId, StringComparison.OrdinalIgnoreCase) &&
                t.TravelDate.Date == travelDate.Date &&
                t.SeatNumber == seatNumber);

            if (seatTaken)
            {
                MessageBox.Show(
                    $"Seat {seatNumber} is ALREADY ISSUED to another passenger for this route on {travelDate:yyyy-MM-dd}.\n\n" +
                    $"Business Rule:\n" +
                    $"Each coach seat can only have one active ticket per journey schedule.",
                    "Seat Collision Conflict",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (_isEditMode && _editingTicket != null)
            {
                _editingTicket.PassengerName = passengerName;
                _editingTicket.PassengerPhone = phone;
                _editingTicket.PassengerEmail = email;
                _editingTicket.RouteId = routeId;
                _editingTicket.RouteName = routeName;
                _editingTicket.Source = source;
                _editingTicket.Destination = destination;
                _editingTicket.TravelDate = travelDate;
                _editingTicket.DepartureTime = departureTime;
                _editingTicket.GateNumber = gateNumber;
                _editingTicket.AssignedBusPlate = busPlate;
                _editingTicket.BusModel = busModel;
                _editingTicket.SeatNumber = seatNumber;
                _editingTicket.FareAmount = fare;
                _editingTicket.Status = status;
                _editingTicket.LuggageAllowance = luggage;
                _editingTicket.Notes = notes;

                TicketStore.Update(_editingTicket);
                MessageBox.Show($"Ticket '{ticketId}' updated successfully.", "Ticket Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var newTicket = new Ticket(
                    ticketId,
                    bookingId,
                    passengerName,
                    phone,
                    email,
                    routeId,
                    routeName,
                    source,
                    destination,
                    travelDate,
                    departureTime,
                    gateNumber,
                    busPlate,
                    busModel,
                    seatNumber,
                    fare,
                    status,
                    "",
                    notes
                )
                {
                    LuggageAllowance = luggage
                };

                TicketStore.Add(newTicket);
                MessageBox.Show(
                    $"Ticket '{ticketId}' has been issued successfully!\n\n" +
                    $"• Passenger:   {passengerName}\n" +
                    $"• Route:       {source} ➔ {destination}\n" +
                    $"• Date & Time: {travelDate:yyyy-MM-dd} at {departureTime}\n" +
                    $"• Seat:        Seat {seatNumber}\n" +
                    $"• Gate:        {gateNumber}\n" +
                    $"• Security ID: {newTicket.SecurityVerificationCode}",
                    "Ticket Issued",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
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

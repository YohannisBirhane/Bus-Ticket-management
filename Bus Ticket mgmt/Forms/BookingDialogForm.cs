using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class BookingDialogForm : Form
    {
        private readonly bool isEditMode = false;
        private readonly Booking? editingBooking = null;
        private bool isInitializing = true;

        public BookingDialogForm()
        {
            InitializeComponent();
            isEditMode = false;
            SetupUI();
            PopulateDropdowns();
            GenerateNewBookingId();
            RefreshSeatAvailability();
            isInitializing = false;
        }

        public BookingDialogForm(Booking bookingToEdit)
        {
            InitializeComponent();
            isEditMode = true;
            editingBooking = bookingToEdit;
            SetupUI();
            PopulateDropdowns();
            LoadBookingData(bookingToEdit);
            RefreshSeatAvailability();
            isInitializing = false;
        }

        private void SetupUI()
        {
            // Title & border styling
            if (isEditMode)
            {
                lblDialogTitle.Text = $"Edit Booking - {editingBooking?.BookingId}";
                lblHeaderTitle.Text = $"Modify Booking ({editingBooking?.BookingId})";
                lblHeaderSubtitle.Text = "Update passenger reservation details, travel date, seat numbers, or status.";
                btnSave.Text = "💾  Update Booking";
            }
            else
            {
                lblDialogTitle.Text = "New Passenger Booking - Reservation Entry";
                lblHeaderTitle.Text = "New Passenger Booking";
                lblHeaderSubtitle.Text = "Enter passenger contact, route, scheduled travel date, and choose available seats.";
                btnSave.Text = "💾  Save Booking";
            }

            dtpTravelDate.MinDate = DateTime.Today;

            // Window drag on title bar
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

            // Window controls
            btnClose.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            btnCancel.Click += (s, e) => this.DialogResult = DialogResult.Cancel;
            btnClear.Click += (s, e) => ClearFields();

            // Save action
            btnSave.Click += (s, e) => SaveBooking();

            // Seat selection changes trigger recalculations
            clbSeats.ItemCheck += (s, e) =>
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    UpdateCalculations();
                });
            };

            // Route change updates fare and seat availability
            cmbRoute.SelectedIndexChanged += (s, e) =>
            {
                if (isInitializing) return;
                OnRouteChanged();
            };

            // Travel date change refreshes seat conflict checks
            dtpTravelDate.ValueChanged += (s, e) =>
            {
                if (isInitializing) return;
                RefreshSeatAvailability();
            };

            // Passenger selection auto-fills phone & email if matched from UserStore
            cmbPassengerName.SelectedIndexChanged += (s, e) =>
            {
                if (cmbPassengerName.SelectedItem is User user)
                {
                    txtPassengerPhone.Text = user.Phone;
                    txtPassengerEmail.Text = user.Email;
                }
            };

            // Fare change triggers total amount recalculation
            numFarePerSeat.ValueChanged += (s, e) => UpdateCalculations();

            // Status defaults
            cmbBookingStatus.SelectedIndex = 0; // Confirmed
            cmbPaymentStatus.SelectedIndex = 0; // Paid
            cmbDepartureTime.SelectedIndex = 0; // 06:00 AM
        }

        private void PopulateDropdowns()
        {
            // 1. Passengers dropdown
            cmbPassengerName.Items.Clear();
            var passengers = UserStore.GetAll().Where(u => u.Role == "Passenger" && u.Status == "Active").ToList();
            foreach (var p in passengers)
            {
                cmbPassengerName.Items.Add(p);
            }
            cmbPassengerName.DisplayMember = "FullName";

            // 2. Routes dropdown
            cmbRoute.Items.Clear();
            var routes = RouteStore.GetAll().Where(r => r.Status == "Active").ToList();
            foreach (var r in routes)
            {
                cmbRoute.Items.Add(r);
            }
            cmbRoute.DisplayMember = "RouteName";

            if (cmbRoute.Items.Count > 0)
            {
                cmbRoute.SelectedIndex = 0;
            }

            // 3. Buses dropdown
            cmbAssignedBus.Items.Clear();
            var buses = BusStore.GetAll().Where(b => b.Status == "Active").ToList();
            foreach (var b in buses)
            {
                cmbAssignedBus.Items.Add($"{b.PlateNumber} - {b.FullModelName} ({b.Capacity} seats)");
            }
            if (cmbAssignedBus.Items.Count > 0)
            {
                cmbAssignedBus.SelectedIndex = 0;
            }
        }

        private void GenerateNewBookingId()
        {
            txtBookingId.Text = BookingStore.GenerateNextId();
        }

        private void OnRouteChanged()
        {
            if (cmbRoute.SelectedItem is Route route)
            {
                numFarePerSeat.Value = route.BaseFare;
            }
            RefreshSeatAvailability();
        }

        private void RefreshSeatAvailability()
        {
            string routeId = "";
            if (cmbRoute.SelectedItem is Route r)
            {
                routeId = r.RouteId;
            }
            else if (editingBooking != null)
            {
                routeId = editingBooking.RouteId;
            }

            DateTime travelDate = dtpTravelDate.Value.Date;
            var bookedSeats = BookingStore.GetBookedSeats(routeId, travelDate, editingBooking?.BookingId);

            // Remember user's currently selected seats
            var previouslyChecked = new HashSet<int>();
            for (int i = 0; i < clbSeats.Items.Count; i++)
            {
                if (clbSeats.GetItemChecked(i))
                {
                    if (int.TryParse(clbSeats.Items[i].ToString()?.Replace("Seat ", "").Split(' ')[0], out int seatNum))
                    {
                        previouslyChecked.Add(seatNum);
                    }
                }
            }

            clbSeats.BeginUpdate();
            clbSeats.Items.Clear();

            // Bus capacity: default 49 seats
            int capacity = 49;
            for (int seat = 1; seat <= capacity; seat++)
            {
                bool isTaken = bookedSeats.Contains(seat);
                string displayText = isTaken ? $"Seat {seat:D2} (Booked)" : $"Seat {seat:D2}";
                int idx = clbSeats.Items.Add(displayText);

                if (isTaken)
                {
                    // Taken by someone else
                    clbSeats.SetItemChecked(idx, false);
                }
                else if (previouslyChecked.Contains(seat) || (editingBooking != null && editingBooking.Seats.Contains(seat)))
                {
                    clbSeats.SetItemChecked(idx, true);
                }
            }
            clbSeats.EndUpdate();

            UpdateCalculations();
        }

        private void UpdateCalculations()
        {
            var selectedSeats = GetSelectedSeatNumbers();
            int count = selectedSeats.Count;
            txtSeatCount.Text = count.ToString();

            decimal total = numFarePerSeat.Value * count;
            txtTotalAmount.Text = $"{total:N2} ETB";

            if (count > 0)
            {
                lblSelectedSeatsPreview.Text = $"Selected ({count}): " + string.Join(", ", selectedSeats.Select(s => $"Seat {s}"));
                lblSelectedSeatsPreview.ForeColor = Color.FromArgb(22, 163, 74);
            }
            else
            {
                lblSelectedSeatsPreview.Text = "Selected Seats: None chosen (please check at least 1 seat)";
                lblSelectedSeatsPreview.ForeColor = Color.FromArgb(220, 38, 38);
            }
        }

        private List<int> GetSelectedSeatNumbers()
        {
            var list = new List<int>();
            for (int i = 0; i < clbSeats.Items.Count; i++)
            {
                if (clbSeats.GetItemChecked(i))
                {
                    string text = clbSeats.Items[i].ToString() ?? "";
                    if (!text.Contains("(Booked)"))
                    {
                        string numPart = text.Replace("Seat ", "").Trim();
                        if (int.TryParse(numPart, out int num))
                        {
                            list.Add(num);
                        }
                    }
                }
            }
            return list.OrderBy(n => n).ToList();
        }

        private void LoadBookingData(Booking b)
        {
            txtBookingId.Text = b.BookingId;
            cmbPassengerName.Text = b.PassengerName;
            txtPassengerPhone.Text = b.PassengerPhone;
            txtPassengerEmail.Text = b.PassengerEmail;

            // Route matching
            for (int i = 0; i < cmbRoute.Items.Count; i++)
            {
                if (cmbRoute.Items[i] is Route r && r.RouteId == b.RouteId)
                {
                    cmbRoute.SelectedIndex = i;
                    break;
                }
            }

            if (cmbRoute.SelectedIndex == -1 && !string.IsNullOrEmpty(b.RouteName))
            {
                cmbRoute.Text = b.RouteName;
            }

            if (b.TravelDate >= dtpTravelDate.MinDate)
            {
                dtpTravelDate.Value = b.TravelDate;
            }
            else
            {
                dtpTravelDate.MinDate = b.TravelDate;
                dtpTravelDate.Value = b.TravelDate;
            }

            cmbDepartureTime.SelectedItem = b.DepartureTime;
            cmbAssignedBus.Text = b.AssignedBus;
            numFarePerSeat.Value = b.FarePerSeat;
            cmbBookingStatus.SelectedItem = b.BookingStatus;
            cmbPaymentStatus.SelectedItem = b.PaymentStatus;
            txtNotes.Text = b.Notes;
        }

        private void ClearFields()
        {
            if (!isEditMode)
            {
                GenerateNewBookingId();
            }
            cmbPassengerName.SelectedIndex = -1;
            cmbPassengerName.Text = "";
            txtPassengerPhone.Text = "";
            txtPassengerEmail.Text = "";
            dtpTravelDate.Value = DateTime.Today;
            txtNotes.Text = "";

            for (int i = 0; i < clbSeats.Items.Count; i++)
            {
                clbSeats.SetItemChecked(i, false);
            }
            UpdateCalculations();
        }

        private void SaveBooking()
        {
            string bookingId = txtBookingId.Text.Trim();
            string passengerName = cmbPassengerName.Text.Trim();
            string phone = txtPassengerPhone.Text.Trim();
            string email = txtPassengerEmail.Text.Trim();
            string bookingStatus = cmbBookingStatus.SelectedItem?.ToString() ?? "Confirmed";
            string paymentStatus = cmbPaymentStatus.SelectedItem?.ToString() ?? "Paid";
            string departureTime = cmbDepartureTime.SelectedItem?.ToString() ?? "06:00 AM";
            string assignedBus = cmbAssignedBus.SelectedItem?.ToString() ?? cmbAssignedBus.Text.Trim();
            if (string.IsNullOrEmpty(assignedBus)) assignedBus = "ET-3-4812 (Scania Touring)";

            // 1. Validation
            if (string.IsNullOrWhiteSpace(bookingId))
            {
                MessageBox.Show("Booking Reference is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookingId.Focus();
                return;
            }

            if (!BookingStore.IsBookingReferenceUnique(bookingId, isEditMode ? editingBooking?.BookingId : null))
            {
                MessageBox.Show($"Booking Reference '{bookingId}' already exists. Please generate a unique ID.", "Duplicate Reference", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBookingId.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(passengerName))
            {
                MessageBox.Show("Please enter or select a Passenger Name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPassengerName.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Passenger contact phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassengerPhone.Focus();
                return;
            }

            Route? selectedRoute = cmbRoute.SelectedItem as Route;
            if (selectedRoute == null)
            {
                MessageBox.Show("Please select an available Route / Trip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoute.Focus();
                return;
            }

            if (selectedRoute.Status != "Active")
            {
                MessageBox.Show($"The selected route '{selectedRoute.RouteName}' is Inactive and cannot accept new bookings.", "Route Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRoute.Focus();
                return;
            }

            var selectedSeats = GetSelectedSeatNumbers();
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one available seat to reserve.", "Seat Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                clbSeats.Focus();
                return;
            }

            if (numFarePerSeat.Value <= 0)
            {
                MessageBox.Show("Fare per seat must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numFarePerSeat.Focus();
                return;
            }

            // Conflict Check: Double-check that none of the chosen seats have been booked in the meantime
            var currentlyBooked = BookingStore.GetBookedSeats(selectedRoute.RouteId, dtpTravelDate.Value.Date, isEditMode ? editingBooking?.BookingId : null);
            var conflictingSeats = selectedSeats.Where(s => currentlyBooked.Contains(s)).ToList();
            if (conflictingSeats.Count > 0)
            {
                string conflictStr = string.Join(", ", conflictingSeats.Select(s => $"Seat {s}"));
                MessageBox.Show($"The following seat(s) are already booked for this trip and travel date:\n\n{conflictStr}\n\nPlease select alternative seats.", "Seat Conflict Detected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RefreshSeatAvailability();
                return;
            }

            // 2. Build or update model
            if (isEditMode && editingBooking != null)
            {
                editingBooking.PassengerName = passengerName;
                editingBooking.PassengerPhone = phone;
                editingBooking.PassengerEmail = email;
                editingBooking.RouteId = selectedRoute.RouteId;
                editingBooking.RouteName = selectedRoute.RouteName;
                editingBooking.Source = selectedRoute.Source;
                editingBooking.Destination = selectedRoute.Destination;
                editingBooking.TravelDate = dtpTravelDate.Value.Date;
                editingBooking.DepartureTime = departureTime;
                editingBooking.AssignedBus = assignedBus;
                editingBooking.Seats = selectedSeats;
                editingBooking.FarePerSeat = numFarePerSeat.Value;
                editingBooking.TotalAmount = numFarePerSeat.Value * selectedSeats.Count;
                editingBooking.BookingStatus = bookingStatus;
                editingBooking.PaymentStatus = paymentStatus;
                editingBooking.Notes = txtNotes.Text.Trim();

                BookingStore.Update(editingBooking);
                MessageBox.Show($"Booking '{editingBooking.BookingId}' for {passengerName} has been successfully updated!\n\nSeats: {editingBooking.SeatNumbersDisplay}\nTotal: {editingBooking.TotalAmount:N2} ETB", "Booking Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Booking newBooking = new Booking(
                    bookingId,
                    passengerName,
                    phone,
                    email,
                    selectedRoute.RouteId,
                    selectedRoute.RouteName,
                    selectedRoute.Source,
                    selectedRoute.Destination,
                    dtpTravelDate.Value.Date,
                    departureTime,
                    assignedBus,
                    selectedSeats,
                    numFarePerSeat.Value,
                    bookingStatus,
                    paymentStatus,
                    txtNotes.Text.Trim()
                );

                BookingStore.Add(newBooking);
                MessageBox.Show($"Booking '{newBooking.BookingId}' created successfully for {passengerName}!\n\nRoute: {newBooking.FullRouteDisplay}\nSeats: {newBooking.SeatNumbersDisplay}\nTotal Fare: {newBooking.TotalAmount:N2} ETB ({paymentStatus})", "Booking Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

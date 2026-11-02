using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bus_Ticket_mgmt;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class TicketOfficerDashboardForm : Form
    {
        private bool isMaximized = false;
        private Point normalLocation;
        private Size normalSize;

        private readonly string _officerName = "Marta Tadesse (Desk 01)";
        private Panel panelSidebarNav = null!;
        private Panel panelSidebarBottom = null!;

        public TicketOfficerDashboardForm()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            InitializeCustomUI();
            SetupNavigation();

            // Setup Event Handlers for 4 Core Modules
            SetupPassengerEvents();
            SetupBookingManagementEvents();
            SetupTicketManagementEvents();
            SetupPaymentEvents();
            SetupBookingHistoryEvents();

            // Populate Initial Data
            PopulatePassengersList();
            PopulateBookingsList();
            PopulateTicketsList();
            PopulatePaymentsList();
            PopulateBookingHistoryList();

            // Default start view: Passenger Management
            ShowPassengersView();
        }

        #region Custom UI & Window Management

        private void InitializeCustomUI()
        {
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

            // Pinned Sign Out Button wiring
            btnNavLogout.Click += (s, e) =>
            {
                var result = MessageBox.Show(
                    "Are you sure you want to log out of the Ticket Officer terminal?",
                    "Confirm Sign Out",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            };
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
                btnMaximize.Text = "🗗";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = normalLocation;
                this.Size = normalSize;
                isMaximized = false;
                btnMaximize.Text = "🗖";
            }
        }

        #endregion

        #region Navigation & Sidebar Layout

        private void SetupNavigation()
        {
            // Setup two-tier sidebar: Scrollable nav area on top, Pinned Sign Out bar at the bottom
            panelSidebar.AutoScroll = false;

            panelSidebarBottom = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 88,
                BackColor = Color.FromArgb(245, 247, 250)
            };
            panelSidebarBottom.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(borderPen, 12, 0, panelSidebarBottom.Width - 12, 0);
                    e.Graphics.DrawLine(borderPen, panelSidebarBottom.Width - 1, 0, panelSidebarBottom.Width - 1, panelSidebarBottom.Height);
                }
            };

            panelSidebarNav = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(245, 247, 250),
                AutoScroll = true
            };
            panelSidebarNav.Paint += (s, e) =>
            {
                using (Pen borderPen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(borderPen, panelSidebarNav.Width - 1, 0, panelSidebarNav.Width - 1, panelSidebarNav.Height);
                }
            };

            // Move navigation controls into panelSidebarNav
            panelSidebar.Controls.Remove(lblNavHeader);
            panelSidebarNav.Controls.Add(lblNavHeader);

            Button[] navButtonsList = new[]
            {
                btnNavPassengers, btnNavBookings, btnNavTickets, btnNavPayments, btnNavHistory
            };

            foreach (var btn in navButtonsList)
            {
                panelSidebar.Controls.Remove(btn);
                panelSidebarNav.Controls.Add(btn);
            }

            // Move logout button into panelSidebarBottom
            panelSidebar.Controls.Remove(btnNavLogout);
            panelSidebarBottom.Controls.Add(btnNavLogout);

            // Add containers to panelSidebar (Fill first, Bottom second)
            panelSidebar.Controls.Add(panelSidebarNav);
            panelSidebar.Controls.Add(panelSidebarBottom);

            LayoutSidebarButtons();
            panelSidebar.SizeChanged += (s, e) => LayoutSidebarButtons();

            btnNavPassengers.Text = "👥   Passengers";
            btnNavBookings.Text = "📋   Bookings";
            btnNavTickets.Text = "🎫   Tickets";
            btnNavPayments.Text = "💳   Payments";
            btnNavHistory.Text = "📜   Booking History";
            btnNavLogout.Text = "🚪   Sign Out";

            SetupSidebarButton(btnNavPassengers);
            SetupSidebarButton(btnNavBookings);
            SetupSidebarButton(btnNavTickets);
            SetupSidebarButton(btnNavPayments);
            SetupSidebarButton(btnNavHistory);

            // Sign out button hover transition
            btnNavLogout.BackColor = Color.White;
            btnNavLogout.ForeColor = Color.FromArgb(71, 85, 105);
            btnNavLogout.FlatAppearance.BorderSize = 2;
            btnNavLogout.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavLogout.MouseEnter += (s, e) =>
            {
                btnNavLogout.BackColor = Color.FromArgb(241, 245, 249);
                btnNavLogout.ForeColor = Color.FromArgb(15, 23, 42);
                btnNavLogout.FlatAppearance.BorderColor = Color.FromArgb(30, 41, 59);
            };
            btnNavLogout.MouseLeave += (s, e) =>
            {
                btnNavLogout.BackColor = Color.White;
                btnNavLogout.ForeColor = Color.FromArgb(71, 85, 105);
                btnNavLogout.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            };

            // Module Switch Handlers
            btnNavPassengers.Click += (s, e) => ShowPassengersView();
            btnNavBookings.Click += (s, e) => ShowBookingsView();
            btnNavTickets.Click += (s, e) => ShowTicketsView();
            btnNavPayments.Click += (s, e) => ShowPaymentsView();
            btnNavHistory.Click += (s, e) => ShowBookingHistoryView();
        }

        private void LayoutSidebarButtons()
        {
            if (panelSidebarNav == null || panelSidebarBottom == null) return;

            Button[] navButtons = new[]
            {
                btnNavPassengers, btnNavBookings, btnNavTickets, btnNavPayments, btnNavHistory
            };

            int sideWidth = panelSidebarNav.ClientSize.Width;
            if (sideWidth < 180) sideWidth = panelSidebar.Width;
            if (sideWidth < 180) sideWidth = 260;

            int marginX = 14;
            int btnWidth = Math.Max(200, sideWidth - (marginX * 2));
            int startY = 36;
            int btnHeight = 60;
            int constantSpacing = 20;

            for (int i = 0; i < navButtons.Length; i++)
            {
                var btn = navButtons[i];
                if (btn == null) continue;

                btn.Location = new Point(marginX, startY + i * (btnHeight + constantSpacing));
                btn.Size = new Size(btnWidth, btnHeight);
                btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
                btn.Padding = new Padding(20, 0, 0, 0);
                btn.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleLeft;
                btn.Cursor = Cursors.Hand;
            }

            int bottomWidth = panelSidebarBottom.ClientSize.Width;
            if (bottomWidth < 180) bottomWidth = panelSidebar.Width;
            int logoutWidth = Math.Max(200, bottomWidth - (marginX * 2));

            btnNavLogout.Location = new Point(marginX, 14);
            btnNavLogout.Size = new Size(logoutWidth, btnHeight);
            btnNavLogout.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnNavLogout.FlatStyle = FlatStyle.Flat;
            btnNavLogout.FlatAppearance.BorderSize = 2;
            btnNavLogout.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavLogout.Padding = new Padding(20, 0, 0, 0);
            btnNavLogout.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
            btnNavLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLogout.Cursor = Cursors.Hand;
        }

        private void SetupSidebarButton(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                if (btn.BackColor != Color.FromArgb(226, 232, 240))
                {
                    btn.BackColor = Color.FromArgb(241, 245, 249);
                    btn.ForeColor = Color.FromArgb(15, 23, 42);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(30, 41, 59);
                }
            };
            btn.MouseLeave += (s, e) =>
            {
                if (btn.BackColor != Color.FromArgb(226, 232, 240))
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(30, 41, 59);
                    btn.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
                }
            };
        }

        private void SetActiveNavButton(Button activeButton)
        {
            Button[] allNavButtons = new[]
            {
                btnNavPassengers, btnNavBookings, btnNavTickets, btnNavPayments, btnNavHistory
            };

            foreach (var btn in allNavButtons)
            {
                if (btn == null) continue;
                if (btn == activeButton)
                {
                    btn.BackColor = Color.FromArgb(226, 232, 240);
                    btn.ForeColor = Color.FromArgb(15, 23, 42);
                    btn.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(15, 23, 42);
                }
                else
                {
                    btn.BackColor = Color.White;
                    btn.ForeColor = Color.FromArgb(30, 41, 59);
                    btn.Font = new Font("Segoe UI", 12f, FontStyle.Bold);
                    btn.FlatAppearance.BorderSize = 2;
                    btn.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
                }
            }
        }

        private void HideAllViews()
        {
            panelPassengers.Visible = false;
            panelBookingManagement.Visible = false;
            panelTicketManagement.Visible = false;
            panelPayments.Visible = false;
            panelBookingHistory.Visible = false;
        }

        private void ShowPassengersView()
        {
            HideAllViews();
            panelPassengers.Visible = true;
            panelPassengers.BringToFront();
            SetActiveNavButton(btnNavPassengers);
            lblPageHeading.Text = "Passenger Management";
            PopulatePassengersList();
        }

        private void ShowBookingsView()
        {
            HideAllViews();
            panelBookingManagement.Visible = true;
            panelBookingManagement.BringToFront();
            SetActiveNavButton(btnNavBookings);
            lblPageHeading.Text = "Booking & Reservation Management";
            PopulateBookingsList();
        }

        private void ShowTicketsView()
        {
            HideAllViews();
            panelTicketManagement.Visible = true;
            panelTicketManagement.BringToFront();
            SetActiveNavButton(btnNavTickets);
            lblPageHeading.Text = "Ticket & Boarding Management";
            PopulateTicketsList();
        }

        private void ShowPaymentsView()
        {
            HideAllViews();
            panelPayments.Visible = true;
            panelPayments.BringToFront();
            SetActiveNavButton(btnNavPayments);
            lblPageHeading.Text = "Payment & Transaction Management";
            PopulatePaymentsList();
        }

        private void ShowBookingHistoryView()
        {
            HideAllViews();
            panelBookingHistory.Visible = true;
            panelBookingHistory.BringToFront();
            SetActiveNavButton(btnNavHistory);
            lblPageHeading.Text = "Booking History & Records";
            PopulateBookingHistoryList();
        }

        #endregion

        #region 1. Passenger Management

        private void SetupPassengerEvents()
        {
            cmbPassengerStatusFilter.Items.Clear();
            cmbPassengerStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Inactive" });
            cmbPassengerStatusFilter.SelectedIndex = 0;

            txtSearchPassenger.TextChanged += (s, e) => PopulatePassengersList();
            cmbPassengerStatusFilter.SelectedIndexChanged += (s, e) => PopulatePassengersList();

            btnRefreshPassengers.Click += (s, e) =>
            {
                txtSearchPassenger.Clear();
                cmbPassengerStatusFilter.SelectedIndex = 0;
                PopulatePassengersList();
            };

            btnAddPassenger.Click += (s, e) =>
            {
                using (var dialog = new UserDialogForm())
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        PopulatePassengersList();
                        MessageBox.Show("New passenger account registered successfully!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };

            btnEditPassenger.Click += (s, e) => EditSelectedPassenger();
            lvPassengers.DoubleClick += (s, e) => EditSelectedPassenger();
            btnViewPassenger.Click += (s, e) => ViewSelectedPassenger();
        }

        private void EditSelectedPassenger()
        {
            if (lvPassengers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a passenger from the list to update information.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string passengerId = lvPassengers.SelectedItems[0].Text;
            var passenger = UserStore.GetById(passengerId);
            if (passenger == null)
            {
                MessageBox.Show("Passenger profile not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var dialog = new UserDialogForm(passenger))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulatePassengersList();
                    MessageBox.Show("Passenger profile updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ViewSelectedPassenger()
        {
            if (lvPassengers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a passenger from the list to view.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string passengerId = lvPassengers.SelectedItems[0].Text;
            var passenger = UserStore.GetById(passengerId);
            if (passenger == null) return;

            string details = $"Passenger ID: {passenger.UserId}\n" +
                             $"Full Name: {passenger.FullName}\n" +
                             $"Username: {passenger.Username}\n" +
                             $"Email: {passenger.Email}\n" +
                             $"Phone Number: {passenger.Phone}\n" +
                             $"Physical Address: {passenger.Address}\n" +
                             $"Account Status: {passenger.Status}\n" +
                             $"Registered Date: {passenger.CreatedDate:yyyy-MM-dd HH:mm}";

            MessageBox.Show(details, $"Passenger Dossier - {passenger.FullName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PopulatePassengersList()
        {
            lvPassengers.Items.Clear();

            var allPassengers = UserStore.GetAll()
                .Where(u => u.Role.Equals("Passenger", StringComparison.OrdinalIgnoreCase))
                .ToList();

            int totalCount = allPassengers.Count;
            int activeCount = allPassengers.Count(u => u.Status.Equals("Active", StringComparison.OrdinalIgnoreCase));
            int newTodayCount = allPassengers.Count(u => u.CreatedDate.Date == DateTime.Today);

            lblMetricTotalPassengersVal.Text = totalCount.ToString();
            lblMetricActivePassengersVal.Text = activeCount.ToString();
            lblMetricNewPassengersTodayVal.Text = newTodayCount.ToString();

            string search = txtSearchPassenger.Text.Trim().ToLower();
            string statusFilter = cmbPassengerStatusFilter.SelectedItem?.ToString() ?? "All Statuses";

            var filtered = allPassengers.Where(u =>
            {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                                     u.UserId.ToLower().Contains(search) ||
                                     u.FullName.ToLower().Contains(search) ||
                                     u.Username.ToLower().Contains(search) ||
                                     u.Email.ToLower().Contains(search) ||
                                     u.Phone.ToLower().Contains(search) ||
                                     u.Address.ToLower().Contains(search);

                bool matchesStatus = statusFilter switch
                {
                    "Active" => u.Status.Equals("Active", StringComparison.OrdinalIgnoreCase),
                    "Inactive" => !u.Status.Equals("Active", StringComparison.OrdinalIgnoreCase),
                    _ => true
                };

                return matchesSearch && matchesStatus;
            }).OrderByDescending(u => u.CreatedDate).ToList();

            foreach (var p in filtered)
            {
                var item = new ListViewItem(p.UserId);
                item.SubItems.Add(p.FullName);
                item.SubItems.Add(p.Username);
                item.SubItems.Add(p.Email);
                item.SubItems.Add(p.Phone);
                item.SubItems.Add(p.Address);
                item.SubItems.Add(p.Status);
                item.SubItems.Add(p.CreatedDate.ToString("yyyy-MM-dd HH:mm"));

                if (!p.Status.Equals("Active", StringComparison.OrdinalIgnoreCase))
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184);
                }

                lvPassengers.Items.Add(item);
            }

            lblPassengerCount.Text = $"Showing {filtered.Count} of {totalCount} registered passengers";
        }

        #endregion

        #region 2. Booking & Ticket Management

        private void SetupBookingManagementEvents()
        {
            cmbBookingStatusFilter.Items.Clear();
            cmbBookingStatusFilter.Items.AddRange(new object[] { "All Statuses", "Confirmed", "Pending", "Cancelled" });
            cmbBookingStatusFilter.SelectedIndex = 0;

            cmbBookingRouteFilter.Items.Clear();
            cmbBookingRouteFilter.Items.Add("All Routes");
            foreach (var route in RouteStore.GetAll())
            {
                cmbBookingRouteFilter.Items.Add(route.RouteName);
            }
            cmbBookingRouteFilter.SelectedIndex = 0;

            txtSearchBooking.TextChanged += (s, e) => PopulateBookingsList();
            cmbBookingStatusFilter.SelectedIndexChanged += (s, e) => PopulateBookingsList();
            cmbBookingRouteFilter.SelectedIndexChanged += (s, e) => PopulateBookingsList();

            btnResetBookingFilters.Click += (s, e) =>
            {
                txtSearchBooking.Clear();
                cmbBookingStatusFilter.SelectedIndex = 0;
                cmbBookingRouteFilter.SelectedIndex = 0;
                PopulateBookingsList();
            };

            // Search Available Trips, Select Seats & Book Tickets
            btnNewBooking.Click += (s, e) =>
            {
                using (var dialog = new BookingDialogForm())
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        PopulateBookingsList();
                        PopulateTicketsList();
                        PopulatePaymentsList();
                        PopulateBookingHistoryList();
                        MessageBox.Show("Booking reservation confirmed successfully!", "Booking Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };

            // View & Update Bookings
            btnModifyBooking.Click += (s, e) => ModifySelectedBooking();
            lvBookings.DoubleClick += (s, e) => ModifySelectedBooking();

            btnViewBookingDetails.Click += (s, e) =>
            {
                if (lvBookings.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a booking to view details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string bookingId = lvBookings.SelectedItems[0].Text;
                var b = BookingStore.GetById(bookingId);
                if (b == null) return;

                string summary = $"Booking Reference: {b.BookingId}\n" +
                                 $"Passenger Name: {b.PassengerName}\n" +
                                 $"Contact Phone: {b.PassengerPhone}\n" +
                                 $"Route: {b.RouteName}\n" +
                                 $"Travel Date: {b.TravelDate:yyyy-MM-dd}\n" +
                                 $"Departure Time: {b.DepartureTime}\n" +
                                 $"Assigned Seats: {b.SeatNumbersDisplay}\n" +
                                 $"Total Price: {b.TotalAmount:N2} ETB\n" +
                                 $"Reservation Status: {b.BookingStatus}\n" +
                                 $"Payment Status: {b.PaymentStatus}\n" +
                                 $"Booked Timestamp: {b.BookingDate:yyyy-MM-dd HH:mm}";

                MessageBox.Show(summary, $"Booking Dossier - {b.BookingId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            btnCancelBookingAction.Click += (s, e) =>
            {
                if (lvBookings.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a booking to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string bookingId = lvBookings.SelectedItems[0].Text;
                var b = BookingStore.GetById(bookingId);
                if (b == null) return;

                if (b.BookingStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This booking is already cancelled.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Are you sure you want to cancel booking {bookingId} for {b.PassengerName}?\nThis will release reserved seat(s): {b.SeatNumbersDisplay}.",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    BookingStore.CancelBooking(bookingId);
                    var tList = TicketStore.GetByBookingId(bookingId);
                    foreach (var t in tList)
                    {
                        TicketStore.CancelTicket(t.TicketId, out _);
                    }

                    PopulateBookingsList();
                    PopulateTicketsList();
                    PopulateBookingHistoryList();
                    MessageBox.Show("Booking cancelled successfully.", "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            btnPrintTicket.Click += (s, e) =>
            {
                if (lvBookings.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a booking to print its boarding pass.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string bookingId = lvBookings.SelectedItems[0].Text;
                var b = BookingStore.GetById(bookingId);
                if (b == null) return;

                PrintBoardingPassPreview(b.BookingId, b.PassengerName, b.RouteName, b.TravelDate.ToString("yyyy-MM-dd"), b.DepartureTime, b.SeatNumbersDisplay, b.TotalAmount);
            };
        }

        private void ModifySelectedBooking()
        {
            if (lvBookings.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a booking to modify.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string bookingId = lvBookings.SelectedItems[0].Text;
            var booking = BookingStore.GetById(bookingId);
            if (booking == null) return;

            using (var dialog = new BookingDialogForm(booking))
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    PopulateBookingsList();
                    PopulateTicketsList();
                    PopulateBookingHistoryList();
                    MessageBox.Show("Booking details updated successfully!", "Update Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void PopulateBookingsList()
        {
            lvBookings.Items.Clear();

            var allBookings = BookingStore.GetAll();

            lblMetricTotalBookingsVal.Text = BookingStore.GetTotalCount().ToString();
            lblMetricConfirmedBookingsVal.Text = BookingStore.GetConfirmedCount().ToString();
            lblMetricPendingBookingsVal.Text = BookingStore.GetPendingCount().ToString();
            lblMetricCancelledBookingsVal.Text = BookingStore.GetCancelledCount().ToString();
            lblMetricTodayBookingsVal.Text = BookingStore.GetTodayCount().ToString();

            string search = txtSearchBooking.Text.Trim().ToLower();
            string statusFilter = cmbBookingStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            string routeFilter = cmbBookingRouteFilter.SelectedItem?.ToString() ?? "All Routes";

            var filtered = allBookings.Where(b =>
            {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                                     b.BookingId.ToLower().Contains(search) ||
                                     b.PassengerName.ToLower().Contains(search) ||
                                     b.PassengerPhone.ToLower().Contains(search) ||
                                     b.RouteName.ToLower().Contains(search) ||
                                     b.SeatNumbersDisplay.ToLower().Contains(search);

                bool matchesStatus = statusFilter == "All Statuses" || b.BookingStatus.Equals(statusFilter, StringComparison.OrdinalIgnoreCase);
                bool matchesRoute = routeFilter == "All Routes" || b.RouteName.Equals(routeFilter, StringComparison.OrdinalIgnoreCase);

                return matchesSearch && matchesStatus && matchesRoute;
            }).OrderByDescending(b => b.BookingDate).ToList();

            foreach (var b in filtered)
            {
                var item = new ListViewItem(b.BookingId);
                item.SubItems.Add(b.PassengerName);
                item.SubItems.Add(b.PassengerPhone);
                item.SubItems.Add(b.RouteName);
                item.SubItems.Add(b.TravelDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(b.DepartureTime);
                item.SubItems.Add(b.SeatNumbersDisplay);
                item.SubItems.Add($"{b.TotalAmount:N2} ETB");
                item.SubItems.Add(b.BookingStatus);
                item.SubItems.Add(b.PaymentStatus);

                if (b.BookingStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184);
                }

                lvBookings.Items.Add(item);
            }

            lblBookingCount.Text = $"Showing {filtered.Count} of {allBookings.Count} bookings";
        }

        private void SetupTicketManagementEvents()
        {
            cmbTicketStatusFilter.Items.Clear();
            cmbTicketStatusFilter.Items.AddRange(new object[] { "All Statuses", "Valid", "Boarded", "Cancelled" });
            cmbTicketStatusFilter.SelectedIndex = 0;

            cmbTicketRouteFilter.Items.Clear();
            cmbTicketRouteFilter.Items.Add("All Routes");
            foreach (var route in RouteStore.GetAll())
            {
                cmbTicketRouteFilter.Items.Add(route.RouteName);
            }
            cmbTicketRouteFilter.SelectedIndex = 0;

            txtSearchTicketFilter.TextChanged += (s, e) => PopulateTicketsList();
            cmbTicketStatusFilter.SelectedIndexChanged += (s, e) => PopulateTicketsList();
            cmbTicketRouteFilter.SelectedIndexChanged += (s, e) => PopulateTicketsList();

            btnResetTicketFilters.Click += (s, e) =>
            {
                txtSearchTicketFilter.Clear();
                cmbTicketStatusFilter.SelectedIndex = 0;
                cmbTicketRouteFilter.SelectedIndex = 0;
                PopulateTicketsList();
            };

            // Issue New Ticket
            btnNewTicket.Click += (s, e) =>
            {
                using (var dialog = new TicketDialogForm())
                {
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        PopulateTicketsList();
                        PopulateBookingsList();
                        PopulatePaymentsList();
                        PopulateBookingHistoryList();
                        MessageBox.Show("New ticket issued successfully!", "Ticket Generated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            };

            // Verify Ticket (Barcode/QR Scan Modal)
            btnVerifyBoardModal.Click += (s, e) =>
            {
                using (var dialog = new TicketVerifyDialogForm())
                {
                    dialog.ShowDialog(this);
                    PopulateTicketsList();
                }
            };

            // Verify & Board Selected Ticket
            btnVerifyAndBoard.Click += (s, e) =>
            {
                if (lvTickets.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a ticket from the list to verify and board.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string ticketId = lvTickets.SelectedItems[0].Text;
                if (TicketStore.VerifyAndBoard(ticketId, _officerName, out string message, out Ticket? verifiedTicket))
                {
                    PopulateTicketsList();
                    MessageBox.Show(message, "Boarding Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(message, "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            };

            // Print Boarding Pass
            btnPrintTicketPass.Click += (s, e) =>
            {
                if (lvTickets.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a ticket to print.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string ticketId = lvTickets.SelectedItems[0].Text;
                var t = TicketStore.GetById(ticketId);
                if (t == null) return;

                PrintBoardingPassPreview(t.BookingId, t.PassengerName, t.RouteName, t.TravelDate.ToString("yyyy-MM-dd"), t.DepartureTime, t.SeatDisplay, t.FareAmount);
            };

            // View Ticket Details
            btnViewTicketDetails.Click += (s, e) =>
            {
                if (lvTickets.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a ticket to view.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string ticketId = lvTickets.SelectedItems[0].Text;
                var t = TicketStore.GetById(ticketId);
                if (t == null) return;

                string text = $"Ticket ID: {t.TicketId}\n" +
                              $"Booking Ref: {t.BookingId}\n" +
                              $"Passenger Name: {t.PassengerName}\n" +
                              $"Phone Number: {t.PassengerPhone}\n" +
                              $"Route: {t.RouteName}\n" +
                              $"Travel Date: {t.TravelDate:yyyy-MM-dd}\n" +
                              $"Departure Time: {t.DepartureTime}\n" +
                              $"Assigned Seat: {t.SeatDisplay}\n" +
                              $"Boarding Gate: {t.GateNumber}\n" +
                              $"Assigned Bus: {t.AssignedBusPlate}\n" +
                              $"Fare Price: {t.FareAmount:N2} ETB\n" +
                              $"Ticket Status: {t.Status}\n" +
                              $"Boarding Time: {(t.BoardedTime.HasValue ? t.BoardedTime.Value.ToString("yyyy-MM-dd HH:mm") : "Not Boarded")}";

                MessageBox.Show(text, $"Ticket Dossier - {t.TicketId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Cancel Ticket
            btnCancelTicketAction.Click += (s, e) =>
            {
                if (lvTickets.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a ticket to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string ticketId = lvTickets.SelectedItems[0].Text;
                var t = TicketStore.GetById(ticketId);
                if (t == null) return;

                var confirm = MessageBox.Show(
                    $"Are you sure you want to cancel ticket {ticketId} for {t.PassengerName}?",
                    "Confirm Cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    if (TicketStore.CancelTicket(ticketId, out string msg))
                    {
                        PopulateTicketsList();
                        PopulateBookingsList();
                        PopulateBookingHistoryList();
                        MessageBox.Show(msg, "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(msg, "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            };

            lvTickets.DoubleClick += (s, e) => btnViewTicketDetails.PerformClick();
        }

        private void PopulateTicketsList()
        {
            lvTickets.Items.Clear();

            var allTickets = TicketStore.GetAll();

            lblMetricTotalTicketsVal.Text = TicketStore.GetTotalCount().ToString();
            lblMetricValidTicketsVal.Text = TicketStore.GetValidCount().ToString();
            lblMetricBoardedTicketsVal.Text = TicketStore.GetBoardedCount().ToString();
            lblMetricCancelledTicketsVal.Text = TicketStore.GetCancelledCount().ToString();
            lblMetricTodayTicketsVal.Text = TicketStore.GetTodayBoardingCount().ToString();

            string search = txtSearchTicketFilter.Text.Trim().ToLower();
            string statusFilter = cmbTicketStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            string routeFilter = cmbTicketRouteFilter.SelectedItem?.ToString() ?? "All Routes";

            var filtered = allTickets.Where(t =>
            {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                                     t.TicketId.ToLower().Contains(search) ||
                                     t.BookingId.ToLower().Contains(search) ||
                                     t.PassengerName.ToLower().Contains(search) ||
                                     t.PassengerPhone.ToLower().Contains(search) ||
                                     t.RouteName.ToLower().Contains(search) ||
                                     t.SeatDisplay.ToLower().Contains(search);

                bool matchesStatus = statusFilter == "All Statuses" || t.Status.Equals(statusFilter, StringComparison.OrdinalIgnoreCase);
                bool matchesRoute = routeFilter == "All Routes" || t.RouteName.Equals(routeFilter, StringComparison.OrdinalIgnoreCase);

                return matchesSearch && matchesStatus && matchesRoute;
            }).OrderByDescending(t => t.IssuedDate).ToList();

            foreach (var t in filtered)
            {
                var item = new ListViewItem(t.TicketId);
                item.SubItems.Add(t.BookingId);
                item.SubItems.Add(t.PassengerName);
                item.SubItems.Add(t.PassengerPhone);
                item.SubItems.Add(t.RouteName);
                item.SubItems.Add(t.TravelDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(t.DepartureTime);
                item.SubItems.Add(t.SeatDisplay);
                item.SubItems.Add(t.GateNumber);
                item.SubItems.Add(t.AssignedBusPlate);
                item.SubItems.Add(t.Status);

                if (t.Status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184);
                }

                lvTickets.Items.Add(item);
            }

            lblTicketCount.Text = $"Showing {filtered.Count} of {allTickets.Count} tickets";
        }

        #endregion

        #region 3. Payment Management

        private void SetupPaymentEvents()
        {
            cmbPaymentStatusFilter.Items.Clear();
            cmbPaymentStatusFilter.Items.AddRange(new object[] { "All Statuses", "Paid", "Pending", "Refunded" });
            cmbPaymentStatusFilter.SelectedIndex = 0;

            cmbPaymentMethodFilter.Items.Clear();
            cmbPaymentMethodFilter.Items.AddRange(new object[] { "All Methods", "Cash", "Telebirr", "CBE Birr", "Card" });
            cmbPaymentMethodFilter.SelectedIndex = 0;

            txtSearchPayments.TextChanged += (s, e) => PopulatePaymentsList();
            cmbPaymentStatusFilter.SelectedIndexChanged += (s, e) => PopulatePaymentsList();
            cmbPaymentMethodFilter.SelectedIndexChanged += (s, e) => PopulatePaymentsList();

            btnRefreshPayments.Click += (s, e) =>
            {
                txtSearchPayments.Clear();
                cmbPaymentStatusFilter.SelectedIndex = 0;
                cmbPaymentMethodFilter.SelectedIndex = 0;
                PopulatePaymentsList();
            };

            // Record Passenger Payment
            btnRecordPayment.Click += (s, e) => OpenRecordPaymentDialog();

            // Process Refund
            btnProcessRefund.Click += (s, e) =>
            {
                if (lvPayments.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a payment transaction to process refund.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string receiptNo = lvPayments.SelectedItems[0].Text;
                var record = PaymentStore.GetAll().FirstOrDefault(p => p.ReceiptNumber == receiptNo);
                if (record == null) return;

                if (record.PaymentStatus.Equals("Refunded", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This transaction has already been refunded.", "Already Refunded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var confirm = MessageBox.Show(
                    $"Confirm processing refund of {record.Amount:N2} ETB for receipt {receiptNo}?\nPassenger: {record.PassengerName}",
                    "Confirm Disbursal Refund",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    record.PaymentStatus = "Refunded";
                    record.Notes += " [Refunded at Desk on " + DateTime.Now.ToString("yyyy-MM-dd HH:mm") + "]";
                    PopulatePaymentsList();
                    MessageBox.Show("Refund recorded successfully.", "Refund Disbursed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            // Generate Payment Receipt
            btnPrintReceipt.Click += (s, e) =>
            {
                if (lvPayments.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a transaction to generate a receipt.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string receiptNo = lvPayments.SelectedItems[0].Text;
                var p = PaymentStore.GetAll().FirstOrDefault(x => x.ReceiptNumber == receiptNo);
                if (p == null) return;

                string receiptText = "========================================\n" +
                                     "    DEBRE BERHAN BUS LINES PORTAL       \n" +
                                     "        OFFICIAL PAYMENT RECEIPT        \n" +
                                     "========================================\n" +
                                     $"Receipt Number:   {p.ReceiptNumber}\n" +
                                     $"Transaction Date: {p.TransactionDate:yyyy-MM-dd HH:mm:ss}\n" +
                                     $"Cashier/Desk:     {p.CashierName}\n" +
                                     $"Passenger:        {p.PassengerName}\n" +
                                     $"Route:            {p.RouteName}\n" +
                                     $"Booking Ref:      {p.BookingId}\n" +
                                     $"Ticket Number:    {p.TicketId}\n" +
                                     $"Payment Method:   {p.PaymentMethod}\n" +
                                     $"Payment Status:   {p.PaymentStatus}\n" +
                                     "----------------------------------------\n" +
                                     $"AMOUNT PAID:      {p.Amount:N2} ETB\n" +
                                     "----------------------------------------\n" +
                                     "Notes: " + (string.IsNullOrEmpty(p.Notes) ? "None" : p.Notes) + "\n" +
                                     "Thank you for traveling with us!\n" +
                                     "========================================";

                MessageBox.Show(receiptText, $"Payment Receipt - {p.ReceiptNumber}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            lvPayments.DoubleClick += (s, e) => btnPrintReceipt.PerformClick();
        }

        private void OpenRecordPaymentDialog()
        {
            using (var form = new Form())
            {
                form.Text = "Record Passenger Payment";
                form.Size = new Size(480, 440);
                form.StartPosition = FormStartPosition.CenterParent;
                form.FormBorderStyle = FormBorderStyle.FixedDialog;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.BackColor = Color.White;

                Label lblP = new Label { Text = "Passenger Name:", Location = new Point(24, 20), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtP = new TextBox { Location = new Point(24, 42), Width = 410 };

                Label lblR = new Label { Text = "Route Name:", Location = new Point(24, 80), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbR = new ComboBox { Location = new Point(24, 102), Width = 410, DropDownStyle = ComboBoxStyle.DropDownList };
                foreach (var r in RouteStore.GetAll()) cmbR.Items.Add(r.RouteName);
                if (cmbR.Items.Count > 0) cmbR.SelectedIndex = 0;

                Label lblA = new Label { Text = "Amount (ETB):", Location = new Point(24, 140), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtA = new TextBox { Location = new Point(24, 162), Width = 190, Text = "1150.00" };

                Label lblM = new Label { Text = "Payment Method:", Location = new Point(244, 140), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                ComboBox cmbM = new ComboBox { Location = new Point(244, 162), Width = 190, DropDownStyle = ComboBoxStyle.DropDownList };
                cmbM.Items.AddRange(new object[] { "Cash", "Telebirr", "CBE Birr", "Card" });
                cmbM.SelectedIndex = 0;

                Label lblN = new Label { Text = "Transaction Notes / Reference:", Location = new Point(24, 200), AutoSize = true, Font = new Font("Segoe UI", 9f, FontStyle.Bold) };
                TextBox txtN = new TextBox { Location = new Point(24, 222), Width = 410, Text = "Desk Counter passenger payment." };

                Button btnSave = new Button
                {
                    Text = "Save Transaction",
                    Location = new Point(220, 310),
                    Size = new Size(130, 42),
                    BackColor = Color.FromArgb(15, 23, 42),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                    DialogResult = DialogResult.OK
                };
                btnSave.FlatAppearance.BorderSize = 0;

                Button btnCancel = new Button
                {
                    Text = "Cancel",
                    Location = new Point(358, 310),
                    Size = new Size(76, 42),
                    BackColor = Color.FromArgb(241, 245, 249),
                    ForeColor = Color.FromArgb(71, 85, 105),
                    FlatStyle = FlatStyle.Flat,
                    DialogResult = DialogResult.Cancel
                };
                btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);

                form.Controls.AddRange(new Control[] { lblP, txtP, lblR, cmbR, lblA, txtA, lblM, cmbM, lblN, txtN, btnSave, btnCancel });
                form.AcceptButton = btnSave;
                form.CancelButton = btnCancel;

                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    if (string.IsNullOrWhiteSpace(txtP.Text))
                    {
                        MessageBox.Show("Please enter passenger name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!decimal.TryParse(txtA.Text, out decimal amt) || amt <= 0)
                    {
                        MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    var newRecord = new PaymentRecord
                    {
                        ReceiptNumber = PaymentStore.GenerateNextReceiptNo(),
                        BookingId = "BK" + new Random().Next(1000, 9999),
                        TicketId = "TK" + new Random().Next(1000, 9999),
                        PassengerName = txtP.Text.Trim(),
                        RouteName = cmbR.SelectedItem?.ToString() ?? "General Transit",
                        Amount = amt,
                        PaymentMethod = cmbM.SelectedItem?.ToString() ?? "Cash",
                        PaymentStatus = "Paid",
                        TransactionDate = DateTime.Now,
                        CashierName = _officerName,
                        Notes = txtN.Text.Trim()
                    };

                    PaymentStore.Add(newRecord);
                    PopulatePaymentsList();
                    MessageBox.Show($"Payment receipt {newRecord.ReceiptNumber} created successfully!", "Payment Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void PopulatePaymentsList()
        {
            lvPayments.Items.Clear();

            var allPayments = PaymentStore.GetAll();

            lblPayTotalVal.Text = $"{PaymentStore.GetTotalCollectionsToday():N2} ETB";
            lblPayCashVal.Text = $"{PaymentStore.GetCashTotalToday():N2} ETB";
            lblPayDigitalVal.Text = $"{PaymentStore.GetDigitalTotalToday():N2} ETB";
            lblPayRefundsVal.Text = $"{PaymentStore.GetRefundsTotalToday():N2} ETB";

            string search = txtSearchPayments.Text.Trim().ToLower();
            string statusFilter = cmbPaymentStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            string methodFilter = cmbPaymentMethodFilter.SelectedItem?.ToString() ?? "All Methods";

            var filtered = allPayments.Where(p =>
            {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                                     p.ReceiptNumber.ToLower().Contains(search) ||
                                     p.BookingId.ToLower().Contains(search) ||
                                     p.TicketId.ToLower().Contains(search) ||
                                     p.PassengerName.ToLower().Contains(search) ||
                                     p.RouteName.ToLower().Contains(search);

                bool matchesStatus = statusFilter == "All Statuses" || p.PaymentStatus.Equals(statusFilter, StringComparison.OrdinalIgnoreCase);
                bool matchesMethod = methodFilter == "All Methods" || p.PaymentMethod.Equals(methodFilter, StringComparison.OrdinalIgnoreCase);

                return matchesSearch && matchesStatus && matchesMethod;
            }).OrderByDescending(p => p.TransactionDate).ToList();

            foreach (var p in filtered)
            {
                var item = new ListViewItem(p.ReceiptNumber);
                item.SubItems.Add(p.BookingId);
                item.SubItems.Add(p.TicketId);
                item.SubItems.Add(p.PassengerName);
                item.SubItems.Add(p.RouteName);
                item.SubItems.Add($"{p.Amount:N2} ETB");
                item.SubItems.Add(p.PaymentMethod);
                item.SubItems.Add(p.PaymentStatus);
                item.SubItems.Add(p.TransactionDate.ToString("yyyy-MM-dd HH:mm"));
                item.SubItems.Add(p.CashierName);

                if (p.PaymentStatus.Equals("Refunded", StringComparison.OrdinalIgnoreCase))
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184);
                }

                lvPayments.Items.Add(item);
            }

            lblPaymentCount.Text = $"Showing {filtered.Count} of {allPayments.Count} transactions";
        }

        #endregion

        #region 4. Booking History

        private void SetupBookingHistoryEvents()
        {
            cmbHistoryStatusFilter.Items.Clear();
            cmbHistoryStatusFilter.Items.AddRange(new object[] { "All Records", "Completed", "Cancelled", "Confirmed", "Pending" });
            cmbHistoryStatusFilter.SelectedIndex = 0;

            txtSearchHistory.TextChanged += (s, e) => PopulateBookingHistoryList();
            cmbHistoryStatusFilter.SelectedIndexChanged += (s, e) => PopulateBookingHistoryList();

            btnRefreshHistory.Click += (s, e) =>
            {
                txtSearchHistory.Clear();
                cmbHistoryStatusFilter.SelectedIndex = 0;
                PopulateBookingHistoryList();
            };

            btnViewHistoryDetails.Click += (s, e) => ViewSelectedHistoryDetails();
            lvBookingHistory.DoubleClick += (s, e) => ViewSelectedHistoryDetails();

            btnPrintHistoryPass.Click += (s, e) =>
            {
                if (lvBookingHistory.SelectedItems.Count == 0)
                {
                    MessageBox.Show("Please select a booking record from the history table to reprint pass.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string bookingId = lvBookingHistory.SelectedItems[0].Text;
                var b = BookingStore.GetById(bookingId);
                if (b == null) return;

                PrintBoardingPassPreview(b.BookingId, b.PassengerName, b.RouteName, b.TravelDate.ToString("yyyy-MM-dd"), b.DepartureTime, b.SeatNumbersDisplay, b.TotalAmount);
            };
        }

        private void ViewSelectedHistoryDetails()
        {
            if (lvBookingHistory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a booking record from history to view audit details.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string bookingId = lvBookingHistory.SelectedItems[0].Text;
            var b = BookingStore.GetById(bookingId);
            if (b == null) return;

            string details = $"=== BOOKING HISTORICAL ARCHIVE ===\n" +
                             $"Booking Reference: {b.BookingId}\n" +
                             $"Passenger: {b.PassengerName}\n" +
                             $"Phone Number: {b.PassengerPhone}\n" +
                             $"Route: {b.RouteName}\n" +
                             $"Travel Date: {b.TravelDate:yyyy-MM-dd}\n" +
                             $"Scheduled Departure: {b.DepartureTime}\n" +
                             $"Booked Seats: {b.SeatNumbersDisplay}\n" +
                             $"Total Amount: {b.TotalAmount:N2} ETB\n" +
                             $"Current Status: {b.BookingStatus}\n" +
                             $"Payment Status: {b.PaymentStatus}\n" +
                             $"Created At: {b.BookingDate:yyyy-MM-dd HH:mm:ss}\n" +
                             $"Archive State: {(b.BookingStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) ? "Cancelled Record" : "Completed / Active Trip")}";

            MessageBox.Show(details, $"Historical Record - {b.BookingId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PopulateBookingHistoryList()
        {
            lvBookingHistory.Items.Clear();

            var allBookings = BookingStore.GetAll();

            int total = allBookings.Count;
            int completed = allBookings.Count(b => b.BookingStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase) || b.TravelDate < DateTime.Today);
            int cancelled = allBookings.Count(b => b.BookingStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase));

            lblMetricHistoryTotalVal.Text = total.ToString();
            lblMetricHistoryCompletedVal.Text = completed.ToString();
            lblMetricHistoryCancelledVal.Text = cancelled.ToString();

            string search = txtSearchHistory.Text.Trim().ToLower();
            string statusFilter = cmbHistoryStatusFilter.SelectedItem?.ToString() ?? "All Records";

            var filtered = allBookings.Where(b =>
            {
                bool matchesSearch = string.IsNullOrEmpty(search) ||
                                     b.BookingId.ToLower().Contains(search) ||
                                     b.PassengerName.ToLower().Contains(search) ||
                                     b.PassengerPhone.ToLower().Contains(search) ||
                                     b.RouteName.ToLower().Contains(search) ||
                                     b.SeatNumbersDisplay.ToLower().Contains(search);

                bool matchesStatus = statusFilter switch
                {
                    "Completed" => b.BookingStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase) || b.TravelDate < DateTime.Today,
                    "Cancelled" => b.BookingStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase),
                    "Confirmed" => b.BookingStatus.Equals("Confirmed", StringComparison.OrdinalIgnoreCase),
                    "Pending" => b.BookingStatus.Equals("Pending", StringComparison.OrdinalIgnoreCase),
                    _ => true
                };

                return matchesSearch && matchesStatus;
            }).OrderByDescending(b => b.BookingDate).ToList();

            foreach (var b in filtered)
            {
                var item = new ListViewItem(b.BookingId);
                item.SubItems.Add(b.PassengerName);
                item.SubItems.Add(b.PassengerPhone);
                item.SubItems.Add(b.RouteName);
                item.SubItems.Add(b.TravelDate.ToString("yyyy-MM-dd"));
                item.SubItems.Add(b.DepartureTime);
                item.SubItems.Add(b.SeatNumbersDisplay);
                item.SubItems.Add($"{b.TotalAmount:N2} ETB");
                item.SubItems.Add(b.BookingStatus);
                item.SubItems.Add(b.PaymentStatus);

                if (b.BookingStatus.Equals("Cancelled", StringComparison.OrdinalIgnoreCase))
                {
                    item.ForeColor = Color.FromArgb(148, 163, 184);
                }

                lvBookingHistory.Items.Add(item);
            }

            lblHistoryCount.Text = $"Showing {filtered.Count} of {total} booking history records";
        }

        #endregion

        #region Print Helpers

        private void PrintBoardingPassPreview(string bookingId, string passenger, string route, string date, string time, string seats, decimal amount)
        {
            string pass = "================================================\n" +
                          "          DEBRE BERHAN BUS LINES                \n" +
                          "          OFFICIAL BOARDING PASS                \n" +
                          "================================================\n" +
                          $"BOOKING REF:  {bookingId}\n" +
                          $"PASSENGER:    {passenger}\n" +
                          $"ROUTE:        {route}\n" +
                          $"TRAVEL DATE:  {date}\n" +
                          $"DEPARTURE:    {time}\n" +
                          $"ASSIGNED SEAT(S): [ {seats} ]\n" +
                          $"TOTAL FARE:   {amount:N2} ETB\n" +
                          $"ISSUED BY:    {_officerName}\n" +
                          "------------------------------------------------\n" +
                          "Please present this pass at the boarding gate 30\n" +
                          "minutes before departure.\n" +
                          "================================================";

            MessageBox.Show(pass, $"Boarding Pass Preview - {bookingId}", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion
    }
}

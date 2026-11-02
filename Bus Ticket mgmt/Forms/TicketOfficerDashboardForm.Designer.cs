namespace Bus_Ticket_mgmt.Forms
{
    partial class TicketOfficerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnNavLogout = new Button();
            btnNavHistory = new Button();
            btnNavPayments = new Button();
            btnNavTickets = new Button();
            btnNavBookings = new Button();
            btnNavPassengers = new Button();
            panelPassengers = new Panel();
            panelPassengerActions = new Panel();
            lblPassengerCount = new Label();
            btnViewPassenger = new Button();
            btnEditPassenger = new Button();
            lvPassengers = new ListView();
            colPassId = new ColumnHeader();
            colPassFullName = new ColumnHeader();
            colPassUsername = new ColumnHeader();
            colPassEmail = new ColumnHeader();
            colPassPhone = new ColumnHeader();
            colPassAddress = new ColumnHeader();
            colPassStatus = new ColumnHeader();
            colPassCreatedDate = new ColumnHeader();
            panelPassengersToolbar = new Panel();
            btnRefreshPassengers = new Button();
            cmbPassengerStatusFilter = new ComboBox();
            txtSearchPassenger = new TextBox();
            flowPassengerMetrics = new FlowLayoutPanel();
            cardTotalPassengers = new Panel();
            lblMetricTotalPassengersVal = new Label();
            lblMetricTotalPassengersTitle = new Label();
            cardActivePassengers = new Panel();
            lblMetricActivePassengersVal = new Label();
            lblMetricActivePassengersTitle = new Label();
            cardNewPassengersToday = new Panel();
            lblMetricNewPassengersTodayVal = new Label();
            lblMetricNewPassengersTodayTitle = new Label();
            panelPassengersHeader = new Panel();
            btnAddPassenger = new Button();
            lblPassengersSubtitle = new Label();
            lblPassengersTitle = new Label();
            panelBookingHistory = new Panel();
            panelHistoryActions = new Panel();
            lblHistoryCount = new Label();
            btnPrintHistoryPass = new Button();
            btnViewHistoryDetails = new Button();
            lvBookingHistory = new ListView();
            colHistBookingId = new ColumnHeader();
            colHistPassengerName = new ColumnHeader();
            colHistPassengerPhone = new ColumnHeader();
            colHistRoute = new ColumnHeader();
            colHistTravelDate = new ColumnHeader();
            colHistDepartureTime = new ColumnHeader();
            colHistSeats = new ColumnHeader();
            colHistTotalAmount = new ColumnHeader();
            colHistBookingStatus = new ColumnHeader();
            colHistPaymentStatus = new ColumnHeader();
            panelHistoryToolbar = new Panel();
            btnRefreshHistory = new Button();
            cmbHistoryStatusFilter = new ComboBox();
            txtSearchHistory = new TextBox();
            flowHistoryMetrics = new FlowLayoutPanel();
            cardHistoryTotal = new Panel();
            lblMetricHistoryTotalVal = new Label();
            lblMetricHistoryTotalTitle = new Label();
            cardHistoryCompleted = new Panel();
            lblMetricHistoryCompletedVal = new Label();
            lblMetricHistoryCompletedTitle = new Label();
            cardHistoryCancelled = new Panel();
            lblMetricHistoryCancelledVal = new Label();
            lblMetricHistoryCancelledTitle = new Label();
            panelHistoryHeader = new Panel();
            lblHistoryTitle = new Label();
            panelTopBar = new Panel();
            lblAppIcon = new Label();
            lblPortalTitle = new Label();
            panelOfficerProfile = new Panel();
            lblOfficerName = new Label();
            lblOfficerRole = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            panelSidebar = new Panel();
            lblNavHeader = new Label();
            panelMain = new Panel();
            panelPayments = new Panel();
            panelPaymentActions = new Panel();
            lblPaymentCount = new Label();
            btnProcessRefund = new Button();
            btnRecordPayment = new Button();
            btnPrintReceipt = new Button();
            lvPayments = new ListView();
            colPayReceipt = new ColumnHeader();
            colPayBooking = new ColumnHeader();
            colPayTicket = new ColumnHeader();
            colPayPassenger = new ColumnHeader();
            colPayRoute = new ColumnHeader();
            colPayAmount = new ColumnHeader();
            colPayMethod = new ColumnHeader();
            colPayStatus = new ColumnHeader();
            colPayDate = new ColumnHeader();
            colPayCashier = new ColumnHeader();
            panelPaymentsToolbar = new Panel();
            btnRefreshPayments = new Button();
            cmbPaymentStatusFilter = new ComboBox();
            cmbPaymentMethodFilter = new ComboBox();
            txtSearchPayments = new TextBox();
            flowPaymentMetrics = new FlowLayoutPanel();
            cardPayTotal = new Panel();
            lblPayTotalVal = new Label();
            lblPayTotalTitle = new Label();
            cardPayCash = new Panel();
            lblPayCashVal = new Label();
            lblPayCashTitle = new Label();
            cardPayDigital = new Panel();
            lblPayDigitalVal = new Label();
            lblPayDigitalTitle = new Label();
            cardPayRefunds = new Panel();
            lblPayRefundsVal = new Label();
            lblPayRefundsTitle = new Label();
            panelPaymentsHeader = new Panel();
            lblPaymentsSubtitle = new Label();
            lblPaymentsTitle = new Label();
            panelTicketManagement = new Panel();
            panelTicketActions = new Panel();
            lblTicketCount = new Label();
            btnCancelTicketAction = new Button();
            btnPrintTicketPass = new Button();
            btnVerifyAndBoard = new Button();
            btnViewTicketDetails = new Button();
            lvTickets = new ListView();
            colTicketId = new ColumnHeader();
            colTicketBookingRef = new ColumnHeader();
            colTicketPassenger = new ColumnHeader();
            colTicketPhone = new ColumnHeader();
            colTicketRoute = new ColumnHeader();
            colTicketDate = new ColumnHeader();
            colTicketTime = new ColumnHeader();
            colTicketSeat = new ColumnHeader();
            colTicketGate = new ColumnHeader();
            colTicketBus = new ColumnHeader();
            colTicketStatus = new ColumnHeader();
            panelTicketsToolbar = new Panel();
            btnResetTicketFilters = new Button();
            dtpTicketFilterDate = new DateTimePicker();
            chkEnableTicketDateFilter = new CheckBox();
            cmbTicketRouteFilter = new ComboBox();
            cmbTicketStatusFilter = new ComboBox();
            txtSearchTicketFilter = new TextBox();
            flowTicketMetrics = new FlowLayoutPanel();
            cardTotalTickets = new Panel();
            lblMetricTotalTicketsVal = new Label();
            lblMetricTotalTicketsTitle = new Label();
            cardValidTickets = new Panel();
            lblMetricValidTicketsVal = new Label();
            lblMetricValidTicketsTitle = new Label();
            cardBoardedTickets = new Panel();
            lblMetricBoardedTicketsVal = new Label();
            lblMetricBoardedTicketsTitle = new Label();
            cardCancelledTickets = new Panel();
            lblMetricCancelledTicketsVal = new Label();
            lblMetricCancelledTicketsTitle = new Label();
            cardTodayTickets = new Panel();
            lblMetricTodayTicketsVal = new Label();
            lblMetricTodayTicketsTitle = new Label();
            panelTicketsHeader = new Panel();
            btnVerifyBoardModal = new Button();
            btnNewTicket = new Button();
            lblTicketsSubtitle = new Label();
            lblTicketsTitle = new Label();
            panelBookingManagement = new Panel();
            panelBookingActions = new Panel();
            lblBookingCount = new Label();
            btnPrintTicket = new Button();
            btnCancelBookingAction = new Button();
            btnModifyBooking = new Button();
            btnViewBookingDetails = new Button();
            lvBookings = new ListView();
            colBookingId = new ColumnHeader();
            colPassengerName = new ColumnHeader();
            colPassengerPhone = new ColumnHeader();
            colBookingRoute = new ColumnHeader();
            colTravelDate = new ColumnHeader();
            colDepartureTime = new ColumnHeader();
            colSeats = new ColumnHeader();
            colTotalAmount = new ColumnHeader();
            colBookingStatus = new ColumnHeader();
            colPaymentStatus = new ColumnHeader();
            panelBookingsToolbar = new Panel();
            btnResetBookingFilters = new Button();
            dtpBookingFilterDate = new DateTimePicker();
            chkEnableDateFilter = new CheckBox();
            cmbBookingRouteFilter = new ComboBox();
            cmbBookingStatusFilter = new ComboBox();
            txtSearchBooking = new TextBox();
            flowBookingMetrics = new FlowLayoutPanel();
            cardTotalBookings = new Panel();
            lblMetricTotalBookingsVal = new Label();
            lblMetricTotalBookingsTitle = new Label();
            cardConfirmedBookings = new Panel();
            lblMetricConfirmedBookingsVal = new Label();
            lblMetricConfirmedBookingsTitle = new Label();
            cardPendingBookings = new Panel();
            lblMetricPendingBookingsVal = new Label();
            lblMetricPendingBookingsTitle = new Label();
            cardCancelledBookings = new Panel();
            lblMetricCancelledBookingsVal = new Label();
            lblMetricCancelledBookingsTitle = new Label();
            cardTodayBookings = new Panel();
            lblMetricTodayBookingsVal = new Label();
            lblMetricTodayBookingsTitle = new Label();
            panelBookingsHeader = new Panel();
            btnNewBooking = new Button();
            lblBookingsSubtitle = new Label();
            lblBookingsTitle = new Label();
            panelHeaderInfo = new Panel();
            lblPageHeading = new Label();
            lblMetricTotalBookingsSub = new Label();
            lblMetricConfirmedBookingsSub = new Label();
            lblMetricPendingBookingsSub = new Label();
            lblMetricCancelledBookingsSub = new Label();
            lblMetricTodayBookingsSub = new Label();
            lblMetricTotalTicketsSub = new Label();
            lblMetricValidTicketsSub = new Label();
            lblMetricBoardedTicketsSub = new Label();
            lblMetricCancelledTicketsSub = new Label();
            lblMetricTodayTicketsSub = new Label();
            colManTicketId = new ColumnHeader();
            colManBookingId = new ColumnHeader();
            panelPassengers.SuspendLayout();
            panelPassengerActions.SuspendLayout();
            panelPassengersToolbar.SuspendLayout();
            flowPassengerMetrics.SuspendLayout();
            cardTotalPassengers.SuspendLayout();
            cardActivePassengers.SuspendLayout();
            cardNewPassengersToday.SuspendLayout();
            panelPassengersHeader.SuspendLayout();
            panelBookingHistory.SuspendLayout();
            panelHistoryActions.SuspendLayout();
            panelHistoryToolbar.SuspendLayout();
            flowHistoryMetrics.SuspendLayout();
            cardHistoryTotal.SuspendLayout();
            cardHistoryCompleted.SuspendLayout();
            cardHistoryCancelled.SuspendLayout();
            panelHistoryHeader.SuspendLayout();
            panelTopBar.SuspendLayout();
            panelOfficerProfile.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
            panelPayments.SuspendLayout();
            panelPaymentActions.SuspendLayout();
            panelPaymentsToolbar.SuspendLayout();
            flowPaymentMetrics.SuspendLayout();
            cardPayTotal.SuspendLayout();
            cardPayCash.SuspendLayout();
            cardPayDigital.SuspendLayout();
            cardPayRefunds.SuspendLayout();
            panelPaymentsHeader.SuspendLayout();
            panelTicketManagement.SuspendLayout();
            panelTicketActions.SuspendLayout();
            panelTicketsToolbar.SuspendLayout();
            flowTicketMetrics.SuspendLayout();
            cardTotalTickets.SuspendLayout();
            cardValidTickets.SuspendLayout();
            cardBoardedTickets.SuspendLayout();
            cardCancelledTickets.SuspendLayout();
            cardTodayTickets.SuspendLayout();
            panelTicketsHeader.SuspendLayout();
            panelBookingManagement.SuspendLayout();
            panelBookingActions.SuspendLayout();
            panelBookingsToolbar.SuspendLayout();
            flowBookingMetrics.SuspendLayout();
            cardTotalBookings.SuspendLayout();
            cardConfirmedBookings.SuspendLayout();
            cardPendingBookings.SuspendLayout();
            cardCancelledBookings.SuspendLayout();
            cardTodayBookings.SuspendLayout();
            panelBookingsHeader.SuspendLayout();
            panelHeaderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // btnNavLogout
            // 
            btnNavLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNavLogout.BackColor = Color.White;
            btnNavLogout.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavLogout.FlatAppearance.BorderSize = 2;
            btnNavLogout.FlatStyle = FlatStyle.Flat;
            btnNavLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNavLogout.ForeColor = Color.FromArgb(71, 85, 105);
            btnNavLogout.Location = new Point(20, 920);
            btnNavLogout.Margin = new Padding(4, 5, 4, 5);
            btnNavLogout.Name = "btnNavLogout";
            btnNavLogout.Padding = new Padding(29, 0, 0, 0);
            btnNavLogout.Size = new Size(360, 100);
            btnNavLogout.TabIndex = 0;
            btnNavLogout.Text = "🚪   Sign Out";
            btnNavLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLogout.UseVisualStyleBackColor = false;
            // 
            // btnNavHistory
            // 
            btnNavHistory.BackColor = Color.White;
            btnNavHistory.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavHistory.FlatAppearance.BorderSize = 2;
            btnNavHistory.FlatStyle = FlatStyle.Flat;
            btnNavHistory.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNavHistory.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavHistory.Location = new Point(20, 600);
            btnNavHistory.Margin = new Padding(4, 5, 4, 5);
            btnNavHistory.Name = "btnNavHistory";
            btnNavHistory.Padding = new Padding(29, 0, 0, 0);
            btnNavHistory.Size = new Size(360, 100);
            btnNavHistory.TabIndex = 1;
            btnNavHistory.Text = "📋   Booking History";
            btnNavHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnNavHistory.UseVisualStyleBackColor = false;
            // 
            // btnNavPayments
            // 
            btnNavPayments.BackColor = Color.White;
            btnNavPayments.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavPayments.FlatAppearance.BorderSize = 2;
            btnNavPayments.FlatStyle = FlatStyle.Flat;
            btnNavPayments.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNavPayments.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavPayments.Location = new Point(20, 467);
            btnNavPayments.Margin = new Padding(4, 5, 4, 5);
            btnNavPayments.Name = "btnNavPayments";
            btnNavPayments.Padding = new Padding(29, 0, 0, 0);
            btnNavPayments.Size = new Size(360, 100);
            btnNavPayments.TabIndex = 2;
            btnNavPayments.Text = "💳   Payments";
            btnNavPayments.TextAlign = ContentAlignment.MiddleLeft;
            btnNavPayments.UseVisualStyleBackColor = false;
            // 
            // btnNavTickets
            // 
            btnNavTickets.BackColor = Color.White;
            btnNavTickets.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavTickets.FlatAppearance.BorderSize = 2;
            btnNavTickets.FlatStyle = FlatStyle.Flat;
            btnNavTickets.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNavTickets.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavTickets.Location = new Point(20, 333);
            btnNavTickets.Margin = new Padding(4, 5, 4, 5);
            btnNavTickets.Name = "btnNavTickets";
            btnNavTickets.Padding = new Padding(29, 0, 0, 0);
            btnNavTickets.Size = new Size(360, 100);
            btnNavTickets.TabIndex = 3;
            btnNavTickets.Text = "🏷️   Tickets";
            btnNavTickets.TextAlign = ContentAlignment.MiddleLeft;
            btnNavTickets.UseVisualStyleBackColor = false;
            // 
            // btnNavBookings
            // 
            btnNavBookings.BackColor = Color.White;
            btnNavBookings.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavBookings.FlatAppearance.BorderSize = 2;
            btnNavBookings.FlatStyle = FlatStyle.Flat;
            btnNavBookings.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNavBookings.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavBookings.Location = new Point(20, 200);
            btnNavBookings.Margin = new Padding(4, 5, 4, 5);
            btnNavBookings.Name = "btnNavBookings";
            btnNavBookings.Padding = new Padding(29, 0, 0, 0);
            btnNavBookings.Size = new Size(360, 100);
            btnNavBookings.TabIndex = 4;
            btnNavBookings.Text = "🎫   Bookings";
            btnNavBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBookings.UseVisualStyleBackColor = false;
            // 
            // btnNavPassengers
            // 
            btnNavPassengers.BackColor = Color.White;
            btnNavPassengers.FlatAppearance.BorderColor = Color.FromArgb(15, 23, 42);
            btnNavPassengers.FlatAppearance.BorderSize = 2;
            btnNavPassengers.FlatStyle = FlatStyle.Flat;
            btnNavPassengers.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNavPassengers.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavPassengers.Location = new Point(20, 67);
            btnNavPassengers.Margin = new Padding(4, 5, 4, 5);
            btnNavPassengers.Name = "btnNavPassengers";
            btnNavPassengers.Padding = new Padding(29, 0, 0, 0);
            btnNavPassengers.Size = new Size(360, 100);
            btnNavPassengers.TabIndex = 5;
            btnNavPassengers.Text = "👥   Passengers";
            btnNavPassengers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavPassengers.UseVisualStyleBackColor = false;
            // 
            // panelPassengers
            // 
            panelPassengers.AutoScroll = true;
            panelPassengers.Controls.Add(panelPassengerActions);
            panelPassengers.Controls.Add(lvPassengers);
            panelPassengers.Controls.Add(panelPassengersToolbar);
            panelPassengers.Controls.Add(flowPassengerMetrics);
            panelPassengers.Controls.Add(panelPassengersHeader);
            panelPassengers.Dock = DockStyle.Fill;
            panelPassengers.Location = new Point(29, 120);
            panelPassengers.Margin = new Padding(4, 5, 4, 5);
            panelPassengers.Name = "panelPassengers";
            panelPassengers.Size = new Size(1488, 880);
            panelPassengers.TabIndex = 5;
            panelPassengers.Visible = false;
            // 
            // panelPassengerActions
            // 
            panelPassengerActions.BackColor = Color.White;
            panelPassengerActions.BorderStyle = BorderStyle.FixedSingle;
            panelPassengerActions.Controls.Add(lblPassengerCount);
            panelPassengerActions.Controls.Add(btnViewPassenger);
            panelPassengerActions.Controls.Add(btnEditPassenger);
            panelPassengerActions.Location = new Point(0, 997);
            panelPassengerActions.Margin = new Padding(4, 5, 4, 5);
            panelPassengerActions.Name = "panelPassengerActions";
            panelPassengerActions.Size = new Size(1392, 79);
            panelPassengerActions.TabIndex = 0;
            // 
            // lblPassengerCount
            // 
            lblPassengerCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPassengerCount.Font = new Font("Segoe UI", 9F);
            lblPassengerCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblPassengerCount.Location = new Point(1020, 23);
            lblPassengerCount.Margin = new Padding(4, 0, 4, 0);
            lblPassengerCount.Name = "lblPassengerCount";
            lblPassengerCount.Size = new Size(350, 33);
            lblPassengerCount.TabIndex = 0;
            lblPassengerCount.Text = "Showing 0 passengers";
            lblPassengerCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnViewPassenger
            // 
            btnViewPassenger.BackColor = Color.FromArgb(241, 245, 249);
            btnViewPassenger.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewPassenger.FlatStyle = FlatStyle.Flat;
            btnViewPassenger.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewPassenger.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewPassenger.Location = new Point(240, 13);
            btnViewPassenger.Margin = new Padding(4, 5, 4, 5);
            btnViewPassenger.Name = "btnViewPassenger";
            btnViewPassenger.Size = new Size(210, 53);
            btnViewPassenger.TabIndex = 1;
            btnViewPassenger.Text = "🔍  View Details";
            btnViewPassenger.UseVisualStyleBackColor = false;
            // 
            // btnEditPassenger
            // 
            btnEditPassenger.BackColor = Color.FromArgb(241, 245, 249);
            btnEditPassenger.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnEditPassenger.FlatStyle = FlatStyle.Flat;
            btnEditPassenger.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditPassenger.ForeColor = Color.FromArgb(30, 41, 59);
            btnEditPassenger.Location = new Point(17, 13);
            btnEditPassenger.Margin = new Padding(4, 5, 4, 5);
            btnEditPassenger.Name = "btnEditPassenger";
            btnEditPassenger.Size = new Size(210, 53);
            btnEditPassenger.TabIndex = 2;
            btnEditPassenger.Text = "✏️  Update Info";
            btnEditPassenger.UseVisualStyleBackColor = false;
            // 
            // lvPassengers
            // 
            lvPassengers.BorderStyle = BorderStyle.FixedSingle;
            lvPassengers.Columns.AddRange(new ColumnHeader[] { colPassId, colPassFullName, colPassUsername, colPassEmail, colPassPhone, colPassAddress, colPassStatus, colPassCreatedDate });
            lvPassengers.FullRowSelect = true;
            lvPassengers.GridLines = true;
            lvPassengers.Location = new Point(0, 350);
            lvPassengers.Margin = new Padding(4, 5, 4, 5);
            lvPassengers.MultiSelect = false;
            lvPassengers.Name = "lvPassengers";
            lvPassengers.Size = new Size(1391, 631);
            lvPassengers.TabIndex = 1;
            lvPassengers.UseCompatibleStateImageBehavior = false;
            lvPassengers.View = View.Details;
            // 
            // colPassId
            // 
            colPassId.Text = "Passenger ID";
            colPassId.Width = 120;
            // 
            // colPassFullName
            // 
            colPassFullName.Text = "Full Name";
            colPassFullName.Width = 180;
            // 
            // colPassUsername
            // 
            colPassUsername.Text = "Username";
            colPassUsername.Width = 130;
            // 
            // colPassEmail
            // 
            colPassEmail.Text = "Email Address";
            colPassEmail.Width = 180;
            // 
            // colPassPhone
            // 
            colPassPhone.Text = "Phone Number";
            colPassPhone.Width = 150;
            // 
            // colPassAddress
            // 
            colPassAddress.Text = "Address / City";
            colPassAddress.Width = 180;
            // 
            // colPassStatus
            // 
            colPassStatus.Text = "Status";
            colPassStatus.Width = 100;
            // 
            // colPassCreatedDate
            // 
            colPassCreatedDate.Text = "Registered Date";
            colPassCreatedDate.Width = 140;
            // 
            // panelPassengersToolbar
            // 
            panelPassengersToolbar.BackColor = Color.White;
            panelPassengersToolbar.BorderStyle = BorderStyle.FixedSingle;
            panelPassengersToolbar.Controls.Add(btnRefreshPassengers);
            panelPassengersToolbar.Controls.Add(cmbPassengerStatusFilter);
            panelPassengersToolbar.Controls.Add(txtSearchPassenger);
            panelPassengersToolbar.Location = new Point(0, 257);
            panelPassengersToolbar.Margin = new Padding(4, 5, 4, 5);
            panelPassengersToolbar.Name = "panelPassengersToolbar";
            panelPassengersToolbar.Size = new Size(1392, 79);
            panelPassengersToolbar.TabIndex = 2;
            // 
            // btnRefreshPassengers
            // 
            btnRefreshPassengers.BackColor = Color.White;
            btnRefreshPassengers.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefreshPassengers.FlatStyle = FlatStyle.Flat;
            btnRefreshPassengers.Location = new Point(800, 18);
            btnRefreshPassengers.Margin = new Padding(4, 5, 4, 5);
            btnRefreshPassengers.Name = "btnRefreshPassengers";
            btnRefreshPassengers.Size = new Size(120, 43);
            btnRefreshPassengers.TabIndex = 0;
            btnRefreshPassengers.Text = "Refresh";
            btnRefreshPassengers.UseVisualStyleBackColor = false;
            // 
            // cmbPassengerStatusFilter
            // 
            cmbPassengerStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPassengerStatusFilter.FormattingEnabled = true;
            cmbPassengerStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Inactive" });
            cmbPassengerStatusFilter.Location = new Point(500, 20);
            cmbPassengerStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbPassengerStatusFilter.Name = "cmbPassengerStatusFilter";
            cmbPassengerStatusFilter.Size = new Size(260, 33);
            cmbPassengerStatusFilter.TabIndex = 1;
            // 
            // txtSearchPassenger
            // 
            txtSearchPassenger.Location = new Point(20, 20);
            txtSearchPassenger.Margin = new Padding(4, 5, 4, 5);
            txtSearchPassenger.Name = "txtSearchPassenger";
            txtSearchPassenger.PlaceholderText = "Search by ID, name, phone, email...";
            txtSearchPassenger.Size = new Size(450, 31);
            txtSearchPassenger.TabIndex = 2;
            // 
            // flowPassengerMetrics
            // 
            flowPassengerMetrics.Controls.Add(cardTotalPassengers);
            flowPassengerMetrics.Controls.Add(cardActivePassengers);
            flowPassengerMetrics.Controls.Add(cardNewPassengersToday);
            flowPassengerMetrics.Location = new Point(0, 107);
            flowPassengerMetrics.Margin = new Padding(4, 5, 4, 5);
            flowPassengerMetrics.Name = "flowPassengerMetrics";
            flowPassengerMetrics.Size = new Size(1407, 147);
            flowPassengerMetrics.TabIndex = 3;
            // 
            // cardTotalPassengers
            // 
            cardTotalPassengers.BackColor = Color.White;
            cardTotalPassengers.BorderStyle = BorderStyle.FixedSingle;
            cardTotalPassengers.Controls.Add(lblMetricTotalPassengersVal);
            cardTotalPassengers.Controls.Add(lblMetricTotalPassengersTitle);
            cardTotalPassengers.Location = new Point(0, 0);
            cardTotalPassengers.Margin = new Padding(0, 0, 20, 0);
            cardTotalPassengers.Name = "cardTotalPassengers";
            cardTotalPassengers.Size = new Size(319, 139);
            cardTotalPassengers.TabIndex = 0;
            // 
            // lblMetricTotalPassengersVal
            // 
            lblMetricTotalPassengersVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricTotalPassengersVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalPassengersVal.Location = new Point(16, 13);
            lblMetricTotalPassengersVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalPassengersVal.Name = "lblMetricTotalPassengersVal";
            lblMetricTotalPassengersVal.Size = new Size(286, 53);
            lblMetricTotalPassengersVal.TabIndex = 0;
            lblMetricTotalPassengersVal.Text = "0";
            // 
            // lblMetricTotalPassengersTitle
            // 
            lblMetricTotalPassengersTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTotalPassengersTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricTotalPassengersTitle.Location = new Point(17, 73);
            lblMetricTotalPassengersTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalPassengersTitle.Name = "lblMetricTotalPassengersTitle";
            lblMetricTotalPassengersTitle.Size = new Size(286, 30);
            lblMetricTotalPassengersTitle.TabIndex = 1;
            lblMetricTotalPassengersTitle.Text = "TOTAL PASSENGERS";
            // 
            // cardActivePassengers
            // 
            cardActivePassengers.BackColor = Color.White;
            cardActivePassengers.BorderStyle = BorderStyle.FixedSingle;
            cardActivePassengers.Controls.Add(lblMetricActivePassengersVal);
            cardActivePassengers.Controls.Add(lblMetricActivePassengersTitle);
            cardActivePassengers.Location = new Point(339, 0);
            cardActivePassengers.Margin = new Padding(0, 0, 20, 0);
            cardActivePassengers.Name = "cardActivePassengers";
            cardActivePassengers.Size = new Size(319, 139);
            cardActivePassengers.TabIndex = 1;
            // 
            // lblMetricActivePassengersVal
            // 
            lblMetricActivePassengersVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricActivePassengersVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricActivePassengersVal.Location = new Point(16, 13);
            lblMetricActivePassengersVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricActivePassengersVal.Name = "lblMetricActivePassengersVal";
            lblMetricActivePassengersVal.Size = new Size(286, 53);
            lblMetricActivePassengersVal.TabIndex = 0;
            lblMetricActivePassengersVal.Text = "0";
            // 
            // lblMetricActivePassengersTitle
            // 
            lblMetricActivePassengersTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricActivePassengersTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricActivePassengersTitle.Location = new Point(17, 73);
            lblMetricActivePassengersTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricActivePassengersTitle.Name = "lblMetricActivePassengersTitle";
            lblMetricActivePassengersTitle.Size = new Size(286, 30);
            lblMetricActivePassengersTitle.TabIndex = 1;
            lblMetricActivePassengersTitle.Text = "ACTIVE ACCOUNTS";
            // 
            // cardNewPassengersToday
            // 
            cardNewPassengersToday.BackColor = Color.White;
            cardNewPassengersToday.BorderStyle = BorderStyle.FixedSingle;
            cardNewPassengersToday.Controls.Add(lblMetricNewPassengersTodayVal);
            cardNewPassengersToday.Controls.Add(lblMetricNewPassengersTodayTitle);
            cardNewPassengersToday.Location = new Point(678, 0);
            cardNewPassengersToday.Margin = new Padding(0, 0, 20, 0);
            cardNewPassengersToday.Name = "cardNewPassengersToday";
            cardNewPassengersToday.Size = new Size(319, 139);
            cardNewPassengersToday.TabIndex = 2;
            // 
            // lblMetricNewPassengersTodayVal
            // 
            lblMetricNewPassengersTodayVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricNewPassengersTodayVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricNewPassengersTodayVal.Location = new Point(16, 13);
            lblMetricNewPassengersTodayVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricNewPassengersTodayVal.Name = "lblMetricNewPassengersTodayVal";
            lblMetricNewPassengersTodayVal.Size = new Size(286, 53);
            lblMetricNewPassengersTodayVal.TabIndex = 0;
            lblMetricNewPassengersTodayVal.Text = "0";
            // 
            // lblMetricNewPassengersTodayTitle
            // 
            lblMetricNewPassengersTodayTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricNewPassengersTodayTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricNewPassengersTodayTitle.Location = new Point(17, 73);
            lblMetricNewPassengersTodayTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricNewPassengersTodayTitle.Name = "lblMetricNewPassengersTodayTitle";
            lblMetricNewPassengersTodayTitle.Size = new Size(286, 30);
            lblMetricNewPassengersTodayTitle.TabIndex = 1;
            lblMetricNewPassengersTodayTitle.Text = "REGISTERED TODAY";
            // 
            // panelPassengersHeader
            // 
            panelPassengersHeader.Controls.Add(btnAddPassenger);
            panelPassengersHeader.Controls.Add(lblPassengersSubtitle);
            panelPassengersHeader.Controls.Add(lblPassengersTitle);
            panelPassengersHeader.Dock = DockStyle.Top;
            panelPassengersHeader.Location = new Point(0, 0);
            panelPassengersHeader.Margin = new Padding(4, 5, 4, 5);
            panelPassengersHeader.Name = "panelPassengersHeader";
            panelPassengersHeader.Size = new Size(1462, 100);
            panelPassengersHeader.TabIndex = 4;
            // 
            // btnAddPassenger
            // 
            btnAddPassenger.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddPassenger.BackColor = Color.FromArgb(15, 23, 42);
            btnAddPassenger.FlatAppearance.BorderSize = 0;
            btnAddPassenger.FlatStyle = FlatStyle.Flat;
            btnAddPassenger.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAddPassenger.ForeColor = Color.White;
            btnAddPassenger.Location = new Point(1177, 23);
            btnAddPassenger.Margin = new Padding(4, 5, 4, 5);
            btnAddPassenger.Name = "btnAddPassenger";
            btnAddPassenger.Size = new Size(264, 57);
            btnAddPassenger.TabIndex = 0;
            btnAddPassenger.Text = "➕  Register Passenger";
            btnAddPassenger.UseVisualStyleBackColor = false;
            // 
            // lblPassengersSubtitle
            // 
            lblPassengersSubtitle.AutoSize = true;
            lblPassengersSubtitle.Font = new Font("Segoe UI", 9F);
            lblPassengersSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblPassengersSubtitle.Location = new Point(3, 55);
            lblPassengersSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblPassengersSubtitle.Name = "lblPassengersSubtitle";
            lblPassengersSubtitle.Size = new Size(607, 25);
            lblPassengersSubtitle.TabIndex = 1;
            lblPassengersSubtitle.Text = "Register new passengers, search directory, and update travel customer info.";
            // 
            // lblPassengersTitle
            // 
            lblPassengersTitle.AutoSize = true;
            lblPassengersTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPassengersTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblPassengersTitle.Location = new Point(0, 7);
            lblPassengersTitle.Margin = new Padding(4, 0, 4, 0);
            lblPassengersTitle.Name = "lblPassengersTitle";
            lblPassengersTitle.Size = new Size(330, 38);
            lblPassengersTitle.TabIndex = 2;
            lblPassengersTitle.Text = "Passenger Management";
            // 
            // panelBookingHistory
            // 
            panelBookingHistory.AutoScroll = true;
            panelBookingHistory.Controls.Add(panelHistoryActions);
            panelBookingHistory.Controls.Add(lvBookingHistory);
            panelBookingHistory.Controls.Add(panelHistoryToolbar);
            panelBookingHistory.Controls.Add(flowHistoryMetrics);
            panelBookingHistory.Controls.Add(panelHistoryHeader);
            panelBookingHistory.Dock = DockStyle.Fill;
            panelBookingHistory.Location = new Point(29, 120);
            panelBookingHistory.Margin = new Padding(4, 5, 4, 5);
            panelBookingHistory.Name = "panelBookingHistory";
            panelBookingHistory.Size = new Size(1488, 880);
            panelBookingHistory.TabIndex = 6;
            panelBookingHistory.Visible = false;
            // 
            // panelHistoryActions
            // 
            panelHistoryActions.BackColor = Color.White;
            panelHistoryActions.BorderStyle = BorderStyle.FixedSingle;
            panelHistoryActions.Controls.Add(lblHistoryCount);
            panelHistoryActions.Controls.Add(btnPrintHistoryPass);
            panelHistoryActions.Controls.Add(btnViewHistoryDetails);
            panelHistoryActions.Location = new Point(0, 997);
            panelHistoryActions.Margin = new Padding(4, 5, 4, 5);
            panelHistoryActions.Name = "panelHistoryActions";
            panelHistoryActions.Size = new Size(1392, 79);
            panelHistoryActions.TabIndex = 0;
            // 
            // lblHistoryCount
            // 
            lblHistoryCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblHistoryCount.Font = new Font("Segoe UI", 9F);
            lblHistoryCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblHistoryCount.Location = new Point(1020, 23);
            lblHistoryCount.Margin = new Padding(4, 0, 4, 0);
            lblHistoryCount.Name = "lblHistoryCount";
            lblHistoryCount.Size = new Size(350, 33);
            lblHistoryCount.TabIndex = 0;
            lblHistoryCount.Text = "Showing 0 historical records";
            lblHistoryCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPrintHistoryPass
            // 
            btnPrintHistoryPass.BackColor = Color.FromArgb(241, 245, 249);
            btnPrintHistoryPass.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnPrintHistoryPass.FlatStyle = FlatStyle.Flat;
            btnPrintHistoryPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrintHistoryPass.ForeColor = Color.FromArgb(30, 41, 59);
            btnPrintHistoryPass.Location = new Point(240, 13);
            btnPrintHistoryPass.Margin = new Padding(4, 5, 4, 5);
            btnPrintHistoryPass.Name = "btnPrintHistoryPass";
            btnPrintHistoryPass.Size = new Size(210, 53);
            btnPrintHistoryPass.TabIndex = 1;
            btnPrintHistoryPass.Text = "🖨️  Reprint Pass";
            btnPrintHistoryPass.UseVisualStyleBackColor = false;
            // 
            // btnViewHistoryDetails
            // 
            btnViewHistoryDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewHistoryDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewHistoryDetails.FlatStyle = FlatStyle.Flat;
            btnViewHistoryDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewHistoryDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewHistoryDetails.Location = new Point(17, 13);
            btnViewHistoryDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewHistoryDetails.Name = "btnViewHistoryDetails";
            btnViewHistoryDetails.Size = new Size(210, 53);
            btnViewHistoryDetails.TabIndex = 2;
            btnViewHistoryDetails.Text = "🔍  View Record";
            btnViewHistoryDetails.UseVisualStyleBackColor = false;
            // 
            // lvBookingHistory
            // 
            lvBookingHistory.BorderStyle = BorderStyle.FixedSingle;
            lvBookingHistory.Columns.AddRange(new ColumnHeader[] { colHistBookingId, colHistPassengerName, colHistPassengerPhone, colHistRoute, colHistTravelDate, colHistDepartureTime, colHistSeats, colHistTotalAmount, colHistBookingStatus, colHistPaymentStatus });
            lvBookingHistory.FullRowSelect = true;
            lvBookingHistory.GridLines = true;
            lvBookingHistory.Location = new Point(0, 350);
            lvBookingHistory.Margin = new Padding(4, 5, 4, 5);
            lvBookingHistory.MultiSelect = false;
            lvBookingHistory.Name = "lvBookingHistory";
            lvBookingHistory.Size = new Size(1391, 631);
            lvBookingHistory.TabIndex = 1;
            lvBookingHistory.UseCompatibleStateImageBehavior = false;
            lvBookingHistory.View = View.Details;
            // 
            // colHistBookingId
            // 
            colHistBookingId.Text = "Booking ID";
            colHistBookingId.Width = 110;
            // 
            // colHistPassengerName
            // 
            colHistPassengerName.Text = "Passenger Name";
            colHistPassengerName.Width = 180;
            // 
            // colHistPassengerPhone
            // 
            colHistPassengerPhone.Text = "Phone Number";
            colHistPassengerPhone.Width = 140;
            // 
            // colHistRoute
            // 
            colHistRoute.Text = "Route";
            colHistRoute.Width = 180;
            // 
            // colHistTravelDate
            // 
            colHistTravelDate.Text = "Travel Date";
            colHistTravelDate.Width = 120;
            // 
            // colHistDepartureTime
            // 
            colHistDepartureTime.Text = "Time";
            colHistDepartureTime.Width = 90;
            // 
            // colHistSeats
            // 
            colHistSeats.Text = "Seats";
            colHistSeats.Width = 100;
            // 
            // colHistTotalAmount
            // 
            colHistTotalAmount.Text = "Fare (ETB)";
            colHistTotalAmount.Width = 110;
            // 
            // colHistBookingStatus
            // 
            colHistBookingStatus.Text = "Booking Status";
            colHistBookingStatus.Width = 130;
            // 
            // colHistPaymentStatus
            // 
            colHistPaymentStatus.Text = "Payment";
            colHistPaymentStatus.Width = 110;
            // 
            // panelHistoryToolbar
            // 
            panelHistoryToolbar.BackColor = Color.White;
            panelHistoryToolbar.BorderStyle = BorderStyle.FixedSingle;
            panelHistoryToolbar.Controls.Add(btnRefreshHistory);
            panelHistoryToolbar.Controls.Add(cmbHistoryStatusFilter);
            panelHistoryToolbar.Controls.Add(txtSearchHistory);
            panelHistoryToolbar.Location = new Point(0, 257);
            panelHistoryToolbar.Margin = new Padding(4, 5, 4, 5);
            panelHistoryToolbar.Name = "panelHistoryToolbar";
            panelHistoryToolbar.Size = new Size(1392, 79);
            panelHistoryToolbar.TabIndex = 2;
            // 
            // btnRefreshHistory
            // 
            btnRefreshHistory.BackColor = Color.White;
            btnRefreshHistory.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefreshHistory.FlatStyle = FlatStyle.Flat;
            btnRefreshHistory.Location = new Point(800, 18);
            btnRefreshHistory.Margin = new Padding(4, 5, 4, 5);
            btnRefreshHistory.Name = "btnRefreshHistory";
            btnRefreshHistory.Size = new Size(120, 43);
            btnRefreshHistory.TabIndex = 0;
            btnRefreshHistory.Text = "Refresh";
            btnRefreshHistory.UseVisualStyleBackColor = false;
            // 
            // cmbHistoryStatusFilter
            // 
            cmbHistoryStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbHistoryStatusFilter.FormattingEnabled = true;
            cmbHistoryStatusFilter.Items.AddRange(new object[] { "All Historical", "Completed / Traveled", "Cancelled" });
            cmbHistoryStatusFilter.Location = new Point(500, 20);
            cmbHistoryStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbHistoryStatusFilter.Name = "cmbHistoryStatusFilter";
            cmbHistoryStatusFilter.Size = new Size(260, 33);
            cmbHistoryStatusFilter.TabIndex = 1;
            // 
            // txtSearchHistory
            // 
            txtSearchHistory.Location = new Point(20, 20);
            txtSearchHistory.Margin = new Padding(4, 5, 4, 5);
            txtSearchHistory.Name = "txtSearchHistory";
            txtSearchHistory.PlaceholderText = "Search by booking ID, passenger, phone, route...";
            txtSearchHistory.Size = new Size(450, 31);
            txtSearchHistory.TabIndex = 2;
            // 
            // flowHistoryMetrics
            // 
            flowHistoryMetrics.Controls.Add(cardHistoryTotal);
            flowHistoryMetrics.Controls.Add(cardHistoryCompleted);
            flowHistoryMetrics.Controls.Add(cardHistoryCancelled);
            flowHistoryMetrics.Location = new Point(0, 107);
            flowHistoryMetrics.Margin = new Padding(4, 5, 4, 5);
            flowHistoryMetrics.Name = "flowHistoryMetrics";
            flowHistoryMetrics.Size = new Size(1407, 147);
            flowHistoryMetrics.TabIndex = 3;
            // 
            // cardHistoryTotal
            // 
            cardHistoryTotal.BackColor = Color.White;
            cardHistoryTotal.BorderStyle = BorderStyle.FixedSingle;
            cardHistoryTotal.Controls.Add(lblMetricHistoryTotalVal);
            cardHistoryTotal.Controls.Add(lblMetricHistoryTotalTitle);
            cardHistoryTotal.Location = new Point(0, 0);
            cardHistoryTotal.Margin = new Padding(0, 0, 20, 0);
            cardHistoryTotal.Name = "cardHistoryTotal";
            cardHistoryTotal.Size = new Size(319, 139);
            cardHistoryTotal.TabIndex = 0;
            // 
            // lblMetricHistoryTotalVal
            // 
            lblMetricHistoryTotalVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricHistoryTotalVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricHistoryTotalVal.Location = new Point(16, 13);
            lblMetricHistoryTotalVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricHistoryTotalVal.Name = "lblMetricHistoryTotalVal";
            lblMetricHistoryTotalVal.Size = new Size(286, 53);
            lblMetricHistoryTotalVal.TabIndex = 0;
            lblMetricHistoryTotalVal.Text = "0";
            // 
            // lblMetricHistoryTotalTitle
            // 
            lblMetricHistoryTotalTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricHistoryTotalTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricHistoryTotalTitle.Location = new Point(17, 73);
            lblMetricHistoryTotalTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricHistoryTotalTitle.Name = "lblMetricHistoryTotalTitle";
            lblMetricHistoryTotalTitle.Size = new Size(286, 30);
            lblMetricHistoryTotalTitle.TabIndex = 1;
            lblMetricHistoryTotalTitle.Text = "TOTAL ARCHIVED";
            // 
            // cardHistoryCompleted
            // 
            cardHistoryCompleted.BackColor = Color.White;
            cardHistoryCompleted.BorderStyle = BorderStyle.FixedSingle;
            cardHistoryCompleted.Controls.Add(lblMetricHistoryCompletedVal);
            cardHistoryCompleted.Controls.Add(lblMetricHistoryCompletedTitle);
            cardHistoryCompleted.Location = new Point(339, 0);
            cardHistoryCompleted.Margin = new Padding(0, 0, 20, 0);
            cardHistoryCompleted.Name = "cardHistoryCompleted";
            cardHistoryCompleted.Size = new Size(319, 139);
            cardHistoryCompleted.TabIndex = 1;
            // 
            // lblMetricHistoryCompletedVal
            // 
            lblMetricHistoryCompletedVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricHistoryCompletedVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricHistoryCompletedVal.Location = new Point(16, 13);
            lblMetricHistoryCompletedVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricHistoryCompletedVal.Name = "lblMetricHistoryCompletedVal";
            lblMetricHistoryCompletedVal.Size = new Size(286, 53);
            lblMetricHistoryCompletedVal.TabIndex = 0;
            lblMetricHistoryCompletedVal.Text = "0";
            // 
            // lblMetricHistoryCompletedTitle
            // 
            lblMetricHistoryCompletedTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricHistoryCompletedTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricHistoryCompletedTitle.Location = new Point(17, 73);
            lblMetricHistoryCompletedTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricHistoryCompletedTitle.Name = "lblMetricHistoryCompletedTitle";
            lblMetricHistoryCompletedTitle.Size = new Size(286, 30);
            lblMetricHistoryCompletedTitle.TabIndex = 1;
            lblMetricHistoryCompletedTitle.Text = "COMPLETED TRIPS";
            // 
            // cardHistoryCancelled
            // 
            cardHistoryCancelled.BackColor = Color.White;
            cardHistoryCancelled.BorderStyle = BorderStyle.FixedSingle;
            cardHistoryCancelled.Controls.Add(lblMetricHistoryCancelledVal);
            cardHistoryCancelled.Controls.Add(lblMetricHistoryCancelledTitle);
            cardHistoryCancelled.Location = new Point(678, 0);
            cardHistoryCancelled.Margin = new Padding(0, 0, 20, 0);
            cardHistoryCancelled.Name = "cardHistoryCancelled";
            cardHistoryCancelled.Size = new Size(319, 139);
            cardHistoryCancelled.TabIndex = 2;
            // 
            // lblMetricHistoryCancelledVal
            // 
            lblMetricHistoryCancelledVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricHistoryCancelledVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricHistoryCancelledVal.Location = new Point(16, 13);
            lblMetricHistoryCancelledVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricHistoryCancelledVal.Name = "lblMetricHistoryCancelledVal";
            lblMetricHistoryCancelledVal.Size = new Size(286, 53);
            lblMetricHistoryCancelledVal.TabIndex = 0;
            lblMetricHistoryCancelledVal.Text = "0";
            // 
            // lblMetricHistoryCancelledTitle
            // 
            lblMetricHistoryCancelledTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricHistoryCancelledTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricHistoryCancelledTitle.Location = new Point(17, 73);
            lblMetricHistoryCancelledTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricHistoryCancelledTitle.Name = "lblMetricHistoryCancelledTitle";
            lblMetricHistoryCancelledTitle.Size = new Size(286, 30);
            lblMetricHistoryCancelledTitle.TabIndex = 1;
            lblMetricHistoryCancelledTitle.Text = "CANCELLED BOOKINGS";
            // 
            // panelHistoryHeader
            // 
            panelHistoryHeader.Controls.Add(lblHistoryTitle);
            panelHistoryHeader.Dock = DockStyle.Top;
            panelHistoryHeader.Location = new Point(0, 0);
            panelHistoryHeader.Margin = new Padding(4, 5, 4, 5);
            panelHistoryHeader.Name = "panelHistoryHeader";
            panelHistoryHeader.Size = new Size(1462, 100);
            panelHistoryHeader.TabIndex = 4;
            // 
            // lblHistoryTitle
            // 
            lblHistoryTitle.AutoSize = true;
            lblHistoryTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHistoryTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblHistoryTitle.Location = new Point(0, 7);
            lblHistoryTitle.Margin = new Padding(4, 0, 4, 0);
            lblHistoryTitle.Name = "lblHistoryTitle";
            lblHistoryTitle.Size = new Size(338, 38);
            lblHistoryTitle.TabIndex = 1;
            lblHistoryTitle.Text = "Booking History Archive";
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(15, 23, 42);
            panelTopBar.Controls.Add(lblAppIcon);
            panelTopBar.Controls.Add(lblPortalTitle);
            panelTopBar.Controls.Add(panelOfficerProfile);
            panelTopBar.Controls.Add(btnMinimize);
            panelTopBar.Controls.Add(btnMaximize);
            panelTopBar.Controls.Add(btnClose);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Margin = new Padding(4, 5, 4, 5);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1946, 73);
            panelTopBar.TabIndex = 0;
            // 
            // lblAppIcon
            // 
            lblAppIcon.Location = new Point(20, 7);
            lblAppIcon.Margin = new Padding(4, 0, 4, 0);
            lblAppIcon.Name = "lblAppIcon";
            lblAppIcon.Size = new Size(46, 60);
            lblAppIcon.TabIndex = 0;
            // 
            // lblPortalTitle
            // 
            lblPortalTitle.AutoSize = true;
            lblPortalTitle.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblPortalTitle.ForeColor = Color.White;
            lblPortalTitle.Location = new Point(74, 20);
            lblPortalTitle.Margin = new Padding(4, 0, 4, 0);
            lblPortalTitle.Name = "lblPortalTitle";
            lblPortalTitle.Size = new Size(477, 30);
            lblPortalTitle.TabIndex = 1;
            lblPortalTitle.Text = "Bus Ticket Management  |  Ticket Officer Portal";
            // 
            // panelOfficerProfile
            // 
            panelOfficerProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelOfficerProfile.Controls.Add(lblOfficerName);
            panelOfficerProfile.Controls.Add(lblOfficerRole);
            panelOfficerProfile.Location = new Point(1432, 7);
            panelOfficerProfile.Margin = new Padding(4, 5, 4, 5);
            panelOfficerProfile.Name = "panelOfficerProfile";
            panelOfficerProfile.Size = new Size(300, 60);
            panelOfficerProfile.TabIndex = 2;
            // 
            // lblOfficerName
            // 
            lblOfficerName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOfficerName.ForeColor = Color.White;
            lblOfficerName.Location = new Point(0, 3);
            lblOfficerName.Margin = new Padding(4, 0, 4, 0);
            lblOfficerName.Name = "lblOfficerName";
            lblOfficerName.Size = new Size(286, 27);
            lblOfficerName.TabIndex = 0;
            lblOfficerName.Text = "Marta Tadesse";
            lblOfficerName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblOfficerRole
            // 
            lblOfficerRole.Font = new Font("Segoe UI", 8F);
            lblOfficerRole.ForeColor = Color.FromArgb(148, 163, 184);
            lblOfficerRole.Location = new Point(0, 30);
            lblOfficerRole.Margin = new Padding(4, 0, 4, 0);
            lblOfficerRole.Name = "lblOfficerRole";
            lblOfficerRole.Size = new Size(286, 23);
            lblOfficerRole.TabIndex = 1;
            lblOfficerRole.Text = "Ticket Officer • Terminal Desk 01";
            lblOfficerRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 10F);
            btnMinimize.ForeColor = Color.FromArgb(148, 163, 184);
            btnMinimize.Location = new Point(1748, 0);
            btnMinimize.Margin = new Padding(4, 5, 4, 5);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(66, 73);
            btnMinimize.TabIndex = 3;
            btnMinimize.Text = "—";
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            btnMaximize.Dock = DockStyle.Right;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Segoe UI", 10.5F);
            btnMaximize.ForeColor = Color.FromArgb(148, 163, 184);
            btnMaximize.Location = new Point(1814, 0);
            btnMaximize.Margin = new Padding(4, 5, 4, 5);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(66, 73);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "□";
            btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F);
            btnClose.ForeColor = Color.FromArgb(148, 163, 184);
            btnClose.Location = new Point(1880, 0);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 73);
            btnClose.TabIndex = 5;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.FromArgb(245, 247, 250);
            panelSidebar.Controls.Add(btnNavLogout);
            panelSidebar.Controls.Add(btnNavHistory);
            panelSidebar.Controls.Add(btnNavPayments);
            panelSidebar.Controls.Add(btnNavTickets);
            panelSidebar.Controls.Add(btnNavBookings);
            panelSidebar.Controls.Add(btnNavPassengers);
            panelSidebar.Controls.Add(lblNavHeader);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 73);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(400, 1033);
            panelSidebar.TabIndex = 1;
            // 
            // lblNavHeader
            // 
            lblNavHeader.AutoSize = true;
            lblNavHeader.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblNavHeader.ForeColor = Color.FromArgb(100, 116, 139);
            lblNavHeader.Location = new Point(23, 27);
            lblNavHeader.Margin = new Padding(4, 0, 4, 0);
            lblNavHeader.Name = "lblNavHeader";
            lblNavHeader.Size = new Size(187, 21);
            lblNavHeader.TabIndex = 9;
            lblNavHeader.Text = "TERMINAL DESK MENU";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 250, 252);
            panelMain.Controls.Add(panelBookingHistory);
            panelMain.Controls.Add(panelPayments);
            panelMain.Controls.Add(panelTicketManagement);
            panelMain.Controls.Add(panelBookingManagement);
            panelMain.Controls.Add(panelPassengers);
            panelMain.Controls.Add(panelHeaderInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(400, 73);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(29, 27, 29, 33);
            panelMain.Size = new Size(1546, 1033);
            panelMain.TabIndex = 0;
            // 
            // panelPayments
            // 
            panelPayments.AutoScroll = true;
            panelPayments.Controls.Add(panelPaymentActions);
            panelPayments.Controls.Add(lvPayments);
            panelPayments.Controls.Add(panelPaymentsToolbar);
            panelPayments.Controls.Add(flowPaymentMetrics);
            panelPayments.Controls.Add(panelPaymentsHeader);
            panelPayments.Dock = DockStyle.Fill;
            panelPayments.Location = new Point(29, 120);
            panelPayments.Margin = new Padding(4, 5, 4, 5);
            panelPayments.Name = "panelPayments";
            panelPayments.Size = new Size(1488, 880);
            panelPayments.TabIndex = 1;
            panelPayments.Visible = false;
            // 
            // panelPaymentActions
            // 
            panelPaymentActions.BackColor = Color.White;
            panelPaymentActions.BorderStyle = BorderStyle.FixedSingle;
            panelPaymentActions.Controls.Add(lblPaymentCount);
            panelPaymentActions.Controls.Add(btnProcessRefund);
            panelPaymentActions.Controls.Add(btnRecordPayment);
            panelPaymentActions.Controls.Add(btnPrintReceipt);
            panelPaymentActions.Location = new Point(0, 997);
            panelPaymentActions.Margin = new Padding(4, 5, 4, 5);
            panelPaymentActions.Name = "panelPaymentActions";
            panelPaymentActions.Size = new Size(1392, 79);
            panelPaymentActions.TabIndex = 0;
            // 
            // lblPaymentCount
            // 
            lblPaymentCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPaymentCount.Font = new Font("Segoe UI", 8.5F);
            lblPaymentCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblPaymentCount.Location = new Point(1071, 23);
            lblPaymentCount.Margin = new Padding(4, 0, 4, 0);
            lblPaymentCount.Name = "lblPaymentCount";
            lblPaymentCount.Size = new Size(300, 33);
            lblPaymentCount.TabIndex = 0;
            lblPaymentCount.Text = "Showing 0 transactions";
            lblPaymentCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnProcessRefund
            // 
            btnProcessRefund.BackColor = Color.White;
            btnProcessRefund.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnProcessRefund.FlatStyle = FlatStyle.Flat;
            btnProcessRefund.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnProcessRefund.ForeColor = Color.FromArgb(51, 65, 85);
            btnProcessRefund.Location = new Point(529, 13);
            btnProcessRefund.Margin = new Padding(4, 5, 4, 5);
            btnProcessRefund.Name = "btnProcessRefund";
            btnProcessRefund.Size = new Size(243, 53);
            btnProcessRefund.TabIndex = 1;
            btnProcessRefund.Text = "🔄  Issue Cancellation Refund";
            btnProcessRefund.UseVisualStyleBackColor = false;
            // 
            // btnRecordPayment
            // 
            btnRecordPayment.BackColor = Color.FromArgb(15, 23, 42);
            btnRecordPayment.FlatAppearance.BorderSize = 0;
            btnRecordPayment.FlatStyle = FlatStyle.Flat;
            btnRecordPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRecordPayment.ForeColor = Color.White;
            btnRecordPayment.Location = new Point(257, 13);
            btnRecordPayment.Margin = new Padding(4, 5, 4, 5);
            btnRecordPayment.Name = "btnRecordPayment";
            btnRecordPayment.Size = new Size(257, 53);
            btnRecordPayment.TabIndex = 2;
            btnRecordPayment.Text = "💵  Record Cash Payment";
            btnRecordPayment.UseVisualStyleBackColor = false;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = Color.FromArgb(241, 245, 249);
            btnPrintReceipt.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.FlatStyle = FlatStyle.Flat;
            btnPrintReceipt.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrintReceipt.ForeColor = Color.FromArgb(30, 41, 59);
            btnPrintReceipt.Location = new Point(17, 13);
            btnPrintReceipt.Margin = new Padding(4, 5, 4, 5);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(229, 53);
            btnPrintReceipt.TabIndex = 3;
            btnPrintReceipt.Text = "\U0001f9fe  Print Official Receipt";
            btnPrintReceipt.UseVisualStyleBackColor = false;
            // 
            // lvPayments
            // 
            lvPayments.Columns.AddRange(new ColumnHeader[] { colPayReceipt, colPayBooking, colPayTicket, colPayPassenger, colPayRoute, colPayAmount, colPayMethod, colPayStatus, colPayDate, colPayCashier });
            lvPayments.FullRowSelect = true;
            lvPayments.GridLines = true;
            lvPayments.Location = new Point(0, 360);
            lvPayments.Margin = new Padding(4, 5, 4, 5);
            lvPayments.MultiSelect = false;
            lvPayments.Name = "lvPayments";
            lvPayments.Size = new Size(1391, 621);
            lvPayments.TabIndex = 3;
            lvPayments.UseCompatibleStateImageBehavior = false;
            lvPayments.View = View.Details;
            // 
            // colPayReceipt
            // 
            colPayReceipt.Text = "Receipt #";
            colPayReceipt.Width = 90;
            // 
            // colPayBooking
            // 
            colPayBooking.Text = "Booking Ref";
            colPayBooking.Width = 90;
            // 
            // colPayTicket
            // 
            colPayTicket.Text = "Ticket ID";
            colPayTicket.Width = 85;
            // 
            // colPayPassenger
            // 
            colPayPassenger.Text = "Passenger Name";
            colPayPassenger.Width = 140;
            // 
            // colPayRoute
            // 
            colPayRoute.Text = "Route";
            colPayRoute.Width = 150;
            // 
            // colPayAmount
            // 
            colPayAmount.Text = "Amount (ETB)";
            colPayAmount.Width = 95;
            // 
            // colPayMethod
            // 
            colPayMethod.Text = "Method";
            colPayMethod.Width = 85;
            // 
            // colPayStatus
            // 
            colPayStatus.Text = "Status";
            colPayStatus.Width = 75;
            // 
            // colPayDate
            // 
            colPayDate.Text = "Timestamp";
            colPayDate.Width = 120;
            // 
            // colPayCashier
            // 
            colPayCashier.Text = "Cashier / Officer";
            colPayCashier.Width = 130;
            // 
            // panelPaymentsToolbar
            // 
            panelPaymentsToolbar.BackColor = Color.White;
            panelPaymentsToolbar.BorderStyle = BorderStyle.FixedSingle;
            panelPaymentsToolbar.Controls.Add(btnRefreshPayments);
            panelPaymentsToolbar.Controls.Add(cmbPaymentStatusFilter);
            panelPaymentsToolbar.Controls.Add(cmbPaymentMethodFilter);
            panelPaymentsToolbar.Controls.Add(txtSearchPayments);
            panelPaymentsToolbar.Location = new Point(0, 267);
            panelPaymentsToolbar.Margin = new Padding(4, 5, 4, 5);
            panelPaymentsToolbar.Name = "panelPaymentsToolbar";
            panelPaymentsToolbar.Size = new Size(1392, 79);
            panelPaymentsToolbar.TabIndex = 4;
            // 
            // btnRefreshPayments
            // 
            btnRefreshPayments.BackColor = Color.White;
            btnRefreshPayments.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefreshPayments.FlatStyle = FlatStyle.Flat;
            btnRefreshPayments.Location = new Point(951, 18);
            btnRefreshPayments.Margin = new Padding(4, 5, 4, 5);
            btnRefreshPayments.Name = "btnRefreshPayments";
            btnRefreshPayments.Size = new Size(129, 43);
            btnRefreshPayments.TabIndex = 0;
            btnRefreshPayments.Text = "Refresh";
            btnRefreshPayments.UseVisualStyleBackColor = false;
            // 
            // cmbPaymentStatusFilter
            // 
            cmbPaymentStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentStatusFilter.Items.AddRange(new object[] { "All Statuses", "Paid", "Pending", "Refunded" });
            cmbPaymentStatusFilter.Location = new Point(720, 20);
            cmbPaymentStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbPaymentStatusFilter.Name = "cmbPaymentStatusFilter";
            cmbPaymentStatusFilter.Size = new Size(213, 33);
            cmbPaymentStatusFilter.TabIndex = 1;
            // 
            // cmbPaymentMethodFilter
            // 
            cmbPaymentMethodFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethodFilter.Items.AddRange(new object[] { "All Methods", "Cash", "Telebirr", "CBE Birr", "Card" });
            cmbPaymentMethodFilter.Location = new Point(491, 20);
            cmbPaymentMethodFilter.Margin = new Padding(4, 5, 4, 5);
            cmbPaymentMethodFilter.Name = "cmbPaymentMethodFilter";
            cmbPaymentMethodFilter.Size = new Size(213, 33);
            cmbPaymentMethodFilter.TabIndex = 2;
            // 
            // txtSearchPayments
            // 
            txtSearchPayments.Location = new Point(17, 20);
            txtSearchPayments.Margin = new Padding(4, 5, 4, 5);
            txtSearchPayments.Name = "txtSearchPayments";
            txtSearchPayments.PlaceholderText = "Search by receipt #, booking, passenger name...";
            txtSearchPayments.Size = new Size(455, 31);
            txtSearchPayments.TabIndex = 3;
            // 
            // flowPaymentMetrics
            // 
            flowPaymentMetrics.Controls.Add(cardPayTotal);
            flowPaymentMetrics.Controls.Add(cardPayCash);
            flowPaymentMetrics.Controls.Add(cardPayDigital);
            flowPaymentMetrics.Controls.Add(cardPayRefunds);
            flowPaymentMetrics.Location = new Point(0, 107);
            flowPaymentMetrics.Margin = new Padding(4, 5, 4, 5);
            flowPaymentMetrics.Name = "flowPaymentMetrics";
            flowPaymentMetrics.Size = new Size(1407, 147);
            flowPaymentMetrics.TabIndex = 5;
            // 
            // cardPayTotal
            // 
            cardPayTotal.BackColor = Color.White;
            cardPayTotal.BorderStyle = BorderStyle.FixedSingle;
            cardPayTotal.Controls.Add(lblPayTotalVal);
            cardPayTotal.Controls.Add(lblPayTotalTitle);
            cardPayTotal.Location = new Point(0, 0);
            cardPayTotal.Margin = new Padding(0, 0, 20, 0);
            cardPayTotal.Name = "cardPayTotal";
            cardPayTotal.Size = new Size(319, 139);
            cardPayTotal.TabIndex = 0;
            // 
            // lblPayTotalVal
            // 
            lblPayTotalVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPayTotalVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblPayTotalVal.Location = new Point(17, 13);
            lblPayTotalVal.Margin = new Padding(4, 0, 4, 0);
            lblPayTotalVal.Name = "lblPayTotalVal";
            lblPayTotalVal.Size = new Size(286, 53);
            lblPayTotalVal.TabIndex = 0;
            lblPayTotalVal.Text = "0 ETB";
            // 
            // lblPayTotalTitle
            // 
            lblPayTotalTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPayTotalTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblPayTotalTitle.Location = new Point(17, 73);
            lblPayTotalTitle.Margin = new Padding(4, 0, 4, 0);
            lblPayTotalTitle.Name = "lblPayTotalTitle";
            lblPayTotalTitle.Size = new Size(286, 30);
            lblPayTotalTitle.TabIndex = 1;
            lblPayTotalTitle.Text = "TODAY'S INTAKE";
            // 
            // cardPayCash
            // 
            cardPayCash.BackColor = Color.White;
            cardPayCash.BorderStyle = BorderStyle.FixedSingle;
            cardPayCash.Controls.Add(lblPayCashVal);
            cardPayCash.Controls.Add(lblPayCashTitle);
            cardPayCash.Location = new Point(339, 0);
            cardPayCash.Margin = new Padding(0, 0, 20, 0);
            cardPayCash.Name = "cardPayCash";
            cardPayCash.Size = new Size(319, 139);
            cardPayCash.TabIndex = 1;
            // 
            // lblPayCashVal
            // 
            lblPayCashVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPayCashVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblPayCashVal.Location = new Point(17, 13);
            lblPayCashVal.Margin = new Padding(4, 0, 4, 0);
            lblPayCashVal.Name = "lblPayCashVal";
            lblPayCashVal.Size = new Size(286, 53);
            lblPayCashVal.TabIndex = 0;
            lblPayCashVal.Text = "0 ETB";
            // 
            // lblPayCashTitle
            // 
            lblPayCashTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPayCashTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblPayCashTitle.Location = new Point(17, 73);
            lblPayCashTitle.Margin = new Padding(4, 0, 4, 0);
            lblPayCashTitle.Name = "lblPayCashTitle";
            lblPayCashTitle.Size = new Size(286, 30);
            lblPayCashTitle.TabIndex = 1;
            lblPayCashTitle.Text = "CASH PAYMENTS";
            // 
            // cardPayDigital
            // 
            cardPayDigital.BackColor = Color.White;
            cardPayDigital.BorderStyle = BorderStyle.FixedSingle;
            cardPayDigital.Controls.Add(lblPayDigitalVal);
            cardPayDigital.Controls.Add(lblPayDigitalTitle);
            cardPayDigital.Location = new Point(678, 0);
            cardPayDigital.Margin = new Padding(0, 0, 20, 0);
            cardPayDigital.Name = "cardPayDigital";
            cardPayDigital.Size = new Size(319, 139);
            cardPayDigital.TabIndex = 2;
            // 
            // lblPayDigitalVal
            // 
            lblPayDigitalVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPayDigitalVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblPayDigitalVal.Location = new Point(17, 13);
            lblPayDigitalVal.Margin = new Padding(4, 0, 4, 0);
            lblPayDigitalVal.Name = "lblPayDigitalVal";
            lblPayDigitalVal.Size = new Size(286, 53);
            lblPayDigitalVal.TabIndex = 0;
            lblPayDigitalVal.Text = "0 ETB";
            // 
            // lblPayDigitalTitle
            // 
            lblPayDigitalTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPayDigitalTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblPayDigitalTitle.Location = new Point(17, 73);
            lblPayDigitalTitle.Margin = new Padding(4, 0, 4, 0);
            lblPayDigitalTitle.Name = "lblPayDigitalTitle";
            lblPayDigitalTitle.Size = new Size(286, 30);
            lblPayDigitalTitle.TabIndex = 1;
            lblPayDigitalTitle.Text = "DIGITAL / TELEBIRR";
            // 
            // cardPayRefunds
            // 
            cardPayRefunds.BackColor = Color.White;
            cardPayRefunds.BorderStyle = BorderStyle.FixedSingle;
            cardPayRefunds.Controls.Add(lblPayRefundsVal);
            cardPayRefunds.Controls.Add(lblPayRefundsTitle);
            cardPayRefunds.Location = new Point(1017, 0);
            cardPayRefunds.Margin = new Padding(0, 0, 20, 0);
            cardPayRefunds.Name = "cardPayRefunds";
            cardPayRefunds.Size = new Size(319, 139);
            cardPayRefunds.TabIndex = 3;
            // 
            // lblPayRefundsVal
            // 
            lblPayRefundsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPayRefundsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblPayRefundsVal.Location = new Point(17, 13);
            lblPayRefundsVal.Margin = new Padding(4, 0, 4, 0);
            lblPayRefundsVal.Name = "lblPayRefundsVal";
            lblPayRefundsVal.Size = new Size(286, 53);
            lblPayRefundsVal.TabIndex = 0;
            lblPayRefundsVal.Text = "0 ETB";
            // 
            // lblPayRefundsTitle
            // 
            lblPayRefundsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblPayRefundsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblPayRefundsTitle.Location = new Point(17, 73);
            lblPayRefundsTitle.Margin = new Padding(4, 0, 4, 0);
            lblPayRefundsTitle.Name = "lblPayRefundsTitle";
            lblPayRefundsTitle.Size = new Size(286, 30);
            lblPayRefundsTitle.TabIndex = 1;
            lblPayRefundsTitle.Text = "REFUNDS ISSUED";
            // 
            // panelPaymentsHeader
            // 
            panelPaymentsHeader.Controls.Add(lblPaymentsSubtitle);
            panelPaymentsHeader.Controls.Add(lblPaymentsTitle);
            panelPaymentsHeader.Dock = DockStyle.Top;
            panelPaymentsHeader.Location = new Point(0, 0);
            panelPaymentsHeader.Margin = new Padding(4, 5, 4, 5);
            panelPaymentsHeader.Name = "panelPaymentsHeader";
            panelPaymentsHeader.Size = new Size(1462, 100);
            panelPaymentsHeader.TabIndex = 6;
            // 
            // lblPaymentsSubtitle
            // 
            lblPaymentsSubtitle.AutoSize = true;
            lblPaymentsSubtitle.Font = new Font("Segoe UI", 9F);
            lblPaymentsSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblPaymentsSubtitle.Location = new Point(3, 55);
            lblPaymentsSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblPaymentsSubtitle.Name = "lblPaymentsSubtitle";
            lblPaymentsSubtitle.Size = new Size(917, 25);
            lblPaymentsSubtitle.TabIndex = 0;
            lblPaymentsSubtitle.Text = "Manage walk-in counter payments, verify electronic transfers (Telebirr/CBE Birr), issue receipts, and process refunds.";
            // 
            // lblPaymentsTitle
            // 
            lblPaymentsTitle.AutoSize = true;
            lblPaymentsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPaymentsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblPaymentsTitle.Location = new Point(0, 7);
            lblPaymentsTitle.Margin = new Padding(4, 0, 4, 0);
            lblPaymentsTitle.Name = "lblPaymentsTitle";
            lblPaymentsTitle.Size = new Size(472, 38);
            lblPaymentsTitle.TabIndex = 1;
            lblPaymentsTitle.Text = "Counter Cashier & Payment Receipts";
            // 
            // panelTicketManagement
            // 
            panelTicketManagement.AutoScroll = true;
            panelTicketManagement.Controls.Add(panelTicketActions);
            panelTicketManagement.Controls.Add(lvTickets);
            panelTicketManagement.Controls.Add(panelTicketsToolbar);
            panelTicketManagement.Controls.Add(flowTicketMetrics);
            panelTicketManagement.Controls.Add(panelTicketsHeader);
            panelTicketManagement.Dock = DockStyle.Fill;
            panelTicketManagement.Location = new Point(29, 120);
            panelTicketManagement.Margin = new Padding(4, 5, 4, 5);
            panelTicketManagement.Name = "panelTicketManagement";
            panelTicketManagement.Size = new Size(1488, 880);
            panelTicketManagement.TabIndex = 3;
            panelTicketManagement.Visible = false;
            // 
            // panelTicketActions
            // 
            panelTicketActions.BackColor = Color.White;
            panelTicketActions.BorderStyle = BorderStyle.FixedSingle;
            panelTicketActions.Controls.Add(lblTicketCount);
            panelTicketActions.Controls.Add(btnCancelTicketAction);
            panelTicketActions.Controls.Add(btnPrintTicketPass);
            panelTicketActions.Controls.Add(btnVerifyAndBoard);
            panelTicketActions.Controls.Add(btnViewTicketDetails);
            panelTicketActions.Location = new Point(0, 997);
            panelTicketActions.Margin = new Padding(4, 5, 4, 5);
            panelTicketActions.Name = "panelTicketActions";
            panelTicketActions.Size = new Size(1392, 79);
            panelTicketActions.TabIndex = 0;
            // 
            // lblTicketCount
            // 
            lblTicketCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTicketCount.Font = new Font("Segoe UI", 8.5F);
            lblTicketCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTicketCount.Location = new Point(1071, 23);
            lblTicketCount.Margin = new Padding(4, 0, 4, 0);
            lblTicketCount.Name = "lblTicketCount";
            lblTicketCount.Size = new Size(300, 33);
            lblTicketCount.TabIndex = 0;
            lblTicketCount.Text = "Showing 0 tickets";
            lblTicketCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnCancelTicketAction
            // 
            btnCancelTicketAction.BackColor = Color.White;
            btnCancelTicketAction.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelTicketAction.FlatStyle = FlatStyle.Flat;
            btnCancelTicketAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelTicketAction.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancelTicketAction.Location = new Point(637, 13);
            btnCancelTicketAction.Margin = new Padding(4, 5, 4, 5);
            btnCancelTicketAction.Name = "btnCancelTicketAction";
            btnCancelTicketAction.Size = new Size(179, 53);
            btnCancelTicketAction.TabIndex = 1;
            btnCancelTicketAction.Text = "❌  Cancel Ticket";
            btnCancelTicketAction.UseVisualStyleBackColor = false;
            // 
            // btnPrintTicketPass
            // 
            btnPrintTicketPass.BackColor = Color.White;
            btnPrintTicketPass.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnPrintTicketPass.FlatStyle = FlatStyle.Flat;
            btnPrintTicketPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrintTicketPass.ForeColor = Color.FromArgb(15, 23, 42);
            btnPrintTicketPass.Location = new Point(440, 13);
            btnPrintTicketPass.Margin = new Padding(4, 5, 4, 5);
            btnPrintTicketPass.Name = "btnPrintTicketPass";
            btnPrintTicketPass.Size = new Size(186, 53);
            btnPrintTicketPass.TabIndex = 2;
            btnPrintTicketPass.Text = "🖨️  Print Ticket";
            btnPrintTicketPass.UseVisualStyleBackColor = false;
            // 
            // btnVerifyAndBoard
            // 
            btnVerifyAndBoard.BackColor = Color.FromArgb(241, 245, 249);
            btnVerifyAndBoard.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnVerifyAndBoard.FlatAppearance.BorderSize = 0;
            btnVerifyAndBoard.FlatStyle = FlatStyle.Flat;
            btnVerifyAndBoard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerifyAndBoard.ForeColor = Color.FromArgb(30, 41, 59);
            btnVerifyAndBoard.Location = new Point(200, 13);
            btnVerifyAndBoard.Margin = new Padding(4, 5, 4, 5);
            btnVerifyAndBoard.Name = "btnVerifyAndBoard";
            btnVerifyAndBoard.Size = new Size(229, 53);
            btnVerifyAndBoard.TabIndex = 3;
            btnVerifyAndBoard.Text = "✅  Verify && Board";
            btnVerifyAndBoard.UseVisualStyleBackColor = false;
            // 
            // btnViewTicketDetails
            // 
            btnViewTicketDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewTicketDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewTicketDetails.FlatAppearance.BorderSize = 0;
            btnViewTicketDetails.FlatStyle = FlatStyle.Flat;
            btnViewTicketDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewTicketDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewTicketDetails.Location = new Point(17, 13);
            btnViewTicketDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewTicketDetails.Name = "btnViewTicketDetails";
            btnViewTicketDetails.Size = new Size(171, 53);
            btnViewTicketDetails.TabIndex = 4;
            btnViewTicketDetails.Text = "👁️  View Ticket";
            btnViewTicketDetails.UseVisualStyleBackColor = false;
            // 
            // lvTickets
            // 
            lvTickets.Columns.AddRange(new ColumnHeader[] { colTicketId, colTicketBookingRef, colTicketPassenger, colTicketPhone, colTicketRoute, colTicketDate, colTicketTime, colTicketSeat, colTicketGate, colTicketBus, colTicketStatus });
            lvTickets.FullRowSelect = true;
            lvTickets.GridLines = true;
            lvTickets.Location = new Point(0, 350);
            lvTickets.Margin = new Padding(4, 5, 4, 5);
            lvTickets.MultiSelect = false;
            lvTickets.Name = "lvTickets";
            lvTickets.Size = new Size(1391, 631);
            lvTickets.TabIndex = 3;
            lvTickets.UseCompatibleStateImageBehavior = false;
            lvTickets.View = View.Details;
            // 
            // colTicketId
            // 
            colTicketId.Text = "Ticket ID";
            colTicketId.Width = 85;
            // 
            // colTicketBookingRef
            // 
            colTicketBookingRef.Text = "Booking Ref";
            colTicketBookingRef.Width = 85;
            // 
            // colTicketPassenger
            // 
            colTicketPassenger.Text = "Passenger";
            colTicketPassenger.Width = 140;
            // 
            // colTicketPhone
            // 
            colTicketPhone.Text = "Phone";
            colTicketPhone.Width = 110;
            // 
            // colTicketRoute
            // 
            colTicketRoute.Text = "Route";
            colTicketRoute.Width = 160;
            // 
            // colTicketDate
            // 
            colTicketDate.Text = "Date";
            colTicketDate.Width = 90;
            // 
            // colTicketTime
            // 
            colTicketTime.Text = "Time";
            colTicketTime.Width = 75;
            // 
            // colTicketSeat
            // 
            colTicketSeat.Text = "Seat";
            colTicketSeat.Width = 65;
            // 
            // colTicketGate
            // 
            colTicketGate.Text = "Gate";
            colTicketGate.Width = 65;
            // 
            // colTicketBus
            // 
            colTicketBus.Text = "Coach";
            colTicketBus.Width = 90;
            // 
            // colTicketStatus
            // 
            colTicketStatus.Text = "Status";
            colTicketStatus.Width = 80;
            // 
            // panelTicketsToolbar
            // 
            panelTicketsToolbar.BackColor = Color.White;
            panelTicketsToolbar.BorderStyle = BorderStyle.FixedSingle;
            panelTicketsToolbar.Controls.Add(btnResetTicketFilters);
            panelTicketsToolbar.Controls.Add(dtpTicketFilterDate);
            panelTicketsToolbar.Controls.Add(chkEnableTicketDateFilter);
            panelTicketsToolbar.Controls.Add(cmbTicketRouteFilter);
            panelTicketsToolbar.Controls.Add(cmbTicketStatusFilter);
            panelTicketsToolbar.Controls.Add(txtSearchTicketFilter);
            panelTicketsToolbar.Location = new Point(0, 257);
            panelTicketsToolbar.Margin = new Padding(4, 5, 4, 5);
            panelTicketsToolbar.Name = "panelTicketsToolbar";
            panelTicketsToolbar.Size = new Size(1392, 79);
            panelTicketsToolbar.TabIndex = 4;
            // 
            // btnResetTicketFilters
            // 
            btnResetTicketFilters.BackColor = Color.White;
            btnResetTicketFilters.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetTicketFilters.FlatStyle = FlatStyle.Flat;
            btnResetTicketFilters.Location = new Point(1151, 18);
            btnResetTicketFilters.Margin = new Padding(4, 5, 4, 5);
            btnResetTicketFilters.Name = "btnResetTicketFilters";
            btnResetTicketFilters.Size = new Size(114, 43);
            btnResetTicketFilters.TabIndex = 0;
            btnResetTicketFilters.Text = "Reset";
            btnResetTicketFilters.UseVisualStyleBackColor = false;
            // 
            // dtpTicketFilterDate
            // 
            dtpTicketFilterDate.Enabled = false;
            dtpTicketFilterDate.Format = DateTimePickerFormat.Short;
            dtpTicketFilterDate.Location = new Point(963, 20);
            dtpTicketFilterDate.Margin = new Padding(4, 5, 4, 5);
            dtpTicketFilterDate.Name = "dtpTicketFilterDate";
            dtpTicketFilterDate.Size = new Size(170, 31);
            dtpTicketFilterDate.TabIndex = 1;
            // 
            // chkEnableTicketDateFilter
            // 
            chkEnableTicketDateFilter.AutoSize = true;
            chkEnableTicketDateFilter.Location = new Point(877, 23);
            chkEnableTicketDateFilter.Margin = new Padding(4, 5, 4, 5);
            chkEnableTicketDateFilter.Name = "chkEnableTicketDateFilter";
            chkEnableTicketDateFilter.Size = new Size(79, 29);
            chkEnableTicketDateFilter.TabIndex = 2;
            chkEnableTicketDateFilter.Text = "Date:";
            // 
            // cmbTicketRouteFilter
            // 
            cmbTicketRouteFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTicketRouteFilter.Items.AddRange(new object[] { "All Routes / Trips" });
            cmbTicketRouteFilter.Location = new Point(603, 20);
            cmbTicketRouteFilter.Margin = new Padding(4, 5, 4, 5);
            cmbTicketRouteFilter.Name = "cmbTicketRouteFilter";
            cmbTicketRouteFilter.Size = new Size(255, 33);
            cmbTicketRouteFilter.TabIndex = 3;
            // 
            // cmbTicketStatusFilter
            // 
            cmbTicketStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTicketStatusFilter.Items.AddRange(new object[] { "All Statuses", "Valid", "Boarded", "Cancelled" });
            cmbTicketStatusFilter.Location = new Point(403, 20);
            cmbTicketStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbTicketStatusFilter.Name = "cmbTicketStatusFilter";
            cmbTicketStatusFilter.Size = new Size(184, 33);
            cmbTicketStatusFilter.TabIndex = 4;
            // 
            // txtSearchTicketFilter
            // 
            txtSearchTicketFilter.Location = new Point(17, 20);
            txtSearchTicketFilter.Margin = new Padding(4, 5, 4, 5);
            txtSearchTicketFilter.Name = "txtSearchTicketFilter";
            txtSearchTicketFilter.PlaceholderText = "Search by Ticket ID, passenger, phone, code...";
            txtSearchTicketFilter.Size = new Size(370, 31);
            txtSearchTicketFilter.TabIndex = 5;
            // 
            // flowTicketMetrics
            // 
            flowTicketMetrics.Controls.Add(cardTotalTickets);
            flowTicketMetrics.Controls.Add(cardValidTickets);
            flowTicketMetrics.Controls.Add(cardBoardedTickets);
            flowTicketMetrics.Controls.Add(cardCancelledTickets);
            flowTicketMetrics.Controls.Add(cardTodayTickets);
            flowTicketMetrics.Location = new Point(0, 107);
            flowTicketMetrics.Margin = new Padding(4, 5, 4, 5);
            flowTicketMetrics.Name = "flowTicketMetrics";
            flowTicketMetrics.Size = new Size(1407, 140);
            flowTicketMetrics.TabIndex = 5;
            // 
            // cardTotalTickets
            // 
            cardTotalTickets.BackColor = Color.White;
            cardTotalTickets.BorderStyle = BorderStyle.FixedSingle;
            cardTotalTickets.Controls.Add(lblMetricTotalTicketsVal);
            cardTotalTickets.Controls.Add(lblMetricTotalTicketsTitle);
            cardTotalTickets.Location = new Point(0, 0);
            cardTotalTickets.Margin = new Padding(0, 0, 20, 0);
            cardTotalTickets.Name = "cardTotalTickets";
            cardTotalTickets.Size = new Size(319, 139);
            cardTotalTickets.TabIndex = 0;
            // 
            // lblMetricTotalTicketsVal
            // 
            lblMetricTotalTicketsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricTotalTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalTicketsVal.Location = new Point(17, 13);
            lblMetricTotalTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalTicketsVal.Name = "lblMetricTotalTicketsVal";
            lblMetricTotalTicketsVal.Size = new Size(286, 53);
            lblMetricTotalTicketsVal.TabIndex = 0;
            lblMetricTotalTicketsVal.Text = "0";
            // 
            // lblMetricTotalTicketsTitle
            // 
            lblMetricTotalTicketsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTotalTicketsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricTotalTicketsTitle.Location = new Point(17, 73);
            lblMetricTotalTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalTicketsTitle.Name = "lblMetricTotalTicketsTitle";
            lblMetricTotalTicketsTitle.Size = new Size(286, 30);
            lblMetricTotalTicketsTitle.TabIndex = 1;
            lblMetricTotalTicketsTitle.Text = "TOTAL TICKETS";
            // 
            // cardValidTickets
            // 
            cardValidTickets.BackColor = Color.White;
            cardValidTickets.BorderStyle = BorderStyle.FixedSingle;
            cardValidTickets.Controls.Add(lblMetricValidTicketsVal);
            cardValidTickets.Controls.Add(lblMetricValidTicketsTitle);
            cardValidTickets.Location = new Point(339, 0);
            cardValidTickets.Margin = new Padding(0, 0, 20, 0);
            cardValidTickets.Name = "cardValidTickets";
            cardValidTickets.Size = new Size(319, 139);
            cardValidTickets.TabIndex = 1;
            // 
            // lblMetricValidTicketsVal
            // 
            lblMetricValidTicketsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricValidTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricValidTicketsVal.Location = new Point(17, 13);
            lblMetricValidTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricValidTicketsVal.Name = "lblMetricValidTicketsVal";
            lblMetricValidTicketsVal.Size = new Size(286, 53);
            lblMetricValidTicketsVal.TabIndex = 0;
            lblMetricValidTicketsVal.Text = "0";
            // 
            // lblMetricValidTicketsTitle
            // 
            lblMetricValidTicketsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricValidTicketsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricValidTicketsTitle.Location = new Point(17, 73);
            lblMetricValidTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricValidTicketsTitle.Name = "lblMetricValidTicketsTitle";
            lblMetricValidTicketsTitle.Size = new Size(286, 30);
            lblMetricValidTicketsTitle.TabIndex = 1;
            lblMetricValidTicketsTitle.Text = "VALID / ACTIVE";
            // 
            // cardBoardedTickets
            // 
            cardBoardedTickets.BackColor = Color.White;
            cardBoardedTickets.BorderStyle = BorderStyle.FixedSingle;
            cardBoardedTickets.Controls.Add(lblMetricBoardedTicketsVal);
            cardBoardedTickets.Controls.Add(lblMetricBoardedTicketsTitle);
            cardBoardedTickets.Location = new Point(678, 0);
            cardBoardedTickets.Margin = new Padding(0, 0, 20, 0);
            cardBoardedTickets.Name = "cardBoardedTickets";
            cardBoardedTickets.Size = new Size(319, 139);
            cardBoardedTickets.TabIndex = 2;
            // 
            // lblMetricBoardedTicketsVal
            // 
            lblMetricBoardedTicketsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricBoardedTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricBoardedTicketsVal.Location = new Point(17, 13);
            lblMetricBoardedTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricBoardedTicketsVal.Name = "lblMetricBoardedTicketsVal";
            lblMetricBoardedTicketsVal.Size = new Size(286, 53);
            lblMetricBoardedTicketsVal.TabIndex = 0;
            lblMetricBoardedTicketsVal.Text = "0";
            // 
            // lblMetricBoardedTicketsTitle
            // 
            lblMetricBoardedTicketsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricBoardedTicketsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricBoardedTicketsTitle.Location = new Point(17, 73);
            lblMetricBoardedTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricBoardedTicketsTitle.Name = "lblMetricBoardedTicketsTitle";
            lblMetricBoardedTicketsTitle.Size = new Size(286, 30);
            lblMetricBoardedTicketsTitle.TabIndex = 1;
            lblMetricBoardedTicketsTitle.Text = "BOARDED / USED";
            // 
            // cardCancelledTickets
            // 
            cardCancelledTickets.BackColor = Color.White;
            cardCancelledTickets.BorderStyle = BorderStyle.FixedSingle;
            cardCancelledTickets.Controls.Add(lblMetricCancelledTicketsVal);
            cardCancelledTickets.Controls.Add(lblMetricCancelledTicketsTitle);
            cardCancelledTickets.Location = new Point(1017, 0);
            cardCancelledTickets.Margin = new Padding(0, 0, 20, 0);
            cardCancelledTickets.Name = "cardCancelledTickets";
            cardCancelledTickets.Size = new Size(319, 139);
            cardCancelledTickets.TabIndex = 3;
            // 
            // lblMetricCancelledTicketsVal
            // 
            lblMetricCancelledTicketsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricCancelledTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricCancelledTicketsVal.Location = new Point(17, 13);
            lblMetricCancelledTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledTicketsVal.Name = "lblMetricCancelledTicketsVal";
            lblMetricCancelledTicketsVal.Size = new Size(286, 53);
            lblMetricCancelledTicketsVal.TabIndex = 0;
            lblMetricCancelledTicketsVal.Text = "0";
            // 
            // lblMetricCancelledTicketsTitle
            // 
            lblMetricCancelledTicketsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricCancelledTicketsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricCancelledTicketsTitle.Location = new Point(17, 73);
            lblMetricCancelledTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledTicketsTitle.Name = "lblMetricCancelledTicketsTitle";
            lblMetricCancelledTicketsTitle.Size = new Size(286, 30);
            lblMetricCancelledTicketsTitle.TabIndex = 1;
            lblMetricCancelledTicketsTitle.Text = "CANCELLED";
            // 
            // cardTodayTickets
            // 
            cardTodayTickets.BackColor = Color.White;
            cardTodayTickets.BorderStyle = BorderStyle.FixedSingle;
            cardTodayTickets.Controls.Add(lblMetricTodayTicketsVal);
            cardTodayTickets.Controls.Add(lblMetricTodayTicketsTitle);
            cardTodayTickets.Location = new Point(0, 139);
            cardTodayTickets.Margin = new Padding(0, 0, 20, 0);
            cardTodayTickets.Name = "cardTodayTickets";
            cardTodayTickets.Size = new Size(319, 139);
            cardTodayTickets.TabIndex = 4;
            // 
            // lblMetricTodayTicketsVal
            // 
            lblMetricTodayTicketsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricTodayTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTodayTicketsVal.Location = new Point(17, 13);
            lblMetricTodayTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayTicketsVal.Name = "lblMetricTodayTicketsVal";
            lblMetricTodayTicketsVal.Size = new Size(286, 53);
            lblMetricTodayTicketsVal.TabIndex = 0;
            lblMetricTodayTicketsVal.Text = "0";
            // 
            // lblMetricTodayTicketsTitle
            // 
            lblMetricTodayTicketsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTodayTicketsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricTodayTicketsTitle.Location = new Point(17, 73);
            lblMetricTodayTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayTicketsTitle.Name = "lblMetricTodayTicketsTitle";
            lblMetricTodayTicketsTitle.Size = new Size(286, 30);
            lblMetricTodayTicketsTitle.TabIndex = 1;
            lblMetricTodayTicketsTitle.Text = "TODAY'S TICKETS";
            // 
            // panelTicketsHeader
            // 
            panelTicketsHeader.Controls.Add(btnVerifyBoardModal);
            panelTicketsHeader.Controls.Add(btnNewTicket);
            panelTicketsHeader.Controls.Add(lblTicketsSubtitle);
            panelTicketsHeader.Controls.Add(lblTicketsTitle);
            panelTicketsHeader.Dock = DockStyle.Top;
            panelTicketsHeader.Location = new Point(0, 0);
            panelTicketsHeader.Margin = new Padding(4, 5, 4, 5);
            panelTicketsHeader.Name = "panelTicketsHeader";
            panelTicketsHeader.Size = new Size(1462, 100);
            panelTicketsHeader.TabIndex = 6;
            // 
            // btnVerifyBoardModal
            // 
            btnVerifyBoardModal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerifyBoardModal.BackColor = Color.FromArgb(241, 245, 249);
            btnVerifyBoardModal.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnVerifyBoardModal.FlatAppearance.BorderSize = 0;
            btnVerifyBoardModal.FlatStyle = FlatStyle.Flat;
            btnVerifyBoardModal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerifyBoardModal.ForeColor = Color.FromArgb(30, 41, 59);
            btnVerifyBoardModal.Location = new Point(948, 23);
            btnVerifyBoardModal.Margin = new Padding(4, 5, 4, 5);
            btnVerifyBoardModal.Name = "btnVerifyBoardModal";
            btnVerifyBoardModal.Size = new Size(257, 57);
            btnVerifyBoardModal.TabIndex = 0;
            btnVerifyBoardModal.Text = "🔍  Boarding Scanner";
            btnVerifyBoardModal.UseVisualStyleBackColor = false;
            // 
            // btnNewTicket
            // 
            btnNewTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewTicket.BackColor = Color.FromArgb(15, 23, 42);
            btnNewTicket.FlatAppearance.BorderSize = 0;
            btnNewTicket.FlatStyle = FlatStyle.Flat;
            btnNewTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewTicket.ForeColor = Color.White;
            btnNewTicket.Location = new Point(1217, 23);
            btnNewTicket.Margin = new Padding(4, 5, 4, 5);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.Size = new Size(221, 57);
            btnNewTicket.TabIndex = 1;
            btnNewTicket.Text = "➕  Issue Ticket";
            btnNewTicket.UseVisualStyleBackColor = false;
            // 
            // lblTicketsSubtitle
            // 
            lblTicketsSubtitle.AutoSize = true;
            lblTicketsSubtitle.Font = new Font("Segoe UI", 9F);
            lblTicketsSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblTicketsSubtitle.Location = new Point(3, 55);
            lblTicketsSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblTicketsSubtitle.Name = "lblTicketsSubtitle";
            lblTicketsSubtitle.Size = new Size(752, 25);
            lblTicketsSubtitle.TabIndex = 2;
            lblTicketsSubtitle.Text = "Complete ledger of all issued boarding passes, seat allocations, and gate verification statuses.";
            // 
            // lblTicketsTitle
            // 
            lblTicketsTitle.AutoSize = true;
            lblTicketsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTicketsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTicketsTitle.Location = new Point(0, 7);
            lblTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblTicketsTitle.Name = "lblTicketsTitle";
            lblTicketsTitle.Size = new Size(467, 38);
            lblTicketsTitle.TabIndex = 3;
            lblTicketsTitle.Text = "Tickets Directory & Issuance Station";
            // 
            // panelBookingManagement
            // 
            panelBookingManagement.AutoScroll = true;
            panelBookingManagement.Controls.Add(panelBookingActions);
            panelBookingManagement.Controls.Add(lvBookings);
            panelBookingManagement.Controls.Add(panelBookingsToolbar);
            panelBookingManagement.Controls.Add(flowBookingMetrics);
            panelBookingManagement.Controls.Add(panelBookingsHeader);
            panelBookingManagement.Dock = DockStyle.Fill;
            panelBookingManagement.Location = new Point(29, 120);
            panelBookingManagement.Margin = new Padding(4, 5, 4, 5);
            panelBookingManagement.Name = "panelBookingManagement";
            panelBookingManagement.Size = new Size(1488, 880);
            panelBookingManagement.TabIndex = 4;
            panelBookingManagement.Visible = false;
            // 
            // panelBookingActions
            // 
            panelBookingActions.BackColor = Color.White;
            panelBookingActions.BorderStyle = BorderStyle.FixedSingle;
            panelBookingActions.Controls.Add(lblBookingCount);
            panelBookingActions.Controls.Add(btnPrintTicket);
            panelBookingActions.Controls.Add(btnCancelBookingAction);
            panelBookingActions.Controls.Add(btnModifyBooking);
            panelBookingActions.Controls.Add(btnViewBookingDetails);
            panelBookingActions.Location = new Point(0, 997);
            panelBookingActions.Margin = new Padding(4, 5, 4, 5);
            panelBookingActions.Name = "panelBookingActions";
            panelBookingActions.Size = new Size(1392, 79);
            panelBookingActions.TabIndex = 0;
            // 
            // lblBookingCount
            // 
            lblBookingCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBookingCount.Font = new Font("Segoe UI", 8.5F);
            lblBookingCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblBookingCount.Location = new Point(1071, 23);
            lblBookingCount.Margin = new Padding(4, 0, 4, 0);
            lblBookingCount.Name = "lblBookingCount";
            lblBookingCount.Size = new Size(300, 33);
            lblBookingCount.TabIndex = 0;
            lblBookingCount.Text = "Showing 0 bookings";
            lblBookingCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.BackColor = Color.White;
            btnPrintTicket.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnPrintTicket.FlatStyle = FlatStyle.Flat;
            btnPrintTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrintTicket.ForeColor = Color.FromArgb(15, 23, 42);
            btnPrintTicket.Location = new Point(574, 13);
            btnPrintTicket.Margin = new Padding(4, 5, 4, 5);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(186, 53);
            btnPrintTicket.TabIndex = 1;
            btnPrintTicket.Text = "🖨️  Print Boarding Pass";
            btnPrintTicket.UseVisualStyleBackColor = false;
            // 
            // btnCancelBookingAction
            // 
            btnCancelBookingAction.BackColor = Color.White;
            btnCancelBookingAction.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelBookingAction.FlatStyle = FlatStyle.Flat;
            btnCancelBookingAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelBookingAction.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancelBookingAction.Location = new Point(383, 13);
            btnCancelBookingAction.Margin = new Padding(4, 5, 4, 5);
            btnCancelBookingAction.Name = "btnCancelBookingAction";
            btnCancelBookingAction.Size = new Size(179, 53);
            btnCancelBookingAction.TabIndex = 2;
            btnCancelBookingAction.Text = "❌  Cancel Booking";
            btnCancelBookingAction.UseVisualStyleBackColor = false;
            // 
            // btnModifyBooking
            // 
            btnModifyBooking.BackColor = Color.White;
            btnModifyBooking.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnModifyBooking.FlatStyle = FlatStyle.Flat;
            btnModifyBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModifyBooking.ForeColor = Color.FromArgb(15, 23, 42);
            btnModifyBooking.Location = new Point(200, 13);
            btnModifyBooking.Margin = new Padding(4, 5, 4, 5);
            btnModifyBooking.Name = "btnModifyBooking";
            btnModifyBooking.Size = new Size(171, 53);
            btnModifyBooking.TabIndex = 3;
            btnModifyBooking.Text = "✏️  Edit Booking";
            btnModifyBooking.UseVisualStyleBackColor = false;
            // 
            // btnViewBookingDetails
            // 
            btnViewBookingDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewBookingDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewBookingDetails.FlatAppearance.BorderSize = 0;
            btnViewBookingDetails.FlatStyle = FlatStyle.Flat;
            btnViewBookingDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewBookingDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewBookingDetails.Location = new Point(17, 13);
            btnViewBookingDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewBookingDetails.Name = "btnViewBookingDetails";
            btnViewBookingDetails.Size = new Size(171, 53);
            btnViewBookingDetails.TabIndex = 4;
            btnViewBookingDetails.Text = "👁️  View Dossier";
            btnViewBookingDetails.UseVisualStyleBackColor = false;
            // 
            // lvBookings
            // 
            lvBookings.Columns.AddRange(new ColumnHeader[] { colBookingId, colPassengerName, colPassengerPhone, colBookingRoute, colTravelDate, colDepartureTime, colSeats, colTotalAmount, colBookingStatus, colPaymentStatus });
            lvBookings.FullRowSelect = true;
            lvBookings.GridLines = true;
            lvBookings.Location = new Point(0, 350);
            lvBookings.Margin = new Padding(4, 5, 4, 5);
            lvBookings.MultiSelect = false;
            lvBookings.Name = "lvBookings";
            lvBookings.Size = new Size(1391, 631);
            lvBookings.TabIndex = 3;
            lvBookings.UseCompatibleStateImageBehavior = false;
            lvBookings.View = View.Details;
            // 
            // colBookingId
            // 
            colBookingId.Text = "Booking ID";
            colBookingId.Width = 85;
            // 
            // colPassengerName
            // 
            colPassengerName.Text = "Passenger Name";
            colPassengerName.Width = 140;
            // 
            // colPassengerPhone
            // 
            colPassengerPhone.Text = "Phone";
            colPassengerPhone.Width = 110;
            // 
            // colBookingRoute
            // 
            colBookingRoute.Text = "Route";
            colBookingRoute.Width = 160;
            // 
            // colTravelDate
            // 
            colTravelDate.Text = "Travel Date";
            colTravelDate.Width = 95;
            // 
            // colDepartureTime
            // 
            colDepartureTime.Text = "Time";
            colDepartureTime.Width = 75;
            // 
            // colSeats
            // 
            colSeats.Text = "Seats";
            colSeats.Width = 85;
            // 
            // colTotalAmount
            // 
            colTotalAmount.Text = "Fare (ETB)";
            colTotalAmount.Width = 80;
            // 
            // colBookingStatus
            // 
            colBookingStatus.Text = "Status";
            colBookingStatus.Width = 75;
            // 
            // colPaymentStatus
            // 
            colPaymentStatus.Text = "Payment";
            colPaymentStatus.Width = 70;
            // 
            // panelBookingsToolbar
            // 
            panelBookingsToolbar.BackColor = Color.White;
            panelBookingsToolbar.BorderStyle = BorderStyle.FixedSingle;
            panelBookingsToolbar.Controls.Add(btnResetBookingFilters);
            panelBookingsToolbar.Controls.Add(dtpBookingFilterDate);
            panelBookingsToolbar.Controls.Add(chkEnableDateFilter);
            panelBookingsToolbar.Controls.Add(cmbBookingRouteFilter);
            panelBookingsToolbar.Controls.Add(cmbBookingStatusFilter);
            panelBookingsToolbar.Controls.Add(txtSearchBooking);
            panelBookingsToolbar.Location = new Point(0, 257);
            panelBookingsToolbar.Margin = new Padding(4, 5, 4, 5);
            panelBookingsToolbar.Name = "panelBookingsToolbar";
            panelBookingsToolbar.Size = new Size(1392, 79);
            panelBookingsToolbar.TabIndex = 4;
            // 
            // btnResetBookingFilters
            // 
            btnResetBookingFilters.BackColor = Color.White;
            btnResetBookingFilters.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetBookingFilters.FlatStyle = FlatStyle.Flat;
            btnResetBookingFilters.Location = new Point(1151, 18);
            btnResetBookingFilters.Margin = new Padding(4, 5, 4, 5);
            btnResetBookingFilters.Name = "btnResetBookingFilters";
            btnResetBookingFilters.Size = new Size(114, 43);
            btnResetBookingFilters.TabIndex = 0;
            btnResetBookingFilters.Text = "Reset";
            btnResetBookingFilters.UseVisualStyleBackColor = false;
            // 
            // dtpBookingFilterDate
            // 
            dtpBookingFilterDate.Enabled = false;
            dtpBookingFilterDate.Format = DateTimePickerFormat.Short;
            dtpBookingFilterDate.Location = new Point(963, 20);
            dtpBookingFilterDate.Margin = new Padding(4, 5, 4, 5);
            dtpBookingFilterDate.Name = "dtpBookingFilterDate";
            dtpBookingFilterDate.Size = new Size(170, 31);
            dtpBookingFilterDate.TabIndex = 1;
            // 
            // chkEnableDateFilter
            // 
            chkEnableDateFilter.AutoSize = true;
            chkEnableDateFilter.Location = new Point(877, 23);
            chkEnableDateFilter.Margin = new Padding(4, 5, 4, 5);
            chkEnableDateFilter.Name = "chkEnableDateFilter";
            chkEnableDateFilter.Size = new Size(79, 29);
            chkEnableDateFilter.TabIndex = 2;
            chkEnableDateFilter.Text = "Date:";
            // 
            // cmbBookingRouteFilter
            // 
            cmbBookingRouteFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingRouteFilter.Items.AddRange(new object[] { "All Routes / Trips" });
            cmbBookingRouteFilter.Location = new Point(603, 20);
            cmbBookingRouteFilter.Margin = new Padding(4, 5, 4, 5);
            cmbBookingRouteFilter.Name = "cmbBookingRouteFilter";
            cmbBookingRouteFilter.Size = new Size(255, 33);
            cmbBookingRouteFilter.TabIndex = 3;
            // 
            // cmbBookingStatusFilter
            // 
            cmbBookingStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingStatusFilter.Items.AddRange(new object[] { "All Statuses", "Confirmed", "Pending", "Cancelled" });
            cmbBookingStatusFilter.Location = new Point(403, 20);
            cmbBookingStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbBookingStatusFilter.Name = "cmbBookingStatusFilter";
            cmbBookingStatusFilter.Size = new Size(184, 33);
            cmbBookingStatusFilter.TabIndex = 4;
            // 
            // txtSearchBooking
            // 
            txtSearchBooking.Location = new Point(17, 20);
            txtSearchBooking.Margin = new Padding(4, 5, 4, 5);
            txtSearchBooking.Name = "txtSearchBooking";
            txtSearchBooking.PlaceholderText = "Search by ID, name, phone, coach...";
            txtSearchBooking.Size = new Size(370, 31);
            txtSearchBooking.TabIndex = 5;
            // 
            // flowBookingMetrics
            // 
            flowBookingMetrics.Controls.Add(cardTotalBookings);
            flowBookingMetrics.Controls.Add(cardConfirmedBookings);
            flowBookingMetrics.Controls.Add(cardPendingBookings);
            flowBookingMetrics.Controls.Add(cardCancelledBookings);
            flowBookingMetrics.Controls.Add(cardTodayBookings);
            flowBookingMetrics.Location = new Point(0, 107);
            flowBookingMetrics.Margin = new Padding(4, 5, 4, 5);
            flowBookingMetrics.Name = "flowBookingMetrics";
            flowBookingMetrics.Size = new Size(1407, 140);
            flowBookingMetrics.TabIndex = 5;
            // 
            // cardTotalBookings
            // 
            cardTotalBookings.BackColor = Color.White;
            cardTotalBookings.BorderStyle = BorderStyle.FixedSingle;
            cardTotalBookings.Controls.Add(lblMetricTotalBookingsVal);
            cardTotalBookings.Controls.Add(lblMetricTotalBookingsTitle);
            cardTotalBookings.Location = new Point(0, 0);
            cardTotalBookings.Margin = new Padding(0, 0, 20, 0);
            cardTotalBookings.Name = "cardTotalBookings";
            cardTotalBookings.Size = new Size(319, 139);
            cardTotalBookings.TabIndex = 0;
            // 
            // lblMetricTotalBookingsVal
            // 
            lblMetricTotalBookingsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricTotalBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalBookingsVal.Location = new Point(17, 13);
            lblMetricTotalBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBookingsVal.Name = "lblMetricTotalBookingsVal";
            lblMetricTotalBookingsVal.Size = new Size(286, 53);
            lblMetricTotalBookingsVal.TabIndex = 0;
            lblMetricTotalBookingsVal.Text = "0";
            // 
            // lblMetricTotalBookingsTitle
            // 
            lblMetricTotalBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTotalBookingsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricTotalBookingsTitle.Location = new Point(17, 73);
            lblMetricTotalBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBookingsTitle.Name = "lblMetricTotalBookingsTitle";
            lblMetricTotalBookingsTitle.Size = new Size(286, 30);
            lblMetricTotalBookingsTitle.TabIndex = 1;
            lblMetricTotalBookingsTitle.Text = "TOTAL BOOKINGS";
            // 
            // cardConfirmedBookings
            // 
            cardConfirmedBookings.BackColor = Color.White;
            cardConfirmedBookings.BorderStyle = BorderStyle.FixedSingle;
            cardConfirmedBookings.Controls.Add(lblMetricConfirmedBookingsVal);
            cardConfirmedBookings.Controls.Add(lblMetricConfirmedBookingsTitle);
            cardConfirmedBookings.Location = new Point(339, 0);
            cardConfirmedBookings.Margin = new Padding(0, 0, 20, 0);
            cardConfirmedBookings.Name = "cardConfirmedBookings";
            cardConfirmedBookings.Size = new Size(319, 139);
            cardConfirmedBookings.TabIndex = 1;
            // 
            // lblMetricConfirmedBookingsVal
            // 
            lblMetricConfirmedBookingsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricConfirmedBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricConfirmedBookingsVal.Location = new Point(17, 13);
            lblMetricConfirmedBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricConfirmedBookingsVal.Name = "lblMetricConfirmedBookingsVal";
            lblMetricConfirmedBookingsVal.Size = new Size(286, 53);
            lblMetricConfirmedBookingsVal.TabIndex = 0;
            lblMetricConfirmedBookingsVal.Text = "0";
            // 
            // lblMetricConfirmedBookingsTitle
            // 
            lblMetricConfirmedBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricConfirmedBookingsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricConfirmedBookingsTitle.Location = new Point(17, 73);
            lblMetricConfirmedBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricConfirmedBookingsTitle.Name = "lblMetricConfirmedBookingsTitle";
            lblMetricConfirmedBookingsTitle.Size = new Size(286, 30);
            lblMetricConfirmedBookingsTitle.TabIndex = 1;
            lblMetricConfirmedBookingsTitle.Text = "CONFIRMED";
            // 
            // cardPendingBookings
            // 
            cardPendingBookings.BackColor = Color.White;
            cardPendingBookings.BorderStyle = BorderStyle.FixedSingle;
            cardPendingBookings.Controls.Add(lblMetricPendingBookingsVal);
            cardPendingBookings.Controls.Add(lblMetricPendingBookingsTitle);
            cardPendingBookings.Location = new Point(678, 0);
            cardPendingBookings.Margin = new Padding(0, 0, 20, 0);
            cardPendingBookings.Name = "cardPendingBookings";
            cardPendingBookings.Size = new Size(319, 139);
            cardPendingBookings.TabIndex = 2;
            // 
            // lblMetricPendingBookingsVal
            // 
            lblMetricPendingBookingsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricPendingBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricPendingBookingsVal.Location = new Point(17, 13);
            lblMetricPendingBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricPendingBookingsVal.Name = "lblMetricPendingBookingsVal";
            lblMetricPendingBookingsVal.Size = new Size(286, 53);
            lblMetricPendingBookingsVal.TabIndex = 0;
            lblMetricPendingBookingsVal.Text = "0";
            // 
            // lblMetricPendingBookingsTitle
            // 
            lblMetricPendingBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricPendingBookingsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricPendingBookingsTitle.Location = new Point(17, 73);
            lblMetricPendingBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricPendingBookingsTitle.Name = "lblMetricPendingBookingsTitle";
            lblMetricPendingBookingsTitle.Size = new Size(286, 30);
            lblMetricPendingBookingsTitle.TabIndex = 1;
            lblMetricPendingBookingsTitle.Text = "PENDING";
            // 
            // cardCancelledBookings
            // 
            cardCancelledBookings.BackColor = Color.White;
            cardCancelledBookings.BorderStyle = BorderStyle.FixedSingle;
            cardCancelledBookings.Controls.Add(lblMetricCancelledBookingsVal);
            cardCancelledBookings.Controls.Add(lblMetricCancelledBookingsTitle);
            cardCancelledBookings.Location = new Point(1017, 0);
            cardCancelledBookings.Margin = new Padding(0, 0, 20, 0);
            cardCancelledBookings.Name = "cardCancelledBookings";
            cardCancelledBookings.Size = new Size(319, 139);
            cardCancelledBookings.TabIndex = 3;
            // 
            // lblMetricCancelledBookingsVal
            // 
            lblMetricCancelledBookingsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricCancelledBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricCancelledBookingsVal.Location = new Point(17, 13);
            lblMetricCancelledBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledBookingsVal.Name = "lblMetricCancelledBookingsVal";
            lblMetricCancelledBookingsVal.Size = new Size(286, 53);
            lblMetricCancelledBookingsVal.TabIndex = 0;
            lblMetricCancelledBookingsVal.Text = "0";
            // 
            // lblMetricCancelledBookingsTitle
            // 
            lblMetricCancelledBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricCancelledBookingsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricCancelledBookingsTitle.Location = new Point(17, 73);
            lblMetricCancelledBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledBookingsTitle.Name = "lblMetricCancelledBookingsTitle";
            lblMetricCancelledBookingsTitle.Size = new Size(286, 30);
            lblMetricCancelledBookingsTitle.TabIndex = 1;
            lblMetricCancelledBookingsTitle.Text = "CANCELLED";
            // 
            // cardTodayBookings
            // 
            cardTodayBookings.BackColor = Color.White;
            cardTodayBookings.BorderStyle = BorderStyle.FixedSingle;
            cardTodayBookings.Controls.Add(lblMetricTodayBookingsVal);
            cardTodayBookings.Controls.Add(lblMetricTodayBookingsTitle);
            cardTodayBookings.Location = new Point(0, 139);
            cardTodayBookings.Margin = new Padding(0, 0, 20, 0);
            cardTodayBookings.Name = "cardTodayBookings";
            cardTodayBookings.Size = new Size(319, 139);
            cardTodayBookings.TabIndex = 4;
            // 
            // lblMetricTodayBookingsVal
            // 
            lblMetricTodayBookingsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricTodayBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTodayBookingsVal.Location = new Point(17, 13);
            lblMetricTodayBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayBookingsVal.Name = "lblMetricTodayBookingsVal";
            lblMetricTodayBookingsVal.Size = new Size(286, 53);
            lblMetricTodayBookingsVal.TabIndex = 0;
            lblMetricTodayBookingsVal.Text = "0";
            // 
            // lblMetricTodayBookingsTitle
            // 
            lblMetricTodayBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTodayBookingsTitle.ForeColor = Color.FromArgb(71, 85, 105);
            lblMetricTodayBookingsTitle.Location = new Point(17, 73);
            lblMetricTodayBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayBookingsTitle.Name = "lblMetricTodayBookingsTitle";
            lblMetricTodayBookingsTitle.Size = new Size(286, 30);
            lblMetricTodayBookingsTitle.TabIndex = 1;
            lblMetricTodayBookingsTitle.Text = "TODAY'S TRAVEL";
            // 
            // panelBookingsHeader
            // 
            panelBookingsHeader.Controls.Add(btnNewBooking);
            panelBookingsHeader.Controls.Add(lblBookingsSubtitle);
            panelBookingsHeader.Controls.Add(lblBookingsTitle);
            panelBookingsHeader.Dock = DockStyle.Top;
            panelBookingsHeader.Location = new Point(0, 0);
            panelBookingsHeader.Margin = new Padding(4, 5, 4, 5);
            panelBookingsHeader.Name = "panelBookingsHeader";
            panelBookingsHeader.Size = new Size(1462, 100);
            panelBookingsHeader.TabIndex = 6;
            // 
            // btnNewBooking
            // 
            btnNewBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewBooking.BackColor = Color.FromArgb(15, 23, 42);
            btnNewBooking.FlatAppearance.BorderSize = 0;
            btnNewBooking.FlatStyle = FlatStyle.Flat;
            btnNewBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNewBooking.ForeColor = Color.White;
            btnNewBooking.Location = new Point(1177, 23);
            btnNewBooking.Margin = new Padding(4, 5, 4, 5);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(264, 57);
            btnNewBooking.TabIndex = 0;
            btnNewBooking.Text = "➕  New Walk-In Booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // lblBookingsSubtitle
            // 
            lblBookingsSubtitle.AutoSize = true;
            lblBookingsSubtitle.Font = new Font("Segoe UI", 9F);
            lblBookingsSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblBookingsSubtitle.Location = new Point(3, 55);
            lblBookingsSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblBookingsSubtitle.Name = "lblBookingsSubtitle";
            lblBookingsSubtitle.Size = new Size(736, 25);
            lblBookingsSubtitle.TabIndex = 1;
            lblBookingsSubtitle.Text = "Search, modify, or cancel reservations, manage seat allocations, and issue passenger tickets.";
            // 
            // lblBookingsTitle
            // 
            lblBookingsTitle.AutoSize = true;
            lblBookingsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBookingsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblBookingsTitle.Location = new Point(0, 7);
            lblBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblBookingsTitle.Name = "lblBookingsTitle";
            lblBookingsTitle.Size = new Size(519, 38);
            lblBookingsTitle.TabIndex = 2;
            lblBookingsTitle.Text = "Passenger Reservations & Booking Desk";
            // 
            // panelHeaderInfo
            // 
            panelHeaderInfo.Controls.Add(lblPageHeading);
            panelHeaderInfo.Dock = DockStyle.Top;
            panelHeaderInfo.Location = new Point(29, 27);
            panelHeaderInfo.Margin = new Padding(4, 5, 4, 5);
            panelHeaderInfo.Name = "panelHeaderInfo";
            panelHeaderInfo.Size = new Size(1488, 93);
            panelHeaderInfo.TabIndex = 8;
            // 
            // lblPageHeading
            // 
            lblPageHeading.AutoSize = true;
            lblPageHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageHeading.ForeColor = Color.FromArgb(15, 23, 42);
            lblPageHeading.Location = new Point(0, 0);
            lblPageHeading.Margin = new Padding(4, 0, 4, 0);
            lblPageHeading.Name = "lblPageHeading";
            lblPageHeading.Size = new Size(628, 45);
            lblPageHeading.TabIndex = 1;
            lblPageHeading.Text = "Ticket Counter Overview & Boarding Desk";
            // 
            // lblMetricTotalBookingsSub
            // 
            lblMetricTotalBookingsSub.Font = new Font("Segoe UI", 8F);
            lblMetricTotalBookingsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricTotalBookingsSub.Location = new Point(12, 62);
            lblMetricTotalBookingsSub.Name = "lblMetricTotalBookingsSub";
            lblMetricTotalBookingsSub.Size = new Size(200, 16);
            lblMetricTotalBookingsSub.TabIndex = 0;
            lblMetricTotalBookingsSub.Text = "All reservations";
            // 
            // lblMetricConfirmedBookingsSub
            // 
            lblMetricConfirmedBookingsSub.Font = new Font("Segoe UI", 8F);
            lblMetricConfirmedBookingsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricConfirmedBookingsSub.Location = new Point(12, 62);
            lblMetricConfirmedBookingsSub.Name = "lblMetricConfirmedBookingsSub";
            lblMetricConfirmedBookingsSub.Size = new Size(200, 16);
            lblMetricConfirmedBookingsSub.TabIndex = 0;
            lblMetricConfirmedBookingsSub.Text = "Active passengers";
            // 
            // lblMetricPendingBookingsSub
            // 
            lblMetricPendingBookingsSub.Font = new Font("Segoe UI", 8F);
            lblMetricPendingBookingsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricPendingBookingsSub.Location = new Point(12, 62);
            lblMetricPendingBookingsSub.Name = "lblMetricPendingBookingsSub";
            lblMetricPendingBookingsSub.Size = new Size(200, 16);
            lblMetricPendingBookingsSub.TabIndex = 0;
            lblMetricPendingBookingsSub.Text = "Awaiting clearance";
            // 
            // lblMetricCancelledBookingsSub
            // 
            lblMetricCancelledBookingsSub.Font = new Font("Segoe UI", 8F);
            lblMetricCancelledBookingsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricCancelledBookingsSub.Location = new Point(12, 62);
            lblMetricCancelledBookingsSub.Name = "lblMetricCancelledBookingsSub";
            lblMetricCancelledBookingsSub.Size = new Size(200, 16);
            lblMetricCancelledBookingsSub.TabIndex = 0;
            lblMetricCancelledBookingsSub.Text = "Seats released";
            // 
            // lblMetricTodayBookingsSub
            // 
            lblMetricTodayBookingsSub.Font = new Font("Segoe UI", 8F);
            lblMetricTodayBookingsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricTodayBookingsSub.Location = new Point(12, 62);
            lblMetricTodayBookingsSub.Name = "lblMetricTodayBookingsSub";
            lblMetricTodayBookingsSub.Size = new Size(200, 16);
            lblMetricTodayBookingsSub.TabIndex = 0;
            lblMetricTodayBookingsSub.Text = "Reservations today";
            // 
            // lblMetricTotalTicketsSub
            // 
            lblMetricTotalTicketsSub.Font = new Font("Segoe UI", 8F);
            lblMetricTotalTicketsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricTotalTicketsSub.Location = new Point(12, 62);
            lblMetricTotalTicketsSub.Name = "lblMetricTotalTicketsSub";
            lblMetricTotalTicketsSub.Size = new Size(200, 16);
            lblMetricTotalTicketsSub.TabIndex = 0;
            lblMetricTotalTicketsSub.Text = "All issued passes";
            // 
            // lblMetricValidTicketsSub
            // 
            lblMetricValidTicketsSub.Font = new Font("Segoe UI", 8F);
            lblMetricValidTicketsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricValidTicketsSub.Location = new Point(12, 62);
            lblMetricValidTicketsSub.Name = "lblMetricValidTicketsSub";
            lblMetricValidTicketsSub.Size = new Size(200, 16);
            lblMetricValidTicketsSub.TabIndex = 0;
            lblMetricValidTicketsSub.Text = "Ready for boarding";
            // 
            // lblMetricBoardedTicketsSub
            // 
            lblMetricBoardedTicketsSub.Font = new Font("Segoe UI", 8F);
            lblMetricBoardedTicketsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricBoardedTicketsSub.Location = new Point(12, 62);
            lblMetricBoardedTicketsSub.Name = "lblMetricBoardedTicketsSub";
            lblMetricBoardedTicketsSub.Size = new Size(200, 16);
            lblMetricBoardedTicketsSub.TabIndex = 0;
            lblMetricBoardedTicketsSub.Text = "Cleared passengers";
            // 
            // lblMetricCancelledTicketsSub
            // 
            lblMetricCancelledTicketsSub.Font = new Font("Segoe UI", 8F);
            lblMetricCancelledTicketsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricCancelledTicketsSub.Location = new Point(12, 62);
            lblMetricCancelledTicketsSub.Name = "lblMetricCancelledTicketsSub";
            lblMetricCancelledTicketsSub.Size = new Size(200, 16);
            lblMetricCancelledTicketsSub.TabIndex = 0;
            lblMetricCancelledTicketsSub.Text = "Voided / refunded";
            // 
            // lblMetricTodayTicketsSub
            // 
            lblMetricTodayTicketsSub.Font = new Font("Segoe UI", 8F);
            lblMetricTodayTicketsSub.ForeColor = Color.FromArgb(148, 163, 184);
            lblMetricTodayTicketsSub.Location = new Point(12, 62);
            lblMetricTodayTicketsSub.Name = "lblMetricTodayTicketsSub";
            lblMetricTodayTicketsSub.Size = new Size(200, 16);
            lblMetricTodayTicketsSub.TabIndex = 0;
            lblMetricTodayTicketsSub.Text = "Departures today";
            // 
            // TicketOfficerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1946, 1106);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelTopBar);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1786, 1078);
            Name = "TicketOfficerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bus Ticket Management - Ticket Officer Portal";
            panelPassengers.ResumeLayout(false);
            panelPassengerActions.ResumeLayout(false);
            panelPassengersToolbar.ResumeLayout(false);
            panelPassengersToolbar.PerformLayout();
            flowPassengerMetrics.ResumeLayout(false);
            cardTotalPassengers.ResumeLayout(false);
            cardActivePassengers.ResumeLayout(false);
            cardNewPassengersToday.ResumeLayout(false);
            panelPassengersHeader.ResumeLayout(false);
            panelPassengersHeader.PerformLayout();
            panelBookingHistory.ResumeLayout(false);
            panelHistoryActions.ResumeLayout(false);
            panelHistoryToolbar.ResumeLayout(false);
            panelHistoryToolbar.PerformLayout();
            flowHistoryMetrics.ResumeLayout(false);
            cardHistoryTotal.ResumeLayout(false);
            cardHistoryCompleted.ResumeLayout(false);
            cardHistoryCancelled.ResumeLayout(false);
            panelHistoryHeader.ResumeLayout(false);
            panelHistoryHeader.PerformLayout();
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelOfficerProfile.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelPayments.ResumeLayout(false);
            panelPaymentActions.ResumeLayout(false);
            panelPaymentsToolbar.ResumeLayout(false);
            panelPaymentsToolbar.PerformLayout();
            flowPaymentMetrics.ResumeLayout(false);
            cardPayTotal.ResumeLayout(false);
            cardPayCash.ResumeLayout(false);
            cardPayDigital.ResumeLayout(false);
            cardPayRefunds.ResumeLayout(false);
            panelPaymentsHeader.ResumeLayout(false);
            panelPaymentsHeader.PerformLayout();
            panelTicketManagement.ResumeLayout(false);
            panelTicketActions.ResumeLayout(false);
            panelTicketsToolbar.ResumeLayout(false);
            panelTicketsToolbar.PerformLayout();
            flowTicketMetrics.ResumeLayout(false);
            cardTotalTickets.ResumeLayout(false);
            cardValidTickets.ResumeLayout(false);
            cardBoardedTickets.ResumeLayout(false);
            cardCancelledTickets.ResumeLayout(false);
            cardTodayTickets.ResumeLayout(false);
            panelTicketsHeader.ResumeLayout(false);
            panelTicketsHeader.PerformLayout();
            panelBookingManagement.ResumeLayout(false);
            panelBookingActions.ResumeLayout(false);
            panelBookingsToolbar.ResumeLayout(false);
            panelBookingsToolbar.PerformLayout();
            flowBookingMetrics.ResumeLayout(false);
            cardTotalBookings.ResumeLayout(false);
            cardConfirmedBookings.ResumeLayout(false);
            cardPendingBookings.ResumeLayout(false);
            cardCancelledBookings.ResumeLayout(false);
            cardTodayBookings.ResumeLayout(false);
            panelBookingsHeader.ResumeLayout(false);
            panelBookingsHeader.PerformLayout();
            panelHeaderInfo.ResumeLayout(false);
            panelHeaderInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNavPassengers;
        private Button btnNavBookings;
        private Button btnNavTickets;
        private Button btnNavPayments;
        private Button btnNavHistory;
        private Button btnNavLogout;
        private Panel panelPassengers;
        private Panel panelPassengersHeader;
        private Label lblPassengersTitle;
        private Label lblPassengersSubtitle;
        private Button btnAddPassenger;
        private FlowLayoutPanel flowPassengerMetrics;
        private Panel cardTotalPassengers;
        private Label lblMetricTotalPassengersVal;
        private Label lblMetricTotalPassengersTitle;
        private Panel cardActivePassengers;
        private Label lblMetricActivePassengersVal;
        private Label lblMetricActivePassengersTitle;
        private Panel cardNewPassengersToday;
        private Label lblMetricNewPassengersTodayVal;
        private Label lblMetricNewPassengersTodayTitle;
        private Panel panelPassengersToolbar;
        private TextBox txtSearchPassenger;
        private ComboBox cmbPassengerStatusFilter;
        private Button btnRefreshPassengers;
        private ListView lvPassengers;
        private ColumnHeader colPassId;
        private ColumnHeader colPassFullName;
        private ColumnHeader colPassUsername;
        private ColumnHeader colPassEmail;
        private ColumnHeader colPassPhone;
        private ColumnHeader colPassAddress;
        private ColumnHeader colPassStatus;
        private ColumnHeader colPassCreatedDate;
        private Panel panelPassengerActions;
        private Button btnEditPassenger;
        private Button btnViewPassenger;
        private Label lblPassengerCount;
        private Panel panelBookingHistory;
        private Panel panelHistoryHeader;
        private Label lblHistoryTitle;
        private FlowLayoutPanel flowHistoryMetrics;
        private Panel cardHistoryTotal;
        private Label lblMetricHistoryTotalVal;
        private Label lblMetricHistoryTotalTitle;
        private Panel cardHistoryCompleted;
        private Label lblMetricHistoryCompletedVal;
        private Label lblMetricHistoryCompletedTitle;
        private Panel cardHistoryCancelled;
        private Label lblMetricHistoryCancelledVal;
        private Label lblMetricHistoryCancelledTitle;
        private Panel panelHistoryToolbar;
        private TextBox txtSearchHistory;
        private ComboBox cmbHistoryStatusFilter;
        private Button btnRefreshHistory;
        private ListView lvBookingHistory;
        private ColumnHeader colHistBookingId;
        private ColumnHeader colHistPassengerName;
        private ColumnHeader colHistPassengerPhone;
        private ColumnHeader colHistRoute;
        private ColumnHeader colHistTravelDate;
        private ColumnHeader colHistDepartureTime;
        private ColumnHeader colHistSeats;
        private ColumnHeader colHistTotalAmount;
        private ColumnHeader colHistBookingStatus;
        private ColumnHeader colHistPaymentStatus;
        private Panel panelHistoryActions;
        private Button btnPrintHistoryPass;
        private Button btnViewHistoryDetails;
        private Label lblHistoryCount;
        private Panel panelTopBar;
        private Label lblAppIcon;
        private Label lblPortalTitle;
        private Panel panelOfficerProfile;
        private Label lblOfficerName;
        private Label lblOfficerRole;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Panel panelSidebar;
        private Label lblNavHeader;
        private Panel panelMain;
        private Panel panelHeaderInfo;
        private Label lblPageHeading;
        private Panel panelBookingManagement;
        private Panel panelBookingsHeader;
        private Label lblBookingsTitle;
        private Label lblBookingsSubtitle;
        private Button btnNewBooking;
        private FlowLayoutPanel flowBookingMetrics;
        private Panel cardTotalBookings;
        private Label lblMetricTotalBookingsVal;
        private Label lblMetricTotalBookingsTitle;
        private Label lblMetricTotalBookingsSub;
        private Panel cardConfirmedBookings;
        private Label lblMetricConfirmedBookingsVal;
        private Label lblMetricConfirmedBookingsTitle;
        private Label lblMetricConfirmedBookingsSub;
        private Panel cardPendingBookings;
        private Label lblMetricPendingBookingsVal;
        private Label lblMetricPendingBookingsTitle;
        private Label lblMetricPendingBookingsSub;
        private Panel cardCancelledBookings;
        private Label lblMetricCancelledBookingsVal;
        private Label lblMetricCancelledBookingsTitle;
        private Label lblMetricCancelledBookingsSub;
        private Panel cardTodayBookings;
        private Label lblMetricTodayBookingsVal;
        private Label lblMetricTodayBookingsTitle;
        private Label lblMetricTodayBookingsSub;
        private Panel panelBookingsToolbar;
        private TextBox txtSearchBooking;
        private ComboBox cmbBookingStatusFilter;
        private ComboBox cmbBookingRouteFilter;
        private CheckBox chkEnableDateFilter;
        private DateTimePicker dtpBookingFilterDate;
        private Button btnResetBookingFilters;
        private ListView lvBookings;
        private ColumnHeader colBookingId;
        private ColumnHeader colPassengerName;
        private ColumnHeader colPassengerPhone;
        private ColumnHeader colBookingRoute;
        private ColumnHeader colTravelDate;
        private ColumnHeader colDepartureTime;
        private ColumnHeader colSeats;
        private ColumnHeader colTotalAmount;
        private ColumnHeader colBookingStatus;
        private ColumnHeader colPaymentStatus;
        private Panel panelBookingActions;
        private Button btnViewBookingDetails;
        private Button btnModifyBooking;
        private Button btnCancelBookingAction;
        private Button btnPrintTicket;
        private Label lblBookingCount;
        private Panel panelTicketManagement;
        private Panel panelTicketsHeader;
        private Label lblTicketsTitle;
        private Label lblTicketsSubtitle;
        private Button btnNewTicket;
        private Button btnVerifyBoardModal;
        private FlowLayoutPanel flowTicketMetrics;
        private Panel cardTotalTickets;
        private Label lblMetricTotalTicketsVal;
        private Label lblMetricTotalTicketsTitle;
        private Label lblMetricTotalTicketsSub;
        private Panel cardValidTickets;
        private Label lblMetricValidTicketsVal;
        private Label lblMetricValidTicketsTitle;
        private Label lblMetricValidTicketsSub;
        private Panel cardBoardedTickets;
        private Label lblMetricBoardedTicketsVal;
        private Label lblMetricBoardedTicketsTitle;
        private Label lblMetricBoardedTicketsSub;
        private Panel cardCancelledTickets;
        private Label lblMetricCancelledTicketsVal;
        private Label lblMetricCancelledTicketsTitle;
        private Label lblMetricCancelledTicketsSub;
        private Panel cardTodayTickets;
        private Label lblMetricTodayTicketsVal;
        private Label lblMetricTodayTicketsTitle;
        private Label lblMetricTodayTicketsSub;
        private Panel panelTicketsToolbar;
        private TextBox txtSearchTicketFilter;
        private ComboBox cmbTicketStatusFilter;
        private ComboBox cmbTicketRouteFilter;
        private CheckBox chkEnableTicketDateFilter;
        private DateTimePicker dtpTicketFilterDate;
        private Button btnResetTicketFilters;
        private ListView lvTickets;
        private ColumnHeader colTicketId;
        private ColumnHeader colTicketBookingRef;
        private ColumnHeader colTicketPassenger;
        private ColumnHeader colTicketPhone;
        private ColumnHeader colTicketRoute;
        private ColumnHeader colTicketDate;
        private ColumnHeader colTicketTime;
        private ColumnHeader colTicketSeat;
        private ColumnHeader colTicketGate;
        private ColumnHeader colTicketBus;
        private ColumnHeader colTicketStatus;
        private Panel panelTicketActions;
        private Button btnViewTicketDetails;
        private Button btnVerifyAndBoard;
        private Button btnPrintTicketPass;
        private Button btnCancelTicketAction;
        private Label lblTicketCount;
        private ColumnHeader colManTicketId;
        private ColumnHeader colManBookingId;
        private Panel panelPayments;
        private Panel panelPaymentsHeader;
        private Label lblPaymentsTitle;
        private Label lblPaymentsSubtitle;
        private FlowLayoutPanel flowPaymentMetrics;
        private Panel cardPayTotal;
        private Label lblPayTotalVal;
        private Label lblPayTotalTitle;
        private Panel cardPayCash;
        private Label lblPayCashVal;
        private Label lblPayCashTitle;
        private Panel cardPayDigital;
        private Label lblPayDigitalVal;
        private Label lblPayDigitalTitle;
        private Panel cardPayRefunds;
        private Label lblPayRefundsVal;
        private Label lblPayRefundsTitle;
        private Panel panelPaymentsToolbar;
        private TextBox txtSearchPayments;
        private ComboBox cmbPaymentMethodFilter;
        private ComboBox cmbPaymentStatusFilter;
        private Button btnRefreshPayments;
        private ListView lvPayments;
        private ColumnHeader colPayReceipt;
        private ColumnHeader colPayBooking;
        private ColumnHeader colPayTicket;
        private ColumnHeader colPayPassenger;
        private ColumnHeader colPayRoute;
        private ColumnHeader colPayAmount;
        private ColumnHeader colPayMethod;
        private ColumnHeader colPayStatus;
        private ColumnHeader colPayDate;
        private ColumnHeader colPayCashier;
        private Panel panelPaymentActions;
        private Button btnPrintReceipt;
        private Button btnRecordPayment;
        private Button btnProcessRefund;
        private Label lblPaymentCount;
    }
}

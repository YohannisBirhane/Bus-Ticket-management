using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        // Top Navigation Bar
        private Panel panelTopBar;
        private Label lblAppIcon;
        private Label lblPortalTitle;
        private Panel panelAdminProfile;
        private Label lblAdminName;
        private Label lblAdminRole;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;

        // Sidebar Navigation
        private Panel panelSidebar;
        private Label lblNavHeader;
        private Button btnNavDashboard;
        private Button btnNavUsers;
        private Button btnNavBuses;
        private Button btnNavRoutes;
        private Button btnNavTrips;
        private Button btnNavBookings;
        private Button btnNavTickets;
        private Button btnNavPayments;
        private Button btnNavSettings;
        private Button btnNavLogout;

        // Main Content Area
        private Panel panelMain;
        private Panel panelHeaderInfo;
        private Label lblPageHeading;
        private Label lblPageSubHeading;
        private FlowLayoutPanel flowDashboard;

        // Dashboard GroupBoxes
        private GroupBox grpOverview;
        private Panel cardBuses;
        private Label lblMetricBusesVal;
        private Label lblMetricBusesTitle;
        private Panel cardTrips;
        private Label lblMetricTripsVal;
        private Label lblMetricTripsTitle;
        private Panel cardBookings;
        private Label lblMetricBookingsVal;
        private Label lblMetricBookingsTitle;
        private Panel cardRevenue;
        private Label lblMetricRevenueVal;
        private Label lblMetricRevenueTitle;

        private GroupBox grpQuickActions;
        private Button btnQuickAddBus;
        private Button btnQuickNewTrip;

        private GroupBox grpTripsSchedule;
        private DataGridView dgvTrips;

        private GroupBox grpTicketVerify;
        private Label lblTicketSearchPrompt;
        private ModernTextBox txtTicketNumber;
        private ModernButton btnVerifyTicket;
        private Label lblVerifyResult;

        // User Management Section
        private Panel panelUserManagement;
        private Panel panelUsersHeader;
        private Label lblUsersTitle;
        private Label lblUsersSubtitle;
        private Panel panelUsersToolbar;
        private Button btnAddUser;
        private TextBox txtSearchUser;
        private ComboBox cmbRoleFilter;
        private ComboBox cmbStatusFilter;
        private Button btnRefreshUsers;
        private ListView lvUsers;
        private ColumnHeader colUserId;
        private ColumnHeader colFullName;
        private ColumnHeader colUsername;
        private ColumnHeader colEmail;
        private ColumnHeader colPhone;
        private ColumnHeader colRole;
        private ColumnHeader colStatus;
        private ColumnHeader colCreatedDate;
        private Panel panelUserActions;
        private Button btnViewUserDetails;
        private Button btnEditUser;
        private Button btnToggleUserStatus;
        private Button btnResetUserPassword;
        private Button btnDeleteUser;
        private Label lblUserCount;

        // Bus Management Section
        private Panel panelBusManagement;
        private Panel panelBusesHeader;
        private Label lblBusesTitle;
        private Label lblBusesSubtitle;
        private Button btnAddBus;

        private FlowLayoutPanel flowBusMetrics;
        private Panel cardTotalBuses;
        private Label lblMetricTotalBusesVal;
        private Label lblMetricTotalBusesTitle;
        private Label lblMetricTotalBusesSub;
        private Panel cardActiveBuses;
        private Label lblMetricActiveBusesVal;
        private Label lblMetricActiveBusesTitle;
        private Label lblMetricActiveBusesSub;
        private Panel cardMaintenanceBuses;
        private Label lblMetricMaintBusesVal;
        private Label lblMetricMaintBusesTitle;
        private Label lblMetricMaintBusesSub;
        private Panel cardInactiveBuses;
        private Label lblMetricInactiveBusesVal;
        private Label lblMetricInactiveBusesTitle;
        private Label lblMetricInactiveBusesSub;

        private Panel panelBusesToolbar;
        private TextBox txtSearchBus;
        private ComboBox cmbBusTypeFilter;
        private ComboBox cmbBusStatusFilter;
        private Button btnRefreshBuses;

        private ListView lvBuses;
        private ColumnHeader colBusId;
        private ColumnHeader colPlateNumber;
        private ColumnHeader colBusModel;
        private ColumnHeader colBusType;
        private ColumnHeader colCapacity;
        private ColumnHeader colRegDate;
        private ColumnHeader colBusStatus;
        private ColumnHeader colAssignedTrip;

        private Panel panelBusActions;
        private Button btnViewBusDetails;
        private Button btnEditBus;
        private Button btnChangeBusStatus;
        private Button btnDeleteBus;
        private Label lblBusCount;

        // Route Management Section
        private Panel panelRouteManagement;
        private Panel panelRoutesHeader;
        private Label lblRoutesTitle;
        private Label lblRoutesSubtitle;
        private Button btnAddRoute;

        private FlowLayoutPanel flowRouteMetrics;
        private Panel cardTotalRoutes;
        private Label lblMetricTotalRoutesVal;
        private Label lblMetricTotalRoutesTitle;
        private Label lblMetricTotalRoutesSub;
        private Panel cardActiveRoutes;
        private Label lblMetricActiveRoutesVal;
        private Label lblMetricActiveRoutesTitle;
        private Label lblMetricActiveRoutesSub;
        private Panel cardInactiveRoutes;
        private Label lblMetricInactiveRoutesVal;
        private Label lblMetricInactiveRoutesTitle;
        private Label lblMetricInactiveRoutesSub;
        private Panel cardTotalDistance;
        private Label lblMetricTotalDistanceVal;
        private Label lblMetricTotalDistanceTitle;
        private Label lblMetricTotalDistanceSub;

        private Panel panelRoutesToolbar;
        private TextBox txtSearchRoute;
        private ComboBox cmbRouteStatusFilter;
        private Button btnRefreshRoutes;

        private ListView lvRoutes;
        private ColumnHeader colRouteId;
        private ColumnHeader colRouteName;
        private ColumnHeader colSource;
        private ColumnHeader colDestination;
        private ColumnHeader colDistance;
        private ColumnHeader colEstimatedTime;
        private ColumnHeader colBaseFare;
        private ColumnHeader colRouteStatus;
        private ColumnHeader colIntermediateStops;

        private Panel panelRouteActions;
        private Button btnViewRouteDetails;
        private Button btnEditRoute;
        private Button btnToggleRouteStatus;
        private Button btnDeleteRoute;
        private Label lblRouteCount;

        // Booking Management Section
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

        // Ticket Management Section
        private Panel panelTicketManagement;
        private Panel panelTicketsHeader;
        private Label lblTicketsTitle;
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
            panelTopBar = new Panel();
            lblAppIcon = new Label();
            lblPortalTitle = new Label();
            panelAdminProfile = new Panel();
            lblAdminName = new Label();
            lblAdminRole = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            panelSidebar = new Panel();
            btnNavLogout = new Button();
            btnNavSettings = new Button();
            btnNavPayments = new Button();
            btnNavTickets = new Button();
            btnNavBookings = new Button();
            btnNavTrips = new Button();
            btnNavRoutes = new Button();
            btnNavBuses = new Button();
            btnNavUsers = new Button();
            btnNavDashboard = new Button();
            lblNavHeader = new Label();
            panelMain = new Panel();
            panelTicketManagement = new Panel();
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
            panelTicketActions = new Panel();
            btnViewTicketDetails = new Button();
            btnVerifyAndBoard = new Button();
            btnPrintTicketPass = new Button();
            btnCancelTicketAction = new Button();
            lblTicketCount = new Label();
            panelTicketsToolbar = new Panel();
            txtSearchTicketFilter = new TextBox();
            cmbTicketStatusFilter = new ComboBox();
            cmbTicketRouteFilter = new ComboBox();
            chkEnableTicketDateFilter = new CheckBox();
            dtpTicketFilterDate = new DateTimePicker();
            btnResetTicketFilters = new Button();
            flowTicketMetrics = new FlowLayoutPanel();
            cardTotalTickets = new Panel();
            lblMetricTotalTicketsSub = new Label();
            lblMetricTotalTicketsVal = new Label();
            lblMetricTotalTicketsTitle = new Label();
            cardValidTickets = new Panel();
            lblMetricValidTicketsSub = new Label();
            lblMetricValidTicketsVal = new Label();
            lblMetricValidTicketsTitle = new Label();
            cardBoardedTickets = new Panel();
            lblMetricBoardedTicketsSub = new Label();
            lblMetricBoardedTicketsVal = new Label();
            lblMetricBoardedTicketsTitle = new Label();
            cardCancelledTickets = new Panel();
            lblMetricCancelledTicketsSub = new Label();
            lblMetricCancelledTicketsVal = new Label();
            lblMetricCancelledTicketsTitle = new Label();
            cardTodayTickets = new Panel();
            lblMetricTodayTicketsSub = new Label();
            lblMetricTodayTicketsVal = new Label();
            lblMetricTodayTicketsTitle = new Label();
            panelTicketsHeader = new Panel();
            btnVerifyBoardModal = new Button();
            btnNewTicket = new Button();
            lblTicketsTitle = new Label();
            panelBookingManagement = new Panel();
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
            panelBookingActions = new Panel();
            btnViewBookingDetails = new Button();
            btnModifyBooking = new Button();
            btnCancelBookingAction = new Button();
            btnPrintTicket = new Button();
            lblBookingCount = new Label();
            panelBookingsToolbar = new Panel();
            txtSearchBooking = new TextBox();
            cmbBookingStatusFilter = new ComboBox();
            cmbBookingRouteFilter = new ComboBox();
            chkEnableDateFilter = new CheckBox();
            dtpBookingFilterDate = new DateTimePicker();
            btnResetBookingFilters = new Button();
            flowBookingMetrics = new FlowLayoutPanel();
            cardTotalBookings = new Panel();
            lblMetricTotalBookingsVal = new Label();
            lblMetricTotalBookingsTitle = new Label();
            lblMetricTotalBookingsSub = new Label();
            cardConfirmedBookings = new Panel();
            lblMetricConfirmedBookingsVal = new Label();
            lblMetricConfirmedBookingsTitle = new Label();
            lblMetricConfirmedBookingsSub = new Label();
            cardPendingBookings = new Panel();
            lblMetricPendingBookingsVal = new Label();
            lblMetricPendingBookingsTitle = new Label();
            lblMetricPendingBookingsSub = new Label();
            cardCancelledBookings = new Panel();
            lblMetricCancelledBookingsVal = new Label();
            lblMetricCancelledBookingsTitle = new Label();
            lblMetricCancelledBookingsSub = new Label();
            cardTodayBookings = new Panel();
            lblMetricTodayBookingsVal = new Label();
            lblMetricTodayBookingsTitle = new Label();
            lblMetricTodayBookingsSub = new Label();
            panelBookingsHeader = new Panel();
            btnNewBooking = new Button();
            lblBookingsTitle = new Label();
            lblBookingsSubtitle = new Label();
            panelRouteManagement = new Panel();
            lvRoutes = new ListView();
            colRouteId = new ColumnHeader();
            colRouteName = new ColumnHeader();
            colSource = new ColumnHeader();
            colDestination = new ColumnHeader();
            colDistance = new ColumnHeader();
            colEstimatedTime = new ColumnHeader();
            colBaseFare = new ColumnHeader();
            colRouteStatus = new ColumnHeader();
            colIntermediateStops = new ColumnHeader();
            panelRouteActions = new Panel();
            btnViewRouteDetails = new Button();
            btnEditRoute = new Button();
            btnToggleRouteStatus = new Button();
            btnDeleteRoute = new Button();
            lblRouteCount = new Label();
            panelRoutesToolbar = new Panel();
            txtSearchRoute = new TextBox();
            cmbRouteStatusFilter = new ComboBox();
            btnRefreshRoutes = new Button();
            flowRouteMetrics = new FlowLayoutPanel();
            cardTotalRoutes = new Panel();
            lblMetricTotalRoutesVal = new Label();
            lblMetricTotalRoutesTitle = new Label();
            lblMetricTotalRoutesSub = new Label();
            cardActiveRoutes = new Panel();
            lblMetricActiveRoutesVal = new Label();
            lblMetricActiveRoutesTitle = new Label();
            lblMetricActiveRoutesSub = new Label();
            cardInactiveRoutes = new Panel();
            lblMetricInactiveRoutesVal = new Label();
            lblMetricInactiveRoutesTitle = new Label();
            lblMetricInactiveRoutesSub = new Label();
            cardTotalDistance = new Panel();
            lblMetricTotalDistanceVal = new Label();
            lblMetricTotalDistanceTitle = new Label();
            lblMetricTotalDistanceSub = new Label();
            panelRoutesHeader = new Panel();
            btnAddRoute = new Button();
            lblRoutesTitle = new Label();
            lblRoutesSubtitle = new Label();
            panelBusManagement = new Panel();
            lvBuses = new ListView();
            colBusId = new ColumnHeader();
            colPlateNumber = new ColumnHeader();
            colBusModel = new ColumnHeader();
            colBusType = new ColumnHeader();
            colCapacity = new ColumnHeader();
            colRegDate = new ColumnHeader();
            colBusStatus = new ColumnHeader();
            colAssignedTrip = new ColumnHeader();
            panelBusActions = new Panel();
            btnViewBusDetails = new Button();
            btnEditBus = new Button();
            btnChangeBusStatus = new Button();
            btnDeleteBus = new Button();
            lblBusCount = new Label();
            panelBusesToolbar = new Panel();
            txtSearchBus = new TextBox();
            cmbBusTypeFilter = new ComboBox();
            cmbBusStatusFilter = new ComboBox();
            btnRefreshBuses = new Button();
            flowBusMetrics = new FlowLayoutPanel();
            cardTotalBuses = new Panel();
            lblMetricTotalBusesVal = new Label();
            lblMetricTotalBusesTitle = new Label();
            lblMetricTotalBusesSub = new Label();
            cardActiveBuses = new Panel();
            lblMetricActiveBusesVal = new Label();
            lblMetricActiveBusesTitle = new Label();
            lblMetricActiveBusesSub = new Label();
            cardMaintenanceBuses = new Panel();
            lblMetricMaintBusesVal = new Label();
            lblMetricMaintBusesTitle = new Label();
            lblMetricMaintBusesSub = new Label();
            cardInactiveBuses = new Panel();
            lblMetricInactiveBusesVal = new Label();
            lblMetricInactiveBusesTitle = new Label();
            lblMetricInactiveBusesSub = new Label();
            panelBusesHeader = new Panel();
            btnAddBus = new Button();
            lblBusesTitle = new Label();
            lblBusesSubtitle = new Label();
            panelUserManagement = new Panel();
            lvUsers = new ListView();
            colUserId = new ColumnHeader();
            colFullName = new ColumnHeader();
            colUsername = new ColumnHeader();
            colEmail = new ColumnHeader();
            colPhone = new ColumnHeader();
            colRole = new ColumnHeader();
            colStatus = new ColumnHeader();
            colCreatedDate = new ColumnHeader();
            panelUserActions = new Panel();
            btnViewUserDetails = new Button();
            btnEditUser = new Button();
            btnToggleUserStatus = new Button();
            btnResetUserPassword = new Button();
            btnDeleteUser = new Button();
            lblUserCount = new Label();
            panelUsersToolbar = new Panel();
            btnAddUser = new Button();
            txtSearchUser = new TextBox();
            cmbRoleFilter = new ComboBox();
            cmbStatusFilter = new ComboBox();
            btnRefreshUsers = new Button();
            panelUsersHeader = new Panel();
            lblUsersTitle = new Label();
            lblUsersSubtitle = new Label();
            flowDashboard = new FlowLayoutPanel();
            grpOverview = new GroupBox();
            cardBuses = new Panel();
            lblMetricBusesVal = new Label();
            lblMetricBusesTitle = new Label();
            cardTrips = new Panel();
            lblMetricTripsVal = new Label();
            lblMetricTripsTitle = new Label();
            cardBookings = new Panel();
            lblMetricBookingsVal = new Label();
            lblMetricBookingsTitle = new Label();
            cardRevenue = new Panel();
            lblMetricRevenueVal = new Label();
            lblMetricRevenueTitle = new Label();
            grpQuickActions = new GroupBox();
            btnQuickAddBus = new Button();
            btnQuickNewTrip = new Button();
            grpTripsSchedule = new GroupBox();
            dgvTrips = new DataGridView();
            grpTicketVerify = new GroupBox();
            lblTicketSearchPrompt = new Label();
            txtTicketNumber = new ModernTextBox();
            btnVerifyTicket = new ModernButton();
            lblVerifyResult = new Label();
            panelHeaderInfo = new Panel();
            lblPageHeading = new Label();

            lblPageSubHeading = new Label();
            panelTopBar.SuspendLayout();
            panelAdminProfile.SuspendLayout();
            panelSidebar.SuspendLayout();
            panelMain.SuspendLayout();
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
            panelRouteManagement.SuspendLayout();
            panelRouteActions.SuspendLayout();
            panelRoutesToolbar.SuspendLayout();
            flowRouteMetrics.SuspendLayout();
            cardTotalRoutes.SuspendLayout();
            cardActiveRoutes.SuspendLayout();
            cardInactiveRoutes.SuspendLayout();
            cardTotalDistance.SuspendLayout();
            panelRoutesHeader.SuspendLayout();
            panelBusManagement.SuspendLayout();
            panelBusActions.SuspendLayout();
            panelBusesToolbar.SuspendLayout();
            flowBusMetrics.SuspendLayout();
            cardTotalBuses.SuspendLayout();
            cardActiveBuses.SuspendLayout();
            cardMaintenanceBuses.SuspendLayout();
            cardInactiveBuses.SuspendLayout();
            panelBusesHeader.SuspendLayout();
            panelUserManagement.SuspendLayout();
            panelUserActions.SuspendLayout();
            panelUsersToolbar.SuspendLayout();
            panelUsersHeader.SuspendLayout();
            flowDashboard.SuspendLayout();
            grpOverview.SuspendLayout();
            cardBuses.SuspendLayout();
            cardTrips.SuspendLayout();
            cardBookings.SuspendLayout();
            cardRevenue.SuspendLayout();
            grpQuickActions.SuspendLayout();
            grpTripsSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTrips).BeginInit();
            grpTicketVerify.SuspendLayout();
            panelHeaderInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panelTopBar
            // 
            panelTopBar.BackColor = Color.FromArgb(15, 23, 42);
            panelTopBar.Controls.Add(lblAppIcon);
            panelTopBar.Controls.Add(lblPortalTitle);
            panelTopBar.Controls.Add(panelAdminProfile);
            panelTopBar.Controls.Add(btnMinimize);
            panelTopBar.Controls.Add(btnMaximize);
            panelTopBar.Controls.Add(btnClose);
            panelTopBar.Dock = DockStyle.Top;
            panelTopBar.Location = new Point(0, 0);
            panelTopBar.Margin = new Padding(4, 5, 4, 5);
            panelTopBar.Name = "panelTopBar";
            panelTopBar.Size = new Size(1771, 73);
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
            lblPortalTitle.Size = new Size(482, 30);
            lblPortalTitle.TabIndex = 1;
            lblPortalTitle.Text = "Bus Ticket Management  |  Administrator Portal";
            // 
            // panelAdminProfile
            // 
            panelAdminProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelAdminProfile.Controls.Add(lblAdminName);
            panelAdminProfile.Controls.Add(lblAdminRole);
            panelAdminProfile.Location = new Point(1271, 7);
            panelAdminProfile.Margin = new Padding(4, 5, 4, 5);
            panelAdminProfile.Name = "panelAdminProfile";
            panelAdminProfile.Size = new Size(286, 60);
            panelAdminProfile.TabIndex = 2;
            // 
            // lblAdminName
            // 
            lblAdminName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAdminName.ForeColor = Color.White;
            lblAdminName.Location = new Point(0, 3);
            lblAdminName.Margin = new Padding(4, 0, 4, 0);
            lblAdminName.Name = "lblAdminName";
            lblAdminName.Size = new Size(271, 27);
            lblAdminName.TabIndex = 0;
            lblAdminName.Text = "System Administrator";
            lblAdminName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAdminRole
            // 
            lblAdminRole.Font = new Font("Segoe UI", 8F);
            lblAdminRole.ForeColor = Color.FromArgb(148, 163, 184);
            lblAdminRole.Location = new Point(0, 30);
            lblAdminRole.Margin = new Padding(4, 0, 4, 0);
            lblAdminRole.Name = "lblAdminRole";
            lblAdminRole.Size = new Size(271, 23);
            lblAdminRole.TabIndex = 1;
            lblAdminRole.Text = "Super Admin • Active";
            lblAdminRole.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMinimize
            // 
            btnMinimize.Dock = DockStyle.Right;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Segoe UI", 10F);
            btnMinimize.ForeColor = Color.FromArgb(148, 163, 184);
            btnMinimize.Location = new Point(1573, 0);
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
            btnMaximize.Location = new Point(1639, 0);
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
            btnClose.Location = new Point(1705, 0);
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
            panelSidebar.Controls.Add(btnNavSettings);
            panelSidebar.Controls.Add(btnNavPayments);
            panelSidebar.Controls.Add(btnNavTickets);
            panelSidebar.Controls.Add(btnNavBookings);
            panelSidebar.Controls.Add(btnNavTrips);
            panelSidebar.Controls.Add(btnNavRoutes);
            panelSidebar.Controls.Add(btnNavBuses);
            panelSidebar.Controls.Add(btnNavUsers);
            panelSidebar.Controls.Add(btnNavDashboard);
            panelSidebar.Controls.Add(lblNavHeader);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 73);
            panelSidebar.Margin = new Padding(4, 5, 4, 5);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.AutoScroll = true;

            panelSidebar.Size = new Size(329, 1033);
            panelSidebar.TabIndex = 1;
            // 
            // btnNavLogout
            // 
            btnNavLogout.BackColor = Color.White;
            btnNavLogout.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavLogout.FlatAppearance.BorderSize = 2;
            btnNavLogout.FlatStyle = FlatStyle.Flat;
            btnNavLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavLogout.ForeColor = Color.FromArgb(71, 85, 105);
            btnNavLogout.Location = new Point(14, 1160);
            btnNavLogout.Margin = new Padding(4, 5, 4, 5);
            btnNavLogout.Name = "btnNavLogout";
            btnNavLogout.Padding = new Padding(20, 0, 0, 0);
            btnNavLogout.Size = new Size(300, 75);
            btnNavLogout.TabIndex = 14;
            btnNavLogout.Text = "🚪   Sign Out";
            btnNavLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnNavLogout.UseVisualStyleBackColor = false;
            // 
            // btnNavSettings
            // 
            btnNavSettings.BackColor = Color.White;
            btnNavSettings.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavSettings.FlatAppearance.BorderSize = 2;
            btnNavSettings.FlatStyle = FlatStyle.Flat;
            btnNavSettings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavSettings.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavSettings.Location = new Point(14, 1068);
            btnNavSettings.Margin = new Padding(4, 5, 4, 5);
            btnNavSettings.Name = "btnNavSettings";
            btnNavSettings.Padding = new Padding(20, 0, 0, 0);
            btnNavSettings.Size = new Size(300, 75);
            btnNavSettings.TabIndex = 12;
            btnNavSettings.Text = "⚙️   Settings";
            btnNavSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavSettings.UseVisualStyleBackColor = false;
            // 
            // btnNavPayments
            // 
            btnNavPayments.BackColor = Color.White;
            btnNavPayments.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavPayments.FlatAppearance.BorderSize = 2;
            btnNavPayments.FlatStyle = FlatStyle.Flat;
            btnNavPayments.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavPayments.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavPayments.Location = new Point(14, 702);
            btnNavPayments.Margin = new Padding(4, 5, 4, 5);
            btnNavPayments.Name = "btnNavPayments";
            btnNavPayments.Padding = new Padding(20, 0, 0, 0);
            btnNavPayments.Size = new Size(340, 75);
            btnNavPayments.TabIndex = 8;
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
            btnNavTickets.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavTickets.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavTickets.Location = new Point(14, 610);
            btnNavTickets.Margin = new Padding(4, 5, 4, 5);
            btnNavTickets.Name = "btnNavTickets";
            btnNavTickets.Padding = new Padding(20, 0, 0, 0);
            btnNavTickets.Size = new Size(340, 75);
            btnNavTickets.TabIndex = 7;
            btnNavTickets.Text = "🎫   Tickets";
            btnNavTickets.TextAlign = ContentAlignment.MiddleLeft;
            btnNavTickets.UseVisualStyleBackColor = false;
            // 
            // btnNavBookings
            // 
            btnNavBookings.BackColor = Color.White;
            btnNavBookings.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavBookings.FlatAppearance.BorderSize = 2;
            btnNavBookings.FlatStyle = FlatStyle.Flat;
            btnNavBookings.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavBookings.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavBookings.Location = new Point(14, 472);
            btnNavBookings.Margin = new Padding(4, 5, 4, 5);
            btnNavBookings.Name = "btnNavBookings";
            btnNavBookings.Padding = new Padding(20, 0, 0, 0);
            btnNavBookings.Size = new Size(340, 121);
            btnNavBookings.TabIndex = 6;
            btnNavBookings.Text = "📋   Bookings";
            btnNavBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBookings.UseVisualStyleBackColor = false;
            // 
            // btnNavTrips
            // 
            btnNavTrips.BackColor = Color.White;
            btnNavTrips.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavTrips.FlatAppearance.BorderSize = 2;
            btnNavTrips.FlatStyle = FlatStyle.Flat;
            btnNavTrips.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavTrips.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavTrips.Location = new Point(14, 376);
            btnNavTrips.Margin = new Padding(4, 5, 4, 5);
            btnNavTrips.Name = "btnNavTrips";
            btnNavTrips.Padding = new Padding(20, 0, 0, 0);
            btnNavTrips.Size = new Size(340, 126);
            btnNavTrips.TabIndex = 5;
            btnNavTrips.Text = "📅   Trip Schedules";
            btnNavTrips.TextAlign = ContentAlignment.MiddleLeft;
            btnNavTrips.UseVisualStyleBackColor = false;
            // 
            // btnNavRoutes
            // 
            btnNavRoutes.BackColor = Color.White;
            btnNavRoutes.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavRoutes.FlatAppearance.BorderSize = 2;
            btnNavRoutes.FlatStyle = FlatStyle.Flat;
            btnNavRoutes.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavRoutes.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavRoutes.Location = new Point(14, 293);
            btnNavRoutes.Margin = new Padding(4, 5, 4, 5);
            btnNavRoutes.Name = "btnNavRoutes";
            btnNavRoutes.Padding = new Padding(20, 0, 0, 0);
            btnNavRoutes.Size = new Size(340, 117);
            btnNavRoutes.TabIndex = 4;
            btnNavRoutes.Text = "🗺️   Routes";
            btnNavRoutes.TextAlign = ContentAlignment.MiddleLeft;
            btnNavRoutes.UseVisualStyleBackColor = false;
            // 
            // btnNavBuses
            // 
            btnNavBuses.BackColor = Color.White;
            btnNavBuses.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavBuses.FlatAppearance.BorderSize = 2;
            btnNavBuses.FlatStyle = FlatStyle.Flat;
            btnNavBuses.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavBuses.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavBuses.Location = new Point(14, 223);
            btnNavBuses.Margin = new Padding(4, 5, 4, 5);
            btnNavBuses.Name = "btnNavBuses";
            btnNavBuses.Padding = new Padding(20, 0, 0, 0);
            btnNavBuses.Size = new Size(340, 95);
            btnNavBuses.TabIndex = 3;
            btnNavBuses.Text = "🚌   Buses";
            btnNavBuses.TextAlign = ContentAlignment.MiddleLeft;
            btnNavBuses.UseVisualStyleBackColor = false;
            // 
            // btnNavUsers
            // 
            btnNavUsers.BackColor = Color.White;
            btnNavUsers.FlatAppearance.BorderColor = Color.FromArgb(148, 163, 184);
            btnNavUsers.FlatAppearance.BorderSize = 2;
            btnNavUsers.FlatStyle = FlatStyle.Flat;
            btnNavUsers.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavUsers.ForeColor = Color.FromArgb(30, 41, 59);
            btnNavUsers.Location = new Point(14, 128);
            btnNavUsers.Margin = new Padding(4, 5, 4, 5);
            btnNavUsers.Name = "btnNavUsers";
            btnNavUsers.Padding = new Padding(20, 0, 0, 0);
            btnNavUsers.Size = new Size(340, 99);
            btnNavUsers.TabIndex = 2;
            btnNavUsers.Text = "👥   Users";
            btnNavUsers.TextAlign = ContentAlignment.MiddleLeft;
            btnNavUsers.UseVisualStyleBackColor = false;
            // 
            // btnNavDashboard
            // 
            btnNavDashboard.BackColor = Color.FromArgb(226, 232, 240);
            btnNavDashboard.FlatAppearance.BorderColor = Color.FromArgb(15, 23, 42);
            btnNavDashboard.FlatAppearance.BorderSize = 2;
            btnNavDashboard.FlatStyle = FlatStyle.Flat;
            btnNavDashboard.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnNavDashboard.ForeColor = Color.FromArgb(15, 23, 42);
            btnNavDashboard.Location = new Point(14, 33);
            btnNavDashboard.Margin = new Padding(4, 5, 4, 5);
            btnNavDashboard.Name = "btnNavDashboard";
            btnNavDashboard.Padding = new Padding(20, 0, 0, 0);
            btnNavDashboard.Size = new Size(340, 102);
            btnNavDashboard.TabIndex = 1;
            btnNavDashboard.Text = "📊   Dashboard";
            btnNavDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnNavDashboard.UseVisualStyleBackColor = false;
            // 
            // lblNavHeader
            // 
            lblNavHeader.AutoSize = true;
            lblNavHeader.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblNavHeader.ForeColor = Color.FromArgb(100, 116, 139);
            lblNavHeader.Location = new Point(23, 20);
            lblNavHeader.Margin = new Padding(4, 0, 4, 0);
            lblNavHeader.Name = "lblNavHeader";
            lblNavHeader.Size = new Size(179, 21);
            lblNavHeader.TabIndex = 0;
            lblNavHeader.Text = "MANAGEMENT MENU";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.BackColor = Color.FromArgb(248, 250, 252);
            panelMain.Controls.Add(panelTicketManagement);
            panelMain.Controls.Add(panelBookingManagement);
            panelMain.Controls.Add(panelRouteManagement);
            panelMain.Controls.Add(panelBusManagement);
            panelMain.Controls.Add(panelUserManagement);
            panelMain.Controls.Add(flowDashboard);
            panelMain.Controls.Add(panelHeaderInfo);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(329, 73);
            panelMain.Margin = new Padding(4, 5, 4, 5);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(29, 33, 29, 33);
            panelMain.Size = new Size(1442, 1033);
            panelMain.TabIndex = 2;
            // 
            // panelTicketManagement
            // 
            panelTicketManagement.Controls.Add(lvTickets);
            panelTicketManagement.Controls.Add(panelTicketActions);
            panelTicketManagement.Controls.Add(panelTicketsToolbar);
            panelTicketManagement.Controls.Add(flowTicketMetrics);
            panelTicketManagement.Controls.Add(panelTicketsHeader);
            panelTicketManagement.Dock = DockStyle.Fill;
            panelTicketManagement.Location = new Point(29, 103);
            panelTicketManagement.Margin = new Padding(4, 5, 4, 5);
            panelTicketManagement.Name = "panelTicketManagement";
            panelTicketManagement.Size = new Size(1384, 897);
            panelTicketManagement.TabIndex = 7;
            panelTicketManagement.Visible = false;
            // 
            // lvTickets
            // 
            lvTickets.BorderStyle = BorderStyle.FixedSingle;
            lvTickets.Columns.AddRange(new ColumnHeader[] { colTicketId, colTicketBookingRef, colTicketPassenger, colTicketPhone, colTicketRoute, colTicketDate, colTicketTime, colTicketSeat, colTicketGate, colTicketBus, colTicketStatus });
            lvTickets.Dock = DockStyle.Fill;
            lvTickets.Font = new Font("Segoe UI", 9.5F);
            lvTickets.FullRowSelect = true;
            lvTickets.GridLines = true;
            lvTickets.Location = new Point(0, 277);
            lvTickets.Margin = new Padding(4, 5, 4, 5);
            lvTickets.MultiSelect = false;
            lvTickets.Name = "lvTickets";
            lvTickets.Size = new Size(1384, 533);
            lvTickets.TabIndex = 3;
            lvTickets.UseCompatibleStateImageBehavior = false;
            lvTickets.View = View.Details;
            // 
            // colTicketId
            // 
            colTicketId.Text = "Ticket Ref";
            colTicketId.Width = 90;
            // 
            // colTicketBookingRef
            // 
            colTicketBookingRef.Text = "Booking Ref";
            colTicketBookingRef.Width = 90;
            // 
            // colTicketPassenger
            // 
            colTicketPassenger.Text = "Passenger Name";
            colTicketPassenger.Width = 135;
            // 
            // colTicketPhone
            // 
            colTicketPhone.Text = "Phone";
            colTicketPhone.Width = 115;
            // 
            // colTicketRoute
            // 
            colTicketRoute.Text = "Route";
            colTicketRoute.Width = 175;
            // 
            // colTicketDate
            // 
            colTicketDate.Text = "Travel Date";
            colTicketDate.Width = 90;
            // 
            // colTicketTime
            // 
            colTicketTime.Text = "Departure";
            colTicketTime.Width = 80;
            // 
            // colTicketSeat
            // 
            colTicketSeat.Text = "Seat";
            colTicketSeat.Width = 65;
            // 
            // colTicketGate
            // 
            colTicketGate.Text = "Gate";
            colTicketGate.Width = 75;
            // 
            // colTicketBus
            // 
            colTicketBus.Text = "Coach";
            colTicketBus.Width = 120;
            // 
            // colTicketStatus
            // 
            colTicketStatus.Text = "Status";
            colTicketStatus.Width = 85;
            // 
            // panelTicketActions
            // 
            panelTicketActions.Controls.Add(btnViewTicketDetails);
            panelTicketActions.Controls.Add(btnVerifyAndBoard);
            panelTicketActions.Controls.Add(btnPrintTicketPass);
            panelTicketActions.Controls.Add(btnCancelTicketAction);
            panelTicketActions.Controls.Add(lblTicketCount);
            panelTicketActions.Dock = DockStyle.Bottom;
            panelTicketActions.Location = new Point(0, 810);
            panelTicketActions.Margin = new Padding(4, 5, 4, 5);
            panelTicketActions.Name = "panelTicketActions";
            panelTicketActions.Size = new Size(1384, 87);
            panelTicketActions.TabIndex = 4;
            // 
            // btnViewTicketDetails
            // 
            btnViewTicketDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewTicketDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewTicketDetails.FlatStyle = FlatStyle.Flat;
            btnViewTicketDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewTicketDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewTicketDetails.Location = new Point(0, 17);
            btnViewTicketDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewTicketDetails.Name = "btnViewTicketDetails";
            btnViewTicketDetails.Size = new Size(171, 57);
            btnViewTicketDetails.TabIndex = 0;
            btnViewTicketDetails.Text = "View Details";
            btnViewTicketDetails.UseVisualStyleBackColor = false;
            // 
            // btnVerifyAndBoard
            // 
            btnVerifyAndBoard.BackColor = Color.FromArgb(15, 23, 42);
            btnVerifyAndBoard.FlatAppearance.BorderSize = 0;
            btnVerifyAndBoard.FlatStyle = FlatStyle.Flat;
            btnVerifyAndBoard.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVerifyAndBoard.ForeColor = Color.White;
            btnVerifyAndBoard.Location = new Point(186, 17);
            btnVerifyAndBoard.Margin = new Padding(4, 5, 4, 5);
            btnVerifyAndBoard.Name = "btnVerifyAndBoard";
            btnVerifyAndBoard.Size = new Size(207, 57);
            btnVerifyAndBoard.TabIndex = 1;
            btnVerifyAndBoard.Text = "Verify & Board";
            btnVerifyAndBoard.UseVisualStyleBackColor = false;
            // 
            // btnPrintTicketPass
            // 
            btnPrintTicketPass.BackColor = Color.FromArgb(241, 245, 249);
            btnPrintTicketPass.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnPrintTicketPass.FlatStyle = FlatStyle.Flat;
            btnPrintTicketPass.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrintTicketPass.ForeColor = Color.FromArgb(30, 41, 59);
            btnPrintTicketPass.Location = new Point(407, 17);
            btnPrintTicketPass.Margin = new Padding(4, 5, 4, 5);
            btnPrintTicketPass.Name = "btnPrintTicketPass";
            btnPrintTicketPass.Size = new Size(229, 57);
            btnPrintTicketPass.TabIndex = 2;
            btnPrintTicketPass.Text = "Print Boarding Pass";
            btnPrintTicketPass.UseVisualStyleBackColor = false;
            // 
            // btnCancelTicketAction
            // 
            btnCancelTicketAction.BackColor = Color.FromArgb(241, 245, 249);
            btnCancelTicketAction.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelTicketAction.FlatStyle = FlatStyle.Flat;
            btnCancelTicketAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelTicketAction.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancelTicketAction.Location = new Point(650, 17);
            btnCancelTicketAction.Margin = new Padding(4, 5, 4, 5);
            btnCancelTicketAction.Name = "btnCancelTicketAction";
            btnCancelTicketAction.Size = new Size(186, 57);
            btnCancelTicketAction.TabIndex = 3;
            btnCancelTicketAction.Text = "Cancel Ticket";
            btnCancelTicketAction.UseVisualStyleBackColor = false;
            // 
            // lblTicketCount
            // 
            lblTicketCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTicketCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTicketCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblTicketCount.Location = new Point(1055, 27);
            lblTicketCount.Margin = new Padding(4, 0, 4, 0);
            lblTicketCount.Name = "lblTicketCount";
            lblTicketCount.Size = new Size(314, 33);
            lblTicketCount.TabIndex = 4;
            lblTicketCount.Text = "Showing 9 tickets";
            lblTicketCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelTicketsToolbar
            // 
            panelTicketsToolbar.Controls.Add(txtSearchTicketFilter);
            panelTicketsToolbar.Controls.Add(cmbTicketStatusFilter);
            panelTicketsToolbar.Controls.Add(cmbTicketRouteFilter);
            panelTicketsToolbar.Controls.Add(chkEnableTicketDateFilter);
            panelTicketsToolbar.Controls.Add(dtpTicketFilterDate);
            panelTicketsToolbar.Controls.Add(btnResetTicketFilters);
            panelTicketsToolbar.Dock = DockStyle.Top;
            panelTicketsToolbar.Location = new Point(0, 190);
            panelTicketsToolbar.Margin = new Padding(4, 5, 4, 5);
            panelTicketsToolbar.Name = "panelTicketsToolbar";
            panelTicketsToolbar.Size = new Size(1384, 87);
            panelTicketsToolbar.TabIndex = 2;
            // 
            // txtSearchTicketFilter
            // 
            txtSearchTicketFilter.Font = new Font("Segoe UI", 10F);
            txtSearchTicketFilter.Location = new Point(0, 22);
            txtSearchTicketFilter.Margin = new Padding(4, 5, 4, 5);
            txtSearchTicketFilter.Name = "txtSearchTicketFilter";
            txtSearchTicketFilter.PlaceholderText = "Search by Ticket ID, Booking Ref, Passenger, Phone, Coach...";
            txtSearchTicketFilter.Size = new Size(455, 34);
            txtSearchTicketFilter.TabIndex = 0;
            // 
            // cmbTicketStatusFilter
            // 
            cmbTicketStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTicketStatusFilter.Font = new Font("Segoe UI", 9.5F);
            cmbTicketStatusFilter.FormattingEnabled = true;
            cmbTicketStatusFilter.Items.AddRange(new object[] { "All Statuses", "Valid", "Boarded", "Cancelled" });
            cmbTicketStatusFilter.Location = new Point(471, 22);
            cmbTicketStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbTicketStatusFilter.Name = "cmbTicketStatusFilter";
            cmbTicketStatusFilter.Size = new Size(177, 33);
            cmbTicketStatusFilter.TabIndex = 1;
            // 
            // cmbTicketRouteFilter
            // 
            cmbTicketRouteFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTicketRouteFilter.Font = new Font("Segoe UI", 9.5F);
            cmbTicketRouteFilter.FormattingEnabled = true;
            cmbTicketRouteFilter.Items.AddRange(new object[] { "All Routes / Trips" });
            cmbTicketRouteFilter.Location = new Point(664, 22);
            cmbTicketRouteFilter.Margin = new Padding(4, 5, 4, 5);
            cmbTicketRouteFilter.Name = "cmbTicketRouteFilter";
            cmbTicketRouteFilter.Size = new Size(248, 33);
            cmbTicketRouteFilter.TabIndex = 2;
            // 
            // chkEnableTicketDateFilter
            // 
            chkEnableTicketDateFilter.AutoSize = true;
            chkEnableTicketDateFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkEnableTicketDateFilter.ForeColor = Color.FromArgb(51, 65, 85);
            chkEnableTicketDateFilter.Location = new Point(929, 27);
            chkEnableTicketDateFilter.Margin = new Padding(4, 5, 4, 5);
            chkEnableTicketDateFilter.Name = "chkEnableTicketDateFilter";
            chkEnableTicketDateFilter.Size = new Size(135, 29);
            chkEnableTicketDateFilter.TabIndex = 3;
            chkEnableTicketDateFilter.Text = "Travel Date";
            chkEnableTicketDateFilter.UseVisualStyleBackColor = true;
            // 
            // dtpTicketFilterDate
            // 
            dtpTicketFilterDate.CustomFormat = "yyyy-MM-dd";
            dtpTicketFilterDate.Enabled = false;
            dtpTicketFilterDate.Font = new Font("Segoe UI", 9.5F);
            dtpTicketFilterDate.Format = DateTimePickerFormat.Custom;
            dtpTicketFilterDate.Location = new Point(1064, 22);
            dtpTicketFilterDate.Margin = new Padding(4, 5, 4, 5);
            dtpTicketFilterDate.Name = "dtpTicketFilterDate";
            dtpTicketFilterDate.Size = new Size(163, 33);
            dtpTicketFilterDate.TabIndex = 4;
            // 
            // btnResetTicketFilters
            // 
            btnResetTicketFilters.BackColor = Color.FromArgb(241, 245, 249);
            btnResetTicketFilters.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetTicketFilters.FlatStyle = FlatStyle.Flat;
            btnResetTicketFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResetTicketFilters.ForeColor = Color.FromArgb(51, 65, 85);
            btnResetTicketFilters.Location = new Point(1243, 20);
            btnResetTicketFilters.Margin = new Padding(4, 5, 4, 5);
            btnResetTicketFilters.Name = "btnResetTicketFilters";
            btnResetTicketFilters.Size = new Size(136, 45);
            btnResetTicketFilters.TabIndex = 5;
            btnResetTicketFilters.Text = "Reset";
            btnResetTicketFilters.UseVisualStyleBackColor = false;
            // 
            // flowTicketMetrics
            // 
            flowTicketMetrics.Controls.Add(cardTotalTickets);
            flowTicketMetrics.Controls.Add(cardValidTickets);
            flowTicketMetrics.Controls.Add(cardBoardedTickets);
            flowTicketMetrics.Controls.Add(cardCancelledTickets);
            flowTicketMetrics.Controls.Add(cardTodayTickets);
            flowTicketMetrics.Dock = DockStyle.Top;
            flowTicketMetrics.Location = new Point(0, 70);
            flowTicketMetrics.Margin = new Padding(4, 5, 4, 5);
            flowTicketMetrics.Name = "flowTicketMetrics";
            flowTicketMetrics.Size = new Size(1384, 120);
            flowTicketMetrics.TabIndex = 1;
            flowTicketMetrics.WrapContents = false;
            // 
            // cardTotalTickets
            // 
            cardTotalTickets.BackColor = Color.White;
            cardTotalTickets.BorderStyle = BorderStyle.FixedSingle;
            cardTotalTickets.Controls.Add(lblMetricTotalTicketsSub);
            cardTotalTickets.Controls.Add(lblMetricTotalTicketsVal);
            cardTotalTickets.Controls.Add(lblMetricTotalTicketsTitle);
            cardTotalTickets.Location = new Point(0, 8);
            cardTotalTickets.Margin = new Padding(0, 8, 17, 8);
            cardTotalTickets.Name = "cardTotalTickets";
            cardTotalTickets.Padding = new Padding(17, 13, 17, 13);
            cardTotalTickets.Size = new Size(259, 99);
            cardTotalTickets.TabIndex = 0;
            // 
            // lblMetricTotalTicketsSub
            // 
            lblMetricTotalTicketsSub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMetricTotalTicketsSub.AutoSize = true;
            lblMetricTotalTicketsSub.Font = new Font("Segoe UI", 7.5F);
            lblMetricTotalTicketsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTotalTicketsSub.Location = new Point(34, 3);
            lblMetricTotalTicketsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalTicketsSub.Name = "lblMetricTotalTicketsSub";
            lblMetricTotalTicketsSub.Size = new Size(137, 20);
            lblMetricTotalTicketsSub.TabIndex = 2;
            lblMetricTotalTicketsSub.Text = "All recorded tickets";
            lblMetricTotalTicketsSub.Visible = false;
            // 
            // lblMetricTotalTicketsVal
            // 
            lblMetricTotalTicketsVal.AutoSize = true;
            lblMetricTotalTicketsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricTotalTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalTicketsVal.Location = new Point(31, 53);
            lblMetricTotalTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalTicketsVal.Name = "lblMetricTotalTicketsVal";
            lblMetricTotalTicketsVal.Size = new Size(38, 45);
            lblMetricTotalTicketsVal.TabIndex = 1;
            lblMetricTotalTicketsVal.Text = "0";
            // 
            // lblMetricTotalTicketsTitle
            // 
            lblMetricTotalTicketsTitle.AutoSize = true;
            lblMetricTotalTicketsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMetricTotalTicketsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricTotalTicketsTitle.Location = new Point(34, 27);
            lblMetricTotalTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalTicketsTitle.Name = "lblMetricTotalTicketsTitle";
            lblMetricTotalTicketsTitle.Size = new Size(181, 21);
            lblMetricTotalTicketsTitle.TabIndex = 0;
            lblMetricTotalTicketsTitle.Text = "TOTAL TICKETS ISSUED";
            // 
            // cardValidTickets
            // 
            cardValidTickets.BackColor = Color.White;
            cardValidTickets.BorderStyle = BorderStyle.FixedSingle;
            cardValidTickets.Controls.Add(lblMetricValidTicketsSub);
            cardValidTickets.Controls.Add(lblMetricValidTicketsVal);
            cardValidTickets.Controls.Add(lblMetricValidTicketsTitle);
            cardValidTickets.Location = new Point(276, 8);
            cardValidTickets.Margin = new Padding(0, 8, 17, 8);
            cardValidTickets.Name = "cardValidTickets";
            cardValidTickets.Padding = new Padding(17, 13, 17, 13);
            cardValidTickets.Size = new Size(259, 99);
            cardValidTickets.TabIndex = 1;
            // 
            // lblMetricValidTicketsSub
            // 
            lblMetricValidTicketsSub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMetricValidTicketsSub.AutoSize = true;
            lblMetricValidTicketsSub.Font = new Font("Segoe UI", 7.5F);
            lblMetricValidTicketsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricValidTicketsSub.Location = new Point(34, 3);
            lblMetricValidTicketsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricValidTicketsSub.Name = "lblMetricValidTicketsSub";
            lblMetricValidTicketsSub.Size = new Size(138, 20);
            lblMetricValidTicketsSub.TabIndex = 2;
            lblMetricValidTicketsSub.Text = "Ready for boarding";
            lblMetricValidTicketsSub.Visible = false;
            // 
            // lblMetricValidTicketsVal
            // 
            lblMetricValidTicketsVal.AutoSize = true;
            lblMetricValidTicketsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricValidTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricValidTicketsVal.Location = new Point(31, 53);
            lblMetricValidTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricValidTicketsVal.Name = "lblMetricValidTicketsVal";
            lblMetricValidTicketsVal.Size = new Size(38, 45);
            lblMetricValidTicketsVal.TabIndex = 1;
            lblMetricValidTicketsVal.Text = "0";
            // 
            // lblMetricValidTicketsTitle
            // 
            lblMetricValidTicketsTitle.AutoSize = true;
            lblMetricValidTicketsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMetricValidTicketsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricValidTicketsTitle.Location = new Point(34, 27);
            lblMetricValidTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricValidTicketsTitle.Name = "lblMetricValidTicketsTitle";
            lblMetricValidTicketsTitle.Size = new Size(126, 21);
            lblMetricValidTicketsTitle.TabIndex = 0;
            lblMetricValidTicketsTitle.Text = "VALID / ACTIVE";
            // 
            // cardBoardedTickets
            // 
            cardBoardedTickets.BackColor = Color.White;
            cardBoardedTickets.BorderStyle = BorderStyle.FixedSingle;
            cardBoardedTickets.Controls.Add(lblMetricBoardedTicketsSub);
            cardBoardedTickets.Controls.Add(lblMetricBoardedTicketsVal);
            cardBoardedTickets.Controls.Add(lblMetricBoardedTicketsTitle);
            cardBoardedTickets.Location = new Point(552, 8);
            cardBoardedTickets.Margin = new Padding(0, 8, 17, 8);
            cardBoardedTickets.Name = "cardBoardedTickets";
            cardBoardedTickets.Padding = new Padding(17, 13, 17, 13);
            cardBoardedTickets.Size = new Size(259, 99);
            cardBoardedTickets.TabIndex = 2;
            // 
            // lblMetricBoardedTicketsSub
            // 
            lblMetricBoardedTicketsSub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMetricBoardedTicketsSub.AutoSize = true;
            lblMetricBoardedTicketsSub.Font = new Font("Segoe UI", 7.5F);
            lblMetricBoardedTicketsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricBoardedTicketsSub.Location = new Point(34, 3);
            lblMetricBoardedTicketsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricBoardedTicketsSub.Name = "lblMetricBoardedTicketsSub";
            lblMetricBoardedTicketsSub.Size = new Size(160, 20);
            lblMetricBoardedTicketsSub.TabIndex = 2;
            lblMetricBoardedTicketsSub.Text = "Checked-in passengers";
            lblMetricBoardedTicketsSub.Visible = false;
            // 
            // lblMetricBoardedTicketsVal
            // 
            lblMetricBoardedTicketsVal.AutoSize = true;
            lblMetricBoardedTicketsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricBoardedTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricBoardedTicketsVal.Location = new Point(31, 53);
            lblMetricBoardedTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricBoardedTicketsVal.Name = "lblMetricBoardedTicketsVal";
            lblMetricBoardedTicketsVal.Size = new Size(38, 45);
            lblMetricBoardedTicketsVal.TabIndex = 1;
            lblMetricBoardedTicketsVal.Text = "0";
            // 
            // lblMetricBoardedTicketsTitle
            // 
            lblMetricBoardedTicketsTitle.AutoSize = true;
            lblMetricBoardedTicketsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMetricBoardedTicketsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricBoardedTicketsTitle.Location = new Point(34, 27);
            lblMetricBoardedTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricBoardedTicketsTitle.Name = "lblMetricBoardedTicketsTitle";
            lblMetricBoardedTicketsTitle.Size = new Size(170, 21);
            lblMetricBoardedTicketsTitle.TabIndex = 0;
            lblMetricBoardedTicketsTitle.Text = "BOARDED / VERIFIED";
            // 
            // cardCancelledTickets
            // 
            cardCancelledTickets.BackColor = Color.White;
            cardCancelledTickets.BorderStyle = BorderStyle.FixedSingle;
            cardCancelledTickets.Controls.Add(lblMetricCancelledTicketsSub);
            cardCancelledTickets.Controls.Add(lblMetricCancelledTicketsVal);
            cardCancelledTickets.Controls.Add(lblMetricCancelledTicketsTitle);
            cardCancelledTickets.Location = new Point(828, 8);
            cardCancelledTickets.Margin = new Padding(0, 8, 17, 8);
            cardCancelledTickets.Name = "cardCancelledTickets";
            cardCancelledTickets.Padding = new Padding(17, 13, 17, 13);
            cardCancelledTickets.Size = new Size(259, 99);
            cardCancelledTickets.TabIndex = 3;
            // 
            // lblMetricCancelledTicketsSub
            // 
            lblMetricCancelledTicketsSub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMetricCancelledTicketsSub.AutoSize = true;
            lblMetricCancelledTicketsSub.Font = new Font("Segoe UI", 7.5F);
            lblMetricCancelledTicketsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricCancelledTicketsSub.Location = new Point(34, 3);
            lblMetricCancelledTicketsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledTicketsSub.Name = "lblMetricCancelledTicketsSub";
            lblMetricCancelledTicketsSub.Size = new Size(133, 20);
            lblMetricCancelledTicketsSub.TabIndex = 2;
            lblMetricCancelledTicketsSub.Text = "Refunded / voided";
            lblMetricCancelledTicketsSub.Visible = false;
            // 
            // lblMetricCancelledTicketsVal
            // 
            lblMetricCancelledTicketsVal.AutoSize = true;
            lblMetricCancelledTicketsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricCancelledTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricCancelledTicketsVal.Location = new Point(31, 53);
            lblMetricCancelledTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledTicketsVal.Name = "lblMetricCancelledTicketsVal";
            lblMetricCancelledTicketsVal.Size = new Size(38, 45);
            lblMetricCancelledTicketsVal.TabIndex = 1;
            lblMetricCancelledTicketsVal.Text = "0";
            // 
            // lblMetricCancelledTicketsTitle
            // 
            lblMetricCancelledTicketsTitle.AutoSize = true;
            lblMetricCancelledTicketsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMetricCancelledTicketsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricCancelledTicketsTitle.Location = new Point(34, 27);
            lblMetricCancelledTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledTicketsTitle.Name = "lblMetricCancelledTicketsTitle";
            lblMetricCancelledTicketsTitle.Size = new Size(100, 21);
            lblMetricCancelledTicketsTitle.TabIndex = 0;
            lblMetricCancelledTicketsTitle.Text = "CANCELLED";
            // 
            // cardTodayTickets
            // 
            cardTodayTickets.BackColor = Color.White;
            cardTodayTickets.BorderStyle = BorderStyle.FixedSingle;
            cardTodayTickets.Controls.Add(lblMetricTodayTicketsSub);
            cardTodayTickets.Controls.Add(lblMetricTodayTicketsVal);
            cardTodayTickets.Controls.Add(lblMetricTodayTicketsTitle);
            cardTodayTickets.Location = new Point(1104, 8);
            cardTodayTickets.Margin = new Padding(0, 8, 0, 8);
            cardTodayTickets.Name = "cardTodayTickets";
            cardTodayTickets.Padding = new Padding(17, 13, 17, 13);
            cardTodayTickets.Size = new Size(259, 99);
            cardTodayTickets.TabIndex = 4;
            // 
            // lblMetricTodayTicketsSub
            // 
            lblMetricTodayTicketsSub.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMetricTodayTicketsSub.AutoSize = true;
            lblMetricTodayTicketsSub.Font = new Font("Segoe UI", 7.5F);
            lblMetricTodayTicketsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTodayTicketsSub.Location = new Point(34, 3);
            lblMetricTodayTicketsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayTicketsSub.Name = "lblMetricTodayTicketsSub";
            lblMetricTodayTicketsSub.Size = new Size(124, 20);
            lblMetricTodayTicketsSub.TabIndex = 2;
            lblMetricTodayTicketsSub.Text = "Departures today";
            lblMetricTodayTicketsSub.Visible = false;
            // 
            // lblMetricTodayTicketsVal
            // 
            lblMetricTodayTicketsVal.AutoSize = true;
            lblMetricTodayTicketsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricTodayTicketsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTodayTicketsVal.Location = new Point(31, 53);
            lblMetricTodayTicketsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayTicketsVal.Name = "lblMetricTodayTicketsVal";
            lblMetricTodayTicketsVal.Size = new Size(38, 45);
            lblMetricTodayTicketsVal.TabIndex = 1;
            lblMetricTodayTicketsVal.Text = "0";
            // 
            // lblMetricTodayTicketsTitle
            // 
            lblMetricTodayTicketsTitle.AutoSize = true;
            lblMetricTodayTicketsTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMetricTodayTicketsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricTodayTicketsTitle.Location = new Point(34, 27);
            lblMetricTodayTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayTicketsTitle.Name = "lblMetricTodayTicketsTitle";
            lblMetricTodayTicketsTitle.Size = new Size(173, 21);
            lblMetricTodayTicketsTitle.TabIndex = 0;
            lblMetricTodayTicketsTitle.Text = "TODAY'S BOARDINGS";
            // 
            // panelTicketsHeader
            // 
            panelTicketsHeader.Controls.Add(btnVerifyBoardModal);
            panelTicketsHeader.Controls.Add(btnNewTicket);
            panelTicketsHeader.Controls.Add(lblTicketsTitle);
            panelTicketsHeader.Dock = DockStyle.Top;
            panelTicketsHeader.Location = new Point(0, 0);
            panelTicketsHeader.Margin = new Padding(4, 5, 4, 5);
            panelTicketsHeader.Name = "panelTicketsHeader";
            panelTicketsHeader.Size = new Size(1384, 70);
            panelTicketsHeader.TabIndex = 0;
            // 
            // btnVerifyBoardModal
            // 
            btnVerifyBoardModal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnVerifyBoardModal.BackColor = Color.FromArgb(15, 23, 42);
            btnVerifyBoardModal.FlatAppearance.BorderSize = 0;
            btnVerifyBoardModal.FlatStyle = FlatStyle.Flat;
            btnVerifyBoardModal.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnVerifyBoardModal.ForeColor = Color.White;
            btnVerifyBoardModal.Location = new Point(884, 7);
            btnVerifyBoardModal.Margin = new Padding(4, 5, 4, 5);
            btnVerifyBoardModal.Name = "btnVerifyBoardModal";
            btnVerifyBoardModal.Size = new Size(257, 60);
            btnVerifyBoardModal.TabIndex = 2;
            btnVerifyBoardModal.Text = "Verify & Board Scanner";
            btnVerifyBoardModal.UseVisualStyleBackColor = false;
            // 
            // btnNewTicket
            // 
            btnNewTicket.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewTicket.BackColor = Color.FromArgb(15, 23, 42);
            btnNewTicket.FlatAppearance.BorderSize = 0;
            btnNewTicket.FlatStyle = FlatStyle.Flat;
            btnNewTicket.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNewTicket.ForeColor = Color.White;
            btnNewTicket.Location = new Point(1155, 7);
            btnNewTicket.Margin = new Padding(4, 5, 4, 5);
            btnNewTicket.Name = "btnNewTicket";
            btnNewTicket.Size = new Size(229, 60);
            btnNewTicket.TabIndex = 3;
            btnNewTicket.Text = "Issue New Ticket";
            btnNewTicket.UseVisualStyleBackColor = false;
            // 
            // lblTicketsTitle
            // 
            lblTicketsTitle.AutoSize = true;
            lblTicketsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTicketsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblTicketsTitle.Location = new Point(0, 0);
            lblTicketsTitle.Margin = new Padding(4, 0, 4, 0);
            lblTicketsTitle.Name = "lblTicketsTitle";
            lblTicketsTitle.Size = new Size(317, 45);
            lblTicketsTitle.TabIndex = 0;
            lblTicketsTitle.Text = "Ticket Management";
            // 
            // panelBookingManagement
            // 
            panelBookingManagement.Controls.Add(lvBookings);
            panelBookingManagement.Controls.Add(panelBookingActions);
            panelBookingManagement.Controls.Add(panelBookingsToolbar);
            panelBookingManagement.Controls.Add(flowBookingMetrics);
            panelBookingManagement.Controls.Add(panelBookingsHeader);
            panelBookingManagement.Dock = DockStyle.Fill;
            panelBookingManagement.Location = new Point(29, 103);
            panelBookingManagement.Margin = new Padding(4, 5, 4, 5);
            panelBookingManagement.Name = "panelBookingManagement";
            panelBookingManagement.Size = new Size(1384, 897);
            panelBookingManagement.TabIndex = 6;
            panelBookingManagement.Visible = false;
            // 
            // lvBookings
            // 
            lvBookings.BorderStyle = BorderStyle.FixedSingle;
            lvBookings.Columns.AddRange(new ColumnHeader[] { colBookingId, colPassengerName, colPassengerPhone, colBookingRoute, colTravelDate, colDepartureTime, colSeats, colTotalAmount, colBookingStatus, colPaymentStatus });
            lvBookings.Dock = DockStyle.Fill;
            lvBookings.Font = new Font("Segoe UI", 9.5F);
            lvBookings.FullRowSelect = true;
            lvBookings.GridLines = true;
            lvBookings.Location = new Point(0, 295);
            lvBookings.Margin = new Padding(4, 5, 4, 5);
            lvBookings.MultiSelect = false;
            lvBookings.Name = "lvBookings";
            lvBookings.Size = new Size(1384, 515);
            lvBookings.TabIndex = 3;
            lvBookings.UseCompatibleStateImageBehavior = false;
            lvBookings.View = View.Details;
            // 
            // colBookingId
            // 
            colBookingId.Text = "Booking Ref";
            colBookingId.Width = 95;
            // 
            // colPassengerName
            // 
            colPassengerName.Text = "Passenger Name";
            colPassengerName.Width = 140;
            // 
            // colPassengerPhone
            // 
            colPassengerPhone.Text = "Phone Number";
            colPassengerPhone.Width = 120;
            // 
            // colBookingRoute
            // 
            colBookingRoute.Text = "Route";
            colBookingRoute.Width = 180;
            // 
            // colTravelDate
            // 
            colTravelDate.Text = "Travel Date";
            colTravelDate.Width = 90;
            // 
            // colDepartureTime
            // 
            colDepartureTime.Text = "Departure";
            colDepartureTime.Width = 80;
            // 
            // colSeats
            // 
            colSeats.Text = "Seat(s)";
            colSeats.Width = 110;
            // 
            // colTotalAmount
            // 
            colTotalAmount.Text = "Total Fare";
            colTotalAmount.Width = 95;
            // 
            // colBookingStatus
            // 
            colBookingStatus.Text = "Status";
            colBookingStatus.Width = 85;
            // 
            // colPaymentStatus
            // 
            colPaymentStatus.Text = "Payment";
            colPaymentStatus.Width = 85;
            // 
            // panelBookingActions
            // 
            panelBookingActions.Controls.Add(btnViewBookingDetails);
            panelBookingActions.Controls.Add(btnModifyBooking);
            panelBookingActions.Controls.Add(btnCancelBookingAction);
            panelBookingActions.Controls.Add(btnPrintTicket);
            panelBookingActions.Controls.Add(lblBookingCount);
            panelBookingActions.Dock = DockStyle.Bottom;
            panelBookingActions.Location = new Point(0, 810);
            panelBookingActions.Margin = new Padding(4, 5, 4, 5);
            panelBookingActions.Name = "panelBookingActions";
            panelBookingActions.Size = new Size(1384, 87);
            panelBookingActions.TabIndex = 4;
            // 
            // btnViewBookingDetails
            // 
            btnViewBookingDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewBookingDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewBookingDetails.FlatStyle = FlatStyle.Flat;
            btnViewBookingDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewBookingDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewBookingDetails.Location = new Point(0, 17);
            btnViewBookingDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewBookingDetails.Name = "btnViewBookingDetails";
            btnViewBookingDetails.Size = new Size(179, 57);
            btnViewBookingDetails.TabIndex = 0;
            btnViewBookingDetails.Text = "View Details";
            btnViewBookingDetails.UseVisualStyleBackColor = false;
            // 
            // btnModifyBooking
            // 
            btnModifyBooking.BackColor = Color.FromArgb(241, 245, 249);
            btnModifyBooking.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnModifyBooking.FlatStyle = FlatStyle.Flat;
            btnModifyBooking.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModifyBooking.ForeColor = Color.FromArgb(30, 41, 59);
            btnModifyBooking.Location = new Point(193, 17);
            btnModifyBooking.Margin = new Padding(4, 5, 4, 5);
            btnModifyBooking.Name = "btnModifyBooking";
            btnModifyBooking.Size = new Size(179, 57);
            btnModifyBooking.TabIndex = 1;
            btnModifyBooking.Text = "Modify Booking";
            btnModifyBooking.UseVisualStyleBackColor = false;
            // 
            // btnCancelBookingAction
            // 
            btnCancelBookingAction.BackColor = Color.FromArgb(241, 245, 249);
            btnCancelBookingAction.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancelBookingAction.FlatStyle = FlatStyle.Flat;
            btnCancelBookingAction.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelBookingAction.ForeColor = Color.FromArgb(51, 65, 85);
            btnCancelBookingAction.Location = new Point(386, 17);
            btnCancelBookingAction.Margin = new Padding(4, 5, 4, 5);
            btnCancelBookingAction.Name = "btnCancelBookingAction";
            btnCancelBookingAction.Size = new Size(193, 57);
            btnCancelBookingAction.TabIndex = 2;
            btnCancelBookingAction.Text = "Cancel Booking";
            btnCancelBookingAction.UseVisualStyleBackColor = false;
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.BackColor = Color.FromArgb(241, 245, 249);
            btnPrintTicket.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnPrintTicket.FlatStyle = FlatStyle.Flat;
            btnPrintTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrintTicket.ForeColor = Color.FromArgb(30, 41, 59);
            btnPrintTicket.Location = new Point(593, 17);
            btnPrintTicket.Margin = new Padding(4, 5, 4, 5);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(221, 57);
            btnPrintTicket.TabIndex = 3;
            btnPrintTicket.Text = "Print / View Ticket";
            btnPrintTicket.UseVisualStyleBackColor = false;
            // 
            // lblBookingCount
            // 
            lblBookingCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBookingCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblBookingCount.Location = new Point(1055, 27);
            lblBookingCount.Margin = new Padding(4, 0, 4, 0);
            lblBookingCount.Name = "lblBookingCount";
            lblBookingCount.Size = new Size(314, 33);
            lblBookingCount.TabIndex = 4;
            lblBookingCount.Text = "Showing 8 bookings";
            lblBookingCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelBookingsToolbar
            // 
            panelBookingsToolbar.Controls.Add(txtSearchBooking);
            panelBookingsToolbar.Controls.Add(cmbBookingStatusFilter);
            panelBookingsToolbar.Controls.Add(cmbBookingRouteFilter);
            panelBookingsToolbar.Controls.Add(chkEnableDateFilter);
            panelBookingsToolbar.Controls.Add(dtpBookingFilterDate);
            panelBookingsToolbar.Controls.Add(btnResetBookingFilters);
            panelBookingsToolbar.Dock = DockStyle.Top;
            panelBookingsToolbar.Location = new Point(0, 212);
            panelBookingsToolbar.Margin = new Padding(4, 5, 4, 5);
            panelBookingsToolbar.Name = "panelBookingsToolbar";
            panelBookingsToolbar.Size = new Size(1384, 83);
            panelBookingsToolbar.TabIndex = 2;
            // 
            // txtSearchBooking
            // 
            txtSearchBooking.Font = new Font("Segoe UI", 10F);
            txtSearchBooking.Location = new Point(0, 20);
            txtSearchBooking.Margin = new Padding(4, 5, 4, 5);
            txtSearchBooking.Name = "txtSearchBooking";
            txtSearchBooking.PlaceholderText = "Search booking ref, passenger, phone, or route...";
            txtSearchBooking.Size = new Size(398, 34);
            txtSearchBooking.TabIndex = 0;
            // 
            // cmbBookingStatusFilter
            // 
            cmbBookingStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingStatusFilter.Font = new Font("Segoe UI", 9.5F);
            cmbBookingStatusFilter.FormattingEnabled = true;
            cmbBookingStatusFilter.Items.AddRange(new object[] { "All Statuses", "Confirmed", "Pending", "Cancelled" });
            cmbBookingStatusFilter.Location = new Point(414, 20);
            cmbBookingStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbBookingStatusFilter.Name = "cmbBookingStatusFilter";
            cmbBookingStatusFilter.Size = new Size(184, 33);
            cmbBookingStatusFilter.TabIndex = 1;
            // 
            // cmbBookingRouteFilter
            // 
            cmbBookingRouteFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookingRouteFilter.Font = new Font("Segoe UI", 9.5F);
            cmbBookingRouteFilter.FormattingEnabled = true;
            cmbBookingRouteFilter.Location = new Point(614, 20);
            cmbBookingRouteFilter.Margin = new Padding(4, 5, 4, 5);
            cmbBookingRouteFilter.Name = "cmbBookingRouteFilter";
            cmbBookingRouteFilter.Size = new Size(263, 33);
            cmbBookingRouteFilter.TabIndex = 2;
            // 
            // chkEnableDateFilter
            // 
            chkEnableDateFilter.AutoSize = true;
            chkEnableDateFilter.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            chkEnableDateFilter.ForeColor = Color.FromArgb(51, 65, 85);
            chkEnableDateFilter.Location = new Point(893, 25);
            chkEnableDateFilter.Margin = new Padding(4, 5, 4, 5);
            chkEnableDateFilter.Name = "chkEnableDateFilter";
            chkEnableDateFilter.Size = new Size(140, 29);
            chkEnableDateFilter.TabIndex = 3;
            chkEnableDateFilter.Text = "Travel Date:";
            chkEnableDateFilter.UseVisualStyleBackColor = true;
            // 
            // dtpBookingFilterDate
            // 
            dtpBookingFilterDate.Enabled = false;
            dtpBookingFilterDate.Font = new Font("Segoe UI", 9.5F);
            dtpBookingFilterDate.Format = DateTimePickerFormat.Short;
            dtpBookingFilterDate.Location = new Point(1036, 20);
            dtpBookingFilterDate.Margin = new Padding(4, 5, 4, 5);
            dtpBookingFilterDate.Name = "dtpBookingFilterDate";
            dtpBookingFilterDate.Size = new Size(177, 33);
            dtpBookingFilterDate.TabIndex = 4;
            // 
            // btnResetBookingFilters
            // 
            btnResetBookingFilters.BackColor = Color.FromArgb(241, 245, 249);
            btnResetBookingFilters.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetBookingFilters.FlatStyle = FlatStyle.Flat;
            btnResetBookingFilters.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResetBookingFilters.ForeColor = Color.FromArgb(51, 65, 85);
            btnResetBookingFilters.Location = new Point(1229, 15);
            btnResetBookingFilters.Margin = new Padding(4, 5, 4, 5);
            btnResetBookingFilters.Name = "btnResetBookingFilters";
            btnResetBookingFilters.Size = new Size(136, 53);
            btnResetBookingFilters.TabIndex = 5;
            btnResetBookingFilters.Text = "Reset";
            btnResetBookingFilters.UseVisualStyleBackColor = false;
            // 
            // flowBookingMetrics
            // 
            flowBookingMetrics.Controls.Add(cardTotalBookings);
            flowBookingMetrics.Controls.Add(cardConfirmedBookings);
            flowBookingMetrics.Controls.Add(cardPendingBookings);
            flowBookingMetrics.Controls.Add(cardCancelledBookings);
            flowBookingMetrics.Controls.Add(cardTodayBookings);
            flowBookingMetrics.Dock = DockStyle.Top;
            flowBookingMetrics.Location = new Point(0, 70);
            flowBookingMetrics.Margin = new Padding(4, 5, 4, 5);
            flowBookingMetrics.Name = "flowBookingMetrics";
            flowBookingMetrics.Size = new Size(1384, 142);
            flowBookingMetrics.TabIndex = 1;
            // 
            // cardTotalBookings
            // 
            cardTotalBookings.BackColor = Color.White;
            cardTotalBookings.BorderStyle = BorderStyle.FixedSingle;
            cardTotalBookings.Controls.Add(lblMetricTotalBookingsVal);
            cardTotalBookings.Controls.Add(lblMetricTotalBookingsTitle);
            cardTotalBookings.Controls.Add(lblMetricTotalBookingsSub);
            cardTotalBookings.Location = new Point(0, 8);
            cardTotalBookings.Margin = new Padding(0, 8, 14, 8);
            cardTotalBookings.Name = "cardTotalBookings";
            cardTotalBookings.Size = new Size(259, 99);
            cardTotalBookings.TabIndex = 0;
            // 
            // lblMetricTotalBookingsVal
            // 
            lblMetricTotalBookingsVal.AutoSize = true;
            lblMetricTotalBookingsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricTotalBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalBookingsVal.Location = new Point(17, 13);
            lblMetricTotalBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBookingsVal.Name = "lblMetricTotalBookingsVal";
            lblMetricTotalBookingsVal.Size = new Size(38, 45);
            lblMetricTotalBookingsVal.TabIndex = 0;
            lblMetricTotalBookingsVal.Text = "8";
            // 
            // lblMetricTotalBookingsTitle
            // 
            lblMetricTotalBookingsTitle.AutoSize = true;
            lblMetricTotalBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTotalBookingsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricTotalBookingsTitle.Location = new Point(20, 63);
            lblMetricTotalBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBookingsTitle.Name = "lblMetricTotalBookingsTitle";
            lblMetricTotalBookingsTitle.Size = new Size(128, 23);
            lblMetricTotalBookingsTitle.TabIndex = 1;
            lblMetricTotalBookingsTitle.Text = "Total Bookings";
            // 
            // lblMetricTotalBookingsSub
            // 
            lblMetricTotalBookingsSub.AutoSize = true;
            lblMetricTotalBookingsSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricTotalBookingsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTotalBookingsSub.Location = new Point(20, 88);
            lblMetricTotalBookingsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBookingsSub.Name = "lblMetricTotalBookingsSub";
            lblMetricTotalBookingsSub.Size = new Size(162, 21);
            lblMetricTotalBookingsSub.TabIndex = 2;
            lblMetricTotalBookingsSub.Text = "All recorded bookings";
            lblMetricTotalBookingsSub.Visible = false;
            // 
            // cardConfirmedBookings
            // 
            cardConfirmedBookings.BackColor = Color.White;
            cardConfirmedBookings.BorderStyle = BorderStyle.FixedSingle;
            cardConfirmedBookings.Controls.Add(lblMetricConfirmedBookingsVal);
            cardConfirmedBookings.Controls.Add(lblMetricConfirmedBookingsTitle);
            cardConfirmedBookings.Controls.Add(lblMetricConfirmedBookingsSub);
            cardConfirmedBookings.Location = new Point(273, 8);
            cardConfirmedBookings.Margin = new Padding(0, 8, 14, 8);
            cardConfirmedBookings.Name = "cardConfirmedBookings";
            cardConfirmedBookings.Size = new Size(259, 99);
            cardConfirmedBookings.TabIndex = 1;
            // 
            // lblMetricConfirmedBookingsVal
            // 
            lblMetricConfirmedBookingsVal.AutoSize = true;
            lblMetricConfirmedBookingsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricConfirmedBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricConfirmedBookingsVal.Location = new Point(17, 13);
            lblMetricConfirmedBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricConfirmedBookingsVal.Name = "lblMetricConfirmedBookingsVal";
            lblMetricConfirmedBookingsVal.Size = new Size(38, 45);
            lblMetricConfirmedBookingsVal.TabIndex = 0;
            lblMetricConfirmedBookingsVal.Text = "5";
            // 
            // lblMetricConfirmedBookingsTitle
            // 
            lblMetricConfirmedBookingsTitle.AutoSize = true;
            lblMetricConfirmedBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricConfirmedBookingsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricConfirmedBookingsTitle.Location = new Point(20, 63);
            lblMetricConfirmedBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricConfirmedBookingsTitle.Name = "lblMetricConfirmedBookingsTitle";
            lblMetricConfirmedBookingsTitle.Size = new Size(96, 23);
            lblMetricConfirmedBookingsTitle.TabIndex = 1;
            lblMetricConfirmedBookingsTitle.Text = "Confirmed";
            // 
            // lblMetricConfirmedBookingsSub
            // 
            lblMetricConfirmedBookingsSub.AutoSize = true;
            lblMetricConfirmedBookingsSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricConfirmedBookingsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricConfirmedBookingsSub.Location = new Point(20, 88);
            lblMetricConfirmedBookingsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricConfirmedBookingsSub.Name = "lblMetricConfirmedBookingsSub";
            lblMetricConfirmedBookingsSub.Size = new Size(173, 21);
            lblMetricConfirmedBookingsSub.TabIndex = 2;
            lblMetricConfirmedBookingsSub.Text = "Confirmed reservations";
            lblMetricConfirmedBookingsSub.Visible = false;
            // 
            // cardPendingBookings
            // 
            cardPendingBookings.BackColor = Color.White;
            cardPendingBookings.BorderStyle = BorderStyle.FixedSingle;
            cardPendingBookings.Controls.Add(lblMetricPendingBookingsVal);
            cardPendingBookings.Controls.Add(lblMetricPendingBookingsTitle);
            cardPendingBookings.Controls.Add(lblMetricPendingBookingsSub);
            cardPendingBookings.Location = new Point(546, 8);
            cardPendingBookings.Margin = new Padding(0, 8, 14, 8);
            cardPendingBookings.Name = "cardPendingBookings";
            cardPendingBookings.Size = new Size(259, 99);
            cardPendingBookings.TabIndex = 2;
            // 
            // lblMetricPendingBookingsVal
            // 
            lblMetricPendingBookingsVal.AutoSize = true;
            lblMetricPendingBookingsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricPendingBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricPendingBookingsVal.Location = new Point(17, 13);
            lblMetricPendingBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricPendingBookingsVal.Name = "lblMetricPendingBookingsVal";
            lblMetricPendingBookingsVal.Size = new Size(38, 45);
            lblMetricPendingBookingsVal.TabIndex = 0;
            lblMetricPendingBookingsVal.Text = "2";
            // 
            // lblMetricPendingBookingsTitle
            // 
            lblMetricPendingBookingsTitle.AutoSize = true;
            lblMetricPendingBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricPendingBookingsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricPendingBookingsTitle.Location = new Point(20, 63);
            lblMetricPendingBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricPendingBookingsTitle.Name = "lblMetricPendingBookingsTitle";
            lblMetricPendingBookingsTitle.Size = new Size(75, 23);
            lblMetricPendingBookingsTitle.TabIndex = 1;
            lblMetricPendingBookingsTitle.Text = "Pending";
            // 
            // lblMetricPendingBookingsSub
            // 
            lblMetricPendingBookingsSub.AutoSize = true;
            lblMetricPendingBookingsSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricPendingBookingsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricPendingBookingsSub.Location = new Point(20, 88);
            lblMetricPendingBookingsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricPendingBookingsSub.Name = "lblMetricPendingBookingsSub";
            lblMetricPendingBookingsSub.Size = new Size(164, 21);
            lblMetricPendingBookingsSub.TabIndex = 2;
            lblMetricPendingBookingsSub.Text = "Awaiting confirmation";
            lblMetricPendingBookingsSub.Visible = false;
            // 
            // cardCancelledBookings
            // 
            cardCancelledBookings.BackColor = Color.White;
            cardCancelledBookings.BorderStyle = BorderStyle.FixedSingle;
            cardCancelledBookings.Controls.Add(lblMetricCancelledBookingsVal);
            cardCancelledBookings.Controls.Add(lblMetricCancelledBookingsTitle);
            cardCancelledBookings.Controls.Add(lblMetricCancelledBookingsSub);
            cardCancelledBookings.Location = new Point(819, 8);
            cardCancelledBookings.Margin = new Padding(0, 8, 14, 8);
            cardCancelledBookings.Name = "cardCancelledBookings";
            cardCancelledBookings.Size = new Size(259, 99);
            cardCancelledBookings.TabIndex = 3;
            // 
            // lblMetricCancelledBookingsVal
            // 
            lblMetricCancelledBookingsVal.AutoSize = true;
            lblMetricCancelledBookingsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricCancelledBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricCancelledBookingsVal.Location = new Point(17, 13);
            lblMetricCancelledBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledBookingsVal.Name = "lblMetricCancelledBookingsVal";
            lblMetricCancelledBookingsVal.Size = new Size(38, 45);
            lblMetricCancelledBookingsVal.TabIndex = 0;
            lblMetricCancelledBookingsVal.Text = "1";
            // 
            // lblMetricCancelledBookingsTitle
            // 
            lblMetricCancelledBookingsTitle.AutoSize = true;
            lblMetricCancelledBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricCancelledBookingsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricCancelledBookingsTitle.Location = new Point(20, 63);
            lblMetricCancelledBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledBookingsTitle.Name = "lblMetricCancelledBookingsTitle";
            lblMetricCancelledBookingsTitle.Size = new Size(87, 23);
            lblMetricCancelledBookingsTitle.TabIndex = 1;
            lblMetricCancelledBookingsTitle.Text = "Cancelled";
            // 
            // lblMetricCancelledBookingsSub
            // 
            lblMetricCancelledBookingsSub.AutoSize = true;
            lblMetricCancelledBookingsSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricCancelledBookingsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricCancelledBookingsSub.Location = new Point(20, 88);
            lblMetricCancelledBookingsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricCancelledBookingsSub.Name = "lblMetricCancelledBookingsSub";
            lblMetricCancelledBookingsSub.Size = new Size(161, 21);
            lblMetricCancelledBookingsSub.TabIndex = 2;
            lblMetricCancelledBookingsSub.Text = "Released reservations";
            lblMetricCancelledBookingsSub.Visible = false;
            // 
            // cardTodayBookings
            // 
            cardTodayBookings.BackColor = Color.White;
            cardTodayBookings.BorderStyle = BorderStyle.FixedSingle;
            cardTodayBookings.Controls.Add(lblMetricTodayBookingsVal);
            cardTodayBookings.Controls.Add(lblMetricTodayBookingsTitle);
            cardTodayBookings.Controls.Add(lblMetricTodayBookingsSub);
            cardTodayBookings.Location = new Point(1092, 8);
            cardTodayBookings.Margin = new Padding(0, 8, 0, 8);
            cardTodayBookings.Name = "cardTodayBookings";
            cardTodayBookings.Size = new Size(259, 99);
            cardTodayBookings.TabIndex = 4;
            // 
            // lblMetricTodayBookingsVal
            // 
            lblMetricTodayBookingsVal.AutoSize = true;
            lblMetricTodayBookingsVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricTodayBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTodayBookingsVal.Location = new Point(17, 13);
            lblMetricTodayBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayBookingsVal.Name = "lblMetricTodayBookingsVal";
            lblMetricTodayBookingsVal.Size = new Size(38, 45);
            lblMetricTodayBookingsVal.TabIndex = 0;
            lblMetricTodayBookingsVal.Text = "4";
            // 
            // lblMetricTodayBookingsTitle
            // 
            lblMetricTodayBookingsTitle.AutoSize = true;
            lblMetricTodayBookingsTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTodayBookingsTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricTodayBookingsTitle.Location = new Point(20, 63);
            lblMetricTodayBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayBookingsTitle.Name = "lblMetricTodayBookingsTitle";
            lblMetricTodayBookingsTitle.Size = new Size(147, 23);
            lblMetricTodayBookingsTitle.TabIndex = 1;
            lblMetricTodayBookingsTitle.Text = "Today's Bookings";
            // 
            // lblMetricTodayBookingsSub
            // 
            lblMetricTodayBookingsSub.AutoSize = true;
            lblMetricTodayBookingsSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricTodayBookingsSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTodayBookingsSub.Location = new Point(20, 88);
            lblMetricTodayBookingsSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricTodayBookingsSub.Name = "lblMetricTodayBookingsSub";
            lblMetricTodayBookingsSub.Size = new Size(169, 21);
            lblMetricTodayBookingsSub.TabIndex = 2;
            lblMetricTodayBookingsSub.Text = "Created or travel today";
            lblMetricTodayBookingsSub.Visible = false;
            // 
            // panelBookingsHeader
            // 
            panelBookingsHeader.Controls.Add(btnNewBooking);
            panelBookingsHeader.Controls.Add(lblBookingsTitle);
            panelBookingsHeader.Controls.Add(lblBookingsSubtitle);
            panelBookingsHeader.Dock = DockStyle.Top;
            panelBookingsHeader.Location = new Point(0, 0);
            panelBookingsHeader.Margin = new Padding(4, 5, 4, 5);
            panelBookingsHeader.Name = "panelBookingsHeader";
            panelBookingsHeader.Size = new Size(1384, 70);
            panelBookingsHeader.TabIndex = 0;
            // 
            // btnNewBooking
            // 
            btnNewBooking.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewBooking.BackColor = Color.FromArgb(15, 23, 42);
            btnNewBooking.FlatAppearance.BorderSize = 0;
            btnNewBooking.FlatStyle = FlatStyle.Flat;
            btnNewBooking.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnNewBooking.ForeColor = Color.White;
            btnNewBooking.Location = new Point(1162, 7);
            btnNewBooking.Margin = new Padding(4, 5, 4, 5);
            btnNewBooking.Name = "btnNewBooking";
            btnNewBooking.Size = new Size(221, 60);
            btnNewBooking.TabIndex = 2;
            btnNewBooking.Text = "New Booking";
            btnNewBooking.UseVisualStyleBackColor = false;
            // 
            // lblBookingsTitle
            // 
            lblBookingsTitle.AutoSize = true;
            lblBookingsTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBookingsTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblBookingsTitle.Location = new Point(0, 0);
            lblBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblBookingsTitle.Name = "lblBookingsTitle";
            lblBookingsTitle.Size = new Size(354, 45);
            lblBookingsTitle.TabIndex = 0;
            lblBookingsTitle.Text = "Booking Management";
            // 
            // lblBookingsSubtitle
            // 
            lblBookingsSubtitle.AutoSize = true;
            lblBookingsSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblBookingsSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblBookingsSubtitle.Location = new Point(0, 50);
            lblBookingsSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblBookingsSubtitle.Name = "lblBookingsSubtitle";
            lblBookingsSubtitle.Size = new Size(852, 25);
            lblBookingsSubtitle.TabIndex = 1;
            lblBookingsSubtitle.Text = "View passenger reservations, manage seat allocations, confirm payments, and process cancellations.";
            lblBookingsSubtitle.Visible = false;
            // 
            // panelRouteManagement
            // 
            panelRouteManagement.Controls.Add(lvRoutes);
            panelRouteManagement.Controls.Add(panelRouteActions);
            panelRouteManagement.Controls.Add(panelRoutesToolbar);
            panelRouteManagement.Controls.Add(flowRouteMetrics);
            panelRouteManagement.Controls.Add(panelRoutesHeader);
            panelRouteManagement.Dock = DockStyle.Fill;
            panelRouteManagement.Location = new Point(29, 103);
            panelRouteManagement.Margin = new Padding(4, 5, 4, 5);
            panelRouteManagement.Name = "panelRouteManagement";
            panelRouteManagement.Size = new Size(1384, 897);
            panelRouteManagement.TabIndex = 5;
            panelRouteManagement.Visible = false;
            // 
            // lvRoutes
            // 
            lvRoutes.BorderStyle = BorderStyle.FixedSingle;
            lvRoutes.Columns.AddRange(new ColumnHeader[] { colRouteId, colRouteName, colSource, colDestination, colDistance, colEstimatedTime, colBaseFare, colRouteStatus, colIntermediateStops });
            lvRoutes.Dock = DockStyle.Fill;
            lvRoutes.Font = new Font("Segoe UI", 9.5F);
            lvRoutes.FullRowSelect = true;
            lvRoutes.GridLines = true;
            lvRoutes.Location = new Point(0, 273);
            lvRoutes.Margin = new Padding(4, 5, 4, 5);
            lvRoutes.MultiSelect = false;
            lvRoutes.Name = "lvRoutes";
            lvRoutes.Size = new Size(1384, 537);
            lvRoutes.TabIndex = 3;
            lvRoutes.UseCompatibleStateImageBehavior = false;
            lvRoutes.View = View.Details;
            // 
            // colRouteId
            // 
            colRouteId.Text = "Route ID";
            colRouteId.Width = 85;
            // 
            // colRouteName
            // 
            colRouteName.Text = "Route Name";
            colRouteName.Width = 190;
            // 
            // colSource
            // 
            colSource.Text = "Source";
            colSource.Width = 120;
            // 
            // colDestination
            // 
            colDestination.Text = "Destination";
            colDestination.Width = 120;
            // 
            // colDistance
            // 
            colDistance.Text = "Distance";
            colDistance.Width = 85;
            // 
            // colEstimatedTime
            // 
            colEstimatedTime.Text = "Est. Duration";
            colEstimatedTime.Width = 110;
            // 
            // colBaseFare
            // 
            colBaseFare.Text = "Base Fare";
            colBaseFare.Width = 95;
            // 
            // colRouteStatus
            // 
            colRouteStatus.Text = "Status";
            colRouteStatus.Width = 85;
            // 
            // colIntermediateStops
            // 
            colIntermediateStops.Text = "Intermediate Stops";
            colIntermediateStops.Width = 200;
            // 
            // panelRouteActions
            // 
            panelRouteActions.Controls.Add(btnViewRouteDetails);
            panelRouteActions.Controls.Add(btnEditRoute);
            panelRouteActions.Controls.Add(btnToggleRouteStatus);
            panelRouteActions.Controls.Add(btnDeleteRoute);
            panelRouteActions.Controls.Add(lblRouteCount);
            panelRouteActions.Dock = DockStyle.Bottom;
            panelRouteActions.Location = new Point(0, 810);
            panelRouteActions.Margin = new Padding(4, 5, 4, 5);
            panelRouteActions.Name = "panelRouteActions";
            panelRouteActions.Size = new Size(1384, 87);
            panelRouteActions.TabIndex = 4;
            // 
            // btnViewRouteDetails
            // 
            btnViewRouteDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewRouteDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewRouteDetails.FlatStyle = FlatStyle.Flat;
            btnViewRouteDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewRouteDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewRouteDetails.Location = new Point(0, 17);
            btnViewRouteDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewRouteDetails.Name = "btnViewRouteDetails";
            btnViewRouteDetails.Size = new Size(179, 57);
            btnViewRouteDetails.TabIndex = 0;
            btnViewRouteDetails.Text = "View Details";
            btnViewRouteDetails.UseVisualStyleBackColor = false;
            // 
            // btnEditRoute
            // 
            btnEditRoute.BackColor = Color.FromArgb(241, 245, 249);
            btnEditRoute.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnEditRoute.FlatStyle = FlatStyle.Flat;
            btnEditRoute.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditRoute.ForeColor = Color.FromArgb(30, 41, 59);
            btnEditRoute.Location = new Point(193, 17);
            btnEditRoute.Margin = new Padding(4, 5, 4, 5);
            btnEditRoute.Name = "btnEditRoute";
            btnEditRoute.Size = new Size(157, 57);
            btnEditRoute.TabIndex = 1;
            btnEditRoute.Text = "Edit Route";
            btnEditRoute.UseVisualStyleBackColor = false;
            // 
            // btnToggleRouteStatus
            // 
            btnToggleRouteStatus.BackColor = Color.FromArgb(241, 245, 249);
            btnToggleRouteStatus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnToggleRouteStatus.FlatStyle = FlatStyle.Flat;
            btnToggleRouteStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnToggleRouteStatus.ForeColor = Color.FromArgb(30, 41, 59);
            btnToggleRouteStatus.Location = new Point(364, 17);
            btnToggleRouteStatus.Margin = new Padding(4, 5, 4, 5);
            btnToggleRouteStatus.Name = "btnToggleRouteStatus";
            btnToggleRouteStatus.Size = new Size(236, 57);
            btnToggleRouteStatus.TabIndex = 2;
            btnToggleRouteStatus.Text = "Activate / Deactivate";
            btnToggleRouteStatus.UseVisualStyleBackColor = false;
            // 
            // btnDeleteRoute
            // 
            btnDeleteRoute.BackColor = Color.FromArgb(241, 245, 249);
            btnDeleteRoute.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDeleteRoute.FlatStyle = FlatStyle.Flat;
            btnDeleteRoute.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteRoute.ForeColor = Color.FromArgb(51, 65, 85);
            btnDeleteRoute.Location = new Point(614, 17);
            btnDeleteRoute.Margin = new Padding(4, 5, 4, 5);
            btnDeleteRoute.Name = "btnDeleteRoute";
            btnDeleteRoute.Size = new Size(171, 57);
            btnDeleteRoute.TabIndex = 3;
            btnDeleteRoute.Text = "Delete Route";
            btnDeleteRoute.UseVisualStyleBackColor = false;
            // 
            // lblRouteCount
            // 
            lblRouteCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblRouteCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRouteCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblRouteCount.Location = new Point(1055, 27);
            lblRouteCount.Margin = new Padding(4, 0, 4, 0);
            lblRouteCount.Name = "lblRouteCount";
            lblRouteCount.Size = new Size(314, 33);
            lblRouteCount.TabIndex = 4;
            lblRouteCount.Text = "Showing 8 routes";
            lblRouteCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelRoutesToolbar
            // 
            panelRoutesToolbar.Controls.Add(txtSearchRoute);
            panelRoutesToolbar.Controls.Add(cmbRouteStatusFilter);
            panelRoutesToolbar.Controls.Add(btnRefreshRoutes);
            panelRoutesToolbar.Dock = DockStyle.Top;
            panelRoutesToolbar.Location = new Point(0, 190);
            panelRoutesToolbar.Margin = new Padding(4, 5, 4, 5);
            panelRoutesToolbar.Name = "panelRoutesToolbar";
            panelRoutesToolbar.Size = new Size(1384, 83);
            panelRoutesToolbar.TabIndex = 2;
            // 
            // txtSearchRoute
            // 
            txtSearchRoute.Font = new Font("Segoe UI", 10F);
            txtSearchRoute.Location = new Point(0, 20);
            txtSearchRoute.Margin = new Padding(4, 5, 4, 5);
            txtSearchRoute.Name = "txtSearchRoute";
            txtSearchRoute.PlaceholderText = "Search route name, source, destination, or ID...";
            txtSearchRoute.Size = new Size(541, 34);
            txtSearchRoute.TabIndex = 0;
            // 
            // cmbRouteStatusFilter
            // 
            cmbRouteStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRouteStatusFilter.Font = new Font("Segoe UI", 9.5F);
            cmbRouteStatusFilter.FormattingEnabled = true;
            cmbRouteStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Inactive" });
            cmbRouteStatusFilter.Location = new Point(564, 20);
            cmbRouteStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbRouteStatusFilter.Name = "cmbRouteStatusFilter";
            cmbRouteStatusFilter.Size = new Size(205, 33);
            cmbRouteStatusFilter.TabIndex = 1;
            // 
            // btnRefreshRoutes
            // 
            btnRefreshRoutes.BackColor = Color.FromArgb(241, 245, 249);
            btnRefreshRoutes.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefreshRoutes.FlatStyle = FlatStyle.Flat;
            btnRefreshRoutes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshRoutes.ForeColor = Color.FromArgb(51, 65, 85);
            btnRefreshRoutes.Location = new Point(793, 15);
            btnRefreshRoutes.Margin = new Padding(4, 5, 4, 5);
            btnRefreshRoutes.Name = "btnRefreshRoutes";
            btnRefreshRoutes.Size = new Size(143, 53);
            btnRefreshRoutes.TabIndex = 2;
            btnRefreshRoutes.Text = "Refresh";
            btnRefreshRoutes.UseVisualStyleBackColor = false;
            // 
            // flowRouteMetrics
            // 
            flowRouteMetrics.Controls.Add(cardTotalRoutes);
            flowRouteMetrics.Controls.Add(cardActiveRoutes);
            flowRouteMetrics.Controls.Add(cardInactiveRoutes);
            flowRouteMetrics.Controls.Add(cardTotalDistance);
            flowRouteMetrics.Dock = DockStyle.Top;
            flowRouteMetrics.Location = new Point(0, 70);
            flowRouteMetrics.Margin = new Padding(4, 5, 4, 5);
            flowRouteMetrics.Name = "flowRouteMetrics";
            flowRouteMetrics.Size = new Size(1384, 120);
            flowRouteMetrics.TabIndex = 1;
            // 
            // cardTotalRoutes
            // 
            cardTotalRoutes.BackColor = Color.White;
            cardTotalRoutes.BorderStyle = BorderStyle.FixedSingle;
            cardTotalRoutes.Controls.Add(lblMetricTotalRoutesVal);
            cardTotalRoutes.Controls.Add(lblMetricTotalRoutesTitle);
            cardTotalRoutes.Controls.Add(lblMetricTotalRoutesSub);
            cardTotalRoutes.Location = new Point(0, 8);
            cardTotalRoutes.Margin = new Padding(0, 8, 17, 8);
            cardTotalRoutes.Name = "cardTotalRoutes";
            cardTotalRoutes.Size = new Size(321, 99);
            cardTotalRoutes.TabIndex = 0;
            // 
            // lblMetricTotalRoutesVal
            // 
            lblMetricTotalRoutesVal.AutoSize = true;
            lblMetricTotalRoutesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricTotalRoutesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalRoutesVal.Location = new Point(17, 13);
            lblMetricTotalRoutesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalRoutesVal.Name = "lblMetricTotalRoutesVal";
            lblMetricTotalRoutesVal.Size = new Size(38, 45);
            lblMetricTotalRoutesVal.TabIndex = 0;
            lblMetricTotalRoutesVal.Text = "8";
            // 
            // lblMetricTotalRoutesTitle
            // 
            lblMetricTotalRoutesTitle.AutoSize = true;
            lblMetricTotalRoutesTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTotalRoutesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricTotalRoutesTitle.Location = new Point(20, 63);
            lblMetricTotalRoutesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalRoutesTitle.Name = "lblMetricTotalRoutesTitle";
            lblMetricTotalRoutesTitle.Size = new Size(108, 23);
            lblMetricTotalRoutesTitle.TabIndex = 1;
            lblMetricTotalRoutesTitle.Text = "Total Routes";
            // 
            // lblMetricTotalRoutesSub
            // 
            lblMetricTotalRoutesSub.AutoSize = true;
            lblMetricTotalRoutesSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricTotalRoutesSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTotalRoutesSub.Location = new Point(20, 88);
            lblMetricTotalRoutesSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalRoutesSub.Name = "lblMetricTotalRoutesSub";
            lblMetricTotalRoutesSub.Size = new Size(150, 21);
            lblMetricTotalRoutesSub.TabIndex = 2;
            lblMetricTotalRoutesSub.Text = "All registered routes";
            lblMetricTotalRoutesSub.Visible = false;
            // 
            // cardActiveRoutes
            // 
            cardActiveRoutes.BackColor = Color.White;
            cardActiveRoutes.BorderStyle = BorderStyle.FixedSingle;
            cardActiveRoutes.Controls.Add(lblMetricActiveRoutesVal);
            cardActiveRoutes.Controls.Add(lblMetricActiveRoutesTitle);
            cardActiveRoutes.Controls.Add(lblMetricActiveRoutesSub);
            cardActiveRoutes.Location = new Point(338, 8);
            cardActiveRoutes.Margin = new Padding(0, 8, 17, 8);
            cardActiveRoutes.Name = "cardActiveRoutes";
            cardActiveRoutes.Size = new Size(321, 99);
            cardActiveRoutes.TabIndex = 1;
            // 
            // lblMetricActiveRoutesVal
            // 
            lblMetricActiveRoutesVal.AutoSize = true;
            lblMetricActiveRoutesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricActiveRoutesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricActiveRoutesVal.Location = new Point(17, 13);
            lblMetricActiveRoutesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricActiveRoutesVal.Name = "lblMetricActiveRoutesVal";
            lblMetricActiveRoutesVal.Size = new Size(38, 45);
            lblMetricActiveRoutesVal.TabIndex = 0;
            lblMetricActiveRoutesVal.Text = "7";
            // 
            // lblMetricActiveRoutesTitle
            // 
            lblMetricActiveRoutesTitle.AutoSize = true;
            lblMetricActiveRoutesTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricActiveRoutesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricActiveRoutesTitle.Location = new Point(20, 63);
            lblMetricActiveRoutesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricActiveRoutesTitle.Name = "lblMetricActiveRoutesTitle";
            lblMetricActiveRoutesTitle.Size = new Size(119, 23);
            lblMetricActiveRoutesTitle.TabIndex = 1;
            lblMetricActiveRoutesTitle.Text = "Active Routes";
            // 
            // lblMetricActiveRoutesSub
            // 
            lblMetricActiveRoutesSub.AutoSize = true;
            lblMetricActiveRoutesSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricActiveRoutesSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricActiveRoutesSub.Location = new Point(20, 88);
            lblMetricActiveRoutesSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricActiveRoutesSub.Name = "lblMetricActiveRoutesSub";
            lblMetricActiveRoutesSub.Size = new Size(176, 21);
            lblMetricActiveRoutesSub.TabIndex = 2;
            lblMetricActiveRoutesSub.Text = "Available for scheduling";
            lblMetricActiveRoutesSub.Visible = false;
            // 
            // cardInactiveRoutes
            // 
            cardInactiveRoutes.BackColor = Color.White;
            cardInactiveRoutes.BorderStyle = BorderStyle.FixedSingle;
            cardInactiveRoutes.Controls.Add(lblMetricInactiveRoutesVal);
            cardInactiveRoutes.Controls.Add(lblMetricInactiveRoutesTitle);
            cardInactiveRoutes.Controls.Add(lblMetricInactiveRoutesSub);
            cardInactiveRoutes.Location = new Point(676, 8);
            cardInactiveRoutes.Margin = new Padding(0, 8, 17, 8);
            cardInactiveRoutes.Name = "cardInactiveRoutes";
            cardInactiveRoutes.Size = new Size(321, 99);
            cardInactiveRoutes.TabIndex = 2;
            // 
            // lblMetricInactiveRoutesVal
            // 
            lblMetricInactiveRoutesVal.AutoSize = true;
            lblMetricInactiveRoutesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricInactiveRoutesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricInactiveRoutesVal.Location = new Point(17, 13);
            lblMetricInactiveRoutesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricInactiveRoutesVal.Name = "lblMetricInactiveRoutesVal";
            lblMetricInactiveRoutesVal.Size = new Size(38, 45);
            lblMetricInactiveRoutesVal.TabIndex = 0;
            lblMetricInactiveRoutesVal.Text = "1";
            // 
            // lblMetricInactiveRoutesTitle
            // 
            lblMetricInactiveRoutesTitle.AutoSize = true;
            lblMetricInactiveRoutesTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricInactiveRoutesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricInactiveRoutesTitle.Location = new Point(20, 63);
            lblMetricInactiveRoutesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricInactiveRoutesTitle.Name = "lblMetricInactiveRoutesTitle";
            lblMetricInactiveRoutesTitle.Size = new Size(131, 23);
            lblMetricInactiveRoutesTitle.TabIndex = 1;
            lblMetricInactiveRoutesTitle.Text = "Inactive Routes";
            // 
            // lblMetricInactiveRoutesSub
            // 
            lblMetricInactiveRoutesSub.AutoSize = true;
            lblMetricInactiveRoutesSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricInactiveRoutesSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricInactiveRoutesSub.Location = new Point(20, 88);
            lblMetricInactiveRoutesSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricInactiveRoutesSub.Name = "lblMetricInactiveRoutesSub";
            lblMetricInactiveRoutesSub.Size = new Size(160, 21);
            lblMetricInactiveRoutesSub.TabIndex = 2;
            lblMetricInactiveRoutesSub.Text = "Not available for trips";
            lblMetricInactiveRoutesSub.Visible = false;
            // 
            // cardTotalDistance
            // 
            cardTotalDistance.BackColor = Color.White;
            cardTotalDistance.BorderStyle = BorderStyle.FixedSingle;
            cardTotalDistance.Controls.Add(lblMetricTotalDistanceVal);
            cardTotalDistance.Controls.Add(lblMetricTotalDistanceTitle);
            cardTotalDistance.Controls.Add(lblMetricTotalDistanceSub);
            cardTotalDistance.Location = new Point(1014, 8);
            cardTotalDistance.Margin = new Padding(0, 8, 0, 8);
            cardTotalDistance.Name = "cardTotalDistance";
            cardTotalDistance.Size = new Size(321, 99);
            cardTotalDistance.TabIndex = 3;
            // 
            // lblMetricTotalDistanceVal
            // 
            lblMetricTotalDistanceVal.AutoSize = true;
            lblMetricTotalDistanceVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricTotalDistanceVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalDistanceVal.Location = new Point(17, 13);
            lblMetricTotalDistanceVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalDistanceVal.Name = "lblMetricTotalDistanceVal";
            lblMetricTotalDistanceVal.Size = new Size(157, 45);
            lblMetricTotalDistanceVal.TabIndex = 0;
            lblMetricTotalDistanceVal.Text = "3,485 km";
            // 
            // lblMetricTotalDistanceTitle
            // 
            lblMetricTotalDistanceTitle.AutoSize = true;
            lblMetricTotalDistanceTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTotalDistanceTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricTotalDistanceTitle.Location = new Point(20, 63);
            lblMetricTotalDistanceTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalDistanceTitle.Name = "lblMetricTotalDistanceTitle";
            lblMetricTotalDistanceTitle.Size = new Size(122, 23);
            lblMetricTotalDistanceTitle.TabIndex = 1;
            lblMetricTotalDistanceTitle.Text = "Total Distance";
            // 
            // lblMetricTotalDistanceSub
            // 
            lblMetricTotalDistanceSub.AutoSize = true;
            lblMetricTotalDistanceSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricTotalDistanceSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTotalDistanceSub.Location = new Point(20, 88);
            lblMetricTotalDistanceSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalDistanceSub.Name = "lblMetricTotalDistanceSub";
            lblMetricTotalDistanceSub.Size = new Size(184, 21);
            lblMetricTotalDistanceSub.TabIndex = 2;
            lblMetricTotalDistanceSub.Text = "Aggregate route network";
            lblMetricTotalDistanceSub.Visible = false;
            // 
            // panelRoutesHeader
            // 
            panelRoutesHeader.Controls.Add(btnAddRoute);
            panelRoutesHeader.Controls.Add(lblRoutesTitle);
            panelRoutesHeader.Controls.Add(lblRoutesSubtitle);
            panelRoutesHeader.Dock = DockStyle.Top;
            panelRoutesHeader.Location = new Point(0, 0);
            panelRoutesHeader.Margin = new Padding(4, 5, 4, 5);
            panelRoutesHeader.Name = "panelRoutesHeader";
            panelRoutesHeader.Size = new Size(1384, 70);
            panelRoutesHeader.TabIndex = 0;
            // 
            // btnAddRoute
            // 
            btnAddRoute.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddRoute.BackColor = Color.FromArgb(15, 23, 42);
            btnAddRoute.FlatAppearance.BorderSize = 0;
            btnAddRoute.FlatStyle = FlatStyle.Flat;
            btnAddRoute.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddRoute.ForeColor = Color.White;
            btnAddRoute.Location = new Point(1162, 7);
            btnAddRoute.Margin = new Padding(4, 5, 4, 5);
            btnAddRoute.Name = "btnAddRoute";
            btnAddRoute.Size = new Size(221, 60);
            btnAddRoute.TabIndex = 2;
            btnAddRoute.Text = "Add New Route";
            btnAddRoute.UseVisualStyleBackColor = false;
            // 
            // lblRoutesTitle
            // 
            lblRoutesTitle.AutoSize = true;
            lblRoutesTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblRoutesTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblRoutesTitle.Location = new Point(0, 0);
            lblRoutesTitle.Margin = new Padding(4, 0, 4, 0);
            lblRoutesTitle.Name = "lblRoutesTitle";
            lblRoutesTitle.Size = new Size(315, 45);
            lblRoutesTitle.TabIndex = 0;
            lblRoutesTitle.Text = "Route Management";
            // 
            // lblRoutesSubtitle
            // 
            lblRoutesSubtitle.AutoSize = true;
            lblRoutesSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblRoutesSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblRoutesSubtitle.Location = new Point(0, 50);
            lblRoutesSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblRoutesSubtitle.Name = "lblRoutesSubtitle";
            lblRoutesSubtitle.Size = new Size(733, 25);
            lblRoutesSubtitle.TabIndex = 1;
            lblRoutesSubtitle.Text = "Manage intercity routes, distances, estimated travel durations, and intermediate stops.";
            lblRoutesSubtitle.Visible = false;
            // 
            // panelBusManagement
            // 
            panelBusManagement.Controls.Add(lvBuses);
            panelBusManagement.Controls.Add(panelBusActions);
            panelBusManagement.Controls.Add(panelBusesToolbar);
            panelBusManagement.Controls.Add(flowBusMetrics);
            panelBusManagement.Controls.Add(panelBusesHeader);
            panelBusManagement.Dock = DockStyle.Fill;
            panelBusManagement.Location = new Point(29, 103);
            panelBusManagement.Margin = new Padding(4, 5, 4, 5);
            panelBusManagement.Name = "panelBusManagement";
            panelBusManagement.Size = new Size(1384, 897);
            panelBusManagement.TabIndex = 4;
            panelBusManagement.Visible = false;
            // 
            // lvBuses
            // 
            lvBuses.BorderStyle = BorderStyle.FixedSingle;
            lvBuses.Columns.AddRange(new ColumnHeader[] { colBusId, colPlateNumber, colBusModel, colBusType, colCapacity, colRegDate, colBusStatus, colAssignedTrip });
            lvBuses.Dock = DockStyle.Fill;
            lvBuses.Font = new Font("Segoe UI", 9.5F);
            lvBuses.FullRowSelect = true;
            lvBuses.GridLines = true;
            lvBuses.Location = new Point(0, 273);
            lvBuses.Margin = new Padding(4, 5, 4, 5);
            lvBuses.MultiSelect = false;
            lvBuses.Name = "lvBuses";
            lvBuses.Size = new Size(1384, 537);
            lvBuses.TabIndex = 3;
            lvBuses.UseCompatibleStateImageBehavior = false;
            lvBuses.View = View.Details;
            // 
            // colBusId
            // 
            colBusId.Text = "Bus ID";
            colBusId.Width = 90;
            // 
            // colPlateNumber
            // 
            colPlateNumber.Text = "Plate Number";
            colPlateNumber.Width = 130;
            // 
            // colBusModel
            // 
            colBusModel.Text = "Bus Name / Model";
            colBusModel.Width = 170;
            // 
            // colBusType
            // 
            colBusType.Text = "Bus Type";
            colBusType.Width = 110;
            // 
            // colCapacity
            // 
            colCapacity.Text = "Capacity";
            colCapacity.Width = 80;
            // 
            // colRegDate
            // 
            colRegDate.Text = "Registration Date";
            colRegDate.Width = 120;
            // 
            // colBusStatus
            // 
            colBusStatus.Text = "Status";
            colBusStatus.Width = 100;
            // 
            // colAssignedTrip
            // 
            colAssignedTrip.Text = "Assigned Trip";
            colAssignedTrip.Width = 230;
            // 
            // panelBusActions
            // 
            panelBusActions.Controls.Add(btnViewBusDetails);
            panelBusActions.Controls.Add(btnEditBus);
            panelBusActions.Controls.Add(btnChangeBusStatus);
            panelBusActions.Controls.Add(btnDeleteBus);
            panelBusActions.Controls.Add(lblBusCount);
            panelBusActions.Dock = DockStyle.Bottom;
            panelBusActions.Location = new Point(0, 810);
            panelBusActions.Margin = new Padding(4, 5, 4, 5);
            panelBusActions.Name = "panelBusActions";
            panelBusActions.Size = new Size(1384, 87);
            panelBusActions.TabIndex = 4;
            // 
            // btnViewBusDetails
            // 
            btnViewBusDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewBusDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewBusDetails.FlatStyle = FlatStyle.Flat;
            btnViewBusDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewBusDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewBusDetails.Location = new Point(0, 17);
            btnViewBusDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewBusDetails.Name = "btnViewBusDetails";
            btnViewBusDetails.Size = new Size(179, 57);
            btnViewBusDetails.TabIndex = 0;
            btnViewBusDetails.Text = "View Details";
            btnViewBusDetails.UseVisualStyleBackColor = false;
            // 
            // btnEditBus
            // 
            btnEditBus.BackColor = Color.FromArgb(241, 245, 249);
            btnEditBus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnEditBus.FlatStyle = FlatStyle.Flat;
            btnEditBus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditBus.ForeColor = Color.FromArgb(30, 41, 59);
            btnEditBus.Location = new Point(193, 17);
            btnEditBus.Margin = new Padding(4, 5, 4, 5);
            btnEditBus.Name = "btnEditBus";
            btnEditBus.Size = new Size(157, 57);
            btnEditBus.TabIndex = 1;
            btnEditBus.Text = "Edit Bus";
            btnEditBus.UseVisualStyleBackColor = false;
            // 
            // btnChangeBusStatus
            // 
            btnChangeBusStatus.BackColor = Color.FromArgb(241, 245, 249);
            btnChangeBusStatus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnChangeBusStatus.FlatStyle = FlatStyle.Flat;
            btnChangeBusStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnChangeBusStatus.ForeColor = Color.FromArgb(30, 41, 59);
            btnChangeBusStatus.Location = new Point(364, 17);
            btnChangeBusStatus.Margin = new Padding(4, 5, 4, 5);
            btnChangeBusStatus.Name = "btnChangeBusStatus";
            btnChangeBusStatus.Size = new Size(221, 57);
            btnChangeBusStatus.TabIndex = 2;
            btnChangeBusStatus.Text = "Change Status";
            btnChangeBusStatus.UseVisualStyleBackColor = false;
            // 
            // btnDeleteBus
            // 
            btnDeleteBus.BackColor = Color.FromArgb(241, 245, 249);
            btnDeleteBus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDeleteBus.FlatStyle = FlatStyle.Flat;
            btnDeleteBus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteBus.ForeColor = Color.FromArgb(51, 65, 85);
            btnDeleteBus.Location = new Point(600, 17);
            btnDeleteBus.Margin = new Padding(4, 5, 4, 5);
            btnDeleteBus.Name = "btnDeleteBus";
            btnDeleteBus.Size = new Size(171, 57);
            btnDeleteBus.TabIndex = 3;
            btnDeleteBus.Text = "Delete Bus";
            btnDeleteBus.UseVisualStyleBackColor = false;
            // 
            // lblBusCount
            // 
            lblBusCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblBusCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBusCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblBusCount.Location = new Point(1055, 27);
            lblBusCount.Margin = new Padding(4, 0, 4, 0);
            lblBusCount.Name = "lblBusCount";
            lblBusCount.Size = new Size(314, 33);
            lblBusCount.TabIndex = 4;
            lblBusCount.Text = "Showing 8 buses";
            lblBusCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelBusesToolbar
            // 
            panelBusesToolbar.Controls.Add(txtSearchBus);
            panelBusesToolbar.Controls.Add(cmbBusTypeFilter);
            panelBusesToolbar.Controls.Add(cmbBusStatusFilter);
            panelBusesToolbar.Controls.Add(btnRefreshBuses);
            panelBusesToolbar.Dock = DockStyle.Top;
            panelBusesToolbar.Location = new Point(0, 190);
            panelBusesToolbar.Margin = new Padding(4, 5, 4, 5);
            panelBusesToolbar.Name = "panelBusesToolbar";
            panelBusesToolbar.Size = new Size(1384, 83);
            panelBusesToolbar.TabIndex = 2;
            // 
            // txtSearchBus
            // 
            txtSearchBus.Font = new Font("Segoe UI", 10F);
            txtSearchBus.Location = new Point(0, 20);
            txtSearchBus.Margin = new Padding(4, 5, 4, 5);
            txtSearchBus.Name = "txtSearchBus";
            txtSearchBus.Size = new Size(455, 34);
            txtSearchBus.TabIndex = 0;
            // 
            // cmbBusTypeFilter
            // 
            cmbBusTypeFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusTypeFilter.Font = new Font("Segoe UI", 9.5F);
            cmbBusTypeFilter.FormattingEnabled = true;
            cmbBusTypeFilter.Items.AddRange(new object[] { "All Bus Types", "Luxury", "Standard", "Semi-Luxury", "Mini-Bus" });
            cmbBusTypeFilter.Location = new Point(479, 20);
            cmbBusTypeFilter.Margin = new Padding(4, 5, 4, 5);
            cmbBusTypeFilter.Name = "cmbBusTypeFilter";
            cmbBusTypeFilter.Size = new Size(213, 33);
            cmbBusTypeFilter.TabIndex = 1;
            // 
            // cmbBusStatusFilter
            // 
            cmbBusStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusStatusFilter.Font = new Font("Segoe UI", 9.5F);
            cmbBusStatusFilter.FormattingEnabled = true;
            cmbBusStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Maintenance", "Inactive" });
            cmbBusStatusFilter.Location = new Point(707, 20);
            cmbBusStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbBusStatusFilter.Name = "cmbBusStatusFilter";
            cmbBusStatusFilter.Size = new Size(205, 33);
            cmbBusStatusFilter.TabIndex = 2;
            // 
            // btnRefreshBuses
            // 
            btnRefreshBuses.BackColor = Color.FromArgb(241, 245, 249);
            btnRefreshBuses.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefreshBuses.FlatStyle = FlatStyle.Flat;
            btnRefreshBuses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshBuses.ForeColor = Color.FromArgb(51, 65, 85);
            btnRefreshBuses.Location = new Point(929, 15);
            btnRefreshBuses.Margin = new Padding(4, 5, 4, 5);
            btnRefreshBuses.Name = "btnRefreshBuses";
            btnRefreshBuses.Size = new Size(143, 53);
            btnRefreshBuses.TabIndex = 3;
            btnRefreshBuses.Text = "Refresh";
            btnRefreshBuses.UseVisualStyleBackColor = false;
            // 
            // flowBusMetrics
            // 
            flowBusMetrics.Controls.Add(cardTotalBuses);
            flowBusMetrics.Controls.Add(cardActiveBuses);
            flowBusMetrics.Controls.Add(cardMaintenanceBuses);
            flowBusMetrics.Controls.Add(cardInactiveBuses);
            flowBusMetrics.Dock = DockStyle.Top;
            flowBusMetrics.Location = new Point(0, 70);
            flowBusMetrics.Margin = new Padding(4, 5, 4, 5);
            flowBusMetrics.Name = "flowBusMetrics";
            flowBusMetrics.Size = new Size(1384, 120);
            flowBusMetrics.TabIndex = 1;
            // 
            // cardTotalBuses
            // 
            cardTotalBuses.BackColor = Color.White;
            cardTotalBuses.BorderStyle = BorderStyle.FixedSingle;
            cardTotalBuses.Controls.Add(lblMetricTotalBusesVal);
            cardTotalBuses.Controls.Add(lblMetricTotalBusesTitle);
            cardTotalBuses.Controls.Add(lblMetricTotalBusesSub);
            cardTotalBuses.Location = new Point(0, 8);
            cardTotalBuses.Margin = new Padding(0, 8, 17, 8);
            cardTotalBuses.Name = "cardTotalBuses";
            cardTotalBuses.Size = new Size(321, 99);
            cardTotalBuses.TabIndex = 0;
            // 
            // lblMetricTotalBusesVal
            // 
            lblMetricTotalBusesVal.AutoSize = true;
            lblMetricTotalBusesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricTotalBusesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTotalBusesVal.Location = new Point(17, 13);
            lblMetricTotalBusesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBusesVal.Name = "lblMetricTotalBusesVal";
            lblMetricTotalBusesVal.Size = new Size(38, 45);
            lblMetricTotalBusesVal.TabIndex = 0;
            lblMetricTotalBusesVal.Text = "8";
            // 
            // lblMetricTotalBusesTitle
            // 
            lblMetricTotalBusesTitle.AutoSize = true;
            lblMetricTotalBusesTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricTotalBusesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricTotalBusesTitle.Location = new Point(20, 63);
            lblMetricTotalBusesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBusesTitle.Name = "lblMetricTotalBusesTitle";
            lblMetricTotalBusesTitle.Size = new Size(98, 23);
            lblMetricTotalBusesTitle.TabIndex = 1;
            lblMetricTotalBusesTitle.Text = "Total Buses";
            // 
            // lblMetricTotalBusesSub
            // 
            lblMetricTotalBusesSub.AutoSize = true;
            lblMetricTotalBusesSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricTotalBusesSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTotalBusesSub.Location = new Point(20, 88);
            lblMetricTotalBusesSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricTotalBusesSub.Name = "lblMetricTotalBusesSub";
            lblMetricTotalBusesSub.Size = new Size(146, 21);
            lblMetricTotalBusesSub.TabIndex = 2;
            lblMetricTotalBusesSub.Text = "All registered buses";
            lblMetricTotalBusesSub.Visible = false;
            // 
            // cardActiveBuses
            // 
            cardActiveBuses.BackColor = Color.White;
            cardActiveBuses.BorderStyle = BorderStyle.FixedSingle;
            cardActiveBuses.Controls.Add(lblMetricActiveBusesVal);
            cardActiveBuses.Controls.Add(lblMetricActiveBusesTitle);
            cardActiveBuses.Controls.Add(lblMetricActiveBusesSub);
            cardActiveBuses.Location = new Point(338, 8);
            cardActiveBuses.Margin = new Padding(0, 8, 17, 8);
            cardActiveBuses.Name = "cardActiveBuses";
            cardActiveBuses.Size = new Size(321, 99);
            cardActiveBuses.TabIndex = 1;
            // 
            // lblMetricActiveBusesVal
            // 
            lblMetricActiveBusesVal.AutoSize = true;
            lblMetricActiveBusesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricActiveBusesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricActiveBusesVal.Location = new Point(17, 13);
            lblMetricActiveBusesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricActiveBusesVal.Name = "lblMetricActiveBusesVal";
            lblMetricActiveBusesVal.Size = new Size(38, 45);
            lblMetricActiveBusesVal.TabIndex = 0;
            lblMetricActiveBusesVal.Text = "6";
            // 
            // lblMetricActiveBusesTitle
            // 
            lblMetricActiveBusesTitle.AutoSize = true;
            lblMetricActiveBusesTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricActiveBusesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricActiveBusesTitle.Location = new Point(20, 63);
            lblMetricActiveBusesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricActiveBusesTitle.Name = "lblMetricActiveBusesTitle";
            lblMetricActiveBusesTitle.Size = new Size(109, 23);
            lblMetricActiveBusesTitle.TabIndex = 1;
            lblMetricActiveBusesTitle.Text = "Active Buses";
            // 
            // lblMetricActiveBusesSub
            // 
            lblMetricActiveBusesSub.AutoSize = true;
            lblMetricActiveBusesSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricActiveBusesSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricActiveBusesSub.Location = new Point(20, 88);
            lblMetricActiveBusesSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricActiveBusesSub.Name = "lblMetricActiveBusesSub";
            lblMetricActiveBusesSub.Size = new Size(175, 21);
            lblMetricActiveBusesSub.TabIndex = 2;
            lblMetricActiveBusesSub.Text = "Available for operations";
            lblMetricActiveBusesSub.Visible = false;
            // 
            // cardMaintenanceBuses
            // 
            cardMaintenanceBuses.BackColor = Color.White;
            cardMaintenanceBuses.BorderStyle = BorderStyle.FixedSingle;
            cardMaintenanceBuses.Controls.Add(lblMetricMaintBusesVal);
            cardMaintenanceBuses.Controls.Add(lblMetricMaintBusesTitle);
            cardMaintenanceBuses.Controls.Add(lblMetricMaintBusesSub);
            cardMaintenanceBuses.Location = new Point(676, 8);
            cardMaintenanceBuses.Margin = new Padding(0, 8, 17, 8);
            cardMaintenanceBuses.Name = "cardMaintenanceBuses";
            cardMaintenanceBuses.Size = new Size(321, 99);
            cardMaintenanceBuses.TabIndex = 2;
            // 
            // lblMetricMaintBusesVal
            // 
            lblMetricMaintBusesVal.AutoSize = true;
            lblMetricMaintBusesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricMaintBusesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricMaintBusesVal.Location = new Point(17, 13);
            lblMetricMaintBusesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricMaintBusesVal.Name = "lblMetricMaintBusesVal";
            lblMetricMaintBusesVal.Size = new Size(38, 45);
            lblMetricMaintBusesVal.TabIndex = 0;
            lblMetricMaintBusesVal.Text = "1";
            // 
            // lblMetricMaintBusesTitle
            // 
            lblMetricMaintBusesTitle.AutoSize = true;
            lblMetricMaintBusesTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricMaintBusesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricMaintBusesTitle.Location = new Point(20, 63);
            lblMetricMaintBusesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricMaintBusesTitle.Name = "lblMetricMaintBusesTitle";
            lblMetricMaintBusesTitle.Size = new Size(112, 23);
            lblMetricMaintBusesTitle.TabIndex = 1;
            lblMetricMaintBusesTitle.Text = "Maintenance";
            // 
            // lblMetricMaintBusesSub
            // 
            lblMetricMaintBusesSub.AutoSize = true;
            lblMetricMaintBusesSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricMaintBusesSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricMaintBusesSub.Location = new Point(20, 88);
            lblMetricMaintBusesSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricMaintBusesSub.Name = "lblMetricMaintBusesSub";
            lblMetricMaintBusesSub.Size = new Size(146, 21);
            lblMetricMaintBusesSub.TabIndex = 2;
            lblMetricMaintBusesSub.Text = "Under maintenance";
            lblMetricMaintBusesSub.Visible = false;
            // 
            // cardInactiveBuses
            // 
            cardInactiveBuses.BackColor = Color.White;
            cardInactiveBuses.BorderStyle = BorderStyle.FixedSingle;
            cardInactiveBuses.Controls.Add(lblMetricInactiveBusesVal);
            cardInactiveBuses.Controls.Add(lblMetricInactiveBusesTitle);
            cardInactiveBuses.Controls.Add(lblMetricInactiveBusesSub);
            cardInactiveBuses.Location = new Point(1014, 8);
            cardInactiveBuses.Margin = new Padding(0, 8, 0, 8);
            cardInactiveBuses.Name = "cardInactiveBuses";
            cardInactiveBuses.Size = new Size(321, 99);
            cardInactiveBuses.TabIndex = 3;
            // 
            // lblMetricInactiveBusesVal
            // 
            lblMetricInactiveBusesVal.AutoSize = true;
            lblMetricInactiveBusesVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricInactiveBusesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricInactiveBusesVal.Location = new Point(17, 13);
            lblMetricInactiveBusesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricInactiveBusesVal.Name = "lblMetricInactiveBusesVal";
            lblMetricInactiveBusesVal.Size = new Size(38, 45);
            lblMetricInactiveBusesVal.TabIndex = 0;
            lblMetricInactiveBusesVal.Text = "1";
            // 
            // lblMetricInactiveBusesTitle
            // 
            lblMetricInactiveBusesTitle.AutoSize = true;
            lblMetricInactiveBusesTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblMetricInactiveBusesTitle.ForeColor = Color.FromArgb(30, 41, 59);
            lblMetricInactiveBusesTitle.Location = new Point(20, 63);
            lblMetricInactiveBusesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricInactiveBusesTitle.Name = "lblMetricInactiveBusesTitle";
            lblMetricInactiveBusesTitle.Size = new Size(121, 23);
            lblMetricInactiveBusesTitle.TabIndex = 1;
            lblMetricInactiveBusesTitle.Text = "Inactive Buses";
            // 
            // lblMetricInactiveBusesSub
            // 
            lblMetricInactiveBusesSub.AutoSize = true;
            lblMetricInactiveBusesSub.Font = new Font("Segoe UI", 7.8F);
            lblMetricInactiveBusesSub.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricInactiveBusesSub.Location = new Point(20, 88);
            lblMetricInactiveBusesSub.Margin = new Padding(4, 0, 4, 0);
            lblMetricInactiveBusesSub.Name = "lblMetricInactiveBusesSub";
            lblMetricInactiveBusesSub.Size = new Size(105, 21);
            lblMetricInactiveBusesSub.TabIndex = 2;
            lblMetricInactiveBusesSub.Text = "Not in service";
            lblMetricInactiveBusesSub.Visible = false;
            // 
            // panelBusesHeader
            // 
            panelBusesHeader.Controls.Add(btnAddBus);
            panelBusesHeader.Controls.Add(lblBusesTitle);
            panelBusesHeader.Controls.Add(lblBusesSubtitle);
            panelBusesHeader.Dock = DockStyle.Top;
            panelBusesHeader.Location = new Point(0, 0);
            panelBusesHeader.Margin = new Padding(4, 5, 4, 5);
            panelBusesHeader.Name = "panelBusesHeader";
            panelBusesHeader.Size = new Size(1384, 70);
            panelBusesHeader.TabIndex = 0;
            // 
            // btnAddBus
            // 
            btnAddBus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddBus.BackColor = Color.FromArgb(15, 23, 42);
            btnAddBus.FlatAppearance.BorderSize = 0;
            btnAddBus.FlatStyle = FlatStyle.Flat;
            btnAddBus.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddBus.ForeColor = Color.White;
            btnAddBus.Location = new Point(1177, 7);
            btnAddBus.Margin = new Padding(4, 5, 4, 5);
            btnAddBus.Name = "btnAddBus";
            btnAddBus.Size = new Size(207, 60);
            btnAddBus.TabIndex = 2;
            btnAddBus.Text = "Add New Bus";
            btnAddBus.UseVisualStyleBackColor = false;
            // 
            // lblBusesTitle
            // 
            lblBusesTitle.AutoSize = true;
            lblBusesTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBusesTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblBusesTitle.Location = new Point(0, 0);
            lblBusesTitle.Margin = new Padding(4, 0, 4, 0);
            lblBusesTitle.Name = "lblBusesTitle";
            lblBusesTitle.Size = new Size(281, 45);
            lblBusesTitle.TabIndex = 0;
            lblBusesTitle.Text = "Bus Management";
            // 
            // lblBusesSubtitle
            // 
            lblBusesSubtitle.AutoSize = true;
            lblBusesSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblBusesSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblBusesSubtitle.Location = new Point(0, 50);
            lblBusesSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblBusesSubtitle.Name = "lblBusesSubtitle";
            lblBusesSubtitle.Size = new Size(609, 25);
            lblBusesSubtitle.TabIndex = 1;
            lblBusesSubtitle.Text = "Manage vehicle fleet inventory, seating capacities, and service statuses.";
            lblBusesSubtitle.Visible = false;
            // 
            // panelUserManagement
            // 
            panelUserManagement.Controls.Add(lvUsers);
            panelUserManagement.Controls.Add(panelUserActions);
            panelUserManagement.Controls.Add(panelUsersToolbar);
            panelUserManagement.Controls.Add(panelUsersHeader);
            panelUserManagement.Dock = DockStyle.Fill;
            panelUserManagement.Location = new Point(29, 103);
            panelUserManagement.Margin = new Padding(4, 5, 4, 5);
            panelUserManagement.Name = "panelUserManagement";
            panelUserManagement.Size = new Size(1384, 897);
            panelUserManagement.TabIndex = 3;
            panelUserManagement.Visible = false;
            // 
            // lvUsers
            // 
            lvUsers.BorderStyle = BorderStyle.FixedSingle;
            lvUsers.Columns.AddRange(new ColumnHeader[] { colUserId, colFullName, colUsername, colEmail, colPhone, colRole, colStatus, colCreatedDate });
            lvUsers.Dock = DockStyle.Fill;
            lvUsers.Font = new Font("Segoe UI", 9.5F);
            lvUsers.FullRowSelect = true;
            lvUsers.GridLines = true;
            lvUsers.Location = new Point(0, 157);
            lvUsers.Margin = new Padding(4, 5, 4, 5);
            lvUsers.MultiSelect = false;
            lvUsers.Name = "lvUsers";
            lvUsers.Size = new Size(1384, 653);
            lvUsers.TabIndex = 2;
            lvUsers.UseCompatibleStateImageBehavior = false;
            lvUsers.View = View.Details;
            // 
            // colUserId
            // 
            colUserId.Text = "User ID";
            colUserId.Width = 90;
            // 
            // colFullName
            // 
            colFullName.Text = "Full Name";
            colFullName.Width = 160;
            // 
            // colUsername
            // 
            colUsername.Text = "Username";
            colUsername.Width = 120;
            // 
            // colEmail
            // 
            colEmail.Text = "Email Address";
            colEmail.Width = 180;
            // 
            // colPhone
            // 
            colPhone.Text = "Phone Number";
            colPhone.Width = 130;
            // 
            // colRole
            // 
            colRole.Text = "Role";
            colRole.Width = 130;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 90;
            // 
            // colCreatedDate
            // 
            colCreatedDate.Text = "Created Date";
            colCreatedDate.Width = 130;
            // 
            // panelUserActions
            // 
            panelUserActions.Controls.Add(btnViewUserDetails);
            panelUserActions.Controls.Add(btnEditUser);
            panelUserActions.Controls.Add(btnToggleUserStatus);
            panelUserActions.Controls.Add(btnResetUserPassword);
            panelUserActions.Controls.Add(btnDeleteUser);
            panelUserActions.Controls.Add(lblUserCount);
            panelUserActions.Dock = DockStyle.Bottom;
            panelUserActions.Location = new Point(0, 810);
            panelUserActions.Margin = new Padding(4, 5, 4, 5);
            panelUserActions.Name = "panelUserActions";
            panelUserActions.Size = new Size(1384, 87);
            panelUserActions.TabIndex = 3;
            // 
            // btnViewUserDetails
            // 
            btnViewUserDetails.BackColor = Color.FromArgb(241, 245, 249);
            btnViewUserDetails.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnViewUserDetails.FlatStyle = FlatStyle.Flat;
            btnViewUserDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewUserDetails.ForeColor = Color.FromArgb(30, 41, 59);
            btnViewUserDetails.Location = new Point(0, 17);
            btnViewUserDetails.Margin = new Padding(4, 5, 4, 5);
            btnViewUserDetails.Name = "btnViewUserDetails";
            btnViewUserDetails.Size = new Size(164, 57);
            btnViewUserDetails.TabIndex = 0;
            btnViewUserDetails.Text = "View Details";
            btnViewUserDetails.UseVisualStyleBackColor = false;
            // 
            // btnEditUser
            // 
            btnEditUser.BackColor = Color.FromArgb(241, 245, 249);
            btnEditUser.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnEditUser.FlatStyle = FlatStyle.Flat;
            btnEditUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEditUser.ForeColor = Color.FromArgb(30, 41, 59);
            btnEditUser.Location = new Point(179, 17);
            btnEditUser.Margin = new Padding(4, 5, 4, 5);
            btnEditUser.Name = "btnEditUser";
            btnEditUser.Size = new Size(150, 57);
            btnEditUser.TabIndex = 1;
            btnEditUser.Text = "Edit User";
            btnEditUser.UseVisualStyleBackColor = false;
            // 
            // btnToggleUserStatus
            // 
            btnToggleUserStatus.BackColor = Color.FromArgb(241, 245, 249);
            btnToggleUserStatus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnToggleUserStatus.FlatStyle = FlatStyle.Flat;
            btnToggleUserStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnToggleUserStatus.ForeColor = Color.FromArgb(30, 41, 59);
            btnToggleUserStatus.Location = new Point(343, 17);
            btnToggleUserStatus.Margin = new Padding(4, 5, 4, 5);
            btnToggleUserStatus.Name = "btnToggleUserStatus";
            btnToggleUserStatus.Size = new Size(236, 57);
            btnToggleUserStatus.TabIndex = 2;
            btnToggleUserStatus.Text = "Activate / Deactivate";
            btnToggleUserStatus.UseVisualStyleBackColor = false;
            // 
            // btnResetUserPassword
            // 
            btnResetUserPassword.BackColor = Color.FromArgb(241, 245, 249);
            btnResetUserPassword.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetUserPassword.FlatStyle = FlatStyle.Flat;
            btnResetUserPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnResetUserPassword.ForeColor = Color.FromArgb(30, 41, 59);
            btnResetUserPassword.Location = new Point(593, 17);
            btnResetUserPassword.Margin = new Padding(4, 5, 4, 5);
            btnResetUserPassword.Name = "btnResetUserPassword";
            btnResetUserPassword.Size = new Size(200, 57);
            btnResetUserPassword.TabIndex = 3;
            btnResetUserPassword.Text = "Reset Password";
            btnResetUserPassword.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(241, 245, 249);
            btnDeleteUser.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteUser.ForeColor = Color.FromArgb(51, 65, 85);
            btnDeleteUser.Location = new Point(807, 17);
            btnDeleteUser.Margin = new Padding(4, 5, 4, 5);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(164, 57);
            btnDeleteUser.TabIndex = 4;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // lblUserCount
            // 
            lblUserCount.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUserCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUserCount.ForeColor = Color.FromArgb(100, 116, 139);
            lblUserCount.Location = new Point(1055, 27);
            lblUserCount.Margin = new Padding(4, 0, 4, 0);
            lblUserCount.Name = "lblUserCount";
            lblUserCount.Size = new Size(314, 33);
            lblUserCount.TabIndex = 5;
            lblUserCount.Text = "Showing 7 accounts";
            lblUserCount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelUsersToolbar
            // 
            panelUsersToolbar.Controls.Add(btnAddUser);
            panelUsersToolbar.Controls.Add(txtSearchUser);
            panelUsersToolbar.Controls.Add(cmbRoleFilter);
            panelUsersToolbar.Controls.Add(cmbStatusFilter);
            panelUsersToolbar.Controls.Add(btnRefreshUsers);
            panelUsersToolbar.Dock = DockStyle.Top;
            panelUsersToolbar.Location = new Point(0, 70);
            panelUsersToolbar.Margin = new Padding(4, 5, 4, 5);
            panelUsersToolbar.Name = "panelUsersToolbar";
            panelUsersToolbar.Size = new Size(1384, 87);
            panelUsersToolbar.TabIndex = 1;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = Color.FromArgb(15, 23, 42);
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.FlatStyle = FlatStyle.Flat;
            btnAddUser.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddUser.ForeColor = Color.White;
            btnAddUser.Location = new Point(0, 13);
            btnAddUser.Margin = new Padding(4, 5, 4, 5);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(171, 60);
            btnAddUser.TabIndex = 0;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = false;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Font = new Font("Segoe UI", 10F);
            txtSearchUser.Location = new Point(193, 22);
            txtSearchUser.Margin = new Padding(4, 5, 4, 5);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(370, 34);
            txtSearchUser.TabIndex = 1;
            // 
            // cmbRoleFilter
            // 
            cmbRoleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoleFilter.Font = new Font("Segoe UI", 9.5F);
            cmbRoleFilter.FormattingEnabled = true;
            cmbRoleFilter.Items.AddRange(new object[] { "All Roles", "Administrator", "Passenger", "Ticket Officer", "Driver", "Bus Manager" });
            cmbRoleFilter.Location = new Point(586, 22);
            cmbRoleFilter.Margin = new Padding(4, 5, 4, 5);
            cmbRoleFilter.Name = "cmbRoleFilter";
            cmbRoleFilter.Size = new Size(205, 33);
            cmbRoleFilter.TabIndex = 2;
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new Font("Segoe UI", 9.5F);
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Active", "Inactive" });
            cmbStatusFilter.Location = new Point(807, 22);
            cmbStatusFilter.Margin = new Padding(4, 5, 4, 5);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(177, 33);
            cmbStatusFilter.TabIndex = 3;
            // 
            // btnRefreshUsers
            // 
            btnRefreshUsers.BackColor = Color.FromArgb(241, 245, 249);
            btnRefreshUsers.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnRefreshUsers.FlatStyle = FlatStyle.Flat;
            btnRefreshUsers.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefreshUsers.ForeColor = Color.FromArgb(51, 65, 85);
            btnRefreshUsers.Location = new Point(1003, 17);
            btnRefreshUsers.Margin = new Padding(4, 5, 4, 5);
            btnRefreshUsers.Name = "btnRefreshUsers";
            btnRefreshUsers.Size = new Size(143, 53);
            btnRefreshUsers.TabIndex = 4;
            btnRefreshUsers.Text = "Refresh";
            btnRefreshUsers.UseVisualStyleBackColor = false;
            // 
            // panelUsersHeader
            // 
            panelUsersHeader.Controls.Add(lblUsersTitle);
            panelUsersHeader.Controls.Add(lblUsersSubtitle);
            panelUsersHeader.Dock = DockStyle.Top;
            panelUsersHeader.Location = new Point(0, 0);
            panelUsersHeader.Margin = new Padding(4, 5, 4, 5);
            panelUsersHeader.Name = "panelUsersHeader";
            panelUsersHeader.Size = new Size(1384, 70);
            panelUsersHeader.TabIndex = 0;
            // 
            // lblUsersTitle
            // 
            lblUsersTitle.AutoSize = true;
            lblUsersTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblUsersTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblUsersTitle.Location = new Point(0, 0);
            lblUsersTitle.Margin = new Padding(4, 0, 4, 0);
            lblUsersTitle.Name = "lblUsersTitle";
            lblUsersTitle.Size = new Size(294, 45);
            lblUsersTitle.TabIndex = 0;
            lblUsersTitle.Text = "User Management";
            // 
            // lblUsersSubtitle
            // 
            lblUsersSubtitle.AutoSize = true;
            lblUsersSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblUsersSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblUsersSubtitle.Location = new Point(0, 50);
            lblUsersSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblUsersSubtitle.Name = "lblUsersSubtitle";
            lblUsersSubtitle.Size = new Size(581, 25);
            lblUsersSubtitle.TabIndex = 1;
            lblUsersSubtitle.Text = "Manage system users, roles, account status, and access permissions.";
            lblUsersSubtitle.Visible = false;
            // 
            // flowDashboard
            // 
            flowDashboard.AutoScroll = true;
            flowDashboard.Controls.Add(grpOverview);
            flowDashboard.Controls.Add(grpQuickActions);
            flowDashboard.Controls.Add(grpTripsSchedule);
            flowDashboard.Controls.Add(grpTicketVerify);
            flowDashboard.Dock = DockStyle.Fill;
            flowDashboard.FlowDirection = FlowDirection.TopDown;
            flowDashboard.Location = new Point(29, 103);
            flowDashboard.Margin = new Padding(4, 5, 4, 5);
            flowDashboard.Name = "flowDashboard";
            flowDashboard.Size = new Size(1384, 897);
            flowDashboard.TabIndex = 1;
            flowDashboard.WrapContents = false;
            // 
            // grpOverview
            // 
            grpOverview.BackColor = Color.White;
            grpOverview.Controls.Add(cardBuses);
            grpOverview.Controls.Add(cardTrips);
            grpOverview.Controls.Add(cardBookings);
            grpOverview.Controls.Add(cardRevenue);
            grpOverview.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpOverview.ForeColor = Color.FromArgb(15, 23, 42);
            grpOverview.Location = new Point(4, 5);
            grpOverview.Margin = new Padding(4, 5, 4, 5);
            grpOverview.Name = "grpOverview";
            grpOverview.Padding = new Padding(4, 5, 4, 5);
            grpOverview.Size = new Size(1343, 210);
            grpOverview.TabIndex = 0;
            grpOverview.TabStop = false;
            grpOverview.Text = "System Metrics & Summaries";
            // 
            // cardBuses
            // 
            cardBuses.BackColor = Color.White;
            cardBuses.BorderStyle = BorderStyle.FixedSingle;
            cardBuses.Controls.Add(lblMetricBusesVal);
            cardBuses.Controls.Add(lblMetricBusesTitle);
            cardBuses.Location = new Point(26, 50);
            cardBuses.Margin = new Padding(4, 5, 4, 5);
            cardBuses.Name = "cardBuses";
            cardBuses.Size = new Size(299, 129);
            cardBuses.TabIndex = 0;
            // 
            // lblMetricBusesVal
            // 
            lblMetricBusesVal.AutoSize = true;
            lblMetricBusesVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricBusesVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricBusesVal.Location = new Point(17, 17);
            lblMetricBusesVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricBusesVal.Name = "lblMetricBusesVal";
            lblMetricBusesVal.Size = new Size(168, 48);
            lblMetricBusesVal.TabIndex = 0;
            lblMetricBusesVal.Text = "48 Buses";
            // 
            // lblMetricBusesTitle
            // 
            lblMetricBusesTitle.AutoSize = true;
            lblMetricBusesTitle.Font = new Font("Segoe UI", 9F);
            lblMetricBusesTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricBusesTitle.Location = new Point(20, 77);
            lblMetricBusesTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricBusesTitle.Name = "lblMetricBusesTitle";
            lblMetricBusesTitle.Size = new Size(206, 25);
            lblMetricBusesTitle.TabIndex = 1;
            lblMetricBusesTitle.Text = "Active Fleet in Operation";
            // 
            // cardTrips
            // 
            cardTrips.BackColor = Color.White;
            cardTrips.BorderStyle = BorderStyle.FixedSingle;
            cardTrips.Controls.Add(lblMetricTripsVal);
            cardTrips.Controls.Add(lblMetricTripsTitle);
            cardTrips.Location = new Point(351, 50);
            cardTrips.Margin = new Padding(4, 5, 4, 5);
            cardTrips.Name = "cardTrips";
            cardTrips.Size = new Size(299, 129);
            cardTrips.TabIndex = 1;
            // 
            // lblMetricTripsVal
            // 
            lblMetricTripsVal.AutoSize = true;
            lblMetricTripsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricTripsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricTripsVal.Location = new Point(17, 17);
            lblMetricTripsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricTripsVal.Name = "lblMetricTripsVal";
            lblMetricTripsVal.Size = new Size(173, 48);
            lblMetricTripsVal.TabIndex = 0;
            lblMetricTripsVal.Text = "124 Trips";
            // 
            // lblMetricTripsTitle
            // 
            lblMetricTripsTitle.AutoSize = true;
            lblMetricTripsTitle.Font = new Font("Segoe UI", 9F);
            lblMetricTripsTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricTripsTitle.Location = new Point(20, 77);
            lblMetricTripsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricTripsTitle.Name = "lblMetricTripsTitle";
            lblMetricTripsTitle.Size = new Size(187, 25);
            lblMetricTripsTitle.TabIndex = 1;
            lblMetricTripsTitle.Text = "Scheduled Trips Today";
            // 
            // cardBookings
            // 
            cardBookings.BackColor = Color.White;
            cardBookings.BorderStyle = BorderStyle.FixedSingle;
            cardBookings.Controls.Add(lblMetricBookingsVal);
            cardBookings.Controls.Add(lblMetricBookingsTitle);
            cardBookings.Location = new Point(677, 50);
            cardBookings.Margin = new Padding(4, 5, 4, 5);
            cardBookings.Name = "cardBookings";
            cardBookings.Size = new Size(299, 129);
            cardBookings.TabIndex = 2;
            // 
            // lblMetricBookingsVal
            // 
            lblMetricBookingsVal.AutoSize = true;
            lblMetricBookingsVal.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblMetricBookingsVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricBookingsVal.Location = new Point(17, 17);
            lblMetricBookingsVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricBookingsVal.Name = "lblMetricBookingsVal";
            lblMetricBookingsVal.Size = new Size(240, 48);
            lblMetricBookingsVal.TabIndex = 0;
            lblMetricBookingsVal.Text = "1,842 Tickets";
            // 
            // lblMetricBookingsTitle
            // 
            lblMetricBookingsTitle.AutoSize = true;
            lblMetricBookingsTitle.Font = new Font("Segoe UI", 9F);
            lblMetricBookingsTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricBookingsTitle.Location = new Point(20, 77);
            lblMetricBookingsTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricBookingsTitle.Name = "lblMetricBookingsTitle";
            lblMetricBookingsTitle.Size = new Size(170, 25);
            lblMetricBookingsTitle.TabIndex = 1;
            lblMetricBookingsTitle.Text = "Passenger Bookings";
            // 
            // cardRevenue
            // 
            cardRevenue.BackColor = Color.White;
            cardRevenue.BorderStyle = BorderStyle.FixedSingle;
            cardRevenue.Controls.Add(lblMetricRevenueVal);
            cardRevenue.Controls.Add(lblMetricRevenueTitle);
            cardRevenue.Location = new Point(1003, 50);
            cardRevenue.Margin = new Padding(4, 5, 4, 5);
            cardRevenue.Name = "cardRevenue";
            cardRevenue.Size = new Size(313, 129);
            cardRevenue.TabIndex = 3;
            // 
            // lblMetricRevenueVal
            // 
            lblMetricRevenueVal.AutoSize = true;
            lblMetricRevenueVal.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblMetricRevenueVal.ForeColor = Color.FromArgb(15, 23, 42);
            lblMetricRevenueVal.Location = new Point(11, 20);
            lblMetricRevenueVal.Margin = new Padding(4, 0, 4, 0);
            lblMetricRevenueVal.Name = "lblMetricRevenueVal";
            lblMetricRevenueVal.Size = new Size(248, 45);
            lblMetricRevenueVal.TabIndex = 0;
            lblMetricRevenueVal.Text = "486,500.00 ETB";
            // 
            // lblMetricRevenueTitle
            // 
            lblMetricRevenueTitle.AutoSize = true;
            lblMetricRevenueTitle.Font = new Font("Segoe UI", 9F);
            lblMetricRevenueTitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblMetricRevenueTitle.Location = new Point(14, 77);
            lblMetricRevenueTitle.Margin = new Padding(4, 0, 4, 0);
            lblMetricRevenueTitle.Name = "lblMetricRevenueTitle";
            lblMetricRevenueTitle.Size = new Size(188, 25);
            lblMetricRevenueTitle.TabIndex = 1;
            lblMetricRevenueTitle.Text = "Total Daily Ticket Sales";
            // 
            // grpQuickActions
            // 
            grpQuickActions.BackColor = Color.White;
            grpQuickActions.Controls.Add(btnQuickAddBus);
            grpQuickActions.Controls.Add(btnQuickNewTrip);
            grpQuickActions.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpQuickActions.ForeColor = Color.FromArgb(15, 23, 42);
            grpQuickActions.Location = new Point(4, 225);
            grpQuickActions.Margin = new Padding(4, 5, 4, 5);
            grpQuickActions.Name = "grpQuickActions";
            grpQuickActions.Padding = new Padding(4, 5, 4, 5);
            grpQuickActions.Size = new Size(1343, 140);
            grpQuickActions.TabIndex = 1;
            grpQuickActions.TabStop = false;
            grpQuickActions.Text = "Quick Actions";
            // 
            // btnQuickAddBus
            // 
            btnQuickAddBus.BackColor = Color.FromArgb(241, 245, 249);
            btnQuickAddBus.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnQuickAddBus.FlatStyle = FlatStyle.Flat;
            btnQuickAddBus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickAddBus.ForeColor = Color.FromArgb(30, 41, 59);
            btnQuickAddBus.Location = new Point(29, 50);
            btnQuickAddBus.Margin = new Padding(4, 5, 4, 5);
            btnQuickAddBus.Name = "btnQuickAddBus";
            btnQuickAddBus.Size = new Size(300, 63);
            btnQuickAddBus.TabIndex = 0;
            btnQuickAddBus.Text = "Add New Bus";
            btnQuickAddBus.UseVisualStyleBackColor = false;
            // 
            // btnQuickNewTrip
            // 
            btnQuickNewTrip.BackColor = Color.FromArgb(241, 245, 249);
            btnQuickNewTrip.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnQuickNewTrip.FlatStyle = FlatStyle.Flat;
            btnQuickNewTrip.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnQuickNewTrip.ForeColor = Color.FromArgb(30, 41, 59);
            btnQuickNewTrip.Location = new Point(357, 50);
            btnQuickNewTrip.Margin = new Padding(4, 5, 4, 5);
            btnQuickNewTrip.Name = "btnQuickNewTrip";
            btnQuickNewTrip.Size = new Size(300, 63);
            btnQuickNewTrip.TabIndex = 1;
            btnQuickNewTrip.Text = "Schedule Trip";
            btnQuickNewTrip.UseVisualStyleBackColor = false;
            // 
            // grpTripsSchedule
            // 
            grpTripsSchedule.BackColor = Color.White;
            grpTripsSchedule.Controls.Add(dgvTrips);
            grpTripsSchedule.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpTripsSchedule.ForeColor = Color.FromArgb(15, 23, 42);
            grpTripsSchedule.Location = new Point(4, 375);
            grpTripsSchedule.Margin = new Padding(4, 5, 4, 5);
            grpTripsSchedule.Name = "grpTripsSchedule";
            grpTripsSchedule.Padding = new Padding(4, 5, 4, 5);
            grpTripsSchedule.Size = new Size(1343, 400);
            grpTripsSchedule.TabIndex = 2;
            grpTripsSchedule.TabStop = false;
            grpTripsSchedule.Text = "Today's Fleet Trips & Active Schedule Status";
            // 
            // dgvTrips
            // 
            dgvTrips.AllowUserToAddRows = false;
            dgvTrips.AllowUserToDeleteRows = false;
            dgvTrips.BackgroundColor = Color.White;
            dgvTrips.BorderStyle = BorderStyle.None;
            dgvTrips.ColumnHeadersHeight = 34;
            dgvTrips.Location = new Point(26, 47);
            dgvTrips.Margin = new Padding(4, 5, 4, 5);
            dgvTrips.Name = "dgvTrips";
            dgvTrips.ReadOnly = true;
            dgvTrips.RowHeadersVisible = false;
            dgvTrips.RowHeadersWidth = 62;
            dgvTrips.RowTemplate.Height = 32;
            dgvTrips.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTrips.Size = new Size(1291, 327);
            dgvTrips.TabIndex = 0;
            // 
            // grpTicketVerify
            // 
            grpTicketVerify.BackColor = Color.White;
            grpTicketVerify.Controls.Add(lblTicketSearchPrompt);
            grpTicketVerify.Controls.Add(txtTicketNumber);
            grpTicketVerify.Controls.Add(btnVerifyTicket);
            grpTicketVerify.Controls.Add(lblVerifyResult);
            grpTicketVerify.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            grpTicketVerify.ForeColor = Color.FromArgb(15, 23, 42);
            grpTicketVerify.Location = new Point(4, 785);
            grpTicketVerify.Margin = new Padding(4, 5, 4, 5);
            grpTicketVerify.Name = "grpTicketVerify";
            grpTicketVerify.Padding = new Padding(4, 5, 4, 5);
            grpTicketVerify.Size = new Size(1343, 183);
            grpTicketVerify.TabIndex = 3;
            grpTicketVerify.TabStop = false;
            grpTicketVerify.Text = "Ticket Search & Information Verification";
            // 
            // lblTicketSearchPrompt
            // 
            lblTicketSearchPrompt.AutoSize = true;
            lblTicketSearchPrompt.Font = new Font("Segoe UI", 9F);
            lblTicketSearchPrompt.ForeColor = Color.FromArgb(71, 85, 105);
            lblTicketSearchPrompt.Location = new Point(26, 50);
            lblTicketSearchPrompt.Margin = new Padding(4, 0, 4, 0);
            lblTicketSearchPrompt.Name = "lblTicketSearchPrompt";
            lblTicketSearchPrompt.Size = new Size(303, 25);
            lblTicketSearchPrompt.TabIndex = 0;
            lblTicketSearchPrompt.Text = "Enter Passenger Ticket / Booking Ref:";
            // 
            // txtTicketNumber
            // 
            txtTicketNumber.BackColor = Color.White;
            txtTicketNumber.Location = new Point(26, 87);
            txtTicketNumber.Margin = new Padding(4, 5, 4, 5);
            txtTicketNumber.Name = "txtTicketNumber";
            txtTicketNumber.Size = new Size(457, 70);
            txtTicketNumber.TabIndex = 1;
            // 
            // btnVerifyTicket
            // 
            btnVerifyTicket.FlatAppearance.BorderSize = 0;
            btnVerifyTicket.FlatStyle = FlatStyle.Flat;
            btnVerifyTicket.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnVerifyTicket.ForeColor = Color.White;
            btnVerifyTicket.Location = new Point(506, 87);
            btnVerifyTicket.Margin = new Padding(4, 5, 4, 5);
            btnVerifyTicket.Name = "btnVerifyTicket";
            btnVerifyTicket.Size = new Size(214, 70);
            btnVerifyTicket.TabIndex = 2;
            btnVerifyTicket.Text = "Verify Ticket";
            btnVerifyTicket.UseVisualStyleBackColor = true;
            // 
            // lblVerifyResult
            // 
            lblVerifyResult.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblVerifyResult.ForeColor = Color.FromArgb(71, 85, 105);
            lblVerifyResult.Location = new Point(743, 87);
            lblVerifyResult.Margin = new Padding(4, 0, 4, 0);
            lblVerifyResult.Name = "lblVerifyResult";
            lblVerifyResult.Size = new Size(571, 70);
            lblVerifyResult.TabIndex = 3;
            lblVerifyResult.Text = "Ready to verify passenger tickets.";
            lblVerifyResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelHeaderInfo
            // 
            panelHeaderInfo.Controls.Add(lblPageHeading);

            panelHeaderInfo.Controls.Add(lblPageSubHeading);
            panelHeaderInfo.Dock = DockStyle.Top;
            panelHeaderInfo.Location = new Point(29, 33);
            panelHeaderInfo.Margin = new Padding(4, 5, 4, 5);
            panelHeaderInfo.Name = "panelHeaderInfo";
            panelHeaderInfo.Size = new Size(1384, 70);
            panelHeaderInfo.TabIndex = 0;
            // 
            // lblPageHeading
            // 
            lblPageHeading.AutoSize = true;
            lblPageHeading.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPageHeading.ForeColor = Color.FromArgb(15, 23, 42);
            lblPageHeading.Location = new Point(0, 0);
            lblPageHeading.Margin = new Padding(4, 0, 4, 0);
            lblPageHeading.Name = "lblPageHeading";
            lblPageHeading.Size = new Size(380, 45);
            lblPageHeading.TabIndex = 0;
            lblPageHeading.Text = "Administrator Overview";

            // 
            // lblPageSubHeading
            // 
            lblPageSubHeading.AutoSize = true;
            lblPageSubHeading.Font = new Font("Segoe UI", 9F);
            lblPageSubHeading.ForeColor = Color.FromArgb(100, 116, 139);
            lblPageSubHeading.Location = new Point(0, 48);
            lblPageSubHeading.Margin = new Padding(4, 0, 4, 0);
            lblPageSubHeading.Name = "lblPageSubHeading";
            lblPageSubHeading.Size = new Size(500, 25);
            lblPageSubHeading.TabIndex = 1;
            lblPageSubHeading.Text = "System Administrator Dashboard";
            lblPageSubHeading.Visible = false;

            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1771, 1106);
            Controls.Add(panelMain);
            Controls.Add(panelSidebar);
            Controls.Add(panelTopBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MinimumSize = new Size(1571, 1078);
            Name = "AdminDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bus Ticket Management - Admin Portal";
            panelTopBar.ResumeLayout(false);
            panelTopBar.PerformLayout();
            panelAdminProfile.ResumeLayout(false);
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            panelMain.ResumeLayout(false);
            panelTicketManagement.ResumeLayout(false);
            panelTicketActions.ResumeLayout(false);
            panelTicketsToolbar.ResumeLayout(false);
            panelTicketsToolbar.PerformLayout();
            flowTicketMetrics.ResumeLayout(false);
            cardTotalTickets.ResumeLayout(false);
            cardTotalTickets.PerformLayout();
            cardValidTickets.ResumeLayout(false);
            cardValidTickets.PerformLayout();
            cardBoardedTickets.ResumeLayout(false);
            cardBoardedTickets.PerformLayout();
            cardCancelledTickets.ResumeLayout(false);
            cardCancelledTickets.PerformLayout();
            cardTodayTickets.ResumeLayout(false);
            cardTodayTickets.PerformLayout();
            panelTicketsHeader.ResumeLayout(false);
            panelTicketsHeader.PerformLayout();
            panelBookingManagement.ResumeLayout(false);
            panelBookingActions.ResumeLayout(false);
            panelBookingsToolbar.ResumeLayout(false);
            panelBookingsToolbar.PerformLayout();
            flowBookingMetrics.ResumeLayout(false);
            cardTotalBookings.ResumeLayout(false);
            cardTotalBookings.PerformLayout();
            cardConfirmedBookings.ResumeLayout(false);
            cardConfirmedBookings.PerformLayout();
            cardPendingBookings.ResumeLayout(false);
            cardPendingBookings.PerformLayout();
            cardCancelledBookings.ResumeLayout(false);
            cardCancelledBookings.PerformLayout();
            cardTodayBookings.ResumeLayout(false);
            cardTodayBookings.PerformLayout();
            panelBookingsHeader.ResumeLayout(false);
            panelBookingsHeader.PerformLayout();
            panelRouteManagement.ResumeLayout(false);
            panelRouteActions.ResumeLayout(false);
            panelRoutesToolbar.ResumeLayout(false);
            panelRoutesToolbar.PerformLayout();
            flowRouteMetrics.ResumeLayout(false);
            cardTotalRoutes.ResumeLayout(false);
            cardTotalRoutes.PerformLayout();
            cardActiveRoutes.ResumeLayout(false);
            cardActiveRoutes.PerformLayout();
            cardInactiveRoutes.ResumeLayout(false);
            cardInactiveRoutes.PerformLayout();
            cardTotalDistance.ResumeLayout(false);
            cardTotalDistance.PerformLayout();
            panelRoutesHeader.ResumeLayout(false);
            panelRoutesHeader.PerformLayout();
            panelBusManagement.ResumeLayout(false);
            panelBusActions.ResumeLayout(false);
            panelBusesToolbar.ResumeLayout(false);
            panelBusesToolbar.PerformLayout();
            flowBusMetrics.ResumeLayout(false);
            cardTotalBuses.ResumeLayout(false);
            cardTotalBuses.PerformLayout();
            cardActiveBuses.ResumeLayout(false);
            cardActiveBuses.PerformLayout();
            cardMaintenanceBuses.ResumeLayout(false);
            cardMaintenanceBuses.PerformLayout();
            cardInactiveBuses.ResumeLayout(false);
            cardInactiveBuses.PerformLayout();
            panelBusesHeader.ResumeLayout(false);
            panelBusesHeader.PerformLayout();
            panelUserManagement.ResumeLayout(false);
            panelUserActions.ResumeLayout(false);
            panelUsersToolbar.ResumeLayout(false);
            panelUsersToolbar.PerformLayout();
            panelUsersHeader.ResumeLayout(false);
            panelUsersHeader.PerformLayout();
            flowDashboard.ResumeLayout(false);
            grpOverview.ResumeLayout(false);
            cardBuses.ResumeLayout(false);
            cardBuses.PerformLayout();
            cardTrips.ResumeLayout(false);
            cardTrips.PerformLayout();
            cardBookings.ResumeLayout(false);
            cardBookings.PerformLayout();
            cardRevenue.ResumeLayout(false);
            cardRevenue.PerformLayout();
            grpQuickActions.ResumeLayout(false);
            grpTripsSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTrips).EndInit();
            grpTicketVerify.ResumeLayout(false);
            grpTicketVerify.PerformLayout();
            panelHeaderInfo.ResumeLayout(false);
            panelHeaderInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }
}

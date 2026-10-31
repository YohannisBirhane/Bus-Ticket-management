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
        private Button btnNavStaff;
        private Button btnNavFares;
        private Button btnNavReports;
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
        private Button btnQuickUpdateFares;
        private Button btnQuickSalesReport;

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
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblAppIcon = new System.Windows.Forms.Label();
            this.lblPortalTitle = new System.Windows.Forms.Label();
            this.panelAdminProfile = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.lblAdminRole = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblNavHeader = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavUsers = new System.Windows.Forms.Button();
            this.btnNavBuses = new System.Windows.Forms.Button();
            this.btnNavRoutes = new System.Windows.Forms.Button();
            this.btnNavTrips = new System.Windows.Forms.Button();
            this.btnNavBookings = new System.Windows.Forms.Button();
            this.btnNavTickets = new System.Windows.Forms.Button();
            this.btnNavPayments = new System.Windows.Forms.Button();
            this.btnNavStaff = new System.Windows.Forms.Button();
            this.btnNavFares = new System.Windows.Forms.Button();
            this.btnNavReports = new System.Windows.Forms.Button();
            this.btnNavSettings = new System.Windows.Forms.Button();
            this.btnNavLogout = new System.Windows.Forms.Button();

            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeaderInfo = new System.Windows.Forms.Panel();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.lblPageSubHeading = new System.Windows.Forms.Label();
            this.flowDashboard = new System.Windows.Forms.FlowLayoutPanel();

            this.grpOverview = new System.Windows.Forms.GroupBox();
            this.cardBuses = new System.Windows.Forms.Panel();
            this.lblMetricBusesVal = new System.Windows.Forms.Label();
            this.lblMetricBusesTitle = new System.Windows.Forms.Label();
            this.cardTrips = new System.Windows.Forms.Panel();
            this.lblMetricTripsVal = new System.Windows.Forms.Label();
            this.lblMetricTripsTitle = new System.Windows.Forms.Label();
            this.cardBookings = new System.Windows.Forms.Panel();
            this.lblMetricBookingsVal = new System.Windows.Forms.Label();
            this.lblMetricBookingsTitle = new System.Windows.Forms.Label();
            this.cardRevenue = new System.Windows.Forms.Panel();
            this.lblMetricRevenueVal = new System.Windows.Forms.Label();
            this.lblMetricRevenueTitle = new System.Windows.Forms.Label();

            this.grpQuickActions = new System.Windows.Forms.GroupBox();
            this.btnQuickAddBus = new System.Windows.Forms.Button();
            this.btnQuickNewTrip = new System.Windows.Forms.Button();
            this.btnQuickUpdateFares = new System.Windows.Forms.Button();
            this.btnQuickSalesReport = new System.Windows.Forms.Button();

            this.grpTripsSchedule = new System.Windows.Forms.GroupBox();
            this.dgvTrips = new System.Windows.Forms.DataGridView();

            this.grpTicketVerify = new System.Windows.Forms.GroupBox();
            this.lblTicketSearchPrompt = new System.Windows.Forms.Label();
            this.txtTicketNumber = new Bus_Ticket_mgmt.ModernTextBox();
            this.btnVerifyTicket = new Bus_Ticket_mgmt.ModernButton();
            this.lblVerifyResult = new System.Windows.Forms.Label();

            // User Management components
            this.panelUserManagement = new System.Windows.Forms.Panel();
            this.panelUsersHeader = new System.Windows.Forms.Panel();
            this.lblUsersTitle = new System.Windows.Forms.Label();
            this.lblUsersSubtitle = new System.Windows.Forms.Label();
            this.panelUsersToolbar = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtSearchUser = new System.Windows.Forms.TextBox();
            this.cmbRoleFilter = new System.Windows.Forms.ComboBox();
            this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshUsers = new System.Windows.Forms.Button();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.colUserId = new System.Windows.Forms.ColumnHeader();
            this.colFullName = new System.Windows.Forms.ColumnHeader();
            this.colUsername = new System.Windows.Forms.ColumnHeader();
            this.colEmail = new System.Windows.Forms.ColumnHeader();
            this.colPhone = new System.Windows.Forms.ColumnHeader();
            this.colRole = new System.Windows.Forms.ColumnHeader();
            this.colStatus = new System.Windows.Forms.ColumnHeader();
            this.colCreatedDate = new System.Windows.Forms.ColumnHeader();
            this.panelUserActions = new System.Windows.Forms.Panel();
            this.btnViewUserDetails = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnToggleUserStatus = new System.Windows.Forms.Button();
            this.btnResetUserPassword = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.lblUserCount = new System.Windows.Forms.Label();

            // Bus Management components
            this.panelBusManagement = new System.Windows.Forms.Panel();
            this.panelBusesHeader = new System.Windows.Forms.Panel();
            this.lblBusesTitle = new System.Windows.Forms.Label();
            this.lblBusesSubtitle = new System.Windows.Forms.Label();
            this.btnAddBus = new System.Windows.Forms.Button();

            this.flowBusMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalBuses = new System.Windows.Forms.Panel();
            this.lblMetricTotalBusesVal = new System.Windows.Forms.Label();
            this.lblMetricTotalBusesTitle = new System.Windows.Forms.Label();
            this.lblMetricTotalBusesSub = new System.Windows.Forms.Label();

            this.cardActiveBuses = new System.Windows.Forms.Panel();
            this.lblMetricActiveBusesVal = new System.Windows.Forms.Label();
            this.lblMetricActiveBusesTitle = new System.Windows.Forms.Label();
            this.lblMetricActiveBusesSub = new System.Windows.Forms.Label();

            this.cardMaintenanceBuses = new System.Windows.Forms.Panel();
            this.lblMetricMaintBusesVal = new System.Windows.Forms.Label();
            this.lblMetricMaintBusesTitle = new System.Windows.Forms.Label();
            this.lblMetricMaintBusesSub = new System.Windows.Forms.Label();

            this.cardInactiveBuses = new System.Windows.Forms.Panel();
            this.lblMetricInactiveBusesVal = new System.Windows.Forms.Label();
            this.lblMetricInactiveBusesTitle = new System.Windows.Forms.Label();
            this.lblMetricInactiveBusesSub = new System.Windows.Forms.Label();

            this.panelBusesToolbar = new System.Windows.Forms.Panel();
            this.txtSearchBus = new System.Windows.Forms.TextBox();
            this.cmbBusTypeFilter = new System.Windows.Forms.ComboBox();
            this.cmbBusStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshBuses = new System.Windows.Forms.Button();

            this.lvBuses = new System.Windows.Forms.ListView();
            this.colBusId = new System.Windows.Forms.ColumnHeader();
            this.colPlateNumber = new System.Windows.Forms.ColumnHeader();
            this.colBusModel = new System.Windows.Forms.ColumnHeader();
            this.colBusType = new System.Windows.Forms.ColumnHeader();
            this.colCapacity = new System.Windows.Forms.ColumnHeader();
            this.colRegDate = new System.Windows.Forms.ColumnHeader();
            this.colBusStatus = new System.Windows.Forms.ColumnHeader();
            this.colAssignedTrip = new System.Windows.Forms.ColumnHeader();

            this.panelBusActions = new System.Windows.Forms.Panel();
            this.btnViewBusDetails = new System.Windows.Forms.Button();
            this.btnEditBus = new System.Windows.Forms.Button();
            this.btnChangeBusStatus = new System.Windows.Forms.Button();
            this.btnDeleteBus = new System.Windows.Forms.Button();
            this.lblBusCount = new System.Windows.Forms.Label();

            // Route Management components
            this.panelRouteManagement = new System.Windows.Forms.Panel();
            this.panelRoutesHeader = new System.Windows.Forms.Panel();
            this.lblRoutesTitle = new System.Windows.Forms.Label();
            this.lblRoutesSubtitle = new System.Windows.Forms.Label();
            this.btnAddRoute = new System.Windows.Forms.Button();

            this.flowRouteMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalRoutes = new System.Windows.Forms.Panel();
            this.lblMetricTotalRoutesVal = new System.Windows.Forms.Label();
            this.lblMetricTotalRoutesTitle = new System.Windows.Forms.Label();
            this.lblMetricTotalRoutesSub = new System.Windows.Forms.Label();

            this.cardActiveRoutes = new System.Windows.Forms.Panel();
            this.lblMetricActiveRoutesVal = new System.Windows.Forms.Label();
            this.lblMetricActiveRoutesTitle = new System.Windows.Forms.Label();
            this.lblMetricActiveRoutesSub = new System.Windows.Forms.Label();

            this.cardInactiveRoutes = new System.Windows.Forms.Panel();
            this.lblMetricInactiveRoutesVal = new System.Windows.Forms.Label();
            this.lblMetricInactiveRoutesTitle = new System.Windows.Forms.Label();
            this.lblMetricInactiveRoutesSub = new System.Windows.Forms.Label();

            this.cardTotalDistance = new System.Windows.Forms.Panel();
            this.lblMetricTotalDistanceVal = new System.Windows.Forms.Label();
            this.lblMetricTotalDistanceTitle = new System.Windows.Forms.Label();
            this.lblMetricTotalDistanceSub = new System.Windows.Forms.Label();

            this.panelRoutesToolbar = new System.Windows.Forms.Panel();
            this.txtSearchRoute = new System.Windows.Forms.TextBox();
            this.cmbRouteStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshRoutes = new System.Windows.Forms.Button();

            this.lvRoutes = new System.Windows.Forms.ListView();
            this.colRouteId = new System.Windows.Forms.ColumnHeader();
            this.colRouteName = new System.Windows.Forms.ColumnHeader();
            this.colSource = new System.Windows.Forms.ColumnHeader();
            this.colDestination = new System.Windows.Forms.ColumnHeader();
            this.colDistance = new System.Windows.Forms.ColumnHeader();
            this.colEstimatedTime = new System.Windows.Forms.ColumnHeader();
            this.colBaseFare = new System.Windows.Forms.ColumnHeader();
            this.colRouteStatus = new System.Windows.Forms.ColumnHeader();
            this.colIntermediateStops = new System.Windows.Forms.ColumnHeader();

            this.panelRouteActions = new System.Windows.Forms.Panel();
            this.btnViewRouteDetails = new System.Windows.Forms.Button();
            this.btnEditRoute = new System.Windows.Forms.Button();
            this.btnToggleRouteStatus = new System.Windows.Forms.Button();
            this.btnDeleteRoute = new System.Windows.Forms.Button();
            this.lblRouteCount = new System.Windows.Forms.Label();

            // Booking Management component instantiation
            this.panelBookingManagement = new System.Windows.Forms.Panel();
            this.panelBookingsHeader = new System.Windows.Forms.Panel();
            this.lblBookingsTitle = new System.Windows.Forms.Label();
            this.lblBookingsSubtitle = new System.Windows.Forms.Label();
            this.btnNewBooking = new System.Windows.Forms.Button();

            this.flowBookingMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalBookings = new System.Windows.Forms.Panel();
            this.lblMetricTotalBookingsVal = new System.Windows.Forms.Label();
            this.lblMetricTotalBookingsTitle = new System.Windows.Forms.Label();
            this.lblMetricTotalBookingsSub = new System.Windows.Forms.Label();

            this.cardConfirmedBookings = new System.Windows.Forms.Panel();
            this.lblMetricConfirmedBookingsVal = new System.Windows.Forms.Label();
            this.lblMetricConfirmedBookingsTitle = new System.Windows.Forms.Label();
            this.lblMetricConfirmedBookingsSub = new System.Windows.Forms.Label();

            this.cardPendingBookings = new System.Windows.Forms.Panel();
            this.lblMetricPendingBookingsVal = new System.Windows.Forms.Label();
            this.lblMetricPendingBookingsTitle = new System.Windows.Forms.Label();
            this.lblMetricPendingBookingsSub = new System.Windows.Forms.Label();

            this.cardCancelledBookings = new System.Windows.Forms.Panel();
            this.lblMetricCancelledBookingsVal = new System.Windows.Forms.Label();
            this.lblMetricCancelledBookingsTitle = new System.Windows.Forms.Label();
            this.lblMetricCancelledBookingsSub = new System.Windows.Forms.Label();

            this.cardTodayBookings = new System.Windows.Forms.Panel();
            this.lblMetricTodayBookingsVal = new System.Windows.Forms.Label();
            this.lblMetricTodayBookingsTitle = new System.Windows.Forms.Label();
            this.lblMetricTodayBookingsSub = new System.Windows.Forms.Label();

            this.panelBookingsToolbar = new System.Windows.Forms.Panel();
            this.txtSearchBooking = new System.Windows.Forms.TextBox();
            this.cmbBookingStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmbBookingRouteFilter = new System.Windows.Forms.ComboBox();
            this.chkEnableDateFilter = new System.Windows.Forms.CheckBox();
            this.dtpBookingFilterDate = new System.Windows.Forms.DateTimePicker();
            this.btnResetBookingFilters = new System.Windows.Forms.Button();

            this.lvBookings = new System.Windows.Forms.ListView();
            this.colBookingId = new System.Windows.Forms.ColumnHeader();
            this.colPassengerName = new System.Windows.Forms.ColumnHeader();
            this.colPassengerPhone = new System.Windows.Forms.ColumnHeader();
            this.colBookingRoute = new System.Windows.Forms.ColumnHeader();
            this.colTravelDate = new System.Windows.Forms.ColumnHeader();
            this.colDepartureTime = new System.Windows.Forms.ColumnHeader();
            this.colSeats = new System.Windows.Forms.ColumnHeader();
            this.colTotalAmount = new System.Windows.Forms.ColumnHeader();
            this.colBookingStatus = new System.Windows.Forms.ColumnHeader();
            this.colPaymentStatus = new System.Windows.Forms.ColumnHeader();

            this.panelBookingActions = new System.Windows.Forms.Panel();
            this.btnViewBookingDetails = new System.Windows.Forms.Button();
            this.btnModifyBooking = new System.Windows.Forms.Button();
            this.btnCancelBookingAction = new System.Windows.Forms.Button();
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.lblBookingCount = new System.Windows.Forms.Label();

            // Ticket Management component instantiation
            this.panelTicketManagement = new System.Windows.Forms.Panel();
            this.panelTicketsHeader = new System.Windows.Forms.Panel();
            this.lblTicketsTitle = new System.Windows.Forms.Label();
            this.lblTicketsSubtitle = new System.Windows.Forms.Label();
            this.btnNewTicket = new System.Windows.Forms.Button();
            this.btnVerifyBoardModal = new System.Windows.Forms.Button();

            this.flowTicketMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.cardTotalTickets = new System.Windows.Forms.Panel();
            this.lblMetricTotalTicketsVal = new System.Windows.Forms.Label();
            this.lblMetricTotalTicketsTitle = new System.Windows.Forms.Label();
            this.lblMetricTotalTicketsSub = new System.Windows.Forms.Label();

            this.cardValidTickets = new System.Windows.Forms.Panel();
            this.lblMetricValidTicketsVal = new System.Windows.Forms.Label();
            this.lblMetricValidTicketsTitle = new System.Windows.Forms.Label();
            this.lblMetricValidTicketsSub = new System.Windows.Forms.Label();

            this.cardBoardedTickets = new System.Windows.Forms.Panel();
            this.lblMetricBoardedTicketsVal = new System.Windows.Forms.Label();
            this.lblMetricBoardedTicketsTitle = new System.Windows.Forms.Label();
            this.lblMetricBoardedTicketsSub = new System.Windows.Forms.Label();

            this.cardCancelledTickets = new System.Windows.Forms.Panel();
            this.lblMetricCancelledTicketsVal = new System.Windows.Forms.Label();
            this.lblMetricCancelledTicketsTitle = new System.Windows.Forms.Label();
            this.lblMetricCancelledTicketsSub = new System.Windows.Forms.Label();

            this.cardTodayTickets = new System.Windows.Forms.Panel();
            this.lblMetricTodayTicketsVal = new System.Windows.Forms.Label();
            this.lblMetricTodayTicketsTitle = new System.Windows.Forms.Label();
            this.lblMetricTodayTicketsSub = new System.Windows.Forms.Label();

            this.panelTicketsToolbar = new System.Windows.Forms.Panel();
            this.txtSearchTicketFilter = new System.Windows.Forms.TextBox();
            this.cmbTicketStatusFilter = new System.Windows.Forms.ComboBox();
            this.cmbTicketRouteFilter = new System.Windows.Forms.ComboBox();
            this.chkEnableTicketDateFilter = new System.Windows.Forms.CheckBox();
            this.dtpTicketFilterDate = new System.Windows.Forms.DateTimePicker();
            this.btnResetTicketFilters = new System.Windows.Forms.Button();

            this.lvTickets = new System.Windows.Forms.ListView();
            this.colTicketId = new System.Windows.Forms.ColumnHeader();
            this.colTicketBookingRef = new System.Windows.Forms.ColumnHeader();
            this.colTicketPassenger = new System.Windows.Forms.ColumnHeader();
            this.colTicketPhone = new System.Windows.Forms.ColumnHeader();
            this.colTicketRoute = new System.Windows.Forms.ColumnHeader();
            this.colTicketDate = new System.Windows.Forms.ColumnHeader();
            this.colTicketTime = new System.Windows.Forms.ColumnHeader();
            this.colTicketSeat = new System.Windows.Forms.ColumnHeader();
            this.colTicketGate = new System.Windows.Forms.ColumnHeader();
            this.colTicketBus = new System.Windows.Forms.ColumnHeader();
            this.colTicketStatus = new System.Windows.Forms.ColumnHeader();

            this.panelTicketActions = new System.Windows.Forms.Panel();
            this.btnViewTicketDetails = new System.Windows.Forms.Button();
            this.btnVerifyAndBoard = new System.Windows.Forms.Button();
            this.btnPrintTicketPass = new System.Windows.Forms.Button();
            this.btnCancelTicketAction = new System.Windows.Forms.Button();
            this.lblTicketCount = new System.Windows.Forms.Label();

            this.panelTopBar.SuspendLayout();
            this.panelAdminProfile.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelTicketManagement.SuspendLayout();
            this.panelTicketsHeader.SuspendLayout();
            this.panelTicketsToolbar.SuspendLayout();
            this.panelTicketActions.SuspendLayout();
            this.panelHeaderInfo.SuspendLayout();
            this.flowDashboard.SuspendLayout();
            this.grpOverview.SuspendLayout();
            this.cardBuses.SuspendLayout();
            this.cardTrips.SuspendLayout();
            this.cardBookings.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.grpQuickActions.SuspendLayout();
            this.grpTripsSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.grpTicketVerify.SuspendLayout();

            this.panelUserManagement.SuspendLayout();
            this.panelUsersHeader.SuspendLayout();
            this.panelUsersToolbar.SuspendLayout();
            this.panelUserActions.SuspendLayout();

            this.panelBusManagement.SuspendLayout();
            this.panelBusesHeader.SuspendLayout();
            this.flowBusMetrics.SuspendLayout();
            this.cardTotalBuses.SuspendLayout();
            this.cardActiveBuses.SuspendLayout();
            this.cardMaintenanceBuses.SuspendLayout();
            this.cardInactiveBuses.SuspendLayout();
            this.panelBusesToolbar.SuspendLayout();
            this.panelBusActions.SuspendLayout();

            this.panelRouteManagement.SuspendLayout();
            this.panelRoutesHeader.SuspendLayout();
            this.flowRouteMetrics.SuspendLayout();
            this.cardTotalRoutes.SuspendLayout();
            this.cardActiveRoutes.SuspendLayout();
            this.cardInactiveRoutes.SuspendLayout();
            this.cardTotalDistance.SuspendLayout();
            this.panelRoutesToolbar.SuspendLayout();
            this.panelRouteActions.SuspendLayout();

            this.panelBookingManagement.SuspendLayout();
            this.panelBookingsHeader.SuspendLayout();
            this.flowBookingMetrics.SuspendLayout();
            this.cardTotalBookings.SuspendLayout();
            this.cardConfirmedBookings.SuspendLayout();
            this.cardPendingBookings.SuspendLayout();
            this.cardCancelledBookings.SuspendLayout();
            this.cardTodayBookings.SuspendLayout();
            this.panelBookingsToolbar.SuspendLayout();
            this.panelBookingActions.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelTopBar.Controls.Add(this.lblAppIcon);
            this.panelTopBar.Controls.Add(this.lblPortalTitle);
            this.panelTopBar.Controls.Add(this.panelAdminProfile);
            this.panelTopBar.Controls.Add(this.btnMinimize);
            this.panelTopBar.Controls.Add(this.btnMaximize);
            this.panelTopBar.Controls.Add(this.btnClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Height = 44;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1240, 44);
            this.panelTopBar.TabIndex = 0;

            // 
            // lblAppIcon
            // 
            this.lblAppIcon.Location = new System.Drawing.Point(14, 4);
            this.lblAppIcon.Name = "lblAppIcon";
            this.lblAppIcon.Size = new System.Drawing.Size(32, 36);
            this.lblAppIcon.TabIndex = 0;

            // 
            // lblPortalTitle
            // 
            this.lblPortalTitle.AutoSize = true;
            this.lblPortalTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPortalTitle.ForeColor = System.Drawing.Color.White;
            this.lblPortalTitle.Location = new System.Drawing.Point(52, 12);
            this.lblPortalTitle.Name = "lblPortalTitle";
            this.lblPortalTitle.Size = new System.Drawing.Size(320, 19);
            this.lblPortalTitle.TabIndex = 1;
            this.lblPortalTitle.Text = "Bus Ticket Management  |  Administrator Portal";

            // 
            // panelAdminProfile
            // 
            this.panelAdminProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAdminProfile.Controls.Add(this.lblAdminName);
            this.panelAdminProfile.Controls.Add(this.lblAdminRole);
            this.panelAdminProfile.Location = new System.Drawing.Point(890, 4);
            this.panelAdminProfile.Name = "panelAdminProfile";
            this.panelAdminProfile.Size = new System.Drawing.Size(200, 36);
            this.panelAdminProfile.TabIndex = 2;

            // 
            // lblAdminName
            // 
            this.lblAdminName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAdminName.ForeColor = System.Drawing.Color.White;
            this.lblAdminName.Location = new System.Drawing.Point(0, 2);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(190, 16);
            this.lblAdminName.Text = "System Administrator";
            this.lblAdminName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // lblAdminRole
            // 
            this.lblAdminRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAdminRole.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.lblAdminRole.Location = new System.Drawing.Point(0, 18);
            this.lblAdminRole.Name = "lblAdminRole";
            this.lblAdminRole.Size = new System.Drawing.Size(190, 14);
            this.lblAdminRole.Text = "Super Admin • Active";
            this.lblAdminRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnMinimize.Location = new System.Drawing.Point(1102, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 44);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;

            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnMaximize.Location = new System.Drawing.Point(1148, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(46, 44);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.Text = "□";
            this.btnMaximize.UseVisualStyleBackColor = true;

            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnClose.Location = new System.Drawing.Point(1194, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 44);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelSidebar.Controls.Add(this.btnNavLogout);
            this.panelSidebar.Controls.Add(this.btnNavSettings);
            this.panelSidebar.Controls.Add(this.btnNavReports);
            this.panelSidebar.Controls.Add(this.btnNavFares);
            this.panelSidebar.Controls.Add(this.btnNavStaff);
            this.panelSidebar.Controls.Add(this.btnNavPayments);
            this.panelSidebar.Controls.Add(this.btnNavTickets);
            this.panelSidebar.Controls.Add(this.btnNavBookings);
            this.panelSidebar.Controls.Add(this.btnNavTrips);
            this.panelSidebar.Controls.Add(this.btnNavRoutes);
            this.panelSidebar.Controls.Add(this.btnNavBuses);
            this.panelSidebar.Controls.Add(this.btnNavUsers);
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.lblNavHeader);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 44);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(230, 756);
            this.panelSidebar.TabIndex = 1;

            // 
            // lblNavHeader
            // 
            this.lblNavHeader.AutoSize = true;
            this.lblNavHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNavHeader.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblNavHeader.Location = new System.Drawing.Point(16, 16);
            this.lblNavHeader.Name = "lblNavHeader";
            this.lblNavHeader.Size = new System.Drawing.Size(122, 13);
            this.lblNavHeader.TabIndex = 0;
            this.lblNavHeader.Text = "MANAGEMENT MENU";

            // 
            // btnNavDashboard
            // 
            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(10, 40);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(210, 36);
            this.btnNavDashboard.TabIndex = 1;
            this.btnNavDashboard.Text = "📊  Dashboard";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavDashboard.UseVisualStyleBackColor = false;

            // 
            // btnNavUsers
            // 
            this.btnNavUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavUsers.Location = new System.Drawing.Point(10, 80);
            this.btnNavUsers.Name = "btnNavUsers";
            this.btnNavUsers.Size = new System.Drawing.Size(210, 34);
            this.btnNavUsers.TabIndex = 2;
            this.btnNavUsers.Text = "👥  User Management";
            this.btnNavUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavUsers.UseVisualStyleBackColor = true;

            // 
            // btnNavBuses
            // 
            this.btnNavBuses.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBuses.FlatAppearance.BorderSize = 0;
            this.btnNavBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBuses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBuses.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavBuses.Location = new System.Drawing.Point(10, 118);
            this.btnNavBuses.Name = "btnNavBuses";
            this.btnNavBuses.Size = new System.Drawing.Size(210, 34);
            this.btnNavBuses.TabIndex = 3;
            this.btnNavBuses.Text = "🚌  Bus Management";
            this.btnNavBuses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBuses.UseVisualStyleBackColor = true;

            // 
            // btnNavRoutes
            // 
            this.btnNavRoutes.BackColor = System.Drawing.Color.Transparent;
            this.btnNavRoutes.FlatAppearance.BorderSize = 0;
            this.btnNavRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRoutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavRoutes.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavRoutes.Location = new System.Drawing.Point(10, 156);
            this.btnNavRoutes.Name = "btnNavRoutes";
            this.btnNavRoutes.Size = new System.Drawing.Size(210, 34);
            this.btnNavRoutes.TabIndex = 4;
            this.btnNavRoutes.Text = "🗺️  Route Management";
            this.btnNavRoutes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavRoutes.UseVisualStyleBackColor = true;

            // 
            // btnNavTrips
            // 
            this.btnNavTrips.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTrips.FlatAppearance.BorderSize = 0;
            this.btnNavTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTrips.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavTrips.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavTrips.Location = new System.Drawing.Point(10, 194);
            this.btnNavTrips.Name = "btnNavTrips";
            this.btnNavTrips.Size = new System.Drawing.Size(210, 34);
            this.btnNavTrips.TabIndex = 5;
            this.btnNavTrips.Text = "📅  Trip & Schedules";
            this.btnNavTrips.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTrips.UseVisualStyleBackColor = true;

            // 
            // btnNavBookings
            // 
            this.btnNavBookings.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBookings.FlatAppearance.BorderSize = 0;
            this.btnNavBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBookings.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavBookings.Location = new System.Drawing.Point(10, 232);
            this.btnNavBookings.Name = "btnNavBookings";
            this.btnNavBookings.Size = new System.Drawing.Size(210, 34);
            this.btnNavBookings.TabIndex = 6;
            this.btnNavBookings.Text = "🎫  Booking Management";
            this.btnNavBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavBookings.UseVisualStyleBackColor = true;

            // 
            // btnNavTickets
            // 
            this.btnNavTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTickets.FlatAppearance.BorderSize = 0;
            this.btnNavTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavTickets.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavTickets.Location = new System.Drawing.Point(10, 270);
            this.btnNavTickets.Name = "btnNavTickets";
            this.btnNavTickets.Size = new System.Drawing.Size(210, 34);
            this.btnNavTickets.TabIndex = 7;
            this.btnNavTickets.Text = "🎟️  Ticket Management";
            this.btnNavTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavTickets.UseVisualStyleBackColor = true;

            // 
            // btnNavPayments
            // 
            this.btnNavPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnNavPayments.FlatAppearance.BorderSize = 0;
            this.btnNavPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavPayments.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavPayments.Location = new System.Drawing.Point(10, 308);
            this.btnNavPayments.Name = "btnNavPayments";
            this.btnNavPayments.Size = new System.Drawing.Size(210, 34);
            this.btnNavPayments.TabIndex = 8;
            this.btnNavPayments.Text = "💳  Payment Records";
            this.btnNavPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavPayments.UseVisualStyleBackColor = true;

            // 
            // btnNavStaff
            // 
            this.btnNavStaff.BackColor = System.Drawing.Color.Transparent;
            this.btnNavStaff.FlatAppearance.BorderSize = 0;
            this.btnNavStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavStaff.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavStaff.Location = new System.Drawing.Point(10, 346);
            this.btnNavStaff.Name = "btnNavStaff";
            this.btnNavStaff.Size = new System.Drawing.Size(210, 34);
            this.btnNavStaff.TabIndex = 9;
            this.btnNavStaff.Text = "👨‍✈️  Driver & Staff";
            this.btnNavStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavStaff.UseVisualStyleBackColor = true;

            // 
            // btnNavFares
            // 
            this.btnNavFares.BackColor = System.Drawing.Color.Transparent;
            this.btnNavFares.FlatAppearance.BorderSize = 0;
            this.btnNavFares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFares.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavFares.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavFares.Location = new System.Drawing.Point(10, 384);
            this.btnNavFares.Name = "btnNavFares";
            this.btnNavFares.Size = new System.Drawing.Size(210, 34);
            this.btnNavFares.TabIndex = 10;
            this.btnNavFares.Text = "🏷️  Fare Management";
            this.btnNavFares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavFares.UseVisualStyleBackColor = true;

            // 
            // btnNavReports
            // 
            this.btnNavReports.BackColor = System.Drawing.Color.Transparent;
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavReports.Location = new System.Drawing.Point(10, 422);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(210, 34);
            this.btnNavReports.TabIndex = 11;
            this.btnNavReports.Text = "📈  Sales Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.UseVisualStyleBackColor = true;

            // 
            // btnNavSettings
            // 
            this.btnNavSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnNavSettings.FlatAppearance.BorderSize = 0;
            this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavSettings.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavSettings.Location = new System.Drawing.Point(10, 460);
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.Size = new System.Drawing.Size(210, 34);
            this.btnNavSettings.TabIndex = 12;
            this.btnNavSettings.Text = "⚙️  System Settings";
            this.btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSettings.UseVisualStyleBackColor = true;

            // 
            // btnNavLogout
            // 
            this.btnNavLogout.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnNavLogout.FlatAppearance.BorderSize = 0;
            this.btnNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavLogout.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnNavLogout.Location = new System.Drawing.Point(10, 546);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(210, 36);
            this.btnNavLogout.TabIndex = 14;
            this.btnNavLogout.Text = "🚪  Sign Out";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.UseVisualStyleBackColor = false;

            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelMain.Controls.Add(this.panelTicketManagement);
            this.panelMain.Controls.Add(this.panelBookingManagement);
            this.panelMain.Controls.Add(this.panelRouteManagement);
            this.panelMain.Controls.Add(this.panelBusManagement);
            this.panelMain.Controls.Add(this.panelUserManagement);
            this.panelMain.Controls.Add(this.flowDashboard);
            this.panelMain.Controls.Add(this.panelHeaderInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(230, 44);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20);
            this.panelMain.Size = new System.Drawing.Size(1010, 756);
            this.panelMain.TabIndex = 2;

            // 
            // panelHeaderInfo
            // 
            this.panelHeaderInfo.Controls.Add(this.lblPageHeading);
            this.panelHeaderInfo.Controls.Add(this.lblPageSubHeading);
            this.panelHeaderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderInfo.Height = 42;
            this.panelHeaderInfo.Location = new System.Drawing.Point(20, 20);
            this.panelHeaderInfo.Name = "panelHeaderInfo";
            this.panelHeaderInfo.Size = new System.Drawing.Size(970, 42);
            this.panelHeaderInfo.TabIndex = 0;

            // 
            // lblPageHeading
            // 
            this.lblPageHeading.AutoSize = true;
            this.lblPageHeading.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPageHeading.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPageHeading.Location = new System.Drawing.Point(0, 0);
            this.lblPageHeading.Name = "lblPageHeading";
            this.lblPageHeading.Size = new System.Drawing.Size(252, 30);
            this.lblPageHeading.TabIndex = 0;
            this.lblPageHeading.Text = "Administrator Overview";

            // 
            // lblPageSubHeading
            // 
            this.lblPageSubHeading.AutoSize = true;
            this.lblPageSubHeading.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPageSubHeading.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPageSubHeading.Location = new System.Drawing.Point(0, 32);
            this.lblPageSubHeading.Name = "lblPageSubHeading";
            this.lblPageSubHeading.Size = new System.Drawing.Size(465, 17);
            this.lblPageSubHeading.TabIndex = 1;
            this.lblPageSubHeading.Text = "Central operational hub for managing buses, routes, schedules, fares, and reports.";
            this.lblPageSubHeading.Visible = false;

            // 
            // flowDashboard
            // 
            this.flowDashboard.AutoScroll = true;
            this.flowDashboard.Controls.Add(this.grpOverview);
            this.flowDashboard.Controls.Add(this.grpQuickActions);
            this.flowDashboard.Controls.Add(this.grpTripsSchedule);
            this.flowDashboard.Controls.Add(this.grpTicketVerify);
            this.flowDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDashboard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowDashboard.Location = new System.Drawing.Point(20, 80);
            this.flowDashboard.Name = "flowDashboard";
            this.flowDashboard.Size = new System.Drawing.Size(970, 656);
            this.flowDashboard.TabIndex = 1;
            this.flowDashboard.WrapContents = false;

            // 
            // grpOverview
            // 
            this.grpOverview.BackColor = System.Drawing.Color.White;
            this.grpOverview.Controls.Add(this.cardBuses);
            this.grpOverview.Controls.Add(this.cardTrips);
            this.grpOverview.Controls.Add(this.cardBookings);
            this.grpOverview.Controls.Add(this.cardRevenue);
            this.grpOverview.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpOverview.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpOverview.Location = new System.Drawing.Point(3, 3);
            this.grpOverview.Name = "grpOverview";
            this.grpOverview.Size = new System.Drawing.Size(940, 126);
            this.grpOverview.TabIndex = 0;
            this.grpOverview.TabStop = false;
            this.grpOverview.Text = "  📊 System Metrics & Summaries  ";

            // 
            // cardBuses
            // 
            this.cardBuses.BackColor = System.Drawing.Color.FromArgb(239, 246, 255);
            this.cardBuses.Controls.Add(this.lblMetricBusesVal);
            this.cardBuses.Controls.Add(this.lblMetricBusesTitle);
            this.cardBuses.Location = new System.Drawing.Point(18, 30);
            this.cardBuses.Name = "cardBuses";
            this.cardBuses.Size = new System.Drawing.Size(210, 78);
            this.cardBuses.TabIndex = 0;

            // 
            // lblMetricBusesVal
            // 
            this.lblMetricBusesVal.AutoSize = true;
            this.lblMetricBusesVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricBusesVal.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblMetricBusesVal.Location = new System.Drawing.Point(12, 10);
            this.lblMetricBusesVal.Name = "lblMetricBusesVal";
            this.lblMetricBusesVal.Size = new System.Drawing.Size(108, 32);
            this.lblMetricBusesVal.TabIndex = 0;
            this.lblMetricBusesVal.Text = "48 Buses";

            // 
            // lblMetricBusesTitle
            // 
            this.lblMetricBusesTitle.AutoSize = true;
            this.lblMetricBusesTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricBusesTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMetricBusesTitle.Location = new System.Drawing.Point(14, 46);
            this.lblMetricBusesTitle.Name = "lblMetricBusesTitle";
            this.lblMetricBusesTitle.Size = new System.Drawing.Size(129, 15);
            this.lblMetricBusesTitle.TabIndex = 1;
            this.lblMetricBusesTitle.Text = "Active Fleet in Operation";

            // 
            // cardTrips
            // 
            this.cardTrips.BackColor = System.Drawing.Color.FromArgb(240, 253, 244);
            this.cardTrips.Controls.Add(this.lblMetricTripsVal);
            this.cardTrips.Controls.Add(this.lblMetricTripsTitle);
            this.cardTrips.Location = new System.Drawing.Point(246, 30);
            this.cardTrips.Name = "cardTrips";
            this.cardTrips.Size = new System.Drawing.Size(210, 78);
            this.cardTrips.TabIndex = 1;

            // 
            // lblMetricTripsVal
            // 
            this.lblMetricTripsVal.AutoSize = true;
            this.lblMetricTripsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTripsVal.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblMetricTripsVal.Location = new System.Drawing.Point(12, 10);
            this.lblMetricTripsVal.Name = "lblMetricTripsVal";
            this.lblMetricTripsVal.Size = new System.Drawing.Size(107, 32);
            this.lblMetricTripsVal.TabIndex = 0;
            this.lblMetricTripsVal.Text = "124 Trips";

            // 
            // lblMetricTripsTitle
            // 
            this.lblMetricTripsTitle.AutoSize = true;
            this.lblMetricTripsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTripsTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMetricTripsTitle.Location = new System.Drawing.Point(14, 46);
            this.lblMetricTripsTitle.Name = "lblMetricTripsTitle";
            this.lblMetricTripsTitle.Size = new System.Drawing.Size(131, 15);
            this.lblMetricTripsTitle.TabIndex = 1;
            this.lblMetricTripsTitle.Text = "Scheduled Trips Today";

            // 
            // cardBookings
            // 
            this.cardBookings.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.cardBookings.Controls.Add(this.lblMetricBookingsVal);
            this.cardBookings.Controls.Add(this.lblMetricBookingsTitle);
            this.cardBookings.Location = new System.Drawing.Point(474, 30);
            this.cardBookings.Name = "cardBookings";
            this.cardBookings.Size = new System.Drawing.Size(210, 78);
            this.cardBookings.TabIndex = 2;

            // 
            // lblMetricBookingsVal
            // 
            this.lblMetricBookingsVal.AutoSize = true;
            this.lblMetricBookingsVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricBookingsVal.ForeColor = System.Drawing.Color.FromArgb(225, 29, 72);
            this.lblMetricBookingsVal.Location = new System.Drawing.Point(12, 10);
            this.lblMetricBookingsVal.Name = "lblMetricBookingsVal";
            this.lblMetricBookingsVal.Size = new System.Drawing.Size(155, 32);
            this.lblMetricBookingsVal.TabIndex = 0;
            this.lblMetricBookingsVal.Text = "1,842 Tickets";

            // 
            // lblMetricBookingsTitle
            // 
            this.lblMetricBookingsTitle.AutoSize = true;
            this.lblMetricBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMetricBookingsTitle.Location = new System.Drawing.Point(14, 46);
            this.lblMetricBookingsTitle.Name = "lblMetricBookingsTitle";
            this.lblMetricBookingsTitle.Size = new System.Drawing.Size(126, 15);
            this.lblMetricBookingsTitle.TabIndex = 1;
            this.lblMetricBookingsTitle.Text = "Passenger Bookings";

            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.FromArgb(254, 249, 195);
            this.cardRevenue.Controls.Add(this.lblMetricRevenueVal);
            this.cardRevenue.Controls.Add(this.lblMetricRevenueTitle);
            this.cardRevenue.Location = new System.Drawing.Point(702, 30);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Size = new System.Drawing.Size(220, 78);
            this.cardRevenue.TabIndex = 3;

            // 
            // lblMetricRevenueVal
            // 
            this.lblMetricRevenueVal.AutoSize = true;
            this.lblMetricRevenueVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricRevenueVal.ForeColor = System.Drawing.Color.FromArgb(161, 98, 7);
            this.lblMetricRevenueVal.Location = new System.Drawing.Point(8, 12);
            this.lblMetricRevenueVal.Name = "lblMetricRevenueVal";
            this.lblMetricRevenueVal.Size = new System.Drawing.Size(175, 30);
            this.lblMetricRevenueVal.TabIndex = 0;
            this.lblMetricRevenueVal.Text = "486,500.00 ETB";

            // 
            // lblMetricRevenueTitle
            // 
            this.lblMetricRevenueTitle.AutoSize = true;
            this.lblMetricRevenueTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricRevenueTitle.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblMetricRevenueTitle.Location = new System.Drawing.Point(10, 46);
            this.lblMetricRevenueTitle.Name = "lblMetricRevenueTitle";
            this.lblMetricRevenueTitle.Size = new System.Drawing.Size(130, 15);
            this.lblMetricRevenueTitle.TabIndex = 1;
            this.lblMetricRevenueTitle.Text = "Total Daily Ticket Sales";

            // 
            // grpQuickActions
            // 
            this.grpQuickActions.BackColor = System.Drawing.Color.White;
            this.grpQuickActions.Controls.Add(this.btnQuickAddBus);
            this.grpQuickActions.Controls.Add(this.btnQuickNewTrip);
            this.grpQuickActions.Controls.Add(this.btnQuickUpdateFares);
            this.grpQuickActions.Controls.Add(this.btnQuickSalesReport);
            this.grpQuickActions.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpQuickActions.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpQuickActions.Location = new System.Drawing.Point(3, 135);
            this.grpQuickActions.Name = "grpQuickActions";
            this.grpQuickActions.Size = new System.Drawing.Size(940, 84);
            this.grpQuickActions.TabIndex = 1;
            this.grpQuickActions.TabStop = false;
            this.grpQuickActions.Text = "  ⚡ Administrator Quick Actions  ";

            // 
            // btnQuickAddBus
            // 
            this.btnQuickAddBus.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnQuickAddBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickAddBus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuickAddBus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnQuickAddBus.Location = new System.Drawing.Point(20, 30);
            this.btnQuickAddBus.Name = "btnQuickAddBus";
            this.btnQuickAddBus.Size = new System.Drawing.Size(210, 38);
            this.btnQuickAddBus.TabIndex = 0;
            this.btnQuickAddBus.Text = "➕  Add New Bus";
            this.btnQuickAddBus.UseVisualStyleBackColor = false;

            // 
            // btnQuickNewTrip
            // 
            this.btnQuickNewTrip.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnQuickNewTrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickNewTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickNewTrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuickNewTrip.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnQuickNewTrip.Location = new System.Drawing.Point(250, 30);
            this.btnQuickNewTrip.Name = "btnQuickNewTrip";
            this.btnQuickNewTrip.Size = new System.Drawing.Size(210, 38);
            this.btnQuickNewTrip.TabIndex = 1;
            this.btnQuickNewTrip.Text = "📅  Schedule Trip";
            this.btnQuickNewTrip.UseVisualStyleBackColor = false;

            // 
            // btnQuickUpdateFares
            // 
            this.btnQuickUpdateFares.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnQuickUpdateFares.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickUpdateFares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickUpdateFares.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuickUpdateFares.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnQuickUpdateFares.Location = new System.Drawing.Point(480, 30);
            this.btnQuickUpdateFares.Name = "btnQuickUpdateFares";
            this.btnQuickUpdateFares.Size = new System.Drawing.Size(210, 38);
            this.btnQuickUpdateFares.TabIndex = 2;
            this.btnQuickUpdateFares.Text = "🏷️  Set Ticket Fares";
            this.btnQuickUpdateFares.UseVisualStyleBackColor = false;

            // 
            // btnQuickSalesReport
            // 
            this.btnQuickSalesReport.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnQuickSalesReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickSalesReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickSalesReport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuickSalesReport.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnQuickSalesReport.Location = new System.Drawing.Point(710, 30);
            this.btnQuickSalesReport.Name = "btnQuickSalesReport";
            this.btnQuickSalesReport.Size = new System.Drawing.Size(210, 38);
            this.btnQuickSalesReport.TabIndex = 3;
            this.btnQuickSalesReport.Text = "📈  Generate Report";
            this.btnQuickSalesReport.UseVisualStyleBackColor = false;

            // 
            // grpTripsSchedule
            // 
            this.grpTripsSchedule.BackColor = System.Drawing.Color.White;
            this.grpTripsSchedule.Controls.Add(this.dgvTrips);
            this.grpTripsSchedule.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTripsSchedule.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpTripsSchedule.Location = new System.Drawing.Point(3, 225);
            this.grpTripsSchedule.Name = "grpTripsSchedule";
            this.grpTripsSchedule.Size = new System.Drawing.Size(940, 240);
            this.grpTripsSchedule.TabIndex = 2;
            this.grpTripsSchedule.TabStop = false;
            this.grpTripsSchedule.Text = "  🚌 Today\'s Fleet Trips & Active Schedule Status  ";

            // 
            // dgvTrips
            // 
            this.dgvTrips.AllowUserToAddRows = false;
            this.dgvTrips.AllowUserToDeleteRows = false;
            this.dgvTrips.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrips.ColumnHeadersHeight = 34;
            this.dgvTrips.Location = new System.Drawing.Point(18, 28);
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.ReadOnly = true;
            this.dgvTrips.RowHeadersVisible = false;
            this.dgvTrips.RowTemplate.Height = 32;
            this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrips.Size = new System.Drawing.Size(904, 196);
            this.dgvTrips.TabIndex = 0;

            // 
            // grpTicketVerify
            // 
            this.grpTicketVerify.BackColor = System.Drawing.Color.White;
            this.grpTicketVerify.Controls.Add(this.lblTicketSearchPrompt);
            this.grpTicketVerify.Controls.Add(this.txtTicketNumber);
            this.grpTicketVerify.Controls.Add(this.btnVerifyTicket);
            this.grpTicketVerify.Controls.Add(this.lblVerifyResult);
            this.grpTicketVerify.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTicketVerify.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpTicketVerify.Location = new System.Drawing.Point(3, 471);
            this.grpTicketVerify.Name = "grpTicketVerify";
            this.grpTicketVerify.Size = new System.Drawing.Size(940, 110);
            this.grpTicketVerify.TabIndex = 3;
            this.grpTicketVerify.TabStop = false;
            this.grpTicketVerify.Text = "  🎟️ Ticket Search & Information Verification  ";

            // 
            // lblTicketSearchPrompt
            // 
            this.lblTicketSearchPrompt.AutoSize = true;
            this.lblTicketSearchPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketSearchPrompt.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblTicketSearchPrompt.Location = new System.Drawing.Point(18, 30);
            this.lblTicketSearchPrompt.Name = "lblTicketSearchPrompt";
            this.lblTicketSearchPrompt.Size = new System.Drawing.Size(206, 15);
            this.lblTicketSearchPrompt.TabIndex = 0;
            this.lblTicketSearchPrompt.Text = "Enter Passenger Ticket / Booking Ref:";

            // 
            // txtTicketNumber
            // 
            this.txtTicketNumber.BackColor = System.Drawing.Color.White;
            this.txtTicketNumber.Location = new System.Drawing.Point(18, 52);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(320, 42);
            this.txtTicketNumber.TabIndex = 1;

            // 
            // btnVerifyTicket
            // 
            this.btnVerifyTicket.FlatAppearance.BorderSize = 0;
            this.btnVerifyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyTicket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyTicket.ForeColor = System.Drawing.Color.White;
            this.btnVerifyTicket.Location = new System.Drawing.Point(354, 52);
            this.btnVerifyTicket.Name = "btnVerifyTicket";
            this.btnVerifyTicket.Size = new System.Drawing.Size(150, 42);
            this.btnVerifyTicket.TabIndex = 2;
            this.btnVerifyTicket.Text = "Verify Ticket";
            this.btnVerifyTicket.UseVisualStyleBackColor = true;

            // 
            // lblVerifyResult
            // 
            this.lblVerifyResult.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblVerifyResult.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblVerifyResult.Location = new System.Drawing.Point(520, 52);
            this.lblVerifyResult.Name = "lblVerifyResult";
            this.lblVerifyResult.Size = new System.Drawing.Size(400, 42);
            this.lblVerifyResult.TabIndex = 3;
            this.lblVerifyResult.Text = "Ready to verify passenger tickets.";
            this.lblVerifyResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // panelUserManagement
            // 
            this.panelUserManagement.Controls.Add(this.lvUsers);
            this.panelUserManagement.Controls.Add(this.panelUserActions);
            this.panelUserManagement.Controls.Add(this.panelUsersToolbar);
            this.panelUserManagement.Controls.Add(this.panelUsersHeader);
            this.panelUserManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserManagement.Location = new System.Drawing.Point(20, 80);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(970, 656);
            this.panelUserManagement.TabIndex = 3;
            this.panelUserManagement.Visible = false;

            // 
            // panelUsersHeader
            // 
            this.panelUsersHeader.Controls.Add(this.lblUsersTitle);
            this.panelUsersHeader.Controls.Add(this.lblUsersSubtitle);
            this.panelUsersHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersHeader.Height = 42;
            this.panelUsersHeader.Location = new System.Drawing.Point(0, 0);
            this.panelUsersHeader.Name = "panelUsersHeader";
            this.panelUsersHeader.Size = new System.Drawing.Size(970, 42);
            this.panelUsersHeader.TabIndex = 0;

            // 
            // lblUsersTitle
            // 
            this.lblUsersTitle.AutoSize = true;
            this.lblUsersTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsersTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblUsersTitle.Location = new System.Drawing.Point(0, 0);
            this.lblUsersTitle.Name = "lblUsersTitle";
            this.lblUsersTitle.Size = new System.Drawing.Size(206, 30);
            this.lblUsersTitle.TabIndex = 0;
            this.lblUsersTitle.Text = "User Management";

            // 
            // lblUsersSubtitle
            // 
            this.lblUsersSubtitle.AutoSize = true;
            this.lblUsersSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsersSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblUsersSubtitle.Location = new System.Drawing.Point(0, 30);
            this.lblUsersSubtitle.Name = "lblUsersSubtitle";
            this.lblUsersSubtitle.Size = new System.Drawing.Size(395, 17);
            this.lblUsersSubtitle.TabIndex = 1;
            this.lblUsersSubtitle.Text = "Manage system users, roles, account status, and access permissions.";
            this.lblUsersSubtitle.Visible = false;

            // 
            // panelUsersToolbar
            // 
            this.panelUsersToolbar.Controls.Add(this.btnAddUser);
            this.panelUsersToolbar.Controls.Add(this.txtSearchUser);
            this.panelUsersToolbar.Controls.Add(this.cmbRoleFilter);
            this.panelUsersToolbar.Controls.Add(this.cmbStatusFilter);
            this.panelUsersToolbar.Controls.Add(this.btnRefreshUsers);
            this.panelUsersToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUsersToolbar.Height = 52;
            this.panelUsersToolbar.Location = new System.Drawing.Point(0, 42);
            this.panelUsersToolbar.Name = "panelUsersToolbar";
            this.panelUsersToolbar.Size = new System.Drawing.Size(970, 52);
            this.panelUsersToolbar.TabIndex = 1;

            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(0, 8);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(120, 36);
            this.btnAddUser.TabIndex = 0;
            this.btnAddUser.Text = "➕  Add User";
            this.btnAddUser.UseVisualStyleBackColor = false;

            // 
            // txtSearchUser
            // 
            this.txtSearchUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchUser.Location = new System.Drawing.Point(135, 13);
            this.txtSearchUser.Name = "txtSearchUser";
            this.txtSearchUser.Size = new System.Drawing.Size(260, 25);
            this.txtSearchUser.TabIndex = 1;

            // 
            // cmbRoleFilter
            // 
            this.cmbRoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoleFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRoleFilter.FormattingEnabled = true;
            this.cmbRoleFilter.Items.AddRange(new object[] {
            "All Roles",
            "Administrator",
            "Passenger",
            "Ticket Officer",
            "Driver",
            "Bus Manager"});
            this.cmbRoleFilter.Location = new System.Drawing.Point(410, 13);
            this.cmbRoleFilter.Name = "cmbRoleFilter";
            this.cmbRoleFilter.Size = new System.Drawing.Size(145, 25);
            this.cmbRoleFilter.TabIndex = 2;

            // 
            // cmbStatusFilter
            // 
            this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatusFilter.FormattingEnabled = true;
            this.cmbStatusFilter.Items.AddRange(new object[] {
            "All Statuses",
            "Active",
            "Inactive"});
            this.cmbStatusFilter.Location = new System.Drawing.Point(565, 13);
            this.cmbStatusFilter.Name = "cmbStatusFilter";
            this.cmbStatusFilter.Size = new System.Drawing.Size(125, 25);
            this.cmbStatusFilter.TabIndex = 3;

            // 
            // btnRefreshUsers
            // 
            this.btnRefreshUsers.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnRefreshUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRefreshUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshUsers.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRefreshUsers.Location = new System.Drawing.Point(702, 10);
            this.btnRefreshUsers.Name = "btnRefreshUsers";
            this.btnRefreshUsers.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshUsers.TabIndex = 4;
            this.btnRefreshUsers.Text = "🔄  Refresh";
            this.btnRefreshUsers.UseVisualStyleBackColor = false;

            // 
            // lvUsers
            // 
            this.lvUsers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colUserId,
            this.colFullName,
            this.colUsername,
            this.colEmail,
            this.colPhone,
            this.colRole,
            this.colStatus,
            this.colCreatedDate});
            this.lvUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvUsers.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.GridLines = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(0, 106);
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(970, 498);
            this.lvUsers.TabIndex = 2;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;

            // 
            // colUserId
            // 
            this.colUserId.Text = "User ID";
            this.colUserId.Width = 90;

            // 
            // colFullName
            // 
            this.colFullName.Text = "Full Name";
            this.colFullName.Width = 160;

            // 
            // colUsername
            // 
            this.colUsername.Text = "Username";
            this.colUsername.Width = 120;

            // 
            // colEmail
            // 
            this.colEmail.Text = "Email Address";
            this.colEmail.Width = 180;

            // 
            // colPhone
            // 
            this.colPhone.Text = "Phone Number";
            this.colPhone.Width = 130;

            // 
            // colRole
            // 
            this.colRole.Text = "Role";
            this.colRole.Width = 130;

            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.Width = 90;

            // 
            // colCreatedDate
            // 
            this.colCreatedDate.Text = "Created Date";
            this.colCreatedDate.Width = 130;

            // 
            // panelUserActions
            // 
            this.panelUserActions.Controls.Add(this.btnViewUserDetails);
            this.panelUserActions.Controls.Add(this.btnEditUser);
            this.panelUserActions.Controls.Add(this.btnToggleUserStatus);
            this.panelUserActions.Controls.Add(this.btnResetUserPassword);
            this.panelUserActions.Controls.Add(this.btnDeleteUser);
            this.panelUserActions.Controls.Add(this.lblUserCount);
            this.panelUserActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUserActions.Height = 52;
            this.panelUserActions.Location = new System.Drawing.Point(0, 604);
            this.panelUserActions.Name = "panelUserActions";
            this.panelUserActions.Size = new System.Drawing.Size(970, 52);
            this.panelUserActions.TabIndex = 3;

            // 
            // btnViewUserDetails
            // 
            this.btnViewUserDetails.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnViewUserDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnViewUserDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewUserDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewUserDetails.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnViewUserDetails.Location = new System.Drawing.Point(0, 10);
            this.btnViewUserDetails.Name = "btnViewUserDetails";
            this.btnViewUserDetails.Size = new System.Drawing.Size(115, 34);
            this.btnViewUserDetails.TabIndex = 0;
            this.btnViewUserDetails.Text = "👁️  View Details";
            this.btnViewUserDetails.UseVisualStyleBackColor = false;

            // 
            // btnEditUser
            // 
            this.btnEditUser.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnEditUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditUser.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnEditUser.Location = new System.Drawing.Point(125, 10);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(105, 34);
            this.btnEditUser.TabIndex = 1;
            this.btnEditUser.Text = "✏️  Edit User";
            this.btnEditUser.UseVisualStyleBackColor = false;

            // 
            // btnToggleUserStatus
            // 
            this.btnToggleUserStatus.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnToggleUserStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnToggleUserStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleUserStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggleUserStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnToggleUserStatus.Location = new System.Drawing.Point(240, 10);
            this.btnToggleUserStatus.Name = "btnToggleUserStatus";
            this.btnToggleUserStatus.Size = new System.Drawing.Size(165, 34);
            this.btnToggleUserStatus.TabIndex = 2;
            this.btnToggleUserStatus.Text = "🔄  Activate / Deactivate";
            this.btnToggleUserStatus.UseVisualStyleBackColor = false;

            // 
            // btnResetUserPassword
            // 
            this.btnResetUserPassword.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnResetUserPassword.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnResetUserPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetUserPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetUserPassword.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnResetUserPassword.Location = new System.Drawing.Point(415, 10);
            this.btnResetUserPassword.Name = "btnResetUserPassword";
            this.btnResetUserPassword.Size = new System.Drawing.Size(140, 34);
            this.btnResetUserPassword.TabIndex = 3;
            this.btnResetUserPassword.Text = "🔑  Reset Password";
            this.btnResetUserPassword.UseVisualStyleBackColor = false;

            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDeleteUser.Location = new System.Drawing.Point(565, 10);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(115, 34);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "🗑️  Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;

            // 
            // lblUserCount
            // 
            this.lblUserCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUserCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblUserCount.Location = new System.Drawing.Point(740, 16);
            this.lblUserCount.Name = "lblUserCount";
            this.lblUserCount.Size = new System.Drawing.Size(220, 20);
            this.lblUserCount.TabIndex = 5;
            this.lblUserCount.Text = "Showing 7 accounts";
            this.lblUserCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // panelBusManagement
            // 
            this.panelBusManagement.Controls.Add(this.lvBuses);
            this.panelBusManagement.Controls.Add(this.panelBusActions);
            this.panelBusManagement.Controls.Add(this.panelBusesToolbar);
            this.panelBusManagement.Controls.Add(this.flowBusMetrics);
            this.panelBusManagement.Controls.Add(this.panelBusesHeader);
            this.panelBusManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBusManagement.Location = new System.Drawing.Point(20, 80);
            this.panelBusManagement.Name = "panelBusManagement";
            this.panelBusManagement.Size = new System.Drawing.Size(970, 656);
            this.panelBusManagement.TabIndex = 4;
            this.panelBusManagement.Visible = false;

            // 
            // panelBusesHeader
            // 
            this.panelBusesHeader.Controls.Add(this.btnAddBus);
            this.panelBusesHeader.Controls.Add(this.lblBusesTitle);
            this.panelBusesHeader.Controls.Add(this.lblBusesSubtitle);
            this.panelBusesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusesHeader.Height = 42;
            this.panelBusesHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBusesHeader.Name = "panelBusesHeader";
            this.panelBusesHeader.Size = new System.Drawing.Size(970, 42);
            this.panelBusesHeader.TabIndex = 0;

            // 
            // lblBusesTitle
            // 
            this.lblBusesTitle.AutoSize = true;
            this.lblBusesTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBusesTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblBusesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblBusesTitle.Name = "lblBusesTitle";
            this.lblBusesTitle.Size = new System.Drawing.Size(199, 30);
            this.lblBusesTitle.TabIndex = 0;
            this.lblBusesTitle.Text = "Bus Management";

            // 
            // lblBusesSubtitle
            // 
            this.lblBusesSubtitle.AutoSize = true;
            this.lblBusesSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBusesSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBusesSubtitle.Location = new System.Drawing.Point(0, 30);
            this.lblBusesSubtitle.Name = "lblBusesSubtitle";
            this.lblBusesSubtitle.Size = new System.Drawing.Size(430, 17);
            this.lblBusesSubtitle.TabIndex = 1;
            this.lblBusesSubtitle.Text = "Manage vehicle fleet inventory, seating capacities, and service statuses.";
            this.lblBusesSubtitle.Visible = false;

            // 
            // btnAddBus
            // 
            this.btnAddBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBus.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnAddBus.FlatAppearance.BorderSize = 0;
            this.btnAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBus.ForeColor = System.Drawing.Color.White;
            this.btnAddBus.Location = new System.Drawing.Point(825, 4);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(145, 36);
            this.btnAddBus.TabIndex = 2;
            this.btnAddBus.Text = "➕  Add New Bus";
            this.btnAddBus.UseVisualStyleBackColor = false;

            // 
            // flowBusMetrics
            // 
            this.flowBusMetrics.Controls.Add(this.cardTotalBuses);
            this.flowBusMetrics.Controls.Add(this.cardActiveBuses);
            this.flowBusMetrics.Controls.Add(this.cardMaintenanceBuses);
            this.flowBusMetrics.Controls.Add(this.cardInactiveBuses);
            this.flowBusMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowBusMetrics.Height = 72;
            this.flowBusMetrics.Location = new System.Drawing.Point(0, 42);
            this.flowBusMetrics.Name = "flowBusMetrics";
            this.flowBusMetrics.Size = new System.Drawing.Size(970, 72);
            this.flowBusMetrics.TabIndex = 1;

            // 
            // cardTotalBuses
            // 
            this.cardTotalBuses.BackColor = System.Drawing.Color.White;
            this.cardTotalBuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalBuses.Controls.Add(this.lblMetricTotalBusesVal);
            this.cardTotalBuses.Controls.Add(this.lblMetricTotalBusesTitle);
            this.cardTotalBuses.Controls.Add(this.lblMetricTotalBusesSub);
            this.cardTotalBuses.Location = new System.Drawing.Point(0, 5);
            this.cardTotalBuses.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardTotalBuses.Name = "cardTotalBuses";
            this.cardTotalBuses.Size = new System.Drawing.Size(225, 60);
            this.cardTotalBuses.TabIndex = 0;

            // 
            // lblMetricTotalBusesVal
            // 
            this.lblMetricTotalBusesVal.AutoSize = true;
            this.lblMetricTotalBusesVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalBusesVal.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblMetricTotalBusesVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricTotalBusesVal.Name = "lblMetricTotalBusesVal";
            this.lblMetricTotalBusesVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricTotalBusesVal.TabIndex = 0;
            this.lblMetricTotalBusesVal.Text = "8";

            // 
            // lblMetricTotalBusesTitle
            // 
            this.lblMetricTotalBusesTitle.AutoSize = true;
            this.lblMetricTotalBusesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalBusesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricTotalBusesTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricTotalBusesTitle.Name = "lblMetricTotalBusesTitle";
            this.lblMetricTotalBusesTitle.Size = new System.Drawing.Size(68, 15);
            this.lblMetricTotalBusesTitle.TabIndex = 1;
            this.lblMetricTotalBusesTitle.Text = "Total Buses";

            // 
            // lblMetricTotalBusesSub
            // 
            this.lblMetricTotalBusesSub.AutoSize = true;
            this.lblMetricTotalBusesSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalBusesSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTotalBusesSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricTotalBusesSub.Name = "lblMetricTotalBusesSub";
            this.lblMetricTotalBusesSub.Size = new System.Drawing.Size(107, 13);
            this.lblMetricTotalBusesSub.TabIndex = 2;
            this.lblMetricTotalBusesSub.Text = "All registered buses";
            this.lblMetricTotalBusesSub.Visible = false;

            // 
            // cardActiveBuses
            // 
            this.cardActiveBuses.BackColor = System.Drawing.Color.White;
            this.cardActiveBuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardActiveBuses.Controls.Add(this.lblMetricActiveBusesVal);
            this.cardActiveBuses.Controls.Add(this.lblMetricActiveBusesTitle);
            this.cardActiveBuses.Controls.Add(this.lblMetricActiveBusesSub);
            this.cardActiveBuses.Location = new System.Drawing.Point(237, 5);
            this.cardActiveBuses.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardActiveBuses.Name = "cardActiveBuses";
            this.cardActiveBuses.Size = new System.Drawing.Size(225, 60);
            this.cardActiveBuses.TabIndex = 1;

            // 
            // lblMetricActiveBusesVal
            // 
            this.lblMetricActiveBusesVal.AutoSize = true;
            this.lblMetricActiveBusesVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricActiveBusesVal.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblMetricActiveBusesVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricActiveBusesVal.Name = "lblMetricActiveBusesVal";
            this.lblMetricActiveBusesVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricActiveBusesVal.TabIndex = 0;
            this.lblMetricActiveBusesVal.Text = "6";

            // 
            // lblMetricActiveBusesTitle
            // 
            this.lblMetricActiveBusesTitle.AutoSize = true;
            this.lblMetricActiveBusesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricActiveBusesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricActiveBusesTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricActiveBusesTitle.Name = "lblMetricActiveBusesTitle";
            this.lblMetricActiveBusesTitle.Size = new System.Drawing.Size(73, 15);
            this.lblMetricActiveBusesTitle.TabIndex = 1;
            this.lblMetricActiveBusesTitle.Text = "Active Buses";

            // 
            // lblMetricActiveBusesSub
            // 
            this.lblMetricActiveBusesSub.AutoSize = true;
            this.lblMetricActiveBusesSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricActiveBusesSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricActiveBusesSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricActiveBusesSub.Name = "lblMetricActiveBusesSub";
            this.lblMetricActiveBusesSub.Size = new System.Drawing.Size(126, 13);
            this.lblMetricActiveBusesSub.TabIndex = 2;
            this.lblMetricActiveBusesSub.Text = "Available for operations";
            this.lblMetricActiveBusesSub.Visible = false;

            // 
            // cardMaintenanceBuses
            // 
            this.cardMaintenanceBuses.BackColor = System.Drawing.Color.White;
            this.cardMaintenanceBuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardMaintenanceBuses.Controls.Add(this.lblMetricMaintBusesVal);
            this.cardMaintenanceBuses.Controls.Add(this.lblMetricMaintBusesTitle);
            this.cardMaintenanceBuses.Controls.Add(this.lblMetricMaintBusesSub);
            this.cardMaintenanceBuses.Location = new System.Drawing.Point(474, 5);
            this.cardMaintenanceBuses.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardMaintenanceBuses.Name = "cardMaintenanceBuses";
            this.cardMaintenanceBuses.Size = new System.Drawing.Size(225, 60);
            this.cardMaintenanceBuses.TabIndex = 2;

            // 
            // lblMetricMaintBusesVal
            // 
            this.lblMetricMaintBusesVal.AutoSize = true;
            this.lblMetricMaintBusesVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricMaintBusesVal.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.lblMetricMaintBusesVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricMaintBusesVal.Name = "lblMetricMaintBusesVal";
            this.lblMetricMaintBusesVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricMaintBusesVal.TabIndex = 0;
            this.lblMetricMaintBusesVal.Text = "1";

            // 
            // lblMetricMaintBusesTitle
            // 
            this.lblMetricMaintBusesTitle.AutoSize = true;
            this.lblMetricMaintBusesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricMaintBusesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricMaintBusesTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricMaintBusesTitle.Name = "lblMetricMaintBusesTitle";
            this.lblMetricMaintBusesTitle.Size = new System.Drawing.Size(81, 15);
            this.lblMetricMaintBusesTitle.TabIndex = 1;
            this.lblMetricMaintBusesTitle.Text = "Maintenance";

            // 
            // lblMetricMaintBusesSub
            // 
            this.lblMetricMaintBusesSub.AutoSize = true;
            this.lblMetricMaintBusesSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricMaintBusesSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricMaintBusesSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricMaintBusesSub.Name = "lblMetricMaintBusesSub";
            this.lblMetricMaintBusesSub.Size = new System.Drawing.Size(107, 13);
            this.lblMetricMaintBusesSub.TabIndex = 2;
            this.lblMetricMaintBusesSub.Text = "Under maintenance";
            this.lblMetricMaintBusesSub.Visible = false;

            // 
            // cardInactiveBuses
            // 
            this.cardInactiveBuses.BackColor = System.Drawing.Color.White;
            this.cardInactiveBuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardInactiveBuses.Controls.Add(this.lblMetricInactiveBusesVal);
            this.cardInactiveBuses.Controls.Add(this.lblMetricInactiveBusesTitle);
            this.cardInactiveBuses.Controls.Add(this.lblMetricInactiveBusesSub);
            this.cardInactiveBuses.Location = new System.Drawing.Point(711, 5);
            this.cardInactiveBuses.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cardInactiveBuses.Name = "cardInactiveBuses";
            this.cardInactiveBuses.Size = new System.Drawing.Size(225, 60);
            this.cardInactiveBuses.TabIndex = 3;

            // 
            // lblMetricInactiveBusesVal
            // 
            this.lblMetricInactiveBusesVal.AutoSize = true;
            this.lblMetricInactiveBusesVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricInactiveBusesVal.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblMetricInactiveBusesVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricInactiveBusesVal.Name = "lblMetricInactiveBusesVal";
            this.lblMetricInactiveBusesVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricInactiveBusesVal.TabIndex = 0;
            this.lblMetricInactiveBusesVal.Text = "1";

            // 
            // lblMetricInactiveBusesTitle
            // 
            this.lblMetricInactiveBusesTitle.AutoSize = true;
            this.lblMetricInactiveBusesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricInactiveBusesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricInactiveBusesTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricInactiveBusesTitle.Name = "lblMetricInactiveBusesTitle";
            this.lblMetricInactiveBusesTitle.Size = new System.Drawing.Size(81, 15);
            this.lblMetricInactiveBusesTitle.TabIndex = 1;
            this.lblMetricInactiveBusesTitle.Text = "Inactive Buses";

            // 
            // lblMetricInactiveBusesSub
            // 
            this.lblMetricInactiveBusesSub.AutoSize = true;
            this.lblMetricInactiveBusesSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricInactiveBusesSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricInactiveBusesSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricInactiveBusesSub.Name = "lblMetricInactiveBusesSub";
            this.lblMetricInactiveBusesSub.Size = new System.Drawing.Size(80, 13);
            this.lblMetricInactiveBusesSub.TabIndex = 2;
            this.lblMetricInactiveBusesSub.Text = "Not in service";
            this.lblMetricInactiveBusesSub.Visible = false;

            // 
            // panelBusesToolbar
            // 
            this.panelBusesToolbar.Controls.Add(this.txtSearchBus);
            this.panelBusesToolbar.Controls.Add(this.cmbBusTypeFilter);
            this.panelBusesToolbar.Controls.Add(this.cmbBusStatusFilter);
            this.panelBusesToolbar.Controls.Add(this.btnRefreshBuses);
            this.panelBusesToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBusesToolbar.Height = 50;
            this.panelBusesToolbar.Location = new System.Drawing.Point(0, 139);
            this.panelBusesToolbar.Name = "panelBusesToolbar";
            this.panelBusesToolbar.Size = new System.Drawing.Size(970, 50);
            this.panelBusesToolbar.TabIndex = 2;

            // 
            // txtSearchBus
            // 
            this.txtSearchBus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchBus.Location = new System.Drawing.Point(0, 12);
            this.txtSearchBus.Name = "txtSearchBus";
            this.txtSearchBus.Size = new System.Drawing.Size(320, 25);
            this.txtSearchBus.TabIndex = 0;

            // 
            // cmbBusTypeFilter
            // 
            this.cmbBusTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusTypeFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBusTypeFilter.FormattingEnabled = true;
            this.cmbBusTypeFilter.Items.AddRange(new object[] {
            "All Bus Types",
            "Luxury",
            "Standard",
            "Semi-Luxury",
            "Mini-Bus"});
            this.cmbBusTypeFilter.Location = new System.Drawing.Point(335, 12);
            this.cmbBusTypeFilter.Name = "cmbBusTypeFilter";
            this.cmbBusTypeFilter.Size = new System.Drawing.Size(150, 25);
            this.cmbBusTypeFilter.TabIndex = 1;

            // 
            // cmbBusStatusFilter
            // 
            this.cmbBusStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBusStatusFilter.FormattingEnabled = true;
            this.cmbBusStatusFilter.Items.AddRange(new object[] {
            "All Statuses",
            "Active",
            "Maintenance",
            "Inactive"});
            this.cmbBusStatusFilter.Location = new System.Drawing.Point(495, 12);
            this.cmbBusStatusFilter.Name = "cmbBusStatusFilter";
            this.cmbBusStatusFilter.Size = new System.Drawing.Size(145, 25);
            this.cmbBusStatusFilter.TabIndex = 2;

            // 
            // btnRefreshBuses
            // 
            this.btnRefreshBuses.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnRefreshBuses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRefreshBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshBuses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshBuses.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRefreshBuses.Location = new System.Drawing.Point(650, 9);
            this.btnRefreshBuses.Name = "btnRefreshBuses";
            this.btnRefreshBuses.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshBuses.TabIndex = 3;
            this.btnRefreshBuses.Text = "🔄  Refresh";
            this.btnRefreshBuses.UseVisualStyleBackColor = false;

            // 
            // lvBuses
            // 
            this.lvBuses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBuses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBusId,
            this.colPlateNumber,
            this.colBusModel,
            this.colBusType,
            this.colCapacity,
            this.colRegDate,
            this.colBusStatus,
            this.colAssignedTrip});
            this.lvBuses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBuses.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvBuses.FullRowSelect = true;
            this.lvBuses.GridLines = true;
            this.lvBuses.HideSelection = false;
            this.lvBuses.Location = new System.Drawing.Point(0, 189);
            this.lvBuses.MultiSelect = false;
            this.lvBuses.Name = "lvBuses";
            this.lvBuses.Size = new System.Drawing.Size(970, 415);
            this.lvBuses.TabIndex = 3;
            this.lvBuses.UseCompatibleStateImageBehavior = false;
            this.lvBuses.View = System.Windows.Forms.View.Details;

            // 
            // colBusId
            // 
            this.colBusId.Text = "Bus ID";
            this.colBusId.Width = 90;

            // 
            // colPlateNumber
            // 
            this.colPlateNumber.Text = "Plate Number";
            this.colPlateNumber.Width = 130;

            // 
            // colBusModel
            // 
            this.colBusModel.Text = "Bus Name / Model";
            this.colBusModel.Width = 170;

            // 
            // colBusType
            // 
            this.colBusType.Text = "Bus Type";
            this.colBusType.Width = 110;

            // 
            // colCapacity
            // 
            this.colCapacity.Text = "Capacity";
            this.colCapacity.Width = 80;

            // 
            // colRegDate
            // 
            this.colRegDate.Text = "Registration Date";
            this.colRegDate.Width = 120;

            // 
            // colBusStatus
            // 
            this.colBusStatus.Text = "Status";
            this.colBusStatus.Width = 100;

            // 
            // colAssignedTrip
            // 
            this.colAssignedTrip.Text = "Assigned Trip";
            this.colAssignedTrip.Width = 230;

            // 
            // panelBusActions
            // 
            this.panelBusActions.Controls.Add(this.btnViewBusDetails);
            this.panelBusActions.Controls.Add(this.btnEditBus);
            this.panelBusActions.Controls.Add(this.btnChangeBusStatus);
            this.panelBusActions.Controls.Add(this.btnDeleteBus);
            this.panelBusActions.Controls.Add(this.lblBusCount);
            this.panelBusActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBusActions.Height = 52;
            this.panelBusActions.Location = new System.Drawing.Point(0, 604);
            this.panelBusActions.Name = "panelBusActions";
            this.panelBusActions.Size = new System.Drawing.Size(970, 52);
            this.panelBusActions.TabIndex = 4;

            // 
            // btnViewBusDetails
            // 
            this.btnViewBusDetails.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnViewBusDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnViewBusDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBusDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewBusDetails.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnViewBusDetails.Location = new System.Drawing.Point(0, 10);
            this.btnViewBusDetails.Name = "btnViewBusDetails";
            this.btnViewBusDetails.Size = new System.Drawing.Size(125, 34);
            this.btnViewBusDetails.TabIndex = 0;
            this.btnViewBusDetails.Text = "👁️  View Details";
            this.btnViewBusDetails.UseVisualStyleBackColor = false;

            // 
            // btnEditBus
            // 
            this.btnEditBus.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnEditBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnEditBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditBus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnEditBus.Location = new System.Drawing.Point(135, 10);
            this.btnEditBus.Name = "btnEditBus";
            this.btnEditBus.Size = new System.Drawing.Size(110, 34);
            this.btnEditBus.TabIndex = 1;
            this.btnEditBus.Text = "✏️  Edit Bus";
            this.btnEditBus.UseVisualStyleBackColor = false;

            // 
            // btnChangeBusStatus
            // 
            this.btnChangeBusStatus.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnChangeBusStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnChangeBusStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeBusStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangeBusStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnChangeBusStatus.Location = new System.Drawing.Point(255, 10);
            this.btnChangeBusStatus.Name = "btnChangeBusStatus";
            this.btnChangeBusStatus.Size = new System.Drawing.Size(155, 34);
            this.btnChangeBusStatus.TabIndex = 2;
            this.btnChangeBusStatus.Text = "🔄  Change Status";
            this.btnChangeBusStatus.UseVisualStyleBackColor = false;

            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnDeleteBus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnDeleteBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteBus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteBus.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDeleteBus.Location = new System.Drawing.Point(420, 10);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(120, 34);
            this.btnDeleteBus.TabIndex = 3;
            this.btnDeleteBus.Text = "🗑️  Delete Bus";
            this.btnDeleteBus.UseVisualStyleBackColor = false;

            // 
            // lblBusCount
            // 
            this.lblBusCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBusCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBusCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBusCount.Location = new System.Drawing.Point(740, 16);
            this.lblBusCount.Name = "lblBusCount";
            this.lblBusCount.Size = new System.Drawing.Size(220, 20);
            this.lblBusCount.TabIndex = 4;
            this.lblBusCount.Text = "Showing 8 buses";
            this.lblBusCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // panelRouteManagement
            // 
            this.panelRouteManagement.Controls.Add(this.lvRoutes);
            this.panelRouteManagement.Controls.Add(this.panelRouteActions);
            this.panelRouteManagement.Controls.Add(this.panelRoutesToolbar);
            this.panelRouteManagement.Controls.Add(this.flowRouteMetrics);
            this.panelRouteManagement.Controls.Add(this.panelRoutesHeader);
            this.panelRouteManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRouteManagement.Location = new System.Drawing.Point(20, 80);
            this.panelRouteManagement.Name = "panelRouteManagement";
            this.panelRouteManagement.Size = new System.Drawing.Size(970, 656);
            this.panelRouteManagement.TabIndex = 5;
            this.panelRouteManagement.Visible = false;

            // 
            // panelRoutesHeader
            // 
            this.panelRoutesHeader.Controls.Add(this.btnAddRoute);
            this.panelRoutesHeader.Controls.Add(this.lblRoutesTitle);
            this.panelRoutesHeader.Controls.Add(this.lblRoutesSubtitle);
            this.panelRoutesHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoutesHeader.Height = 42;
            this.panelRoutesHeader.Location = new System.Drawing.Point(0, 0);
            this.panelRoutesHeader.Name = "panelRoutesHeader";
            this.panelRoutesHeader.Size = new System.Drawing.Size(970, 42);
            this.panelRoutesHeader.TabIndex = 0;

            // 
            // lblRoutesTitle
            // 
            this.lblRoutesTitle.AutoSize = true;
            this.lblRoutesTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoutesTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblRoutesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblRoutesTitle.Name = "lblRoutesTitle";
            this.lblRoutesTitle.Size = new System.Drawing.Size(220, 30);
            this.lblRoutesTitle.TabIndex = 0;
            this.lblRoutesTitle.Text = "Route Management";

            // 
            // lblRoutesSubtitle
            // 
            this.lblRoutesSubtitle.AutoSize = true;
            this.lblRoutesSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoutesSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRoutesSubtitle.Location = new System.Drawing.Point(0, 30);
            this.lblRoutesSubtitle.Name = "lblRoutesSubtitle";
            this.lblRoutesSubtitle.Size = new System.Drawing.Size(430, 17);
            this.lblRoutesSubtitle.TabIndex = 1;
            this.lblRoutesSubtitle.Text = "Manage intercity routes, distances, estimated travel durations, and intermediate stops.";
            this.lblRoutesSubtitle.Visible = false;

            // 
            // btnAddRoute
            // 
            this.btnAddRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRoute.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnAddRoute.FlatAppearance.BorderSize = 0;
            this.btnAddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRoute.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddRoute.ForeColor = System.Drawing.Color.White;
            this.btnAddRoute.Location = new System.Drawing.Point(815, 4);
            this.btnAddRoute.Name = "btnAddRoute";
            this.btnAddRoute.Size = new System.Drawing.Size(155, 36);
            this.btnAddRoute.TabIndex = 2;
            this.btnAddRoute.Text = "➕  Add New Route";
            this.btnAddRoute.UseVisualStyleBackColor = false;

            // 
            // flowRouteMetrics
            // 
            this.flowRouteMetrics.Controls.Add(this.cardTotalRoutes);
            this.flowRouteMetrics.Controls.Add(this.cardActiveRoutes);
            this.flowRouteMetrics.Controls.Add(this.cardInactiveRoutes);
            this.flowRouteMetrics.Controls.Add(this.cardTotalDistance);
            this.flowRouteMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowRouteMetrics.Height = 72;
            this.flowRouteMetrics.Location = new System.Drawing.Point(0, 42);
            this.flowRouteMetrics.Name = "flowRouteMetrics";
            this.flowRouteMetrics.Size = new System.Drawing.Size(970, 72);
            this.flowRouteMetrics.TabIndex = 1;

            // 
            // cardTotalRoutes
            // 
            this.cardTotalRoutes.BackColor = System.Drawing.Color.White;
            this.cardTotalRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalRoutes.Controls.Add(this.lblMetricTotalRoutesVal);
            this.cardTotalRoutes.Controls.Add(this.lblMetricTotalRoutesTitle);
            this.cardTotalRoutes.Controls.Add(this.lblMetricTotalRoutesSub);
            this.cardTotalRoutes.Location = new System.Drawing.Point(0, 5);
            this.cardTotalRoutes.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardTotalRoutes.Name = "cardTotalRoutes";
            this.cardTotalRoutes.Size = new System.Drawing.Size(225, 60);
            this.cardTotalRoutes.TabIndex = 0;

            // 
            // lblMetricTotalRoutesVal
            // 
            this.lblMetricTotalRoutesVal.AutoSize = true;
            this.lblMetricTotalRoutesVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalRoutesVal.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblMetricTotalRoutesVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricTotalRoutesVal.Name = "lblMetricTotalRoutesVal";
            this.lblMetricTotalRoutesVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricTotalRoutesVal.TabIndex = 0;
            this.lblMetricTotalRoutesVal.Text = "8";

            // 
            // lblMetricTotalRoutesTitle
            // 
            this.lblMetricTotalRoutesTitle.AutoSize = true;
            this.lblMetricTotalRoutesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalRoutesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricTotalRoutesTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricTotalRoutesTitle.Name = "lblMetricTotalRoutesTitle";
            this.lblMetricTotalRoutesTitle.Size = new System.Drawing.Size(75, 15);
            this.lblMetricTotalRoutesTitle.TabIndex = 1;
            this.lblMetricTotalRoutesTitle.Text = "Total Routes";

            // 
            // lblMetricTotalRoutesSub
            // 
            this.lblMetricTotalRoutesSub.AutoSize = true;
            this.lblMetricTotalRoutesSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalRoutesSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTotalRoutesSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricTotalRoutesSub.Name = "lblMetricTotalRoutesSub";
            this.lblMetricTotalRoutesSub.Size = new System.Drawing.Size(110, 13);
            this.lblMetricTotalRoutesSub.TabIndex = 2;
            this.lblMetricTotalRoutesSub.Text = "All registered routes";
            this.lblMetricTotalRoutesSub.Visible = false;

            // 
            // cardActiveRoutes
            // 
            this.cardActiveRoutes.BackColor = System.Drawing.Color.White;
            this.cardActiveRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardActiveRoutes.Controls.Add(this.lblMetricActiveRoutesVal);
            this.cardActiveRoutes.Controls.Add(this.lblMetricActiveRoutesTitle);
            this.cardActiveRoutes.Controls.Add(this.lblMetricActiveRoutesSub);
            this.cardActiveRoutes.Location = new System.Drawing.Point(237, 5);
            this.cardActiveRoutes.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardActiveRoutes.Name = "cardActiveRoutes";
            this.cardActiveRoutes.Size = new System.Drawing.Size(225, 60);
            this.cardActiveRoutes.TabIndex = 1;

            // 
            // lblMetricActiveRoutesVal
            // 
            this.lblMetricActiveRoutesVal.AutoSize = true;
            this.lblMetricActiveRoutesVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricActiveRoutesVal.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblMetricActiveRoutesVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricActiveRoutesVal.Name = "lblMetricActiveRoutesVal";
            this.lblMetricActiveRoutesVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricActiveRoutesVal.TabIndex = 0;
            this.lblMetricActiveRoutesVal.Text = "7";

            // 
            // lblMetricActiveRoutesTitle
            // 
            this.lblMetricActiveRoutesTitle.AutoSize = true;
            this.lblMetricActiveRoutesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricActiveRoutesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricActiveRoutesTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricActiveRoutesTitle.Name = "lblMetricActiveRoutesTitle";
            this.lblMetricActiveRoutesTitle.Size = new System.Drawing.Size(80, 15);
            this.lblMetricActiveRoutesTitle.TabIndex = 1;
            this.lblMetricActiveRoutesTitle.Text = "Active Routes";

            // 
            // lblMetricActiveRoutesSub
            // 
            this.lblMetricActiveRoutesSub.AutoSize = true;
            this.lblMetricActiveRoutesSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricActiveRoutesSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricActiveRoutesSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricActiveRoutesSub.Name = "lblMetricActiveRoutesSub";
            this.lblMetricActiveRoutesSub.Size = new System.Drawing.Size(126, 13);
            this.lblMetricActiveRoutesSub.TabIndex = 2;
            this.lblMetricActiveRoutesSub.Text = "Available for scheduling";
            this.lblMetricActiveRoutesSub.Visible = false;

            // 
            // cardInactiveRoutes
            // 
            this.cardInactiveRoutes.BackColor = System.Drawing.Color.White;
            this.cardInactiveRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardInactiveRoutes.Controls.Add(this.lblMetricInactiveRoutesVal);
            this.cardInactiveRoutes.Controls.Add(this.lblMetricInactiveRoutesTitle);
            this.cardInactiveRoutes.Controls.Add(this.lblMetricInactiveRoutesSub);
            this.cardInactiveRoutes.Location = new System.Drawing.Point(474, 5);
            this.cardInactiveRoutes.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardInactiveRoutes.Name = "cardInactiveRoutes";
            this.cardInactiveRoutes.Size = new System.Drawing.Size(225, 60);
            this.cardInactiveRoutes.TabIndex = 2;

            // 
            // lblMetricInactiveRoutesVal
            // 
            this.lblMetricInactiveRoutesVal.AutoSize = true;
            this.lblMetricInactiveRoutesVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricInactiveRoutesVal.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblMetricInactiveRoutesVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricInactiveRoutesVal.Name = "lblMetricInactiveRoutesVal";
            this.lblMetricInactiveRoutesVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricInactiveRoutesVal.TabIndex = 0;
            this.lblMetricInactiveRoutesVal.Text = "1";

            // 
            // lblMetricInactiveRoutesTitle
            // 
            this.lblMetricInactiveRoutesTitle.AutoSize = true;
            this.lblMetricInactiveRoutesTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricInactiveRoutesTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricInactiveRoutesTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricInactiveRoutesTitle.Name = "lblMetricInactiveRoutesTitle";
            this.lblMetricInactiveRoutesTitle.Size = new System.Drawing.Size(88, 15);
            this.lblMetricInactiveRoutesTitle.TabIndex = 1;
            this.lblMetricInactiveRoutesTitle.Text = "Inactive Routes";

            // 
            // lblMetricInactiveRoutesSub
            // 
            this.lblMetricInactiveRoutesSub.AutoSize = true;
            this.lblMetricInactiveRoutesSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricInactiveRoutesSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricInactiveRoutesSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricInactiveRoutesSub.Name = "lblMetricInactiveRoutesSub";
            this.lblMetricInactiveRoutesSub.Size = new System.Drawing.Size(126, 13);
            this.lblMetricInactiveRoutesSub.TabIndex = 2;
            this.lblMetricInactiveRoutesSub.Text = "Not available for trips";
            this.lblMetricInactiveRoutesSub.Visible = false;

            // 
            // cardTotalDistance
            // 
            this.cardTotalDistance.BackColor = System.Drawing.Color.White;
            this.cardTotalDistance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalDistance.Controls.Add(this.lblMetricTotalDistanceVal);
            this.cardTotalDistance.Controls.Add(this.lblMetricTotalDistanceTitle);
            this.cardTotalDistance.Controls.Add(this.lblMetricTotalDistanceSub);
            this.cardTotalDistance.Location = new System.Drawing.Point(711, 5);
            this.cardTotalDistance.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cardTotalDistance.Name = "cardTotalDistance";
            this.cardTotalDistance.Size = new System.Drawing.Size(225, 60);
            this.cardTotalDistance.TabIndex = 3;

            // 
            // lblMetricTotalDistanceVal
            // 
            this.lblMetricTotalDistanceVal.AutoSize = true;
            this.lblMetricTotalDistanceVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalDistanceVal.ForeColor = System.Drawing.Color.FromArgb(14, 165, 233);
            this.lblMetricTotalDistanceVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricTotalDistanceVal.Name = "lblMetricTotalDistanceVal";
            this.lblMetricTotalDistanceVal.Size = new System.Drawing.Size(107, 30);
            this.lblMetricTotalDistanceVal.TabIndex = 0;
            this.lblMetricTotalDistanceVal.Text = "3,485 km";

            // 
            // lblMetricTotalDistanceTitle
            // 
            this.lblMetricTotalDistanceTitle.AutoSize = true;
            this.lblMetricTotalDistanceTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalDistanceTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricTotalDistanceTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricTotalDistanceTitle.Name = "lblMetricTotalDistanceTitle";
            this.lblMetricTotalDistanceTitle.Size = new System.Drawing.Size(83, 15);
            this.lblMetricTotalDistanceTitle.TabIndex = 1;
            this.lblMetricTotalDistanceTitle.Text = "Total Distance";

            // 
            // lblMetricTotalDistanceSub
            // 
            this.lblMetricTotalDistanceSub.AutoSize = true;
            this.lblMetricTotalDistanceSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalDistanceSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTotalDistanceSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricTotalDistanceSub.Name = "lblMetricTotalDistanceSub";
            this.lblMetricTotalDistanceSub.Size = new System.Drawing.Size(117, 13);
            this.lblMetricTotalDistanceSub.TabIndex = 2;
            this.lblMetricTotalDistanceSub.Text = "Aggregate route network";
            this.lblMetricTotalDistanceSub.Visible = false;

            // 
            // panelRoutesToolbar
            // 
            this.panelRoutesToolbar.Controls.Add(this.txtSearchRoute);
            this.panelRoutesToolbar.Controls.Add(this.cmbRouteStatusFilter);
            this.panelRoutesToolbar.Controls.Add(this.btnRefreshRoutes);
            this.panelRoutesToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRoutesToolbar.Height = 50;
            this.panelRoutesToolbar.Location = new System.Drawing.Point(0, 139);
            this.panelRoutesToolbar.Name = "panelRoutesToolbar";
            this.panelRoutesToolbar.Size = new System.Drawing.Size(970, 50);
            this.panelRoutesToolbar.TabIndex = 2;

            // 
            // txtSearchRoute
            // 
            this.txtSearchRoute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchRoute.Location = new System.Drawing.Point(0, 12);
            this.txtSearchRoute.Name = "txtSearchRoute";
            this.txtSearchRoute.PlaceholderText = "🔍 Search route name, source, destination, or ID...";
            this.txtSearchRoute.Size = new System.Drawing.Size(380, 25);
            this.txtSearchRoute.TabIndex = 0;

            // 
            // cmbRouteStatusFilter
            // 
            this.cmbRouteStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRouteStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRouteStatusFilter.FormattingEnabled = true;
            this.cmbRouteStatusFilter.Items.AddRange(new object[] {
            "All Statuses",
            "Active",
            "Inactive"});
            this.cmbRouteStatusFilter.Location = new System.Drawing.Point(395, 12);
            this.cmbRouteStatusFilter.Name = "cmbRouteStatusFilter";
            this.cmbRouteStatusFilter.Size = new System.Drawing.Size(145, 25);
            this.cmbRouteStatusFilter.TabIndex = 1;

            // 
            // btnRefreshRoutes
            // 
            this.btnRefreshRoutes.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnRefreshRoutes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRefreshRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshRoutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshRoutes.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnRefreshRoutes.Location = new System.Drawing.Point(555, 9);
            this.btnRefreshRoutes.Name = "btnRefreshRoutes";
            this.btnRefreshRoutes.Size = new System.Drawing.Size(100, 32);
            this.btnRefreshRoutes.TabIndex = 2;
            this.btnRefreshRoutes.Text = "🔄  Refresh";
            this.btnRefreshRoutes.UseVisualStyleBackColor = false;

            // 
            // lvRoutes
            // 
            this.lvRoutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvRoutes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colRouteId,
            this.colRouteName,
            this.colSource,
            this.colDestination,
            this.colDistance,
            this.colEstimatedTime,
            this.colBaseFare,
            this.colRouteStatus,
            this.colIntermediateStops});
            this.lvRoutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvRoutes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvRoutes.FullRowSelect = true;
            this.lvRoutes.GridLines = true;
            this.lvRoutes.HideSelection = false;
            this.lvRoutes.Location = new System.Drawing.Point(0, 189);
            this.lvRoutes.MultiSelect = false;
            this.lvRoutes.Name = "lvRoutes";
            this.lvRoutes.Size = new System.Drawing.Size(970, 415);
            this.lvRoutes.TabIndex = 3;
            this.lvRoutes.UseCompatibleStateImageBehavior = false;
            this.lvRoutes.View = System.Windows.Forms.View.Details;

            // 
            // colRouteId
            // 
            this.colRouteId.Text = "Route ID";
            this.colRouteId.Width = 85;

            // 
            // colRouteName
            // 
            this.colRouteName.Text = "Route Name";
            this.colRouteName.Width = 190;

            // 
            // colSource
            // 
            this.colSource.Text = "Source";
            this.colSource.Width = 120;

            // 
            // colDestination
            // 
            this.colDestination.Text = "Destination";
            this.colDestination.Width = 120;

            // 
            // colDistance
            // 
            this.colDistance.Text = "Distance";
            this.colDistance.Width = 85;

            // 
            // colEstimatedTime
            // 
            this.colEstimatedTime.Text = "Est. Duration";
            this.colEstimatedTime.Width = 110;

            // 
            // colBaseFare
            // 
            this.colBaseFare.Text = "Base Fare";
            this.colBaseFare.Width = 95;

            // 
            // colRouteStatus
            // 
            this.colRouteStatus.Text = "Status";
            this.colRouteStatus.Width = 85;

            // 
            // colIntermediateStops
            // 
            this.colIntermediateStops.Text = "Intermediate Stops";
            this.colIntermediateStops.Width = 200;

            // 
            // panelRouteActions
            // 
            this.panelRouteActions.Controls.Add(this.btnViewRouteDetails);
            this.panelRouteActions.Controls.Add(this.btnEditRoute);
            this.panelRouteActions.Controls.Add(this.btnToggleRouteStatus);
            this.panelRouteActions.Controls.Add(this.btnDeleteRoute);
            this.panelRouteActions.Controls.Add(this.lblRouteCount);
            this.panelRouteActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelRouteActions.Height = 52;
            this.panelRouteActions.Location = new System.Drawing.Point(0, 604);
            this.panelRouteActions.Name = "panelRouteActions";
            this.panelRouteActions.Size = new System.Drawing.Size(970, 52);
            this.panelRouteActions.TabIndex = 4;

            // 
            // btnViewRouteDetails
            // 
            this.btnViewRouteDetails.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnViewRouteDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnViewRouteDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewRouteDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewRouteDetails.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnViewRouteDetails.Location = new System.Drawing.Point(0, 10);
            this.btnViewRouteDetails.Name = "btnViewRouteDetails";
            this.btnViewRouteDetails.Size = new System.Drawing.Size(125, 34);
            this.btnViewRouteDetails.TabIndex = 0;
            this.btnViewRouteDetails.Text = "👁️  View Details";
            this.btnViewRouteDetails.UseVisualStyleBackColor = false;

            // 
            // btnEditRoute
            // 
            this.btnEditRoute.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnEditRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnEditRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditRoute.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnEditRoute.Location = new System.Drawing.Point(135, 10);
            this.btnEditRoute.Name = "btnEditRoute";
            this.btnEditRoute.Size = new System.Drawing.Size(110, 34);
            this.btnEditRoute.TabIndex = 1;
            this.btnEditRoute.Text = "✏️  Edit Route";
            this.btnEditRoute.UseVisualStyleBackColor = false;

            // 
            // btnToggleRouteStatus
            // 
            this.btnToggleRouteStatus.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnToggleRouteStatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnToggleRouteStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggleRouteStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnToggleRouteStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnToggleRouteStatus.Location = new System.Drawing.Point(255, 10);
            this.btnToggleRouteStatus.Name = "btnToggleRouteStatus";
            this.btnToggleRouteStatus.Size = new System.Drawing.Size(165, 34);
            this.btnToggleRouteStatus.TabIndex = 2;
            this.btnToggleRouteStatus.Text = "🔄  Activate / Deactivate";
            this.btnToggleRouteStatus.UseVisualStyleBackColor = false;

            // 
            // btnDeleteRoute
            // 
            this.btnDeleteRoute.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnDeleteRoute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnDeleteRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteRoute.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnDeleteRoute.Location = new System.Drawing.Point(430, 10);
            this.btnDeleteRoute.Name = "btnDeleteRoute";
            this.btnDeleteRoute.Size = new System.Drawing.Size(120, 34);
            this.btnDeleteRoute.TabIndex = 3;
            this.btnDeleteRoute.Text = "🗑️  Delete Route";
            this.btnDeleteRoute.UseVisualStyleBackColor = false;

            // 
            // lblRouteCount
            // 
            this.lblRouteCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRouteCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRouteCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRouteCount.Location = new System.Drawing.Point(740, 16);
            this.lblRouteCount.Name = "lblRouteCount";
            this.lblRouteCount.Size = new System.Drawing.Size(220, 20);
            this.lblRouteCount.TabIndex = 4;
            this.lblRouteCount.Text = "Showing 8 routes";
            this.lblRouteCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // panelBookingManagement
            // 
            this.panelBookingManagement.Controls.Add(this.lvBookings);
            this.panelBookingManagement.Controls.Add(this.panelBookingActions);
            this.panelBookingManagement.Controls.Add(this.panelBookingsToolbar);
            this.panelBookingManagement.Controls.Add(this.flowBookingMetrics);
            this.panelBookingManagement.Controls.Add(this.panelBookingsHeader);
            this.panelBookingManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookingManagement.Location = new System.Drawing.Point(20, 80);
            this.panelBookingManagement.Name = "panelBookingManagement";
            this.panelBookingManagement.Size = new System.Drawing.Size(970, 656);
            this.panelBookingManagement.TabIndex = 6;
            this.panelBookingManagement.Visible = false;

            // 
            // panelBookingsHeader
            // 
            this.panelBookingsHeader.Controls.Add(this.btnNewBooking);
            this.panelBookingsHeader.Controls.Add(this.lblBookingsTitle);
            this.panelBookingsHeader.Controls.Add(this.lblBookingsSubtitle);
            this.panelBookingsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookingsHeader.Height = 42;
            this.panelBookingsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBookingsHeader.Name = "panelBookingsHeader";
            this.panelBookingsHeader.Size = new System.Drawing.Size(970, 42);
            this.panelBookingsHeader.TabIndex = 0;

            // 
            // lblBookingsTitle
            // 
            this.lblBookingsTitle.AutoSize = true;
            this.lblBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblBookingsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblBookingsTitle.Name = "lblBookingsTitle";
            this.lblBookingsTitle.Size = new System.Drawing.Size(246, 30);
            this.lblBookingsTitle.TabIndex = 0;
            this.lblBookingsTitle.Text = "Booking Management";

            // 
            // lblBookingsSubtitle
            // 
            this.lblBookingsSubtitle.AutoSize = true;
            this.lblBookingsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBookingsSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBookingsSubtitle.Location = new System.Drawing.Point(0, 30);
            this.lblBookingsSubtitle.Name = "lblBookingsSubtitle";
            this.lblBookingsSubtitle.Size = new System.Drawing.Size(430, 17);
            this.lblBookingsSubtitle.TabIndex = 1;
            this.lblBookingsSubtitle.Text = "View passenger reservations, manage seat allocations, confirm payments, and process cancellations.";
            this.lblBookingsSubtitle.Visible = false;

            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewBooking.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnNewBooking.FlatAppearance.BorderSize = 0;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnNewBooking.Location = new System.Drawing.Point(815, 4);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(155, 36);
            this.btnNewBooking.TabIndex = 2;
            this.btnNewBooking.Text = "➕  New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;

            // 
            // flowBookingMetrics
            // 
            this.flowBookingMetrics.Controls.Add(this.cardTotalBookings);
            this.flowBookingMetrics.Controls.Add(this.cardConfirmedBookings);
            this.flowBookingMetrics.Controls.Add(this.cardPendingBookings);
            this.flowBookingMetrics.Controls.Add(this.cardCancelledBookings);
            this.flowBookingMetrics.Controls.Add(this.cardTodayBookings);
            this.flowBookingMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowBookingMetrics.Height = 72;
            this.flowBookingMetrics.Location = new System.Drawing.Point(0, 42);
            this.flowBookingMetrics.Name = "flowBookingMetrics";
            this.flowBookingMetrics.Size = new System.Drawing.Size(970, 72);
            this.flowBookingMetrics.TabIndex = 1;
            this.flowBookingMetrics.Size = new System.Drawing.Size(970, 85);
            this.flowBookingMetrics.TabIndex = 1;

            // 
            // cardTotalBookings
            // 
            this.cardTotalBookings.BackColor = System.Drawing.Color.White;
            this.cardTotalBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalBookings.Controls.Add(this.lblMetricTotalBookingsVal);
            this.cardTotalBookings.Controls.Add(this.lblMetricTotalBookingsTitle);
            this.cardTotalBookings.Controls.Add(this.lblMetricTotalBookingsSub);
            this.cardTotalBookings.Location = new System.Drawing.Point(0, 5);
            this.cardTotalBookings.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cardTotalBookings.Name = "cardTotalBookings";
            this.cardTotalBookings.Size = new System.Drawing.Size(182, 60);
            this.cardTotalBookings.TabIndex = 0;

            // 
            // lblMetricTotalBookingsVal
            // 
            this.lblMetricTotalBookingsVal.AutoSize = true;
            this.lblMetricTotalBookingsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalBookingsVal.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblMetricTotalBookingsVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricTotalBookingsVal.Name = "lblMetricTotalBookingsVal";
            this.lblMetricTotalBookingsVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricTotalBookingsVal.TabIndex = 0;
            this.lblMetricTotalBookingsVal.Text = "8";

            // 
            // lblMetricTotalBookingsTitle
            // 
            this.lblMetricTotalBookingsTitle.AutoSize = true;
            this.lblMetricTotalBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricTotalBookingsTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricTotalBookingsTitle.Name = "lblMetricTotalBookingsTitle";
            this.lblMetricTotalBookingsTitle.Size = new System.Drawing.Size(87, 15);
            this.lblMetricTotalBookingsTitle.TabIndex = 1;
            this.lblMetricTotalBookingsTitle.Text = "Total Bookings";

            // 
            // lblMetricTotalBookingsSub
            // 
            this.lblMetricTotalBookingsSub.AutoSize = true;
            this.lblMetricTotalBookingsSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalBookingsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTotalBookingsSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricTotalBookingsSub.Name = "lblMetricTotalBookingsSub";
            this.lblMetricTotalBookingsSub.Size = new System.Drawing.Size(117, 13);
            this.lblMetricTotalBookingsSub.TabIndex = 2;
            this.lblMetricTotalBookingsSub.Text = "All recorded bookings";
            this.lblMetricTotalBookingsSub.Visible = false;

            // 
            // cardConfirmedBookings
            // 
            this.cardConfirmedBookings.BackColor = System.Drawing.Color.White;
            this.cardConfirmedBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardConfirmedBookings.Controls.Add(this.lblMetricConfirmedBookingsVal);
            this.cardConfirmedBookings.Controls.Add(this.lblMetricConfirmedBookingsTitle);
            this.cardConfirmedBookings.Controls.Add(this.lblMetricConfirmedBookingsSub);
            this.cardConfirmedBookings.Location = new System.Drawing.Point(192, 5);
            this.cardConfirmedBookings.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cardConfirmedBookings.Name = "cardConfirmedBookings";
            this.cardConfirmedBookings.Size = new System.Drawing.Size(182, 60);
            this.cardConfirmedBookings.TabIndex = 1;

            // 
            // lblMetricConfirmedBookingsVal
            // 
            this.lblMetricConfirmedBookingsVal.AutoSize = true;
            this.lblMetricConfirmedBookingsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricConfirmedBookingsVal.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblMetricConfirmedBookingsVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricConfirmedBookingsVal.Name = "lblMetricConfirmedBookingsVal";
            this.lblMetricConfirmedBookingsVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricConfirmedBookingsVal.TabIndex = 0;
            this.lblMetricConfirmedBookingsVal.Text = "5";

            // 
            // lblMetricConfirmedBookingsTitle
            // 
            this.lblMetricConfirmedBookingsTitle.AutoSize = true;
            this.lblMetricConfirmedBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricConfirmedBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricConfirmedBookingsTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricConfirmedBookingsTitle.Name = "lblMetricConfirmedBookingsTitle";
            this.lblMetricConfirmedBookingsTitle.Size = new System.Drawing.Size(65, 15);
            this.lblMetricConfirmedBookingsTitle.TabIndex = 1;
            this.lblMetricConfirmedBookingsTitle.Text = "Confirmed";

            // 
            // lblMetricConfirmedBookingsSub
            // 
            this.lblMetricConfirmedBookingsSub.AutoSize = true;
            this.lblMetricConfirmedBookingsSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricConfirmedBookingsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricConfirmedBookingsSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricConfirmedBookingsSub.Name = "lblMetricConfirmedBookingsSub";
            this.lblMetricConfirmedBookingsSub.Size = new System.Drawing.Size(126, 13);
            this.lblMetricConfirmedBookingsSub.TabIndex = 2;
            this.lblMetricConfirmedBookingsSub.Text = "Confirmed reservations";
            this.lblMetricConfirmedBookingsSub.Visible = false;

            // 
            // cardPendingBookings
            // 
            this.cardPendingBookings.BackColor = System.Drawing.Color.White;
            this.cardPendingBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPendingBookings.Controls.Add(this.lblMetricPendingBookingsVal);
            this.cardPendingBookings.Controls.Add(this.lblMetricPendingBookingsTitle);
            this.cardPendingBookings.Controls.Add(this.lblMetricPendingBookingsSub);
            this.cardPendingBookings.Location = new System.Drawing.Point(384, 5);
            this.cardPendingBookings.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cardPendingBookings.Name = "cardPendingBookings";
            this.cardPendingBookings.Size = new System.Drawing.Size(182, 60);
            this.cardPendingBookings.TabIndex = 2;

            // 
            // lblMetricPendingBookingsVal
            // 
            this.lblMetricPendingBookingsVal.AutoSize = true;
            this.lblMetricPendingBookingsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricPendingBookingsVal.ForeColor = System.Drawing.Color.FromArgb(217, 119, 6);
            this.lblMetricPendingBookingsVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricPendingBookingsVal.Name = "lblMetricPendingBookingsVal";
            this.lblMetricPendingBookingsVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricPendingBookingsVal.TabIndex = 0;
            this.lblMetricPendingBookingsVal.Text = "2";

            // 
            // lblMetricPendingBookingsTitle
            // 
            this.lblMetricPendingBookingsTitle.AutoSize = true;
            this.lblMetricPendingBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricPendingBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricPendingBookingsTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricPendingBookingsTitle.Name = "lblMetricPendingBookingsTitle";
            this.lblMetricPendingBookingsTitle.Size = new System.Drawing.Size(52, 15);
            this.lblMetricPendingBookingsTitle.TabIndex = 1;
            this.lblMetricPendingBookingsTitle.Text = "Pending";

            // 
            // lblMetricPendingBookingsSub
            // 
            this.lblMetricPendingBookingsSub.AutoSize = true;
            this.lblMetricPendingBookingsSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricPendingBookingsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricPendingBookingsSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricPendingBookingsSub.Name = "lblMetricPendingBookingsSub";
            this.lblMetricPendingBookingsSub.Size = new System.Drawing.Size(126, 13);
            this.lblMetricPendingBookingsSub.TabIndex = 2;
            this.lblMetricPendingBookingsSub.Text = "Awaiting confirmation";
            this.lblMetricPendingBookingsSub.Visible = false;

            // 
            // cardCancelledBookings
            // 
            this.cardCancelledBookings.BackColor = System.Drawing.Color.White;
            this.cardCancelledBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardCancelledBookings.Controls.Add(this.lblMetricCancelledBookingsVal);
            this.cardCancelledBookings.Controls.Add(this.lblMetricCancelledBookingsTitle);
            this.cardCancelledBookings.Controls.Add(this.lblMetricCancelledBookingsSub);
            this.cardCancelledBookings.Location = new System.Drawing.Point(576, 5);
            this.cardCancelledBookings.Margin = new System.Windows.Forms.Padding(0, 5, 10, 5);
            this.cardCancelledBookings.Name = "cardCancelledBookings";
            this.cardCancelledBookings.Size = new System.Drawing.Size(182, 60);
            this.cardCancelledBookings.TabIndex = 3;

            // 
            // lblMetricCancelledBookingsVal
            // 
            this.lblMetricCancelledBookingsVal.AutoSize = true;
            this.lblMetricCancelledBookingsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricCancelledBookingsVal.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.lblMetricCancelledBookingsVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricCancelledBookingsVal.Name = "lblMetricCancelledBookingsVal";
            this.lblMetricCancelledBookingsVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricCancelledBookingsVal.TabIndex = 0;
            this.lblMetricCancelledBookingsVal.Text = "1";

            // 
            // lblMetricCancelledBookingsTitle
            // 
            this.lblMetricCancelledBookingsTitle.AutoSize = true;
            this.lblMetricCancelledBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricCancelledBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricCancelledBookingsTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricCancelledBookingsTitle.Name = "lblMetricCancelledBookingsTitle";
            this.lblMetricCancelledBookingsTitle.Size = new System.Drawing.Size(59, 15);
            this.lblMetricCancelledBookingsTitle.TabIndex = 1;
            this.lblMetricCancelledBookingsTitle.Text = "Cancelled";

            // 
            // lblMetricCancelledBookingsSub
            // 
            this.lblMetricCancelledBookingsSub.AutoSize = true;
            this.lblMetricCancelledBookingsSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricCancelledBookingsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricCancelledBookingsSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricCancelledBookingsSub.Name = "lblMetricCancelledBookingsSub";
            this.lblMetricCancelledBookingsSub.Size = new System.Drawing.Size(126, 13);
            this.lblMetricCancelledBookingsSub.TabIndex = 2;
            this.lblMetricCancelledBookingsSub.Text = "Released reservations";
            this.lblMetricCancelledBookingsSub.Visible = false;

            // 
            // cardTodayBookings
            // 
            this.cardTodayBookings.BackColor = System.Drawing.Color.White;
            this.cardTodayBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTodayBookings.Controls.Add(this.lblMetricTodayBookingsVal);
            this.cardTodayBookings.Controls.Add(this.lblMetricTodayBookingsTitle);
            this.cardTodayBookings.Controls.Add(this.lblMetricTodayBookingsSub);
            this.cardTodayBookings.Location = new System.Drawing.Point(768, 5);
            this.cardTodayBookings.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cardTodayBookings.Name = "cardTodayBookings";
            this.cardTodayBookings.Size = new System.Drawing.Size(182, 60);
            this.cardTodayBookings.TabIndex = 4;

            // 
            // lblMetricTodayBookingsVal
            // 
            this.lblMetricTodayBookingsVal.AutoSize = true;
            this.lblMetricTodayBookingsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTodayBookingsVal.ForeColor = System.Drawing.Color.FromArgb(2, 132, 199);
            this.lblMetricTodayBookingsVal.Location = new System.Drawing.Point(12, 8);
            this.lblMetricTodayBookingsVal.Name = "lblMetricTodayBookingsVal";
            this.lblMetricTodayBookingsVal.Size = new System.Drawing.Size(26, 30);
            this.lblMetricTodayBookingsVal.TabIndex = 0;
            this.lblMetricTodayBookingsVal.Text = "4";

            // 
            // lblMetricTodayBookingsTitle
            // 
            this.lblMetricTodayBookingsTitle.AutoSize = true;
            this.lblMetricTodayBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTodayBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblMetricTodayBookingsTitle.Location = new System.Drawing.Point(14, 38);
            this.lblMetricTodayBookingsTitle.Name = "lblMetricTodayBookingsTitle";
            this.lblMetricTodayBookingsTitle.Size = new System.Drawing.Size(94, 15);
            this.lblMetricTodayBookingsTitle.TabIndex = 1;
            this.lblMetricTodayBookingsTitle.Text = "Today's Bookings";

            // 
            // lblMetricTodayBookingsSub
            // 
            this.lblMetricTodayBookingsSub.AutoSize = true;
            this.lblMetricTodayBookingsSub.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTodayBookingsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTodayBookingsSub.Location = new System.Drawing.Point(14, 53);
            this.lblMetricTodayBookingsSub.Name = "lblMetricTodayBookingsSub";
            this.lblMetricTodayBookingsSub.Size = new System.Drawing.Size(126, 13);
            this.lblMetricTodayBookingsSub.TabIndex = 2;
            this.lblMetricTodayBookingsSub.Text = "Created or travel today";
            this.lblMetricTodayBookingsSub.Visible = false;

            // 
            // panelBookingsToolbar
            // 
            this.panelBookingsToolbar.Controls.Add(this.txtSearchBooking);
            this.panelBookingsToolbar.Controls.Add(this.cmbBookingStatusFilter);
            this.panelBookingsToolbar.Controls.Add(this.cmbBookingRouteFilter);
            this.panelBookingsToolbar.Controls.Add(this.chkEnableDateFilter);
            this.panelBookingsToolbar.Controls.Add(this.dtpBookingFilterDate);
            this.panelBookingsToolbar.Controls.Add(this.btnResetBookingFilters);
            this.panelBookingsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookingsToolbar.Height = 50;
            this.panelBookingsToolbar.Location = new System.Drawing.Point(0, 139);
            this.panelBookingsToolbar.Name = "panelBookingsToolbar";
            this.panelBookingsToolbar.Size = new System.Drawing.Size(970, 50);
            this.panelBookingsToolbar.TabIndex = 2;

            // 
            // txtSearchBooking
            // 
            this.txtSearchBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchBooking.Location = new System.Drawing.Point(0, 12);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.PlaceholderText = "🔍 Search booking ref, passenger, phone, or route...";
            this.txtSearchBooking.Size = new System.Drawing.Size(280, 25);
            this.txtSearchBooking.TabIndex = 0;

            // 
            // cmbBookingStatusFilter
            // 
            this.cmbBookingStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBookingStatusFilter.FormattingEnabled = true;
            this.cmbBookingStatusFilter.Items.AddRange(new object[] {
            "All Statuses",
            "Confirmed",
            "Pending",
            "Cancelled"});
            this.cmbBookingStatusFilter.Location = new System.Drawing.Point(290, 12);
            this.cmbBookingStatusFilter.Name = "cmbBookingStatusFilter";
            this.cmbBookingStatusFilter.Size = new System.Drawing.Size(130, 25);
            this.cmbBookingStatusFilter.TabIndex = 1;

            // 
            // cmbBookingRouteFilter
            // 
            this.cmbBookingRouteFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingRouteFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBookingRouteFilter.FormattingEnabled = true;
            this.cmbBookingRouteFilter.Location = new System.Drawing.Point(430, 12);
            this.cmbBookingRouteFilter.Name = "cmbBookingRouteFilter";
            this.cmbBookingRouteFilter.Size = new System.Drawing.Size(185, 25);
            this.cmbBookingRouteFilter.TabIndex = 2;

            // 
            // chkEnableDateFilter
            // 
            this.chkEnableDateFilter.AutoSize = true;
            this.chkEnableDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEnableDateFilter.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkEnableDateFilter.Location = new System.Drawing.Point(625, 15);
            this.chkEnableDateFilter.Name = "chkEnableDateFilter";
            this.chkEnableDateFilter.Size = new System.Drawing.Size(95, 19);
            this.chkEnableDateFilter.TabIndex = 3;
            this.chkEnableDateFilter.Text = "Travel Date:";
            this.chkEnableDateFilter.UseVisualStyleBackColor = true;

            // 
            // dtpBookingFilterDate
            // 
            this.dtpBookingFilterDate.Enabled = false;
            this.dtpBookingFilterDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBookingFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingFilterDate.Location = new System.Drawing.Point(725, 12);
            this.dtpBookingFilterDate.Name = "dtpBookingFilterDate";
            this.dtpBookingFilterDate.Size = new System.Drawing.Size(125, 24);
            this.dtpBookingFilterDate.TabIndex = 4;

            // 
            // btnResetBookingFilters
            // 
            this.btnResetBookingFilters.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnResetBookingFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnResetBookingFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetBookingFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnResetBookingFilters.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnResetBookingFilters.Location = new System.Drawing.Point(860, 9);
            this.btnResetBookingFilters.Name = "btnResetBookingFilters";
            this.btnResetBookingFilters.Size = new System.Drawing.Size(95, 32);
            this.btnResetBookingFilters.TabIndex = 5;
            this.btnResetBookingFilters.Text = "🔄  Reset";
            this.btnResetBookingFilters.UseVisualStyleBackColor = false;

            // 
            // lvBookings
            // 
            this.lvBookings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBookingId,
            this.colPassengerName,
            this.colPassengerPhone,
            this.colBookingRoute,
            this.colTravelDate,
            this.colDepartureTime,
            this.colSeats,
            this.colTotalAmount,
            this.colBookingStatus,
            this.colPaymentStatus});
            this.lvBookings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvBookings.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvBookings.FullRowSelect = true;
            this.lvBookings.GridLines = true;
            this.lvBookings.HideSelection = false;
            this.lvBookings.Location = new System.Drawing.Point(0, 189);
            this.lvBookings.MultiSelect = false;
            this.lvBookings.Name = "lvBookings";
            this.lvBookings.Size = new System.Drawing.Size(970, 415);
            this.lvBookings.TabIndex = 3;
            this.lvBookings.UseCompatibleStateImageBehavior = false;
            this.lvBookings.View = System.Windows.Forms.View.Details;

            // 
            // colBookingId
            // 
            this.colBookingId.Text = "Booking Ref";
            this.colBookingId.Width = 95;

            // 
            // colPassengerName
            // 
            this.colPassengerName.Text = "Passenger Name";
            this.colPassengerName.Width = 140;

            // 
            // colPassengerPhone
            // 
            this.colPassengerPhone.Text = "Phone Number";
            this.colPassengerPhone.Width = 120;

            // 
            // colBookingRoute
            // 
            this.colBookingRoute.Text = "Route";
            this.colBookingRoute.Width = 180;

            // 
            // colTravelDate
            // 
            this.colTravelDate.Text = "Travel Date";
            this.colTravelDate.Width = 90;

            // 
            // colDepartureTime
            // 
            this.colDepartureTime.Text = "Departure";
            this.colDepartureTime.Width = 80;

            // 
            // colSeats
            // 
            this.colSeats.Text = "Seat(s)";
            this.colSeats.Width = 110;

            // 
            // colTotalAmount
            // 
            this.colTotalAmount.Text = "Total Fare";
            this.colTotalAmount.Width = 95;

            // 
            // colBookingStatus
            // 
            this.colBookingStatus.Text = "Status";
            this.colBookingStatus.Width = 85;

            // 
            // colPaymentStatus
            // 
            this.colPaymentStatus.Text = "Payment";
            this.colPaymentStatus.Width = 85;

            // 
            // panelBookingActions
            // 
            this.panelBookingActions.Controls.Add(this.btnViewBookingDetails);
            this.panelBookingActions.Controls.Add(this.btnModifyBooking);
            this.panelBookingActions.Controls.Add(this.btnCancelBookingAction);
            this.panelBookingActions.Controls.Add(this.btnPrintTicket);
            this.panelBookingActions.Controls.Add(this.lblBookingCount);
            this.panelBookingActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBookingActions.Height = 52;
            this.panelBookingActions.Location = new System.Drawing.Point(0, 604);
            this.panelBookingActions.Name = "panelBookingActions";
            this.panelBookingActions.Size = new System.Drawing.Size(970, 52);
            this.panelBookingActions.TabIndex = 4;

            // 
            // btnViewBookingDetails
            // 
            this.btnViewBookingDetails.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnViewBookingDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnViewBookingDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookingDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewBookingDetails.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnViewBookingDetails.Location = new System.Drawing.Point(0, 10);
            this.btnViewBookingDetails.Name = "btnViewBookingDetails";
            this.btnViewBookingDetails.Size = new System.Drawing.Size(125, 34);
            this.btnViewBookingDetails.TabIndex = 0;
            this.btnViewBookingDetails.Text = "👁️  View Details";
            this.btnViewBookingDetails.UseVisualStyleBackColor = false;

            // 
            // btnModifyBooking
            // 
            this.btnModifyBooking.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnModifyBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnModifyBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModifyBooking.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnModifyBooking.Location = new System.Drawing.Point(135, 10);
            this.btnModifyBooking.Name = "btnModifyBooking";
            this.btnModifyBooking.Size = new System.Drawing.Size(125, 34);
            this.btnModifyBooking.TabIndex = 1;
            this.btnModifyBooking.Text = "✏️  Modify Booking";
            this.btnModifyBooking.UseVisualStyleBackColor = false;

            // 
            // btnCancelBookingAction
            // 
            this.btnCancelBookingAction.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnCancelBookingAction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnCancelBookingAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBookingAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelBookingAction.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnCancelBookingAction.Location = new System.Drawing.Point(270, 10);
            this.btnCancelBookingAction.Name = "btnCancelBookingAction";
            this.btnCancelBookingAction.Size = new System.Drawing.Size(135, 34);
            this.btnCancelBookingAction.TabIndex = 2;
            this.btnCancelBookingAction.Text = "❌  Cancel Booking";
            this.btnCancelBookingAction.UseVisualStyleBackColor = false;

            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnPrintTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnPrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintTicket.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnPrintTicket.Location = new System.Drawing.Point(415, 10);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(155, 34);
            this.btnPrintTicket.TabIndex = 3;
            this.btnPrintTicket.Text = "🎟️  Print / View Ticket";
            this.btnPrintTicket.UseVisualStyleBackColor = false;

            // 
            // lblBookingCount
            // 
            this.lblBookingCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookingCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookingCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBookingCount.Location = new System.Drawing.Point(740, 16);
            this.lblBookingCount.Name = "lblBookingCount";
            this.lblBookingCount.Size = new System.Drawing.Size(220, 20);
            this.lblBookingCount.TabIndex = 4;
            this.lblBookingCount.Text = "Showing 8 bookings";
            this.lblBookingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // panelTicketManagement
            // 
            this.panelTicketManagement.Controls.Add(this.lvTickets);
            this.panelTicketManagement.Controls.Add(this.panelTicketActions);
            this.panelTicketManagement.Controls.Add(this.panelTicketsToolbar);
            this.panelTicketManagement.Controls.Add(this.flowTicketMetrics);
            this.panelTicketManagement.Controls.Add(this.panelTicketsHeader);
            this.panelTicketManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTicketManagement.Location = new System.Drawing.Point(20, 80);
            this.panelTicketManagement.Name = "panelTicketManagement";
            this.panelTicketManagement.Size = new System.Drawing.Size(970, 656);
            this.panelTicketManagement.TabIndex = 7;
            this.panelTicketManagement.Visible = false;

            // 
            // panelTicketsHeader
            // 
            this.panelTicketsHeader.Controls.Add(this.btnVerifyBoardModal);
            this.panelTicketsHeader.Controls.Add(this.btnNewTicket);
            this.panelTicketsHeader.Controls.Add(this.lblTicketsTitle);
            this.panelTicketsHeader.Controls.Add(this.lblTicketsSubtitle);
            this.panelTicketsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTicketsHeader.Height = 42;
            this.panelTicketsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelTicketsHeader.Name = "panelTicketsHeader";
            this.panelTicketsHeader.Size = new System.Drawing.Size(970, 42);
            this.panelTicketsHeader.TabIndex = 0;

            // 
            // lblTicketsTitle
            // 
            this.lblTicketsTitle.AutoSize = true;
            this.lblTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTicketsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTicketsTitle.Name = "lblTicketsTitle";
            this.lblTicketsTitle.Size = new System.Drawing.Size(225, 30);
            this.lblTicketsTitle.TabIndex = 0;
            this.lblTicketsTitle.Text = "Ticket Management";

            // 
            // lblTicketsSubtitle
            // 
            this.lblTicketsSubtitle.AutoSize = true;
            this.lblTicketsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTicketsSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTicketsSubtitle.Location = new System.Drawing.Point(0, 30);
            this.lblTicketsSubtitle.Name = "lblTicketsSubtitle";
            this.lblTicketsSubtitle.Size = new System.Drawing.Size(460, 17);
            this.lblTicketsSubtitle.TabIndex = 1;
            this.lblTicketsSubtitle.Text = "Generate ticket references, verify authorizations before boarding, and print boarding passes.";
            this.lblTicketsSubtitle.Visible = false;

            // 
            // btnVerifyBoardModal
            // 
            this.btnVerifyBoardModal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerifyBoardModal.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnVerifyBoardModal.FlatAppearance.BorderSize = 0;
            this.btnVerifyBoardModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyBoardModal.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyBoardModal.ForeColor = System.Drawing.Color.White;
            this.btnVerifyBoardModal.Location = new System.Drawing.Point(620, 4);
            this.btnVerifyBoardModal.Name = "btnVerifyBoardModal";
            this.btnVerifyBoardModal.Size = new System.Drawing.Size(180, 36);
            this.btnVerifyBoardModal.TabIndex = 2;
            this.btnVerifyBoardModal.Text = "⚡ Verify & Board Scanner";
            this.btnVerifyBoardModal.UseVisualStyleBackColor = false;

            // 
            // btnNewTicket
            // 
            this.btnNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTicket.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnNewTicket.FlatAppearance.BorderSize = 0;
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewTicket.ForeColor = System.Drawing.Color.White;
            this.btnNewTicket.Location = new System.Drawing.Point(810, 4);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(160, 36);
            this.btnNewTicket.TabIndex = 3;
            this.btnNewTicket.Text = "➕  Issue New Ticket";
            this.btnNewTicket.UseVisualStyleBackColor = false;

            // 
            // flowTicketMetrics
            // 
            this.flowTicketMetrics.Controls.Add(this.cardTotalTickets);
            this.flowTicketMetrics.Controls.Add(this.cardValidTickets);
            this.flowTicketMetrics.Controls.Add(this.cardBoardedTickets);
            this.flowTicketMetrics.Controls.Add(this.cardCancelledTickets);
            this.flowTicketMetrics.Controls.Add(this.cardTodayTickets);
            this.flowTicketMetrics.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowTicketMetrics.Height = 72;
            this.flowTicketMetrics.Location = new System.Drawing.Point(0, 42);
            this.flowTicketMetrics.Name = "flowTicketMetrics";
            this.flowTicketMetrics.Size = new System.Drawing.Size(970, 72);
            this.flowTicketMetrics.TabIndex = 1;
            this.flowTicketMetrics.WrapContents = false;

            // 
            // cardTotalTickets
            // 
            this.cardTotalTickets.BackColor = System.Drawing.Color.White;
            this.cardTotalTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTotalTickets.Controls.Add(this.lblMetricTotalTicketsSub);
            this.cardTotalTickets.Controls.Add(this.lblMetricTotalTicketsVal);
            this.cardTotalTickets.Controls.Add(this.lblMetricTotalTicketsTitle);
            this.cardTotalTickets.Location = new System.Drawing.Point(0, 5);
            this.cardTotalTickets.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardTotalTickets.Name = "cardTotalTickets";
            this.cardTotalTickets.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.cardTotalTickets.Size = new System.Drawing.Size(182, 60);
            this.cardTotalTickets.TabIndex = 0;

            this.lblMetricTotalTicketsTitle.AutoSize = true;
            this.lblMetricTotalTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTotalTicketsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblMetricTotalTicketsTitle.Name = "lblMetricTotalTicketsTitle";
            this.lblMetricTotalTicketsTitle.Size = new System.Drawing.Size(125, 13);
            this.lblMetricTotalTicketsTitle.TabIndex = 0;
            this.lblMetricTotalTicketsTitle.Text = "TOTAL TICKETS ISSUED";

            this.lblMetricTotalTicketsVal.AutoSize = true;
            this.lblMetricTotalTicketsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalTicketsVal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMetricTotalTicketsVal.Location = new System.Drawing.Point(10, 24);
            this.lblMetricTotalTicketsVal.Name = "lblMetricTotalTicketsVal";
            this.lblMetricTotalTicketsVal.Size = new System.Drawing.Size(39, 30);
            this.lblMetricTotalTicketsVal.TabIndex = 1;
            this.lblMetricTotalTicketsVal.Text = "0";

            this.lblMetricTotalTicketsSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetricTotalTicketsSub.AutoSize = true;
            this.lblMetricTotalTicketsSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTotalTicketsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTotalTicketsSub.Location = new System.Drawing.Point(12, 52);
            this.lblMetricTotalTicketsSub.Name = "lblMetricTotalTicketsSub";
            this.lblMetricTotalTicketsSub.Size = new System.Drawing.Size(100, 12);
            this.lblMetricTotalTicketsSub.TabIndex = 2;
            this.lblMetricTotalTicketsSub.Text = "All recorded tickets";
            this.lblMetricTotalTicketsSub.Visible = false;

            // 
            // cardValidTickets
            // 
            this.cardValidTickets.BackColor = System.Drawing.Color.White;
            this.cardValidTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardValidTickets.Controls.Add(this.lblMetricValidTicketsSub);
            this.cardValidTickets.Controls.Add(this.lblMetricValidTicketsVal);
            this.cardValidTickets.Controls.Add(this.lblMetricValidTicketsTitle);
            this.cardValidTickets.Location = new System.Drawing.Point(194, 5);
            this.cardValidTickets.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardValidTickets.Name = "cardValidTickets";
            this.cardValidTickets.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.cardValidTickets.Size = new System.Drawing.Size(182, 60);
            this.cardValidTickets.TabIndex = 1;

            this.lblMetricValidTicketsTitle.AutoSize = true;
            this.lblMetricValidTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricValidTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblMetricValidTicketsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblMetricValidTicketsTitle.Name = "lblMetricValidTicketsTitle";
            this.lblMetricValidTicketsTitle.Size = new System.Drawing.Size(84, 13);
            this.lblMetricValidTicketsTitle.TabIndex = 0;
            this.lblMetricValidTicketsTitle.Text = "VALID / ACTIVE";

            this.lblMetricValidTicketsVal.AutoSize = true;
            this.lblMetricValidTicketsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricValidTicketsVal.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblMetricValidTicketsVal.Location = new System.Drawing.Point(10, 24);
            this.lblMetricValidTicketsVal.Name = "lblMetricValidTicketsVal";
            this.lblMetricValidTicketsVal.Size = new System.Drawing.Size(39, 30);
            this.lblMetricValidTicketsVal.TabIndex = 1;
            this.lblMetricValidTicketsVal.Text = "0";

            this.lblMetricValidTicketsSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetricValidTicketsSub.AutoSize = true;
            this.lblMetricValidTicketsSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricValidTicketsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricValidTicketsSub.Location = new System.Drawing.Point(12, 52);
            this.lblMetricValidTicketsSub.Name = "lblMetricValidTicketsSub";
            this.lblMetricValidTicketsSub.Size = new System.Drawing.Size(95, 12);
            this.lblMetricValidTicketsSub.TabIndex = 2;
            this.lblMetricValidTicketsSub.Text = "Ready for boarding";
            this.lblMetricValidTicketsSub.Visible = false;

            // 
            // cardBoardedTickets
            // 
            this.cardBoardedTickets.BackColor = System.Drawing.Color.White;
            this.cardBoardedTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBoardedTickets.Controls.Add(this.lblMetricBoardedTicketsSub);
            this.cardBoardedTickets.Controls.Add(this.lblMetricBoardedTicketsVal);
            this.cardBoardedTickets.Controls.Add(this.lblMetricBoardedTicketsTitle);
            this.cardBoardedTickets.Location = new System.Drawing.Point(388, 5);
            this.cardBoardedTickets.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardBoardedTickets.Name = "cardBoardedTickets";
            this.cardBoardedTickets.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.cardBoardedTickets.Size = new System.Drawing.Size(182, 60);
            this.cardBoardedTickets.TabIndex = 2;

            this.lblMetricBoardedTicketsTitle.AutoSize = true;
            this.lblMetricBoardedTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricBoardedTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblMetricBoardedTicketsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblMetricBoardedTicketsTitle.Name = "lblMetricBoardedTicketsTitle";
            this.lblMetricBoardedTicketsTitle.Size = new System.Drawing.Size(125, 13);
            this.lblMetricBoardedTicketsTitle.TabIndex = 0;
            this.lblMetricBoardedTicketsTitle.Text = "BOARDED / VERIFIED";

            this.lblMetricBoardedTicketsVal.AutoSize = true;
            this.lblMetricBoardedTicketsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricBoardedTicketsVal.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblMetricBoardedTicketsVal.Location = new System.Drawing.Point(10, 24);
            this.lblMetricBoardedTicketsVal.Name = "lblMetricBoardedTicketsVal";
            this.lblMetricBoardedTicketsVal.Size = new System.Drawing.Size(39, 30);
            this.lblMetricBoardedTicketsVal.TabIndex = 1;
            this.lblMetricBoardedTicketsVal.Text = "0";

            this.lblMetricBoardedTicketsSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetricBoardedTicketsSub.AutoSize = true;
            this.lblMetricBoardedTicketsSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricBoardedTicketsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricBoardedTicketsSub.Location = new System.Drawing.Point(12, 52);
            this.lblMetricBoardedTicketsSub.Name = "lblMetricBoardedTicketsSub";
            this.lblMetricBoardedTicketsSub.Size = new System.Drawing.Size(100, 12);
            this.lblMetricBoardedTicketsSub.TabIndex = 2;
            this.lblMetricBoardedTicketsSub.Text = "Checked-in passengers";
            this.lblMetricBoardedTicketsSub.Visible = false;

            // 
            // cardCancelledTickets
            // 
            this.cardCancelledTickets.BackColor = System.Drawing.Color.White;
            this.cardCancelledTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardCancelledTickets.Controls.Add(this.lblMetricCancelledTicketsSub);
            this.cardCancelledTickets.Controls.Add(this.lblMetricCancelledTicketsVal);
            this.cardCancelledTickets.Controls.Add(this.lblMetricCancelledTicketsTitle);
            this.cardCancelledTickets.Location = new System.Drawing.Point(582, 5);
            this.cardCancelledTickets.Margin = new System.Windows.Forms.Padding(0, 5, 12, 5);
            this.cardCancelledTickets.Name = "cardCancelledTickets";
            this.cardCancelledTickets.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.cardCancelledTickets.Size = new System.Drawing.Size(182, 60);
            this.cardCancelledTickets.TabIndex = 3;

            this.lblMetricCancelledTicketsTitle.AutoSize = true;
            this.lblMetricCancelledTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricCancelledTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(225, 29, 72);
            this.lblMetricCancelledTicketsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblMetricCancelledTicketsTitle.Name = "lblMetricCancelledTicketsTitle";
            this.lblMetricCancelledTicketsTitle.Size = new System.Drawing.Size(73, 13);
            this.lblMetricCancelledTicketsTitle.TabIndex = 0;
            this.lblMetricCancelledTicketsTitle.Text = "CANCELLED";

            this.lblMetricCancelledTicketsVal.AutoSize = true;
            this.lblMetricCancelledTicketsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricCancelledTicketsVal.ForeColor = System.Drawing.Color.FromArgb(225, 29, 72);
            this.lblMetricCancelledTicketsVal.Location = new System.Drawing.Point(10, 24);
            this.lblMetricCancelledTicketsVal.Name = "lblMetricCancelledTicketsVal";
            this.lblMetricCancelledTicketsVal.Size = new System.Drawing.Size(39, 30);
            this.lblMetricCancelledTicketsVal.TabIndex = 1;
            this.lblMetricCancelledTicketsVal.Text = "0";

            this.lblMetricCancelledTicketsSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetricCancelledTicketsSub.AutoSize = true;
            this.lblMetricCancelledTicketsSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricCancelledTicketsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricCancelledTicketsSub.Location = new System.Drawing.Point(12, 52);
            this.lblMetricCancelledTicketsSub.Name = "lblMetricCancelledTicketsSub";
            this.lblMetricCancelledTicketsSub.Size = new System.Drawing.Size(100, 12);
            this.lblMetricCancelledTicketsSub.TabIndex = 2;
            this.lblMetricCancelledTicketsSub.Text = "Refunded / voided";
            this.lblMetricCancelledTicketsSub.Visible = false;

            // 
            // cardTodayTickets
            // 
            this.cardTodayTickets.BackColor = System.Drawing.Color.White;
            this.cardTodayTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTodayTickets.Controls.Add(this.lblMetricTodayTicketsSub);
            this.cardTodayTickets.Controls.Add(this.lblMetricTodayTicketsVal);
            this.cardTodayTickets.Controls.Add(this.lblMetricTodayTicketsTitle);
            this.cardTodayTickets.Location = new System.Drawing.Point(776, 5);
            this.cardTodayTickets.Margin = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.cardTodayTickets.Name = "cardTodayTickets";
            this.cardTodayTickets.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);
            this.cardTodayTickets.Size = new System.Drawing.Size(182, 60);
            this.cardTodayTickets.TabIndex = 4;

            this.lblMetricTodayTicketsTitle.AutoSize = true;
            this.lblMetricTodayTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTodayTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.lblMetricTodayTicketsTitle.Location = new System.Drawing.Point(12, 8);
            this.lblMetricTodayTicketsTitle.Name = "lblMetricTodayTicketsTitle";
            this.lblMetricTodayTicketsTitle.Size = new System.Drawing.Size(116, 13);
            this.lblMetricTodayTicketsTitle.TabIndex = 0;
            this.lblMetricTodayTicketsTitle.Text = "TODAY'S BOARDINGS";

            this.lblMetricTodayTicketsVal.AutoSize = true;
            this.lblMetricTodayTicketsVal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTodayTicketsVal.ForeColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.lblMetricTodayTicketsVal.Location = new System.Drawing.Point(10, 24);
            this.lblMetricTodayTicketsVal.Name = "lblMetricTodayTicketsVal";
            this.lblMetricTodayTicketsVal.Size = new System.Drawing.Size(39, 30);
            this.lblMetricTodayTicketsVal.TabIndex = 1;
            this.lblMetricTodayTicketsVal.Text = "0";

            this.lblMetricTodayTicketsSub.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMetricTodayTicketsSub.AutoSize = true;
            this.lblMetricTodayTicketsSub.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMetricTodayTicketsSub.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTodayTicketsSub.Location = new System.Drawing.Point(12, 52);
            this.lblMetricTodayTicketsSub.Name = "lblMetricTodayTicketsSub";
            this.lblMetricTodayTicketsSub.Size = new System.Drawing.Size(100, 12);
            this.lblMetricTodayTicketsSub.TabIndex = 2;
            this.lblMetricTodayTicketsSub.Text = "Departures today";
            this.lblMetricTodayTicketsSub.Visible = false;

            // 
            // panelTicketsToolbar
            // 
            this.panelTicketsToolbar.Controls.Add(this.txtSearchTicketFilter);
            this.panelTicketsToolbar.Controls.Add(this.cmbTicketStatusFilter);
            this.panelTicketsToolbar.Controls.Add(this.cmbTicketRouteFilter);
            this.panelTicketsToolbar.Controls.Add(this.chkEnableTicketDateFilter);
            this.panelTicketsToolbar.Controls.Add(this.dtpTicketFilterDate);
            this.panelTicketsToolbar.Controls.Add(this.btnResetTicketFilters);
            this.panelTicketsToolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTicketsToolbar.Height = 52;
            this.panelTicketsToolbar.Location = new System.Drawing.Point(0, 142);
            this.panelTicketsToolbar.Name = "panelTicketsToolbar";
            this.panelTicketsToolbar.Size = new System.Drawing.Size(970, 52);
            this.panelTicketsToolbar.TabIndex = 2;

            // 
            // txtSearchTicketFilter
            // 
            this.txtSearchTicketFilter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTicketFilter.Location = new System.Drawing.Point(0, 13);
            this.txtSearchTicketFilter.Name = "txtSearchTicketFilter";
            this.txtSearchTicketFilter.PlaceholderText = "Search by Ticket ID, Booking Ref, Passenger, Phone, Coach...";
            this.txtSearchTicketFilter.Size = new System.Drawing.Size(320, 25);
            this.txtSearchTicketFilter.TabIndex = 0;

            // 
            // cmbTicketStatusFilter
            // 
            this.cmbTicketStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketStatusFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTicketStatusFilter.FormattingEnabled = true;
            this.cmbTicketStatusFilter.Items.AddRange(new object[] {
            "All Statuses",
            "Valid",
            "Boarded",
            "Cancelled"});
            this.cmbTicketStatusFilter.Location = new System.Drawing.Point(330, 13);
            this.cmbTicketStatusFilter.Name = "cmbTicketStatusFilter";
            this.cmbTicketStatusFilter.Size = new System.Drawing.Size(125, 25);
            this.cmbTicketStatusFilter.TabIndex = 1;

            // 
            // cmbTicketRouteFilter
            // 
            this.cmbTicketRouteFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketRouteFilter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTicketRouteFilter.FormattingEnabled = true;
            this.cmbTicketRouteFilter.Items.AddRange(new object[] {
            "All Routes / Trips"});
            this.cmbTicketRouteFilter.Location = new System.Drawing.Point(465, 13);
            this.cmbTicketRouteFilter.Name = "cmbTicketRouteFilter";
            this.cmbTicketRouteFilter.Size = new System.Drawing.Size(175, 25);
            this.cmbTicketRouteFilter.TabIndex = 2;

            // 
            // chkEnableTicketDateFilter
            // 
            this.chkEnableTicketDateFilter.AutoSize = true;
            this.chkEnableTicketDateFilter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkEnableTicketDateFilter.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.chkEnableTicketDateFilter.Location = new System.Drawing.Point(650, 16);
            this.chkEnableTicketDateFilter.Name = "chkEnableTicketDateFilter";
            this.chkEnableTicketDateFilter.Size = new System.Drawing.Size(89, 19);
            this.chkEnableTicketDateFilter.TabIndex = 3;
            this.chkEnableTicketDateFilter.Text = "Travel Date";
            this.chkEnableTicketDateFilter.UseVisualStyleBackColor = true;

            // 
            // dtpTicketFilterDate
            // 
            this.dtpTicketFilterDate.CustomFormat = "yyyy-MM-dd";
            this.dtpTicketFilterDate.Enabled = false;
            this.dtpTicketFilterDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTicketFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTicketFilterDate.Location = new System.Drawing.Point(745, 13);
            this.dtpTicketFilterDate.Name = "dtpTicketFilterDate";
            this.dtpTicketFilterDate.Size = new System.Drawing.Size(115, 24);
            this.dtpTicketFilterDate.TabIndex = 4;

            // 
            // btnResetTicketFilters
            // 
            this.btnResetTicketFilters.BackColor = System.Drawing.Color.White;
            this.btnResetTicketFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnResetTicketFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTicketFilters.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnResetTicketFilters.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnResetTicketFilters.Location = new System.Drawing.Point(870, 12);
            this.btnResetTicketFilters.Name = "btnResetTicketFilters";
            this.btnResetTicketFilters.Size = new System.Drawing.Size(95, 27);
            this.btnResetTicketFilters.TabIndex = 5;
            this.btnResetTicketFilters.Text = "↺  Reset";
            this.btnResetTicketFilters.UseVisualStyleBackColor = false;

            // 
            // lvTickets
            // 
            this.lvTickets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTicketId,
            this.colTicketBookingRef,
            this.colTicketPassenger,
            this.colTicketPhone,
            this.colTicketRoute,
            this.colTicketDate,
            this.colTicketTime,
            this.colTicketSeat,
            this.colTicketGate,
            this.colTicketBus,
            this.colTicketStatus});
            this.lvTickets.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTickets.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvTickets.FullRowSelect = true;
            this.lvTickets.GridLines = true;
            this.lvTickets.Location = new System.Drawing.Point(0, 194);
            this.lvTickets.MultiSelect = false;
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(970, 410);
            this.lvTickets.TabIndex = 3;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;

            this.colTicketId.Text = "Ticket Ref";
            this.colTicketId.Width = 90;

            this.colTicketBookingRef.Text = "Booking Ref";
            this.colTicketBookingRef.Width = 90;

            this.colTicketPassenger.Text = "Passenger Name";
            this.colTicketPassenger.Width = 135;

            this.colTicketPhone.Text = "Phone";
            this.colTicketPhone.Width = 115;

            this.colTicketRoute.Text = "Route";
            this.colTicketRoute.Width = 175;

            this.colTicketDate.Text = "Travel Date";
            this.colTicketDate.Width = 90;

            this.colTicketTime.Text = "Departure";
            this.colTicketTime.Width = 80;

            this.colTicketSeat.Text = "Seat";
            this.colTicketSeat.Width = 65;

            this.colTicketGate.Text = "Gate";
            this.colTicketGate.Width = 75;

            this.colTicketBus.Text = "Coach";
            this.colTicketBus.Width = 120;

            this.colTicketStatus.Text = "Status";
            this.colTicketStatus.Width = 85;

            // 
            // panelTicketActions
            // 
            this.panelTicketActions.Controls.Add(this.btnViewTicketDetails);
            this.panelTicketActions.Controls.Add(this.btnVerifyAndBoard);
            this.panelTicketActions.Controls.Add(this.btnPrintTicketPass);
            this.panelTicketActions.Controls.Add(this.btnCancelTicketAction);
            this.panelTicketActions.Controls.Add(this.lblTicketCount);
            this.panelTicketActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTicketActions.Height = 52;
            this.panelTicketActions.Location = new System.Drawing.Point(0, 604);
            this.panelTicketActions.Name = "panelTicketActions";
            this.panelTicketActions.Size = new System.Drawing.Size(970, 52);
            this.panelTicketActions.TabIndex = 4;

            // 
            // btnViewTicketDetails
            // 
            this.btnViewTicketDetails.BackColor = System.Drawing.Color.White;
            this.btnViewTicketDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnViewTicketDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTicketDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewTicketDetails.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnViewTicketDetails.Location = new System.Drawing.Point(0, 10);
            this.btnViewTicketDetails.Name = "btnViewTicketDetails";
            this.btnViewTicketDetails.Size = new System.Drawing.Size(120, 34);
            this.btnViewTicketDetails.TabIndex = 0;
            this.btnViewTicketDetails.Text = "👁️  View Details";
            this.btnViewTicketDetails.UseVisualStyleBackColor = false;

            // 
            // btnVerifyAndBoard
            // 
            this.btnVerifyAndBoard.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnVerifyAndBoard.FlatAppearance.BorderSize = 0;
            this.btnVerifyAndBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyAndBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVerifyAndBoard.ForeColor = System.Drawing.Color.White;
            this.btnVerifyAndBoard.Location = new System.Drawing.Point(130, 10);
            this.btnVerifyAndBoard.Name = "btnVerifyAndBoard";
            this.btnVerifyAndBoard.Size = new System.Drawing.Size(145, 34);
            this.btnVerifyAndBoard.TabIndex = 1;
            this.btnVerifyAndBoard.Text = "✅  Verify & Board";
            this.btnVerifyAndBoard.UseVisualStyleBackColor = false;

            // 
            // btnPrintTicketPass
            // 
            this.btnPrintTicketPass.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnPrintTicketPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnPrintTicketPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTicketPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintTicketPass.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnPrintTicketPass.Location = new System.Drawing.Point(285, 10);
            this.btnPrintTicketPass.Name = "btnPrintTicketPass";
            this.btnPrintTicketPass.Size = new System.Drawing.Size(160, 34);
            this.btnPrintTicketPass.TabIndex = 2;
            this.btnPrintTicketPass.Text = "🖨️  Print Boarding Pass";
            this.btnPrintTicketPass.UseVisualStyleBackColor = false;

            // 
            // btnCancelTicketAction
            // 
            this.btnCancelTicketAction.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnCancelTicketAction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(254, 202, 202);
            this.btnCancelTicketAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTicketAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelTicketAction.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnCancelTicketAction.Location = new System.Drawing.Point(455, 10);
            this.btnCancelTicketAction.Name = "btnCancelTicketAction";
            this.btnCancelTicketAction.Size = new System.Drawing.Size(130, 34);
            this.btnCancelTicketAction.TabIndex = 3;
            this.btnCancelTicketAction.Text = "❌  Cancel Ticket";
            this.btnCancelTicketAction.UseVisualStyleBackColor = false;

            // 
            // lblTicketCount
            // 
            this.lblTicketCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTicketCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTicketCount.Location = new System.Drawing.Point(740, 16);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Size = new System.Drawing.Size(220, 20);
            this.lblTicketCount.TabIndex = 4;
            this.lblTicketCount.Text = "Showing 9 tickets";
            this.lblTicketCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1240, 800);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Ticket Management - Admin Portal";

            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelAdminProfile.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelHeaderInfo.ResumeLayout(false);
            this.panelHeaderInfo.PerformLayout();
            this.flowDashboard.ResumeLayout(false);
            this.grpOverview.ResumeLayout(false);
            this.cardBuses.ResumeLayout(false);
            this.cardBuses.PerformLayout();
            this.cardTrips.ResumeLayout(false);
            this.cardTrips.PerformLayout();
            this.cardBookings.ResumeLayout(false);
            this.cardBookings.PerformLayout();
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.grpQuickActions.ResumeLayout(false);
            this.grpTripsSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();
            this.grpTicketVerify.ResumeLayout(false);
            this.grpTicketVerify.PerformLayout();

            this.panelUserManagement.ResumeLayout(false);
            this.panelUsersHeader.ResumeLayout(false);
            this.panelUsersHeader.PerformLayout();
            this.panelUsersToolbar.ResumeLayout(false);
            this.panelUsersToolbar.PerformLayout();
            this.panelUserActions.ResumeLayout(false);

            this.panelBusManagement.ResumeLayout(false);
            this.panelBusesHeader.ResumeLayout(false);
            this.panelBusesHeader.PerformLayout();
            this.flowBusMetrics.ResumeLayout(false);
            this.cardTotalBuses.ResumeLayout(false);
            this.cardTotalBuses.PerformLayout();
            this.cardActiveBuses.ResumeLayout(false);
            this.cardActiveBuses.PerformLayout();
            this.cardMaintenanceBuses.ResumeLayout(false);
            this.cardMaintenanceBuses.PerformLayout();
            this.cardInactiveBuses.ResumeLayout(false);
            this.cardInactiveBuses.PerformLayout();
            this.panelBusesToolbar.ResumeLayout(false);
            this.panelBusesToolbar.PerformLayout();
            this.panelBusActions.ResumeLayout(false);

            this.panelRouteManagement.ResumeLayout(false);
            this.panelRoutesHeader.ResumeLayout(false);
            this.panelRoutesHeader.PerformLayout();
            this.flowRouteMetrics.ResumeLayout(false);
            this.cardTotalRoutes.ResumeLayout(false);
            this.cardTotalRoutes.PerformLayout();
            this.cardActiveRoutes.ResumeLayout(false);
            this.cardActiveRoutes.PerformLayout();
            this.cardInactiveRoutes.ResumeLayout(false);
            this.cardInactiveRoutes.PerformLayout();
            this.cardTotalDistance.ResumeLayout(false);
            this.cardTotalDistance.PerformLayout();
            this.panelRoutesToolbar.ResumeLayout(false);
            this.panelRoutesToolbar.PerformLayout();
            this.panelRouteActions.ResumeLayout(false);

            this.panelBookingManagement.ResumeLayout(false);
            this.panelBookingsHeader.ResumeLayout(false);
            this.panelBookingsHeader.PerformLayout();
            this.flowBookingMetrics.ResumeLayout(false);
            this.cardTotalBookings.ResumeLayout(false);
            this.cardTotalBookings.PerformLayout();
            this.cardConfirmedBookings.ResumeLayout(false);
            this.cardConfirmedBookings.PerformLayout();
            this.cardPendingBookings.ResumeLayout(false);
            this.cardPendingBookings.PerformLayout();
            this.cardCancelledBookings.ResumeLayout(false);
            this.cardCancelledBookings.PerformLayout();
            this.cardTodayBookings.ResumeLayout(false);
            this.cardTodayBookings.PerformLayout();
            this.panelBookingsToolbar.ResumeLayout(false);
            this.panelBookingsToolbar.PerformLayout();
            this.panelBookingActions.ResumeLayout(false);

            this.panelTicketManagement.ResumeLayout(false);
            this.panelTicketsHeader.ResumeLayout(false);
            this.panelTicketsHeader.PerformLayout();
            this.flowTicketMetrics.ResumeLayout(false);
            this.cardTotalTickets.ResumeLayout(false);
            this.cardTotalTickets.PerformLayout();
            this.cardValidTickets.ResumeLayout(false);
            this.cardValidTickets.PerformLayout();
            this.cardBoardedTickets.ResumeLayout(false);
            this.cardBoardedTickets.PerformLayout();
            this.cardCancelledTickets.ResumeLayout(false);
            this.cardCancelledTickets.PerformLayout();
            this.cardTodayTickets.ResumeLayout(false);
            this.cardTodayTickets.PerformLayout();
            this.panelTicketsToolbar.ResumeLayout(false);
            this.panelTicketsToolbar.PerformLayout();
            this.panelTicketActions.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion
    }
}

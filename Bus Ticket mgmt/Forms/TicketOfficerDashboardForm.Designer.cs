using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class TicketOfficerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        // Top Navigation Bar
        private Panel panelTopBar;
        private Label lblAppIcon;
        private Label lblPortalTitle;
        private Panel panelOfficerProfile;
        private Label lblOfficerName;
        private Label lblOfficerRole;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;

        // Sidebar Navigation
        private Panel panelSidebar;
        private Label lblNavHeader;
        private Button btnNavDashboard;
        private Button btnNavIssueTicket;
        private Button btnNavVerifyTicket;
        private Button btnNavBookings;
        private Button btnNavTickets;
        private Button btnNavManifest;
        private Button btnNavPayments;
        private Button btnNavFeedback;
        private Button btnNavLogout;

        // Main Content Area
        private Panel panelMain;
        private Panel panelHeaderInfo;
        private Label lblPageHeading;
        private Label lblPageSubHeading;

        // 1. Dashboard Overview Components
        private FlowLayoutPanel flowDashboard;
        private GroupBox grpOverview;
        private Panel cardTicketsToday;
        private Label lblMetricTicketsTodayVal;
        private Label lblMetricTicketsTodayTitle;
        private Panel cardBoarded;
        private Label lblMetricBoardedVal;
        private Label lblMetricBoardedTitle;
        private Panel cardPendingBoarding;
        private Label lblMetricPendingVal;
        private Label lblMetricPendingTitle;
        private Panel cardRevenueToday;
        private Label lblMetricRevenueTodayVal;
        private Label lblMetricRevenueTodayTitle;

        private GroupBox grpQuickActions;
        private Button btnQuickIssue;
        private Button btnQuickScanner;
        private Button btnQuickManifest;
        private Button btnQuickReceipt;
        private Button btnQuickHelpdesk;

        private GroupBox grpTripsSchedule;
        private DataGridView dgvTrips;

        private GroupBox grpTicketVerify;
        private Label lblTicketSearchPrompt;
        private ModernTextBox txtTicketNumber;
        private ModernButton btnVerifyTicket;
        private Label lblVerifyResult;

        // 2. Issue Walk-In Ticket Components
        private Panel panelIssueTicket;
        private Panel panelIssueHeader;
        private Label lblIssueTitle;
        private Label lblIssueSubtitle;
        private Panel panelIssueFormCard;
        private Label lblIssueFormHeader;
        private Label lblIssueName;
        private TextBox txtIssueName;
        private Label lblIssuePhone;
        private TextBox txtIssuePhone;
        private Label lblIssueEmail;
        private TextBox txtIssueEmail;
        private Label lblIssueRoute;
        private ComboBox cmbIssueRoute;
        private Label lblIssueDate;
        private DateTimePicker dtpIssueDate;
        private Label lblIssueTime;
        private ComboBox cmbIssueTime;
        private Label lblIssueBus;
        private ComboBox cmbIssueBus;
        private Label lblIssueGate;
        private ComboBox cmbIssueGate;
        private Label lblIssueSeat;
        private NumericUpDown numIssueSeat;
        private Label lblIssueFare;
        private NumericUpDown numIssueFare;
        private Label lblIssuePaymentMethod;
        private ComboBox cmbIssuePaymentMethod;
        private Label lblIssuePaymentStatus;
        private ComboBox cmbIssuePaymentStatus;
        private Label lblIssueLuggage;
        private TextBox txtIssueLuggage;
        private Label lblIssueNotes;
        private TextBox txtIssueNotes;
        private Button btnConfirmIssueTicket;
        private Button btnClearIssueForm;
        private Button btnOpenAdvancedBooking;

        private Panel panelIssueSummaryCard;
        private Label lblIssueSummaryHeader;
        private Label lblSummaryDetails;
        private Label lblPreviewTitle;
        private TextBox txtTicketPreview;

        // 3. Verification & Boarding Station Components
        private Panel panelVerifyBoarding;
        private Panel panelVerifyHeader;
        private Label lblVerifyTitle;
        private Label lblVerifySubtitle;
        private Panel panelVerifyToolbar;
        private TextBox txtVerifySearch;
        private Button btnVerifyLookup;
        private Button btnOpenModalScanner;
        private Panel panelVerifyBanner;
        private Label lblVerifyBannerTitle;
        private Label lblVerifyBannerSub;
        private Panel panelVerifyDossier;
        private Label lblDossierTitle;
        private Label lblDossierContent;
        private Panel panelVerifyActions;
        private Button btnMarkBoardedAction;
        private Button btnPrintVerificationPass;
        private Button btnReportDiscrepancy;

        // 4. Booking Management Section
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

        // 5. Ticket Management Section
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

        // 6. Passenger Manifest Section
        private Panel panelManifest;
        private Panel panelManifestHeader;
        private Label lblManifestTitle;
        private Label lblManifestSubtitle;
        private Panel panelManifestToolbar;
        private Label lblManifestRoutePrompt;
        private ComboBox cmbManifestRoute;
        private Label lblManifestDatePrompt;
        private DateTimePicker dtpManifestDate;
        private Button btnLoadManifest;

        private FlowLayoutPanel flowManifestMetrics;
        private Panel cardManifestTotal;
        private Label lblManifestTotalVal;
        private Label lblManifestTotalTitle;
        private Panel cardManifestBoarded;
        private Label lblManifestBoardedVal;
        private Label lblManifestBoardedTitle;
        private Panel cardManifestPending;
        private Label lblManifestPendingVal;
        private Label lblManifestPendingTitle;
        private Panel cardManifestNoShow;
        private Label lblManifestNoShowVal;
        private Label lblManifestNoShowTitle;

        private ListView lvManifest;
        private ColumnHeader colManSeat;
        private ColumnHeader colManPassenger;
        private ColumnHeader colManPhone;
        private ColumnHeader colManTicketId;
        private ColumnHeader colManBookingId;
        private ColumnHeader colManGate;
        private ColumnHeader colManStatus;
        private ColumnHeader colManBoardedTime;
        private ColumnHeader colManVerifiedBy;

        private Panel panelManifestActions;
        private Button btnManifestMarkBoarded;
        private Button btnManifestMarkAbsent;
        private Button btnPrintManifest;
        private Button btnVerifyManifestPassenger;
        private Label lblManifestCount;

        // 7. Counter Payments & Cashier Section
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

        // 8. Customer Helpdesk & Inquiries Section
        private Panel panelFeedback;
        private Panel panelFeedbackHeader;
        private Label lblFeedbackTitle;
        private Label lblFeedbackSubtitle;
        private Button btnNewInquiry;

        private FlowLayoutPanel flowFeedbackMetrics;
        private Panel cardInqTotal;
        private Label lblInqTotalVal;
        private Label lblInqTotalTitle;
        private Panel cardInqPending;
        private Label lblInqPendingVal;
        private Label lblInqPendingTitle;
        private Panel cardInqResolved;
        private Label lblInqResolvedVal;
        private Label lblInqResolvedTitle;

        private Panel panelFeedbackToolbar;
        private TextBox txtSearchInquiries;
        private ComboBox cmbInquiryStatusFilter;
        private Button btnRefreshInquiries;

        private ListView lvInquiries;
        private ColumnHeader colInqId;
        private ColumnHeader colInqPassenger;
        private ColumnHeader colInqPhone;
        private ColumnHeader colInqCategory;
        private ColumnHeader colInqSubject;
        private ColumnHeader colInqStatus;
        private ColumnHeader colInqDate;
        private ColumnHeader colInqOfficer;

        private Panel panelFeedbackActions;
        private Button btnResolveInquiry;
        private Button btnViewInquiryDetails;
        private Label lblInquiryCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.lblAppIcon = new System.Windows.Forms.Label();
            this.lblPortalTitle = new System.Windows.Forms.Label();
            this.panelOfficerProfile = new System.Windows.Forms.Panel();
            this.lblOfficerName = new System.Windows.Forms.Label();
            this.lblOfficerRole = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelSidebar = new System.Windows.Forms.Panel();
            this.lblNavHeader = new System.Windows.Forms.Label();
            this.btnNavDashboard = new System.Windows.Forms.Button();
            this.btnNavIssueTicket = new System.Windows.Forms.Button();
            this.btnNavVerifyTicket = new System.Windows.Forms.Button();
            this.btnNavBookings = new System.Windows.Forms.Button();
            this.btnNavTickets = new System.Windows.Forms.Button();
            this.btnNavManifest = new System.Windows.Forms.Button();
            this.btnNavPayments = new System.Windows.Forms.Button();
            this.btnNavFeedback = new System.Windows.Forms.Button();
            this.btnNavLogout = new System.Windows.Forms.Button();

            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeaderInfo = new System.Windows.Forms.Panel();
            this.lblPageHeading = new System.Windows.Forms.Label();
            this.lblPageSubHeading = new System.Windows.Forms.Label();

            // 1. Dashboard
            this.flowDashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.grpOverview = new System.Windows.Forms.GroupBox();
            this.cardTicketsToday = new System.Windows.Forms.Panel();
            this.lblMetricTicketsTodayVal = new System.Windows.Forms.Label();
            this.lblMetricTicketsTodayTitle = new System.Windows.Forms.Label();
            this.cardBoarded = new System.Windows.Forms.Panel();
            this.lblMetricBoardedVal = new System.Windows.Forms.Label();
            this.lblMetricBoardedTitle = new System.Windows.Forms.Label();
            this.cardPendingBoarding = new System.Windows.Forms.Panel();
            this.lblMetricPendingVal = new System.Windows.Forms.Label();
            this.lblMetricPendingTitle = new System.Windows.Forms.Label();
            this.cardRevenueToday = new System.Windows.Forms.Panel();
            this.lblMetricRevenueTodayVal = new System.Windows.Forms.Label();
            this.lblMetricRevenueTodayTitle = new System.Windows.Forms.Label();

            this.grpQuickActions = new System.Windows.Forms.GroupBox();
            this.btnQuickIssue = new System.Windows.Forms.Button();
            this.btnQuickScanner = new System.Windows.Forms.Button();
            this.btnQuickManifest = new System.Windows.Forms.Button();
            this.btnQuickReceipt = new System.Windows.Forms.Button();
            this.btnQuickHelpdesk = new System.Windows.Forms.Button();

            this.grpTripsSchedule = new System.Windows.Forms.GroupBox();
            this.dgvTrips = new System.Windows.Forms.DataGridView();

            this.grpTicketVerify = new System.Windows.Forms.GroupBox();
            this.lblTicketSearchPrompt = new System.Windows.Forms.Label();
            this.txtTicketNumber = new Bus_Ticket_mgmt.ModernTextBox();
            this.btnVerifyTicket = new Bus_Ticket_mgmt.ModernButton();
            this.lblVerifyResult = new System.Windows.Forms.Label();

            // 2. Issue Walk-In Ticket
            this.panelIssueTicket = new System.Windows.Forms.Panel();
            this.panelIssueHeader = new System.Windows.Forms.Panel();
            this.lblIssueTitle = new System.Windows.Forms.Label();
            this.lblIssueSubtitle = new System.Windows.Forms.Label();
            this.panelIssueFormCard = new System.Windows.Forms.Panel();
            this.lblIssueFormHeader = new System.Windows.Forms.Label();
            this.lblIssueName = new System.Windows.Forms.Label();
            this.txtIssueName = new System.Windows.Forms.TextBox();
            this.lblIssuePhone = new System.Windows.Forms.Label();
            this.txtIssuePhone = new System.Windows.Forms.TextBox();
            this.lblIssueEmail = new System.Windows.Forms.Label();
            this.txtIssueEmail = new System.Windows.Forms.TextBox();
            this.lblIssueRoute = new System.Windows.Forms.Label();
            this.cmbIssueRoute = new System.Windows.Forms.ComboBox();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
            this.lblIssueTime = new System.Windows.Forms.Label();
            this.cmbIssueTime = new System.Windows.Forms.ComboBox();
            this.lblIssueBus = new System.Windows.Forms.Label();
            this.cmbIssueBus = new System.Windows.Forms.ComboBox();
            this.lblIssueGate = new System.Windows.Forms.Label();
            this.cmbIssueGate = new System.Windows.Forms.ComboBox();
            this.lblIssueSeat = new System.Windows.Forms.Label();
            this.numIssueSeat = new System.Windows.Forms.NumericUpDown();
            this.lblIssueFare = new System.Windows.Forms.Label();
            this.numIssueFare = new System.Windows.Forms.NumericUpDown();
            this.lblIssuePaymentMethod = new System.Windows.Forms.Label();
            this.cmbIssuePaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblIssuePaymentStatus = new System.Windows.Forms.Label();
            this.cmbIssuePaymentStatus = new System.Windows.Forms.ComboBox();
            this.lblIssueLuggage = new System.Windows.Forms.Label();
            this.txtIssueLuggage = new System.Windows.Forms.TextBox();
            this.lblIssueNotes = new System.Windows.Forms.Label();
            this.txtIssueNotes = new System.Windows.Forms.TextBox();
            this.btnConfirmIssueTicket = new System.Windows.Forms.Button();
            this.btnClearIssueForm = new System.Windows.Forms.Button();
            this.btnOpenAdvancedBooking = new System.Windows.Forms.Button();

            this.panelIssueSummaryCard = new System.Windows.Forms.Panel();
            this.lblIssueSummaryHeader = new System.Windows.Forms.Label();
            this.lblSummaryDetails = new System.Windows.Forms.Label();
            this.lblPreviewTitle = new System.Windows.Forms.Label();
            this.txtTicketPreview = new System.Windows.Forms.TextBox();

            // 3. Verification & Boarding
            this.panelVerifyBoarding = new System.Windows.Forms.Panel();
            this.panelVerifyHeader = new System.Windows.Forms.Panel();
            this.lblVerifyTitle = new System.Windows.Forms.Label();
            this.lblVerifySubtitle = new System.Windows.Forms.Label();
            this.panelVerifyToolbar = new System.Windows.Forms.Panel();
            this.txtVerifySearch = new System.Windows.Forms.TextBox();
            this.btnVerifyLookup = new System.Windows.Forms.Button();
            this.btnOpenModalScanner = new System.Windows.Forms.Button();
            this.panelVerifyBanner = new System.Windows.Forms.Panel();
            this.lblVerifyBannerTitle = new System.Windows.Forms.Label();
            this.lblVerifyBannerSub = new System.Windows.Forms.Label();
            this.panelVerifyDossier = new System.Windows.Forms.Panel();
            this.lblDossierTitle = new System.Windows.Forms.Label();
            this.lblDossierContent = new System.Windows.Forms.Label();
            this.panelVerifyActions = new System.Windows.Forms.Panel();
            this.btnMarkBoardedAction = new System.Windows.Forms.Button();
            this.btnPrintVerificationPass = new System.Windows.Forms.Button();
            this.btnReportDiscrepancy = new System.Windows.Forms.Button();

            // 4. Booking Management
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

            // 5. Ticket Management
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

            // 6. Manifest
            this.panelManifest = new System.Windows.Forms.Panel();
            this.panelManifestHeader = new System.Windows.Forms.Panel();
            this.lblManifestTitle = new System.Windows.Forms.Label();
            this.lblManifestSubtitle = new System.Windows.Forms.Label();
            this.panelManifestToolbar = new System.Windows.Forms.Panel();
            this.lblManifestRoutePrompt = new System.Windows.Forms.Label();
            this.cmbManifestRoute = new System.Windows.Forms.ComboBox();
            this.lblManifestDatePrompt = new System.Windows.Forms.Label();
            this.dtpManifestDate = new System.Windows.Forms.DateTimePicker();
            this.btnLoadManifest = new System.Windows.Forms.Button();

            this.flowManifestMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.cardManifestTotal = new System.Windows.Forms.Panel();
            this.lblManifestTotalVal = new System.Windows.Forms.Label();
            this.lblManifestTotalTitle = new System.Windows.Forms.Label();
            this.cardManifestBoarded = new System.Windows.Forms.Panel();
            this.lblManifestBoardedVal = new System.Windows.Forms.Label();
            this.lblManifestBoardedTitle = new System.Windows.Forms.Label();
            this.cardManifestPending = new System.Windows.Forms.Panel();
            this.lblManifestPendingVal = new System.Windows.Forms.Label();
            this.lblManifestPendingTitle = new System.Windows.Forms.Label();
            this.cardManifestNoShow = new System.Windows.Forms.Panel();
            this.lblManifestNoShowVal = new System.Windows.Forms.Label();
            this.lblManifestNoShowTitle = new System.Windows.Forms.Label();

            this.lvManifest = new System.Windows.Forms.ListView();
            this.colManSeat = new System.Windows.Forms.ColumnHeader();
            this.colManPassenger = new System.Windows.Forms.ColumnHeader();
            this.colManPhone = new System.Windows.Forms.ColumnHeader();
            this.colManTicketId = new System.Windows.Forms.ColumnHeader();
            this.colManBookingId = new System.Windows.Forms.ColumnHeader();
            this.colManGate = new System.Windows.Forms.ColumnHeader();
            this.colManStatus = new System.Windows.Forms.ColumnHeader();
            this.colManBoardedTime = new System.Windows.Forms.ColumnHeader();
            this.colManVerifiedBy = new System.Windows.Forms.ColumnHeader();

            this.panelManifestActions = new System.Windows.Forms.Panel();
            this.btnManifestMarkBoarded = new System.Windows.Forms.Button();
            this.btnManifestMarkAbsent = new System.Windows.Forms.Button();
            this.btnPrintManifest = new System.Windows.Forms.Button();
            this.btnVerifyManifestPassenger = new System.Windows.Forms.Button();
            this.lblManifestCount = new System.Windows.Forms.Label();

            // 7. Payments
            this.panelPayments = new System.Windows.Forms.Panel();
            this.panelPaymentsHeader = new System.Windows.Forms.Panel();
            this.lblPaymentsTitle = new System.Windows.Forms.Label();
            this.lblPaymentsSubtitle = new System.Windows.Forms.Label();

            this.flowPaymentMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.cardPayTotal = new System.Windows.Forms.Panel();
            this.lblPayTotalVal = new System.Windows.Forms.Label();
            this.lblPayTotalTitle = new System.Windows.Forms.Label();
            this.cardPayCash = new System.Windows.Forms.Panel();
            this.lblPayCashVal = new System.Windows.Forms.Label();
            this.lblPayCashTitle = new System.Windows.Forms.Label();
            this.cardPayDigital = new System.Windows.Forms.Panel();
            this.lblPayDigitalVal = new System.Windows.Forms.Label();
            this.lblPayDigitalTitle = new System.Windows.Forms.Label();
            this.cardPayRefunds = new System.Windows.Forms.Panel();
            this.lblPayRefundsVal = new System.Windows.Forms.Label();
            this.lblPayRefundsTitle = new System.Windows.Forms.Label();

            this.panelPaymentsToolbar = new System.Windows.Forms.Panel();
            this.txtSearchPayments = new System.Windows.Forms.TextBox();
            this.cmbPaymentMethodFilter = new System.Windows.Forms.ComboBox();
            this.cmbPaymentStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshPayments = new System.Windows.Forms.Button();

            this.lvPayments = new System.Windows.Forms.ListView();
            this.colPayReceipt = new System.Windows.Forms.ColumnHeader();
            this.colPayBooking = new System.Windows.Forms.ColumnHeader();
            this.colPayTicket = new System.Windows.Forms.ColumnHeader();
            this.colPayPassenger = new System.Windows.Forms.ColumnHeader();
            this.colPayRoute = new System.Windows.Forms.ColumnHeader();
            this.colPayAmount = new System.Windows.Forms.ColumnHeader();
            this.colPayMethod = new System.Windows.Forms.ColumnHeader();
            this.colPayStatus = new System.Windows.Forms.ColumnHeader();
            this.colPayDate = new System.Windows.Forms.ColumnHeader();
            this.colPayCashier = new System.Windows.Forms.ColumnHeader();

            this.panelPaymentActions = new System.Windows.Forms.Panel();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.btnRecordPayment = new System.Windows.Forms.Button();
            this.btnProcessRefund = new System.Windows.Forms.Button();
            this.lblPaymentCount = new System.Windows.Forms.Label();

            // 8. Helpdesk
            this.panelFeedback = new System.Windows.Forms.Panel();
            this.panelFeedbackHeader = new System.Windows.Forms.Panel();
            this.lblFeedbackTitle = new System.Windows.Forms.Label();
            this.lblFeedbackSubtitle = new System.Windows.Forms.Label();
            this.btnNewInquiry = new System.Windows.Forms.Button();

            this.flowFeedbackMetrics = new System.Windows.Forms.FlowLayoutPanel();
            this.cardInqTotal = new System.Windows.Forms.Panel();
            this.lblInqTotalVal = new System.Windows.Forms.Label();
            this.lblInqTotalTitle = new System.Windows.Forms.Label();
            this.cardInqPending = new System.Windows.Forms.Panel();
            this.lblInqPendingVal = new System.Windows.Forms.Label();
            this.lblInqPendingTitle = new System.Windows.Forms.Label();
            this.cardInqResolved = new System.Windows.Forms.Panel();
            this.lblInqResolvedVal = new System.Windows.Forms.Label();
            this.lblInqResolvedTitle = new System.Windows.Forms.Label();

            this.panelFeedbackToolbar = new System.Windows.Forms.Panel();
            this.txtSearchInquiries = new System.Windows.Forms.TextBox();
            this.cmbInquiryStatusFilter = new System.Windows.Forms.ComboBox();
            this.btnRefreshInquiries = new System.Windows.Forms.Button();

            this.lvInquiries = new System.Windows.Forms.ListView();
            this.colInqId = new System.Windows.Forms.ColumnHeader();
            this.colInqPassenger = new System.Windows.Forms.ColumnHeader();
            this.colInqPhone = new System.Windows.Forms.ColumnHeader();
            this.colInqCategory = new System.Windows.Forms.ColumnHeader();
            this.colInqSubject = new System.Windows.Forms.ColumnHeader();
            this.colInqStatus = new System.Windows.Forms.ColumnHeader();
            this.colInqDate = new System.Windows.Forms.ColumnHeader();
            this.colInqOfficer = new System.Windows.Forms.ColumnHeader();

            this.panelFeedbackActions = new System.Windows.Forms.Panel();
            this.btnResolveInquiry = new System.Windows.Forms.Button();
            this.btnViewInquiryDetails = new System.Windows.Forms.Button();
            this.lblInquiryCount = new System.Windows.Forms.Label();

            // SuspendLayouts
            this.panelTopBar.SuspendLayout();
            this.panelOfficerProfile.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panelHeaderInfo.SuspendLayout();
            this.flowDashboard.SuspendLayout();
            this.grpOverview.SuspendLayout();
            this.cardTicketsToday.SuspendLayout();
            this.cardBoarded.SuspendLayout();
            this.cardPendingBoarding.SuspendLayout();
            this.cardRevenueToday.SuspendLayout();
            this.grpQuickActions.SuspendLayout();
            this.grpTripsSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).BeginInit();
            this.grpTicketVerify.SuspendLayout();

            this.panelIssueTicket.SuspendLayout();
            this.panelIssueHeader.SuspendLayout();
            this.panelIssueFormCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIssueSeat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIssueFare)).BeginInit();
            this.panelIssueSummaryCard.SuspendLayout();

            this.panelVerifyBoarding.SuspendLayout();
            this.panelVerifyHeader.SuspendLayout();
            this.panelVerifyToolbar.SuspendLayout();
            this.panelVerifyBanner.SuspendLayout();
            this.panelVerifyDossier.SuspendLayout();
            this.panelVerifyActions.SuspendLayout();

            this.panelBookingManagement.SuspendLayout();
            this.panelBookingsHeader.SuspendLayout();
            this.flowBookingMetrics.SuspendLayout();
            this.panelBookingsToolbar.SuspendLayout();
            this.panelBookingActions.SuspendLayout();

            this.panelTicketManagement.SuspendLayout();
            this.panelTicketsHeader.SuspendLayout();
            this.flowTicketMetrics.SuspendLayout();
            this.panelTicketsToolbar.SuspendLayout();
            this.panelTicketActions.SuspendLayout();

            this.panelManifest.SuspendLayout();
            this.panelManifestHeader.SuspendLayout();
            this.panelManifestToolbar.SuspendLayout();
            this.flowManifestMetrics.SuspendLayout();
            this.panelManifestActions.SuspendLayout();

            this.panelPayments.SuspendLayout();
            this.panelPaymentsHeader.SuspendLayout();
            this.flowPaymentMetrics.SuspendLayout();
            this.panelPaymentsToolbar.SuspendLayout();
            this.panelPaymentActions.SuspendLayout();

            this.panelFeedback.SuspendLayout();
            this.panelFeedbackHeader.SuspendLayout();
            this.flowFeedbackMetrics.SuspendLayout();
            this.panelFeedbackToolbar.SuspendLayout();
            this.panelFeedbackActions.SuspendLayout();
            this.SuspendLayout();

            // ==========================================
            // TOP BAR
            // ==========================================
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelTopBar.Controls.Add(this.lblAppIcon);
            this.panelTopBar.Controls.Add(this.lblPortalTitle);
            this.panelTopBar.Controls.Add(this.panelOfficerProfile);
            this.panelTopBar.Controls.Add(this.btnMinimize);
            this.panelTopBar.Controls.Add(this.btnMaximize);
            this.panelTopBar.Controls.Add(this.btnClose);
            this.panelTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopBar.Height = 44;
            this.panelTopBar.Location = new System.Drawing.Point(0, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(1260, 44);
            this.panelTopBar.TabIndex = 0;

            this.lblAppIcon.Location = new System.Drawing.Point(14, 4);
            this.lblAppIcon.Name = "lblAppIcon";
            this.lblAppIcon.Size = new System.Drawing.Size(32, 36);

            this.lblPortalTitle.AutoSize = true;
            this.lblPortalTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPortalTitle.ForeColor = System.Drawing.Color.White;
            this.lblPortalTitle.Location = new System.Drawing.Point(52, 12);
            this.lblPortalTitle.Name = "lblPortalTitle";
            this.lblPortalTitle.Size = new System.Drawing.Size(340, 19);
            this.lblPortalTitle.Text = "Bus Ticket Management  |  Ticket Officer Portal";

            this.panelOfficerProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOfficerProfile.Controls.Add(this.lblOfficerName);
            this.panelOfficerProfile.Controls.Add(this.lblOfficerRole);
            this.panelOfficerProfile.Location = new System.Drawing.Point(900, 4);
            this.panelOfficerProfile.Name = "panelOfficerProfile";
            this.panelOfficerProfile.Size = new System.Drawing.Size(210, 36);

            this.lblOfficerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOfficerName.ForeColor = System.Drawing.Color.White;
            this.lblOfficerName.Location = new System.Drawing.Point(0, 2);
            this.lblOfficerName.Name = "lblOfficerName";
            this.lblOfficerName.Size = new System.Drawing.Size(200, 16);
            this.lblOfficerName.Text = "Marta Tadesse";
            this.lblOfficerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.lblOfficerRole.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOfficerRole.ForeColor = System.Drawing.Color.FromArgb(56, 189, 248);
            this.lblOfficerRole.Location = new System.Drawing.Point(0, 18);
            this.lblOfficerRole.Name = "lblOfficerRole";
            this.lblOfficerRole.Size = new System.Drawing.Size(200, 14);
            this.lblOfficerRole.Text = "Ticket Officer • Terminal Desk 01";
            this.lblOfficerRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnMinimize.Location = new System.Drawing.Point(1122, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 44);
            this.btnMinimize.Text = "—";
            this.btnMinimize.UseVisualStyleBackColor = true;

            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnMaximize.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnMaximize.Location = new System.Drawing.Point(1168, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(46, 44);
            this.btnMaximize.Text = "□";
            this.btnMaximize.UseVisualStyleBackColor = true;

            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnClose.Location = new System.Drawing.Point(1214, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 44);
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;

            // ==========================================
            // SIDEBAR
            // ==========================================
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(245, 247, 250);
            this.panelSidebar.Controls.Add(this.btnNavLogout);
            this.panelSidebar.Controls.Add(this.btnNavFeedback);
            this.panelSidebar.Controls.Add(this.btnNavPayments);
            this.panelSidebar.Controls.Add(this.btnNavManifest);
            this.panelSidebar.Controls.Add(this.btnNavTickets);
            this.panelSidebar.Controls.Add(this.btnNavBookings);
            this.panelSidebar.Controls.Add(this.btnNavVerifyTicket);
            this.panelSidebar.Controls.Add(this.btnNavIssueTicket);
            this.panelSidebar.Controls.Add(this.btnNavDashboard);
            this.panelSidebar.Controls.Add(this.lblNavHeader);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 44);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(230, 776);

            this.lblNavHeader.AutoSize = true;
            this.lblNavHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblNavHeader.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblNavHeader.Location = new System.Drawing.Point(16, 16);
            this.lblNavHeader.Name = "lblNavHeader";
            this.lblNavHeader.Size = new System.Drawing.Size(126, 13);
            this.lblNavHeader.Text = "TERMINAL DESK MENU";

            this.btnNavDashboard.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnNavDashboard.FlatAppearance.BorderSize = 0;
            this.btnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavDashboard.ForeColor = System.Drawing.Color.White;
            this.btnNavDashboard.Location = new System.Drawing.Point(10, 40);
            this.btnNavDashboard.Name = "btnNavDashboard";
            this.btnNavDashboard.Size = new System.Drawing.Size(210, 36);
            this.btnNavDashboard.Text = "📊  Counter Overview";
            this.btnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavIssueTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnNavIssueTicket.FlatAppearance.BorderSize = 0;
            this.btnNavIssueTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavIssueTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavIssueTicket.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavIssueTicket.Location = new System.Drawing.Point(10, 80);
            this.btnNavIssueTicket.Name = "btnNavIssueTicket";
            this.btnNavIssueTicket.Size = new System.Drawing.Size(210, 34);
            this.btnNavIssueTicket.Text = "🎫  Issue Walk-in Ticket";
            this.btnNavIssueTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavVerifyTicket.BackColor = System.Drawing.Color.Transparent;
            this.btnNavVerifyTicket.FlatAppearance.BorderSize = 0;
            this.btnNavVerifyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavVerifyTicket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavVerifyTicket.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavVerifyTicket.Location = new System.Drawing.Point(10, 118);
            this.btnNavVerifyTicket.Name = "btnNavVerifyTicket";
            this.btnNavVerifyTicket.Size = new System.Drawing.Size(210, 34);
            this.btnNavVerifyTicket.Text = "🔍  Verify & Boarding Pass";
            this.btnNavVerifyTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavBookings.BackColor = System.Drawing.Color.Transparent;
            this.btnNavBookings.FlatAppearance.BorderSize = 0;
            this.btnNavBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBookings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavBookings.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavBookings.Location = new System.Drawing.Point(10, 156);
            this.btnNavBookings.Name = "btnNavBookings";
            this.btnNavBookings.Size = new System.Drawing.Size(210, 34);
            this.btnNavBookings.Text = "📋  Bookings Desk";
            this.btnNavBookings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavTickets.BackColor = System.Drawing.Color.Transparent;
            this.btnNavTickets.FlatAppearance.BorderSize = 0;
            this.btnNavTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTickets.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavTickets.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavTickets.Location = new System.Drawing.Point(10, 194);
            this.btnNavTickets.Name = "btnNavTickets";
            this.btnNavTickets.Size = new System.Drawing.Size(210, 34);
            this.btnNavTickets.Text = "🏷️  Tickets Directory";
            this.btnNavTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavManifest.BackColor = System.Drawing.Color.Transparent;
            this.btnNavManifest.FlatAppearance.BorderSize = 0;
            this.btnNavManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavManifest.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavManifest.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavManifest.Location = new System.Drawing.Point(10, 232);
            this.btnNavManifest.Name = "btnNavManifest";
            this.btnNavManifest.Size = new System.Drawing.Size(210, 34);
            this.btnNavManifest.Text = "🚌  Passenger Manifest";
            this.btnNavManifest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavPayments.BackColor = System.Drawing.Color.Transparent;
            this.btnNavPayments.FlatAppearance.BorderSize = 0;
            this.btnNavPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayments.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavPayments.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavPayments.Location = new System.Drawing.Point(10, 270);
            this.btnNavPayments.Name = "btnNavPayments";
            this.btnNavPayments.Size = new System.Drawing.Size(210, 34);
            this.btnNavPayments.Text = "💳  Cashier & Receipts";
            this.btnNavPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavFeedback.BackColor = System.Drawing.Color.Transparent;
            this.btnNavFeedback.FlatAppearance.BorderSize = 0;
            this.btnNavFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFeedback.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNavFeedback.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnNavFeedback.Location = new System.Drawing.Point(10, 308);
            this.btnNavFeedback.Name = "btnNavFeedback";
            this.btnNavFeedback.Size = new System.Drawing.Size(210, 34);
            this.btnNavFeedback.Text = "💬  Customer Helpdesk";
            this.btnNavFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnNavLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNavLogout.BackColor = System.Drawing.Color.FromArgb(254, 242, 242);
            this.btnNavLogout.FlatAppearance.BorderSize = 0;
            this.btnNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnNavLogout.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnNavLogout.Location = new System.Drawing.Point(10, 720);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(210, 40);
            this.btnNavLogout.Text = "🚪  Sign Out";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ==========================================
            // MAIN CONTAINER
            // ==========================================
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelMain.Controls.Add(this.panelFeedback);
            this.panelMain.Controls.Add(this.panelPayments);
            this.panelMain.Controls.Add(this.panelManifest);
            this.panelMain.Controls.Add(this.panelTicketManagement);
            this.panelMain.Controls.Add(this.panelBookingManagement);
            this.panelMain.Controls.Add(this.panelVerifyBoarding);
            this.panelMain.Controls.Add(this.panelIssueTicket);
            this.panelMain.Controls.Add(this.flowDashboard);
            this.panelMain.Controls.Add(this.panelHeaderInfo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(230, 44);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(20, 16, 20, 20);
            this.panelMain.Size = new System.Drawing.Size(1030, 776);

            // Header info
            this.panelHeaderInfo.Controls.Add(this.lblPageSubHeading);
            this.panelHeaderInfo.Controls.Add(this.lblPageHeading);
            this.panelHeaderInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeaderInfo.Location = new System.Drawing.Point(20, 16);
            this.panelHeaderInfo.Name = "panelHeaderInfo";
            this.panelHeaderInfo.Size = new System.Drawing.Size(990, 56);

            this.lblPageHeading.AutoSize = true;
            this.lblPageHeading.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPageHeading.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPageHeading.Location = new System.Drawing.Point(0, 0);
            this.lblPageHeading.Name = "lblPageHeading";
            this.lblPageHeading.Size = new System.Drawing.Size(430, 30);
            this.lblPageHeading.Text = "Ticket Counter Overview & Boarding Desk";

            this.lblPageSubHeading.AutoSize = true;
            this.lblPageSubHeading.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPageSubHeading.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPageSubHeading.Location = new System.Drawing.Point(2, 33);
            this.lblPageSubHeading.Name = "lblPageSubHeading";
            this.lblPageSubHeading.Size = new System.Drawing.Size(550, 15);
            this.lblPageSubHeading.Text = "Terminal Desk 01  •  Ethiopian Intercity Bus Terminal  •  Live Passenger Services & Boarding Verification";

            // ==========================================
            // 1. DASHBOARD OVERVIEW VIEW
            // ==========================================
            this.flowDashboard.AutoScroll = true;
            this.flowDashboard.Controls.Add(this.grpOverview);
            this.flowDashboard.Controls.Add(this.grpQuickActions);
            this.flowDashboard.Controls.Add(this.grpTicketVerify);
            this.flowDashboard.Controls.Add(this.grpTripsSchedule);
            this.flowDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowDashboard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowDashboard.Location = new System.Drawing.Point(20, 72);
            this.flowDashboard.Name = "flowDashboard";
            this.flowDashboard.Size = new System.Drawing.Size(990, 684);
            this.flowDashboard.WrapContents = false;

            // grpOverview
            this.grpOverview.Controls.Add(this.cardRevenueToday);
            this.grpOverview.Controls.Add(this.cardPendingBoarding);
            this.grpOverview.Controls.Add(this.cardBoarded);
            this.grpOverview.Controls.Add(this.cardTicketsToday);
            this.grpOverview.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpOverview.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpOverview.Location = new System.Drawing.Point(3, 3);
            this.grpOverview.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.grpOverview.Name = "grpOverview";
            this.grpOverview.Size = new System.Drawing.Size(975, 116);
            this.grpOverview.Text = "TODAY\'S TERMINAL STATS";

            // cardTicketsToday
            this.cardTicketsToday.BackColor = System.Drawing.Color.White;
            this.cardTicketsToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardTicketsToday.Controls.Add(this.lblMetricTicketsTodayVal);
            this.cardTicketsToday.Controls.Add(this.lblMetricTicketsTodayTitle);
            this.cardTicketsToday.Location = new System.Drawing.Point(14, 25);
            this.cardTicketsToday.Name = "cardTicketsToday";
            this.cardTicketsToday.Size = new System.Drawing.Size(224, 76);

            this.lblMetricTicketsTodayVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMetricTicketsTodayVal.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblMetricTicketsTodayVal.Location = new System.Drawing.Point(10, 8);
            this.lblMetricTicketsTodayVal.Name = "lblMetricTicketsTodayVal";
            this.lblMetricTicketsTodayVal.Size = new System.Drawing.Size(200, 34);
            this.lblMetricTicketsTodayVal.Text = "0";

            this.lblMetricTicketsTodayTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMetricTicketsTodayTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricTicketsTodayTitle.Location = new System.Drawing.Point(11, 46);
            this.lblMetricTicketsTodayTitle.Name = "lblMetricTicketsTodayTitle";
            this.lblMetricTicketsTodayTitle.Size = new System.Drawing.Size(200, 18);
            this.lblMetricTicketsTodayTitle.Text = "TICKETS ISSUED TODAY";

            // cardBoarded
            this.cardBoarded.BackColor = System.Drawing.Color.White;
            this.cardBoarded.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardBoarded.Controls.Add(this.lblMetricBoardedVal);
            this.cardBoarded.Controls.Add(this.lblMetricBoardedTitle);
            this.cardBoarded.Location = new System.Drawing.Point(252, 25);
            this.cardBoarded.Name = "cardBoarded";
            this.cardBoarded.Size = new System.Drawing.Size(224, 76);

            this.lblMetricBoardedVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMetricBoardedVal.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.lblMetricBoardedVal.Location = new System.Drawing.Point(10, 8);
            this.lblMetricBoardedVal.Name = "lblMetricBoardedVal";
            this.lblMetricBoardedVal.Size = new System.Drawing.Size(200, 34);
            this.lblMetricBoardedVal.Text = "0";

            this.lblMetricBoardedTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMetricBoardedTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricBoardedTitle.Location = new System.Drawing.Point(11, 46);
            this.lblMetricBoardedTitle.Name = "lblMetricBoardedTitle";
            this.lblMetricBoardedTitle.Size = new System.Drawing.Size(200, 18);
            this.lblMetricBoardedTitle.Text = "PASSENGERS BOARDED";

            // cardPendingBoarding
            this.cardPendingBoarding.BackColor = System.Drawing.Color.White;
            this.cardPendingBoarding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardPendingBoarding.Controls.Add(this.lblMetricPendingVal);
            this.cardPendingBoarding.Controls.Add(this.lblMetricPendingTitle);
            this.cardPendingBoarding.Location = new System.Drawing.Point(490, 25);
            this.cardPendingBoarding.Name = "cardPendingBoarding";
            this.cardPendingBoarding.Size = new System.Drawing.Size(224, 76);

            this.lblMetricPendingVal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblMetricPendingVal.ForeColor = System.Drawing.Color.FromArgb(234, 88, 12);
            this.lblMetricPendingVal.Location = new System.Drawing.Point(10, 8);
            this.lblMetricPendingVal.Name = "lblMetricPendingVal";
            this.lblMetricPendingVal.Size = new System.Drawing.Size(200, 34);
            this.lblMetricPendingVal.Text = "0";

            this.lblMetricPendingTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMetricPendingTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricPendingTitle.Location = new System.Drawing.Point(11, 46);
            this.lblMetricPendingTitle.Name = "lblMetricPendingTitle";
            this.lblMetricPendingTitle.Size = new System.Drawing.Size(200, 18);
            this.lblMetricPendingTitle.Text = "AWAITING BOARDING";

            // cardRevenueToday
            this.cardRevenueToday.BackColor = System.Drawing.Color.White;
            this.cardRevenueToday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cardRevenueToday.Controls.Add(this.lblMetricRevenueTodayVal);
            this.cardRevenueToday.Controls.Add(this.lblMetricRevenueTodayTitle);
            this.cardRevenueToday.Location = new System.Drawing.Point(728, 25);
            this.cardRevenueToday.Name = "cardRevenueToday";
            this.cardRevenueToday.Size = new System.Drawing.Size(232, 76);

            this.lblMetricRevenueTodayVal.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lblMetricRevenueTodayVal.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblMetricRevenueTodayVal.Location = new System.Drawing.Point(10, 8);
            this.lblMetricRevenueTodayVal.Name = "lblMetricRevenueTodayVal";
            this.lblMetricRevenueTodayVal.Size = new System.Drawing.Size(210, 34);
            this.lblMetricRevenueTodayVal.Text = "0 ETB";

            this.lblMetricRevenueTodayTitle.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblMetricRevenueTodayTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblMetricRevenueTodayTitle.Location = new System.Drawing.Point(11, 46);
            this.lblMetricRevenueTodayTitle.Name = "lblMetricRevenueTodayTitle";
            this.lblMetricRevenueTodayTitle.Size = new System.Drawing.Size(210, 18);
            this.lblMetricRevenueTodayTitle.Text = "TODAY\'S CASHIER INTAKE";

            // grpQuickActions
            this.grpQuickActions.Controls.Add(this.btnQuickHelpdesk);
            this.grpQuickActions.Controls.Add(this.btnQuickReceipt);
            this.grpQuickActions.Controls.Add(this.btnQuickManifest);
            this.grpQuickActions.Controls.Add(this.btnQuickScanner);
            this.grpQuickActions.Controls.Add(this.btnQuickIssue);
            this.grpQuickActions.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpQuickActions.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpQuickActions.Location = new System.Drawing.Point(3, 136);
            this.grpQuickActions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.grpQuickActions.Name = "grpQuickActions";
            this.grpQuickActions.Size = new System.Drawing.Size(975, 78);
            this.grpQuickActions.Text = "FAST TERMINAL ACTIONS";

            this.btnQuickIssue.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnQuickIssue.FlatAppearance.BorderSize = 0;
            this.btnQuickIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickIssue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickIssue.ForeColor = System.Drawing.Color.White;
            this.btnQuickIssue.Location = new System.Drawing.Point(14, 26);
            this.btnQuickIssue.Name = "btnQuickIssue";
            this.btnQuickIssue.Size = new System.Drawing.Size(180, 36);
            this.btnQuickIssue.Text = "🎫  Issue Walk-in Ticket";

            this.btnQuickScanner.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnQuickScanner.FlatAppearance.BorderSize = 0;
            this.btnQuickScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickScanner.ForeColor = System.Drawing.Color.White;
            this.btnQuickScanner.Location = new System.Drawing.Point(206, 26);
            this.btnQuickScanner.Name = "btnQuickScanner";
            this.btnQuickScanner.Size = new System.Drawing.Size(180, 36);
            this.btnQuickScanner.Text = "🔍  Boarding Scanner";

            this.btnQuickManifest.BackColor = System.Drawing.Color.White;
            this.btnQuickManifest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickManifest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickManifest.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnQuickManifest.Location = new System.Drawing.Point(398, 26);
            this.btnQuickManifest.Name = "btnQuickManifest";
            this.btnQuickManifest.Size = new System.Drawing.Size(180, 36);
            this.btnQuickManifest.Text = "🚌  Passenger Manifest";

            this.btnQuickReceipt.BackColor = System.Drawing.Color.White;
            this.btnQuickReceipt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickReceipt.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnQuickReceipt.Location = new System.Drawing.Point(590, 26);
            this.btnQuickReceipt.Name = "btnQuickReceipt";
            this.btnQuickReceipt.Size = new System.Drawing.Size(180, 36);
            this.btnQuickReceipt.Text = "💳  Cashier Payments";

            this.btnQuickHelpdesk.BackColor = System.Drawing.Color.White;
            this.btnQuickHelpdesk.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickHelpdesk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickHelpdesk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuickHelpdesk.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnQuickHelpdesk.Location = new System.Drawing.Point(782, 26);
            this.btnQuickHelpdesk.Name = "btnQuickHelpdesk";
            this.btnQuickHelpdesk.Size = new System.Drawing.Size(178, 36);
            this.btnQuickHelpdesk.Text = "💬  Customer Helpdesk";

            // grpTicketVerify
            this.grpTicketVerify.Controls.Add(this.lblVerifyResult);
            this.grpTicketVerify.Controls.Add(this.btnVerifyTicket);
            this.grpTicketVerify.Controls.Add(this.txtTicketNumber);
            this.grpTicketVerify.Controls.Add(this.lblTicketSearchPrompt);
            this.grpTicketVerify.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTicketVerify.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpTicketVerify.Location = new System.Drawing.Point(3, 231);
            this.grpTicketVerify.Margin = new System.Windows.Forms.Padding(3, 3, 3, 14);
            this.grpTicketVerify.Name = "grpTicketVerify";
            this.grpTicketVerify.Size = new System.Drawing.Size(975, 110);
            this.grpTicketVerify.Text = "INSTANT TICKET VERIFICATION & BOARDING CHECK-IN";

            this.lblTicketSearchPrompt.AutoSize = true;
            this.lblTicketSearchPrompt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketSearchPrompt.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblTicketSearchPrompt.Location = new System.Drawing.Point(14, 25);
            this.lblTicketSearchPrompt.Name = "lblTicketSearchPrompt";
            this.lblTicketSearchPrompt.Size = new System.Drawing.Size(560, 15);
            this.lblTicketSearchPrompt.Text = "Scan barcode or enter Ticket ID (e.g. TK1001), Booking Reference (BK0001), or Security Code (VER-...) to verify:";

            this.txtTicketNumber.BackColor = System.Drawing.Color.White;
            this.txtTicketNumber.Location = new System.Drawing.Point(14, 48);
            this.txtTicketNumber.Name = "txtTicketNumber";
            this.txtTicketNumber.Size = new System.Drawing.Size(340, 42);

            this.btnVerifyTicket.FlatAppearance.BorderSize = 0;
            this.btnVerifyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyTicket.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerifyTicket.ForeColor = System.Drawing.Color.White;
            this.btnVerifyTicket.Location = new System.Drawing.Point(364, 48);
            this.btnVerifyTicket.Name = "btnVerifyTicket";
            this.btnVerifyTicket.Size = new System.Drawing.Size(210, 42);
            this.btnVerifyTicket.Text = "Verify && Confirm Boarding";

            this.lblVerifyResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVerifyResult.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblVerifyResult.Location = new System.Drawing.Point(588, 48);
            this.lblVerifyResult.Name = "lblVerifyResult";
            this.lblVerifyResult.Size = new System.Drawing.Size(372, 42);
            this.lblVerifyResult.Text = "Ready for ticket scanning. Enter reference to validate.";
            this.lblVerifyResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // grpTripsSchedule
            this.grpTripsSchedule.Controls.Add(this.dgvTrips);
            this.grpTripsSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpTripsSchedule.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpTripsSchedule.Location = new System.Drawing.Point(3, 362);
            this.grpTripsSchedule.Name = "grpTripsSchedule";
            this.grpTripsSchedule.Size = new System.Drawing.Size(975, 270);
            this.grpTripsSchedule.Text = "TODAY\'S TERMINAL DEPARTURES & GATE STATUS";

            this.dgvTrips.AllowUserToAddRows = false;
            this.dgvTrips.AllowUserToDeleteRows = false;
            this.dgvTrips.BackgroundColor = System.Drawing.Color.White;
            this.dgvTrips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrips.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTrips.Location = new System.Drawing.Point(3, 20);
            this.dgvTrips.MultiSelect = false;
            this.dgvTrips.Name = "dgvTrips";
            this.dgvTrips.ReadOnly = true;
            this.dgvTrips.RowHeadersVisible = false;
            this.dgvTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrips.Size = new System.Drawing.Size(969, 247);

            // ==========================================
            // 2. ISSUE WALK-IN TICKET VIEW
            // ==========================================
            this.panelIssueTicket.AutoScroll = true;
            this.panelIssueTicket.Controls.Add(this.panelIssueSummaryCard);
            this.panelIssueTicket.Controls.Add(this.panelIssueFormCard);
            this.panelIssueTicket.Controls.Add(this.panelIssueHeader);
            this.panelIssueTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIssueTicket.Location = new System.Drawing.Point(20, 72);
            this.panelIssueTicket.Name = "panelIssueTicket";
            this.panelIssueTicket.Size = new System.Drawing.Size(990, 684);
            this.panelIssueTicket.Visible = false;

            // panelIssueHeader
            this.panelIssueHeader.Controls.Add(this.lblIssueSubtitle);
            this.panelIssueHeader.Controls.Add(this.lblIssueTitle);
            this.panelIssueHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIssueHeader.Location = new System.Drawing.Point(0, 0);
            this.panelIssueHeader.Name = "panelIssueHeader";
            this.panelIssueHeader.Size = new System.Drawing.Size(990, 60);

            this.lblIssueTitle.AutoSize = true;
            this.lblIssueTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblIssueTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblIssueTitle.Location = new System.Drawing.Point(0, 4);
            this.lblIssueTitle.Name = "lblIssueTitle";
            this.lblIssueTitle.Size = new System.Drawing.Size(370, 25);
            this.lblIssueTitle.Text = "Walk-In Passenger Ticket Issuance Desk";

            this.lblIssueSubtitle.AutoSize = true;
            this.lblIssueSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIssueSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblIssueSubtitle.Location = new System.Drawing.Point(2, 33);
            this.lblIssueSubtitle.Name = "lblIssueSubtitle";
            this.lblIssueSubtitle.Size = new System.Drawing.Size(590, 15);
            this.lblIssueSubtitle.Text = "Book seats, calculate fares, process walk-in counter payment, and generate official passenger boarding tickets.";

            // panelIssueFormCard
            this.panelIssueFormCard.BackColor = System.Drawing.Color.White;
            this.panelIssueFormCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIssueFormCard.Controls.Add(this.btnOpenAdvancedBooking);
            this.panelIssueFormCard.Controls.Add(this.btnClearIssueForm);
            this.panelIssueFormCard.Controls.Add(this.btnConfirmIssueTicket);
            this.panelIssueFormCard.Controls.Add(this.txtIssueNotes);
            this.panelIssueFormCard.Controls.Add(this.lblIssueNotes);
            this.panelIssueFormCard.Controls.Add(this.txtIssueLuggage);
            this.panelIssueFormCard.Controls.Add(this.lblIssueLuggage);
            this.panelIssueFormCard.Controls.Add(this.cmbIssuePaymentStatus);
            this.panelIssueFormCard.Controls.Add(this.lblIssuePaymentStatus);
            this.panelIssueFormCard.Controls.Add(this.cmbIssuePaymentMethod);
            this.panelIssueFormCard.Controls.Add(this.lblIssuePaymentMethod);
            this.panelIssueFormCard.Controls.Add(this.numIssueFare);
            this.panelIssueFormCard.Controls.Add(this.lblIssueFare);
            this.panelIssueFormCard.Controls.Add(this.numIssueSeat);
            this.panelIssueFormCard.Controls.Add(this.lblIssueSeat);
            this.panelIssueFormCard.Controls.Add(this.cmbIssueGate);
            this.panelIssueFormCard.Controls.Add(this.lblIssueGate);
            this.panelIssueFormCard.Controls.Add(this.cmbIssueBus);
            this.panelIssueFormCard.Controls.Add(this.lblIssueBus);
            this.panelIssueFormCard.Controls.Add(this.cmbIssueTime);
            this.panelIssueFormCard.Controls.Add(this.lblIssueTime);
            this.panelIssueFormCard.Controls.Add(this.dtpIssueDate);
            this.panelIssueFormCard.Controls.Add(this.lblIssueDate);
            this.panelIssueFormCard.Controls.Add(this.cmbIssueRoute);
            this.panelIssueFormCard.Controls.Add(this.lblIssueRoute);
            this.panelIssueFormCard.Controls.Add(this.txtIssueEmail);
            this.panelIssueFormCard.Controls.Add(this.lblIssueEmail);
            this.panelIssueFormCard.Controls.Add(this.txtIssuePhone);
            this.panelIssueFormCard.Controls.Add(this.lblIssuePhone);
            this.panelIssueFormCard.Controls.Add(this.txtIssueName);
            this.panelIssueFormCard.Controls.Add(this.lblIssueName);
            this.panelIssueFormCard.Controls.Add(this.lblIssueFormHeader);
            this.panelIssueFormCard.Location = new System.Drawing.Point(3, 68);
            this.panelIssueFormCard.Name = "panelIssueFormCard";
            this.panelIssueFormCard.Size = new System.Drawing.Size(560, 580);

            this.lblIssueFormHeader.AutoSize = true;
            this.lblIssueFormHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueFormHeader.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblIssueFormHeader.Location = new System.Drawing.Point(16, 12);
            this.lblIssueFormHeader.Name = "lblIssueFormHeader";
            this.lblIssueFormHeader.Size = new System.Drawing.Size(260, 19);
            this.lblIssueFormHeader.Text = "PASSENGER && JOURNEY BOOKING ENTRY";

            // Row 1: Name & Phone
            this.lblIssueName.AutoSize = true;
            this.lblIssueName.Location = new System.Drawing.Point(16, 42);
            this.lblIssueName.Name = "lblIssueName";
            this.lblIssueName.Size = new System.Drawing.Size(125, 15);
            this.lblIssueName.Text = "Passenger Full Name *";

            this.txtIssueName.Location = new System.Drawing.Point(16, 60);
            this.txtIssueName.Name = "txtIssueName";
            this.txtIssueName.Size = new System.Drawing.Size(250, 23);

            this.lblIssuePhone.AutoSize = true;
            this.lblIssuePhone.Location = new System.Drawing.Point(286, 42);
            this.lblIssuePhone.Name = "lblIssuePhone";
            this.lblIssuePhone.Size = new System.Drawing.Size(96, 15);
            this.lblIssuePhone.Text = "Phone Number *";

            this.txtIssuePhone.Location = new System.Drawing.Point(286, 60);
            this.txtIssuePhone.Name = "txtIssuePhone";
            this.txtIssuePhone.Size = new System.Drawing.Size(250, 23);

            // Row 2: Email & Route
            this.lblIssueEmail.AutoSize = true;
            this.lblIssueEmail.Location = new System.Drawing.Point(16, 92);
            this.lblIssueEmail.Name = "lblIssueEmail";
            this.lblIssueEmail.Size = new System.Drawing.Size(81, 15);
            this.lblIssueEmail.Text = "Email Address";

            this.txtIssueEmail.Location = new System.Drawing.Point(16, 110);
            this.txtIssueEmail.Name = "txtIssueEmail";
            this.txtIssueEmail.Size = new System.Drawing.Size(250, 23);

            this.lblIssueRoute.AutoSize = true;
            this.lblIssueRoute.Location = new System.Drawing.Point(286, 92);
            this.lblIssueRoute.Name = "lblIssueRoute";
            this.lblIssueRoute.Size = new System.Drawing.Size(83, 15);
            this.lblIssueRoute.Text = "Select Route *";

            this.cmbIssueRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueRoute.Location = new System.Drawing.Point(286, 110);
            this.cmbIssueRoute.Name = "cmbIssueRoute";
            this.cmbIssueRoute.Size = new System.Drawing.Size(250, 23);

            // Row 3: Date & Departure Time
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(16, 142);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(73, 15);
            this.lblIssueDate.Text = "Travel Date *";

            this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpIssueDate.Location = new System.Drawing.Point(16, 160);
            this.dtpIssueDate.Name = "dtpIssueDate";
            this.dtpIssueDate.Size = new System.Drawing.Size(250, 23);

            this.lblIssueTime.AutoSize = true;
            this.lblIssueTime.Location = new System.Drawing.Point(286, 142);
            this.lblIssueTime.Name = "lblIssueTime";
            this.lblIssueTime.Size = new System.Drawing.Size(98, 15);
            this.lblIssueTime.Text = "Departure Time *";

            this.cmbIssueTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueTime.Items.AddRange(new object[] { "06:00 AM", "07:30 AM", "08:00 AM", "09:30 AM", "11:00 AM", "01:30 PM", "03:00 PM" });
            this.cmbIssueTime.Location = new System.Drawing.Point(286, 160);
            this.cmbIssueTime.Name = "cmbIssueTime";
            this.cmbIssueTime.Size = new System.Drawing.Size(250, 23);

            // Row 4: Bus & Gate
            this.lblIssueBus.AutoSize = true;
            this.lblIssueBus.Location = new System.Drawing.Point(16, 192);
            this.lblIssueBus.Name = "lblIssueBus";
            this.lblIssueBus.Size = new System.Drawing.Size(89, 15);
            this.lblIssueBus.Text = "Assigned Coach";

            this.cmbIssueBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueBus.Location = new System.Drawing.Point(16, 210);
            this.cmbIssueBus.Name = "cmbIssueBus";
            this.cmbIssueBus.Size = new System.Drawing.Size(250, 23);

            this.lblIssueGate.AutoSize = true;
            this.lblIssueGate.Location = new System.Drawing.Point(286, 192);
            this.lblIssueGate.Name = "lblIssueGate";
            this.lblIssueGate.Size = new System.Drawing.Size(86, 15);
            this.lblIssueGate.Text = "Departure Gate";

            this.cmbIssueGate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueGate.Items.AddRange(new object[] { "Gate 01", "Gate 02", "Gate 03", "Gate 04", "Gate 05", "Gate 06" });
            this.cmbIssueGate.Location = new System.Drawing.Point(286, 210);
            this.cmbIssueGate.Name = "cmbIssueGate";
            this.cmbIssueGate.Size = new System.Drawing.Size(250, 23);

            // Row 5: Seat & Fare
            this.lblIssueSeat.AutoSize = true;
            this.lblIssueSeat.Location = new System.Drawing.Point(16, 242);
            this.lblIssueSeat.Name = "lblIssueSeat";
            this.lblIssueSeat.Size = new System.Drawing.Size(86, 15);
            this.lblIssueSeat.Text = "Seat Number *";

            this.numIssueSeat.Location = new System.Drawing.Point(16, 260);
            this.numIssueSeat.Minimum = 1;
            this.numIssueSeat.Maximum = 65;
            this.numIssueSeat.Value = 1;
            this.numIssueSeat.Name = "numIssueSeat";
            this.numIssueSeat.Size = new System.Drawing.Size(250, 23);

            this.lblIssueFare.AutoSize = true;
            this.lblIssueFare.Location = new System.Drawing.Point(286, 242);
            this.lblIssueFare.Name = "lblIssueFare";
            this.lblIssueFare.Size = new System.Drawing.Size(117, 15);
            this.lblIssueFare.Text = "Fare Amount (ETB) *";

            this.numIssueFare.DecimalPlaces = 2;
            this.numIssueFare.Maximum = 10000;
            this.numIssueFare.Location = new System.Drawing.Point(286, 260);
            this.numIssueFare.Name = "numIssueFare";
            this.numIssueFare.Size = new System.Drawing.Size(250, 23);

            // Row 6: Payment Method & Payment Status
            this.lblIssuePaymentMethod.AutoSize = true;
            this.lblIssuePaymentMethod.Location = new System.Drawing.Point(16, 292);
            this.lblIssuePaymentMethod.Name = "lblIssuePaymentMethod";
            this.lblIssuePaymentMethod.Size = new System.Drawing.Size(107, 15);
            this.lblIssuePaymentMethod.Text = "Payment Method *";

            this.cmbIssuePaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssuePaymentMethod.Items.AddRange(new object[] { "Cash", "Telebirr", "CBE Birr", "Card" });
            this.cmbIssuePaymentMethod.Location = new System.Drawing.Point(16, 310);
            this.cmbIssuePaymentMethod.Name = "cmbIssuePaymentMethod";
            this.cmbIssuePaymentMethod.Size = new System.Drawing.Size(250, 23);

            this.lblIssuePaymentStatus.AutoSize = true;
            this.lblIssuePaymentStatus.Location = new System.Drawing.Point(286, 292);
            this.lblIssuePaymentStatus.Name = "lblIssuePaymentStatus";
            this.lblIssuePaymentStatus.Size = new System.Drawing.Size(97, 15);
            this.lblIssuePaymentStatus.Text = "Payment Status *";

            this.cmbIssuePaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssuePaymentStatus.Items.AddRange(new object[] { "Paid", "Pending" });
            this.cmbIssuePaymentStatus.Location = new System.Drawing.Point(286, 310);
            this.cmbIssuePaymentStatus.Name = "cmbIssuePaymentStatus";
            this.cmbIssuePaymentStatus.Size = new System.Drawing.Size(250, 23);

            // Row 7: Luggage & Notes
            this.lblIssueLuggage.AutoSize = true;
            this.lblIssueLuggage.Location = new System.Drawing.Point(16, 342);
            this.lblIssueLuggage.Name = "lblIssueLuggage";
            this.lblIssueLuggage.Size = new System.Drawing.Size(107, 15);
            this.lblIssueLuggage.Text = "Luggage Allowance";

            this.txtIssueLuggage.Location = new System.Drawing.Point(16, 360);
            this.txtIssueLuggage.Name = "txtIssueLuggage";
            this.txtIssueLuggage.Size = new System.Drawing.Size(520, 23);
            this.txtIssueLuggage.Text = "25 kg (1 Standard Cargo + 1 Handbag)";

            this.lblIssueNotes.AutoSize = true;
            this.lblIssueNotes.Location = new System.Drawing.Point(16, 392);
            this.lblIssueNotes.Name = "lblIssueNotes";
            this.lblIssueNotes.Size = new System.Drawing.Size(148, 15);
            this.lblIssueNotes.Text = "Special Requests or Notes";

            this.txtIssueNotes.Location = new System.Drawing.Point(16, 410);
            this.txtIssueNotes.Multiline = true;
            this.txtIssueNotes.Name = "txtIssueNotes";
            this.txtIssueNotes.Size = new System.Drawing.Size(520, 50);

            // Action Buttons in Form Card
            this.btnConfirmIssueTicket.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnConfirmIssueTicket.FlatAppearance.BorderSize = 0;
            this.btnConfirmIssueTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmIssueTicket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmIssueTicket.ForeColor = System.Drawing.Color.White;
            this.btnConfirmIssueTicket.Location = new System.Drawing.Point(16, 474);
            this.btnConfirmIssueTicket.Name = "btnConfirmIssueTicket";
            this.btnConfirmIssueTicket.Size = new System.Drawing.Size(260, 42);
            this.btnConfirmIssueTicket.Text = "🎫  Issue Ticket && Print";

            this.btnClearIssueForm.BackColor = System.Drawing.Color.White;
            this.btnClearIssueForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClearIssueForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearIssueForm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearIssueForm.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnClearIssueForm.Location = new System.Drawing.Point(286, 474);
            this.btnClearIssueForm.Name = "btnClearIssueForm";
            this.btnClearIssueForm.Size = new System.Drawing.Size(120, 42);
            this.btnClearIssueForm.Text = "🔄  Clear";

            this.btnOpenAdvancedBooking.BackColor = System.Drawing.Color.White;
            this.btnOpenAdvancedBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnOpenAdvancedBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenAdvancedBooking.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnOpenAdvancedBooking.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnOpenAdvancedBooking.Location = new System.Drawing.Point(16, 526);
            this.btnOpenAdvancedBooking.Name = "btnOpenAdvancedBooking";
            this.btnOpenAdvancedBooking.Size = new System.Drawing.Size(390, 32);
            this.btnOpenAdvancedBooking.Text = "📑  Need Multiple Seats? Open Advanced Booking Wizard...";

            // panelIssueSummaryCard (Right Side Preview)
            this.panelIssueSummaryCard.BackColor = System.Drawing.Color.White;
            this.panelIssueSummaryCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIssueSummaryCard.Controls.Add(this.txtTicketPreview);
            this.panelIssueSummaryCard.Controls.Add(this.lblPreviewTitle);
            this.panelIssueSummaryCard.Controls.Add(this.lblSummaryDetails);
            this.panelIssueSummaryCard.Controls.Add(this.lblIssueSummaryHeader);
            this.panelIssueSummaryCard.Location = new System.Drawing.Point(576, 68);
            this.panelIssueSummaryCard.Name = "panelIssueSummaryCard";
            this.panelIssueSummaryCard.Size = new System.Drawing.Size(400, 580);

            this.lblIssueSummaryHeader.AutoSize = true;
            this.lblIssueSummaryHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblIssueSummaryHeader.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblIssueSummaryHeader.Location = new System.Drawing.Point(16, 12);
            this.lblIssueSummaryHeader.Name = "lblIssueSummaryHeader";
            this.lblIssueSummaryHeader.Size = new System.Drawing.Size(190, 19);
            this.lblIssueSummaryHeader.Text = "LIVE FARE && SEAT SUMMARY";

            this.lblSummaryDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSummaryDetails.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSummaryDetails.Location = new System.Drawing.Point(16, 40);
            this.lblSummaryDetails.Name = "lblSummaryDetails";
            this.lblSummaryDetails.Size = new System.Drawing.Size(366, 100);
            this.lblSummaryDetails.Text = "Select a route to calculate distance, scheduled departure time, gate assignment, and ticket fare.";

            this.lblPreviewTitle.AutoSize = true;
            this.lblPreviewTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPreviewTitle.Location = new System.Drawing.Point(16, 150);
            this.lblPreviewTitle.Name = "lblPreviewTitle";
            this.lblPreviewTitle.Size = new System.Drawing.Size(195, 15);
            this.lblPreviewTitle.Text = "BOARDING PASS PREVIEW (PRINT)";

            this.txtTicketPreview.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.txtTicketPreview.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.txtTicketPreview.Location = new System.Drawing.Point(16, 172);
            this.txtTicketPreview.Multiline = true;
            this.txtTicketPreview.Name = "txtTicketPreview";
            this.txtTicketPreview.ReadOnly = true;
            this.txtTicketPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTicketPreview.Size = new System.Drawing.Size(366, 390);

            // ==========================================
            // 3. TICKET VERIFICATION & BOARDING VIEW
            // ==========================================
            this.panelVerifyBoarding.AutoScroll = true;
            this.panelVerifyBoarding.Controls.Add(this.panelVerifyActions);
            this.panelVerifyBoarding.Controls.Add(this.panelVerifyDossier);
            this.panelVerifyBoarding.Controls.Add(this.panelVerifyBanner);
            this.panelVerifyBoarding.Controls.Add(this.panelVerifyToolbar);
            this.panelVerifyBoarding.Controls.Add(this.panelVerifyHeader);
            this.panelVerifyBoarding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelVerifyBoarding.Location = new System.Drawing.Point(20, 72);
            this.panelVerifyBoarding.Name = "panelVerifyBoarding";
            this.panelVerifyBoarding.Size = new System.Drawing.Size(990, 684);
            this.panelVerifyBoarding.Visible = false;

            this.panelVerifyHeader.Controls.Add(this.lblVerifySubtitle);
            this.panelVerifyHeader.Controls.Add(this.lblVerifyTitle);
            this.panelVerifyHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVerifyHeader.Location = new System.Drawing.Point(0, 0);
            this.panelVerifyHeader.Name = "panelVerifyHeader";
            this.panelVerifyHeader.Size = new System.Drawing.Size(990, 60);

            this.lblVerifyTitle.AutoSize = true;
            this.lblVerifyTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblVerifyTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblVerifyTitle.Location = new System.Drawing.Point(0, 4);
            this.lblVerifyTitle.Name = "lblVerifyTitle";
            this.lblVerifyTitle.Size = new System.Drawing.Size(430, 25);
            this.lblVerifyTitle.Text = "Ticket Verification & Passenger Check-In Station";

            this.lblVerifySubtitle.AutoSize = true;
            this.lblVerifySubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblVerifySubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblVerifySubtitle.Location = new System.Drawing.Point(2, 33);
            this.lblVerifySubtitle.Name = "lblVerifySubtitle";
            this.lblVerifySubtitle.Size = new System.Drawing.Size(610, 15);
            this.lblVerifySubtitle.Text = "Scan boarding barcode or enter ticket reference to validate security codes, prevent duplicate reuse, and clear boarding.";

            this.panelVerifyToolbar.BackColor = System.Drawing.Color.White;
            this.panelVerifyToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVerifyToolbar.Controls.Add(this.btnOpenModalScanner);
            this.panelVerifyToolbar.Controls.Add(this.btnVerifyLookup);
            this.panelVerifyToolbar.Controls.Add(this.txtVerifySearch);
            this.panelVerifyToolbar.Location = new System.Drawing.Point(3, 68);
            this.panelVerifyToolbar.Name = "panelVerifyToolbar";
            this.panelVerifyToolbar.Size = new System.Drawing.Size(975, 56);

            this.txtVerifySearch.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtVerifySearch.Location = new System.Drawing.Point(14, 14);
            this.txtVerifySearch.Name = "txtVerifySearch";
            this.txtVerifySearch.PlaceholderText = "Scan or type Ticket ID (TK1001), Booking Ref (BK0001), or Security Code (VER-...)";
            this.txtVerifySearch.Size = new System.Drawing.Size(560, 27);

            this.btnVerifyLookup.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnVerifyLookup.FlatAppearance.BorderSize = 0;
            this.btnVerifyLookup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyLookup.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVerifyLookup.ForeColor = System.Drawing.Color.White;
            this.btnVerifyLookup.Location = new System.Drawing.Point(590, 12);
            this.btnVerifyLookup.Name = "btnVerifyLookup";
            this.btnVerifyLookup.Size = new System.Drawing.Size(170, 32);
            this.btnVerifyLookup.Text = "🔍  Verify Ticket";

            this.btnOpenModalScanner.BackColor = System.Drawing.Color.White;
            this.btnOpenModalScanner.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnOpenModalScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenModalScanner.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOpenModalScanner.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnOpenModalScanner.Location = new System.Drawing.Point(772, 12);
            this.btnOpenModalScanner.Name = "btnOpenModalScanner";
            this.btnOpenModalScanner.Size = new System.Drawing.Size(188, 32);
            this.btnOpenModalScanner.Text = "📱  Open Scanner Modal";

            // Status Banner
            this.panelVerifyBanner.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelVerifyBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVerifyBanner.Controls.Add(this.lblVerifyBannerSub);
            this.panelVerifyBanner.Controls.Add(this.lblVerifyBannerTitle);
            this.panelVerifyBanner.Location = new System.Drawing.Point(3, 134);
            this.panelVerifyBanner.Name = "panelVerifyBanner";
            this.panelVerifyBanner.Size = new System.Drawing.Size(975, 76);

            this.lblVerifyBannerTitle.AutoSize = true;
            this.lblVerifyBannerTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblVerifyBannerTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblVerifyBannerTitle.Location = new System.Drawing.Point(16, 12);
            this.lblVerifyBannerTitle.Name = "lblVerifyBannerTitle";
            this.lblVerifyBannerTitle.Size = new System.Drawing.Size(330, 25);
            this.lblVerifyBannerTitle.Text = "READY FOR TICKET VERIFICATION";

            this.lblVerifyBannerSub.AutoSize = true;
            this.lblVerifyBannerSub.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblVerifyBannerSub.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblVerifyBannerSub.Location = new System.Drawing.Point(18, 42);
            this.lblVerifyBannerSub.Name = "lblVerifyBannerSub";
            this.lblVerifyBannerSub.Size = new System.Drawing.Size(530, 17);
            this.lblVerifyBannerSub.Text = "Please enter or scan a passenger boarding reference above to inspect validity.";

            // Dossier Card
            this.panelVerifyDossier.BackColor = System.Drawing.Color.White;
            this.panelVerifyDossier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVerifyDossier.Controls.Add(this.lblDossierContent);
            this.panelVerifyDossier.Controls.Add(this.lblDossierTitle);
            this.panelVerifyDossier.Location = new System.Drawing.Point(3, 220);
            this.panelVerifyDossier.Name = "panelVerifyDossier";
            this.panelVerifyDossier.Size = new System.Drawing.Size(975, 360);

            this.lblDossierTitle.AutoSize = true;
            this.lblDossierTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDossierTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblDossierTitle.Location = new System.Drawing.Point(16, 12);
            this.lblDossierTitle.Name = "lblDossierTitle";
            this.lblDossierTitle.Size = new System.Drawing.Size(260, 19);
            this.lblDossierTitle.Text = "PASSENGER && BOARDING DOSSIER";

            this.lblDossierContent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblDossierContent.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDossierContent.Location = new System.Drawing.Point(16, 42);
            this.lblDossierContent.Name = "lblDossierContent";
            this.lblDossierContent.Size = new System.Drawing.Size(940, 300);
            this.lblDossierContent.Text = "No ticket loaded yet. Enter reference to inspect passenger details, coach assignment, and security clearance.";

            // Actions panel
            this.panelVerifyActions.BackColor = System.Drawing.Color.White;
            this.panelVerifyActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelVerifyActions.Controls.Add(this.btnReportDiscrepancy);
            this.panelVerifyActions.Controls.Add(this.btnPrintVerificationPass);
            this.panelVerifyActions.Controls.Add(this.btnMarkBoardedAction);
            this.panelVerifyActions.Location = new System.Drawing.Point(3, 590);
            this.panelVerifyActions.Name = "panelVerifyActions";
            this.panelVerifyActions.Size = new System.Drawing.Size(975, 54);

            this.btnMarkBoardedAction.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnMarkBoardedAction.Enabled = false;
            this.btnMarkBoardedAction.FlatAppearance.BorderSize = 0;
            this.btnMarkBoardedAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarkBoardedAction.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnMarkBoardedAction.ForeColor = System.Drawing.Color.White;
            this.btnMarkBoardedAction.Location = new System.Drawing.Point(14, 10);
            this.btnMarkBoardedAction.Name = "btnMarkBoardedAction";
            this.btnMarkBoardedAction.Size = new System.Drawing.Size(240, 34);
            this.btnMarkBoardedAction.Text = "✅  Confirm Passenger Boarded";

            this.btnPrintVerificationPass.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnPrintVerificationPass.Enabled = false;
            this.btnPrintVerificationPass.FlatAppearance.BorderSize = 0;
            this.btnPrintVerificationPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintVerificationPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnPrintVerificationPass.ForeColor = System.Drawing.Color.White;
            this.btnPrintVerificationPass.Location = new System.Drawing.Point(264, 10);
            this.btnPrintVerificationPass.Name = "btnPrintVerificationPass";
            this.btnPrintVerificationPass.Size = new System.Drawing.Size(200, 34);
            this.btnPrintVerificationPass.Text = "🖨️  Print Boarding Pass";

            this.btnReportDiscrepancy.BackColor = System.Drawing.Color.White;
            this.btnReportDiscrepancy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnReportDiscrepancy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportDiscrepancy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnReportDiscrepancy.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnReportDiscrepancy.Location = new System.Drawing.Point(474, 10);
            this.btnReportDiscrepancy.Name = "btnReportDiscrepancy";
            this.btnReportDiscrepancy.Size = new System.Drawing.Size(210, 34);
            this.btnReportDiscrepancy.Text = "⚠️  Report Discrepancy / Cancel";

            // ==========================================
            // 4. BOOKINGS MANAGEMENT VIEW
            // ==========================================
            this.panelBookingManagement.AutoScroll = true;
            this.panelBookingManagement.Controls.Add(this.panelBookingActions);
            this.panelBookingManagement.Controls.Add(this.lvBookings);
            this.panelBookingManagement.Controls.Add(this.panelBookingsToolbar);
            this.panelBookingManagement.Controls.Add(this.flowBookingMetrics);
            this.panelBookingManagement.Controls.Add(this.panelBookingsHeader);
            this.panelBookingManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBookingManagement.Location = new System.Drawing.Point(20, 72);
            this.panelBookingManagement.Name = "panelBookingManagement";
            this.panelBookingManagement.Size = new System.Drawing.Size(990, 684);
            this.panelBookingManagement.Visible = false;

            this.panelBookingsHeader.Controls.Add(this.btnNewBooking);
            this.panelBookingsHeader.Controls.Add(this.lblBookingsSubtitle);
            this.panelBookingsHeader.Controls.Add(this.lblBookingsTitle);
            this.panelBookingsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBookingsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBookingsHeader.Name = "panelBookingsHeader";
            this.panelBookingsHeader.Size = new System.Drawing.Size(990, 60);

            this.lblBookingsTitle.AutoSize = true;
            this.lblBookingsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBookingsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblBookingsTitle.Location = new System.Drawing.Point(0, 4);
            this.lblBookingsTitle.Name = "lblBookingsTitle";
            this.lblBookingsTitle.Size = new System.Drawing.Size(380, 25);
            this.lblBookingsTitle.Text = "Passenger Reservations & Booking Desk";

            this.lblBookingsSubtitle.AutoSize = true;
            this.lblBookingsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblBookingsSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBookingsSubtitle.Location = new System.Drawing.Point(2, 33);
            this.lblBookingsSubtitle.Name = "lblBookingsSubtitle";
            this.lblBookingsSubtitle.Size = new System.Drawing.Size(590, 15);
            this.lblBookingsSubtitle.Text = "Search, modify, or cancel reservations, manage seat allocations, and issue passenger tickets.";

            this.btnNewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewBooking.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnNewBooking.FlatAppearance.BorderSize = 0;
            this.btnNewBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewBooking.ForeColor = System.Drawing.Color.White;
            this.btnNewBooking.Location = new System.Drawing.Point(790, 14);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(185, 34);
            this.btnNewBooking.Text = "➕  New Walk-In Booking";

            // Metric Cards
            this.flowBookingMetrics.Controls.Add(this.cardTotalBookings);
            this.flowBookingMetrics.Controls.Add(this.cardConfirmedBookings);
            this.flowBookingMetrics.Controls.Add(this.cardPendingBookings);
            this.flowBookingMetrics.Controls.Add(this.cardCancelledBookings);
            this.flowBookingMetrics.Controls.Add(this.cardTodayBookings);
            this.flowBookingMetrics.Location = new System.Drawing.Point(0, 64);
            this.flowBookingMetrics.Name = "flowBookingMetrics";
            this.flowBookingMetrics.Size = new System.Drawing.Size(985, 84);

            BuildMetricCard(out this.cardTotalBookings, out this.lblMetricTotalBookingsVal, out this.lblMetricTotalBookingsTitle, out this.lblMetricTotalBookingsSub, "TOTAL BOOKINGS", "0", "All reservations", Color.FromArgb(15, 23, 42));
            BuildMetricCard(out this.cardConfirmedBookings, out this.lblMetricConfirmedBookingsVal, out this.lblMetricConfirmedBookingsTitle, out this.lblMetricConfirmedBookingsSub, "CONFIRMED", "0", "Active passengers", Color.FromArgb(16, 185, 129));
            BuildMetricCard(out this.cardPendingBookings, out this.lblMetricPendingBookingsVal, out this.lblMetricPendingBookingsTitle, out this.lblMetricPendingBookingsSub, "PENDING", "0", "Awaiting clearance", Color.FromArgb(234, 88, 12));
            BuildMetricCard(out this.cardCancelledBookings, out this.lblMetricCancelledBookingsVal, out this.lblMetricCancelledBookingsTitle, out this.lblMetricCancelledBookingsSub, "CANCELLED", "0", "Seats released", Color.FromArgb(239, 68, 68));
            BuildMetricCard(out this.cardTodayBookings, out this.lblMetricTodayBookingsVal, out this.lblMetricTodayBookingsTitle, out this.lblMetricTodayBookingsSub, "TODAY\'S TRAVEL", "0", "Reservations today", Color.FromArgb(13, 94, 234));

            // Bookings Toolbar
            this.panelBookingsToolbar.BackColor = System.Drawing.Color.White;
            this.panelBookingsToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookingsToolbar.Controls.Add(this.btnResetBookingFilters);
            this.panelBookingsToolbar.Controls.Add(this.dtpBookingFilterDate);
            this.panelBookingsToolbar.Controls.Add(this.chkEnableDateFilter);
            this.panelBookingsToolbar.Controls.Add(this.cmbBookingRouteFilter);
            this.panelBookingsToolbar.Controls.Add(this.cmbBookingStatusFilter);
            this.panelBookingsToolbar.Controls.Add(this.txtSearchBooking);
            this.panelBookingsToolbar.Location = new System.Drawing.Point(0, 154);
            this.panelBookingsToolbar.Name = "panelBookingsToolbar";
            this.panelBookingsToolbar.Size = new System.Drawing.Size(975, 48);

            this.txtSearchBooking.Location = new System.Drawing.Point(12, 12);
            this.txtSearchBooking.Name = "txtSearchBooking";
            this.txtSearchBooking.PlaceholderText = "Search by ID, name, phone, coach...";
            this.txtSearchBooking.Size = new System.Drawing.Size(260, 23);

            this.cmbBookingStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingStatusFilter.Items.AddRange(new object[] { "All Statuses", "Confirmed", "Pending", "Cancelled" });
            this.cmbBookingStatusFilter.Location = new System.Drawing.Point(282, 12);
            this.cmbBookingStatusFilter.Name = "cmbBookingStatusFilter";
            this.cmbBookingStatusFilter.Size = new System.Drawing.Size(130, 23);

            this.cmbBookingRouteFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingRouteFilter.Items.AddRange(new object[] { "All Routes / Trips" });
            this.cmbBookingRouteFilter.Location = new System.Drawing.Point(422, 12);
            this.cmbBookingRouteFilter.Name = "cmbBookingRouteFilter";
            this.cmbBookingRouteFilter.Size = new System.Drawing.Size(180, 23);

            this.chkEnableDateFilter.AutoSize = true;
            this.chkEnableDateFilter.Location = new System.Drawing.Point(614, 14);
            this.chkEnableDateFilter.Name = "chkEnableDateFilter";
            this.chkEnableDateFilter.Size = new System.Drawing.Size(53, 19);
            this.chkEnableDateFilter.Text = "Date:";

            this.dtpBookingFilterDate.Enabled = false;
            this.dtpBookingFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBookingFilterDate.Location = new System.Drawing.Point(674, 12);
            this.dtpBookingFilterDate.Name = "dtpBookingFilterDate";
            this.dtpBookingFilterDate.Size = new System.Drawing.Size(120, 23);

            this.btnResetBookingFilters.BackColor = System.Drawing.Color.White;
            this.btnResetBookingFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnResetBookingFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetBookingFilters.Location = new System.Drawing.Point(806, 11);
            this.btnResetBookingFilters.Name = "btnResetBookingFilters";
            this.btnResetBookingFilters.Size = new System.Drawing.Size(80, 26);
            this.btnResetBookingFilters.Text = "Reset";

            // lvBookings
            this.lvBookings.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colBookingId, this.colPassengerName, this.colPassengerPhone,
                this.colBookingRoute, this.colTravelDate, this.colDepartureTime,
                this.colSeats, this.colTotalAmount, this.colBookingStatus, this.colPaymentStatus
            });
            this.lvBookings.FullRowSelect = true;
            this.lvBookings.GridLines = true;
            this.lvBookings.Location = new System.Drawing.Point(0, 210);
            this.lvBookings.MultiSelect = false;
            this.lvBookings.Name = "lvBookings";
            this.lvBookings.Size = new System.Drawing.Size(975, 380);
            this.lvBookings.TabIndex = 3;
            this.lvBookings.UseCompatibleStateImageBehavior = false;
            this.lvBookings.View = System.Windows.Forms.View.Details;

            this.colBookingId.Text = "Booking ID"; this.colBookingId.Width = 85;
            this.colPassengerName.Text = "Passenger Name"; this.colPassengerName.Width = 140;
            this.colPassengerPhone.Text = "Phone"; this.colPassengerPhone.Width = 110;
            this.colBookingRoute.Text = "Route"; this.colBookingRoute.Width = 160;
            this.colTravelDate.Text = "Travel Date"; this.colTravelDate.Width = 95;
            this.colDepartureTime.Text = "Time"; this.colDepartureTime.Width = 75;
            this.colSeats.Text = "Seats"; this.colSeats.Width = 85;
            this.colTotalAmount.Text = "Fare (ETB)"; this.colTotalAmount.Width = 80;
            this.colBookingStatus.Text = "Status"; this.colBookingStatus.Width = 75;
            this.colPaymentStatus.Text = "Payment"; this.colPaymentStatus.Width = 70;

            // panelBookingActions
            this.panelBookingActions.BackColor = System.Drawing.Color.White;
            this.panelBookingActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookingActions.Controls.Add(this.lblBookingCount);
            this.panelBookingActions.Controls.Add(this.btnPrintTicket);
            this.panelBookingActions.Controls.Add(this.btnCancelBookingAction);
            this.panelBookingActions.Controls.Add(this.btnModifyBooking);
            this.panelBookingActions.Controls.Add(this.btnViewBookingDetails);
            this.panelBookingActions.Location = new System.Drawing.Point(0, 598);
            this.panelBookingActions.Name = "panelBookingActions";
            this.panelBookingActions.Size = new System.Drawing.Size(975, 48);

            this.btnViewBookingDetails.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnViewBookingDetails.FlatAppearance.BorderSize = 0;
            this.btnViewBookingDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewBookingDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewBookingDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewBookingDetails.Location = new System.Drawing.Point(12, 8);
            this.btnViewBookingDetails.Name = "btnViewBookingDetails";
            this.btnViewBookingDetails.Size = new System.Drawing.Size(120, 32);
            this.btnViewBookingDetails.Text = "👁️  View Dossier";

            this.btnModifyBooking.BackColor = System.Drawing.Color.White;
            this.btnModifyBooking.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnModifyBooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyBooking.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnModifyBooking.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnModifyBooking.Location = new System.Drawing.Point(140, 8);
            this.btnModifyBooking.Name = "btnModifyBooking";
            this.btnModifyBooking.Size = new System.Drawing.Size(120, 32);
            this.btnModifyBooking.Text = "✏️  Edit Booking";

            this.btnCancelBookingAction.BackColor = System.Drawing.Color.White;
            this.btnCancelBookingAction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCancelBookingAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelBookingAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelBookingAction.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnCancelBookingAction.Location = new System.Drawing.Point(268, 8);
            this.btnCancelBookingAction.Name = "btnCancelBookingAction";
            this.btnCancelBookingAction.Size = new System.Drawing.Size(125, 32);
            this.btnCancelBookingAction.Text = "❌  Cancel Booking";

            this.btnPrintTicket.BackColor = System.Drawing.Color.White;
            this.btnPrintTicket.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnPrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintTicket.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnPrintTicket.Location = new System.Drawing.Point(402, 8);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(130, 32);
            this.btnPrintTicket.Text = "🖨️  Print Boarding Pass";

            this.lblBookingCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookingCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblBookingCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblBookingCount.Location = new System.Drawing.Point(750, 14);
            this.lblBookingCount.Name = "lblBookingCount";
            this.lblBookingCount.Size = new System.Drawing.Size(210, 20);
            this.lblBookingCount.Text = "Showing 0 bookings";
            this.lblBookingCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // 5. TICKETS DIRECTORY VIEW
            // ==========================================
            this.panelTicketManagement.AutoScroll = true;
            this.panelTicketManagement.Controls.Add(this.panelTicketActions);
            this.panelTicketManagement.Controls.Add(this.lvTickets);
            this.panelTicketManagement.Controls.Add(this.panelTicketsToolbar);
            this.panelTicketManagement.Controls.Add(this.flowTicketMetrics);
            this.panelTicketManagement.Controls.Add(this.panelTicketsHeader);
            this.panelTicketManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTicketManagement.Location = new System.Drawing.Point(20, 72);
            this.panelTicketManagement.Name = "panelTicketManagement";
            this.panelTicketManagement.Size = new System.Drawing.Size(990, 684);
            this.panelTicketManagement.Visible = false;

            this.panelTicketsHeader.Controls.Add(this.btnVerifyBoardModal);
            this.panelTicketsHeader.Controls.Add(this.btnNewTicket);
            this.panelTicketsHeader.Controls.Add(this.lblTicketsSubtitle);
            this.panelTicketsHeader.Controls.Add(this.lblTicketsTitle);
            this.panelTicketsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTicketsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelTicketsHeader.Name = "panelTicketsHeader";
            this.panelTicketsHeader.Size = new System.Drawing.Size(990, 60);

            this.lblTicketsTitle.AutoSize = true;
            this.lblTicketsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTicketsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblTicketsTitle.Location = new System.Drawing.Point(0, 4);
            this.lblTicketsTitle.Name = "lblTicketsTitle";
            this.lblTicketsTitle.Size = new System.Drawing.Size(370, 25);
            this.lblTicketsTitle.Text = "Tickets Directory & Issuance Station";

            this.lblTicketsSubtitle.AutoSize = true;
            this.lblTicketsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTicketsSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTicketsSubtitle.Location = new System.Drawing.Point(2, 33);
            this.lblTicketsSubtitle.Name = "lblTicketsSubtitle";
            this.lblTicketsSubtitle.Size = new System.Drawing.Size(590, 15);
            this.lblTicketsSubtitle.Text = "Complete ledger of all issued boarding passes, seat allocations, and gate verification statuses.";

            this.btnVerifyBoardModal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerifyBoardModal.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnVerifyBoardModal.FlatAppearance.BorderSize = 0;
            this.btnVerifyBoardModal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyBoardModal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerifyBoardModal.ForeColor = System.Drawing.Color.White;
            this.btnVerifyBoardModal.Location = new System.Drawing.Point(630, 14);
            this.btnVerifyBoardModal.Name = "btnVerifyBoardModal";
            this.btnVerifyBoardModal.Size = new System.Drawing.Size(180, 34);
            this.btnVerifyBoardModal.Text = "🔍  Boarding Scanner";

            this.btnNewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewTicket.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnNewTicket.FlatAppearance.BorderSize = 0;
            this.btnNewTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTicket.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewTicket.ForeColor = System.Drawing.Color.White;
            this.btnNewTicket.Location = new System.Drawing.Point(818, 14);
            this.btnNewTicket.Name = "btnNewTicket";
            this.btnNewTicket.Size = new System.Drawing.Size(155, 34);
            this.btnNewTicket.Text = "➕  Issue Ticket";

            // Ticket Metrics
            this.flowTicketMetrics.Controls.Add(this.cardTotalTickets);
            this.flowTicketMetrics.Controls.Add(this.cardValidTickets);
            this.flowTicketMetrics.Controls.Add(this.cardBoardedTickets);
            this.flowTicketMetrics.Controls.Add(this.cardCancelledTickets);
            this.flowTicketMetrics.Controls.Add(this.cardTodayTickets);
            this.flowTicketMetrics.Location = new System.Drawing.Point(0, 64);
            this.flowTicketMetrics.Name = "flowTicketMetrics";
            this.flowTicketMetrics.Size = new System.Drawing.Size(985, 84);

            BuildMetricCard(out this.cardTotalTickets, out this.lblMetricTotalTicketsVal, out this.lblMetricTotalTicketsTitle, out this.lblMetricTotalTicketsSub, "TOTAL TICKETS", "0", "All issued passes", Color.FromArgb(15, 23, 42));
            BuildMetricCard(out this.cardValidTickets, out this.lblMetricValidTicketsVal, out this.lblMetricValidTicketsTitle, out this.lblMetricValidTicketsSub, "VALID / ACTIVE", "0", "Ready for boarding", Color.FromArgb(13, 94, 234));
            BuildMetricCard(out this.cardBoardedTickets, out this.lblMetricBoardedTicketsVal, out this.lblMetricBoardedTicketsTitle, out this.lblMetricBoardedTicketsSub, "BOARDED / USED", "0", "Cleared passengers", Color.FromArgb(16, 185, 129));
            BuildMetricCard(out this.cardCancelledTickets, out this.lblMetricCancelledTicketsVal, out this.lblMetricCancelledTicketsTitle, out this.lblMetricCancelledTicketsSub, "CANCELLED", "0", "Voided / refunded", Color.FromArgb(239, 68, 68));
            BuildMetricCard(out this.cardTodayTickets, out this.lblMetricTodayTicketsVal, out this.lblMetricTodayTicketsTitle, out this.lblMetricTodayTicketsSub, "TODAY\'S TICKETS", "0", "Departures today", Color.FromArgb(234, 88, 12));

            // Tickets Toolbar
            this.panelTicketsToolbar.BackColor = System.Drawing.Color.White;
            this.panelTicketsToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicketsToolbar.Controls.Add(this.btnResetTicketFilters);
            this.panelTicketsToolbar.Controls.Add(this.dtpTicketFilterDate);
            this.panelTicketsToolbar.Controls.Add(this.chkEnableTicketDateFilter);
            this.panelTicketsToolbar.Controls.Add(this.cmbTicketRouteFilter);
            this.panelTicketsToolbar.Controls.Add(this.cmbTicketStatusFilter);
            this.panelTicketsToolbar.Controls.Add(this.txtSearchTicketFilter);
            this.panelTicketsToolbar.Location = new System.Drawing.Point(0, 154);
            this.panelTicketsToolbar.Name = "panelTicketsToolbar";
            this.panelTicketsToolbar.Size = new System.Drawing.Size(975, 48);

            this.txtSearchTicketFilter.Location = new System.Drawing.Point(12, 12);
            this.txtSearchTicketFilter.Name = "txtSearchTicketFilter";
            this.txtSearchTicketFilter.PlaceholderText = "Search by Ticket ID, passenger, phone, code...";
            this.txtSearchTicketFilter.Size = new System.Drawing.Size(260, 23);

            this.cmbTicketStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketStatusFilter.Items.AddRange(new object[] { "All Statuses", "Valid", "Boarded", "Cancelled" });
            this.cmbTicketStatusFilter.Location = new System.Drawing.Point(282, 12);
            this.cmbTicketStatusFilter.Name = "cmbTicketStatusFilter";
            this.cmbTicketStatusFilter.Size = new System.Drawing.Size(130, 23);

            this.cmbTicketRouteFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTicketRouteFilter.Items.AddRange(new object[] { "All Routes / Trips" });
            this.cmbTicketRouteFilter.Location = new System.Drawing.Point(422, 12);
            this.cmbTicketRouteFilter.Name = "cmbTicketRouteFilter";
            this.cmbTicketRouteFilter.Size = new System.Drawing.Size(180, 23);

            this.chkEnableTicketDateFilter.AutoSize = true;
            this.chkEnableTicketDateFilter.Location = new System.Drawing.Point(614, 14);
            this.chkEnableTicketDateFilter.Name = "chkEnableTicketDateFilter";
            this.chkEnableTicketDateFilter.Size = new System.Drawing.Size(53, 19);
            this.chkEnableTicketDateFilter.Text = "Date:";

            this.dtpTicketFilterDate.Enabled = false;
            this.dtpTicketFilterDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTicketFilterDate.Location = new System.Drawing.Point(674, 12);
            this.dtpTicketFilterDate.Name = "dtpTicketFilterDate";
            this.dtpTicketFilterDate.Size = new System.Drawing.Size(120, 23);

            this.btnResetTicketFilters.BackColor = System.Drawing.Color.White;
            this.btnResetTicketFilters.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnResetTicketFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetTicketFilters.Location = new System.Drawing.Point(806, 11);
            this.btnResetTicketFilters.Name = "btnResetTicketFilters";
            this.btnResetTicketFilters.Size = new System.Drawing.Size(80, 26);
            this.btnResetTicketFilters.Text = "Reset";

            // lvTickets
            this.lvTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colTicketId, this.colTicketBookingRef, this.colTicketPassenger,
                this.colTicketPhone, this.colTicketRoute, this.colTicketDate,
                this.colTicketTime, this.colTicketSeat, this.colTicketGate,
                this.colTicketBus, this.colTicketStatus
            });
            this.lvTickets.FullRowSelect = true;
            this.lvTickets.GridLines = true;
            this.lvTickets.Location = new System.Drawing.Point(0, 210);
            this.lvTickets.MultiSelect = false;
            this.lvTickets.Name = "lvTickets";
            this.lvTickets.Size = new System.Drawing.Size(975, 380);
            this.lvTickets.TabIndex = 3;
            this.lvTickets.UseCompatibleStateImageBehavior = false;
            this.lvTickets.View = System.Windows.Forms.View.Details;

            this.colTicketId.Text = "Ticket ID"; this.colTicketId.Width = 85;
            this.colTicketBookingRef.Text = "Booking Ref"; this.colTicketBookingRef.Width = 85;
            this.colTicketPassenger.Text = "Passenger"; this.colTicketPassenger.Width = 140;
            this.colTicketPhone.Text = "Phone"; this.colTicketPhone.Width = 110;
            this.colTicketRoute.Text = "Route"; this.colTicketRoute.Width = 160;
            this.colTicketDate.Text = "Date"; this.colTicketDate.Width = 90;
            this.colTicketTime.Text = "Time"; this.colTicketTime.Width = 75;
            this.colTicketSeat.Text = "Seat"; this.colTicketSeat.Width = 65;
            this.colTicketGate.Text = "Gate"; this.colTicketGate.Width = 65;
            this.colTicketBus.Text = "Coach"; this.colTicketBus.Width = 90;
            this.colTicketStatus.Text = "Status"; this.colTicketStatus.Width = 80;

            // panelTicketActions
            this.panelTicketActions.BackColor = System.Drawing.Color.White;
            this.panelTicketActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTicketActions.Controls.Add(this.lblTicketCount);
            this.panelTicketActions.Controls.Add(this.btnCancelTicketAction);
            this.panelTicketActions.Controls.Add(this.btnPrintTicketPass);
            this.panelTicketActions.Controls.Add(this.btnVerifyAndBoard);
            this.panelTicketActions.Controls.Add(this.btnViewTicketDetails);
            this.panelTicketActions.Location = new System.Drawing.Point(0, 598);
            this.panelTicketActions.Name = "panelTicketActions";
            this.panelTicketActions.Size = new System.Drawing.Size(975, 48);

            this.btnViewTicketDetails.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnViewTicketDetails.FlatAppearance.BorderSize = 0;
            this.btnViewTicketDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewTicketDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewTicketDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewTicketDetails.Location = new System.Drawing.Point(12, 8);
            this.btnViewTicketDetails.Name = "btnViewTicketDetails";
            this.btnViewTicketDetails.Size = new System.Drawing.Size(120, 32);
            this.btnViewTicketDetails.Text = "👁️  View Ticket";

            this.btnVerifyAndBoard.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnVerifyAndBoard.FlatAppearance.BorderSize = 0;
            this.btnVerifyAndBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyAndBoard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerifyAndBoard.ForeColor = System.Drawing.Color.White;
            this.btnVerifyAndBoard.Location = new System.Drawing.Point(140, 8);
            this.btnVerifyAndBoard.Name = "btnVerifyAndBoard";
            this.btnVerifyAndBoard.Size = new System.Drawing.Size(160, 32);
            this.btnVerifyAndBoard.Text = "✅  Verify && Board";

            this.btnPrintTicketPass.BackColor = System.Drawing.Color.White;
            this.btnPrintTicketPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnPrintTicketPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintTicketPass.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintTicketPass.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnPrintTicketPass.Location = new System.Drawing.Point(308, 8);
            this.btnPrintTicketPass.Name = "btnPrintTicketPass";
            this.btnPrintTicketPass.Size = new System.Drawing.Size(130, 32);
            this.btnPrintTicketPass.Text = "🖨️  Print Ticket";

            this.btnCancelTicketAction.BackColor = System.Drawing.Color.White;
            this.btnCancelTicketAction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnCancelTicketAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelTicketAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancelTicketAction.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnCancelTicketAction.Location = new System.Drawing.Point(446, 8);
            this.btnCancelTicketAction.Name = "btnCancelTicketAction";
            this.btnCancelTicketAction.Size = new System.Drawing.Size(125, 32);
            this.btnCancelTicketAction.Text = "❌  Cancel Ticket";

            this.lblTicketCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTicketCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTicketCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblTicketCount.Location = new System.Drawing.Point(750, 14);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Size = new System.Drawing.Size(210, 20);
            this.lblTicketCount.Text = "Showing 0 tickets";
            this.lblTicketCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // 6. PASSENGER MANIFEST & BOARDING VIEW
            // ==========================================
            this.panelManifest.AutoScroll = true;
            this.panelManifest.Controls.Add(this.panelManifestActions);
            this.panelManifest.Controls.Add(this.lvManifest);
            this.panelManifest.Controls.Add(this.flowManifestMetrics);
            this.panelManifest.Controls.Add(this.panelManifestToolbar);
            this.panelManifest.Controls.Add(this.panelManifestHeader);
            this.panelManifest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelManifest.Location = new System.Drawing.Point(20, 72);
            this.panelManifest.Name = "panelManifest";
            this.panelManifest.Size = new System.Drawing.Size(990, 684);
            this.panelManifest.Visible = false;

            this.panelManifestHeader.Controls.Add(this.lblManifestSubtitle);
            this.panelManifestHeader.Controls.Add(this.lblManifestTitle);
            this.panelManifestHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManifestHeader.Location = new System.Drawing.Point(0, 0);
            this.panelManifestHeader.Name = "panelManifestHeader";
            this.panelManifestHeader.Size = new System.Drawing.Size(990, 60);

            this.lblManifestTitle.AutoSize = true;
            this.lblManifestTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblManifestTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblManifestTitle.Location = new System.Drawing.Point(0, 4);
            this.lblManifestTitle.Name = "lblManifestTitle";
            this.lblManifestTitle.Size = new System.Drawing.Size(390, 25);
            this.lblManifestTitle.Text = "Passenger Manifest & Boarding Oversight";

            this.lblManifestSubtitle.AutoSize = true;
            this.lblManifestSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblManifestSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblManifestSubtitle.Location = new System.Drawing.Point(2, 33);
            this.lblManifestSubtitle.Name = "lblManifestSubtitle";
            this.lblManifestSubtitle.Size = new System.Drawing.Size(630, 15);
            this.lblManifestSubtitle.Text = "Review passenger manifest for any scheduled trip, record boarding status, identify absentees, and print departure logs.";

            // Manifest Toolbar
            this.panelManifestToolbar.BackColor = System.Drawing.Color.White;
            this.panelManifestToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManifestToolbar.Controls.Add(this.btnLoadManifest);
            this.panelManifestToolbar.Controls.Add(this.dtpManifestDate);
            this.panelManifestToolbar.Controls.Add(this.lblManifestDatePrompt);
            this.panelManifestToolbar.Controls.Add(this.cmbManifestRoute);
            this.panelManifestToolbar.Controls.Add(this.lblManifestRoutePrompt);
            this.panelManifestToolbar.Location = new System.Drawing.Point(0, 64);
            this.panelManifestToolbar.Name = "panelManifestToolbar";
            this.panelManifestToolbar.Size = new System.Drawing.Size(975, 48);

            this.lblManifestRoutePrompt.AutoSize = true;
            this.lblManifestRoutePrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblManifestRoutePrompt.Location = new System.Drawing.Point(12, 16);
            this.lblManifestRoutePrompt.Name = "lblManifestRoutePrompt";
            this.lblManifestRoutePrompt.Size = new System.Drawing.Size(74, 15);
            this.lblManifestRoutePrompt.Text = "Select Trip:";

            this.cmbManifestRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbManifestRoute.Location = new System.Drawing.Point(92, 12);
            this.cmbManifestRoute.Name = "cmbManifestRoute";
            this.cmbManifestRoute.Size = new System.Drawing.Size(320, 23);

            this.lblManifestDatePrompt.AutoSize = true;
            this.lblManifestDatePrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblManifestDatePrompt.Location = new System.Drawing.Point(430, 16);
            this.lblManifestDatePrompt.Name = "lblManifestDatePrompt";
            this.lblManifestDatePrompt.Size = new System.Drawing.Size(73, 15);
            this.lblManifestDatePrompt.Text = "Travel Date:";

            this.dtpManifestDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpManifestDate.Location = new System.Drawing.Point(510, 12);
            this.dtpManifestDate.Name = "dtpManifestDate";
            this.dtpManifestDate.Size = new System.Drawing.Size(130, 23);

            this.btnLoadManifest.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnLoadManifest.FlatAppearance.BorderSize = 0;
            this.btnLoadManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadManifest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnLoadManifest.ForeColor = System.Drawing.Color.White;
            this.btnLoadManifest.Location = new System.Drawing.Point(660, 10);
            this.btnLoadManifest.Name = "btnLoadManifest";
            this.btnLoadManifest.Size = new System.Drawing.Size(140, 28);
            this.btnLoadManifest.Text = "🔍  Load Manifest";

            // Manifest Metrics
            this.flowManifestMetrics.Controls.Add(this.cardManifestTotal);
            this.flowManifestMetrics.Controls.Add(this.cardManifestBoarded);
            this.flowManifestMetrics.Controls.Add(this.cardManifestPending);
            this.flowManifestMetrics.Controls.Add(this.cardManifestNoShow);
            this.flowManifestMetrics.Location = new System.Drawing.Point(0, 118);
            this.flowManifestMetrics.Name = "flowManifestMetrics";
            this.flowManifestMetrics.Size = new System.Drawing.Size(985, 76);

            BuildMetricCard(out this.cardManifestTotal, out this.lblManifestTotalVal, out this.lblManifestTotalTitle, out _, "MANIFEST SEATS", "0", "Booked on coach", Color.FromArgb(15, 23, 42));
            BuildMetricCard(out this.cardManifestBoarded, out this.lblManifestBoardedVal, out this.lblManifestBoardedTitle, out _, "BOARDED", "0", "Checked-in", Color.FromArgb(16, 185, 129));
            BuildMetricCard(out this.cardManifestPending, out this.lblManifestPendingVal, out this.lblManifestPendingTitle, out _, "AWAITING BOARDING", "0", "At terminal", Color.FromArgb(234, 88, 12));
            BuildMetricCard(out this.cardManifestNoShow, out this.lblManifestNoShowVal, out this.lblManifestNoShowTitle, out _, "ABSENT / NO-SHOW", "0", "Unchecked", Color.FromArgb(239, 68, 68));

            // lvManifest
            this.lvManifest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colManSeat, this.colManPassenger, this.colManPhone,
                this.colManTicketId, this.colManBookingId, this.colManGate,
                this.colManStatus, this.colManBoardedTime, this.colManVerifiedBy
            });
            this.lvManifest.FullRowSelect = true;
            this.lvManifest.GridLines = true;
            this.lvManifest.Location = new System.Drawing.Point(0, 200);
            this.lvManifest.MultiSelect = false;
            this.lvManifest.Name = "lvManifest";
            this.lvManifest.Size = new System.Drawing.Size(975, 390);
            this.lvManifest.TabIndex = 3;
            this.lvManifest.UseCompatibleStateImageBehavior = false;
            this.lvManifest.View = System.Windows.Forms.View.Details;

            this.colManSeat.Text = "Seat #"; this.colManSeat.Width = 65;
            this.colManPassenger.Text = "Passenger Name"; this.colManPassenger.Width = 160;
            this.colManPhone.Text = "Phone Number"; this.colManPhone.Width = 120;
            this.colManTicketId.Text = "Ticket ID"; this.colManTicketId.Width = 90;
            this.colManBookingId.Text = "Booking Ref"; this.colManBookingId.Width = 90;
            this.colManGate.Text = "Gate"; this.colManGate.Width = 65;
            this.colManStatus.Text = "Boarding Status"; this.colManStatus.Width = 110;
            this.colManBoardedTime.Text = "Check-In Time"; this.colManBoardedTime.Width = 120;
            this.colManVerifiedBy.Text = "Gate Officer"; this.colManVerifiedBy.Width = 130;

            // panelManifestActions
            this.panelManifestActions.BackColor = System.Drawing.Color.White;
            this.panelManifestActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelManifestActions.Controls.Add(this.lblManifestCount);
            this.panelManifestActions.Controls.Add(this.btnVerifyManifestPassenger);
            this.panelManifestActions.Controls.Add(this.btnPrintManifest);
            this.panelManifestActions.Controls.Add(this.btnManifestMarkAbsent);
            this.panelManifestActions.Controls.Add(this.btnManifestMarkBoarded);
            this.panelManifestActions.Location = new System.Drawing.Point(0, 598);
            this.panelManifestActions.Name = "panelManifestActions";
            this.panelManifestActions.Size = new System.Drawing.Size(975, 48);

            this.btnManifestMarkBoarded.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnManifestMarkBoarded.FlatAppearance.BorderSize = 0;
            this.btnManifestMarkBoarded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManifestMarkBoarded.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManifestMarkBoarded.ForeColor = System.Drawing.Color.White;
            this.btnManifestMarkBoarded.Location = new System.Drawing.Point(12, 8);
            this.btnManifestMarkBoarded.Name = "btnManifestMarkBoarded";
            this.btnManifestMarkBoarded.Size = new System.Drawing.Size(160, 32);
            this.btnManifestMarkBoarded.Text = "✅  Confirm Boarded";

            this.btnManifestMarkAbsent.BackColor = System.Drawing.Color.White;
            this.btnManifestMarkAbsent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnManifestMarkAbsent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManifestMarkAbsent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnManifestMarkAbsent.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnManifestMarkAbsent.Location = new System.Drawing.Point(180, 8);
            this.btnManifestMarkAbsent.Name = "btnManifestMarkAbsent";
            this.btnManifestMarkAbsent.Size = new System.Drawing.Size(150, 32);
            this.btnManifestMarkAbsent.Text = "⚠️  Mark as No-Show";

            this.btnPrintManifest.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnPrintManifest.FlatAppearance.BorderSize = 0;
            this.btnPrintManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintManifest.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintManifest.ForeColor = System.Drawing.Color.White;
            this.btnPrintManifest.Location = new System.Drawing.Point(338, 8);
            this.btnPrintManifest.Name = "btnPrintManifest";
            this.btnPrintManifest.Size = new System.Drawing.Size(160, 32);
            this.btnPrintManifest.Text = "🖨️  Print Trip Manifest";

            this.btnVerifyManifestPassenger.BackColor = System.Drawing.Color.White;
            this.btnVerifyManifestPassenger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnVerifyManifestPassenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerifyManifestPassenger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnVerifyManifestPassenger.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.btnVerifyManifestPassenger.Location = new System.Drawing.Point(506, 8);
            this.btnVerifyManifestPassenger.Name = "btnVerifyManifestPassenger";
            this.btnVerifyManifestPassenger.Size = new System.Drawing.Size(150, 32);
            this.btnVerifyManifestPassenger.Text = "🔍  Verify Identity";

            this.lblManifestCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblManifestCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblManifestCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblManifestCount.Location = new System.Drawing.Point(750, 14);
            this.lblManifestCount.Name = "lblManifestCount";
            this.lblManifestCount.Size = new System.Drawing.Size(210, 20);
            this.lblManifestCount.Text = "Manifest: 0 passengers";
            this.lblManifestCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // 7. COUNTER PAYMENTS & CASHIER VIEW
            // ==========================================
            this.panelPayments.AutoScroll = true;
            this.panelPayments.Controls.Add(this.panelPaymentActions);
            this.panelPayments.Controls.Add(this.lvPayments);
            this.panelPayments.Controls.Add(this.panelPaymentsToolbar);
            this.panelPayments.Controls.Add(this.flowPaymentMetrics);
            this.panelPayments.Controls.Add(this.panelPaymentsHeader);
            this.panelPayments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPayments.Location = new System.Drawing.Point(20, 72);
            this.panelPayments.Name = "panelPayments";
            this.panelPayments.Size = new System.Drawing.Size(990, 684);
            this.panelPayments.Visible = false;

            this.panelPaymentsHeader.Controls.Add(this.lblPaymentsSubtitle);
            this.panelPaymentsHeader.Controls.Add(this.lblPaymentsTitle);
            this.panelPaymentsHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPaymentsHeader.Location = new System.Drawing.Point(0, 0);
            this.panelPaymentsHeader.Name = "panelPaymentsHeader";
            this.panelPaymentsHeader.Size = new System.Drawing.Size(990, 60);

            this.lblPaymentsTitle.AutoSize = true;
            this.lblPaymentsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPaymentsTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblPaymentsTitle.Location = new System.Drawing.Point(0, 4);
            this.lblPaymentsTitle.Name = "lblPaymentsTitle";
            this.lblPaymentsTitle.Size = new System.Drawing.Size(370, 25);
            this.lblPaymentsTitle.Text = "Counter Cashier & Payment Receipts";

            this.lblPaymentsSubtitle.AutoSize = true;
            this.lblPaymentsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaymentsSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPaymentsSubtitle.Location = new System.Drawing.Point(2, 33);
            this.lblPaymentsSubtitle.Name = "lblPaymentsSubtitle";
            this.lblPaymentsSubtitle.Size = new System.Drawing.Size(610, 15);
            this.lblPaymentsSubtitle.Text = "Manage walk-in counter payments, verify electronic transfers (Telebirr/CBE Birr), issue receipts, and process refunds.";

            // Payment Metrics
            this.flowPaymentMetrics.Controls.Add(this.cardPayTotal);
            this.flowPaymentMetrics.Controls.Add(this.cardPayCash);
            this.flowPaymentMetrics.Controls.Add(this.cardPayDigital);
            this.flowPaymentMetrics.Controls.Add(this.cardPayRefunds);
            this.flowPaymentMetrics.Location = new System.Drawing.Point(0, 64);
            this.flowPaymentMetrics.Name = "flowPaymentMetrics";
            this.flowPaymentMetrics.Size = new System.Drawing.Size(985, 76);

            BuildMetricCard(out this.cardPayTotal, out this.lblPayTotalVal, out this.lblPayTotalTitle, out _, "TODAY\'S INTAKE", "0 ETB", "Total collections", Color.FromArgb(13, 94, 234));
            BuildMetricCard(out this.cardPayCash, out this.lblPayCashVal, out this.lblPayCashTitle, out _, "CASH PAYMENTS", "0 ETB", "Counter drawer", Color.FromArgb(16, 185, 129));
            BuildMetricCard(out this.cardPayDigital, out this.lblPayDigitalVal, out this.lblPayDigitalTitle, out _, "DIGITAL / TELEBIRR", "0 ETB", "Electronic money", Color.FromArgb(234, 88, 12));
            BuildMetricCard(out this.cardPayRefunds, out this.lblPayRefundsVal, out this.lblPayRefundsTitle, out _, "REFUNDS ISSUED", "0 ETB", "Cancelled bookings", Color.FromArgb(239, 68, 68));

            // Payments Toolbar
            this.panelPaymentsToolbar.BackColor = System.Drawing.Color.White;
            this.panelPaymentsToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaymentsToolbar.Controls.Add(this.btnRefreshPayments);
            this.panelPaymentsToolbar.Controls.Add(this.cmbPaymentStatusFilter);
            this.panelPaymentsToolbar.Controls.Add(this.cmbPaymentMethodFilter);
            this.panelPaymentsToolbar.Controls.Add(this.txtSearchPayments);
            this.panelPaymentsToolbar.Location = new System.Drawing.Point(0, 146);
            this.panelPaymentsToolbar.Name = "panelPaymentsToolbar";
            this.panelPaymentsToolbar.Size = new System.Drawing.Size(975, 48);

            this.txtSearchPayments.Location = new System.Drawing.Point(12, 12);
            this.txtSearchPayments.Name = "txtSearchPayments";
            this.txtSearchPayments.PlaceholderText = "Search by receipt #, booking, passenger name...";
            this.txtSearchPayments.Size = new System.Drawing.Size(320, 23);

            this.cmbPaymentMethodFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMethodFilter.Items.AddRange(new object[] { "All Methods", "Cash", "Telebirr", "CBE Birr", "Card" });
            this.cmbPaymentMethodFilter.Location = new System.Drawing.Point(344, 12);
            this.cmbPaymentMethodFilter.Name = "cmbPaymentMethodFilter";
            this.cmbPaymentMethodFilter.Size = new System.Drawing.Size(150, 23);

            this.cmbPaymentStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatusFilter.Items.AddRange(new object[] { "All Statuses", "Paid", "Pending", "Refunded" });
            this.cmbPaymentStatusFilter.Location = new System.Drawing.Point(504, 12);
            this.cmbPaymentStatusFilter.Name = "cmbPaymentStatusFilter";
            this.cmbPaymentStatusFilter.Size = new System.Drawing.Size(150, 23);

            this.btnRefreshPayments.BackColor = System.Drawing.Color.White;
            this.btnRefreshPayments.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRefreshPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshPayments.Location = new System.Drawing.Point(666, 11);
            this.btnRefreshPayments.Name = "btnRefreshPayments";
            this.btnRefreshPayments.Size = new System.Drawing.Size(90, 26);
            this.btnRefreshPayments.Text = "Refresh";

            // lvPayments
            this.lvPayments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colPayReceipt, this.colPayBooking, this.colPayTicket,
                this.colPayPassenger, this.colPayRoute, this.colPayAmount,
                this.colPayMethod, this.colPayStatus, this.colPayDate, this.colPayCashier
            });
            this.lvPayments.FullRowSelect = true;
            this.lvPayments.GridLines = true;
            this.lvPayments.Location = new System.Drawing.Point(0, 202);
            this.lvPayments.MultiSelect = false;
            this.lvPayments.Name = "lvPayments";
            this.lvPayments.Size = new System.Drawing.Size(975, 388);
            this.lvPayments.TabIndex = 3;
            this.lvPayments.UseCompatibleStateImageBehavior = false;
            this.lvPayments.View = System.Windows.Forms.View.Details;

            this.colPayReceipt.Text = "Receipt #"; this.colPayReceipt.Width = 90;
            this.colPayBooking.Text = "Booking Ref"; this.colPayBooking.Width = 90;
            this.colPayTicket.Text = "Ticket ID"; this.colPayTicket.Width = 85;
            this.colPayPassenger.Text = "Passenger Name"; this.colPayPassenger.Width = 140;
            this.colPayRoute.Text = "Route"; this.colPayRoute.Width = 150;
            this.colPayAmount.Text = "Amount (ETB)"; this.colPayAmount.Width = 95;
            this.colPayMethod.Text = "Method"; this.colPayMethod.Width = 85;
            this.colPayStatus.Text = "Status"; this.colPayStatus.Width = 75;
            this.colPayDate.Text = "Timestamp"; this.colPayDate.Width = 120;
            this.colPayCashier.Text = "Cashier / Officer"; this.colPayCashier.Width = 130;

            // panelPaymentActions
            this.panelPaymentActions.BackColor = System.Drawing.Color.White;
            this.panelPaymentActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaymentActions.Controls.Add(this.lblPaymentCount);
            this.panelPaymentActions.Controls.Add(this.btnProcessRefund);
            this.panelPaymentActions.Controls.Add(this.btnRecordPayment);
            this.panelPaymentActions.Controls.Add(this.btnPrintReceipt);
            this.panelPaymentActions.Location = new System.Drawing.Point(0, 598);
            this.panelPaymentActions.Name = "panelPaymentActions";
            this.panelPaymentActions.Size = new System.Drawing.Size(975, 48);

            this.btnPrintReceipt.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnPrintReceipt.FlatAppearance.BorderSize = 0;
            this.btnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPrintReceipt.ForeColor = System.Drawing.Color.White;
            this.btnPrintReceipt.Location = new System.Drawing.Point(12, 8);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(160, 32);
            this.btnPrintReceipt.Text = "🧾  Print Official Receipt";

            this.btnRecordPayment.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnRecordPayment.FlatAppearance.BorderSize = 0;
            this.btnRecordPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordPayment.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRecordPayment.ForeColor = System.Drawing.Color.White;
            this.btnRecordPayment.Location = new System.Drawing.Point(180, 8);
            this.btnRecordPayment.Name = "btnRecordPayment";
            this.btnRecordPayment.Size = new System.Drawing.Size(180, 32);
            this.btnRecordPayment.Text = "💵  Record Cash Payment";

            this.btnProcessRefund.BackColor = System.Drawing.Color.White;
            this.btnProcessRefund.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnProcessRefund.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessRefund.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnProcessRefund.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38);
            this.btnProcessRefund.Location = new System.Drawing.Point(370, 8);
            this.btnProcessRefund.Name = "btnProcessRefund";
            this.btnProcessRefund.Size = new System.Drawing.Size(170, 32);
            this.btnProcessRefund.Text = "🔄  Issue Cancellation Refund";

            this.lblPaymentCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPaymentCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPaymentCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblPaymentCount.Location = new System.Drawing.Point(750, 14);
            this.lblPaymentCount.Name = "lblPaymentCount";
            this.lblPaymentCount.Size = new System.Drawing.Size(210, 20);
            this.lblPaymentCount.Text = "Showing 0 transactions";
            this.lblPaymentCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // 8. CUSTOMER HELPDESK & INQUIRIES VIEW
            // ==========================================
            this.panelFeedback.AutoScroll = true;
            this.panelFeedback.Controls.Add(this.panelFeedbackActions);
            this.panelFeedback.Controls.Add(this.lvInquiries);
            this.panelFeedback.Controls.Add(this.panelFeedbackToolbar);
            this.panelFeedback.Controls.Add(this.flowFeedbackMetrics);
            this.panelFeedback.Controls.Add(this.panelFeedbackHeader);
            this.panelFeedback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFeedback.Location = new System.Drawing.Point(20, 72);
            this.panelFeedback.Name = "panelFeedback";
            this.panelFeedback.Size = new System.Drawing.Size(990, 684);
            this.panelFeedback.Visible = false;

            this.panelFeedbackHeader.Controls.Add(this.btnNewInquiry);
            this.panelFeedbackHeader.Controls.Add(this.lblFeedbackSubtitle);
            this.panelFeedbackHeader.Controls.Add(this.lblFeedbackTitle);
            this.panelFeedbackHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFeedbackHeader.Location = new System.Drawing.Point(0, 0);
            this.panelFeedbackHeader.Name = "panelFeedbackHeader";
            this.panelFeedbackHeader.Size = new System.Drawing.Size(990, 60);

            this.lblFeedbackTitle.AutoSize = true;
            this.lblFeedbackTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFeedbackTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblFeedbackTitle.Location = new System.Drawing.Point(0, 4);
            this.lblFeedbackTitle.Name = "lblFeedbackTitle";
            this.lblFeedbackTitle.Size = new System.Drawing.Size(370, 25);
            this.lblFeedbackTitle.Text = "Customer Inquiries & Terminal Helpdesk";

            this.lblFeedbackSubtitle.AutoSize = true;
            this.lblFeedbackSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblFeedbackSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblFeedbackSubtitle.Location = new System.Drawing.Point(2, 33);
            this.lblFeedbackSubtitle.Name = "lblFeedbackSubtitle";
            this.lblFeedbackSubtitle.Size = new System.Drawing.Size(610, 15);
            this.lblFeedbackSubtitle.Text = "Assist passengers with inquiries, special boarding assistance, lost luggage reporting, and complaint resolution.";

            this.btnNewInquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewInquiry.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnNewInquiry.FlatAppearance.BorderSize = 0;
            this.btnNewInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewInquiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnNewInquiry.ForeColor = System.Drawing.Color.White;
            this.btnNewInquiry.Location = new System.Drawing.Point(800, 14);
            this.btnNewInquiry.Name = "btnNewInquiry";
            this.btnNewInquiry.Size = new System.Drawing.Size(175, 34);
            this.btnNewInquiry.Text = "➕  Log New Inquiry";

            // Helpdesk Metrics
            this.flowFeedbackMetrics.Controls.Add(this.cardInqTotal);
            this.flowFeedbackMetrics.Controls.Add(this.cardInqPending);
            this.flowFeedbackMetrics.Controls.Add(this.cardInqResolved);
            this.flowFeedbackMetrics.Location = new System.Drawing.Point(0, 64);
            this.flowFeedbackMetrics.Name = "flowFeedbackMetrics";
            this.flowFeedbackMetrics.Size = new System.Drawing.Size(985, 76);

            BuildMetricCard(out this.cardInqTotal, out this.lblInqTotalVal, out this.lblInqTotalTitle, out _, "TOTAL INQUIRIES", "0", "Logged requests", Color.FromArgb(15, 23, 42));
            BuildMetricCard(out this.cardInqPending, out this.lblInqPendingVal, out this.lblInqPendingTitle, out _, "PENDING ACTION", "0", "Awaiting resolution", Color.FromArgb(234, 88, 12));
            BuildMetricCard(out this.cardInqResolved, out this.lblInqResolvedVal, out this.lblInqResolvedTitle, out _, "RESOLVED REQUESTS", "0", "Handled by desk", Color.FromArgb(16, 185, 129));

            // Helpdesk Toolbar
            this.panelFeedbackToolbar.BackColor = System.Drawing.Color.White;
            this.panelFeedbackToolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFeedbackToolbar.Controls.Add(this.btnRefreshInquiries);
            this.panelFeedbackToolbar.Controls.Add(this.cmbInquiryStatusFilter);
            this.panelFeedbackToolbar.Controls.Add(this.txtSearchInquiries);
            this.panelFeedbackToolbar.Location = new System.Drawing.Point(0, 146);
            this.panelFeedbackToolbar.Name = "panelFeedbackToolbar";
            this.panelFeedbackToolbar.Size = new System.Drawing.Size(975, 48);

            this.txtSearchInquiries.Location = new System.Drawing.Point(12, 12);
            this.txtSearchInquiries.Name = "txtSearchInquiries";
            this.txtSearchInquiries.PlaceholderText = "Search by ID, passenger name, category, subject...";
            this.txtSearchInquiries.Size = new System.Drawing.Size(340, 23);

            this.cmbInquiryStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInquiryStatusFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "Resolved" });
            this.cmbInquiryStatusFilter.Location = new System.Drawing.Point(364, 12);
            this.cmbInquiryStatusFilter.Name = "cmbInquiryStatusFilter";
            this.cmbInquiryStatusFilter.Size = new System.Drawing.Size(140, 23);

            this.btnRefreshInquiries.BackColor = System.Drawing.Color.White;
            this.btnRefreshInquiries.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnRefreshInquiries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshInquiries.Location = new System.Drawing.Point(516, 11);
            this.btnRefreshInquiries.Name = "btnRefreshInquiries";
            this.btnRefreshInquiries.Size = new System.Drawing.Size(90, 26);
            this.btnRefreshInquiries.Text = "Refresh";

            // lvInquiries
            this.lvInquiries.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colInqId, this.colInqPassenger, this.colInqPhone,
                this.colInqCategory, this.colInqSubject, this.colInqStatus,
                this.colInqDate, this.colInqOfficer
            });
            this.lvInquiries.FullRowSelect = true;
            this.lvInquiries.GridLines = true;
            this.lvInquiries.Location = new System.Drawing.Point(0, 202);
            this.lvInquiries.MultiSelect = false;
            this.lvInquiries.Name = "lvInquiries";
            this.lvInquiries.Size = new System.Drawing.Size(975, 388);
            this.lvInquiries.TabIndex = 3;
            this.lvInquiries.UseCompatibleStateImageBehavior = false;
            this.lvInquiries.View = System.Windows.Forms.View.Details;

            this.colInqId.Text = "Inquiry ID"; this.colInqId.Width = 85;
            this.colInqPassenger.Text = "Passenger Name"; this.colInqPassenger.Width = 140;
            this.colInqPhone.Text = "Phone"; this.colInqPhone.Width = 110;
            this.colInqCategory.Text = "Category"; this.colInqCategory.Width = 120;
            this.colInqSubject.Text = "Subject / Request"; this.colInqSubject.Width = 220;
            this.colInqStatus.Text = "Status"; this.colInqStatus.Width = 85;
            this.colInqDate.Text = "Recorded At"; this.colInqDate.Width = 120;
            this.colInqOfficer.Text = "Attended By"; this.colInqOfficer.Width = 110;

            // panelFeedbackActions
            this.panelFeedbackActions.BackColor = System.Drawing.Color.White;
            this.panelFeedbackActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFeedbackActions.Controls.Add(this.lblInquiryCount);
            this.panelFeedbackActions.Controls.Add(this.btnViewInquiryDetails);
            this.panelFeedbackActions.Controls.Add(this.btnResolveInquiry);
            this.panelFeedbackActions.Location = new System.Drawing.Point(0, 598);
            this.panelFeedbackActions.Name = "panelFeedbackActions";
            this.panelFeedbackActions.Size = new System.Drawing.Size(975, 48);

            this.btnResolveInquiry.BackColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.btnResolveInquiry.FlatAppearance.BorderSize = 0;
            this.btnResolveInquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResolveInquiry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnResolveInquiry.ForeColor = System.Drawing.Color.White;
            this.btnResolveInquiry.Location = new System.Drawing.Point(12, 8);
            this.btnResolveInquiry.Name = "btnResolveInquiry";
            this.btnResolveInquiry.Size = new System.Drawing.Size(160, 32);
            this.btnResolveInquiry.Text = "✅  Mark as Resolved";

            this.btnViewInquiryDetails.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnViewInquiryDetails.FlatAppearance.BorderSize = 0;
            this.btnViewInquiryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewInquiryDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewInquiryDetails.ForeColor = System.Drawing.Color.White;
            this.btnViewInquiryDetails.Location = new System.Drawing.Point(180, 8);
            this.btnViewInquiryDetails.Name = "btnViewInquiryDetails";
            this.btnViewInquiryDetails.Size = new System.Drawing.Size(140, 32);
            this.btnViewInquiryDetails.Text = "👁️  View Details";

            this.lblInquiryCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInquiryCount.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblInquiryCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblInquiryCount.Location = new System.Drawing.Point(750, 14);
            this.lblInquiryCount.Name = "lblInquiryCount";
            this.lblInquiryCount.Size = new System.Drawing.Size(210, 20);
            this.lblInquiryCount.Text = "Showing 0 inquiries";
            this.lblInquiryCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ==========================================
            // FINAL FORM SETUP
            // ==========================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.ClientSize = new System.Drawing.Size(1260, 820);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelTopBar);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1150, 750);
            this.Name = "TicketOfficerDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bus Ticket Management - Ticket Officer Portal";

            // Resume layouts
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            this.panelOfficerProfile.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelHeaderInfo.ResumeLayout(false);
            this.panelHeaderInfo.PerformLayout();
            this.flowDashboard.ResumeLayout(false);
            this.grpOverview.ResumeLayout(false);
            this.cardTicketsToday.ResumeLayout(false);
            this.cardBoarded.ResumeLayout(false);
            this.cardPendingBoarding.ResumeLayout(false);
            this.cardRevenueToday.ResumeLayout(false);
            this.grpQuickActions.ResumeLayout(false);
            this.grpTicketVerify.ResumeLayout(false);
            this.grpTicketVerify.PerformLayout();
            this.grpTripsSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrips)).EndInit();

            this.panelIssueTicket.ResumeLayout(false);
            this.panelIssueHeader.ResumeLayout(false);
            this.panelIssueHeader.PerformLayout();
            this.panelIssueFormCard.ResumeLayout(false);
            this.panelIssueFormCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIssueSeat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIssueFare)).EndInit();
            this.panelIssueSummaryCard.ResumeLayout(false);
            this.panelIssueSummaryCard.PerformLayout();

            this.panelVerifyBoarding.ResumeLayout(false);
            this.panelVerifyHeader.ResumeLayout(false);
            this.panelVerifyHeader.PerformLayout();
            this.panelVerifyToolbar.ResumeLayout(false);
            this.panelVerifyToolbar.PerformLayout();
            this.panelVerifyBanner.ResumeLayout(false);
            this.panelVerifyBanner.PerformLayout();
            this.panelVerifyDossier.ResumeLayout(false);
            this.panelVerifyDossier.PerformLayout();
            this.panelVerifyActions.ResumeLayout(false);

            this.panelBookingManagement.ResumeLayout(false);
            this.panelBookingsHeader.ResumeLayout(false);
            this.panelBookingsHeader.PerformLayout();
            this.flowBookingMetrics.ResumeLayout(false);
            this.panelBookingsToolbar.ResumeLayout(false);
            this.panelBookingsToolbar.PerformLayout();
            this.panelBookingActions.ResumeLayout(false);

            this.panelTicketManagement.ResumeLayout(false);
            this.panelTicketsHeader.ResumeLayout(false);
            this.panelTicketsHeader.PerformLayout();
            this.flowTicketMetrics.ResumeLayout(false);
            this.panelTicketsToolbar.ResumeLayout(false);
            this.panelTicketsToolbar.PerformLayout();
            this.panelTicketActions.ResumeLayout(false);

            this.panelManifest.ResumeLayout(false);
            this.panelManifestHeader.ResumeLayout(false);
            this.panelManifestHeader.PerformLayout();
            this.panelManifestToolbar.ResumeLayout(false);
            this.panelManifestToolbar.PerformLayout();
            this.flowManifestMetrics.ResumeLayout(false);
            this.panelManifestActions.ResumeLayout(false);

            this.panelPayments.ResumeLayout(false);
            this.panelPaymentsHeader.ResumeLayout(false);
            this.panelPaymentsHeader.PerformLayout();
            this.flowPaymentMetrics.ResumeLayout(false);
            this.panelPaymentsToolbar.ResumeLayout(false);
            this.panelPaymentsToolbar.PerformLayout();
            this.panelPaymentActions.ResumeLayout(false);

            this.panelFeedback.ResumeLayout(false);
            this.panelFeedbackHeader.ResumeLayout(false);
            this.panelFeedbackHeader.PerformLayout();
            this.flowFeedbackMetrics.ResumeLayout(false);
            this.panelFeedbackToolbar.ResumeLayout(false);
            this.panelFeedbackToolbar.PerformLayout();
            this.panelFeedbackActions.ResumeLayout(false);

            this.ResumeLayout(false);
        }

        private void BuildMetricCard(out Panel card, out Label lblVal, out Label lblTitle, out Label lblSub,
                                     string title, string val, string sub, Color accentColor)
        {
            card = new Panel
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(188, 70),
                Margin = new Padding(0, 0, 8, 0)
            };

            lblVal = new Label
            {
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = accentColor,
                Location = new Point(8, 6),
                Size = new Size(170, 28),
                Text = val
            };

            lblTitle = new Label
            {
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                ForeColor = Color.FromArgb(100, 116, 139),
                Location = new Point(9, 34),
                Size = new Size(170, 16),
                Text = title
            };

            lblSub = new Label
            {
                Font = new Font("Segoe UI", 7.5F),
                ForeColor = Color.FromArgb(148, 163, 184),
                Location = new Point(9, 50),
                Size = new Size(170, 14),
                Text = sub
            };

            card.Controls.Add(lblSub);
            card.Controls.Add(lblTitle);
            card.Controls.Add(lblVal);
        }
    }
}

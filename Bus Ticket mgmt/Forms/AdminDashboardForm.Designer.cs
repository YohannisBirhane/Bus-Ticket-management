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
        private Button btnNavFeedback;
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
        private Button btnQuickFeedback;

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
            this.btnNavFeedback = new System.Windows.Forms.Button();
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
            this.btnQuickFeedback = new System.Windows.Forms.Button();

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

            this.panelTopBar.SuspendLayout();
            this.panelAdminProfile.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelMain.SuspendLayout();
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
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.panelSidebar.Controls.Add(this.btnNavLogout);
            this.panelSidebar.Controls.Add(this.btnNavSettings);
            this.panelSidebar.Controls.Add(this.btnNavFeedback);
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
            this.lblNavHeader.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
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
            this.btnNavUsers.FlatAppearance.BorderSize = 0;
            this.btnNavUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavUsers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavUsers.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavBuses.FlatAppearance.BorderSize = 0;
            this.btnNavBuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBuses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBuses.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavRoutes.FlatAppearance.BorderSize = 0;
            this.btnNavRoutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavRoutes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavRoutes.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavTrips.FlatAppearance.BorderSize = 0;
            this.btnNavTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTrips.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavTrips.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavBookings.FlatAppearance.BorderSize = 0;
            this.btnNavBookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavBookings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavBookings.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavTickets.FlatAppearance.BorderSize = 0;
            this.btnNavTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavTickets.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavTickets.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavPayments.FlatAppearance.BorderSize = 0;
            this.btnNavPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavPayments.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavPayments.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavStaff.FlatAppearance.BorderSize = 0;
            this.btnNavStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavStaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavStaff.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavFares.FlatAppearance.BorderSize = 0;
            this.btnNavFares.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFares.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavFares.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
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
            this.btnNavReports.FlatAppearance.BorderSize = 0;
            this.btnNavReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavReports.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavReports.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnNavReports.Location = new System.Drawing.Point(10, 422);
            this.btnNavReports.Name = "btnNavReports";
            this.btnNavReports.Size = new System.Drawing.Size(210, 34);
            this.btnNavReports.TabIndex = 11;
            this.btnNavReports.Text = "📈  Sales Reports";
            this.btnNavReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavReports.UseVisualStyleBackColor = true;

            // 
            // btnNavFeedback
            // 
            this.btnNavFeedback.FlatAppearance.BorderSize = 0;
            this.btnNavFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavFeedback.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnNavFeedback.Location = new System.Drawing.Point(10, 460);
            this.btnNavFeedback.Name = "btnNavFeedback";
            this.btnNavFeedback.Size = new System.Drawing.Size(210, 34);
            this.btnNavFeedback.TabIndex = 12;
            this.btnNavFeedback.Text = "💬  Feedback & Complaints";
            this.btnNavFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavFeedback.UseVisualStyleBackColor = true;

            // 
            // btnNavSettings
            // 
            this.btnNavSettings.FlatAppearance.BorderSize = 0;
            this.btnNavSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNavSettings.ForeColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnNavSettings.Location = new System.Drawing.Point(10, 498);
            this.btnNavSettings.Name = "btnNavSettings";
            this.btnNavSettings.Size = new System.Drawing.Size(210, 34);
            this.btnNavSettings.TabIndex = 13;
            this.btnNavSettings.Text = "⚙️  System Settings";
            this.btnNavSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavSettings.UseVisualStyleBackColor = true;

            // 
            // btnNavLogout
            // 
            this.btnNavLogout.FlatAppearance.BorderSize = 0;
            this.btnNavLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavLogout.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNavLogout.ForeColor = System.Drawing.Color.FromArgb(248, 113, 113);
            this.btnNavLogout.Location = new System.Drawing.Point(10, 546);
            this.btnNavLogout.Name = "btnNavLogout";
            this.btnNavLogout.Size = new System.Drawing.Size(210, 36);
            this.btnNavLogout.TabIndex = 14;
            this.btnNavLogout.Text = "🚪  Sign Out";
            this.btnNavLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNavLogout.UseVisualStyleBackColor = true;

            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
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
            this.panelHeaderInfo.Height = 60;
            this.panelHeaderInfo.Location = new System.Drawing.Point(20, 20);
            this.panelHeaderInfo.Name = "panelHeaderInfo";
            this.panelHeaderInfo.Size = new System.Drawing.Size(970, 60);
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
            this.grpQuickActions.Controls.Add(this.btnQuickFeedback);
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
            this.btnQuickAddBus.Location = new System.Drawing.Point(18, 30);
            this.btnQuickAddBus.Name = "btnQuickAddBus";
            this.btnQuickAddBus.Size = new System.Drawing.Size(168, 38);
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
            this.btnQuickNewTrip.Location = new System.Drawing.Point(198, 30);
            this.btnQuickNewTrip.Name = "btnQuickNewTrip";
            this.btnQuickNewTrip.Size = new System.Drawing.Size(172, 38);
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
            this.btnQuickUpdateFares.Location = new System.Drawing.Point(382, 30);
            this.btnQuickUpdateFares.Name = "btnQuickUpdateFares";
            this.btnQuickUpdateFares.Size = new System.Drawing.Size(172, 38);
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
            this.btnQuickSalesReport.Location = new System.Drawing.Point(566, 30);
            this.btnQuickSalesReport.Name = "btnQuickSalesReport";
            this.btnQuickSalesReport.Size = new System.Drawing.Size(176, 38);
            this.btnQuickSalesReport.TabIndex = 3;
            this.btnQuickSalesReport.Text = "📈  Generate Report";
            this.btnQuickSalesReport.UseVisualStyleBackColor = false;

            // 
            // btnQuickFeedback
            // 
            this.btnQuickFeedback.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnQuickFeedback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnQuickFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuickFeedback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuickFeedback.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnQuickFeedback.Location = new System.Drawing.Point(754, 30);
            this.btnQuickFeedback.Name = "btnQuickFeedback";
            this.btnQuickFeedback.Size = new System.Drawing.Size(168, 38);
            this.btnQuickFeedback.TabIndex = 4;
            this.btnQuickFeedback.Text = "💬  Passenger Feedback";
            this.btnQuickFeedback.UseVisualStyleBackColor = false;

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
            this.panelUsersHeader.Height = 54;
            this.panelUsersHeader.Location = new System.Drawing.Point(0, 0);
            this.panelUsersHeader.Name = "panelUsersHeader";
            this.panelUsersHeader.Size = new System.Drawing.Size(970, 54);
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
            this.panelUsersToolbar.Location = new System.Drawing.Point(0, 54);
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
            this.panelBusesHeader.Height = 54;
            this.panelBusesHeader.Location = new System.Drawing.Point(0, 0);
            this.panelBusesHeader.Name = "panelBusesHeader";
            this.panelBusesHeader.Size = new System.Drawing.Size(970, 54);
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

            // 
            // btnAddBus
            // 
            this.btnAddBus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddBus.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnAddBus.FlatAppearance.BorderSize = 0;
            this.btnAddBus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddBus.ForeColor = System.Drawing.Color.White;
            this.btnAddBus.Location = new System.Drawing.Point(825, 8);
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
            this.flowBusMetrics.Height = 85;
            this.flowBusMetrics.Location = new System.Drawing.Point(0, 54);
            this.flowBusMetrics.Name = "flowBusMetrics";
            this.flowBusMetrics.Size = new System.Drawing.Size(970, 85);
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
            this.cardTotalBuses.Size = new System.Drawing.Size(225, 72);
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
            this.cardActiveBuses.Size = new System.Drawing.Size(225, 72);
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
            this.cardMaintenanceBuses.Size = new System.Drawing.Size(225, 72);
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
            this.cardInactiveBuses.Size = new System.Drawing.Size(225, 72);
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
            this.ResumeLayout(false);
        }

        #endregion
    }
}

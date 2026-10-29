using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class TicketVerifyDialogForm
    {
        private System.ComponentModel.IContainer components = null;

        // Title Bar
        private Panel panelTitleBar;
        private Label lblDialogTitle;
        private Button btnClose;

        // Content
        private Panel panelContent;
        private Label lblHeaderTitle;
        private Label lblHeaderSubtitle;

        // Search bar
        private Panel panelSearchBox;
        private Label lblSearchPrompt;
        private TextBox txtSearchTicket;
        private Button btnSearch;

        // Status Banner
        private Panel panelStatusBanner;
        private Label lblStatusIcon;
        private Label lblStatusHeading;
        private Label lblStatusSubheading;

        // Details Grid / Card
        private GroupBox grpTicketDetails;
        private Label lblDetailTicketNo;
        private Label lblValTicketNo;
        private Label lblDetailBookingRef;
        private Label lblValBookingRef;
        private Label lblDetailPassenger;
        private Label lblValPassenger;
        private Label lblDetailPhone;
        private Label lblValPhone;
        private Label lblDetailRoute;
        private Label lblValRoute;
        private Label lblDetailSchedule;
        private Label lblValSchedule;
        private Label lblDetailBus;
        private Label lblValBus;
        private Label lblDetailSeat;
        private Label lblValSeat;
        private Label lblDetailGate;
        private Label lblValGate;
        private Label lblDetailSecurityCode;
        private Label lblValSecurityCode;

        // Actions
        private Button btnConfirmBoard;
        private Button btnPrintPass;
        private Button btnCancelDialog;

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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblDialogTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelContent = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();

            this.panelSearchBox = new System.Windows.Forms.Panel();
            this.lblSearchPrompt = new System.Windows.Forms.Label();
            this.txtSearchTicket = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();

            this.panelStatusBanner = new System.Windows.Forms.Panel();
            this.lblStatusIcon = new System.Windows.Forms.Label();
            this.lblStatusHeading = new System.Windows.Forms.Label();
            this.lblStatusSubheading = new System.Windows.Forms.Label();

            this.grpTicketDetails = new System.Windows.Forms.GroupBox();
            this.lblDetailTicketNo = new System.Windows.Forms.Label();
            this.lblValTicketNo = new System.Windows.Forms.Label();
            this.lblDetailBookingRef = new System.Windows.Forms.Label();
            this.lblValBookingRef = new System.Windows.Forms.Label();
            this.lblDetailPassenger = new System.Windows.Forms.Label();
            this.lblValPassenger = new System.Windows.Forms.Label();
            this.lblDetailPhone = new System.Windows.Forms.Label();
            this.lblValPhone = new System.Windows.Forms.Label();
            this.lblDetailRoute = new System.Windows.Forms.Label();
            this.lblValRoute = new System.Windows.Forms.Label();
            this.lblDetailSchedule = new System.Windows.Forms.Label();
            this.lblValSchedule = new System.Windows.Forms.Label();
            this.lblDetailBus = new System.Windows.Forms.Label();
            this.lblValBus = new System.Windows.Forms.Label();
            this.lblDetailSeat = new System.Windows.Forms.Label();
            this.lblValSeat = new System.Windows.Forms.Label();
            this.lblDetailGate = new System.Windows.Forms.Label();
            this.lblValGate = new System.Windows.Forms.Label();
            this.lblDetailSecurityCode = new System.Windows.Forms.Label();
            this.lblValSecurityCode = new System.Windows.Forms.Label();

            this.btnConfirmBoard = new System.Windows.Forms.Button();
            this.btnPrintPass = new System.Windows.Forms.Button();
            this.btnCancelDialog = new System.Windows.Forms.Button();

            this.panelTitleBar.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelSearchBox.SuspendLayout();
            this.panelStatusBanner.SuspendLayout();
            this.grpTicketDetails.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelTitleBar.Controls.Add(this.lblDialogTitle);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Height = 44;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(680, 44);
            this.panelTitleBar.TabIndex = 0;

            // 
            // lblDialogTitle
            // 
            this.lblDialogTitle.AutoSize = true;
            this.lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDialogTitle.ForeColor = System.Drawing.Color.White;
            this.lblDialogTitle.Location = new System.Drawing.Point(16, 12);
            this.lblDialogTitle.Name = "lblDialogTitle";
            this.lblDialogTitle.Size = new System.Drawing.Size(320, 19);
            this.lblDialogTitle.TabIndex = 0;
            this.lblDialogTitle.Text = "⚡ Boarding Verification & Scanner Terminal";

            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnClose.Location = new System.Drawing.Point(636, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.panelContent.Controls.Add(this.lblHeaderTitle);
            this.panelContent.Controls.Add(this.lblHeaderSubtitle);
            this.panelContent.Controls.Add(this.panelSearchBox);
            this.panelContent.Controls.Add(this.panelStatusBanner);
            this.panelContent.Controls.Add(this.grpTicketDetails);
            this.panelContent.Controls.Add(this.btnConfirmBoard);
            this.panelContent.Controls.Add(this.btnPrintPass);
            this.panelContent.Controls.Add(this.btnCancelDialog);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 44);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(680, 580);
            this.panelContent.TabIndex = 1;

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(300, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Pre-Boarding Ticket Verification";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 46);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(560, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Scan barcode or enter Ticket Reference / Booking ID to verify security authorization before gate boarding.";

            // 
            // panelSearchBox
            // 
            this.panelSearchBox.BackColor = System.Drawing.Color.White;
            this.panelSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearchBox.Controls.Add(this.lblSearchPrompt);
            this.panelSearchBox.Controls.Add(this.txtSearchTicket);
            this.panelSearchBox.Controls.Add(this.btnSearch);
            this.panelSearchBox.Location = new System.Drawing.Point(24, 72);
            this.panelSearchBox.Name = "panelSearchBox";
            this.panelSearchBox.Size = new System.Drawing.Size(632, 54);
            this.panelSearchBox.TabIndex = 2;

            // 
            // lblSearchPrompt
            // 
            this.lblSearchPrompt.AutoSize = true;
            this.lblSearchPrompt.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSearchPrompt.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblSearchPrompt.Location = new System.Drawing.Point(12, 6);
            this.lblSearchPrompt.Name = "lblSearchPrompt";
            this.lblSearchPrompt.Size = new System.Drawing.Size(260, 15);
            this.lblSearchPrompt.TabIndex = 0;
            this.lblSearchPrompt.Text = "SCAN BARCODE OR ENTER REFERENCE CODE:";

            // 
            // txtSearchTicket
            // 
            this.txtSearchTicket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchTicket.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTicket.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSearchTicket.Location = new System.Drawing.Point(15, 24);
            this.txtSearchTicket.Name = "txtSearchTicket";
            this.txtSearchTicket.Size = new System.Drawing.Size(460, 22);
            this.txtSearchTicket.TabIndex = 1;

            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(495, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 36);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "🔍 Verify Ticket";
            this.btnSearch.UseVisualStyleBackColor = false;

            // 
            // panelStatusBanner
            // 
            this.panelStatusBanner.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.panelStatusBanner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStatusBanner.Controls.Add(this.lblStatusIcon);
            this.panelStatusBanner.Controls.Add(this.lblStatusHeading);
            this.panelStatusBanner.Controls.Add(this.lblStatusSubheading);
            this.panelStatusBanner.Location = new System.Drawing.Point(24, 136);
            this.panelStatusBanner.Name = "panelStatusBanner";
            this.panelStatusBanner.Size = new System.Drawing.Size(632, 60);
            this.panelStatusBanner.TabIndex = 3;

            // 
            // lblStatusIcon
            // 
            this.lblStatusIcon.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusIcon.Location = new System.Drawing.Point(10, 8);
            this.lblStatusIcon.Name = "lblStatusIcon";
            this.lblStatusIcon.Size = new System.Drawing.Size(42, 42);
            this.lblStatusIcon.TabIndex = 0;
            this.lblStatusIcon.Text = "ℹ️";
            this.lblStatusIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // lblStatusHeading
            // 
            this.lblStatusHeading.AutoSize = true;
            this.lblStatusHeading.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatusHeading.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblStatusHeading.Location = new System.Drawing.Point(58, 8);
            this.lblStatusHeading.Name = "lblStatusHeading";
            this.lblStatusHeading.Size = new System.Drawing.Size(210, 20);
            this.lblStatusHeading.TabIndex = 1;
            this.lblStatusHeading.Text = "Ready to Scan / Verify Ticket";

            // 
            // lblStatusSubheading
            // 
            this.lblStatusSubheading.AutoSize = true;
            this.lblStatusSubheading.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatusSubheading.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblStatusSubheading.Location = new System.Drawing.Point(59, 32);
            this.lblStatusSubheading.Name = "lblStatusSubheading";
            this.lblStatusSubheading.Size = new System.Drawing.Size(460, 15);
            this.lblStatusSubheading.TabIndex = 2;
            this.lblStatusSubheading.Text = "Please scan a ticket barcode or enter ticket reference e.g. TK1001 or booking ref e.g. BK0001.";

            // 
            // grpTicketDetails
            // 
            this.grpTicketDetails.BackColor = System.Drawing.Color.White;
            this.grpTicketDetails.Controls.Add(this.lblDetailTicketNo);
            this.grpTicketDetails.Controls.Add(this.lblValTicketNo);
            this.grpTicketDetails.Controls.Add(this.lblDetailBookingRef);
            this.grpTicketDetails.Controls.Add(this.lblValBookingRef);
            this.grpTicketDetails.Controls.Add(this.lblDetailPassenger);
            this.grpTicketDetails.Controls.Add(this.lblValPassenger);
            this.grpTicketDetails.Controls.Add(this.lblDetailPhone);
            this.grpTicketDetails.Controls.Add(this.lblValPhone);
            this.grpTicketDetails.Controls.Add(this.lblDetailRoute);
            this.grpTicketDetails.Controls.Add(this.lblValRoute);
            this.grpTicketDetails.Controls.Add(this.lblDetailSchedule);
            this.grpTicketDetails.Controls.Add(this.lblValSchedule);
            this.grpTicketDetails.Controls.Add(this.lblDetailBus);
            this.grpTicketDetails.Controls.Add(this.lblValBus);
            this.grpTicketDetails.Controls.Add(this.lblDetailSeat);
            this.grpTicketDetails.Controls.Add(this.lblValSeat);
            this.grpTicketDetails.Controls.Add(this.lblDetailGate);
            this.grpTicketDetails.Controls.Add(this.lblValGate);
            this.grpTicketDetails.Controls.Add(this.lblDetailSecurityCode);
            this.grpTicketDetails.Controls.Add(this.lblValSecurityCode);
            this.grpTicketDetails.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grpTicketDetails.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.grpTicketDetails.Location = new System.Drawing.Point(24, 206);
            this.grpTicketDetails.Name = "grpTicketDetails";
            this.grpTicketDetails.Size = new System.Drawing.Size(632, 296);
            this.grpTicketDetails.TabIndex = 4;
            this.grpTicketDetails.TabStop = false;
            this.grpTicketDetails.Text = "Passenger Boarding Pass Dossier";

            // Column 1
            this.lblDetailTicketNo.AutoSize = true;
            this.lblDetailTicketNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailTicketNo.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailTicketNo.Location = new System.Drawing.Point(20, 32);
            this.lblDetailTicketNo.Name = "lblDetailTicketNo";
            this.lblDetailTicketNo.Size = new System.Drawing.Size(65, 15);
            this.lblDetailTicketNo.Text = "Ticket Ref:";

            this.lblValTicketNo.AutoSize = true;
            this.lblValTicketNo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValTicketNo.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblValTicketNo.Location = new System.Drawing.Point(120, 30);
            this.lblValTicketNo.Name = "lblValTicketNo";
            this.lblValTicketNo.Size = new System.Drawing.Size(24, 19);
            this.lblValTicketNo.Text = "---";

            this.lblDetailBookingRef.AutoSize = true;
            this.lblDetailBookingRef.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailBookingRef.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailBookingRef.Location = new System.Drawing.Point(340, 32);
            this.lblDetailBookingRef.Name = "lblDetailBookingRef";
            this.lblDetailBookingRef.Size = new System.Drawing.Size(76, 15);
            this.lblDetailBookingRef.Text = "Booking Ref:";

            this.lblValBookingRef.AutoSize = true;
            this.lblValBookingRef.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValBookingRef.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValBookingRef.Location = new System.Drawing.Point(435, 30);
            this.lblValBookingRef.Name = "lblValBookingRef";
            this.lblValBookingRef.Size = new System.Drawing.Size(24, 19);
            this.lblValBookingRef.Text = "---";

            // Row 2: Passenger & Phone
            this.lblDetailPassenger.AutoSize = true;
            this.lblDetailPassenger.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailPassenger.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailPassenger.Location = new System.Drawing.Point(20, 72);
            this.lblDetailPassenger.Name = "lblDetailPassenger";
            this.lblDetailPassenger.Size = new System.Drawing.Size(67, 15);
            this.lblDetailPassenger.Text = "Passenger:";

            this.lblValPassenger.AutoSize = true;
            this.lblValPassenger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValPassenger.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValPassenger.Location = new System.Drawing.Point(120, 70);
            this.lblValPassenger.Name = "lblValPassenger";
            this.lblValPassenger.Size = new System.Drawing.Size(24, 19);
            this.lblValPassenger.Text = "---";

            this.lblDetailPhone.AutoSize = true;
            this.lblDetailPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailPhone.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailPhone.Location = new System.Drawing.Point(340, 72);
            this.lblDetailPhone.Name = "lblDetailPhone";
            this.lblDetailPhone.Size = new System.Drawing.Size(44, 15);
            this.lblDetailPhone.Text = "Phone:";

            this.lblValPhone.AutoSize = true;
            this.lblValPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValPhone.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValPhone.Location = new System.Drawing.Point(435, 71);
            this.lblValPhone.Name = "lblValPhone";
            this.lblValPhone.Size = new System.Drawing.Size(24, 17);
            this.lblValPhone.Text = "---";

            // Row 3: Route & Schedule
            this.lblDetailRoute.AutoSize = true;
            this.lblDetailRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailRoute.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailRoute.Location = new System.Drawing.Point(20, 114);
            this.lblDetailRoute.Name = "lblDetailRoute";
            this.lblDetailRoute.Size = new System.Drawing.Size(41, 15);
            this.lblDetailRoute.Text = "Route:";

            this.lblValRoute.AutoSize = true;
            this.lblValRoute.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValRoute.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValRoute.Location = new System.Drawing.Point(120, 112);
            this.lblValRoute.Name = "lblValRoute";
            this.lblValRoute.Size = new System.Drawing.Size(24, 19);
            this.lblValRoute.Text = "---";

            this.lblDetailSchedule.AutoSize = true;
            this.lblDetailSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailSchedule.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailSchedule.Location = new System.Drawing.Point(20, 154);
            this.lblDetailSchedule.Name = "lblDetailSchedule";
            this.lblDetailSchedule.Size = new System.Drawing.Size(62, 15);
            this.lblDetailSchedule.Text = "Departure:";

            this.lblValSchedule.AutoSize = true;
            this.lblValSchedule.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValSchedule.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValSchedule.Location = new System.Drawing.Point(120, 153);
            this.lblValSchedule.Name = "lblValSchedule";
            this.lblValSchedule.Size = new System.Drawing.Size(24, 17);
            this.lblValSchedule.Text = "---";

            // Row 4: Bus & Seat
            this.lblDetailBus.AutoSize = true;
            this.lblDetailBus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailBus.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailBus.Location = new System.Drawing.Point(20, 194);
            this.lblDetailBus.Name = "lblDetailBus";
            this.lblDetailBus.Size = new System.Drawing.Size(84, 15);
            this.lblDetailBus.Text = "Assigned Bus:";

            this.lblValBus.AutoSize = true;
            this.lblValBus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValBus.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblValBus.Location = new System.Drawing.Point(120, 193);
            this.lblValBus.Name = "lblValBus";
            this.lblValBus.Size = new System.Drawing.Size(24, 17);
            this.lblValBus.Text = "---";

            this.lblDetailSeat.AutoSize = true;
            this.lblDetailSeat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailSeat.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailSeat.Location = new System.Drawing.Point(340, 194);
            this.lblDetailSeat.Name = "lblDetailSeat";
            this.lblDetailSeat.Size = new System.Drawing.Size(63, 15);
            this.lblDetailSeat.Text = "Seat No:";

            this.lblValSeat.AutoSize = true;
            this.lblValSeat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValSeat.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.lblValSeat.Location = new System.Drawing.Point(435, 191);
            this.lblValSeat.Name = "lblValSeat";
            this.lblValSeat.Size = new System.Drawing.Size(27, 20);
            this.lblValSeat.Text = "---";

            // Row 5: Gate & Security
            this.lblDetailGate.AutoSize = true;
            this.lblDetailGate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailGate.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailGate.Location = new System.Drawing.Point(20, 236);
            this.lblDetailGate.Name = "lblDetailGate";
            this.lblDetailGate.Size = new System.Drawing.Size(76, 15);
            this.lblDetailGate.Text = "Boarding Gate:";

            this.lblValGate.AutoSize = true;
            this.lblValGate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblValGate.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblValGate.Location = new System.Drawing.Point(120, 234);
            this.lblValGate.Name = "lblValGate";
            this.lblValGate.Size = new System.Drawing.Size(24, 19);
            this.lblValGate.Text = "---";

            this.lblDetailSecurityCode.AutoSize = true;
            this.lblDetailSecurityCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetailSecurityCode.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblDetailSecurityCode.Location = new System.Drawing.Point(340, 236);
            this.lblDetailSecurityCode.Name = "lblDetailSecurityCode";
            this.lblDetailSecurityCode.Size = new System.Drawing.Size(83, 15);
            this.lblDetailSecurityCode.Text = "Security Hash:";

            this.lblValSecurityCode.AutoSize = true;
            this.lblValSecurityCode.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValSecurityCode.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.lblValSecurityCode.Location = new System.Drawing.Point(435, 237);
            this.lblValSecurityCode.Name = "lblValSecurityCode";
            this.lblValSecurityCode.Size = new System.Drawing.Size(28, 14);
            this.lblValSecurityCode.Text = "---";

            // 
            // btnConfirmBoard
            // 
            this.btnConfirmBoard.BackColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.btnConfirmBoard.Enabled = false;
            this.btnConfirmBoard.FlatAppearance.BorderSize = 0;
            this.btnConfirmBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBoard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmBoard.ForeColor = System.Drawing.Color.White;
            this.btnConfirmBoard.Location = new System.Drawing.Point(24, 516);
            this.btnConfirmBoard.Name = "btnConfirmBoard";
            this.btnConfirmBoard.Size = new System.Drawing.Size(230, 42);
            this.btnConfirmBoard.TabIndex = 5;
            this.btnConfirmBoard.Text = "✅ Confirm & Board Passenger";
            this.btnConfirmBoard.UseVisualStyleBackColor = false;

            // 
            // btnPrintPass
            // 
            this.btnPrintPass.BackColor = System.Drawing.Color.White;
            this.btnPrintPass.Enabled = false;
            this.btnPrintPass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnPrintPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintPass.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPrintPass.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.btnPrintPass.Location = new System.Drawing.Point(268, 516);
            this.btnPrintPass.Name = "btnPrintPass";
            this.btnPrintPass.Size = new System.Drawing.Size(180, 42);
            this.btnPrintPass.TabIndex = 6;
            this.btnPrintPass.Text = "🖨️ Print Boarding Pass";
            this.btnPrintPass.UseVisualStyleBackColor = false;

            // 
            // btnCancelDialog
            // 
            this.btnCancelDialog.BackColor = System.Drawing.Color.White;
            this.btnCancelDialog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancelDialog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelDialog.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelDialog.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnCancelDialog.Location = new System.Drawing.Point(544, 516);
            this.btnCancelDialog.Name = "btnCancelDialog";
            this.btnCancelDialog.Size = new System.Drawing.Size(112, 42);
            this.btnCancelDialog.TabIndex = 7;
            this.btnCancelDialog.Text = "Close";
            this.btnCancelDialog.UseVisualStyleBackColor = false;

            // 
            // TicketVerifyDialogForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.CancelButton = this.btnCancelDialog;
            this.ClientSize = new System.Drawing.Size(680, 624);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketVerifyDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Boarding Verification Terminal";

            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelSearchBox.ResumeLayout(false);
            this.panelSearchBox.PerformLayout();
            this.panelStatusBanner.ResumeLayout(false);
            this.panelStatusBanner.PerformLayout();
            this.grpTicketDetails.ResumeLayout(false);
            this.grpTicketDetails.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

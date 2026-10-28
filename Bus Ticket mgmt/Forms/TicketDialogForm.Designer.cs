using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class TicketDialogForm
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

        // Form Fields
        private Label lblTicketId;
        private TextBox txtTicketId;

        private Label lblBookingSelect;
        private ComboBox cmbBookingSelect;

        private Label lblPassengerName;
        private TextBox txtPassengerName;

        private Label lblPassengerPhone;
        private TextBox txtPassengerPhone;

        private Label lblPassengerEmail;
        private TextBox txtPassengerEmail;

        private Label lblRoute;
        private ComboBox cmbRoute;

        private Label lblTravelDate;
        private DateTimePicker dtpTravelDate;

        private Label lblDepartureTime;
        private ComboBox cmbDepartureTime;

        private Label lblGateNumber;
        private ComboBox cmbGateNumber;

        private Label lblAssignedBus;
        private ComboBox cmbAssignedBus;

        private Label lblSeatNumber;
        private NumericUpDown numSeatNumber;

        private Label lblFareAmount;
        private NumericUpDown numFareAmount;

        private Label lblStatus;
        private ComboBox cmbStatus;

        private Label lblLuggage;
        private TextBox txtLuggage;

        private Label lblNotes;
        private TextBox txtNotes;

        // Action Buttons
        private Button btnSave;
        private Button btnCancel;

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

            this.lblTicketId = new System.Windows.Forms.Label();
            this.txtTicketId = new System.Windows.Forms.TextBox();

            this.lblBookingSelect = new System.Windows.Forms.Label();
            this.cmbBookingSelect = new System.Windows.Forms.ComboBox();

            this.lblPassengerName = new System.Windows.Forms.Label();
            this.txtPassengerName = new System.Windows.Forms.TextBox();

            this.lblPassengerPhone = new System.Windows.Forms.Label();
            this.txtPassengerPhone = new System.Windows.Forms.TextBox();

            this.lblPassengerEmail = new System.Windows.Forms.Label();
            this.txtPassengerEmail = new System.Windows.Forms.TextBox();

            this.lblRoute = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();

            this.lblTravelDate = new System.Windows.Forms.Label();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();

            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.cmbDepartureTime = new System.Windows.Forms.ComboBox();

            this.lblGateNumber = new System.Windows.Forms.Label();
            this.cmbGateNumber = new System.Windows.Forms.ComboBox();

            this.lblAssignedBus = new System.Windows.Forms.Label();
            this.cmbAssignedBus = new System.Windows.Forms.ComboBox();

            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.numSeatNumber = new System.Windows.Forms.NumericUpDown();

            this.lblFareAmount = new System.Windows.Forms.Label();
            this.numFareAmount = new System.Windows.Forms.NumericUpDown();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.lblLuggage = new System.Windows.Forms.Label();
            this.txtLuggage = new System.Windows.Forms.TextBox();

            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numSeatNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFareAmount)).BeginInit();

            this.panelTitleBar.SuspendLayout();
            this.panelContent.SuspendLayout();
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
            this.lblDialogTitle.Size = new System.Drawing.Size(220, 19);
            this.lblDialogTitle.TabIndex = 0;
            this.lblDialogTitle.Text = "🎟️ Issue Passenger Travel Ticket";

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
            this.panelContent.Controls.Add(this.lblTicketId);
            this.panelContent.Controls.Add(this.txtTicketId);
            this.panelContent.Controls.Add(this.lblBookingSelect);
            this.panelContent.Controls.Add(this.cmbBookingSelect);
            this.panelContent.Controls.Add(this.lblPassengerName);
            this.panelContent.Controls.Add(this.txtPassengerName);
            this.panelContent.Controls.Add(this.lblPassengerPhone);
            this.panelContent.Controls.Add(this.txtPassengerPhone);
            this.panelContent.Controls.Add(this.lblPassengerEmail);
            this.panelContent.Controls.Add(this.txtPassengerEmail);
            this.panelContent.Controls.Add(this.lblRoute);
            this.panelContent.Controls.Add(this.cmbRoute);
            this.panelContent.Controls.Add(this.lblTravelDate);
            this.panelContent.Controls.Add(this.dtpTravelDate);
            this.panelContent.Controls.Add(this.lblDepartureTime);
            this.panelContent.Controls.Add(this.cmbDepartureTime);
            this.panelContent.Controls.Add(this.lblGateNumber);
            this.panelContent.Controls.Add(this.cmbGateNumber);
            this.panelContent.Controls.Add(this.lblAssignedBus);
            this.panelContent.Controls.Add(this.cmbAssignedBus);
            this.panelContent.Controls.Add(this.lblSeatNumber);
            this.panelContent.Controls.Add(this.numSeatNumber);
            this.panelContent.Controls.Add(this.lblFareAmount);
            this.panelContent.Controls.Add(this.numFareAmount);
            this.panelContent.Controls.Add(this.lblStatus);
            this.panelContent.Controls.Add(this.cmbStatus);
            this.panelContent.Controls.Add(this.lblLuggage);
            this.panelContent.Controls.Add(this.txtLuggage);
            this.panelContent.Controls.Add(this.lblNotes);
            this.panelContent.Controls.Add(this.txtNotes);
            this.panelContent.Controls.Add(this.btnSave);
            this.panelContent.Controls.Add(this.btnCancel);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 44);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(680, 586);
            this.panelContent.TabIndex = 1;

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 16);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(260, 25);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Issue Boarding Pass / Ticket";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(24, 42);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(530, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Select a confirmed reservation or specify travel details to generate an official passenger travel document.";

            // 
            // lblTicketId
            // 
            this.lblTicketId.AutoSize = true;
            this.lblTicketId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTicketId.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTicketId.Location = new System.Drawing.Point(24, 72);
            this.lblTicketId.Name = "lblTicketId";
            this.lblTicketId.Size = new System.Drawing.Size(103, 15);
            this.lblTicketId.TabIndex = 2;
            this.lblTicketId.Text = "Ticket Reference *";

            // 
            // txtTicketId
            // 
            this.txtTicketId.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtTicketId.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTicketId.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.txtTicketId.Location = new System.Drawing.Point(24, 92);
            this.txtTicketId.Name = "txtTicketId";
            this.txtTicketId.ReadOnly = true;
            this.txtTicketId.Size = new System.Drawing.Size(160, 24);
            this.txtTicketId.TabIndex = 3;

            // 
            // lblBookingSelect
            // 
            this.lblBookingSelect.AutoSize = true;
            this.lblBookingSelect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookingSelect.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookingSelect.Location = new System.Drawing.Point(204, 72);
            this.lblBookingSelect.Name = "lblBookingSelect";
            this.lblBookingSelect.Size = new System.Drawing.Size(160, 15);
            this.lblBookingSelect.TabIndex = 4;
            this.lblBookingSelect.Text = "Link to Existing Booking *";

            // 
            // cmbBookingSelect
            // 
            this.cmbBookingSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingSelect.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBookingSelect.FormattingEnabled = true;
            this.cmbBookingSelect.Location = new System.Drawing.Point(204, 92);
            this.cmbBookingSelect.Name = "cmbBookingSelect";
            this.cmbBookingSelect.Size = new System.Drawing.Size(450, 25);
            this.cmbBookingSelect.TabIndex = 5;

            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassengerName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPassengerName.Location = new System.Drawing.Point(24, 130);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(130, 15);
            this.lblPassengerName.TabIndex = 6;
            this.lblPassengerName.Text = "Passenger Full Name *";

            // 
            // txtPassengerName
            // 
            this.txtPassengerName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassengerName.Location = new System.Drawing.Point(24, 150);
            this.txtPassengerName.Name = "txtPassengerName";
            this.txtPassengerName.Size = new System.Drawing.Size(300, 24);
            this.txtPassengerName.TabIndex = 7;

            // 
            // lblPassengerPhone
            // 
            this.lblPassengerPhone.AutoSize = true;
            this.lblPassengerPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassengerPhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPassengerPhone.Location = new System.Drawing.Point(344, 130);
            this.lblPassengerPhone.Name = "lblPassengerPhone";
            this.lblPassengerPhone.Size = new System.Drawing.Size(100, 15);
            this.lblPassengerPhone.TabIndex = 8;
            this.lblPassengerPhone.Text = "Contact Phone *";

            // 
            // txtPassengerPhone
            // 
            this.txtPassengerPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassengerPhone.Location = new System.Drawing.Point(344, 150);
            this.txtPassengerPhone.Name = "txtPassengerPhone";
            this.txtPassengerPhone.Size = new System.Drawing.Size(310, 24);
            this.txtPassengerPhone.TabIndex = 9;

            // 
            // lblPassengerEmail
            // 
            this.lblPassengerEmail.AutoSize = true;
            this.lblPassengerEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassengerEmail.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPassengerEmail.Location = new System.Drawing.Point(24, 186);
            this.lblPassengerEmail.Name = "lblPassengerEmail";
            this.lblPassengerEmail.Size = new System.Drawing.Size(83, 15);
            this.lblPassengerEmail.TabIndex = 10;
            this.lblPassengerEmail.Text = "Email Address";

            // 
            // txtPassengerEmail
            // 
            this.txtPassengerEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassengerEmail.Location = new System.Drawing.Point(24, 206);
            this.txtPassengerEmail.Name = "txtPassengerEmail";
            this.txtPassengerEmail.Size = new System.Drawing.Size(300, 24);
            this.txtPassengerEmail.TabIndex = 11;

            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoute.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRoute.Location = new System.Drawing.Point(344, 186);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(91, 15);
            this.lblRoute.TabIndex = 12;
            this.lblRoute.Text = "Travel Route *";

            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(344, 206);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(310, 25);
            this.cmbRoute.TabIndex = 13;

            // 
            // lblTravelDate
            // 
            this.lblTravelDate.AutoSize = true;
            this.lblTravelDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTravelDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTravelDate.Location = new System.Drawing.Point(24, 242);
            this.lblTravelDate.Name = "lblTravelDate";
            this.lblTravelDate.Size = new System.Drawing.Size(81, 15);
            this.lblTravelDate.TabIndex = 14;
            this.lblTravelDate.Text = "Travel Date *";

            // 
            // dtpTravelDate
            // 
            this.dtpTravelDate.CalendarFont = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTravelDate.CustomFormat = "yyyy-MM-dd";
            this.dtpTravelDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTravelDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTravelDate.Location = new System.Drawing.Point(24, 262);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(140, 24);
            this.dtpTravelDate.TabIndex = 15;

            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureTime.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDepartureTime.Location = new System.Drawing.Point(180, 242);
            this.lblDepartureTime.Name = "lblDepartureTime";
            this.lblDepartureTime.Size = new System.Drawing.Size(104, 15);
            this.lblDepartureTime.TabIndex = 16;
            this.lblDepartureTime.Text = "Departure Time *";

            // 
            // cmbDepartureTime
            // 
            this.cmbDepartureTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartureTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDepartureTime.FormattingEnabled = true;
            this.cmbDepartureTime.Items.AddRange(new object[] {
            "06:00 AM",
            "07:30 AM",
            "08:00 AM",
            "09:30 AM",
            "10:00 AM",
            "11:15 AM",
            "01:00 PM",
            "03:00 PM"});
            this.cmbDepartureTime.Location = new System.Drawing.Point(180, 262);
            this.cmbDepartureTime.Name = "cmbDepartureTime";
            this.cmbDepartureTime.Size = new System.Drawing.Size(144, 25);
            this.cmbDepartureTime.TabIndex = 17;

            // 
            // lblGateNumber
            // 
            this.lblGateNumber.AutoSize = true;
            this.lblGateNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGateNumber.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblGateNumber.Location = new System.Drawing.Point(344, 242);
            this.lblGateNumber.Name = "lblGateNumber";
            this.lblGateNumber.Size = new System.Drawing.Size(98, 15);
            this.lblGateNumber.TabIndex = 18;
            this.lblGateNumber.Text = "Boarding Gate *";

            // 
            // cmbGateNumber
            // 
            this.cmbGateNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGateNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGateNumber.FormattingEnabled = true;
            this.cmbGateNumber.Items.AddRange(new object[] {
            "Gate 01",
            "Gate 02",
            "Gate 03",
            "Gate 04",
            "Gate 05",
            "VIP Lounge Gate"});
            this.cmbGateNumber.Location = new System.Drawing.Point(344, 262);
            this.cmbGateNumber.Name = "cmbGateNumber";
            this.cmbGateNumber.Size = new System.Drawing.Size(140, 25);
            this.cmbGateNumber.TabIndex = 19;

            // 
            // lblAssignedBus
            // 
            this.lblAssignedBus.AutoSize = true;
            this.lblAssignedBus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssignedBus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblAssignedBus.Location = new System.Drawing.Point(500, 242);
            this.lblAssignedBus.Name = "lblAssignedBus";
            this.lblAssignedBus.Size = new System.Drawing.Size(95, 15);
            this.lblAssignedBus.TabIndex = 20;
            this.lblAssignedBus.Text = "Assigned Coach";

            // 
            // cmbAssignedBus
            // 
            this.cmbAssignedBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignedBus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAssignedBus.FormattingEnabled = true;
            this.cmbAssignedBus.Location = new System.Drawing.Point(500, 262);
            this.cmbAssignedBus.Name = "cmbAssignedBus";
            this.cmbAssignedBus.Size = new System.Drawing.Size(154, 25);
            this.cmbAssignedBus.TabIndex = 21;

            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeatNumber.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSeatNumber.Location = new System.Drawing.Point(24, 302);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(93, 15);
            this.lblSeatNumber.TabIndex = 22;
            this.lblSeatNumber.Text = "Seat Number *";

            // 
            // numSeatNumber
            // 
            this.numSeatNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numSeatNumber.Location = new System.Drawing.Point(24, 322);
            this.numSeatNumber.Maximum = new decimal(new int[] { 65, 0, 0, 0 });
            this.numSeatNumber.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numSeatNumber.Name = "numSeatNumber";
            this.numSeatNumber.Size = new System.Drawing.Size(140, 24);
            this.numSeatNumber.TabIndex = 23;
            this.numSeatNumber.Value = new decimal(new int[] { 1, 0, 0, 0 });

            // 
            // lblFareAmount
            // 
            this.lblFareAmount.AutoSize = true;
            this.lblFareAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFareAmount.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblFareAmount.Location = new System.Drawing.Point(180, 302);
            this.lblFareAmount.Name = "lblFareAmount";
            this.lblFareAmount.Size = new System.Drawing.Size(107, 15);
            this.lblFareAmount.TabIndex = 24;
            this.lblFareAmount.Text = "Fare Amount (ETB)";

            // 
            // numFareAmount
            // 
            this.numFareAmount.DecimalPlaces = 2;
            this.numFareAmount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numFareAmount.Increment = new decimal(new int[] { 50, 0, 0, 0 });
            this.numFareAmount.Location = new System.Drawing.Point(180, 322);
            this.numFareAmount.Maximum = new decimal(new int[] { 25000, 0, 0, 0 });
            this.numFareAmount.Name = "numFareAmount";
            this.numFareAmount.Size = new System.Drawing.Size(144, 24);
            this.numFareAmount.TabIndex = 25;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStatus.Location = new System.Drawing.Point(344, 302);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(89, 15);
            this.lblStatus.TabIndex = 26;
            this.lblStatus.Text = "Ticket Status *";

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Valid",
            "Boarded",
            "Cancelled"});
            this.cmbStatus.Location = new System.Drawing.Point(344, 322);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(140, 25);
            this.cmbStatus.TabIndex = 27;

            // 
            // lblLuggage
            // 
            this.lblLuggage.AutoSize = true;
            this.lblLuggage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLuggage.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblLuggage.Location = new System.Drawing.Point(500, 302);
            this.lblLuggage.Name = "lblLuggage";
            this.lblLuggage.Size = new System.Drawing.Size(117, 15);
            this.lblLuggage.TabIndex = 28;
            this.lblLuggage.Text = "Luggage Allowance";

            // 
            // txtLuggage
            // 
            this.txtLuggage.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLuggage.Location = new System.Drawing.Point(500, 322);
            this.txtLuggage.Name = "txtLuggage";
            this.txtLuggage.Size = new System.Drawing.Size(154, 24);
            this.txtLuggage.TabIndex = 29;
            this.txtLuggage.Text = "25 kg";

            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblNotes.Location = new System.Drawing.Point(24, 362);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(176, 15);
            this.lblNotes.TabIndex = 30;
            this.lblNotes.Text = "Special Instructions / Remarks";

            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotes.Location = new System.Drawing.Point(24, 382);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(630, 80);
            this.txtNotes.TabIndex = 31;

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(24, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(190, 42);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "🎟️ Issue Ticket";
            this.btnSave.UseVisualStyleBackColor = false;

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.btnCancel.Location = new System.Drawing.Point(224, 510);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 42);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;

            // 
            // TicketDialogForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(680, 630);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TicketDialogForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Issue Passenger Ticket";

            ((System.ComponentModel.ISupportInitialize)(this.numSeatNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFareAmount)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}

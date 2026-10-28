using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class BookingDialogForm
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

        private Label lblBookingId;
        private TextBox txtBookingId;

        private Label lblBookingStatus;
        private ComboBox cmbBookingStatus;

        private Label lblPassengerName;
        private ComboBox cmbPassengerName;

        private Label lblPassengerPhone;
        private TextBox txtPassengerPhone;

        private Label lblPassengerEmail;
        private TextBox txtPassengerEmail;

        private Label lblPaymentStatus;
        private ComboBox cmbPaymentStatus;

        private Label lblRoute;
        private ComboBox cmbRoute;

        private Label lblDepartureTime;
        private ComboBox cmbDepartureTime;

        private Label lblTravelDate;
        private DateTimePicker dtpTravelDate;

        private Label lblAssignedBus;
        private ComboBox cmbAssignedBus;

        private Label lblFarePerSeat;
        private NumericUpDown numFarePerSeat;

        private Label lblSeatCount;
        private TextBox txtSeatCount;

        private Label lblTotalAmount;
        private TextBox txtTotalAmount;

        private Label lblSeatsPrompt;
        private CheckedListBox clbSeats;
        private Label lblSelectedSeatsPreview;

        private Label lblNotes;
        private TextBox txtNotes;

        private Button btnSave;
        private Button btnClear;
        private Button btnCancel;

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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblDialogTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelContent = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();

            this.lblBookingId = new System.Windows.Forms.Label();
            this.txtBookingId = new System.Windows.Forms.TextBox();

            this.lblBookingStatus = new System.Windows.Forms.Label();
            this.cmbBookingStatus = new System.Windows.Forms.ComboBox();

            this.lblPassengerName = new System.Windows.Forms.Label();
            this.cmbPassengerName = new System.Windows.Forms.ComboBox();

            this.lblPassengerPhone = new System.Windows.Forms.Label();
            this.txtPassengerPhone = new System.Windows.Forms.TextBox();

            this.lblPassengerEmail = new System.Windows.Forms.Label();
            this.txtPassengerEmail = new System.Windows.Forms.TextBox();

            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();

            this.lblRoute = new System.Windows.Forms.Label();
            this.cmbRoute = new System.Windows.Forms.ComboBox();

            this.lblDepartureTime = new System.Windows.Forms.Label();
            this.cmbDepartureTime = new System.Windows.Forms.ComboBox();

            this.lblTravelDate = new System.Windows.Forms.Label();
            this.dtpTravelDate = new System.Windows.Forms.DateTimePicker();

            this.lblAssignedBus = new System.Windows.Forms.Label();
            this.cmbAssignedBus = new System.Windows.Forms.ComboBox();

            this.lblFarePerSeat = new System.Windows.Forms.Label();
            this.numFarePerSeat = new System.Windows.Forms.NumericUpDown();

            this.lblSeatCount = new System.Windows.Forms.Label();
            this.txtSeatCount = new System.Windows.Forms.TextBox();

            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();

            this.lblSeatsPrompt = new System.Windows.Forms.Label();
            this.clbSeats = new System.Windows.Forms.CheckedListBox();
            this.lblSelectedSeatsPreview = new System.Windows.Forms.Label();

            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.panelTitleBar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFarePerSeat)).BeginInit();
            this.SuspendLayout();

            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelTitleBar.Controls.Add(this.lblDialogTitle);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Height = 38;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(650, 38);
            this.panelTitleBar.TabIndex = 0;

            // 
            // lblDialogTitle
            // 
            this.lblDialogTitle.AutoSize = true;
            this.lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDialogTitle.ForeColor = System.Drawing.Color.White;
            this.lblDialogTitle.Location = new System.Drawing.Point(14, 10);
            this.lblDialogTitle.Name = "lblDialogTitle";
            this.lblDialogTitle.Size = new System.Drawing.Size(260, 17);
            this.lblDialogTitle.TabIndex = 0;
            this.lblDialogTitle.Text = "Passenger Booking - Reservation Entry";

            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnClose.Location = new System.Drawing.Point(608, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 38);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // panelContent
            // 
            this.panelContent.AutoScroll = true;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.lblHeaderTitle);
            this.panelContent.Controls.Add(this.lblHeaderSubtitle);
            this.panelContent.Controls.Add(this.lblBookingId);
            this.panelContent.Controls.Add(this.txtBookingId);
            this.panelContent.Controls.Add(this.lblBookingStatus);
            this.panelContent.Controls.Add(this.cmbBookingStatus);
            this.panelContent.Controls.Add(this.lblPassengerName);
            this.panelContent.Controls.Add(this.cmbPassengerName);
            this.panelContent.Controls.Add(this.lblPassengerPhone);
            this.panelContent.Controls.Add(this.txtPassengerPhone);
            this.panelContent.Controls.Add(this.lblPassengerEmail);
            this.panelContent.Controls.Add(this.txtPassengerEmail);
            this.panelContent.Controls.Add(this.lblPaymentStatus);
            this.panelContent.Controls.Add(this.cmbPaymentStatus);
            this.panelContent.Controls.Add(this.lblRoute);
            this.panelContent.Controls.Add(this.cmbRoute);
            this.panelContent.Controls.Add(this.lblDepartureTime);
            this.panelContent.Controls.Add(this.cmbDepartureTime);
            this.panelContent.Controls.Add(this.lblTravelDate);
            this.panelContent.Controls.Add(this.dtpTravelDate);
            this.panelContent.Controls.Add(this.lblAssignedBus);
            this.panelContent.Controls.Add(this.cmbAssignedBus);
            this.panelContent.Controls.Add(this.lblFarePerSeat);
            this.panelContent.Controls.Add(this.numFarePerSeat);
            this.panelContent.Controls.Add(this.lblSeatCount);
            this.panelContent.Controls.Add(this.txtSeatCount);
            this.panelContent.Controls.Add(this.lblTotalAmount);
            this.panelContent.Controls.Add(this.txtTotalAmount);
            this.panelContent.Controls.Add(this.lblSeatsPrompt);
            this.panelContent.Controls.Add(this.clbSeats);
            this.panelContent.Controls.Add(this.lblSelectedSeatsPreview);
            this.panelContent.Controls.Add(this.lblNotes);
            this.panelContent.Controls.Add(this.txtNotes);
            this.panelContent.Controls.Add(this.btnSave);
            this.panelContent.Controls.Add(this.btnClear);
            this.panelContent.Controls.Add(this.btnCancel);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 38);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(650, 692);
            this.panelContent.TabIndex = 1;

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 18);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(225, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "New Passenger Booking";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(25, 48);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(460, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Enter passenger contact, route, scheduled travel date, and choose available seats.";

            // 
            // lblBookingId
            // 
            this.lblBookingId.AutoSize = true;
            this.lblBookingId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookingId.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookingId.Location = new System.Drawing.Point(25, 78);
            this.lblBookingId.Name = "lblBookingId";
            this.lblBookingId.Size = new System.Drawing.Size(120, 15);
            this.lblBookingId.TabIndex = 2;
            this.lblBookingId.Text = "Booking Reference *";

            // 
            // txtBookingId
            // 
            this.txtBookingId.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtBookingId.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBookingId.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.txtBookingId.Location = new System.Drawing.Point(25, 96);
            this.txtBookingId.Name = "txtBookingId";
            this.txtBookingId.ReadOnly = true;
            this.txtBookingId.Size = new System.Drawing.Size(280, 24);
            this.txtBookingId.TabIndex = 3;

            // 
            // lblBookingStatus
            // 
            this.lblBookingStatus.AutoSize = true;
            this.lblBookingStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBookingStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblBookingStatus.Location = new System.Drawing.Point(325, 78);
            this.lblBookingStatus.Name = "lblBookingStatus";
            this.lblBookingStatus.Size = new System.Drawing.Size(100, 15);
            this.lblBookingStatus.TabIndex = 4;
            this.lblBookingStatus.Text = "Booking Status *";

            // 
            // cmbBookingStatus
            // 
            this.cmbBookingStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookingStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBookingStatus.FormattingEnabled = true;
            this.cmbBookingStatus.Items.AddRange(new object[] {
            "Confirmed",
            "Pending",
            "Cancelled"});
            this.cmbBookingStatus.Location = new System.Drawing.Point(325, 96);
            this.cmbBookingStatus.Name = "cmbBookingStatus";
            this.cmbBookingStatus.Size = new System.Drawing.Size(280, 24);
            this.cmbBookingStatus.TabIndex = 5;

            // 
            // lblPassengerName
            // 
            this.lblPassengerName.AutoSize = true;
            this.lblPassengerName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassengerName.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPassengerName.Location = new System.Drawing.Point(25, 132);
            this.lblPassengerName.Name = "lblPassengerName";
            this.lblPassengerName.Size = new System.Drawing.Size(110, 15);
            this.lblPassengerName.TabIndex = 6;
            this.lblPassengerName.Text = "Passenger Name *";

            // 
            // cmbPassengerName
            // 
            this.cmbPassengerName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPassengerName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPassengerName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPassengerName.FormattingEnabled = true;
            this.cmbPassengerName.Location = new System.Drawing.Point(25, 150);
            this.cmbPassengerName.Name = "cmbPassengerName";
            this.cmbPassengerName.Size = new System.Drawing.Size(280, 24);
            this.cmbPassengerName.TabIndex = 7;

            // 
            // lblPassengerPhone
            // 
            this.lblPassengerPhone.AutoSize = true;
            this.lblPassengerPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassengerPhone.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPassengerPhone.Location = new System.Drawing.Point(325, 132);
            this.lblPassengerPhone.Name = "lblPassengerPhone";
            this.lblPassengerPhone.Size = new System.Drawing.Size(102, 15);
            this.lblPassengerPhone.TabIndex = 8;
            this.lblPassengerPhone.Text = "Phone Number *";

            // 
            // txtPassengerPhone
            // 
            this.txtPassengerPhone.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassengerPhone.Location = new System.Drawing.Point(325, 150);
            this.txtPassengerPhone.Name = "txtPassengerPhone";
            this.txtPassengerPhone.PlaceholderText = "+251 9XX XXXXXX";
            this.txtPassengerPhone.Size = new System.Drawing.Size(280, 24);
            this.txtPassengerPhone.TabIndex = 9;

            // 
            // lblPassengerEmail
            // 
            this.lblPassengerEmail.AutoSize = true;
            this.lblPassengerEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassengerEmail.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPassengerEmail.Location = new System.Drawing.Point(25, 186);
            this.lblPassengerEmail.Name = "lblPassengerEmail";
            this.lblPassengerEmail.Size = new System.Drawing.Size(92, 15);
            this.lblPassengerEmail.TabIndex = 10;
            this.lblPassengerEmail.Text = "Email Address";

            // 
            // txtPassengerEmail
            // 
            this.txtPassengerEmail.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassengerEmail.Location = new System.Drawing.Point(25, 204);
            this.txtPassengerEmail.Name = "txtPassengerEmail";
            this.txtPassengerEmail.PlaceholderText = "passenger@example.com";
            this.txtPassengerEmail.Size = new System.Drawing.Size(280, 24);
            this.txtPassengerEmail.TabIndex = 11;

            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPaymentStatus.Location = new System.Drawing.Point(325, 186);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(102, 15);
            this.lblPaymentStatus.TabIndex = 12;
            this.lblPaymentStatus.Text = "Payment Status *";

            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Pending",
            "Refunded"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(325, 204);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(280, 24);
            this.cmbPaymentStatus.TabIndex = 13;

            // 
            // lblRoute
            // 
            this.lblRoute.AutoSize = true;
            this.lblRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRoute.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblRoute.Location = new System.Drawing.Point(25, 240);
            this.lblRoute.Name = "lblRoute";
            this.lblRoute.Size = new System.Drawing.Size(89, 15);
            this.lblRoute.TabIndex = 14;
            this.lblRoute.Text = "Route / Trip *";

            // 
            // cmbRoute
            // 
            this.cmbRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoute.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(25, 258);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(280, 24);
            this.cmbRoute.TabIndex = 15;

            // 
            // lblDepartureTime
            // 
            this.lblDepartureTime.AutoSize = true;
            this.lblDepartureTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDepartureTime.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblDepartureTime.Location = new System.Drawing.Point(325, 240);
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
            "08:30 AM",
            "09:30 AM",
            "10:00 AM",
            "11:15 AM",
            "01:30 PM",
            "03:00 PM"});
            this.cmbDepartureTime.Location = new System.Drawing.Point(325, 258);
            this.cmbDepartureTime.Name = "cmbDepartureTime";
            this.cmbDepartureTime.Size = new System.Drawing.Size(280, 24);
            this.cmbDepartureTime.TabIndex = 17;

            // 
            // lblTravelDate
            // 
            this.lblTravelDate.AutoSize = true;
            this.lblTravelDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTravelDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTravelDate.Location = new System.Drawing.Point(25, 294);
            this.lblTravelDate.Name = "lblTravelDate";
            this.lblTravelDate.Size = new System.Drawing.Size(81, 15);
            this.lblTravelDate.TabIndex = 18;
            this.lblTravelDate.Text = "Travel Date *";

            // 
            // dtpTravelDate
            // 
            this.dtpTravelDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpTravelDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTravelDate.Location = new System.Drawing.Point(25, 312);
            this.dtpTravelDate.Name = "dtpTravelDate";
            this.dtpTravelDate.Size = new System.Drawing.Size(280, 24);
            this.dtpTravelDate.TabIndex = 19;

            // 
            // lblAssignedBus
            // 
            this.lblAssignedBus.AutoSize = true;
            this.lblAssignedBus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssignedBus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblAssignedBus.Location = new System.Drawing.Point(325, 294);
            this.lblAssignedBus.Name = "lblAssignedBus";
            this.lblAssignedBus.Size = new System.Drawing.Size(89, 15);
            this.lblAssignedBus.TabIndex = 20;
            this.lblAssignedBus.Text = "Assigned Bus *";

            // 
            // cmbAssignedBus
            // 
            this.cmbAssignedBus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssignedBus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAssignedBus.FormattingEnabled = true;
            this.cmbAssignedBus.Location = new System.Drawing.Point(325, 312);
            this.cmbAssignedBus.Name = "cmbAssignedBus";
            this.cmbAssignedBus.Size = new System.Drawing.Size(280, 24);
            this.cmbAssignedBus.TabIndex = 21;

            // 
            // lblFarePerSeat
            // 
            this.lblFarePerSeat.AutoSize = true;
            this.lblFarePerSeat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFarePerSeat.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblFarePerSeat.Location = new System.Drawing.Point(25, 348);
            this.lblFarePerSeat.Name = "lblFarePerSeat";
            this.lblFarePerSeat.Size = new System.Drawing.Size(126, 15);
            this.lblFarePerSeat.TabIndex = 22;
            this.lblFarePerSeat.Text = "Fare per Seat (ETB) *";

            // 
            // numFarePerSeat
            // 
            this.numFarePerSeat.DecimalPlaces = 2;
            this.numFarePerSeat.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numFarePerSeat.Location = new System.Drawing.Point(25, 366);
            this.numFarePerSeat.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numFarePerSeat.Name = "numFarePerSeat";
            this.numFarePerSeat.Size = new System.Drawing.Size(180, 24);
            this.numFarePerSeat.TabIndex = 23;
            this.numFarePerSeat.ThousandsSeparator = true;

            // 
            // lblSeatCount
            // 
            this.lblSeatCount.AutoSize = true;
            this.lblSeatCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeatCount.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSeatCount.Location = new System.Drawing.Point(225, 348);
            this.lblSeatCount.Name = "lblSeatCount";
            this.lblSeatCount.Size = new System.Drawing.Size(80, 15);
            this.lblSeatCount.TabIndex = 24;
            this.lblSeatCount.Text = "No. of Seats";

            // 
            // txtSeatCount
            // 
            this.txtSeatCount.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtSeatCount.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSeatCount.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.txtSeatCount.Location = new System.Drawing.Point(225, 366);
            this.txtSeatCount.Name = "txtSeatCount";
            this.txtSeatCount.ReadOnly = true;
            this.txtSeatCount.Size = new System.Drawing.Size(80, 24);
            this.txtSeatCount.TabIndex = 25;
            this.txtSeatCount.Text = "0";
            this.txtSeatCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTotalAmount.Location = new System.Drawing.Point(325, 348);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(125, 15);
            this.lblTotalAmount.TabIndex = 26;
            this.lblTotalAmount.Text = "Total Amount (ETB)";

            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.FromArgb(240, 253, 244);
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(22, 163, 74);
            this.txtTotalAmount.Location = new System.Drawing.Point(325, 366);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(280, 26);
            this.txtTotalAmount.TabIndex = 27;
            this.txtTotalAmount.Text = "0.00 ETB";

            // 
            // lblSeatsPrompt
            // 
            this.lblSeatsPrompt.AutoSize = true;
            this.lblSeatsPrompt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeatsPrompt.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSeatsPrompt.Location = new System.Drawing.Point(25, 404);
            this.lblSeatsPrompt.Name = "lblSeatsPrompt";
            this.lblSeatsPrompt.Size = new System.Drawing.Size(340, 15);
            this.lblSeatsPrompt.TabIndex = 28;
            this.lblSeatsPrompt.Text = "Select Seat(s) * (Check boxes to reserve; red items are taken)";

            // 
            // clbSeats
            // 
            this.clbSeats.CheckOnClick = true;
            this.clbSeats.ColumnWidth = 110;
            this.clbSeats.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clbSeats.FormattingEnabled = true;
            this.clbSeats.Location = new System.Drawing.Point(25, 424);
            this.clbSeats.MultiColumn = true;
            this.clbSeats.Name = "clbSeats";
            this.clbSeats.Size = new System.Drawing.Size(580, 100);
            this.clbSeats.TabIndex = 29;

            // 
            // lblSelectedSeatsPreview
            // 
            this.lblSelectedSeatsPreview.AutoSize = true;
            this.lblSelectedSeatsPreview.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblSelectedSeatsPreview.ForeColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.lblSelectedSeatsPreview.Location = new System.Drawing.Point(25, 528);
            this.lblSelectedSeatsPreview.Name = "lblSelectedSeatsPreview";
            this.lblSelectedSeatsPreview.Size = new System.Drawing.Size(148, 15);
            this.lblSelectedSeatsPreview.TabIndex = 30;
            this.lblSelectedSeatsPreview.Text = "Selected Seats: None chosen";

            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblNotes.Location = new System.Drawing.Point(25, 552);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(180, 15);
            this.lblNotes.TabIndex = 31;
            this.lblNotes.Text = "Booking Notes & Special Requests";

            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotes.Location = new System.Drawing.Point(25, 570);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "e.g., Passenger luggage notes, boarding gate preferences...";
            this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNotes.Size = new System.Drawing.Size(580, 50);
            this.txtNotes.TabIndex = 32;

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(260, 634);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 36);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "💾  Save Booking";
            this.btnSave.UseVisualStyleBackColor = false;

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(395, 634);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 34;
            this.btnClear.Text = "🔄  Clear";
            this.btnClear.UseVisualStyleBackColor = false;

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnCancel.Location = new System.Drawing.Point(505, 634);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 36);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;

            // 
            // BookingDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 730);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Booking Reservation";
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFarePerSeat)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class BusDialogForm
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

        private Label lblBusId;
        private TextBox txtBusId;

        private Label lblPlateNumber;
        private TextBox txtPlateNumber;

        private Label lblManufacturer;
        private TextBox txtManufacturer;

        private Label lblModel;
        private TextBox txtModel;

        private Label lblBusType;
        private ComboBox cmbBusType;

        private Label lblCapacity;
        private NumericUpDown numCapacity;

        private Label lblRegDate;
        private DateTimePicker dtpRegDate;

        private Label lblStatus;
        private ComboBox cmbStatus;

        private Label lblRegInfo;
        private TextBox txtRegInfo;

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
            panelTitleBar = new Panel();
            lblDialogTitle = new Label();
            btnClose = new Button();
            panelContent = new Panel();
            lblHeaderTitle = new Label();
            lblHeaderSubtitle = new Label();
            lblBusId = new Label();
            txtBusId = new TextBox();
            lblPlateNumber = new Label();
            txtPlateNumber = new TextBox();
            lblManufacturer = new Label();
            txtManufacturer = new TextBox();
            lblModel = new Label();
            txtModel = new TextBox();
            lblBusType = new Label();
            cmbBusType = new ComboBox();
            lblCapacity = new Label();
            numCapacity = new NumericUpDown();
            lblRegDate = new Label();
            dtpRegDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblRegInfo = new Label();
            txtRegInfo = new TextBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            panelTitleBar.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(15, 23, 42);
            panelTitleBar.Controls.Add(lblDialogTitle);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Margin = new Padding(4, 5, 4, 5);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(771, 60);
            panelTitleBar.TabIndex = 0;
            // 
            // lblDialogTitle
            // 
            lblDialogTitle.AutoSize = true;
            lblDialogTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDialogTitle.ForeColor = Color.White;
            lblDialogTitle.Location = new Point(20, 15);
            lblDialogTitle.Margin = new Padding(4, 0, 4, 0);
            lblDialogTitle.Name = "lblDialogTitle";
            lblDialogTitle.Size = new Size(214, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Bus Fleet Management";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.ForeColor = Color.FromArgb(148, 163, 184);
            btnClose.Location = new Point(705, 0);
            btnClose.Margin = new Padding(4, 5, 4, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(66, 60);
            btnClose.TabIndex = 1;
            btnClose.Text = "✕";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(lblHeaderTitle);
            panelContent.Controls.Add(lblHeaderSubtitle);
            panelContent.Controls.Add(lblBusId);
            panelContent.Controls.Add(txtBusId);
            panelContent.Controls.Add(lblPlateNumber);
            panelContent.Controls.Add(txtPlateNumber);
            panelContent.Controls.Add(lblManufacturer);
            panelContent.Controls.Add(txtManufacturer);
            panelContent.Controls.Add(lblModel);
            panelContent.Controls.Add(txtModel);
            panelContent.Controls.Add(lblBusType);
            panelContent.Controls.Add(cmbBusType);
            panelContent.Controls.Add(lblCapacity);
            panelContent.Controls.Add(numCapacity);
            panelContent.Controls.Add(lblRegDate);
            panelContent.Controls.Add(dtpRegDate);
            panelContent.Controls.Add(lblStatus);
            panelContent.Controls.Add(cmbStatus);
            panelContent.Controls.Add(lblRegInfo);
            panelContent.Controls.Add(txtRegInfo);
            panelContent.Controls.Add(lblNotes);
            panelContent.Controls.Add(txtNotes);
            panelContent.Controls.Add(btnSave);
            panelContent.Controls.Add(btnClear);
            panelContent.Controls.Add(btnCancel);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(34, 40, 34, 40);
            panelContent.Size = new Size(771, 873);
            panelContent.TabIndex = 1;
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.AutoSize = true;
            lblHeaderTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.FromArgb(15, 23, 42);
            lblHeaderTitle.Location = new Point(34, 23);
            lblHeaderTitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(207, 41);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Add New Bus";
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 9F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblHeaderSubtitle.Location = new Point(37, 73);
            lblHeaderSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(474, 25);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Register vehicle specifications, seating capacity, and status.";
            // 
            // lblBusId
            // 
            lblBusId.AutoSize = true;
            lblBusId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBusId.ForeColor = Color.FromArgb(30, 41, 59);
            lblBusId.Location = new Point(40, 120);
            lblBusId.Margin = new Padding(4, 0, 4, 0);
            lblBusId.Name = "lblBusId";
            lblBusId.Size = new Size(80, 25);
            lblBusId.TabIndex = 2;
            lblBusId.Text = "Bus ID *";
            // 
            // txtBusId
            // 
            txtBusId.BackColor = Color.FromArgb(241, 245, 249);
            txtBusId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtBusId.Location = new Point(40, 153);
            txtBusId.Margin = new Padding(4, 5, 4, 5);
            txtBusId.Name = "txtBusId";
            txtBusId.ReadOnly = true;
            txtBusId.Size = new Size(320, 33);
            txtBusId.TabIndex = 3;
            // 
            // lblPlateNumber
            // 
            lblPlateNumber.AutoSize = true;
            lblPlateNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPlateNumber.ForeColor = Color.FromArgb(30, 41, 59);
            lblPlateNumber.Location = new Point(400, 120);
            lblPlateNumber.Margin = new Padding(4, 0, 4, 0);
            lblPlateNumber.Name = "lblPlateNumber";
            lblPlateNumber.Size = new Size(142, 25);
            lblPlateNumber.TabIndex = 4;
            lblPlateNumber.Text = "Plate Number *";
            // 
            // txtPlateNumber
            // 
            txtPlateNumber.Font = new Font("Segoe UI", 9.5F);
            txtPlateNumber.Location = new Point(400, 153);
            txtPlateNumber.Margin = new Padding(4, 5, 4, 5);
            txtPlateNumber.Name = "txtPlateNumber";
            txtPlateNumber.PlaceholderText = "e.g. 3-ET-A48120";
            txtPlateNumber.Size = new Size(330, 33);
            txtPlateNumber.TabIndex = 5;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblManufacturer.ForeColor = Color.FromArgb(30, 41, 59);
            lblManufacturer.Location = new Point(40, 213);
            lblManufacturer.Margin = new Padding(4, 0, 4, 0);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(142, 25);
            lblManufacturer.TabIndex = 6;
            lblManufacturer.Text = "Manufacturer *";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Font = new Font("Segoe UI", 9.5F);
            txtManufacturer.Location = new Point(40, 247);
            txtManufacturer.Margin = new Padding(4, 5, 4, 5);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.PlaceholderText = "e.g. Yutong, Scania";
            txtManufacturer.Size = new Size(320, 33);
            txtManufacturer.TabIndex = 7;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblModel.ForeColor = Color.FromArgb(30, 41, 59);
            lblModel.Location = new Point(400, 213);
            lblModel.Margin = new Padding(4, 0, 4, 0);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(79, 25);
            lblModel.TabIndex = 8;
            lblModel.Text = "Model *";
            // 
            // txtModel
            // 
            txtModel.Font = new Font("Segoe UI", 9.5F);
            txtModel.Location = new Point(400, 247);
            txtModel.Margin = new Padding(4, 5, 4, 5);
            txtModel.Name = "txtModel";
            txtModel.PlaceholderText = "e.g. ZK6122H, Touring HD";
            txtModel.Size = new Size(330, 33);
            txtModel.TabIndex = 9;
            // 
            // lblBusType
            // 
            lblBusType.AutoSize = true;
            lblBusType.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBusType.ForeColor = Color.FromArgb(30, 41, 59);
            lblBusType.Location = new Point(40, 307);
            lblBusType.Margin = new Padding(4, 0, 4, 0);
            lblBusType.Name = "lblBusType";
            lblBusType.Size = new Size(102, 25);
            lblBusType.TabIndex = 10;
            lblBusType.Text = "Bus Type *";
            // 
            // cmbBusType
            // 
            cmbBusType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBusType.Font = new Font("Segoe UI", 9.5F);
            cmbBusType.FormattingEnabled = true;
            cmbBusType.Items.AddRange(new object[] { "Luxury", "Standard", "Semi-Luxury", "Mini-Bus" });
            cmbBusType.Location = new Point(40, 340);
            cmbBusType.Margin = new Padding(4, 5, 4, 5);
            cmbBusType.Name = "cmbBusType";
            cmbBusType.Size = new Size(320, 33);
            cmbBusType.TabIndex = 11;
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCapacity.ForeColor = Color.FromArgb(30, 41, 59);
            lblCapacity.Location = new Point(400, 307);
            lblCapacity.Margin = new Padding(4, 0, 4, 0);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(140, 25);
            lblCapacity.TabIndex = 12;
            lblCapacity.Text = "Seat Capacity *";
            // 
            // numCapacity
            // 
            numCapacity.Font = new Font("Segoe UI", 9.5F);
            numCapacity.Location = new Point(400, 340);
            numCapacity.Margin = new Padding(4, 5, 4, 5);
            numCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(331, 33);
            numCapacity.TabIndex = 13;
            numCapacity.Value = new decimal(new int[] { 51, 0, 0, 0 });
            // 
            // lblRegDate
            // 
            lblRegDate.AutoSize = true;
            lblRegDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegDate.ForeColor = Color.FromArgb(30, 41, 59);
            lblRegDate.Location = new Point(40, 403);
            lblRegDate.Margin = new Padding(4, 0, 4, 0);
            lblRegDate.Name = "lblRegDate";
            lblRegDate.Size = new Size(174, 25);
            lblRegDate.TabIndex = 14;
            lblRegDate.Text = "Registration Date *";
            // 
            // dtpRegDate
            // 
            dtpRegDate.Font = new Font("Segoe UI", 9.5F);
            dtpRegDate.Format = DateTimePickerFormat.Short;
            dtpRegDate.Location = new Point(40, 437);
            dtpRegDate.Margin = new Padding(4, 5, 4, 5);
            dtpRegDate.Name = "dtpRegDate";
            dtpRegDate.Size = new Size(320, 33);
            dtpRegDate.TabIndex = 15;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(30, 41, 59);
            lblStatus.Location = new Point(400, 403);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(184, 25);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Operational Status *";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Maintenance", "Inactive" });
            cmbStatus.Location = new Point(400, 437);
            cmbStatus.Margin = new Padding(4, 5, 4, 5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(330, 33);
            cmbStatus.TabIndex = 17;
            // 
            // lblRegInfo
            // 
            lblRegInfo.AutoSize = true;
            lblRegInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRegInfo.ForeColor = Color.FromArgb(30, 41, 59);
            lblRegInfo.Location = new Point(40, 500);
            lblRegInfo.Margin = new Padding(4, 0, 4, 0);
            lblRegInfo.Name = "lblRegInfo";
            lblRegInfo.Size = new Size(236, 25);
            lblRegInfo.TabIndex = 18;
            lblRegInfo.Text = "Registration Information *";
            // 
            // txtRegInfo
            // 
            txtRegInfo.Font = new Font("Segoe UI", 9.5F);
            txtRegInfo.Location = new Point(40, 533);
            txtRegInfo.Margin = new Padding(4, 5, 4, 5);
            txtRegInfo.Name = "txtRegInfo";
            txtRegInfo.PlaceholderText = "e.g. Commercial Transport Permit REG-ET-2024-XXXX";
            txtRegInfo.Size = new Size(690, 33);
            txtRegInfo.TabIndex = 19;
            txtRegInfo.TextChanged += txtRegInfo_TextChanged;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNotes.ForeColor = Color.FromArgb(30, 41, 59);
            lblNotes.Location = new Point(40, 593);
            lblNotes.Margin = new Padding(4, 0, 4, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(261, 25);
            lblNotes.TabIndex = 20;
            lblNotes.Text = "Operational Notes (Optional)";
            // 
            // txtNotes
            // 
            txtNotes.Font = new Font("Segoe UI", 9.5F);
            txtNotes.Location = new Point(40, 627);
            txtNotes.Margin = new Padding(4, 5, 4, 5);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PlaceholderText = "Enter equipment, amenities, or maintenance notes...";
            txtNotes.Size = new Size(690, 97);
            txtNotes.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(13, 94, 234);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(360, 767);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 67);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save Bus";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(241, 245, 249);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(71, 85, 105);
            btnClear.Location = new Point(200, 767);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(143, 67);
            btnClear.TabIndex = 23;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(241, 245, 249);
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(71, 85, 105);
            btnCancel.Location = new Point(577, 767);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 67);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // BusDialogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(771, 933);
            Controls.Add(panelContent);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(771, 933);
            MinimumSize = new Size(771, 933);
            Name = "BusDialogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bus Registration";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}

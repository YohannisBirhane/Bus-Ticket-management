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
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblDialogTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();

            this.panelContent = new System.Windows.Forms.Panel();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.lblHeaderSubtitle = new System.Windows.Forms.Label();

            this.lblBusId = new System.Windows.Forms.Label();
            this.txtBusId = new System.Windows.Forms.TextBox();

            this.lblPlateNumber = new System.Windows.Forms.Label();
            this.txtPlateNumber = new System.Windows.Forms.TextBox();

            this.lblManufacturer = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();

            this.lblModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();

            this.lblBusType = new System.Windows.Forms.Label();
            this.cmbBusType = new System.Windows.Forms.ComboBox();

            this.lblCapacity = new System.Windows.Forms.Label();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();

            this.lblRegDate = new System.Windows.Forms.Label();
            this.dtpRegDate = new System.Windows.Forms.DateTimePicker();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.lblRegInfo = new System.Windows.Forms.Label();
            this.txtRegInfo = new System.Windows.Forms.TextBox();

            this.lblNotes = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.panelTitleBar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            this.SuspendLayout();

            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.panelTitleBar.Controls.Add(this.lblDialogTitle);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Height = 36;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(540, 36);
            this.panelTitleBar.TabIndex = 0;

            // 
            // lblDialogTitle
            // 
            this.lblDialogTitle.AutoSize = true;
            this.lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDialogTitle.ForeColor = System.Drawing.Color.White;
            this.lblDialogTitle.Location = new System.Drawing.Point(14, 9);
            this.lblDialogTitle.Name = "lblDialogTitle";
            this.lblDialogTitle.Size = new System.Drawing.Size(155, 17);
            this.lblDialogTitle.TabIndex = 0;
            this.lblDialogTitle.Text = "Bus Fleet Management";

            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnClose.Location = new System.Drawing.Point(494, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = true;

            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.lblHeaderTitle);
            this.panelContent.Controls.Add(this.lblHeaderSubtitle);
            this.panelContent.Controls.Add(this.lblBusId);
            this.panelContent.Controls.Add(this.txtBusId);
            this.panelContent.Controls.Add(this.lblPlateNumber);
            this.panelContent.Controls.Add(this.txtPlateNumber);
            this.panelContent.Controls.Add(this.lblManufacturer);
            this.panelContent.Controls.Add(this.txtManufacturer);
            this.panelContent.Controls.Add(this.lblModel);
            this.panelContent.Controls.Add(this.txtModel);
            this.panelContent.Controls.Add(this.lblBusType);
            this.panelContent.Controls.Add(this.cmbBusType);
            this.panelContent.Controls.Add(this.lblCapacity);
            this.panelContent.Controls.Add(this.numCapacity);
            this.panelContent.Controls.Add(this.lblRegDate);
            this.panelContent.Controls.Add(this.dtpRegDate);
            this.panelContent.Controls.Add(this.lblStatus);
            this.panelContent.Controls.Add(this.cmbStatus);
            this.panelContent.Controls.Add(this.lblRegInfo);
            this.panelContent.Controls.Add(this.txtRegInfo);
            this.panelContent.Controls.Add(this.lblNotes);
            this.panelContent.Controls.Add(this.txtNotes);
            this.panelContent.Controls.Add(this.btnSave);
            this.panelContent.Controls.Add(this.btnClear);
            this.panelContent.Controls.Add(this.btnCancel);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 36);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(540, 644);
            this.panelContent.TabIndex = 1;

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(142, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Add New Bus";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(26, 44);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(328, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Register vehicle specifications, seating capacity, and status.";

            // 
            // lblBusId
            // 
            this.lblBusId.AutoSize = true;
            this.lblBusId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBusId.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBusId.Location = new System.Drawing.Point(28, 72);
            this.lblBusId.Name = "lblBusId";
            this.lblBusId.Size = new System.Drawing.Size(51, 15);
            this.lblBusId.TabIndex = 2;
            this.lblBusId.Text = "Bus ID *";

            // 
            // txtBusId
            // 
            this.txtBusId.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtBusId.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBusId.Location = new System.Drawing.Point(28, 92);
            this.txtBusId.Name = "txtBusId";
            this.txtBusId.ReadOnly = true;
            this.txtBusId.Size = new System.Drawing.Size(225, 24);
            this.txtBusId.TabIndex = 3;

            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.AutoSize = true;
            this.lblPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlateNumber.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblPlateNumber.Location = new System.Drawing.Point(280, 72);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(93, 15);
            this.lblPlateNumber.TabIndex = 4;
            this.lblPlateNumber.Text = "Plate Number *";

            // 
            // txtPlateNumber
            // 
            this.txtPlateNumber.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPlateNumber.Location = new System.Drawing.Point(280, 92);
            this.txtPlateNumber.Name = "txtPlateNumber";
            this.txtPlateNumber.PlaceholderText = "e.g. 3-ET-A48120";
            this.txtPlateNumber.Size = new System.Drawing.Size(232, 24);
            this.txtPlateNumber.TabIndex = 5;

            // 
            // lblManufacturer
            // 
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblManufacturer.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblManufacturer.Location = new System.Drawing.Point(28, 128);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(91, 15);
            this.lblManufacturer.TabIndex = 6;
            this.lblManufacturer.Text = "Manufacturer *";

            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtManufacturer.Location = new System.Drawing.Point(28, 148);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.PlaceholderText = "e.g. Yutong, Scania";
            this.txtManufacturer.Size = new System.Drawing.Size(225, 24);
            this.txtManufacturer.TabIndex = 7;

            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblModel.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblModel.Location = new System.Drawing.Point(280, 128);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(50, 15);
            this.lblModel.TabIndex = 8;
            this.lblModel.Text = "Model *";

            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtModel.Location = new System.Drawing.Point(280, 148);
            this.txtModel.Name = "txtModel";
            this.txtModel.PlaceholderText = "e.g. ZK6122H, Touring HD";
            this.txtModel.Size = new System.Drawing.Size(232, 24);
            this.txtModel.TabIndex = 9;

            // 
            // lblBusType
            // 
            this.lblBusType.AutoSize = true;
            this.lblBusType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBusType.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBusType.Location = new System.Drawing.Point(28, 184);
            this.lblBusType.Name = "lblBusType";
            this.lblBusType.Size = new System.Drawing.Size(65, 15);
            this.lblBusType.TabIndex = 10;
            this.lblBusType.Text = "Bus Type *";

            // 
            // cmbBusType
            // 
            this.cmbBusType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBusType.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbBusType.FormattingEnabled = true;
            this.cmbBusType.Items.AddRange(new object[] {
            "Luxury",
            "Standard",
            "Semi-Luxury",
            "Mini-Bus"});
            this.cmbBusType.Location = new System.Drawing.Point(28, 204);
            this.cmbBusType.Name = "cmbBusType";
            this.cmbBusType.Size = new System.Drawing.Size(225, 25);
            this.cmbBusType.TabIndex = 11;

            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapacity.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblCapacity.Location = new System.Drawing.Point(280, 184);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(91, 15);
            this.lblCapacity.TabIndex = 12;
            this.lblCapacity.Text = "Seat Capacity *";

            // 
            // numCapacity
            // 
            this.numCapacity.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numCapacity.Location = new System.Drawing.Point(280, 204);
            this.numCapacity.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numCapacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(232, 24);
            this.numCapacity.TabIndex = 13;
            this.numCapacity.Value = new decimal(new int[] {
            51,
            0,
            0,
            0});

            // 
            // lblRegDate
            // 
            this.lblRegDate.AutoSize = true;
            this.lblRegDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegDate.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRegDate.Location = new System.Drawing.Point(28, 242);
            this.lblRegDate.Name = "lblRegDate";
            this.lblRegDate.Size = new System.Drawing.Size(112, 15);
            this.lblRegDate.TabIndex = 14;
            this.lblRegDate.Text = "Registration Date *";

            // 
            // dtpRegDate
            // 
            this.dtpRegDate.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpRegDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRegDate.Location = new System.Drawing.Point(28, 262);
            this.dtpRegDate.Name = "dtpRegDate";
            this.dtpRegDate.Size = new System.Drawing.Size(225, 24);
            this.dtpRegDate.TabIndex = 15;

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblStatus.Location = new System.Drawing.Point(280, 242);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(117, 15);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Operational Status *";

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Maintenance",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(280, 262);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(232, 25);
            this.cmbStatus.TabIndex = 17;

            // 
            // lblRegInfo
            // 
            this.lblRegInfo.AutoSize = true;
            this.lblRegInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRegInfo.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRegInfo.Location = new System.Drawing.Point(28, 300);
            this.lblRegInfo.Name = "lblRegInfo";
            this.lblRegInfo.Size = new System.Drawing.Size(155, 15);
            this.lblRegInfo.TabIndex = 18;
            this.lblRegInfo.Text = "Registration Information *";

            // 
            // txtRegInfo
            // 
            this.txtRegInfo.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRegInfo.Location = new System.Drawing.Point(28, 320);
            this.txtRegInfo.Name = "txtRegInfo";
            this.txtRegInfo.PlaceholderText = "e.g. Commercial Transport Permit REG-ET-2024-XXXX";
            this.txtRegInfo.Size = new System.Drawing.Size(484, 24);
            this.txtRegInfo.TabIndex = 19;

            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNotes.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblNotes.Location = new System.Drawing.Point(28, 356);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(161, 15);
            this.lblNotes.TabIndex = 20;
            this.lblNotes.Text = "Operational Notes (Optional)";

            // 
            // txtNotes
            // 
            this.txtNotes.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNotes.Location = new System.Drawing.Point(28, 376);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.PlaceholderText = "Enter equipment, amenities, or maintenance notes...";
            this.txtNotes.Size = new System.Drawing.Size(484, 60);
            this.txtNotes.TabIndex = 21;

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(252, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save Bus";
            this.btnSave.UseVisualStyleBackColor = false;

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnClear.Location = new System.Drawing.Point(140, 460);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnCancel.Location = new System.Drawing.Point(404, 460);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;

            // 
            // BusDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(540, 560);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(540, 560);
            this.MinimumSize = new System.Drawing.Size(540, 560);
            this.Name = "BusDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bus Registration";

            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

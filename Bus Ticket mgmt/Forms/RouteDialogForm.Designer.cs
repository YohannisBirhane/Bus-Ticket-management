using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    partial class RouteDialogForm
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

        private Label lblRouteId;
        private TextBox txtRouteId;

        private Label lblRouteName;
        private TextBox txtRouteName;

        private Label lblSource;
        private ComboBox cmbSource;

        private Label lblDestination;
        private ComboBox cmbDestination;

        private Label lblDistance;
        private NumericUpDown numDistance;

        private Label lblEstimatedTime;
        private TextBox txtEstimatedTime;

        private Label lblBaseFare;
        private NumericUpDown numBaseFare;

        private Label lblStatus;
        private ComboBox cmbStatus;

        private Label lblIntermediateStops;
        private TextBox txtIntermediateStops;

        private Label lblDescription;
        private TextBox txtDescription;

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

            this.lblRouteId = new System.Windows.Forms.Label();
            this.txtRouteId = new System.Windows.Forms.TextBox();

            this.lblRouteName = new System.Windows.Forms.Label();
            this.txtRouteName = new System.Windows.Forms.TextBox();

            this.lblSource = new System.Windows.Forms.Label();
            this.cmbSource = new System.Windows.Forms.ComboBox();

            this.lblDestination = new System.Windows.Forms.Label();
            this.cmbDestination = new System.Windows.Forms.ComboBox();

            this.lblDistance = new System.Windows.Forms.Label();
            this.numDistance = new System.Windows.Forms.NumericUpDown();

            this.lblEstimatedTime = new System.Windows.Forms.Label();
            this.txtEstimatedTime = new System.Windows.Forms.TextBox();

            this.lblBaseFare = new System.Windows.Forms.Label();
            this.numBaseFare = new System.Windows.Forms.NumericUpDown();

            this.lblStatus = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();

            this.lblIntermediateStops = new System.Windows.Forms.Label();
            this.txtIntermediateStops = new System.Windows.Forms.TextBox();

            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();

            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.panelTitleBar.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseFare)).BeginInit();
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
            this.panelTitleBar.Size = new System.Drawing.Size(560, 36);
            this.panelTitleBar.TabIndex = 0;

            // 
            // lblDialogTitle
            // 
            this.lblDialogTitle.AutoSize = true;
            this.lblDialogTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDialogTitle.ForeColor = System.Drawing.Color.White;
            this.lblDialogTitle.Location = new System.Drawing.Point(14, 9);
            this.lblDialogTitle.Name = "lblDialogTitle";
            this.lblDialogTitle.Size = new System.Drawing.Size(180, 17);
            this.lblDialogTitle.TabIndex = 0;
            this.lblDialogTitle.Text = "Route Network Management";

            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(148, 163, 184);
            this.btnClose.Location = new System.Drawing.Point(514, 0);
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
            this.panelContent.Controls.Add(this.lblRouteId);
            this.panelContent.Controls.Add(this.txtRouteId);
            this.panelContent.Controls.Add(this.lblRouteName);
            this.panelContent.Controls.Add(this.txtRouteName);
            this.panelContent.Controls.Add(this.lblSource);
            this.panelContent.Controls.Add(this.cmbSource);
            this.panelContent.Controls.Add(this.lblDestination);
            this.panelContent.Controls.Add(this.cmbDestination);
            this.panelContent.Controls.Add(this.lblDistance);
            this.panelContent.Controls.Add(this.numDistance);
            this.panelContent.Controls.Add(this.lblEstimatedTime);
            this.panelContent.Controls.Add(this.txtEstimatedTime);
            this.panelContent.Controls.Add(this.lblBaseFare);
            this.panelContent.Controls.Add(this.numBaseFare);
            this.panelContent.Controls.Add(this.lblStatus);
            this.panelContent.Controls.Add(this.cmbStatus);
            this.panelContent.Controls.Add(this.lblIntermediateStops);
            this.panelContent.Controls.Add(this.txtIntermediateStops);
            this.panelContent.Controls.Add(this.lblDescription);
            this.panelContent.Controls.Add(this.txtDescription);
            this.panelContent.Controls.Add(this.btnSave);
            this.panelContent.Controls.Add(this.btnClear);
            this.panelContent.Controls.Add(this.btnCancel);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 36);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(24);
            this.panelContent.Size = new System.Drawing.Size(560, 584);
            this.panelContent.TabIndex = 1;

            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblHeaderTitle.Location = new System.Drawing.Point(24, 14);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(157, 28);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "Add New Route";

            // 
            // lblHeaderSubtitle
            // 
            this.lblHeaderSubtitle.AutoSize = true;
            this.lblHeaderSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHeaderSubtitle.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblHeaderSubtitle.Location = new System.Drawing.Point(26, 44);
            this.lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            this.lblHeaderSubtitle.Size = new System.Drawing.Size(370, 15);
            this.lblHeaderSubtitle.TabIndex = 1;
            this.lblHeaderSubtitle.Text = "Define departure, destination, travel distance, base fare, and stops.";

            // 
            // lblRouteId
            // 
            this.lblRouteId.AutoSize = true;
            this.lblRouteId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRouteId.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRouteId.Location = new System.Drawing.Point(28, 72);
            this.lblRouteId.Name = "lblRouteId";
            this.lblRouteId.Size = new System.Drawing.Size(65, 15);
            this.lblRouteId.TabIndex = 2;
            this.lblRouteId.Text = "Route ID *";

            // 
            // txtRouteId
            // 
            this.txtRouteId.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.txtRouteId.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtRouteId.Location = new System.Drawing.Point(28, 92);
            this.txtRouteId.Name = "txtRouteId";
            this.txtRouteId.ReadOnly = true;
            this.txtRouteId.Size = new System.Drawing.Size(235, 24);
            this.txtRouteId.TabIndex = 3;

            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRouteName.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblRouteName.Location = new System.Drawing.Point(290, 72);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(86, 15);
            this.lblRouteName.TabIndex = 4;
            this.lblRouteName.Text = "Route Name *";

            // 
            // txtRouteName
            // 
            this.txtRouteName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRouteName.Location = new System.Drawing.Point(290, 92);
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.PlaceholderText = "e.g. Addis - Bahir Dar Express";
            this.txtRouteName.Size = new System.Drawing.Size(242, 24);
            this.txtRouteName.TabIndex = 5;

            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSource.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblSource.Location = new System.Drawing.Point(28, 128);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(126, 15);
            this.lblSource.TabIndex = 6;
            this.lblSource.Text = "Source (Departure) *";

            // 
            // cmbSource
            // 
            this.cmbSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSource.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbSource.FormattingEnabled = true;
            this.cmbSource.Items.AddRange(new object[] {
            "Addis Ababa",
            "Bahir Dar",
            "Hawassa",
            "Gondar",
            "Dire Dawa",
            "Mekelle",
            "Jimma",
            "Dessie",
            "Arba Minch",
            "Debre Berhan",
            "Jijiga",
            "Nekemte",
            "Asosa",
            "Semera",
            "Harar",
            "Bishoftu",
            "Adama",
            "Shashemene"});
            this.cmbSource.Location = new System.Drawing.Point(28, 148);
            this.cmbSource.Name = "cmbSource";
            this.cmbSource.Size = new System.Drawing.Size(235, 25);
            this.cmbSource.TabIndex = 7;

            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestination.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDestination.Location = new System.Drawing.Point(290, 128);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(133, 15);
            this.lblDestination.TabIndex = 8;
            this.lblDestination.Text = "Destination (Arrival) *";

            // 
            // cmbDestination
            // 
            this.cmbDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDestination.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbDestination.FormattingEnabled = true;
            this.cmbDestination.Items.AddRange(new object[] {
            "Addis Ababa",
            "Bahir Dar",
            "Hawassa",
            "Gondar",
            "Dire Dawa",
            "Mekelle",
            "Jimma",
            "Dessie",
            "Arba Minch",
            "Debre Berhan",
            "Jijiga",
            "Nekemte",
            "Asosa",
            "Semera",
            "Harar",
            "Bishoftu",
            "Adama",
            "Shashemene"});
            this.cmbDestination.Location = new System.Drawing.Point(290, 148);
            this.cmbDestination.Name = "cmbDestination";
            this.cmbDestination.Size = new System.Drawing.Size(242, 25);
            this.cmbDestination.TabIndex = 9;

            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDistance.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDistance.Location = new System.Drawing.Point(28, 186);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(96, 15);
            this.lblDistance.TabIndex = 10;
            this.lblDistance.Text = "Distance (km) *";

            // 
            // numDistance
            // 
            this.numDistance.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDistance.Location = new System.Drawing.Point(28, 206);
            this.numDistance.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numDistance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDistance.Name = "numDistance";
            this.numDistance.Size = new System.Drawing.Size(235, 24);
            this.numDistance.TabIndex = 11;
            this.numDistance.Value = new decimal(new int[] {
            350,
            0,
            0,
            0});

            // 
            // lblEstimatedTime
            // 
            this.lblEstimatedTime.AutoSize = true;
            this.lblEstimatedTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstimatedTime.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblEstimatedTime.Location = new System.Drawing.Point(290, 186);
            this.lblEstimatedTime.Name = "lblEstimatedTime";
            this.lblEstimatedTime.Size = new System.Drawing.Size(142, 15);
            this.lblEstimatedTime.TabIndex = 12;
            this.lblEstimatedTime.Text = "Estimated Travel Time *";

            // 
            // txtEstimatedTime
            // 
            this.txtEstimatedTime.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEstimatedTime.Location = new System.Drawing.Point(290, 206);
            this.txtEstimatedTime.Name = "txtEstimatedTime";
            this.txtEstimatedTime.PlaceholderText = "e.g. 5 hrs 30 mins";
            this.txtEstimatedTime.Size = new System.Drawing.Size(242, 24);
            this.txtEstimatedTime.TabIndex = 13;

            // 
            // lblBaseFare
            // 
            this.lblBaseFare.AutoSize = true;
            this.lblBaseFare.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBaseFare.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblBaseFare.Location = new System.Drawing.Point(28, 244);
            this.lblBaseFare.Name = "lblBaseFare";
            this.lblBaseFare.Size = new System.Drawing.Size(99, 15);
            this.lblBaseFare.TabIndex = 14;
            this.lblBaseFare.Text = "Base Fare (ETB) *";

            // 
            // numBaseFare
            // 
            this.numBaseFare.DecimalPlaces = 2;
            this.numBaseFare.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numBaseFare.Location = new System.Drawing.Point(28, 264);
            this.numBaseFare.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.numBaseFare.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numBaseFare.Name = "numBaseFare";
            this.numBaseFare.Size = new System.Drawing.Size(235, 24);
            this.numBaseFare.TabIndex = 15;
            this.numBaseFare.Value = new decimal(new int[] {
            750,
            0,
            0,
            0});

            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblStatus.Location = new System.Drawing.Point(290, 244);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 15);
            this.lblStatus.TabIndex = 16;
            this.lblStatus.Text = "Route Status *";

            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(290, 264);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(242, 25);
            this.cmbStatus.TabIndex = 17;

            // 
            // lblIntermediateStops
            // 
            this.lblIntermediateStops.AutoSize = true;
            this.lblIntermediateStops.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIntermediateStops.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblIntermediateStops.Location = new System.Drawing.Point(28, 302);
            this.lblIntermediateStops.Name = "lblIntermediateStops";
            this.lblIntermediateStops.Size = new System.Drawing.Size(201, 15);
            this.lblIntermediateStops.TabIndex = 18;
            this.lblIntermediateStops.Text = "Intermediate Stops (Optional, comma-separated)";

            // 
            // txtIntermediateStops
            // 
            this.txtIntermediateStops.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIntermediateStops.Location = new System.Drawing.Point(28, 322);
            this.txtIntermediateStops.Name = "txtIntermediateStops";
            this.txtIntermediateStops.PlaceholderText = "e.g. Bishoftu, Mojo, Batu";
            this.txtIntermediateStops.Size = new System.Drawing.Size(504, 24);
            this.txtIntermediateStops.TabIndex = 19;

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.lblDescription.Location = new System.Drawing.Point(28, 358);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(183, 15);
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Route Description / Operational Notes";

            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(28, 378);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Enter highway details, terrain remarks, or seasonal notes...";
            this.txtDescription.Size = new System.Drawing.Size(504, 66);
            this.txtDescription.TabIndex = 21;

            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(13, 94, 234);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(264, 468);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 40);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save Route";
            this.btnSave.UseVisualStyleBackColor = false;

            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(71, 85, 105);
            this.btnClear.Location = new System.Drawing.Point(148, 468);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 40);
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
            this.btnCancel.Location = new System.Drawing.Point(424, 468);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 40);
            this.btnCancel.TabIndex = 24;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;

            // 
            // RouteDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 584);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(560, 584);
            this.MinimumSize = new System.Drawing.Size(560, 584);
            this.Name = "RouteDialogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Route Registration";

            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseFare)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}

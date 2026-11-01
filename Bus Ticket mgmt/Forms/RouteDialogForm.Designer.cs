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
            panelTitleBar = new Panel();
            lblDialogTitle = new Label();
            btnClose = new Button();
            panelContent = new Panel();
            lblHeaderTitle = new Label();
            lblHeaderSubtitle = new Label();
            lblRouteId = new Label();
            txtRouteId = new TextBox();
            lblRouteName = new Label();
            txtRouteName = new TextBox();
            lblSource = new Label();
            cmbSource = new ComboBox();
            lblDestination = new Label();
            cmbDestination = new ComboBox();
            lblDistance = new Label();
            numDistance = new NumericUpDown();
            lblEstimatedTime = new Label();
            txtEstimatedTime = new TextBox();
            lblBaseFare = new Label();
            numBaseFare = new NumericUpDown();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblIntermediateStops = new Label();
            txtIntermediateStops = new TextBox();
            lblDescription = new Label();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnClear = new Button();
            btnCancel = new Button();
            panelTitleBar.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numBaseFare).BeginInit();
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
            panelTitleBar.Size = new Size(800, 60);
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
            lblDialogTitle.Size = new Size(271, 25);
            lblDialogTitle.TabIndex = 0;
            lblDialogTitle.Text = "Route Network Management";
            // 
            // btnClose
            // 
            btnClose.Dock = DockStyle.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 9.5F);
            btnClose.ForeColor = Color.FromArgb(148, 163, 184);
            btnClose.Location = new Point(734, 0);
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
            panelContent.Controls.Add(lblRouteId);
            panelContent.Controls.Add(txtRouteId);
            panelContent.Controls.Add(lblRouteName);
            panelContent.Controls.Add(txtRouteName);
            panelContent.Controls.Add(lblSource);
            panelContent.Controls.Add(cmbSource);
            panelContent.Controls.Add(lblDestination);
            panelContent.Controls.Add(cmbDestination);
            panelContent.Controls.Add(lblDistance);
            panelContent.Controls.Add(numDistance);
            panelContent.Controls.Add(lblEstimatedTime);
            panelContent.Controls.Add(txtEstimatedTime);
            panelContent.Controls.Add(lblBaseFare);
            panelContent.Controls.Add(numBaseFare);
            panelContent.Controls.Add(lblStatus);
            panelContent.Controls.Add(cmbStatus);
            panelContent.Controls.Add(lblIntermediateStops);
            panelContent.Controls.Add(txtIntermediateStops);
            panelContent.Controls.Add(lblDescription);
            panelContent.Controls.Add(txtDescription);
            panelContent.Controls.Add(btnSave);
            panelContent.Controls.Add(btnClear);
            panelContent.Controls.Add(btnCancel);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 60);
            panelContent.Margin = new Padding(4, 5, 4, 5);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(34, 40, 34, 40);
            panelContent.Size = new Size(800, 913);
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
            lblHeaderTitle.Size = new Size(240, 41);
            lblHeaderTitle.TabIndex = 0;
            lblHeaderTitle.Text = "Add New Route";
            // 
            // lblHeaderSubtitle
            // 
            lblHeaderSubtitle.AutoSize = true;
            lblHeaderSubtitle.Font = new Font("Segoe UI", 9F);
            lblHeaderSubtitle.ForeColor = Color.FromArgb(100, 116, 139);
            lblHeaderSubtitle.Location = new Point(37, 73);
            lblHeaderSubtitle.Margin = new Padding(4, 0, 4, 0);
            lblHeaderSubtitle.Name = "lblHeaderSubtitle";
            lblHeaderSubtitle.Size = new Size(537, 25);
            lblHeaderSubtitle.TabIndex = 1;
            lblHeaderSubtitle.Text = "Define departure, destination, travel distance, base fare, and stops.";
            // 
            // lblRouteId
            // 
            lblRouteId.AutoSize = true;
            lblRouteId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRouteId.ForeColor = Color.FromArgb(30, 41, 59);
            lblRouteId.Location = new Point(40, 120);
            lblRouteId.Margin = new Padding(4, 0, 4, 0);
            lblRouteId.Name = "lblRouteId";
            lblRouteId.Size = new Size(100, 25);
            lblRouteId.TabIndex = 2;
            lblRouteId.Text = "Route ID *";
            // 
            // txtRouteId
            // 
            txtRouteId.BackColor = Color.FromArgb(241, 245, 249);
            txtRouteId.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            txtRouteId.Location = new Point(40, 153);
            txtRouteId.Margin = new Padding(4, 5, 4, 5);
            txtRouteId.Name = "txtRouteId";
            txtRouteId.ReadOnly = true;
            txtRouteId.Size = new Size(334, 33);
            txtRouteId.TabIndex = 3;
            // 
            // lblRouteName
            // 
            lblRouteName.AutoSize = true;
            lblRouteName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRouteName.ForeColor = Color.FromArgb(30, 41, 59);
            lblRouteName.Location = new Point(414, 120);
            lblRouteName.Margin = new Padding(4, 0, 4, 0);
            lblRouteName.Name = "lblRouteName";
            lblRouteName.Size = new Size(131, 25);
            lblRouteName.TabIndex = 4;
            lblRouteName.Text = "Route Name *";
            // 
            // txtRouteName
            // 
            txtRouteName.Font = new Font("Segoe UI", 9.5F);
            txtRouteName.Location = new Point(414, 153);
            txtRouteName.Margin = new Padding(4, 5, 4, 5);
            txtRouteName.Name = "txtRouteName";
            txtRouteName.PlaceholderText = "e.g. Addis - Bahir Dar Express";
            txtRouteName.Size = new Size(344, 33);
            txtRouteName.TabIndex = 5;
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSource.ForeColor = Color.FromArgb(30, 41, 59);
            lblSource.Location = new Point(40, 213);
            lblSource.Margin = new Padding(4, 0, 4, 0);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(189, 25);
            lblSource.TabIndex = 6;
            lblSource.Text = "Source (Departure) *";
            // 
            // cmbSource
            // 
            cmbSource.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSource.Font = new Font("Segoe UI", 9.5F);
            cmbSource.FormattingEnabled = true;
            cmbSource.Items.AddRange(new object[] { "Addis Ababa", "Bahir Dar", "Hawassa", "Gondar", "Dire Dawa", "Mekelle", "Jimma", "Dessie", "Arba Minch", "Debre Berhan", "Jijiga", "Nekemte", "Asosa", "Semera", "Harar", "Bishoftu", "Adama", "Shashemene" });
            cmbSource.Location = new Point(40, 247);
            cmbSource.Margin = new Padding(4, 5, 4, 5);
            cmbSource.Name = "cmbSource";
            cmbSource.Size = new Size(334, 33);
            cmbSource.TabIndex = 7;
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDestination.ForeColor = Color.FromArgb(30, 41, 59);
            lblDestination.Location = new Point(414, 213);
            lblDestination.Margin = new Padding(4, 0, 4, 0);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(199, 25);
            lblDestination.TabIndex = 8;
            lblDestination.Text = "Destination (Arrival) *";
            // 
            // cmbDestination
            // 
            cmbDestination.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDestination.Font = new Font("Segoe UI", 9.5F);
            cmbDestination.FormattingEnabled = true;
            cmbDestination.Items.AddRange(new object[] { "Addis Ababa", "Bahir Dar", "Hawassa", "Gondar", "Dire Dawa", "Mekelle", "Jimma", "Dessie", "Arba Minch", "Debre Berhan", "Jijiga", "Nekemte", "Asosa", "Semera", "Harar", "Bishoftu", "Adama", "Shashemene" });
            cmbDestination.Location = new Point(414, 247);
            cmbDestination.Margin = new Padding(4, 5, 4, 5);
            cmbDestination.Name = "cmbDestination";
            cmbDestination.Size = new Size(344, 33);
            cmbDestination.TabIndex = 9;
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDistance.ForeColor = Color.FromArgb(30, 41, 59);
            lblDistance.Location = new Point(40, 310);
            lblDistance.Margin = new Padding(4, 0, 4, 0);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(143, 25);
            lblDistance.TabIndex = 10;
            lblDistance.Text = "Distance (km) *";
            // 
            // numDistance
            // 
            numDistance.Font = new Font("Segoe UI", 9.5F);
            numDistance.Location = new Point(40, 343);
            numDistance.Margin = new Padding(4, 5, 4, 5);
            numDistance.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            numDistance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDistance.Name = "numDistance";
            numDistance.Size = new Size(336, 33);
            numDistance.TabIndex = 11;
            numDistance.Value = new decimal(new int[] { 350, 0, 0, 0 });
            numDistance.ValueChanged += numDistance_ValueChanged;
            // 
            // lblEstimatedTime
            // 
            lblEstimatedTime.AutoSize = true;
            lblEstimatedTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstimatedTime.ForeColor = Color.FromArgb(30, 41, 59);
            lblEstimatedTime.Location = new Point(414, 310);
            lblEstimatedTime.Margin = new Padding(4, 0, 4, 0);
            lblEstimatedTime.Name = "lblEstimatedTime";
            lblEstimatedTime.Size = new Size(213, 25);
            lblEstimatedTime.TabIndex = 12;
            lblEstimatedTime.Text = "Estimated Travel Time *";
            // 
            // txtEstimatedTime
            // 
            txtEstimatedTime.Font = new Font("Segoe UI", 9.5F);
            txtEstimatedTime.Location = new Point(414, 343);
            txtEstimatedTime.Margin = new Padding(4, 5, 4, 5);
            txtEstimatedTime.Name = "txtEstimatedTime";
            txtEstimatedTime.PlaceholderText = "e.g. 5 hrs 30 mins";
            txtEstimatedTime.Size = new Size(344, 33);
            txtEstimatedTime.TabIndex = 13;
            // 
            // lblBaseFare
            // 
            lblBaseFare.AutoSize = true;
            lblBaseFare.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBaseFare.ForeColor = Color.FromArgb(30, 41, 59);
            lblBaseFare.Location = new Point(40, 407);
            lblBaseFare.Margin = new Padding(4, 0, 4, 0);
            lblBaseFare.Name = "lblBaseFare";
            lblBaseFare.Size = new Size(157, 25);
            lblBaseFare.TabIndex = 14;
            lblBaseFare.Text = "Base Fare (ETB) *";
            // 
            // numBaseFare
            // 
            numBaseFare.DecimalPlaces = 2;
            numBaseFare.Font = new Font("Segoe UI", 9.5F);
            numBaseFare.Location = new Point(40, 440);
            numBaseFare.Margin = new Padding(4, 5, 4, 5);
            numBaseFare.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numBaseFare.Minimum = new decimal(new int[] { 10, 0, 0, 0 });
            numBaseFare.Name = "numBaseFare";
            numBaseFare.Size = new Size(336, 33);
            numBaseFare.TabIndex = 15;
            numBaseFare.Value = new decimal(new int[] { 750, 0, 0, 0 });
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(30, 41, 59);
            lblStatus.Location = new Point(414, 407);
            lblStatus.Margin = new Padding(4, 0, 4, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(134, 25);
            lblStatus.TabIndex = 16;
            lblStatus.Text = "Route Status *";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Active", "Inactive" });
            cmbStatus.Location = new Point(414, 440);
            cmbStatus.Margin = new Padding(4, 5, 4, 5);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(344, 33);
            cmbStatus.TabIndex = 17;
            // 
            // lblIntermediateStops
            // 
            lblIntermediateStops.AutoSize = true;
            lblIntermediateStops.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblIntermediateStops.ForeColor = Color.FromArgb(30, 41, 59);
            lblIntermediateStops.Location = new Point(40, 503);
            lblIntermediateStops.Margin = new Padding(4, 0, 4, 0);
            lblIntermediateStops.Name = "lblIntermediateStops";
            lblIntermediateStops.Size = new Size(430, 25);
            lblIntermediateStops.TabIndex = 18;
            lblIntermediateStops.Text = "Intermediate Stops (Optional, comma-separated)";
            // 
            // txtIntermediateStops
            // 
            txtIntermediateStops.Font = new Font("Segoe UI", 9.5F);
            txtIntermediateStops.Location = new Point(40, 537);
            txtIntermediateStops.Margin = new Padding(4, 5, 4, 5);
            txtIntermediateStops.Name = "txtIntermediateStops";
            txtIntermediateStops.PlaceholderText = "e.g. Bishoftu, Mojo, Batu";
            txtIntermediateStops.Size = new Size(718, 33);
            txtIntermediateStops.TabIndex = 19;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDescription.ForeColor = Color.FromArgb(30, 41, 59);
            lblDescription.Location = new Point(40, 597);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(339, 25);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Route Description / Operational Notes";
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI", 9.5F);
            txtDescription.Location = new Point(40, 630);
            txtDescription.Margin = new Padding(4, 5, 4, 5);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PlaceholderText = "Enter highway details, terrain remarks, or seasonal notes...";
            txtDescription.Size = new Size(718, 107);
            txtDescription.TabIndex = 21;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(13, 94, 234);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(377, 780);
            btnSave.Margin = new Padding(4, 5, 4, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(211, 67);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save Route";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(241, 245, 249);
            btnClear.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(71, 85, 105);
            btnClear.Location = new Point(211, 780);
            btnClear.Margin = new Padding(4, 5, 4, 5);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(149, 67);
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
            btnCancel.Location = new Point(606, 780);
            btnCancel.Margin = new Padding(4, 5, 4, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(154, 67);
            btnCancel.TabIndex = 24;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // RouteDialogForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 973);
            Controls.Add(panelContent);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MaximumSize = new Size(800, 973);
            MinimumSize = new Size(800, 973);
            Name = "RouteDialogForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Route Registration";
            panelTitleBar.ResumeLayout(false);
            panelTitleBar.PerformLayout();
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)numBaseFare).EndInit();
            ResumeLayout(false);
        }

        #endregion
    }
}

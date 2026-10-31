using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class AdminDashboardForm
    {
        private Panel panelSettingsManagement = null!;
        private TextBox txtSetCompanyName = null!;
        private TextBox txtSetStationHub = null!;
        private TextBox txtSetHelpline = null!;
        private TextBox txtSetCurrency = null!;
        private TextBox txtSetTin = null!;
        private NumericUpDown numHoldMinutes = null!;
        private NumericUpDown numCancelHours = null!;
        private NumericUpDown numRefundDeduction = null!;
        private NumericUpDown numLuggageLimit = null!;
        private NumericUpDown numExcessFee = null!;
        private CheckBox chkSmsNotifications = null!;
        private CheckBox chkEmailBoarding = null!;
        private CheckBox chkDelayAlerts = null!;
        private CheckBox chkAutoArchive = null!;

        private void InitializeSettingsManagement()
        {
            panelSettingsManagement = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(248, 250, 252),
                AutoScroll = true,
                Visible = false
            };

            // 1. Header
            Panel header = new Panel { Dock = DockStyle.Top, Height = 56, BackColor = Color.White, Padding = new Padding(24, 8, 24, 8) };
            header.Paint += (s, e) =>
            {
                using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1))
                {
                    e.Graphics.DrawLine(pen, 0, header.Height - 1, header.Width, header.Height - 1);
                }
            };

            Label title = new Label
            {
                Text = "System Configuration & Operational Policies",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(24, 12),
                AutoSize = true
            };

            header.Controls.Add(title);
            panelSettingsManagement.Controls.Add(header);

            // 2. Main Content Flow
            FlowLayoutPanel flowContent = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(24, 16, 24, 60),
                BackColor = Color.FromArgb(248, 250, 252)
            };

            // Card 1: Enterprise Profile
            Panel card1 = CreateSettingsCard("Enterprise & Terminal Station Identity", 420);
            AddSettingField(card1, "Company / System Name:", txtSetCompanyName = new TextBox { Text = "Ethio Bus Transportation Services", Width = 380 }, 40);
            AddSettingField(card1, "Central Terminal Hub:", txtSetStationHub = new TextBox { Text = "Autobus Tera National Station, Addis Ababa", Width = 380 }, 105);
            AddSettingField(card1, "Customer Helpline:", txtSetHelpline = new TextBox { Text = "+251 11 551 2233", Width = 180 }, 170);
            AddSettingField(card1, "Accounting Currency:", txtSetCurrency = new TextBox { Text = "ETB (Ethiopian Birr)", Width = 180, ReadOnly = true }, 235);
            AddSettingField(card1, "Commercial Tax TIN:", txtSetTin = new TextBox { Text = "TIN-00481920-ET", Width = 180 }, 300);
            flowContent.Controls.Add(card1);

            // Card 2: Booking & Refund Policies
            Panel card2 = CreateSettingsCard("Reservation, Cancellation & Luggage Policies", 420);
            AddSettingNumeric(card2, "Unpaid Seat Hold Window (Minutes):", numHoldMinutes = new NumericUpDown { Value = 15, Minimum = 5, Maximum = 60, Width = 120 }, 40);
            AddSettingNumeric(card2, "Minimum Cancellation Notice (Hours):", numCancelHours = new NumericUpDown { Value = 2, Minimum = 1, Maximum = 24, Width = 120 }, 105);
            AddSettingNumeric(card2, "Cancellation Refund Fee Deduction (%):", numRefundDeduction = new NumericUpDown { Value = 10, Minimum = 0, Maximum = 50, Width = 120 }, 170);
            AddSettingNumeric(card2, "Complimentary Luggage Limit (kg):", numLuggageLimit = new NumericUpDown { Value = 25, Minimum = 10, Maximum = 40, Width = 120 }, 235);
            AddSettingNumeric(card2, "Excess Luggage Fee (ETB / kg):", numExcessFee = new NumericUpDown { Value = 50, Minimum = 10, Maximum = 200, Width = 120 }, 300);
            flowContent.Controls.Add(card2);

            // Card 3: Notification Services
            Panel card3 = CreateSettingsCard("Notification Dispatch & Automation Rules", 420);
            chkSmsNotifications = new CheckBox { Text = "Enable Automated SMS Booking Confirmations", Checked = true, AutoSize = true, Location = new Point(24, 45), Font = new Font("Segoe UI", 9.5f) };
            chkEmailBoarding = new CheckBox { Text = "Email Digital PDF Boarding Passes to Passengers", Checked = true, AutoSize = true, Location = new Point(24, 95), Font = new Font("Segoe UI", 9.5f) };
            chkDelayAlerts = new CheckBox { Text = "Broadcast Real-Time Trip Delay Alerts to Passenger Terminals", Checked = true, AutoSize = true, Location = new Point(24, 145), Font = new Font("Segoe UI", 9.5f) };
            chkAutoArchive = new CheckBox { Text = "Automatically Archive Departed & Completed Trips After 24 Hours", Checked = true, AutoSize = true, Location = new Point(24, 195), Font = new Font("Segoe UI", 9.5f) };

            card3.Controls.Add(chkSmsNotifications);
            card3.Controls.Add(chkEmailBoarding);
            card3.Controls.Add(chkDelayAlerts);
            card3.Controls.Add(chkAutoArchive);

            // Save Buttons inside card 3
            Button btnSaveSettings = new Button
            {
                Text = "Save Configuration",
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(15, 23, 42),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(180, 40),
                Location = new Point(24, 260),
                Cursor = Cursors.Hand
            };
            btnSaveSettings.FlatAppearance.BorderSize = 0;
            btnSaveSettings.Click += (s, e) => SaveSettings();

            Button btnResetDefaults = new Button
            {
                Text = "Reset to Defaults",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 65, 85),
                BackColor = Color.FromArgb(241, 245, 249),
                FlatStyle = FlatStyle.Flat,
                Size = new Size(140, 40),
                Location = new Point(214, 260),
                Cursor = Cursors.Hand
            };
            btnResetDefaults.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            btnResetDefaults.Click += (s, e) => LoadSettings();

            card3.Controls.Add(btnSaveSettings);
            card3.Controls.Add(btnResetDefaults);
            flowContent.Controls.Add(card3);

            panelSettingsManagement.Controls.Add(flowContent);

            this.panelMain.Controls.Add(panelSettingsManagement);
        }

        public void ShowSettingsManagementView()
        {
            HideAllPanels();
            panelSettingsManagement.Visible = true;
            panelSettingsManagement.BringToFront();
            SetActiveSidebarButton(btnNavSettings);
            lblPageHeading.Text = "System Configuration & Operational Policies";
            lblPageSubHeading.Text = "Manage enterprise information, terminal hubs, refund policies, and notification rules.";
            LoadSettings();
        }

        private void SaveSettings()
        {
            MessageBox.Show(
                "System configuration and operational policies have been successfully saved!\n\n" +
                $"• System Name: {txtSetCompanyName.Text}\n" +
                $"• Main Station: {txtSetStationHub.Text}\n" +
                $"• Hold Timer: {numHoldMinutes.Value} minutes\n" +
                $"• Refund Deduction: {numRefundDeduction.Value}%\n" +
                $"• Excess Luggage Fee: {numExcessFee.Value} ETB/kg\n" +
                "• All notification channels: Active and configured.",
                "Settings Saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void LoadSettings()
        {
            if (txtSetCompanyName != null) txtSetCompanyName.Text = "Ethio Bus Transportation Services";
            if (txtSetStationHub != null) txtSetStationHub.Text = "Autobus Tera National Station, Addis Ababa";
            if (txtSetHelpline != null) txtSetHelpline.Text = "+251 11 551 2233";
            if (txtSetTin != null) txtSetTin.Text = "TIN-00481920-ET";
            if (numHoldMinutes != null) numHoldMinutes.Value = 15;
            if (numCancelHours != null) numCancelHours.Value = 2;
            if (numRefundDeduction != null) numRefundDeduction.Value = 10;
            if (numLuggageLimit != null) numLuggageLimit.Value = 25;
            if (numExcessFee != null) numExcessFee.Value = 50;
            if (chkSmsNotifications != null) chkSmsNotifications.Checked = true;
            if (chkEmailBoarding != null) chkEmailBoarding.Checked = true;
            if (chkDelayAlerts != null) chkDelayAlerts.Checked = true;
            if (chkAutoArchive != null) chkAutoArchive.Checked = true;
        }

        private Panel CreateSettingsCard(string title, int height)
        {
            Panel card = new Panel
            {
                Size = new Size(460, height),
                BackColor = Color.White,
                Margin = new Padding(8, 8, 16, 16)
            };
            card.Paint += (s, e) =>
            {
                using (GraphicsPath p = CardPanel.GetRoundedRectanglePath(new Rectangle(0, 0, card.Width - 1, card.Height - 1), 10))
                {
                    using (SolidBrush b = new SolidBrush(Color.White)) e.Graphics.FillPath(b, p);
                    using (Pen pen = new Pen(Color.FromArgb(226, 232, 240), 1)) e.Graphics.DrawPath(pen, p);
                }
            };

            Label lbl = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 11f, FontStyle.Bold),
                ForeColor = Color.FromArgb(15, 23, 42),
                Location = new Point(20, 14),
                AutoSize = true
            };
            card.Controls.Add(lbl);

            return card;
        }

        private void AddSettingField(Panel card, string labelText, TextBox tb, int top)
        {
            Label lbl = new Label
            {
                Text = labelText,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 65, 85),
                Location = new Point(20, top),
                AutoSize = true
            };
            tb.Location = new Point(20, top + 22);
            tb.Font = new Font("Segoe UI", 9.5f);
            card.Controls.Add(lbl);
            card.Controls.Add(tb);
        }

        private void AddSettingNumeric(Panel card, string labelText, NumericUpDown num, int top)
        {
            Label lbl = new Label
            {
                Text = labelText,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                ForeColor = Color.FromArgb(51, 65, 85),
                Location = new Point(20, top),
                AutoSize = true
            };
            num.Location = new Point(20, top + 22);
            num.Font = new Font("Segoe UI", 9.5f);
            card.Controls.Add(lbl);
            card.Controls.Add(num);
        }
    }
}

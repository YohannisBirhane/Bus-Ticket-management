using System;
using System.Drawing;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class RouteDialogForm : Form
    {
        private Route? _existingRoute = null;
        private bool _isEditMode = false;

        public RouteDialogForm(Route? routeToEdit = null)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            _existingRoute = routeToEdit;
            _isEditMode = routeToEdit != null;

            InitializeFormMode();
            SetupEvents();
        }

        private void InitializeFormMode()
        {
            if (_isEditMode && _existingRoute != null)
            {
                lblDialogTitle.Text = $"Edit Route Network ({_existingRoute.RouteId})";
                lblHeaderTitle.Text = $"Edit Route: {_existingRoute.RouteId}";
                lblHeaderSubtitle.Text = "Modify route path, travel duration, distance, and base tariff.";
                btnSave.Text = "Update Route";

                txtRouteId.Text = _existingRoute.RouteId;
                txtRouteName.Text = _existingRoute.RouteName;
                cmbSource.SelectedItem = _existingRoute.Source;
                cmbDestination.SelectedItem = _existingRoute.Destination;
                numDistance.Value = _existingRoute.DistanceKm > 0 ? _existingRoute.DistanceKm : 350;
                txtEstimatedTime.Text = _existingRoute.EstimatedTime;
                numBaseFare.Value = _existingRoute.BaseFare > 0 ? _existingRoute.BaseFare : 750.0m;
                cmbStatus.SelectedItem = _existingRoute.Status;
                txtIntermediateStops.Text = _existingRoute.IntermediateStops;
                txtDescription.Text = _existingRoute.Description;

                btnClear.Enabled = false; // Disable clear in edit mode
            }
            else
            {
                lblDialogTitle.Text = "Register New Bus Route";
                lblHeaderTitle.Text = "Add New Route";
                lblHeaderSubtitle.Text = "Define departure, destination, travel distance, base fare, and stops.";
                btnSave.Text = "Save Route";

                txtRouteId.Text = RouteStore.GenerateNextId();
                cmbSource.SelectedIndex = 0;       // Default Addis Ababa
                cmbDestination.SelectedIndex = 1;  // Default Bahir Dar
                cmbStatus.SelectedIndex = 0;       // Default Active
                numDistance.Value = 350;
                numBaseFare.Value = 750.0m;
                txtEstimatedTime.Text = "5 hrs 30 mins";
            }
        }

        private void SetupEvents()
        {
            // Title bar dragging
            panelTitleBar.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            lblDialogTitle.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    WindowHelper.DragForm(this.Handle);
                }
            };

            // Close & cancel
            btnClose.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };
            btnCancel.Click += (s, e) => { this.DialogResult = DialogResult.Cancel; this.Close(); };

            btnClose.MouseEnter += (s, e) => { btnClose.BackColor = Color.FromArgb(239, 68, 68); btnClose.ForeColor = Color.White; };
            btnClose.MouseLeave += (s, e) => { btnClose.BackColor = Color.FromArgb(15, 23, 42); btnClose.ForeColor = Color.FromArgb(148, 163, 184); };

            // Source & destination auto-update route name helper if route name is default
            cmbSource.SelectedIndexChanged += (s, e) => SuggestRouteName();
            cmbDestination.SelectedIndexChanged += (s, e) => SuggestRouteName();

            // Clear button
            btnClear.Click += (s, e) => ClearForm();

            // Save route button
            btnSave.Click += (s, e) => SaveRoute();
        }

        private void SuggestRouteName()
        {
            if (!_isEditMode && string.IsNullOrWhiteSpace(txtRouteName.Text) || txtRouteName.Text.Contains("-"))
            {
                string src = cmbSource.SelectedItem?.ToString() ?? "";
                string dst = cmbDestination.SelectedItem?.ToString() ?? "";
                if (!string.IsNullOrEmpty(src) && !string.IsNullOrEmpty(dst) && src != dst)
                {
                    txtRouteName.Text = $"{src} - {dst} Express";
                }
            }
        }

        private void ClearForm()
        {
            if (!_isEditMode)
            {
                txtRouteName.Clear();
                cmbSource.SelectedIndex = 0;
                cmbDestination.SelectedIndex = 1;
                numDistance.Value = 350;
                txtEstimatedTime.Text = "5 hrs 30 mins";
                numBaseFare.Value = 750.0m;
                cmbStatus.SelectedIndex = 0;
                txtIntermediateStops.Clear();
                txtDescription.Clear();
                txtRouteName.Focus();
            }
        }

        private void SaveRoute()
        {
            string routeId = txtRouteId.Text.Trim();
            string routeName = txtRouteName.Text.Trim();
            string source = cmbSource.SelectedItem?.ToString() ?? "";
            string destination = cmbDestination.SelectedItem?.ToString() ?? "";
            int distanceKm = (int)numDistance.Value;
            string estimatedTime = txtEstimatedTime.Text.Trim();
            decimal baseFare = numBaseFare.Value;
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";
            string intermediateStops = txtIntermediateStops.Text.Trim();
            string description = txtDescription.Text.Trim();

            string? excludeId = _isEditMode ? _existingRoute?.RouteId : null;

            // 1. Route ID validation
            if (string.IsNullOrWhiteSpace(routeId))
            {
                MessageBox.Show("Route ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRouteId.Focus();
                return;
            }

            if (!RouteStore.IsRouteIdUnique(routeId, excludeId))
            {
                MessageBox.Show($"Route ID '{routeId}' is already in use. Please generate or enter a unique ID.", "Duplicate Route ID", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRouteId.Focus();
                return;
            }

            // 2. Route Name validation
            if (string.IsNullOrWhiteSpace(routeName))
            {
                MessageBox.Show("Route Name cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRouteName.Focus();
                return;
            }

            // 3. Source & Destination validation
            if (string.IsNullOrWhiteSpace(source))
            {
                MessageBox.Show("Please select a Source (Departure) location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSource.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please select a Destination (Arrival) location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDestination.Focus();
                return;
            }

            // Rule: Source and Destination cannot be the same
            if (source.Equals(destination, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Source and Destination locations cannot be the same! A route requires distinct origin and arrival cities.", "Invalid Route Endpoints", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbDestination.Focus();
                return;
            }

            // 4. Distance validation
            if (distanceKm <= 0)
            {
                MessageBox.Show("Route Distance must be greater than zero kilometers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numDistance.Focus();
                return;
            }

            // 5. Estimated travel time validation
            if (string.IsNullOrWhiteSpace(estimatedTime))
            {
                MessageBox.Show("Estimated Travel Time is required (e.g. '8 hrs 30 mins').", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstimatedTime.Focus();
                return;
            }

            // 6. Base fare validation
            if (baseFare <= 0)
            {
                MessageBox.Show("Base fare must be a positive value.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numBaseFare.Focus();
                return;
            }

            // Save / Update logic
            if (_isEditMode && _existingRoute != null)
            {
                _existingRoute.RouteName = routeName;
                _existingRoute.Source = source;
                _existingRoute.Destination = destination;
                _existingRoute.DistanceKm = distanceKm;
                _existingRoute.EstimatedTime = estimatedTime;
                _existingRoute.BaseFare = baseFare;
                _existingRoute.Status = status;
                _existingRoute.IntermediateStops = intermediateStops;
                _existingRoute.Description = description;

                RouteStore.Update(_existingRoute);
                MessageBox.Show($"Route '{routeId}' ({routeName}) updated successfully!", "Route Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Route newRoute = new Route(
                    routeId: routeId,
                    routeName: routeName,
                    source: source,
                    destination: destination,
                    distanceKm: distanceKm,
                    estimatedTime: estimatedTime,
                    baseFare: baseFare,
                    intermediateStops: intermediateStops,
                    status: status,
                    description: description
                );

                RouteStore.Add(newRoute);
                MessageBox.Show($"New route '{newRoute.RouteId}' ({routeName}) registered successfully!", "Route Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen borderPen = new Pen(Color.FromArgb(15, 23, 42), 1))
            {
                e.Graphics.DrawRectangle(borderPen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }
    }
}

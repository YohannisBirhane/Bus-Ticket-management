using System;
using System.Drawing;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public partial class BusDialogForm : Form
    {
        private Bus? _existingBus = null;
        private bool _isEditMode = false;

        public BusDialogForm(Bus? busToEdit = null)
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                     ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);

            _existingBus = busToEdit;
            _isEditMode = busToEdit != null;

            InitializeFormMode();
            SetupEvents();
        }

        private void InitializeFormMode()
        {
            if (_isEditMode && _existingBus != null)
            {
                lblDialogTitle.Text = $"Edit Bus Fleet ({_existingBus.BusId})";
                lblHeaderTitle.Text = $"Edit Bus: {_existingBus.BusId}";
                lblHeaderSubtitle.Text = "Modify vehicle specs, seating capacity, and operational status.";
                btnSave.Text = "Update Bus";

                txtBusId.Text = _existingBus.BusId;
                txtPlateNumber.Text = _existingBus.PlateNumber;
                txtManufacturer.Text = _existingBus.Manufacturer;
                txtModel.Text = _existingBus.Model;
                cmbBusType.SelectedItem = _existingBus.BusType;
                numCapacity.Value = _existingBus.Capacity > 0 ? _existingBus.Capacity : 51;
                dtpRegDate.Value = _existingBus.RegistrationDate;
                txtRegInfo.Text = _existingBus.RegistrationInfo;
                cmbStatus.SelectedItem = _existingBus.Status;
                txtNotes.Text = _existingBus.Notes;

                btnClear.Enabled = false; // Disable clear in edit mode
            }
            else
            {
                lblDialogTitle.Text = "Register New Bus";
                lblHeaderTitle.Text = "Add New Bus";
                lblHeaderSubtitle.Text = "Register vehicle specifications, seating capacity, and status.";
                btnSave.Text = "Save Bus";

                txtBusId.Text = BusStore.GenerateNextId();
                cmbBusType.SelectedIndex = 0; // Default to Luxury
                cmbStatus.SelectedIndex = 0;  // Default to Active
                numCapacity.Value = 51;
                dtpRegDate.Value = DateTime.Now;
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

            // Clear button
            btnClear.Click += (s, e) => ClearForm();

            // Save bus button
            btnSave.Click += (s, e) => SaveBus();
        }

        private void ClearForm()
        {
            if (!_isEditMode)
            {
                txtPlateNumber.Clear();
                txtManufacturer.Clear();
                txtModel.Clear();
                cmbBusType.SelectedIndex = 0;
                numCapacity.Value = 51;
                dtpRegDate.Value = DateTime.Now;
                txtRegInfo.Clear();
                cmbStatus.SelectedIndex = 0;
                txtNotes.Clear();
                txtPlateNumber.Focus();
            }
        }

        private void SaveBus()
        {
            string busId = txtBusId.Text.Trim();
            string plateNumber = txtPlateNumber.Text.Trim();
            string manufacturer = txtManufacturer.Text.Trim();
            string model = txtModel.Text.Trim();
            string busType = cmbBusType.SelectedItem?.ToString() ?? "";
            int capacity = (int)numCapacity.Value;
            DateTime regDate = dtpRegDate.Value;
            string regInfo = txtRegInfo.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString() ?? "Active";
            string notes = txtNotes.Text.Trim();

            string? excludeId = _isEditMode ? _existingBus?.BusId : null;

            // 1. Bus ID validation
            if (string.IsNullOrWhiteSpace(busId))
            {
                MessageBox.Show("Bus ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBusId.Focus();
                return;
            }

            // 2. Plate number validation
            if (string.IsNullOrWhiteSpace(plateNumber))
            {
                MessageBox.Show("Plate Number cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlateNumber.Focus();
                return;
            }

            if (!BusStore.IsPlateUnique(plateNumber, excludeId))
            {
                MessageBox.Show($"The plate number '{plateNumber}' is already registered to another bus. Please check and provide a unique plate number.", "Duplicate Plate Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPlateNumber.Focus();
                return;
            }

            // 3. Manufacturer validation
            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                MessageBox.Show("Manufacturer cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManufacturer.Focus();
                return;
            }

            // 4. Model validation
            if (string.IsNullOrWhiteSpace(model))
            {
                MessageBox.Show("Bus Model cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtModel.Focus();
                return;
            }

            // 5. Bus Type validation
            if (string.IsNullOrWhiteSpace(busType))
            {
                MessageBox.Show("Please select a Bus Type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBusType.Focus();
                return;
            }

            // 6. Seat capacity validation
            if (capacity <= 0)
            {
                MessageBox.Show("Seat Capacity must be greater than zero.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numCapacity.Focus();
                return;
            }

            // 7. Registration information validation
            if (string.IsNullOrWhiteSpace(regInfo))
            {
                MessageBox.Show("Registration Information cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRegInfo.Focus();
                return;
            }

            // 8. Status validation
            if (string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please select an Operational Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStatus.Focus();
                return;
            }

            // Save / Update logic
            if (_isEditMode && _existingBus != null)
            {
                _existingBus.PlateNumber = plateNumber;
                _existingBus.Manufacturer = manufacturer;
                _existingBus.Model = model;
                _existingBus.BusType = busType;
                _existingBus.Capacity = capacity;
                _existingBus.RegistrationDate = regDate;
                _existingBus.RegistrationInfo = regInfo;
                _existingBus.Status = status;
                _existingBus.Notes = notes;

                if (status == "Maintenance" || status == "Inactive")
                {
                    _existingBus.AssignedTrip = "None / Unavailable";
                }

                BusStore.Update(_existingBus);
                MessageBox.Show($"Bus '{busId}' ({manufacturer} {model}) updated successfully!", "Bus Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Bus newBus = new Bus(
                    busId: busId,
                    plateNumber: plateNumber,
                    manufacturer: manufacturer,
                    model: model,
                    busType: busType,
                    capacity: capacity,
                    regDate: regDate,
                    regInfo: regInfo,
                    status: status,
                    assignedTrip: "None / Available",
                    notes: notes
                );

                BusStore.Add(newBus);
                MessageBox.Show($"New bus '{newBus.BusId}' ({manufacturer} {model}) registered successfully!", "Bus Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

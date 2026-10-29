using System.Drawing;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public sealed class DriverDashboardForm : Form
    {
        private static readonly Color Navy = Color.FromArgb(15, 23, 42);
        private static readonly Color Blue = Color.FromArgb(13, 94, 234);
        private static readonly Color Background = Color.FromArgb(248, 250, 252);
        private static readonly Color Muted = Color.FromArgb(100, 116, 139);

        private readonly Panel pageHost = new();
        private readonly Label pageTitle = new();
        private readonly Label pageSubtitle = new();
        private readonly Button overviewNavigation = new();
        private readonly Button tripsNavigation = new();
        private readonly Button passengersNavigation = new();
        private readonly IReadOnlyList<DriverTrip> assignedTrips =
            DriverDemoStore.GetTripsForDriver(DriverDemoStore.DriverId);
        private readonly Label totalTripsValue = CreateMetricValue();
        private readonly Label upcomingTripsValue = CreateMetricValue();
        private readonly Label completedTripsValue = CreateMetricValue();
        private readonly Label delayedTripsValue = CreateMetricValue();
        private readonly TextBox tripSearch = new();
        private readonly ComboBox statusFilter = new();
        private readonly DateTimePicker dateFilter = new();
        private readonly CheckBox useDateFilter = new();
        private readonly DataGridView tripGrid = new();
        private readonly Label tripDetails = new();
        private readonly ComboBox statusSelector = new();
        private readonly Button updateStatusButton = new();
        private readonly TextBox passengerSearch = new();
        private readonly ListView passengerList = new();
        private readonly Button markBoardedButton = new();
        private readonly Label passengerMessage = new();
        private readonly Label statusMessage = new();
        private Panel overviewPage = new();
        private Panel tripsPage = new();
        private Panel passengersPage = new();
        private bool refreshingTrips;

        public DriverDashboardForm()
        {
            Text = "BusLink - Driver Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(1120, 780);
            Size = new Size(1320, 860);
            BackColor = Background;
            Font = new Font("Segoe UI", 9F);

            BuildLayout();
            RefreshTripList();
            UpdateSummary();
            SetStatus("Showing assigned trips for this demo driver.");
            ShowPage("overview");
        }

        private void BuildLayout()
        {
            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Margin = Padding.Empty,
                BackColor = Background
            };
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220));
            root.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 54));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var topBar = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Navy,
                Padding = new Padding(18, 0, 18, 0)
            };
            topBar.Controls.Add(new Label
            {
                Text = "BUSLINK  /  DRIVER PORTAL",
                Dock = DockStyle.Left,
                Width = 480,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            });
            var demoLabel = new Label
            {
                Text = "DEMO MODE",
                Dock = DockStyle.Right,
                Width = 110,
                ForeColor = Color.FromArgb(147, 197, 253),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight
            };
            topBar.Controls.Add(demoLabel);
            root.Controls.Add(topBar, 0, 0);
            root.SetColumnSpan(topBar, 2);

            var sidebar = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Navy,
                Padding = new Padding(10, 14, 10, 10)
            };
            sidebar.Controls.Add(new Label
            {
                Text = "DRIVER MENU",
                Location = new Point(12, 12),
                Size = new Size(180, 24),
                ForeColor = Color.FromArgb(148, 163, 184),
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            });
            sidebar.Controls.Add(new Label
            {
                Text = $"{DriverDemoStore.DriverName}\n{DriverDemoStore.DriverId}\n{DriverDemoStore.PlateNumber}",
                Location = new Point(12, 42),
                Size = new Size(190, 62),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            });
            ConfigureNavigationButton(overviewNavigation, "Overview", 120);
            ConfigureNavigationButton(tripsNavigation, "My assigned trips", 160);
            ConfigureNavigationButton(passengersNavigation, "Passenger manifest", 200);
            sidebar.Controls.Add(overviewNavigation);
            sidebar.Controls.Add(tripsNavigation);
            sidebar.Controls.Add(passengersNavigation);

            var logoutButton = CreateButton("Log out", false);
            logoutButton.SetBounds(10, 0, 198, 38);
            logoutButton.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            logoutButton.BackColor = Navy;
            logoutButton.ForeColor = Color.FromArgb(248, 113, 113);
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.Click += (sender, args) =>
            {
                if (MessageBox.Show("Return to the login screen?", "Log out",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            };
            sidebar.Controls.Add(logoutButton);
            sidebar.Resize += (sender, args) =>
            {
                logoutButton.Left = 10;
                logoutButton.Top = Math.Max(10, sidebar.ClientSize.Height - logoutButton.Height - 12);
            };
            root.Controls.Add(sidebar, 0, 1);

            var mainArea = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Background,
                Padding = new Padding(20, 16, 20, 10)
            };
            var pageHeader = new Panel
            {
                Dock = DockStyle.Top,
                Height = 68,
                BackColor = Background
            };
            pageTitle.SetBounds(0, 0, 760, 36);
            pageTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            pageTitle.ForeColor = Navy;
            pageHeader.Controls.Add(pageTitle);
            pageSubtitle.SetBounds(0, 38, 900, 22);
            pageSubtitle.Font = new Font("Segoe UI", 9.5F);
            pageSubtitle.ForeColor = Muted;
            pageHeader.Controls.Add(pageSubtitle);

            var footer = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 30,
                BackColor = Color.White,
                Padding = new Padding(8, 0, 8, 0)
            };
            statusMessage.Dock = DockStyle.Fill;
            statusMessage.TextAlign = ContentAlignment.MiddleLeft;
            statusMessage.ForeColor = Muted;
            footer.Controls.Add(statusMessage);

            pageHost.Dock = DockStyle.Fill;
            pageHost.BackColor = Background;
            mainArea.Controls.Add(pageHost);
            mainArea.Controls.Add(footer);
            mainArea.Controls.Add(pageHeader);
            root.Controls.Add(mainArea, 1, 1);

            overviewPage = BuildOverviewPage();
            tripsPage = BuildTripPanel();
            passengersPage = BuildPassengerPanel();
            pageHost.Controls.Add(overviewPage);
            pageHost.Controls.Add(tripsPage);
            pageHost.Controls.Add(passengersPage);
            Controls.Add(root);

            overviewNavigation.Click += (sender, args) => ShowPage("overview");
            tripsNavigation.Click += (sender, args) => ShowPage("trips");
            passengersNavigation.Click += (sender, args) => ShowPage("passengers");
        }

        private static void ConfigureNavigationButton(Button button, string text, int top)
        {
            button.Text = text;
            button.Location = new Point(8, top);
            button.Size = new Size(198, 36);
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Navy;
            button.ForeColor = Color.FromArgb(226, 232, 240);
            button.Font = new Font("Segoe UI", 9.5F);
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(10, 0, 0, 0);
            button.Cursor = Cursors.Hand;
        }

        private Panel BuildOverviewPage()
        {
            var page = new Panel { Dock = DockStyle.Fill, BackColor = Background };
            var welcome = new Panel
            {
                Location = new Point(10, 10),
                Size = new Size(860, 110),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Padding = new Padding(18)
            };
            welcome.Controls.Add(new Label
            {
                Text = $"Welcome back, {DriverDemoStore.DriverName}",
                Location = new Point(18, 18),
                Size = new Size(700, 34),
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Navy
            });
            welcome.Controls.Add(new Label
            {
                Text = $"Driver ID {DriverDemoStore.DriverId}  |  Assigned bus {DriverDemoStore.BusName}  |  Plate {DriverDemoStore.PlateNumber}",
                Location = new Point(18, 58),
                Size = new Size(800, 28),
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = Muted
            });
            page.Controls.Add(welcome);

            var metrics = new TableLayoutPanel
            {
                Location = new Point(10, 136),
                Size = new Size(860, 104),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                ColumnCount = 4,
                RowCount = 1,
                BackColor = Background
            };
            for (int index = 0; index < 4; index++)
            {
                metrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            }
            metrics.Controls.Add(CreateMetricCard("Assigned trips", totalTripsValue), 0, 0);
            metrics.Controls.Add(CreateMetricCard("Upcoming trips", upcomingTripsValue), 1, 0);
            metrics.Controls.Add(CreateMetricCard("Completed trips", completedTripsValue), 2, 0);
            metrics.Controls.Add(CreateMetricCard("Delayed trips", delayedTripsValue), 3, 0);
            page.Controls.Add(metrics);

            var actions = new Panel
            {
                Location = new Point(10, 258),
                Size = new Size(860, 168),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Padding = new Padding(18)
            };
            actions.Controls.Add(new Label
            {
                Text = "Driver tasks",
                Location = new Point(18, 14),
                Size = new Size(320, 30),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Navy
            });
            actions.Controls.Add(new Label
            {
                Text = "Review your schedule, update an assigned trip, and manage passenger boarding.",
                Location = new Point(18, 50),
                Size = new Size(780, 26),
                ForeColor = Muted
            });
            var tripsButton = CreateButton("Open my trips", true);
            tripsButton.SetBounds(18, 96, 165, 40);
            tripsButton.Click += (sender, args) => ShowPage("trips");
            actions.Controls.Add(tripsButton);
            var passengersButton = CreateButton("Passenger manifest", false);
            passengersButton.SetBounds(196, 96, 190, 40);
            passengersButton.Click += (sender, args) => ShowPage("passengers");
            actions.Controls.Add(passengersButton);
            page.Controls.Add(actions);

            page.Resize += (sender, args) =>
            {
                int width = Math.Max(0, page.ClientSize.Width - 20);
                welcome.Width = width;
                metrics.Width = width;
                actions.Width = width;
            };
            return page;
        }

        private Panel BuildTripPanel()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(12),
                Margin = new Padding(0, 0, 8, 0),
                BorderStyle = BorderStyle.FixedSingle
            };
            panel.Controls.Add(new Label
            {
                Text = "My Assigned Trips",
                Location = new Point(12, 10),
                Size = new Size(360, 28),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Navy
            });

            tripSearch.PlaceholderText = "Search trip or route";
            tripSearch.SetBounds(12, 44, 180, 28);
            tripSearch.TextChanged += (sender, args) => RefreshTripList();
            panel.Controls.Add(tripSearch);

            statusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            statusFilter.Items.AddRange(new object[]
                { "All statuses", "Scheduled", "Departed", "Delayed", "Completed", "Cancelled" });
            statusFilter.SelectedIndex = 0;
            statusFilter.SetBounds(200, 44, 120, 28);
            statusFilter.SelectedIndexChanged += (sender, args) => RefreshTripList();
            panel.Controls.Add(statusFilter);

            useDateFilter.Text = "Date";
            useDateFilter.SetBounds(334, 46, 60, 24);
            useDateFilter.CheckedChanged += (sender, args) => RefreshTripList();
            panel.Controls.Add(useDateFilter);
            dateFilter.Format = DateTimePickerFormat.Short;
            dateFilter.SetBounds(394, 44, 126, 28);
            dateFilter.ValueChanged += (sender, args) =>
            {
                if (useDateFilter.Checked)
                {
                    RefreshTripList();
                }
            };
            panel.Controls.Add(dateFilter);

            tripGrid.SetBounds(12, 82, 558, 236);
            tripGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tripGrid.ReadOnly = true;
            tripGrid.AllowUserToAddRows = false;
            tripGrid.AllowUserToDeleteRows = false;
            tripGrid.AllowUserToResizeRows = false;
            tripGrid.MultiSelect = false;
            tripGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tripGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tripGrid.RowHeadersVisible = false;
            tripGrid.BackgroundColor = Color.White;
            tripGrid.Columns.Add("TripId", "Trip");
            tripGrid.Columns.Add("Route", "Route");
            tripGrid.Columns.Add("Departure", "Departure");
            tripGrid.Columns.Add("Status", "Status");
            tripGrid.SelectionChanged += (sender, args) =>
            {
                if (!refreshingTrips)
                {
                    UpdateSelectedTrip();
                }
            };
            panel.Controls.Add(tripGrid);

            var detailsTitle = new Label
            {
                Text = "Trip details and status",
                Location = new Point(12, 326),
                Size = new Size(300, 24),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                ForeColor = Navy
            };
            panel.Controls.Add(detailsTitle);

            tripDetails.SetBounds(12, 352, 558, 104);
            tripDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tripDetails.ForeColor = Muted;
            panel.Controls.Add(tripDetails);

            statusSelector.DropDownStyle = ComboBoxStyle.DropDownList;
            statusSelector.Items.AddRange(new object[]
                { "Scheduled", "Departed", "Delayed", "Completed", "Cancelled" });
            statusSelector.SetBounds(12, 464, 170, 30);
            panel.Controls.Add(statusSelector);

            updateStatusButton.Text = "Update trip status";
            updateStatusButton.SetBounds(192, 462, 170, 34);
            updateStatusButton.Enabled = false;
            updateStatusButton.Click += (sender, args) => UpdateTripStatus();
            panel.Controls.Add(updateStatusButton);

            var manifestButton = CreateButton("View passenger manifest", false);
            manifestButton.SetBounds(374, 462, 190, 34);
            manifestButton.Click += (sender, args) => ShowPage("passengers");
            panel.Controls.Add(manifestButton);

            panel.Resize += (sender, args) =>
            {
                int width = Math.Max(400, panel.ClientSize.Width - 26);
                tripGrid.Width = width;
                tripDetails.Width = width;
                dateFilter.Left = width - dateFilter.Width + 12;
                useDateFilter.Left = dateFilter.Left - useDateFilter.Width;
            };
            return panel;
        }

        private Panel BuildPassengerPanel()
        {
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(12),
                Margin = new Padding(8, 0, 0, 0),
                BorderStyle = BorderStyle.FixedSingle
            };
            panel.Controls.Add(new Label
            {
                Text = "Passengers on selected trip",
                Location = new Point(12, 10),
                Size = new Size(420, 28),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Navy
            });
            passengerSearch.PlaceholderText = "Search name, booking, seat, or boarding";
            passengerSearch.SetBounds(12, 44, 440, 28);
            passengerSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passengerSearch.TextChanged += (sender, args) => RefreshPassengerList();
            panel.Controls.Add(passengerSearch);

            passengerList.SetBounds(12, 82, 440, 310);
            passengerList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passengerList.View = View.Details;
            passengerList.FullRowSelect = true;
            passengerList.GridLines = true;
            passengerList.MultiSelect = false;
            passengerList.HideSelection = false;
            passengerList.Columns.Add("Passenger", 130);
            passengerList.Columns.Add("Booking", 96);
            passengerList.Columns.Add("Seat", 45);
            passengerList.Columns.Add("Ticket", 72);
            passengerList.Columns.Add("Boarding", 80);
            passengerList.SelectedIndexChanged += (sender, args) => UpdateBoardingButton();
            panel.Controls.Add(passengerList);

            passengerMessage.SetBounds(12, 400, 440, 24);
            passengerMessage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passengerMessage.ForeColor = Muted;
            panel.Controls.Add(passengerMessage);

            markBoardedButton.Text = "Mark selected passenger as boarded";
            markBoardedButton.SetBounds(12, 432, 280, 36);
            markBoardedButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            markBoardedButton.Enabled = false;
            markBoardedButton.Click += (sender, args) => MarkSelectedPassengerBoarded();
            panel.Controls.Add(markBoardedButton);

            panel.Resize += (sender, args) =>
            {
                int width = Math.Max(300, panel.ClientSize.Width - 26);
                passengerSearch.Width = width;
                passengerList.Width = width;
                passengerList.Height = Math.Max(160, panel.ClientSize.Height - 175);
                passengerMessage.Top = passengerList.Bottom + 8;
                markBoardedButton.Top = passengerMessage.Bottom + 8;
            };
            return panel;
        }

        private static Panel CreateMetricCard(string title, Label value)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 10, 0),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            value.Location = new Point(14, 10);
            value.Size = new Size(180, 40);
            card.Controls.Add(value);
            card.Controls.Add(new Label
            {
                Text = title,
                Location = new Point(14, 54),
                Size = new Size(200, 22),
                ForeColor = Muted
            });
            return card;
        }

        private static Label CreateMetricValue()
        {
            return new Label
            {
                Text = "0",
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                ForeColor = Blue
            };
        }

        private static Button CreateButton(string text, bool primary)
        {
            var button = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = primary ? Blue : Color.White,
                ForeColor = primary ? Color.White : Navy,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            button.FlatAppearance.BorderSize = primary ? 0 : 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            return button;
        }

        private void ShowPage(string page)
        {
            overviewPage.Visible = page == "overview";
            tripsPage.Visible = page == "trips";
            passengersPage.Visible = page == "passengers";

            if (page == "overview")
            {
                pageTitle.Text = "Driver Overview";
                pageSubtitle.Text = "Your assigned schedule and current trip summary.";
            }
            else if (page == "trips")
            {
                pageTitle.Text = "My Assigned Trips";
                pageSubtitle.Text = "Search your schedule and update the status of an assigned trip.";
            }
            else
            {
                pageTitle.Text = "Passenger Manifest";
                pageSubtitle.Text = "Passenger and boarding information for your selected trip only.";
                RefreshPassengerList();
            }

            overviewNavigation.BackColor = page == "overview" ? Blue : Navy;
            tripsNavigation.BackColor = page == "trips" ? Blue : Navy;
            passengersNavigation.BackColor = page == "passengers" ? Blue : Navy;
            SetStatus(page == "overview"
                ? "Demo trip data is held in memory and resets when the application closes."
                : "Ready.");
        }

        private DriverTrip? GetSelectedTrip()
        {
            return tripGrid.SelectedRows.Count > 0
                ? tripGrid.SelectedRows[0].Tag as DriverTrip
                : null;
        }

        private void RefreshTripList(string? selectedTripId = null)
        {
            refreshingTrips = true;
            tripGrid.Rows.Clear();
            string query = tripSearch.Text.Trim();
            string selectedStatus = statusFilter.SelectedItem?.ToString() ?? "All statuses";

            foreach (var trip in assignedTrips)
            {
                string route = $"{trip.DepartureCity} to {trip.DestinationCity}";
                bool matchesQuery = string.IsNullOrWhiteSpace(query) ||
                    trip.TripId.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                    route.Contains(query, StringComparison.OrdinalIgnoreCase);
                bool matchesStatus = selectedStatus == "All statuses" || trip.Status == selectedStatus;
                bool matchesDate = !useDateFilter.Checked ||
                    trip.DepartureAt.Date == dateFilter.Value.Date;
                if (!matchesQuery || !matchesStatus || !matchesDate)
                {
                    continue;
                }

                int rowIndex = tripGrid.Rows.Add(
                    trip.TripId,
                    route,
                    trip.DepartureAt.ToString("MMM d, h:mm tt"),
                    trip.Status);
                tripGrid.Rows[rowIndex].Tag = trip;
                if (trip.TripId.Equals(selectedTripId, StringComparison.OrdinalIgnoreCase))
                {
                    tripGrid.Rows[rowIndex].Selected = true;
                    tripGrid.CurrentCell = tripGrid.Rows[rowIndex].Cells[0];
                }
            }
            refreshingTrips = false;

            if (tripGrid.Rows.Count > 0 && tripGrid.SelectedRows.Count == 0)
            {
                tripGrid.Rows[0].Selected = true;
                tripGrid.CurrentCell = tripGrid.Rows[0].Cells[0];
            }
            if (tripGrid.Rows.Count == 0)
            {
                tripDetails.Text = "No assigned trips match the selected filters.";
                RefreshPassengerList();
                updateStatusButton.Enabled = false;
                statusSelector.Enabled = false;
            }
            else
            {
                UpdateSelectedTrip();
            }
        }

        private void UpdateSelectedTrip()
        {
            var trip = GetSelectedTrip();
            if (trip == null)
            {
                tripDetails.Text = "Select an assigned trip to view its schedule and manifest.";
                statusSelector.Enabled = false;
                updateStatusButton.Enabled = false;
                RefreshPassengerList();
                return;
            }

            tripDetails.Text =
                $"Trip: {trip.TripId}     Status: {trip.Status}\n" +
                $"Route: {trip.DepartureCity} to {trip.DestinationCity}\n" +
                $"Departure: {trip.DepartureAt:ddd, MMM d yyyy h:mm tt}     " +
                $"Expected arrival: {trip.ArrivalAt:h:mm tt}\n" +
                $"Bus: {trip.BusName} ({trip.PlateNumber})     Passengers: {trip.Passengers.Count}\n" +
                $"Notes: {trip.Notes}";
            statusSelector.SelectedItem = trip.Status;
            statusSelector.Enabled = true;
            updateStatusButton.Enabled = true;
            passengerSearch.Clear();
            RefreshPassengerList();
        }

        private void RefreshPassengerList()
        {
            passengerList.BeginUpdate();
            passengerList.Items.Clear();
            var trip = GetSelectedTrip();
            string query = passengerSearch.Text.Trim();
            if (trip != null)
            {
                foreach (var passenger in trip.Passengers)
                {
                    string boarding = passenger.IsBoarded ? "Boarded" : "Not yet";
                    bool matches = string.IsNullOrWhiteSpace(query) ||
                        passenger.Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                        passenger.BookingReference.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                        passenger.SeatNumber.ToString().Contains(query, StringComparison.OrdinalIgnoreCase) ||
                        boarding.Contains(query, StringComparison.OrdinalIgnoreCase);
                    if (!matches)
                    {
                        continue;
                    }

                    var item = new ListViewItem(passenger.Name);
                    item.SubItems.Add(passenger.BookingReference);
                    item.SubItems.Add(passenger.SeatNumber.ToString());
                    item.SubItems.Add(passenger.TicketStatus);
                    item.SubItems.Add(boarding);
                    item.Tag = passenger;
                    passengerList.Items.Add(item);
                }
            }
            passengerList.EndUpdate();

            passengerMessage.Text = trip == null
                ? "Select a trip to view its passenger manifest."
                : trip.Passengers.Count == 0
                    ? "There are no passenger records for this trip."
                    : passengerList.Items.Count == 0
                        ? "No passengers match this search."
                        : $"{passengerList.Items.Count} passenger(s) shown.";
            UpdateBoardingButton();
        }

        private void UpdateBoardingButton()
        {
            markBoardedButton.Enabled =
                passengerList.SelectedItems.Count > 0 &&
                passengerList.SelectedItems[0].Tag is DriverPassengerRecord passenger &&
                !passenger.IsBoarded;
        }

        private void MarkSelectedPassengerBoarded()
        {
            if (passengerList.SelectedItems.Count == 0 ||
                passengerList.SelectedItems[0].Tag is not DriverPassengerRecord passenger)
            {
                SetStatus("Select a passenger before recording boarding.", true);
                return;
            }

            if (passenger.IsBoarded)
            {
                SetStatus($"{passenger.Name} is already marked as boarded.", true);
                return;
            }

            passenger.MarkBoarded();
            RefreshPassengerList();
            SetStatus($"{passenger.Name} marked as boarded.");
        }

        private void UpdateTripStatus()
        {
            var trip = GetSelectedTrip();
            if (trip == null || statusSelector.SelectedItem is not string newStatus)
            {
                SetStatus("Select an assigned trip and a status before updating.", true);
                return;
            }
            if (trip.Status == newStatus)
            {
                SetStatus("The selected trip already has that status.");
                return;
            }

            if (MessageBox.Show(
                    $"Change {trip.TripId} from {trip.Status} to {newStatus}?",
                    "Confirm trip status",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            trip.UpdateStatus(newStatus);
            RefreshTripList(trip.TripId);
            UpdateSummary();
            SetStatus($"{trip.TripId} status updated to {newStatus}.");
        }

        private void UpdateSummary()
        {
            totalTripsValue.Text = assignedTrips.Count.ToString();
            upcomingTripsValue.Text = assignedTrips.Count(trip =>
                trip.DepartureAt > DateTime.Now &&
                trip.Status is "Scheduled" or "Delayed").ToString();
            completedTripsValue.Text = assignedTrips.Count(trip => trip.Status == "Completed").ToString();
            delayedTripsValue.Text = assignedTrips.Count(trip => trip.Status == "Delayed").ToString();
        }

        private void SetStatus(string message, bool isError = false)
        {
            statusMessage.Text = message;
            statusMessage.ForeColor = isError ? Color.FromArgb(185, 28, 28) : Muted;
        }
    }
}

using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Forms
{
    public sealed class PassengerDashboardForm : Form
    {
        private static readonly Color Navy = Color.FromArgb(15, 23, 42);
        private static readonly Color Blue = Color.FromArgb(13, 94, 234);
        private static readonly Color PageBackground = Color.FromArgb(248, 250, 252);
        private static readonly Color MutedText = Color.FromArgb(100, 116, 139);

        private readonly Panel pageHost = new();
        private readonly Label pageTitle = new();
        private readonly Label pageSubtitle = new();
        private readonly Label statusMessage = new();
        private readonly Button overviewNavigation = new();
        private readonly Button tripsNavigation = new();
        private readonly Button bookingsNavigation = new();
        private readonly Button profileNavigation = new();

        private Panel overviewPage = new();
        private Panel tripsPage = new();
        private Panel bookingsPage = new();
        private Panel profilePage = new();

        private TextBox profileNameInput = new();
        private TextBox profileEmailInput = new();
        private TextBox profilePhoneInput = new();
        private TextBox profileAddressInput = new();
        private CheckBox emailUpdatesOption = new();
        private CheckBox smsUpdatesOption = new();

        private Label availableTripMetric = new();
        private Label activeBookingMetric = new();
        private Label availableSeatMetric = new();

        private ComboBox departureFilter = new();
        private ComboBox destinationFilter = new();
        private DateTimePicker travelDateFilter = new();
        private DataGridView tripGrid = new();
        private Label tripSearchMessage = new();
        private Label selectedTripDetails = new();
        private ComboBox seatSelector = new();
        private Label bookingFare = new();
        private TextBox passengerNameInput = new();
        private TextBox contactNumberInput = new();
        private Button confirmBookingButton = new();
        private PassengerTrip? selectedTrip;
        private bool refreshingTripResults;

        private TextBox bookingSearchInput = new();
        private ListView bookingList = new();
        private Label bookingDetails = new();
        private Button viewTicketButton = new();
        private Button cancelBookingButton = new();

        public PassengerDashboardForm()
        {
            Text = "Bus Ticket Management - Passenger Dashboard";
            StartPosition = FormStartPosition.CenterParent;
            MinimumSize = new Size(1160, 740);
            Size = new Size(1360, 860);
            BackColor = PageBackground;
            Font = new Font("Segoe UI", 9F);

            BuildShell();
            overviewPage = BuildOverviewPage();
            tripsPage = BuildTripsPage();
            bookingsPage = BuildBookingsPage();
            profilePage = BuildProfilePage();
            pageHost.Controls.Add(overviewPage);
            pageHost.Controls.Add(tripsPage);
            pageHost.Controls.Add(bookingsPage);
            pageHost.Controls.Add(profilePage);

            RefreshTripResults();
            RefreshBookingList();
            UpdateOverviewMetrics();
            ShowPage("overview");
        }

        private void BuildShell()
        {
            var shell = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Margin = Padding.Empty
            };
            shell.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220));
            shell.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            shell.RowStyles.Add(new RowStyle(SizeType.Absolute, 48));
            shell.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var topBar = new Panel
            {
                BackColor = Navy,
                Dock = DockStyle.Fill,
                Padding = new Padding(18, 0, 18, 0)
            };
            topBar.Controls.Add(new Label
            {
                Text = "BUS TICKET MANAGEMENT  /  PASSENGER PORTAL",
                Dock = DockStyle.Left,
                Width = 480,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            });
            topBar.Controls.Add(new Label
            {
                Text = "DEMO MODE",
                Dock = DockStyle.Right,
                Width = 110,
                ForeColor = Color.FromArgb(147, 197, 253),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleRight
            });
            shell.Controls.Add(topBar, 0, 0);
            shell.SetColumnSpan(topBar, 2);

            var sidebar = new Panel
            {
                BackColor = Navy,
                Dock = DockStyle.Fill,
                Padding = new Padding(10, 14, 10, 10)
            };
            sidebar.Controls.Add(new Label
            {
                Text = "PASSENGER MENU",
                Location = new Point(12, 12),
                Size = new Size(180, 24),
                ForeColor = Color.FromArgb(148, 163, 184),
                Font = new Font("Segoe UI", 8F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft
            });

            ConfigureNavigationButton(overviewNavigation, "Overview", 48);
            ConfigureNavigationButton(tripsNavigation, "Find trips", 88);
            ConfigureNavigationButton(bookingsNavigation, "My bookings", 128);
            ConfigureNavigationButton(profileNavigation, "Profile settings", 168);
            sidebar.Controls.Add(overviewNavigation);
            sidebar.Controls.Add(tripsNavigation);
            sidebar.Controls.Add(bookingsNavigation);
            sidebar.Controls.Add(profileNavigation);

            var signOutButton = new Button
            {
                Text = "Log out",
                Location = new Point(10, 0),
                Size = new Size(198, 38),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom,
                FlatStyle = FlatStyle.Flat,
                BackColor = Navy,
                ForeColor = Color.FromArgb(248, 113, 113),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Cursor = Cursors.Hand
            };
            signOutButton.FlatAppearance.BorderSize = 0;
            signOutButton.Click += (sender, args) =>
            {
                var confirm = MessageBox.Show(
                    "Are you sure you want to log out of the Passenger Portal?",
                    "Confirm Log Out",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    Close();
                }
            };
            sidebar.Controls.Add(signOutButton);
            signOutButton.BringToFront();
            signOutButton.Left = 10;
            signOutButton.Top = Math.Max(10, sidebar.ClientSize.Height - signOutButton.Height - 12);
            sidebar.Resize += (sender, args) =>
            {
                signOutButton.Left = 10;
                signOutButton.Top = Math.Max(10, sidebar.ClientSize.Height - signOutButton.Height - 12);
            };
            shell.Controls.Add(sidebar, 0, 1);

            var mainArea = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = PageBackground,
                Padding = new Padding(20, 16, 20, 10)
            };
            var header = new Panel
            {
                Dock = DockStyle.Top,
                Height = 68,
                BackColor = PageBackground
            };
            pageTitle.SetBounds(0, 0, 760, 36);
            pageTitle.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            pageTitle.ForeColor = Navy;
            header.Controls.Add(pageTitle);

            pageSubtitle.SetBounds(0, 38, 860, 22);
            pageSubtitle.Font = new Font("Segoe UI", 9.5F);
            pageSubtitle.ForeColor = MutedText;
            header.Controls.Add(pageSubtitle);

            var footer = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 30,
                BackColor = Color.White,
                Padding = new Padding(8, 0, 8, 0)
            };
            statusMessage.Dock = DockStyle.Fill;
            statusMessage.TextAlign = ContentAlignment.MiddleLeft;
            statusMessage.ForeColor = MutedText;
            footer.Controls.Add(statusMessage);

            pageHost.Dock = DockStyle.Fill;
            pageHost.BackColor = PageBackground;
            mainArea.Controls.Add(pageHost);
            mainArea.Controls.Add(footer);
            mainArea.Controls.Add(header);
            shell.Controls.Add(mainArea, 1, 1);

            Controls.Add(shell);
            overviewNavigation.Click += (sender, args) => ShowPage("overview");
            tripsNavigation.Click += (sender, args) => ShowPage("trips");
            bookingsNavigation.Click += (sender, args) => ShowPage("bookings");
            profileNavigation.Click += (sender, args) => ShowPage("profile");
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
            var page = new Panel { Dock = DockStyle.Fill, BackColor = PageBackground };
            var welcome = new Panel
            {
                Location = new Point(10, 10),
                Size = new Size(860, 118),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Padding = new Padding(18)
            };
            welcome.Controls.Add(new Label
            {
                Text = "Welcome to your passenger dashboard",
                Location = new Point(18, 18),
                Size = new Size(700, 34),
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Navy
            });
            welcome.Controls.Add(new Label
            {
                Text = "Find a route, reserve an available seat, and keep your demonstration tickets together.",
                Location = new Point(18, 58),
                Size = new Size(800, 28),
                Font = new Font("Segoe UI", 9.5F),
                ForeColor = MutedText
            });
            page.Controls.Add(welcome);

            var metrics = new TableLayoutPanel
            {
                Location = new Point(10, 142),
                Size = new Size(860, 112),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                ColumnCount = 3,
                RowCount = 1,
                BackColor = PageBackground
            };
            for (int index = 0; index < 3; index++)
            {
                metrics.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.333F));
            }

            metrics.Controls.Add(CreateMetricCard("Available trips", out availableTripMetric), 0, 0);
            metrics.Controls.Add(CreateMetricCard("Active bookings", out activeBookingMetric), 1, 0);
            metrics.Controls.Add(CreateMetricCard("Open seats", out availableSeatMetric), 2, 0);
            page.Controls.Add(metrics);

            var actions = new Panel
            {
                Location = new Point(10, 270),
                Size = new Size(860, 220),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Padding = new Padding(18)
            };
            actions.Controls.Add(new Label
            {
                Text = "Passenger tasks",
                Location = new Point(18, 14),
                Size = new Size(320, 30),
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Navy
            });
            actions.Controls.Add(new Label
            {
                Text = "1. Search for a trip     2. Choose an open seat     3. Confirm and view your ticket",
                Location = new Point(18, 50),
                Size = new Size(800, 26),
                ForeColor = MutedText
            });

            var findTripsButton = CreateActionButton("Find available trips", true);
            findTripsButton.SetBounds(18, 98, 190, 42);
            findTripsButton.Click += (sender, args) => ShowPage("trips");
            actions.Controls.Add(findTripsButton);

            var viewBookingsButton = CreateActionButton("View my bookings", false);
            viewBookingsButton.SetBounds(220, 98, 190, 42);
            viewBookingsButton.Click += (sender, args) => ShowPage("bookings");
            actions.Controls.Add(viewBookingsButton);

            actions.Controls.Add(new Label
            {
                Text = "Bookings and sample trips are stored in memory for this demo only. No account, API, database, or payment is used.",
                Location = new Point(18, 160),
                Size = new Size(800, 38),
                ForeColor = MutedText
            });
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

        private Panel BuildProfilePage()
        {
            var page = new Panel { Dock = DockStyle.Fill, BackColor = PageBackground };
            var profileCard = new GroupBox
            {
                Text = "Personal information",
                Location = new Point(10, 8),
                Size = new Size(860, 282),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Navy
            };
            profileCard.Controls.Add(new Label
            {
                Text = "DEMO PROFILE",
                Location = new Point(18, 22),
                Size = new Size(150, 22),
                ForeColor = Blue,
                Font = new Font("Segoe UI", 8F, FontStyle.Bold)
            });
            profileCard.Controls.Add(new Label
            {
                Text = "Edit your contact details for this session. Changes are not stored after the app closes.",
                Location = new Point(18, 46),
                Size = new Size(800, 24),
                ForeColor = MutedText,
                Font = new Font("Segoe UI", 9F)
            });

            AddProfileField(profileCard, "Full name", out profileNameInput, 18, 86, 245);
            AddProfileField(profileCard, "Email address", out profileEmailInput, 292, 86, 245);
            AddProfileField(profileCard, "Phone number", out profilePhoneInput, 566, 86, 245);
            AddProfileField(profileCard, "Address", out profileAddressInput, 18, 162, 519);

            profileCard.Controls.Add(new Label
            {
                Text = "Account type",
                Location = new Point(566, 162),
                Size = new Size(245, 20),
                ForeColor = MutedText,
                Font = new Font("Segoe UI", 8.5F)
            });
            profileCard.Controls.Add(new Label
            {
                Text = "Passenger (demo)",
                Location = new Point(566, 184),
                Size = new Size(245, 30),
                ForeColor = Navy,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold)
            });
            page.Controls.Add(profileCard);

            var preferencesCard = new GroupBox
            {
                Text = "Travel updates",
                Location = new Point(10, 304),
                Size = new Size(860, 148),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Navy
            };
            preferencesCard.Controls.Add(new Label
            {
                Text = "Choose how you would like to receive trip reminders and booking updates.",
                Location = new Point(18, 26),
                Size = new Size(800, 22),
                ForeColor = MutedText,
                Font = new Font("Segoe UI", 9F)
            });
            emailUpdatesOption = new CheckBox
            {
                Text = "Email me booking confirmations and travel reminders",
                Location = new Point(18, 62),
                Size = new Size(430, 26),
                Checked = true,
                ForeColor = Navy,
                Font = new Font("Segoe UI", 9F)
            };
            smsUpdatesOption = new CheckBox
            {
                Text = "Send SMS updates for trip changes",
                Location = new Point(18, 94),
                Size = new Size(430, 26),
                Checked = true,
                ForeColor = Navy,
                Font = new Font("Segoe UI", 9F)
            };
            preferencesCard.Controls.Add(emailUpdatesOption);
            preferencesCard.Controls.Add(smsUpdatesOption);
            page.Controls.Add(preferencesCard);

            var saveButton = CreateActionButton("Save settings", true);
            saveButton.SetBounds(10, 468, 150, 38);
            saveButton.Click += (sender, args) => SaveProfileSettings();
            page.Controls.Add(saveButton);

            var resetButton = CreateActionButton("Reset demo profile", false);
            resetButton.SetBounds(172, 468, 170, 38);
            resetButton.Click += (sender, args) =>
            {
                LoadDefaultProfile();
                SetStatus("Demo profile settings restored.");
            };
            page.Controls.Add(resetButton);

            page.Controls.Add(new Label
            {
                Text = "This is a visual mock only. Profile edits and notification preferences stay in memory and are not sent or persisted.",
                Location = new Point(10, 520),
                Size = new Size(860, 38),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                ForeColor = MutedText,
                Font = new Font("Segoe UI", 8.5F)
            });
            page.Resize += (sender, args) =>
            {
                int width = Math.Max(0, page.ClientSize.Width - 20);
                profileCard.Width = width;
                preferencesCard.Width = width;
                if (width > 650)
                {
                    profileEmailInput.Width = Math.Max(180, (width - 100) / 3);
                    profilePhoneInput.Width = profileEmailInput.Width;
                    profileEmailInput.Left = 292;
                    profilePhoneInput.Left = 566;
                    profileAddressInput.Width = Math.Max(300, profileEmailInput.Width * 2 + 29);
                }
            };
            LoadDefaultProfile();
            return page;
        }

        private static void AddProfileField(
            Control parent,
            string label,
            out TextBox input,
            int left,
            int top,
            int width)
        {
            parent.Controls.Add(new Label
            {
                Text = label,
                Location = new Point(left, top),
                Size = new Size(width, 20),
                ForeColor = MutedText,
                Font = new Font("Segoe UI", 8.5F)
            });
            input = new TextBox
            {
                Location = new Point(left, top + 23),
                Size = new Size(width, 30),
                Font = new Font("Segoe UI", 9.5F),
                BorderStyle = BorderStyle.FixedSingle
            };
            parent.Controls.Add(input);
        }

        private void LoadDefaultProfile()
        {
            profileNameInput.Text = "Hana Tesfaye";
            profileEmailInput.Text = "hana@gmail.com";
            profilePhoneInput.Text = "+251 912 345 678";
            profileAddressInput.Text = "Mexico, Addis Ababa";
            emailUpdatesOption.Checked = true;
            smsUpdatesOption.Checked = true;
        }

        private void SaveProfileSettings()
        {
            if (string.IsNullOrWhiteSpace(profileNameInput.Text) ||
                string.IsNullOrWhiteSpace(profileEmailInput.Text) ||
                string.IsNullOrWhiteSpace(profilePhoneInput.Text))
            {
                MessageBox.Show(
                    "Full name, email address, and phone number are required.",
                    "Profile details required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!profileEmailInput.Text.Trim().Contains('@'))
            {
                MessageBox.Show(
                    "Enter a valid email address.",
                    "Invalid email address",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                profileEmailInput.Focus();
                return;
            }

            SetStatus("Profile settings saved for this demo session only.");
            MessageBox.Show(
                "Your profile settings have been updated for this demo session.\nThey will reset when the application closes.",
                "Settings saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private static Panel CreateMetricCard(string title, out Label valueLabel)
        {
            var card = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 10, 0),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
            valueLabel = new Label
            {
                Text = "0",
                Location = new Point(14, 12),
                Size = new Size(220, 42),
                Font = new Font("Segoe UI", 20F, FontStyle.Bold),
                ForeColor = Blue
            };
            card.Controls.Add(valueLabel);
            card.Controls.Add(new Label
            {
                Text = title,
                Location = new Point(14, 62),
                Size = new Size(220, 24),
                Font = new Font("Segoe UI", 9F),
                ForeColor = MutedText
            });
            return card;
        }

        private Panel BuildTripsPage()
        {
            var page = new Panel { Dock = DockStyle.Fill, BackColor = PageBackground };
            var filters = new GroupBox
            {
                Text = "Search trips",
                Location = new Point(10, 8),
                Size = new Size(860, 98),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Navy
            };

            filters.Controls.Add(CreateFieldLabel("Departure", 12, 18, 165));
            filters.Controls.Add(CreateFieldLabel("Destination", 190, 18, 165));
            filters.Controls.Add(CreateFieldLabel("Travel date (optional)", 368, 18, 155));

            departureFilter = CreateComboBox();
            departureFilter.SetBounds(12, 39, 165, 28);
            destinationFilter = CreateComboBox();
            destinationFilter.SetBounds(190, 39, 165, 28);
            travelDateFilter = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                ShowCheckBox = true,
                Checked = false
            };
            travelDateFilter.SetBounds(368, 39, 150, 28);

            var cities = PassengerBookingStore.GetTrips()
                .SelectMany(trip => new[] { trip.DepartureCity, trip.DestinationCity })
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderBy(city => city)
                .ToArray();
            departureFilter.Items.Add("Any city");
            destinationFilter.Items.Add("Any city");
            departureFilter.Items.AddRange(cities);
            destinationFilter.Items.AddRange(cities);
            departureFilter.SelectedIndex = 0;
            destinationFilter.SelectedIndex = 0;

            var searchButton = CreateActionButton("Search", true);
            searchButton.SetBounds(535, 38, 96, 30);
            searchButton.Click += (sender, args) => SearchTripsFromInputs();

            var clearButton = CreateActionButton("Clear", false);
            clearButton.SetBounds(641, 38, 96, 30);
            clearButton.Click += (sender, args) => ClearTripSearch();

            tripSearchMessage = CreateFieldLabel("Choose a route and select a trip to see its seats.", 12, 68, 810);
            tripSearchMessage.ForeColor = MutedText;
            tripSearchMessage.Font = new Font("Segoe UI", 8.5F);
            filters.Controls.Add(departureFilter);
            filters.Controls.Add(destinationFilter);
            filters.Controls.Add(travelDateFilter);
            filters.Controls.Add(searchButton);
            filters.Controls.Add(clearButton);
            filters.Controls.Add(tripSearchMessage);
            page.Controls.Add(filters);

            tripGrid = new DataGridView
            {
                Location = new Point(10, 114),
                Size = new Size(860, 220),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AllowUserToResizeRows = false,
                MultiSelect = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                GridColor = Color.FromArgb(226, 232, 240),
                EnableHeadersVisualStyles = false
            };
            tripGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(241, 245, 249);
            tripGrid.ColumnHeadersDefaultCellStyle.ForeColor = Navy;
            tripGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tripGrid.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            tripGrid.DefaultCellStyle.ForeColor = Navy;
            tripGrid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            tripGrid.DefaultCellStyle.SelectionForeColor = Navy;
            tripGrid.Columns.Add("TripId", "Trip");
            tripGrid.Columns.Add("DepartureCity", "From");
            tripGrid.Columns.Add("DestinationCity", "To");
            tripGrid.Columns.Add("DepartureAt", "Departure");
            tripGrid.Columns.Add("ArrivalAt", "Arrival");
            tripGrid.Columns.Add("Fare", "Fare (ETB)");
            tripGrid.Columns.Add("Seats", "Open seats");
            tripGrid.SelectionChanged += (sender, args) =>
            {
                if (!refreshingTripResults)
                {
                    UpdateSelectedTrip();
                }
            };
            page.Controls.Add(tripGrid);

            var detailsGroup = new GroupBox
            {
                Text = "Selected trip",
                Location = new Point(10, 342),
                Size = new Size(860, 78),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Navy
            };
            selectedTripDetails = CreateFieldLabel("Select a trip from the list to view its route, schedule, fare, and available seats.",
                14, 26, 820, 32);
            selectedTripDetails.Font = new Font("Segoe UI", 9F);
            selectedTripDetails.ForeColor = MutedText;
            detailsGroup.Controls.Add(selectedTripDetails);
            page.Controls.Add(detailsGroup);

            var bookingGroup = new GroupBox
            {
                Text = "Passenger details and seat",
                Location = new Point(10, 428),
                Size = new Size(860, 150),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Navy
            };
            bookingGroup.Controls.Add(CreateFieldLabel("Passenger name", 14, 24, 205));
            bookingGroup.Controls.Add(CreateFieldLabel("Contact number", 232, 24, 180));
            bookingGroup.Controls.Add(CreateFieldLabel("Available seat", 425, 24, 132));

            passengerNameInput = new TextBox { Font = new Font("Segoe UI", 9.5F) };
            passengerNameInput.SetBounds(14, 47, 205, 30);
            contactNumberInput = new TextBox { Font = new Font("Segoe UI", 9.5F) };
            contactNumberInput.SetBounds(232, 47, 180, 30);
            seatSelector = CreateComboBox();
            seatSelector.SetBounds(425, 47, 132, 30);
            seatSelector.SelectedIndexChanged += (sender, args) => UpdateConfirmButton();

            bookingFare = CreateFieldLabel("Fare: --", 574, 43, 122, 42);
            bookingFare.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            bookingFare.ForeColor = Navy;
            confirmBookingButton = CreateActionButton("Confirm booking", true);
            confirmBookingButton.SetBounds(708, 45, 136, 36);
            confirmBookingButton.Enabled = false;
            confirmBookingButton.Click += (sender, args) => ConfirmBooking();

            bookingGroup.Controls.Add(passengerNameInput);
            bookingGroup.Controls.Add(contactNumberInput);
            bookingGroup.Controls.Add(seatSelector);
            bookingGroup.Controls.Add(bookingFare);
            bookingGroup.Controls.Add(confirmBookingButton);
            bookingGroup.Controls.Add(new Label
            {
                Text = "One passenger and one seat per booking. Payment is not processed in this demonstration.",
                Location = new Point(14, 96),
                Size = new Size(820, 28),
                ForeColor = MutedText,
                Font = new Font("Segoe UI", 8.5F)
            });
            page.Controls.Add(bookingGroup);

            page.Resize += (sender, args) =>
            {
                int width = Math.Max(780, page.ClientSize.Width - 20);
                filters.Width = width;
                tripGrid.Width = width;
                detailsGroup.Width = width;
                bookingGroup.Width = width;
                tripSearchMessage.Width = width - 36;
                selectedTripDetails.Width = width - 40;
            };
            return page;
        }

        private Panel BuildBookingsPage()
        {
            var page = new Panel { Dock = DockStyle.Fill, BackColor = PageBackground };
            var toolbar = new GroupBox
            {
                Text = "Search booking history",
                Location = new Point(10, 8),
                Size = new Size(860, 70),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Navy
            };
            bookingSearchInput = new TextBox { Font = new Font("Segoe UI", 9.5F) };
            bookingSearchInput.SetBounds(14, 26, 520, 28);
            bookingSearchInput.PlaceholderText = "Search by booking reference, passenger, or route";
            bookingSearchInput.TextChanged += (sender, args) => RefreshBookingList();
            var clearButton = CreateActionButton("Clear search", false);
            clearButton.SetBounds(548, 25, 115, 30);
            clearButton.Click += (sender, args) => bookingSearchInput.Clear();
            toolbar.Controls.Add(bookingSearchInput);
            toolbar.Controls.Add(clearButton);
            page.Controls.Add(toolbar);

            bookingList = new ListView
            {
                Location = new Point(10, 86),
                Size = new Size(860, 300),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                View = View.Details,
                FullRowSelect = true,
                GridLines = true,
                MultiSelect = false,
                HideSelection = false,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F)
            };
            bookingList.Columns.Add("Reference", 120);
            bookingList.Columns.Add("Passenger", 145);
            bookingList.Columns.Add("Route", 210);
            bookingList.Columns.Add("Travel date", 105);
            bookingList.Columns.Add("Seat", 60);
            bookingList.Columns.Add("Fare (ETB)", 90);
            bookingList.Columns.Add("Status", 95);
            bookingList.SelectedIndexChanged += (sender, args) => UpdateSelectedBooking();
            page.Controls.Add(bookingList);

            var detailsGroup = new GroupBox
            {
                Text = "Booking details and ticket",
                Location = new Point(10, 396),
                Size = new Size(860, 180),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Navy
            };
            bookingDetails = CreateFieldLabel("Select a booking to view its ticket details.", 14, 28, 610, 112);
            bookingDetails.Font = new Font("Segoe UI", 9.5F);
            bookingDetails.ForeColor = MutedText;

            viewTicketButton = CreateActionButton("View ticket", true);
            viewTicketButton.SetBounds(650, 38, 180, 36);
            viewTicketButton.Enabled = false;
            viewTicketButton.Click += (sender, args) =>
            {
                var booking = GetSelectedBooking();
                if (booking != null)
                {
                    ShowTicketPreview(booking);
                }
            };

            cancelBookingButton = CreateActionButton("Cancel booking", false);
            cancelBookingButton.SetBounds(650, 84, 180, 36);
            cancelBookingButton.Enabled = false;
            cancelBookingButton.ForeColor = Color.FromArgb(185, 28, 28);
            cancelBookingButton.Click += (sender, args) => CancelSelectedBooking();

            detailsGroup.Controls.Add(bookingDetails);
            detailsGroup.Controls.Add(viewTicketButton);
            detailsGroup.Controls.Add(cancelBookingButton);
            page.Controls.Add(detailsGroup);

            page.Resize += (sender, args) =>
            {
                int width = Math.Max(780, page.ClientSize.Width - 20);
                toolbar.Width = width;
                bookingList.Width = width;
                detailsGroup.Width = width;
                bookingDetails.Width = Math.Max(400, width - 250);
            };
            return page;
        }

        private static Label CreateFieldLabel(string text, int left, int top, int width, int height = 20)
        {
            return new Label
            {
                Text = text,
                Location = new Point(left, top),
                Size = new Size(width, height),
                TextAlign = ContentAlignment.MiddleLeft,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Navy
            };
        }

        private static ComboBox CreateComboBox()
        {
            return new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9.5F),
                IntegralHeight = false
            };
        }

        private static Button CreateActionButton(string text, bool primary)
        {
            var button = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = primary ? Blue : Color.White,
                ForeColor = primary ? Color.White : Navy,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Cursor = Cursors.Hand,
                UseVisualStyleBackColor = false
            };
            button.FlatAppearance.BorderSize = primary ? 0 : 1;
            button.FlatAppearance.BorderColor = Color.FromArgb(203, 213, 225);
            return button;
        }

        private void ShowPage(string page)
        {
            overviewPage.Visible = page == "overview";
            tripsPage.Visible = page == "trips";
            bookingsPage.Visible = page == "bookings";
            profilePage.Visible = page == "profile";

            if (page == "overview")
            {
                pageTitle.Text = "Passenger Overview";
                pageSubtitle.Text = "Search trips, reserve a seat, and review your demonstration bookings.";
            }
            else if (page == "trips")
            {
                pageTitle.Text = "Find Available Trips";
                pageSubtitle.Text = "Filter sample routes and choose an open seat before confirming a booking.";
            }
            else if (page == "bookings")
            {
                pageTitle.Text = "My Bookings";
                pageSubtitle.Text = "View ticket details or cancel a confirmed booking and release its seat.";
                RefreshBookingList();
            }
            else
            {
                pageTitle.Text = "Profile Settings";
                pageSubtitle.Text = "Manage your sample passenger details and travel notification preferences.";
            }

            overviewNavigation.BackColor = page == "overview" ? Blue : Navy;
            tripsNavigation.BackColor = page == "trips" ? Blue : Navy;
            bookingsNavigation.BackColor = page == "bookings" ? Blue : Navy;
            profileNavigation.BackColor = page == "profile" ? Blue : Navy;
            SetStatus(page == "overview"
                ? "Demo data is held in memory and resets when the application closes."
                : "Ready.");
        }

        private void SetStatus(string message, bool isError = false)
        {
            statusMessage.Text = message;
            statusMessage.ForeColor = isError ? Color.FromArgb(185, 28, 28) : MutedText;
        }

        private void SearchTripsFromInputs()
        {
            string? departure = GetSelectedCity(departureFilter);
            string? destination = GetSelectedCity(destinationFilter);
            if (!string.IsNullOrWhiteSpace(departure) &&
                departure.Equals(destination, StringComparison.OrdinalIgnoreCase))
            {
                tripSearchMessage.Text = "Departure and destination must be different cities.";
                SetStatus(tripSearchMessage.Text, true);
                return;
            }

            RefreshTripResults();
            if (tripGrid.Rows.Count == 0)
            {
                tripSearchMessage.Text = "No matching trips were found. Try another route or date.";
                SetStatus(tripSearchMessage.Text, true);
                MessageBox.Show(tripSearchMessage.Text, "No trips found",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tripSearchMessage.Text = $"Found {tripGrid.Rows.Count} available trip(s).";
                SetStatus(tripSearchMessage.Text);
            }
        }

        private static string? GetSelectedCity(ComboBox selector)
        {
            string? value = selector.SelectedItem?.ToString();
            return string.IsNullOrWhiteSpace(value) || value == "Any city" ? null : value;
        }

        private void ClearTripSearch()
        {
            departureFilter.SelectedIndex = 0;
            destinationFilter.SelectedIndex = 0;
            travelDateFilter.Checked = false;
            RefreshTripResults();
            tripSearchMessage.Text = "Choose a route and select a trip to see its seats.";
            SetStatus("Trip search cleared.");
        }

        private void RefreshTripResults(string? preserveTripId = null)
        {
            if (tripGrid.IsDisposed)
            {
                return;
            }

            refreshingTripResults = true;
            selectedTrip = null;
            seatSelector.Items.Clear();
            bookingFare.Text = "Fare: --";
            selectedTripDetails.Text = "Select a trip from the list to view its route, schedule, fare, and available seats.";
            var trips = PassengerBookingStore.SearchTrips(
                GetSelectedCity(departureFilter),
                GetSelectedCity(destinationFilter),
                travelDateFilter.Checked ? travelDateFilter.Value.Date : null);

            tripGrid.Rows.Clear();
            foreach (var trip in trips)
            {
                int rowIndex = tripGrid.Rows.Add(
                    trip.TripId,
                    trip.DepartureCity,
                    trip.DestinationCity,
                    trip.DepartureAt.ToString("ddd, MMM d  h:mm tt"),
                    trip.ArrivalAt.ToString("h:mm tt"),
                    trip.FareEtb.ToString("N0"),
                    PassengerBookingStore.GetAvailableSeatCount(trip.TripId));
                tripGrid.Rows[rowIndex].Tag = trip;
            }
            tripGrid.ClearSelection();
            tripGrid.CurrentCell = null;
            refreshingTripResults = false;

            if (!string.IsNullOrWhiteSpace(preserveTripId))
            {
                foreach (DataGridViewRow row in tripGrid.Rows)
                {
                    if (row.Tag is PassengerTrip trip &&
                        trip.TripId.Equals(preserveTripId, StringComparison.OrdinalIgnoreCase))
                    {
                        row.Selected = true;
                        tripGrid.CurrentCell = row.Cells[0];
                        break;
                    }
                }
            }

            if (selectedTrip == null)
            {
                UpdateSelectedTrip();
            }

            if (tripGrid.Rows.Count > 0 && string.IsNullOrWhiteSpace(preserveTripId))
            {
                tripSearchMessage.Text = $"{tripGrid.Rows.Count} available trip(s). Select a row to continue.";
            }
            else if (tripGrid.Rows.Count == 0)
            {
                tripSearchMessage.Text = "No matching trips were found. Try another route or date.";
            }
            UpdateConfirmButton();
        }

        private void UpdateSelectedTrip()
        {
            selectedTrip = tripGrid.SelectedRows.Count > 0
                ? tripGrid.SelectedRows[0].Tag as PassengerTrip
                : null;

            seatSelector.Items.Clear();
            if (selectedTrip == null)
            {
                selectedTripDetails.Text = "Select a trip from the list to view its route, schedule, fare, and available seats.";
                bookingFare.Text = "Fare: --";
                UpdateConfirmButton();
                return;
            }

            foreach (int seatNumber in PassengerBookingStore.GetAvailableSeats(selectedTrip.TripId))
            {
                seatSelector.Items.Add(seatNumber);
            }

            selectedTripDetails.Text =
                $"{selectedTrip.TripId}  |  {selectedTrip.DepartureCity} to {selectedTrip.DestinationCity}  |  " +
                $"{selectedTrip.DepartureAt:dddd, MMMM d at h:mm tt} - {selectedTrip.ArrivalAt:h:mm tt}  |  " +
                $"{selectedTrip.FareEtb:N0} ETB  |  {seatSelector.Items.Count} of {selectedTrip.SeatCapacity} seats available";
            bookingFare.Text = $"Fare:\n{selectedTrip.FareEtb:N0} ETB";
            UpdateConfirmButton();
        }

        private void UpdateConfirmButton()
        {
            if (confirmBookingButton != null && !confirmBookingButton.IsDisposed)
            {
                confirmBookingButton.Enabled = selectedTrip != null && seatSelector.SelectedItem is int;
            }
        }

        private void ConfirmBooking()
        {
            if (selectedTrip == null || seatSelector.SelectedItem is not int seatNumber)
            {
                MessageBox.Show("Select a trip and an available seat first.", "Selection required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string passengerName = passengerNameInput.Text.Trim();
            string contactNumber = contactNumberInput.Text.Trim();
            int digitCount = contactNumber.Count(char.IsDigit);
            if (passengerName.Length < 2)
            {
                MessageBox.Show("Enter the passenger's full name.", "Passenger name required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passengerNameInput.Focus();
                return;
            }

            if (digitCount < 7 || contactNumber.Length > 24)
            {
                MessageBox.Show("Enter a valid contact number with at least 7 digits.", "Contact number required",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contactNumberInput.Focus();
                return;
            }

            string summary =
                $"Passenger: {passengerName}\n" +
                $"Route: {selectedTrip.DepartureCity} to {selectedTrip.DestinationCity}\n" +
                $"Departure: {selectedTrip.DepartureAt:ddd, MMM d yyyy h:mm tt}\n" +
                $"Seat: {seatNumber}\n" +
                $"Fare: {selectedTrip.FareEtb:N0} ETB\n\n" +
                "This is a demo booking. No payment will be taken.";
            if (MessageBox.Show(summary, "Review booking",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            string tripId = selectedTrip.TripId;
            if (!PassengerBookingStore.TryCreateBooking(
                    passengerName,
                    contactNumber,
                    tripId,
                    seatNumber,
                    out var booking,
                    out string error))
            {
                MessageBox.Show(error, "Booking not completed",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RefreshTripResults(tripId);
                return;
            }

            RefreshTripResults(tripId);
            RefreshBookingList(booking!.Reference);
            UpdateOverviewMetrics();
            SetStatus($"Booking {booking.Reference} confirmed. Seat {booking.SeatNumber} is reserved for this trip.");
            ShowTicketPreview(booking);
            ShowPage("bookings");
            RefreshBookingList(booking.Reference);
        }

        private void UpdateOverviewMetrics()
        {
            availableTripMetric.Text = PassengerBookingStore.SearchTrips(null, null, null).Count.ToString();
            activeBookingMetric.Text = PassengerBookingStore.GetBookings()
                .Count(booking => booking.Status == PassengerBookingStatus.Confirmed)
                .ToString();
            availableSeatMetric.Text = PassengerBookingStore.GetTrips()
                .Sum(trip => PassengerBookingStore.GetAvailableSeatCount(trip.TripId))
                .ToString();
        }

        private void RefreshBookingList(string? selectReference = null)
        {
            if (bookingList.IsDisposed)
            {
                return;
            }

            bookingList.BeginUpdate();
            bookingList.Items.Clear();
            string search = bookingSearchInput.Text.Trim();
            foreach (var booking in PassengerBookingStore.GetBookings()
                         .OrderByDescending(item => item.CreatedAt))
            {
                var trip = PassengerBookingStore.GetTrip(booking.TripId);
                if (trip == null)
                {
                    continue;
                }

                string route = $"{trip.DepartureCity} to {trip.DestinationCity}";
                if (!string.IsNullOrWhiteSpace(search) &&
                    !booking.Reference.Contains(search, StringComparison.OrdinalIgnoreCase) &&
                    !booking.PassengerName.Contains(search, StringComparison.OrdinalIgnoreCase) &&
                    !route.Contains(search, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                var item = new ListViewItem(booking.Reference);
                item.SubItems.Add(booking.PassengerName);
                item.SubItems.Add(route);
                item.SubItems.Add(trip.DepartureAt.ToString("MMM d, yyyy"));
                item.SubItems.Add(booking.SeatNumber.ToString());
                item.SubItems.Add(booking.FareEtb.ToString("N0"));
                item.SubItems.Add(booking.Status.ToString());
                item.Tag = booking;
                bookingList.Items.Add(item);

                if (booking.Reference.Equals(selectReference, StringComparison.OrdinalIgnoreCase))
                {
                    item.Selected = true;
                    item.Focused = true;
                }
            }
            bookingList.EndUpdate();
            UpdateSelectedBooking();
        }

        private PassengerBooking? GetSelectedBooking()
        {
            return bookingList.SelectedItems.Count > 0
                ? bookingList.SelectedItems[0].Tag as PassengerBooking
                : null;
        }

        private void UpdateSelectedBooking()
        {
            var booking = GetSelectedBooking();
            if (booking == null)
            {
                bookingDetails.Text = "Select a booking to view its ticket details.";
                viewTicketButton.Enabled = false;
                cancelBookingButton.Enabled = false;
                return;
            }

            var trip = PassengerBookingStore.GetTrip(booking.TripId);
            if (trip == null)
            {
                bookingDetails.Text = "Trip details are unavailable for this booking.";
                viewTicketButton.Enabled = false;
                cancelBookingButton.Enabled = false;
                return;
            }

            bookingDetails.Text =
                $"Reference: {booking.Reference}     Status: {booking.Status}\n" +
                $"Passenger: {booking.PassengerName}     Contact: {booking.ContactNumber}\n" +
                $"Route: {trip.DepartureCity} to {trip.DestinationCity}\n" +
                $"Departure: {trip.DepartureAt:ddd, MMM d yyyy h:mm tt}     Seat: {booking.SeatNumber}     " +
                $"Fare: {booking.FareEtb:N0} ETB";
            viewTicketButton.Enabled = true;
            cancelBookingButton.Enabled = booking.Status == PassengerBookingStatus.Confirmed;
        }

        private void CancelSelectedBooking()
        {
            var booking = GetSelectedBooking();
            if (booking == null || booking.Status != PassengerBookingStatus.Confirmed)
            {
                return;
            }

            if (MessageBox.Show(
                    $"Cancel booking {booking.Reference} and release seat {booking.SeatNumber}?\n\n" +
                    "This demo does not issue refunds or process payments.",
                    "Confirm cancellation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            if (!PassengerBookingStore.TryCancelBooking(booking.Reference))
            {
                MessageBox.Show("This booking could not be cancelled. It may already be cancelled.",
                    "Cancellation not completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshBookingList(booking.Reference);
                return;
            }

            RefreshTripResults(selectedTrip?.TripId);
            RefreshBookingList(booking.Reference);
            UpdateOverviewMetrics();
            SetStatus($"Booking {booking.Reference} cancelled. Seat {booking.SeatNumber} is available again.");
        }

        private void ShowTicketPreview(PassengerBooking booking)
        {
            var trip = PassengerBookingStore.GetTrip(booking.TripId);
            if (trip == null)
            {
                MessageBox.Show("Trip details for this ticket are unavailable.", "Ticket unavailable",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var preview = new Form
            {
                Text = "Passenger Ticket Preview",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false,
                ClientSize = new Size(470, 450),
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F)
            };
            preview.Controls.Add(new Label
            {
                Text = "BUS TICKET",
                Location = new Point(24, 20),
                Size = new Size(410, 38),
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Blue,
                TextAlign = ContentAlignment.MiddleCenter
            });

            var ticketText = new TextBox
            {
                Location = new Point(24, 72),
                Size = new Size(422, 290),
                Multiline = true,
                ReadOnly = true,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(248, 250, 252),
                ForeColor = Navy,
                Font = new Font("Consolas", 10F),
                Text =
                    $"Booking reference: {booking.Reference}\r\n" +
                    $"Status:            {booking.Status}\r\n" +
                    $"Passenger:         {booking.PassengerName}\r\n" +
                    $"Contact:           {booking.ContactNumber}\r\n\r\n" +
                    $"Trip:              {trip.TripId}\r\n" +
                    $"From:              {trip.DepartureCity}\r\n" +
                    $"To:                {trip.DestinationCity}\r\n" +
                    $"Departure:         {trip.DepartureAt:ddd, MMM d yyyy h:mm tt}\r\n" +
                    $"Arrival:           {trip.ArrivalAt:h:mm tt}\r\n" +
                    $"Seat:              {booking.SeatNumber}\r\n" +
                    $"Fare:              {booking.FareEtb:N0} ETB\r\n" +
                    $"Payment:           {booking.PaymentStatus}\r\n\r\n" +
                    "Demonstration ticket only. No payment was processed."
            };
            preview.Controls.Add(ticketText);

            var closeButton = CreateActionButton("Close preview", true);
            closeButton.SetBounds(154, 386, 162, 38);
            closeButton.Click += (sender, args) => preview.Close();
            preview.Controls.Add(closeButton);
            preview.AcceptButton = closeButton;
            preview.ShowDialog(this);
        }
    }
}

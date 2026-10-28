using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class PassengerBookingStore
    {
        private static readonly List<PassengerTrip> Trips = new()
        {
            new PassengerTrip("TRP-201", "Addis Ababa", "Debre Berhan",
                DateTime.Today.AddDays(1).AddHours(7.5), DateTime.Today.AddDays(1).AddHours(10),
                380m, 40, "Yutong Express"),
            new PassengerTrip("TRP-202", "Addis Ababa", "Adama",
                DateTime.Today.AddDays(1).AddHours(8), DateTime.Today.AddDays(1).AddHours(10.5),
                320m, 45, "Scania Coach"),
            new PassengerTrip("TRP-203", "Addis Ababa", "Bishoftu",
                DateTime.Today.AddDays(1).AddHours(9.25), DateTime.Today.AddDays(1).AddHours(10.75),
                250m, 35, "City Express"),
            new PassengerTrip("TRP-204", "Addis Ababa", "Hawassa",
                DateTime.Today.AddDays(2).AddHours(6.5), DateTime.Today.AddDays(2).AddHours(11),
                750m, 49, "Volvo Touring"),
            new PassengerTrip("TRP-205", "Debre Berhan", "Addis Ababa",
                DateTime.Today.AddDays(2).AddHours(12), DateTime.Today.AddDays(2).AddHours(14.5),
                380m, 40, "Yutong Express"),
            new PassengerTrip("TRP-206", "Adama", "Addis Ababa",
                DateTime.Today.AddDays(3).AddHours(15), DateTime.Today.AddDays(3).AddHours(17.5),
                320m, 45, "Scania Coach"),
            new PassengerTrip("TRP-207", "Bishoftu", "Hawassa",
                DateTime.Today.AddDays(4).AddHours(7.25), DateTime.Today.AddDays(4).AddHours(11.75),
                680m, 42, "Golden Dragon Coach")
        };

        private static readonly List<PassengerBooking> Bookings = new();
        private static int nextBookingNumber = 1;

        public static IReadOnlyList<PassengerTrip> GetTrips()
        {
            return Trips.ToList();
        }

        public static IReadOnlyList<PassengerBooking> GetBookings()
        {
            return Bookings.ToList();
        }

        public static PassengerTrip? GetTrip(string tripId)
        {
            return Trips.FirstOrDefault(trip =>
                trip.TripId.Equals(tripId, StringComparison.OrdinalIgnoreCase));
        }

        public static IReadOnlyList<PassengerTrip> SearchTrips(
            string? departureCity,
            string? destinationCity,
            DateTime? travelDate)
        {
            return Trips
                .Where(trip =>
                    (string.IsNullOrWhiteSpace(departureCity) ||
                     trip.DepartureCity.Equals(departureCity, StringComparison.OrdinalIgnoreCase)) &&
                    (string.IsNullOrWhiteSpace(destinationCity) ||
                     trip.DestinationCity.Equals(destinationCity, StringComparison.OrdinalIgnoreCase)) &&
                    (!travelDate.HasValue || trip.DepartureAt.Date == travelDate.Value.Date) &&
                    GetAvailableSeatCount(trip.TripId) > 0)
                .OrderBy(trip => trip.DepartureAt)
                .ToList();
        }

        public static IReadOnlyList<int> GetAvailableSeats(string tripId)
        {
            var trip = GetTrip(tripId);
            if (trip == null)
            {
                return Array.Empty<int>();
            }

            var bookedSeats = Bookings
                .Where(booking =>
                    booking.TripId.Equals(tripId, StringComparison.OrdinalIgnoreCase) &&
                    booking.Status == PassengerBookingStatus.Confirmed)
                .Select(booking => booking.SeatNumber)
                .ToHashSet();

            return Enumerable.Range(1, trip.SeatCapacity)
                .Where(seatNumber => !bookedSeats.Contains(seatNumber))
                .ToList();
        }

        public static int GetAvailableSeatCount(string tripId)
        {
            return GetAvailableSeats(tripId).Count;
        }

        public static bool TryCreateBooking(
            string passengerName,
            string contactNumber,
            string tripId,
            int seatNumber,
            out PassengerBooking? booking,
            out string error)
        {
            booking = null;
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(passengerName) || string.IsNullOrWhiteSpace(contactNumber))
            {
                error = "Passenger name and contact number are required.";
                return false;
            }

            var trip = GetTrip(tripId);
            if (trip == null)
            {
                error = "The selected trip is no longer available.";
                return false;
            }

            if (seatNumber < 1 || seatNumber > trip.SeatCapacity)
            {
                error = "Select a valid seat for this trip.";
                return false;
            }

            if (!GetAvailableSeats(tripId).Contains(seatNumber))
            {
                error = $"Seat {seatNumber} has already been booked. Select another seat.";
                return false;
            }

            string reference = $"PB-{nextBookingNumber++:D6}";
            booking = new PassengerBooking(
                reference,
                passengerName.Trim(),
                contactNumber.Trim(),
                trip.TripId,
                seatNumber,
                trip.FareEtb);
            Bookings.Add(booking);
            return true;
        }

        public static bool TryCancelBooking(string reference)
        {
            var booking = Bookings.FirstOrDefault(item =>
                item.Reference.Equals(reference, StringComparison.OrdinalIgnoreCase));

            if (booking == null || booking.Status != PassengerBookingStatus.Confirmed)
            {
                return false;
            }

            booking.Cancel();
            return true;
        }
    }
}

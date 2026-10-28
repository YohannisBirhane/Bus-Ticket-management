using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class BookingStore
    {
        private static readonly List<Booking> _bookings = new List<Booking>();

        static BookingStore()
        {
            DateTime today = DateTime.Today;

            _bookings.Add(new Booking(
                "BK0001",
                "Abebe Bikila",
                "+251 911 234567",
                "abebe.bikila@gmail.com",
                "RT001",
                "Addis - Bahir Dar Express",
                "Addis Ababa",
                "Bahir Dar",
                today,
                "06:00 AM",
                "ET-3-4812 (Scania Touring)",
                new List<int> { 14, 15 },
                1150.0m,
                "Confirmed",
                "Paid",
                "Window seats requested. Passenger traveling with luggage."
            ));

            _bookings.Add(new Booking(
                "BK0002",
                "Fatuma Roba",
                "+251 922 345678",
                "fatuma.roba@yahoo.com",
                "RT002",
                "Addis - Hawassa Highway",
                "Addis Ababa",
                "Hawassa",
                today,
                "07:30 AM",
                "ET-3-9201 (Volvo B11R)",
                new List<int> { 7 },
                650.0m,
                "Confirmed",
                "Paid",
                "Business commuter; electronic payment confirmed."
            ));

            _bookings.Add(new Booking(
                "BK0003",
                "Haile Gebrselassie",
                "+251 933 456789",
                "haile.g@ethionet.et",
                "RT003",
                "Addis - Gondar Historical",
                "Addis Ababa",
                "Gondar",
                today.AddDays(1),
                "08:00 AM",
                "ET-3-1184 (Yutong ZK6122HD)",
                new List<int> { 1, 2, 3 },
                1450.0m,
                "Confirmed",
                "Paid",
                "Family reservation; front row preferred."
            ));

            _bookings.Add(new Booking(
                "BK0004",
                "Derartu Tulu",
                "+251 944 567890",
                "derartu.t@outlook.com",
                "RT004",
                "Addis - Dire Dawa Highway",
                "Addis Ababa",
                "Dire Dawa",
                today.AddDays(1),
                "09:30 AM",
                "ET-3-7723 (King Long XMQ6129)",
                new List<int> { 22 },
                950.0m,
                "Pending",
                "Pending",
                "Awaiting mobile money payment confirmation."
            ));

            _bookings.Add(new Booking(
                "BK0005",
                "Kenenisa Bekele",
                "+251 955 678901",
                "kenenisa.b@gmail.com",
                "RT006",
                "Addis - Jimma Coffee Trail",
                "Addis Ababa",
                "Jimma",
                today.AddDays(2),
                "11:15 AM",
                "ET-3-6310 (Toyota Coaster)",
                new List<int> { 10, 11 },
                750.0m,
                "Confirmed",
                "Paid",
                "Commercial trade trip."
            ));

            _bookings.Add(new Booking(
                "BK0006",
                "Tirunesh Dibaba",
                "+251 966 789012",
                "tirunesh.d@gmail.com",
                "RT001",
                "Addis - Bahir Dar Express",
                "Addis Ababa",
                "Bahir Dar",
                today.AddDays(-1),
                "06:00 AM",
                "ET-3-4812 (Scania Touring)",
                new List<int> { 5 },
                1150.0m,
                "Cancelled",
                "Refunded",
                "Cancelled due to passenger scheduling change. Refund processed."
            ));

            _bookings.Add(new Booking(
                "BK0007",
                "Meseret Defar",
                "+251 977 890123",
                "meseret.d@gmail.com",
                "RT007",
                "Addis - Dessie Highlands",
                "Addis Ababa",
                "Dessie",
                today,
                "08:30 AM",
                "ET-3-2244 (Isuzu Turquoise)",
                new List<int> { 18 },
                850.0m,
                "Confirmed",
                "Paid",
                "Direct terminal booking."
            ));

            _bookings.Add(new Booking(
                "BK0008",
                "Sileshi Sihine",
                "+251 988 901234",
                "sileshi.s@gmail.com",
                "RT005",
                "Addis - Mekelle Route",
                "Addis Ababa",
                "Mekelle",
                today.AddDays(3),
                "10:00 AM",
                "ET-3-5509 (Golden Dragon Triumph)",
                new List<int> { 30, 31 },
                1600.0m,
                "Pending",
                "Pending",
                "Reservation on hold for 24 hours."
            ));
        }

        public static List<Booking> GetAll()
        {
            return _bookings.ToList();
        }

        public static Booking? GetById(string id)
        {
            return _bookings.FirstOrDefault(b => b.BookingId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static void Add(Booking booking)
        {
            if (string.IsNullOrEmpty(booking.BookingId))
            {
                booking.BookingId = GenerateNextId();
            }
            booking.TotalAmount = booking.FarePerSeat * booking.NumberOfSeats;
            if (booking.PaymentStatus == "Paid" && booking.AmountPaid == 0)
            {
                booking.AmountPaid = booking.TotalAmount;
            }
            _bookings.Add(booking);
        }

        public static bool Update(Booking updated)
        {
            var existing = GetById(updated.BookingId);
            if (existing != null)
            {
                existing.PassengerName = updated.PassengerName;
                existing.PassengerPhone = updated.PassengerPhone;
                existing.PassengerEmail = updated.PassengerEmail;
                existing.RouteId = updated.RouteId;
                existing.RouteName = updated.RouteName;
                existing.Source = updated.Source;
                existing.Destination = updated.Destination;
                existing.TravelDate = updated.TravelDate;
                existing.DepartureTime = updated.DepartureTime;
                existing.AssignedBus = updated.AssignedBus;
                existing.Seats = updated.Seats;
                existing.FarePerSeat = updated.FarePerSeat;
                existing.TotalAmount = updated.FarePerSeat * updated.NumberOfSeats;
                existing.PaymentStatus = updated.PaymentStatus;
                existing.AmountPaid = updated.PaymentStatus == "Paid" ? existing.TotalAmount : updated.AmountPaid;
                existing.BookingStatus = updated.BookingStatus;
                existing.Notes = updated.Notes;
                return true;
            }
            return false;
        }

        public static bool CancelBooking(string id)
        {
            var booking = GetById(id);
            if (booking != null)
            {
                booking.BookingStatus = "Cancelled";
                booking.PaymentStatus = (booking.PaymentStatus == "Paid") ? "Refunded" : "Cancelled";
                return true;
            }
            return false;
        }

        public static bool Delete(string id)
        {
            var booking = GetById(id);
            if (booking != null)
            {
                _bookings.Remove(booking);
                return true;
            }
            return false;
        }

        public static HashSet<int> GetBookedSeats(string routeId, DateTime travelDate, string? excludeBookingId = null)
        {
            var bookedSeats = new HashSet<int>();
            var activeBookings = _bookings.Where(b =>
                b.RouteId.Equals(routeId, StringComparison.OrdinalIgnoreCase) &&
                b.TravelDate.Date == travelDate.Date &&
                b.BookingStatus != "Cancelled" &&
                (string.IsNullOrEmpty(excludeBookingId) || !b.BookingId.Equals(excludeBookingId, StringComparison.OrdinalIgnoreCase)));

            foreach (var b in activeBookings)
            {
                foreach (var s in b.Seats)
                {
                    bookedSeats.Add(s);
                }
            }
            return bookedSeats;
        }

        public static bool IsBookingReferenceUnique(string id, string? excludeId = null)
        {
            string cleanId = id.Trim().ToUpper();
            return !_bookings.Any(b => b.BookingId.Trim().ToUpper() == cleanId &&
                                      (string.IsNullOrEmpty(excludeId) || !b.BookingId.Equals(excludeId, StringComparison.OrdinalIgnoreCase)));
        }

        public static string GenerateNextId()
        {
            int maxId = 0;
            foreach (var b in _bookings)
            {
                if (b.BookingId.StartsWith("BK") && int.TryParse(b.BookingId.Substring(2), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            return $"BK{(maxId + 1):D4}";
        }

        public static int GetTotalCount() => _bookings.Count;
        public static int GetConfirmedCount() => _bookings.Count(b => b.BookingStatus == "Confirmed");
        public static int GetPendingCount() => _bookings.Count(b => b.BookingStatus == "Pending");
        public static int GetCancelledCount() => _bookings.Count(b => b.BookingStatus == "Cancelled");
        public static int GetTodayCount() => _bookings.Count(b => b.BookingDate.Date == DateTime.Today || b.TravelDate.Date == DateTime.Today);
    }
}

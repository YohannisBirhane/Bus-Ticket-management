using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class TicketStore
    {
        private static readonly List<Ticket> _tickets = new List<Ticket>();

        static TicketStore()
        {
            DateTime today = DateTime.Today;

            // Seed realistic tickets derived from BookingStore sample reservations
            _tickets.Add(new Ticket(
                "TK1001",
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
                "Gate 03",
                "ET-3-4812",
                "Scania Touring HD",
                14,
                1150.0m,
                "Valid",
                "VER-94812-TK1001",
                "Passenger carrying sports equipment. Priority window seat."
            ));

            _tickets.Add(new Ticket(
                "TK1002",
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
                "Gate 03",
                "ET-3-4812",
                "Scania Touring HD",
                15,
                1150.0m,
                "Valid",
                "VER-94813-TK1002",
                "Accompanied passenger ticket."
            ));

            _tickets.Add(new Ticket(
                "TK1003",
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
                "Gate 01",
                "ET-3-9201",
                "Volvo B11R Luxury",
                7,
                650.0m,
                "Boarded",
                "VER-82910-TK1003",
                "Commuter discount applied. Verified at main security gate."
            )
            {
                BoardedTime = today.AddHours(7).AddMinutes(12),
                VerifiedBy = "Gate Officer Yonas"
            });

            _tickets.Add(new Ticket(
                "TK1004",
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
                "Gate 04",
                "ET-3-1184",
                "Mercedes-Benz Travego",
                21,
                1400.0m,
                "Valid",
                "VER-31184-TK1004",
                "Executive VIP traveler booking."
            ));

            _tickets.Add(new Ticket(
                "TK1005",
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
                "Gate 04",
                "ET-3-1184",
                "Mercedes-Benz Travego",
                22,
                1400.0m,
                "Valid",
                "VER-31185-TK1005",
                "Executive VIP traveler booking."
            ));

            _tickets.Add(new Ticket(
                "TK1006",
                "BK0004",
                "Derartu Tulu",
                "+251 944 567890",
                "derartu.t@outlook.com",
                "RT004",
                "Addis - Dire Dawa Highway",
                "Addis Ababa",
                "Dire Dawa",
                today.AddDays(2),
                "09:30 AM",
                "Gate 02",
                "ET-3-7723",
                "Yutong Coach HD",
                11,
                950.0m,
                "Valid",
                "VER-77723-TK1006",
                "Middle aisle seat requested."
            ));

            _tickets.Add(new Ticket(
                "TK1007",
                "BK0005",
                "Kenenisa Bekele",
                "+251 955 678901",
                "kenenisa.b@gmail.com",
                "RT005",
                "Mekelle - Addis Direct",
                "Mekelle",
                "Addis Ababa",
                today,
                "10:00 AM",
                "Gate 05",
                "ET-3-5509",
                "Golden Dragon Navigator",
                18,
                1600.0m,
                "Boarded",
                "VER-55509-TK1007",
                "Direct express service. Passenger boarded."
            )
            {
                BoardedTime = today.AddHours(9).AddMinutes(45),
                VerifiedBy = "Gate Officer Aster"
            });

            _tickets.Add(new Ticket(
                "TK1008",
                "BK0006",
                "Tirunesh Dibaba",
                "+251 966 789012",
                "tirunesh.d@yahoo.com",
                "RT006",
                "Jimma - Addis Scenic",
                "Jimma",
                "Addis Ababa",
                today.AddDays(3),
                "11:15 AM",
                "Gate 01",
                "ET-3-6310",
                "Scania Touring HD",
                5,
                700.0m,
                "Valid",
                "VER-66310-TK1008",
                "Student passenger fare discount."
            ));

            _tickets.Add(new Ticket(
                "TK1009",
                "BK0008",
                "Almaz Ayana",
                "+251 988 901234",
                "almaz.ayana@gmail.com",
                "RT001",
                "Addis - Bahir Dar Express",
                "Addis Ababa",
                "Bahir Dar",
                today.AddDays(-1),
                "06:00 AM",
                "Gate 03",
                "ET-3-4812",
                "Scania Touring HD",
                30,
                1150.0m,
                "Cancelled",
                "VER-44812-TK1009",
                "Trip cancelled and booking refunded per customer cancellation request."
            ));
        }

        public static List<Ticket> GetAll()
        {
            return _tickets.ToList();
        }

        public static Ticket? GetById(string ticketId)
        {
            if (string.IsNullOrWhiteSpace(ticketId)) return null;
            return _tickets.FirstOrDefault(t => t.TicketId.Equals(ticketId.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public static List<Ticket> GetByBookingId(string bookingId)
        {
            if (string.IsNullOrWhiteSpace(bookingId)) return new List<Ticket>();
            return _tickets.Where(t => t.BookingId.Equals(bookingId.Trim(), StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public static bool Add(Ticket ticket)
        {
            if (ticket == null || string.IsNullOrWhiteSpace(ticket.TicketId)) return false;
            if (_tickets.Any(t => t.TicketId.Equals(ticket.TicketId.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                return false;
            }
            _tickets.Insert(0, ticket);
            return true;
        }

        public static bool Update(Ticket updated)
        {
            if (updated == null) return false;
            var existing = GetById(updated.TicketId);
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
                existing.GateNumber = updated.GateNumber;
                existing.AssignedBusPlate = updated.AssignedBusPlate;
                existing.BusModel = updated.BusModel;
                existing.SeatNumber = updated.SeatNumber;
                existing.FareAmount = updated.FareAmount;
                existing.Status = updated.Status;
                existing.BoardedTime = updated.BoardedTime;
                existing.VerifiedBy = updated.VerifiedBy;
                existing.LuggageAllowance = updated.LuggageAllowance;
                existing.Notes = updated.Notes;
                return true;
            }
            return false;
        }

        public static bool Delete(string ticketId)
        {
            var ticket = GetById(ticketId);
            if (ticket != null)
            {
                _tickets.Remove(ticket);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Validates and verifies a ticket prior to passenger boarding.
        /// Identifies by TicketId, BookingId, or SecurityVerificationCode.
        /// </summary>
        public static bool VerifyAndBoard(string identifier, string officerName, out string message, out Ticket? ticket)
        {
            ticket = null;
            if (string.IsNullOrWhiteSpace(identifier))
            {
                message = "Please provide a Ticket ID, Booking Reference, or Verification Code.";
                return false;
            }

            string clean = identifier.Trim().ToUpper();

            // Search by Ticket ID, Verification code, or Booking ID
            ticket = _tickets.FirstOrDefault(t =>
                t.TicketId.Equals(clean, StringComparison.OrdinalIgnoreCase) ||
                t.SecurityVerificationCode.Equals(clean, StringComparison.OrdinalIgnoreCase) ||
                t.BookingId.Equals(clean, StringComparison.OrdinalIgnoreCase));

            if (ticket == null)
            {
                message = $"No boarding ticket found matching reference '{identifier}'.";
                return false;
            }

            if (ticket.Status == "Cancelled")
            {
                message = $"❌ INVALID: Ticket {ticket.TicketId} was CANCELLED/REFUNDED and cannot be used for boarding.";
                return false;
            }

            if (ticket.Status == "Boarded")
            {
                string boardedInfo = ticket.BoardedTime.HasValue
                    ? $"{ticket.BoardedTime.Value:yyyy-MM-dd HH:mm}"
                    : "earlier today";
                string agent = string.IsNullOrWhiteSpace(ticket.VerifiedBy) ? "Gate Staff" : ticket.VerifiedBy;
                message = $"⚠️ ALREADY USED: Ticket {ticket.TicketId} was already verified & checked-in on {boardedInfo} by {agent}.";
                return false;
            }

            // Ticket is valid -> mark as Boarded
            ticket.Status = "Boarded";
            ticket.BoardedTime = DateTime.Now;
            ticket.VerifiedBy = string.IsNullOrWhiteSpace(officerName) ? "Admin / Gate Agent" : officerName;

            message = $"✅ BOARDING CONFIRMED: Passenger '{ticket.PassengerName}' checked-in successfully for {ticket.FullRouteDisplay} ({ticket.SeatDisplay}, Bus {ticket.AssignedBusPlate}, {ticket.GateNumber}).";
            return true;
        }

        public static bool CancelTicket(string ticketId, out string message)
        {
            var ticket = GetById(ticketId);
            if (ticket == null)
            {
                message = $"Ticket '{ticketId}' not found.";
                return false;
            }

            if (ticket.Status == "Cancelled")
            {
                message = $"Ticket '{ticketId}' is already Cancelled.";
                return false;
            }

            if (ticket.Status == "Boarded")
            {
                message = $"Ticket '{ticketId}' cannot be cancelled because the passenger has already boarded the coach.";
                return false;
            }

            ticket.Status = "Cancelled";
            message = $"Ticket '{ticket.TicketId}' has been successfully cancelled.";
            return true;
        }

        public static string GenerateNextId()
        {
            int maxId = 1000;
            foreach (var t in _tickets)
            {
                if (t.TicketId.StartsWith("TK") && int.TryParse(t.TicketId.Substring(2), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            return $"TK{(maxId + 1)}";
        }

        public static int GetTotalCount() => _tickets.Count;
        public static int GetValidCount() => _tickets.Count(t => t.Status == "Valid");
        public static int GetBoardedCount() => _tickets.Count(t => t.Status == "Boarded");
        public static int GetCancelledCount() => _tickets.Count(t => t.Status == "Cancelled");
        public static int GetTodayBoardingCount() => _tickets.Count(t => t.TravelDate.Date == DateTime.Today);
    }
}

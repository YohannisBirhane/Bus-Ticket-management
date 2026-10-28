using System;

namespace Bus_Ticket_mgmt.Models
{
    public class Ticket
    {
        public string TicketId { get; set; } = string.Empty;       // e.g. TK1001
        public string BookingId { get; set; } = string.Empty;      // e.g. BK0001
        public string PassengerName { get; set; } = string.Empty;
        public string PassengerPhone { get; set; } = string.Empty;
        public string PassengerEmail { get; set; } = string.Empty;
        
        // Trip specifications
        public string RouteId { get; set; } = string.Empty;
        public string RouteName { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime TravelDate { get; set; } = DateTime.Today;
        public string DepartureTime { get; set; } = "06:00 AM";
        public string GateNumber { get; set; } = "Gate 02";
        public string AssignedBusPlate { get; set; } = "ET-3-4812";
        public string BusModel { get; set; } = "Scania Touring HD";
        
        // Seat & Fare
        public int SeatNumber { get; set; } = 1;
        public decimal FareAmount { get; set; } = 0.0m;
        
        // Issuance and Boarding Status
        public DateTime IssuedDate { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Valid"; // Valid, Boarded, Cancelled, Expired
        public DateTime? BoardedTime { get; set; }
        public string VerifiedBy { get; set; } = string.Empty; // Officer / Gate Agent
        public string SecurityVerificationCode { get; set; } = string.Empty; // e.g. VER-88219-TK
        public string LuggageAllowance { get; set; } = "25 kg (1 Piece Cargo + 1 Handbag)";
        public string Notes { get; set; } = string.Empty;

        public string FullRouteDisplay => $"{Source} ➔ {Destination}";
        public string SeatDisplay => $"Seat {SeatNumber:D2}";

        public Ticket() { }

        public Ticket(string ticketId, string bookingId, string passengerName, string phone, string email,
                      string routeId, string routeName, string source, string destination,
                      DateTime travelDate, string departureTime, string gateNumber,
                      string busPlate, string busModel, int seatNumber, decimal fareAmount,
                      string status = "Valid", string verificationCode = "", string notes = "")
        {
            TicketId = ticketId;
            BookingId = bookingId;
            PassengerName = passengerName;
            PassengerPhone = phone;
            PassengerEmail = email;
            RouteId = routeId;
            RouteName = routeName;
            Source = source;
            Destination = destination;
            TravelDate = travelDate;
            DepartureTime = departureTime;
            GateNumber = gateNumber;
            AssignedBusPlate = busPlate;
            BusModel = busModel;
            SeatNumber = seatNumber;
            FareAmount = fareAmount;
            Status = status;
            IssuedDate = DateTime.Now;
            SecurityVerificationCode = string.IsNullOrEmpty(verificationCode)
                ? $"VER-{new Random().Next(10000, 99999)}-{ticketId}"
                : verificationCode;
            Notes = notes;
        }
    }
}

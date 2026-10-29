using System;
using System.Collections.Generic;
using System.Linq;

namespace Bus_Ticket_mgmt.Models
{
    public class Booking
    {
        public string BookingId { get; set; } = string.Empty;
        public string PassengerName { get; set; } = string.Empty;
        public string PassengerPhone { get; set; } = string.Empty;
        public string PassengerEmail { get; set; } = string.Empty;
        public string RouteId { get; set; } = string.Empty;
        public string RouteName { get; set; } = string.Empty;
        public string Source { get; set; } = string.Empty;
        public string Destination { get; set; } = string.Empty;
        public DateTime TravelDate { get; set; } = DateTime.Today;
        public string DepartureTime { get; set; } = "06:00 AM";
        public string AssignedBus { get; set; } = "Unassigned";
        public List<int> Seats { get; set; } = new List<int>();
        public decimal FarePerSeat { get; set; } = 0.0m;
        public int NumberOfSeats => Seats.Count > 0 ? Seats.Count : 1;
        public decimal TotalAmount { get; set; } = 0.0m;
        public decimal AmountPaid { get; set; } = 0.0m;
        public decimal Balance => TotalAmount - AmountPaid;
        public string BookingStatus { get; set; } = "Confirmed"; // Confirmed, Pending, Cancelled
        public string PaymentStatus { get; set; } = "Paid"; // Paid, Pending, Refunded
        public DateTime BookingDate { get; set; } = DateTime.Now;
        public string Notes { get; set; } = string.Empty;

        public string SeatNumbersDisplay => Seats.Count > 0 ? string.Join(", ", Seats.OrderBy(s => s).Select(s => $"Seat {s}")) : "Unassigned";
        public string FullRouteDisplay => $"{Source} ➔ {Destination}";

        public Booking() { }

        public Booking(string bookingId, string passengerName, string phone, string email,
                       string routeId, string routeName, string source, string destination,
                       DateTime travelDate, string departureTime, string assignedBus,
                       List<int> seats, decimal farePerSeat, string bookingStatus = "Confirmed",
                       string paymentStatus = "Paid", string notes = "")
        {
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
            AssignedBus = assignedBus;
            Seats = seats ?? new List<int>();
            FarePerSeat = farePerSeat;
            TotalAmount = FarePerSeat * NumberOfSeats;
            AmountPaid = paymentStatus == "Paid" ? TotalAmount : 0;
            BookingStatus = bookingStatus;
            PaymentStatus = paymentStatus;
            BookingDate = DateTime.Now;
            Notes = notes;
        }
    }
}

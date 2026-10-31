using System;

namespace Bus_Ticket_mgmt.Models
{
    public class TripSchedule
    {
        public string TripId { get; set; } = string.Empty;
        public string RouteId { get; set; } = string.Empty;
        public string RouteName { get; set; } = string.Empty;
        public string BusPlate { get; set; } = string.Empty;
        public string DriverName { get; set; } = string.Empty;
        public DateTime DepartureDate { get; set; } = DateTime.Today;
        public string DepartureTime { get; set; } = "06:00 AM";
        public string EstimatedArrival { get; set; } = "02:30 PM";
        public string GateNumber { get; set; } = "Gate 01";
        public int TotalSeats { get; set; } = 51;
        public int BookedSeats { get; set; } = 0;
        public decimal Fare { get; set; } = 1000.0m;
        public string Status { get; set; } = "Scheduled"; // Scheduled, Boarding, On Route, Delayed, Completed, Cancelled
        public string Notes { get; set; } = string.Empty;

        public TripSchedule() { }

        public TripSchedule(string tripId, string routeId, string routeName, string busPlate,
                            string driverName, DateTime departureDate, string departureTime,
                            string arrivalTime, string gate, int totalSeats, int bookedSeats,
                            decimal fare, string status, string notes = "")
        {
            TripId = tripId;
            RouteId = routeId;
            RouteName = routeName;
            BusPlate = busPlate;
            DriverName = driverName;
            DepartureDate = departureDate;
            DepartureTime = departureTime;
            EstimatedArrival = arrivalTime;
            GateNumber = gate;
            TotalSeats = totalSeats;
            BookedSeats = bookedSeats;
            Fare = fare;
            Status = status;
            Notes = notes;
        }

        public string OccupancyText => $"{BookedSeats} / {TotalSeats} ({((double)BookedSeats / (TotalSeats > 0 ? TotalSeats : 1) * 100):F0}%)";
    }
}

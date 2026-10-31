using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class TripScheduleStore
    {
        private static readonly List<TripSchedule> _trips = new List<TripSchedule>();

        static TripScheduleStore()
        {
            DateTime today = DateTime.Today;

            _trips.Add(new TripSchedule("TRP-101", "RT001", "Addis Ababa ➔ Bahir Dar", "3-ET-A48120", "Dawit Alemu", today, "06:00 AM", "02:30 PM", "Gate 01", 51, 49, 1150.0m, "On Route", "Northern highway express service."));
            _trips.Add(new TripSchedule("TRP-102", "RT002", "Addis Ababa ➔ Hawassa", "3-ET-B92015", "Bekele Tadesse", today, "07:30 AM", "11:30 AM", "Gate 02", 51, 51, 650.0m, "Departed", "South corridor expressway route."));
            _trips.Add(new TripSchedule("TRP-103", "RT003", "Addis Ababa ➔ Gondar", "3-ET-C11840", "Henok Girma", today, "08:00 AM", "07:00 PM", "Gate 03", 51, 42, 1450.0m, "Boarding", "Extended scenic historical tour route."));
            _trips.Add(new TripSchedule("TRP-104", "RT004", "Addis Ababa ➔ Dire Dawa", "3-ET-D77230", "Yared Solomon", today, "09:30 AM", "05:00 PM", "Gate 04", 49, 38, 950.0m, "Scheduled", "Eastern commercial highway express."));
            _trips.Add(new TripSchedule("TRP-105", "RT005", "Mekelle ➔ Addis Ababa", "3-ET-E55092", "Fitsum Berhe", today, "10:00 AM", "10:30 PM", "Gate 05", 51, 47, 1600.0m, "Scheduled", "Northern artery route."));
            _trips.Add(new TripSchedule("TRP-106", "RT006", "Jimma ➔ Addis Ababa", "3-ET-F63101", "Tariku Kebede", today, "11:15 AM", "04:45 PM", "Gate 06", 49, 33, 750.0m, "Scheduled", "Coffee belt scenic transport."));
        }

        public static List<TripSchedule> GetAll() => _trips.ToList();

        public static TripSchedule? GetById(string id) =>
            _trips.FirstOrDefault(t => t.TripId.Equals(id, StringComparison.OrdinalIgnoreCase));

        public static bool Add(TripSchedule trip, out string error)
        {
            if (trip == null)
            {
                error = "Trip data is empty.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(trip.TripId))
            {
                trip.TripId = GenerateNextId();
            }

            // Conflict prevention: check if bus is already scheduled at the same time
            var busConflict = _trips.FirstOrDefault(t => t.DepartureDate.Date == trip.DepartureDate.Date &&
                                                         t.DepartureTime.Equals(trip.DepartureTime, StringComparison.OrdinalIgnoreCase) &&
                                                         t.BusPlate.Equals(trip.BusPlate, StringComparison.OrdinalIgnoreCase) &&
                                                         t.Status != "Cancelled" && t.Status != "Completed");
            if (busConflict != null)
            {
                error = $"Bus '{trip.BusPlate}' is already assigned to trip {busConflict.TripId} at {trip.DepartureTime}.";
                return false;
            }

            // Conflict prevention: check if driver is already scheduled at the same time
            var driverConflict = _trips.FirstOrDefault(t => t.DepartureDate.Date == trip.DepartureDate.Date &&
                                                            t.DepartureTime.Equals(trip.DepartureTime, StringComparison.OrdinalIgnoreCase) &&
                                                            t.DriverName.Equals(trip.DriverName, StringComparison.OrdinalIgnoreCase) &&
                                                            t.Status != "Cancelled" && t.Status != "Completed");
            if (driverConflict != null)
            {
                error = $"Driver '{trip.DriverName}' is already assigned to trip {driverConflict.TripId} at {trip.DepartureTime}.";
                return false;
            }

            _trips.Insert(0, trip);
            error = string.Empty;
            return true;
        }

        public static bool Update(TripSchedule trip, out string error)
        {
            var existing = GetById(trip.TripId);
            if (existing == null)
            {
                error = "Trip not found.";
                return false;
            }

            existing.RouteName = trip.RouteName;
            existing.BusPlate = trip.BusPlate;
            existing.DriverName = trip.DriverName;
            existing.DepartureDate = trip.DepartureDate;
            existing.DepartureTime = trip.DepartureTime;
            existing.EstimatedArrival = trip.EstimatedArrival;
            existing.GateNumber = trip.GateNumber;
            existing.TotalSeats = trip.TotalSeats;
            existing.BookedSeats = trip.BookedSeats;
            existing.Fare = trip.Fare;
            existing.Status = trip.Status;
            existing.Notes = trip.Notes;

            error = string.Empty;
            return true;
        }

        public static bool UpdateStatus(string tripId, string newStatus)
        {
            var trip = GetById(tripId);
            if (trip != null)
            {
                trip.Status = newStatus;
                return true;
            }
            return false;
        }

        public static bool Delete(string tripId)
        {
            var trip = GetById(tripId);
            if (trip != null)
            {
                _trips.Remove(trip);
                return true;
            }
            return false;
        }

        public static string GenerateNextId()
        {
            int max = 100;
            foreach (var t in _trips)
            {
                if (t.TripId.StartsWith("TRP-") && int.TryParse(t.TripId.Substring(4), out int n))
                {
                    if (n > max) max = n;
                }
            }
            return $"TRP-{(max + 1)}";
        }

        public static (int Total, int Scheduled, int Departed, int Delayed, int Completed) GetMetrics()
        {
            return (
                _trips.Count,
                _trips.Count(t => t.Status == "Scheduled" || t.Status == "Boarding"),
                _trips.Count(t => t.Status == "Departed" || t.Status == "On Route"),
                _trips.Count(t => t.Status == "Delayed"),
                _trips.Count(t => t.Status == "Completed")
            );
        }
    }
}

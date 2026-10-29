using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class DriverDemoStore
    {
        public const string DriverId = "DRV-004";
        public const string DriverName = "Bekele Tadesse";
        public const string BusName = "Yutong ZK6122H";
        public const string PlateNumber = "3-ET-A48120";

        private static readonly List<DriverTrip> Trips = new()
        {
            new DriverTrip(
                "TRP-301", DriverId, "Addis Ababa", "Debre Berhan",
                DateTime.Today.AddDays(1).AddHours(7.5),
                DateTime.Today.AddDays(1).AddHours(10),
                BusName, PlateNumber, "Scheduled",
                "Arrive at the station 30 minutes before departure.",
                new List<DriverPassengerRecord>
                {
                    new("Mekdes Abebe", "BK-3101", 3, "Confirmed"),
                    new("Yonas Girma", "BK-3102", 7, "Confirmed"),
                    new("Rahel Tesfaye", "BK-3103", 12, "Confirmed", true)
                }),
            new DriverTrip(
                "TRP-302", DriverId, "Addis Ababa", "Adama",
                DateTime.Today.AddHours(-2),
                DateTime.Today.AddHours(0.5),
                BusName, PlateNumber, "Departed",
                "Use the south highway route. Passenger manifest verified.",
                new List<DriverPassengerRecord>
                {
                    new("Samuel Bekele", "BK-3201", 2, "Confirmed", true),
                    new("Hana Worku", "BK-3202", 9, "Confirmed", true)
                }),
            new DriverTrip(
                "TRP-303", DriverId, "Debre Berhan", "Addis Ababa",
                DateTime.Today.AddDays(-2).AddHours(12),
                DateTime.Today.AddDays(-2).AddHours(14.5),
                BusName, PlateNumber, "Completed",
                "Trip completed. Vehicle inspection recorded at arrival.",
                new List<DriverPassengerRecord>
                {
                    new("Kalkidan Ali", "BK-3301", 5, "Confirmed", true),
                    new("Dawit Fikru", "BK-3302", 11, "Confirmed", true)
                }),
            new DriverTrip(
                "TRP-304", DriverId, "Addis Ababa", "Hawassa",
                DateTime.Today.AddDays(2).AddHours(6.5),
                DateTime.Today.AddDays(2).AddHours(11),
                BusName, PlateNumber, "Delayed",
                "Departure delayed due to a scheduled road inspection.",
                new List<DriverPassengerRecord>()),
            new DriverTrip(
                "TRP-399", "DRV-006", "Addis Ababa", "Dire Dawa",
                DateTime.Today.AddDays(1).AddHours(9),
                DateTime.Today.AddDays(1).AddHours(16),
                "Scania Touring HD", "3-ET-B92015", "Scheduled",
                "This trip is assigned to another driver.",
                new List<DriverPassengerRecord>())
        };

        public static IReadOnlyList<DriverTrip> GetTripsForDriver(string driverId)
        {
            return Trips
                .Where(trip => trip.DriverId.Equals(driverId, StringComparison.OrdinalIgnoreCase))
                .OrderBy(trip => trip.DepartureAt)
                .ToList();
        }
    }
}

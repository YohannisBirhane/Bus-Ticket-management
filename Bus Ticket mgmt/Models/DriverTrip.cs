namespace Bus_Ticket_mgmt.Models
{
    public sealed class DriverTrip
    {
        public string TripId { get; }
        public string DriverId { get; }
        public string DepartureCity { get; }
        public string DestinationCity { get; }
        public DateTime DepartureAt { get; }
        public DateTime ArrivalAt { get; }
        public string BusName { get; }
        public string PlateNumber { get; }
        public string Status { get; private set; }
        public string Notes { get; }
        public List<DriverPassengerRecord> Passengers { get; }

        public DriverTrip(
            string tripId,
            string driverId,
            string departureCity,
            string destinationCity,
            DateTime departureAt,
            DateTime arrivalAt,
            string busName,
            string plateNumber,
            string status,
            string notes,
            List<DriverPassengerRecord> passengers)
        {
            TripId = tripId;
            DriverId = driverId;
            DepartureCity = departureCity;
            DestinationCity = destinationCity;
            DepartureAt = departureAt;
            ArrivalAt = arrivalAt;
            BusName = busName;
            PlateNumber = plateNumber;
            Status = status;
            Notes = notes;
            Passengers = passengers;
        }

        public void UpdateStatus(string status)
        {
            Status = status;
        }
    }
}

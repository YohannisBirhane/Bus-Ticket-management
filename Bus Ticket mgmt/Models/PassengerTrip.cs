namespace Bus_Ticket_mgmt.Models
{
    public sealed class PassengerTrip
    {
        public string TripId { get; }
        public string DepartureCity { get; }
        public string DestinationCity { get; }
        public DateTime DepartureAt { get; }
        public DateTime ArrivalAt { get; }
        public decimal FareEtb { get; }
        public int SeatCapacity { get; }
        public string BusName { get; }

        public PassengerTrip(
            string tripId,
            string departureCity,
            string destinationCity,
            DateTime departureAt,
            DateTime arrivalAt,
            decimal fareEtb,
            int seatCapacity,
            string busName)
        {
            TripId = tripId;
            DepartureCity = departureCity;
            DestinationCity = destinationCity;
            DepartureAt = departureAt;
            ArrivalAt = arrivalAt;
            FareEtb = fareEtb;
            SeatCapacity = seatCapacity;
            BusName = busName;
        }
    }
}

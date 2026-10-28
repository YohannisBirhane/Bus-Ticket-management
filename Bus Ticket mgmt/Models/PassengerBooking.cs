namespace Bus_Ticket_mgmt.Models
{
    public enum PassengerBookingStatus
    {
        Confirmed,
        Cancelled
    }

    public sealed class PassengerBooking
    {
        public string Reference { get; }
        public string PassengerName { get; }
        public string ContactNumber { get; }
        public string TripId { get; }
        public int SeatNumber { get; }
        public decimal FareEtb { get; }
        public DateTime CreatedAt { get; }
        public PassengerBookingStatus Status { get; private set; }
        public string PaymentStatus => "Pay at station (simulation)";

        public PassengerBooking(
            string reference,
            string passengerName,
            string contactNumber,
            string tripId,
            int seatNumber,
            decimal fareEtb)
        {
            Reference = reference;
            PassengerName = passengerName;
            ContactNumber = contactNumber;
            TripId = tripId;
            SeatNumber = seatNumber;
            FareEtb = fareEtb;
            CreatedAt = DateTime.Now;
            Status = PassengerBookingStatus.Confirmed;
        }

        public void Cancel()
        {
            Status = PassengerBookingStatus.Cancelled;
        }
    }
}

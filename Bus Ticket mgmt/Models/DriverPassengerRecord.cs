namespace Bus_Ticket_mgmt.Models
{
    public sealed class DriverPassengerRecord
    {
        public string Name { get; }
        public string BookingReference { get; }
        public int SeatNumber { get; }
        public string TicketStatus { get; }
        public bool IsBoarded { get; private set; }

        public DriverPassengerRecord(
            string name,
            string bookingReference,
            int seatNumber,
            string ticketStatus,
            bool isBoarded = false)
        {
            Name = name;
            BookingReference = bookingReference;
            SeatNumber = seatNumber;
            TicketStatus = ticketStatus;
            IsBoarded = isBoarded;
        }

        public void MarkBoarded()
        {
            IsBoarded = true;
        }
    }
}

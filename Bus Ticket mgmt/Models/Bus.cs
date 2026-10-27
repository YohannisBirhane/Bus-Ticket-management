using System;

namespace Bus_Ticket_mgmt.Models
{
    public class Bus
    {
        public string BusId { get; set; } = string.Empty;
        public string PlateNumber { get; set; } = string.Empty;
        public string Manufacturer { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public string BusType { get; set; } = "Luxury";
        public int Capacity { get; set; } = 51;
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public string RegistrationInfo { get; set; } = string.Empty;
        public string Status { get; set; } = "Active";
        public string AssignedTrip { get; set; } = "None / Available";
        public string Notes { get; set; } = string.Empty;

        public string FullModelName => $"{Manufacturer} {Model}".Trim();

        public Bus() { }

        public Bus(string busId, string plateNumber, string manufacturer, string model, string busType, int capacity, DateTime regDate, string regInfo, string status, string assignedTrip = "None / Available", string notes = "")
        {
            BusId = busId;
            PlateNumber = plateNumber;
            Manufacturer = manufacturer;
            Model = model;
            BusType = busType;
            Capacity = capacity;
            RegistrationDate = regDate;
            RegistrationInfo = regInfo;
            Status = status;
            AssignedTrip = assignedTrip;
            Notes = notes;
        }
    }
}

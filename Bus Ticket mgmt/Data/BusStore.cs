using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Data
{
    public static class BusStore
    {
        private static readonly List<Bus> _buses = new List<Bus>();

        static BusStore()
        {
            // Seed initial fleet records
            _buses.Add(new Bus("BUS001", "3-ET-A48120", "Yutong", "ZK6122H", "Luxury", 51, DateTime.Now.AddMonths(-18), "REG-ET-2023-0891", "Active", "TRP-101 (Addis ➔ Bahir Dar)", "Flagship express coach equipped with AC and WiFi."));
            _buses.Add(new Bus("BUS002", "3-ET-B92015", "Scania", "Touring HD", "Luxury", 51, DateTime.Now.AddMonths(-14), "REG-ET-2023-1104", "Active", "TRP-102 (Addis ➔ Hawassa)", "Regular south corridor express."));
            _buses.Add(new Bus("BUS003", "3-ET-C11840", "Volvo", "9700 Grand", "Luxury", 51, DateTime.Now.AddMonths(-12), "REG-ET-2024-0045", "Active", "TRP-103 (Addis ➔ Gondar)", "High-altitude route tested."));
            _buses.Add(new Bus("BUS004", "3-ET-D77230", "Higer", "KLQ6129", "Standard", 49, DateTime.Now.AddMonths(-10), "REG-ET-2024-0231", "Active", "TRP-104 (Addis ➔ Dire Dawa)", "Eastern highway service."));
            _buses.Add(new Bus("BUS005", "3-ET-E55092", "Golden Dragon", "XML6127", "Standard", 49, DateTime.Now.AddMonths(-8), "REG-ET-2024-0518", "Maintenance", "None / In Garage", "Scheduled 50,000 km brake inspection and oil servicing."));
            _buses.Add(new Bus("BUS006", "3-ET-F63101", "Yutong", "ZK6118", "Semi-Luxury", 45, DateTime.Now.AddMonths(-6), "REG-ET-2024-0779", "Active", "None / Available", "Standby reserve bus at Autobus Tera station."));
            _buses.Add(new Bus("BUS007", "3-ET-G88414", "Scania", "Interlink", "Luxury", 51, DateTime.Now.AddMonths(-4), "REG-ET-2024-0992", "Inactive", "None / Decommissioned", "Pending transmission overhaul; temporarily out of service."));
            _buses.Add(new Bus("BUS008", "3-ET-H33290", "Toyota", "Coaster", "Mini-Bus", 30, DateTime.Now.AddMonths(-2), "REG-ET-2024-1180", "Active", "None / Available", "Short distance feeder shuttle."));
        }

        public static List<Bus> GetAll()
        {
            return _buses.ToList();
        }

        public static Bus? GetById(string id)
        {
            return _buses.FirstOrDefault(b => b.BusId.Equals(id, StringComparison.OrdinalIgnoreCase));
        }

        public static void Add(Bus bus)
        {
            if (string.IsNullOrEmpty(bus.BusId))
            {
                bus.BusId = GenerateNextId();
            }
            _buses.Add(bus);
        }

        public static bool Update(Bus updatedBus)
        {
            var existing = GetById(updatedBus.BusId);
            if (existing != null)
            {
                existing.PlateNumber = updatedBus.PlateNumber;
                existing.Manufacturer = updatedBus.Manufacturer;
                existing.Model = updatedBus.Model;
                existing.BusType = updatedBus.BusType;
                existing.Capacity = updatedBus.Capacity;
                existing.RegistrationDate = updatedBus.RegistrationDate;
                existing.RegistrationInfo = updatedBus.RegistrationInfo;
                existing.Status = updatedBus.Status;
                existing.AssignedTrip = updatedBus.AssignedTrip;
                existing.Notes = updatedBus.Notes;
                return true;
            }
            return false;
        }

        public static bool Delete(string id)
        {
            var bus = GetById(id);
            if (bus != null)
            {
                _buses.Remove(bus);
                return true;
            }
            return false;
        }

        public static bool SetStatus(string id, string newStatus)
        {
            var bus = GetById(id);
            if (bus != null)
            {
                bus.Status = newStatus;
                if (newStatus == "Maintenance" || newStatus == "Inactive")
                {
                    bus.AssignedTrip = "None / Unavailable";
                }
                return true;
            }
            return false;
        }

        public static bool IsPlateUnique(string plate, string? excludeBusId = null)
        {
            string cleanPlate = plate.Trim().ToUpper();
            return !_buses.Any(b => b.PlateNumber.Trim().ToUpper() == cleanPlate &&
                                    (string.IsNullOrEmpty(excludeBusId) || !b.BusId.Equals(excludeBusId, StringComparison.OrdinalIgnoreCase)));
        }

        public static string GenerateNextId()
        {
            int maxId = 0;
            foreach (var b in _buses)
            {
                if (b.BusId.StartsWith("BUS") && int.TryParse(b.BusId.Substring(3), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            return $"BUS{(maxId + 1):D3}";
        }

        public static int GetTotalCount() => _buses.Count;
        public static int GetActiveCount() => _buses.Count(b => b.Status == "Active");
        public static int GetMaintenanceCount() => _buses.Count(b => b.Status == "Maintenance");
        public static int GetInactiveCount() => _buses.Count(b => b.Status == "Inactive");
    }
}

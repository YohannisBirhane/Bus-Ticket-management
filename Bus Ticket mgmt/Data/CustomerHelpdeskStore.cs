using System;
using System.Collections.Generic;
using System.Linq;

namespace Bus_Ticket_mgmt.Data
{
    public class CustomerInquiry
    {
        public string InquiryId { get; set; } = string.Empty;
        public string PassengerName { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        public string Category { get; set; } = "Schedule Inquiry"; // Ticket Change, Lost Property, Schedule Inquiry, Complaint, Special Assistance
        public string Subject { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public string Status { get; set; } = "Pending"; // Pending, Resolved, In Progress
        public DateTime RecordedDate { get; set; } = DateTime.Now;
        public string AttendedBy { get; set; } = "Marta Tadesse";
        public string ResolutionNotes { get; set; } = string.Empty;

        public CustomerInquiry() { }

        public CustomerInquiry(string id, string passenger, string phone, string category,
                               string subject, string details, string status,
                               DateTime date, string officer, string resolution = "")
        {
            InquiryId = id;
            PassengerName = passenger;
            ContactPhone = phone;
            Category = category;
            Subject = subject;
            Details = details;
            Status = status;
            RecordedDate = date;
            AttendedBy = officer;
            ResolutionNotes = resolution;
        }
    }

    public static class CustomerHelpdeskStore
    {
        private static readonly List<CustomerInquiry> _inquiries = new List<CustomerInquiry>();

        static CustomerHelpdeskStore()
        {
            DateTime today = DateTime.Today;

            _inquiries.Add(new CustomerInquiry("INQ-101", "Solomon Desta", "+251 911 554433", "Lost Property", "Misplaced handbag at Gate 02", "Passenger reported leaving a black leather bag near Gate 02 waiting area.", "Resolved", today.AddHours(6), "Marta Tadesse", "Bag located at terminal security desk and handed over to passenger."));
            _inquiries.Add(new CustomerInquiry("INQ-102", "Aster Aweke", "+251 922 667788", "Special Assistance", "Wheelchair priority boarding request", "Elderly passenger traveling to Hawassa requires boarding ramp assistance.", "Resolved", today.AddHours(7), "Marta Tadesse", "Boarding crew notified; priority front-row seating confirmed."));
            _inquiries.Add(new CustomerInquiry("INQ-103", "Kassahun Tilahun", "+251 933 778899", "Ticket Change", "Reschedule departure to afternoon coach", "Passenger wishes to move travel time from 08:00 AM to 01:30 PM due to urgent business.", "Pending", today.AddHours(7).AddMinutes(30), "Marta Tadesse", "Awaiting confirmation of seat availability on 01:30 PM coach."));
            _inquiries.Add(new CustomerInquiry("INQ-104", "Tigist Assefa", "+251 944 889900", "Schedule Inquiry", "Estimated travel time to Jimma", "Customer inquired about road conditions and estimated arrival time in Jimma.", "Resolved", today.AddHours(8), "Marta Tadesse", "Informed customer that journey takes approximately 5 hrs 30 mins via expressway."));
            _inquiries.Add(new CustomerInquiry("INQ-105", "Girma Wolde", "+251 955 990011", "Complaint", "Departure gate confusion on ticket", "Passenger reported gate printout discrepancy on previous trip ticket.", "Pending", today.AddHours(8).AddMinutes(15), "Marta Tadesse", "Reported to IT terminal admin for template synchronization."));
        }

        public static List<CustomerInquiry> GetAll() => _inquiries.ToList();

        public static void Add(CustomerInquiry inquiry)
        {
            if (inquiry != null)
            {
                if (string.IsNullOrWhiteSpace(inquiry.InquiryId))
                {
                    inquiry.InquiryId = GenerateNextId();
                }
                _inquiries.Insert(0, inquiry);
            }
        }

        public static bool MarkResolved(string inquiryId, string resolution)
        {
            var item = _inquiries.FirstOrDefault(i => i.InquiryId.Equals(inquiryId, StringComparison.OrdinalIgnoreCase));
            if (item != null)
            {
                item.Status = "Resolved";
                item.ResolutionNotes = resolution;
                return true;
            }
            return false;
        }

        public static string GenerateNextId()
        {
            int max = 100;
            foreach (var i in _inquiries)
            {
                if (i.InquiryId.StartsWith("INQ-") && int.TryParse(i.InquiryId.Substring(4), out int n))
                {
                    if (n > max) max = n;
                }
            }
            return $"INQ-{(max + 1)}";
        }

        public static int GetTotalCount() => _inquiries.Count;
        public static int GetPendingCount() => _inquiries.Count(i => i.Status == "Pending");
        public static int GetResolvedCount() => _inquiries.Count(i => i.Status == "Resolved");
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace Bus_Ticket_mgmt.Data
{
    public class PaymentRecord
    {
        public string ReceiptNumber { get; set; } = string.Empty;
        public string BookingId { get; set; } = string.Empty;
        public string TicketId { get; set; } = string.Empty;
        public string PassengerName { get; set; } = string.Empty;
        public string RouteName { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0.0m;
        public string PaymentMethod { get; set; } = "Cash"; // Cash, Telebirr, CBE Birr, Card
        public string PaymentStatus { get; set; } = "Paid"; // Paid, Pending, Refunded
        public DateTime TransactionDate { get; set; } = DateTime.Now;
        public string CashierName { get; set; } = "Marta Tadesse (Desk 01)";
        public string Notes { get; set; } = string.Empty;

        public PaymentRecord() { }

        public PaymentRecord(string receiptNo, string bookingId, string ticketId, string passenger,
                             string route, decimal amount, string method, string status,
                             DateTime date, string cashier, string notes = "")
        {
            ReceiptNumber = receiptNo;
            BookingId = bookingId;
            TicketId = ticketId;
            PassengerName = passenger;
            RouteName = route;
            Amount = amount;
            PaymentMethod = method;
            PaymentStatus = status;
            TransactionDate = date;
            CashierName = cashier;
            Notes = notes;
        }
    }

    public static class PaymentStore
    {
        private static readonly List<PaymentRecord> _payments = new List<PaymentRecord>();

        static PaymentStore()
        {
            DateTime today = DateTime.Today;

            _payments.Add(new PaymentRecord("REC-8801", "BK0001", "TK1001", "Abebe Bikila", "Addis - Bahir Dar Express", 2300.0m, "Cash", "Paid", today.AddHours(5).AddMinutes(30), "Marta Tadesse (Desk 01)", "Counter cash payment received in full."));
            _payments.Add(new PaymentRecord("REC-8802", "BK0002", "TK1003", "Fatuma Roba", "Addis - Hawassa Highway", 650.0m, "Telebirr", "Paid", today.AddHours(6).AddMinutes(15), "Marta Tadesse (Desk 01)", "Telebirr transaction ID: TB-9481023"));
            _payments.Add(new PaymentRecord("REC-8803", "BK0003", "TK1004", "Haile Gebrselassie", "Addis - Gondar Historical", 4350.0m, "CBE Birr", "Paid", today.AddHours(6).AddMinutes(45), "Marta Tadesse (Desk 01)", "CBE Birr reference: CBE-119481"));
            _payments.Add(new PaymentRecord("REC-8804", "BK0004", "TK1005", "Derartu Tulu", "Addis - Dire Dawa Highway", 950.0m, "Cash", "Pending", today.AddHours(7).AddMinutes(10), "Marta Tadesse (Desk 01)", "Awaiting counter cash clearance"));
            _payments.Add(new PaymentRecord("REC-8805", "BK0005", "TK1006", "Kenenisa Bekele", "Addis - Jimma Coffee Trail", 1500.0m, "Telebirr", "Paid", today.AddHours(7).AddMinutes(40), "Marta Tadesse (Desk 01)", "Telebirr confirmed"));
            _payments.Add(new PaymentRecord("REC-8806", "BK0006", "TK1007", "Meseret Defar", "Addis - Dessie Highlands", 850.0m, "Card", "Paid", today.AddHours(8).AddMinutes(05), "Marta Tadesse (Desk 01)", "POS Terminal debit card authorization #4481"));
            _payments.Add(new PaymentRecord("REC-8807", "BK0008", "TK1009", "Almaz Ayana", "Addis - Bahir Dar Express", 1150.0m, "Cash", "Refunded", today.AddHours(8).AddMinutes(30), "Marta Tadesse (Desk 01)", "Customer cancellation authorized. Cash refunded per policy."));
        }

        public static List<PaymentRecord> GetAll() => _payments.ToList();

        public static void Add(PaymentRecord payment)
        {
            if (payment != null)
            {
                if (string.IsNullOrWhiteSpace(payment.ReceiptNumber))
                {
                    payment.ReceiptNumber = GenerateNextReceiptNo();
                }
                _payments.Insert(0, payment);
            }
        }

        public static string GenerateNextReceiptNo()
        {
            int max = 8800;
            foreach (var p in _payments)
            {
                if (p.ReceiptNumber.StartsWith("REC-") && int.TryParse(p.ReceiptNumber.Substring(4), out int n))
                {
                    if (n > max) max = n;
                }
            }
            return $"REC-{(max + 1)}";
        }

        public static decimal GetTotalCollectionsToday() =>
            _payments.Where(p => p.TransactionDate.Date == DateTime.Today && p.PaymentStatus == "Paid").Sum(p => p.Amount);

        public static decimal GetCashTotalToday() =>
            _payments.Where(p => p.TransactionDate.Date == DateTime.Today && p.PaymentStatus == "Paid" && p.PaymentMethod == "Cash").Sum(p => p.Amount);

        public static decimal GetDigitalTotalToday() =>
            _payments.Where(p => p.TransactionDate.Date == DateTime.Today && p.PaymentStatus == "Paid" && (p.PaymentMethod == "Telebirr" || p.PaymentMethod == "CBE Birr" || p.PaymentMethod == "Card")).Sum(p => p.Amount);

        public static decimal GetRefundsTotalToday() =>
            _payments.Where(p => p.TransactionDate.Date == DateTime.Today && p.PaymentStatus == "Refunded").Sum(p => p.Amount);
    }
}


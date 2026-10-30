using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Services
{
    /// <summary>
    /// Service responsible for ticket lifecycle operations:
    /// issuance, verification, boarding clearance, cancellation, and metrics.
    /// </summary>
    public static class TicketService
    {
        public static List<Ticket> GetAllTickets() => TicketStore.GetAll();

        public static Ticket? GetTicketById(string ticketId) => TicketStore.GetById(ticketId);

        public static List<Ticket> GetTicketsByBooking(string bookingId) => TicketStore.GetByBookingId(bookingId);

        public static bool IssueTicket(Ticket ticket, out string generatedId)
        {
            if (ticket == null)
            {
                generatedId = string.Empty;
                return false;
            }

            if (string.IsNullOrWhiteSpace(ticket.TicketId))
            {
                ticket.TicketId = TicketStore.GenerateNextId();
            }

            if (string.IsNullOrWhiteSpace(ticket.SecurityVerificationCode))
            {
                ticket.SecurityVerificationCode = $"VER-{new Random().Next(10000, 99999)}-{ticket.TicketId}";
            }

            generatedId = ticket.TicketId;
            return TicketStore.Add(ticket);
        }

        public static bool VerifyAndClearBoarding(string identifier, string officerName, out string statusMessage, out Ticket? clearedTicket)
        {
            return TicketStore.VerifyAndBoard(identifier, officerName, out statusMessage, out clearedTicket);
        }

        public static bool CancelTicket(string ticketId, out string message)
        {
            return TicketStore.CancelTicket(ticketId, out message);
        }

        public static (int Total, int Valid, int Boarded, int Cancelled, int Today) GetTicketMetrics()
        {
            return (
                TicketStore.GetTotalCount(),
                TicketStore.GetValidCount(),
                TicketStore.GetBoardedCount(),
                TicketStore.GetCancelledCount(),
                TicketStore.GetTodayBoardingCount()
            );
        }
    }
}


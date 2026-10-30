using System;
using System.Collections.Generic;
using System.Linq;
using Bus_Ticket_mgmt.Data;
using Bus_Ticket_mgmt.Models;

namespace Bus_Ticket_mgmt.Services
{
    /// <summary>
    /// Service responsible for passenger reservations, seat allocation, and cancellations.
    /// </summary>
    public static class BookingService
    {
        public static List<Booking> GetAllBookings() => BookingStore.GetAll();

        public static Booking? GetBookingById(string bookingId) => BookingStore.GetById(bookingId);

        public static bool CreateBooking(Booking booking, out string bookingId)
        {
            if (booking == null)
            {
                bookingId = string.Empty;
                return false;
            }

            if (string.IsNullOrWhiteSpace(booking.BookingId))
            {
                booking.BookingId = BookingStore.GenerateNextId();
            }

            booking.BookingDate = DateTime.Now;
            BookingStore.Add(booking);
            bookingId = booking.BookingId;
            return true;
        }

        public static bool CancelBooking(string bookingId)
        {
            return BookingStore.CancelBooking(bookingId);
        }

        public static (int Total, int Confirmed, int Pending, int Cancelled, int Today) GetBookingMetrics()
        {
            return (
                BookingStore.GetTotalCount(),
                BookingStore.GetConfirmedCount(),
                BookingStore.GetPendingCount(),
                BookingStore.GetCancelledCount(),
                BookingStore.GetTodayCount()
            );
        }
    }
}


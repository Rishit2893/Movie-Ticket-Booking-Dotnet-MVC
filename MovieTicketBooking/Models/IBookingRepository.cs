using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public interface IBookingRepository
    {
        IEnumerable<Booking> GetAllBookings();
        Booking AddBooking(Booking newBooking);

    }
}

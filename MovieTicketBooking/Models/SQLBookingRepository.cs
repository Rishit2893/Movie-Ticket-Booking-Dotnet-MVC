using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class SQLBookingRepository : IBookingRepository
    {
        private readonly AppDbContext _context;

        public SQLBookingRepository(AppDbContext context)
        {
            _context = context;
        }

        public Booking AddBooking(Booking newBooking)
        {
            _context.Bookings.Add(newBooking);
            _context.SaveChanges();
            return newBooking;
        }

        public IEnumerable<Booking> GetAllBookings()
        {
            return _context.Bookings.Include(b => b.Show).Include(b => b.IdentityUser);
        }

    }
}

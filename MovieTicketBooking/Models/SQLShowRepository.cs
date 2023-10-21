using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class SQLShowRepository : IShowRepository
    {
        private readonly AppDbContext _context;

        public SQLShowRepository(AppDbContext context)
        {
            _context = context;
        }

        public Show AddShow(Show newShow)
        {
            _context.Shows.Add(newShow);
            _context.SaveChanges();
            return newShow;
        }

        public Show DeleteShow(int id)
        {
            var show = _context.Shows.Find(id);
            _context.Shows.Remove(show);
            _context.SaveChanges();
            return show;
        }
        public void DeleteExpiredShow()
        {
            var allShows = GetAllShows();
            foreach (var show in allShows)
            {
                if (DateTime.Compare(DateTime.Parse(show.EndDate), DateTime.Parse(DateTime.Now.ToString("dd-MM-yyyy"))) < 0)
                {
                    _context.Shows.Remove(show);
                }
            }
            _context.SaveChanges();
        }

        public IEnumerable<Show> GetAllShows()
        {
            return _context.Shows.Include(s => s.Movie);
        }

        public Show GetShow(int id)
        {
            return _context.Shows.Include(s => s.Movie).FirstOrDefault(s => s.Id == id);
        }
    }
}

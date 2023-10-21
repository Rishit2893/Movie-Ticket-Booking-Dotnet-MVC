using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public interface IShowRepository
    {
        IEnumerable<Show> GetAllShows();

        Show GetShow(int id);

        Show AddShow(Show newShow);

        Show DeleteShow(int id);

        void DeleteExpiredShow();
    }
}

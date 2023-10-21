using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class Show
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }

        public string Time { get; set; }

        public string Language { get; set; }

        public double Price { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.ViewModels
{
    public class MovieEditViewModel : MovieCreateViewModel
    {
        public int Id { get; set; }

        public string ExistingPosterPath { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.ViewModels
{
    public class SelectShowViewModel : BookingIndexViewModel
    {
        public List<SelectListItem> Times { get; set; }

        [Required(ErrorMessage = "Select a time")]
        public int? ShowId { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking.Models
{
    public class Booking
    {
        public int Id { get; set; }
        
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        
        public IdentityUser IdentityUser { get; set; }
        
        public int ShowId { get; set; }
        
        public Show Show { get; set; }
        
        public string ShowDate { get; set; }
        
        public int SeatNo { get; set; }

    }
}

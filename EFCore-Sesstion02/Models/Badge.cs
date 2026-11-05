using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sesstion02.Models
{
    internal class Badge
    {
        public int Id { get; set; }
        public string BadgeNumber { get; set; }
        public DateTime IssuedDate { get; set; }
        public string Tier { get; set; }

        [InverseProperty(nameof(Attendee.Badge))]
        public Attendee? Attendee { get; set; }

        [ForeignKey(nameof(Attendee))]
        public int AttendeeId { get; set; }
    }
}

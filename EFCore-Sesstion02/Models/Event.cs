using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sesstion02.Models
{
    internal class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MaxAttendees { get; set; }

        [InverseProperty(nameof(Organizer.events))]
        public Organizer? OrganizerEV { get; set; }

        [ForeignKey(nameof(OrganizerEV))]
        public int OrganizerEVId { get; set; }


    }
}

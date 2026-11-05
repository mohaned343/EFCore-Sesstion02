using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sesstion02.Models
{
    internal class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public bool IsVerified { get; set; }

        [InverseProperty(nameof(OrganizerProfile.Organizer))]
        public OrganizerProfile Profile { get; set; }

        [InverseProperty(nameof(Event.OrganizerEV))]
        public ICollection<Event> events { get; set; }= new HashSet<Event>();
    }
}

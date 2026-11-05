using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sesstion02.Models
{
    internal class OrganizerProfile
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public string Website { get; set; }
        public string Logo { get; set; }
        [InverseProperty(nameof(Organizer.Profile))]
        public Organizer Organizer { get; set; }
        [ForeignKey(nameof(Organizer))]
        public int OrganizerId { get; set; }
    }
}

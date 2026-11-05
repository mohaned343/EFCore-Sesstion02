using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_Sesstion02.Models
{
    internal class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string ZipCobe { get; set; }
        public string FullAdress => $"{Street} ,{City} ,{Country} ,{ZipCobe}";

        [InverseProperty(nameof(Badge.Attendee))]
        public Badge Badge { get; set; }

    }
}

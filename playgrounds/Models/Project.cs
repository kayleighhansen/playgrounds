
using System.Collections.Generic;

namespace Playgrounds.Models
{
    public class Project {
        public int ProjectId { get; set; }
        public Date DateAdded { get; set; }
        public Date StartDate { get; set; }
        public bool Ongoing { get; set; }
        public string Plan { get; set; }
        public Construction Construction { get; set; }
        public Trip TripId { get; set; }

        public virtual ICollection<List> Contacts { get; set; }
        public virtual ICollection<List> Organizations { get; set; }



    }
}
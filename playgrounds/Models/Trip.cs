using System.Collections.Generic;

namespace Playgrounds.Models
{
    public class Trip {

        public int TripId { get; set; }
        public Date DateAdded { get; set; }
        public Date Departure { get; set; }
        public Date Arrival { get; set; }
        public Contact Driver { get; set; }
        public int Budget { get; set; }

        public virtual ICollection<List> Projects { get; set; }
        public virtual ICollection<List> Lodgings { get; set; }
    }
}
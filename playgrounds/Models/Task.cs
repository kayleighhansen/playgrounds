using System.Collections.Generic;

namespace Playgrounds.Models
{
    public class Task {
        public int TaskId { get; set; }
        public Date DateAdded{ get; set; }
        public bool Completed { get; set; }
        public string ActionType { get; set; }
        public int TripId { get; set; }


        public virtual ICollection<List> Contacts { get; set; }
        public virtual ICollection<List> Organizations { get; set; }
        public virtual ICollection<List> Trips { get; set; }
        public virtual ICollection<List> Projects { get; set; }

    }
}
using System.Collections.Generic;

namespace Playgrounds.Models
{
    public class Organization { 
        public int OrganizationId { get; set; }
        public Date DateAdded { get; set; }
        public Address Address { get; set; }
        public ContactInfo ContactInfo { get; set; }
        public OrganizationType Type { get; set; }
        public string Description { get; set; }


        public virtual ICollection<List> Contacts { get; set; }
        public virtual ICollection<List> Projects { get; set; }
        public virtual ICollection<List> Tasks { get; set; }
        public virtual ICollection<List> Trips { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playgrounds.Models
{
    public class Contact
    {
        public int ContactId { get; set; }

        // Contact Details
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string Details { get; set; }

        // Date the contact was added
        public int DateAdded { get; set; }

        // Contact Information

        [InverseProperty("ContactInformationList")]
        public int ContactInformation { get; set; }



        // Lists they belong to

        //public virtual ICollection<List> Organizations { get; set; }
        // public virtual ICollection<List> Projects { get; set; }
        // public virtual ICollection<List> Tasks { get; set; }
        // public virtual ICollection<List> Trips { get; set; }

    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playgrounds.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public int DateAddedId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string Details { get; set; }

        // reference keys
        public int ContactInfoId { get; set;}
        public int AddressId { get; set;}

        //navigation properties
        [InverseProperty("ContactDateAdded")]
        public Date DateAdded { get; set; }

        [InverseProperty("ContactInformation")]
        public ContactInfo ContactInfomation { get; set; }

        // can appear in these lists
        // public virtual ICollection<List> Organizations { get; set; }
        // public virtual ICollection<List> Projects { get; set; }
        // public virtual ICollection<List> Tasks { get; set; }
        // public virtual ICollection<List> Trips { get; set; }

    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playgrounds.Models
{
    public class Note {

        public int NoteId { get; set; }
        public int DateAddedId { get; set; }
        public string Text { get; set; }
        public int ContactId { get; set; }


        // navigation properties
        public Contact Contacts { get; set; }

        [InverseProperty("NoteDateAdded")]         
        public Date DateAdded { get; set; }


        // can appear in these lists
        // [InverseProperty("Contacts")]

        // [InverseProperty("Organizations")]
        // public Organization Organizations { get; set; }


        // [InverseProperty("Projects")]
        // public Project Projects { get; set; }


        // [InverseProperty("Trips")]
        // public Trip Trips { get; set; }


        // [InverseProperty("Tasks")]
        // public Task Tasks { get; set; }
    }
}
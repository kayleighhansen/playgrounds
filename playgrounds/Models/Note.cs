using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playgrounds.Models
{
    public class Note {

        public int NoteId { get; set; }
        public string DateAdded { get; set; }
        public string Text { get; set; }


        // can appear in these lists
        // [InverseProperty("Contacts")]
        // public Contact Contacts { get; set; }


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
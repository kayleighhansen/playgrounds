using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Playgrounds.Models
{
    public class List {

        public int ListItemId { get; set; }
        public int ContactId { get; set; }
        public int OrganizationId { get; set; }
        public int ProjectId { get; set; }
        public int TripId { get; set; }
        public int TaskId { get; set; }
        public int LodgingId { get; set; }



        [InverseProperty("Contacts")]
        public Contact Contacts { get; set; }


        [InverseProperty("Organizations")]
        public Organization Organizations { get; set; }


        [InverseProperty("Projects")]
        public Project Projects { get; set; }


        [InverseProperty("Trips")]
        public Trip Trips { get; set; }


        [InverseProperty("Tasks")]
        public Task Tasks { get; set; }


        [InverseProperty("Lodgings")]
        public Lodging Lodgings { get; set; }
    }

}

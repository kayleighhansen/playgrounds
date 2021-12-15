
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Playgrounds.Models
{
    public class Lodging {
        public int LodgingId { get; set; }
        public string Name { get; set; }
        public Address LodgingAddress { get; set; }
        public Date Arrival { get; set; }
        public Date Departure { get; set; }
        public int Budget { get; set; }
        public int TripId { get; set; }



        [InverseProperty("Trips")]
        public Trip Trips { get; set; }
    }
}

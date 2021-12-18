using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;


namespace Playgrounds.Models
{
    public class Date {

        public int DateId { get; set; }
        public string Time { get; set; }
        public string DayWeek { get; set; }
        public string DayMonth { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

        public Contact ContactDateAdded { get; set; } 
        public Note NoteDateAdded { get; set; }



        // [InverseProperty("ContactInformation")]
        // public Contact Dates { get; set; }
        // public Contact OrganizationId { get; set; }
    }
}
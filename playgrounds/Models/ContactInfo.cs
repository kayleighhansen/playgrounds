using System.Collections.Generic;

namespace Playgrounds.Models
{
    public class ContactInfo {
        public int ContactInfoId {get; set; }
        public string phone {get; set; }
        public string email {get; set; }
        public string facebook {get; set; }
        public string instagram {get; set; }

        // navigation properties
        public Contact ContactInformation { get; set; }


        // can appear in these lists
        // public List<Contact> ContactInfoLists { get; set; }
        // public List<Organization> OrganizationInfoLists { get; set; }
        // public List<Project> ProjectInfoLists { get; set; }
        // public List<Lodging> LodgingInfoLists { get; set; }
    }
}
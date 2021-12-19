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
        public List<Contact> ContactInformationList { get; set; }

    }
}
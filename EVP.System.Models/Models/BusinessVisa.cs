using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Models
{
    public class BusinessVisa : Applicant
    {
        public int ApplicantID { get; set; }

        public string PurposeOfTravel { get; set; }

        public string BusinessName { get; set; }

        public string BusinessAddress { get; set; }
        
        public string BusinessContact { get; set; }

        public string Designation { get; set; }

        public string DateOfArrival { get; set; }

        public string DateOfDeparture { get; set; }

        public string PurposedAddressInNepal { get; set; }

        public string NameofGuarantor { get; set; }

        public string AddressOfGuarantor { get; set; }

        public string ContactOfGuarantor { get; set; }
    }
}

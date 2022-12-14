using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.ViewModels
{
    public class TouristVisaViewModel
    {
        public int ApplicantID { get; set; }

        public string PurposeOfTravel { get; set; }

        public string DateOfArrival { get; set; }

        public string DateOfDeparture { get; set; }
        public string PurposedAddressInNepal { get; set; }
        public string NameofGuarantor { get; set; }
        public string AddressOfGuarantor { get; set; }

        public string ContactOfGuarantor { get; set; }

        public class CreateTouristVisaViewModel
        {
            public int ApplicantID { get; set; }

            public string PurposeOfTravel { get; set; }

            public string DateOfArrival { get; set; }

            public string DateOfDeparture { get; set; }
            public string PurposedAddressInNepal { get; set; }
            public string NameofGuarantor { get; set; }
            public string AddressOfGuarantor { get; set; }

            public string ContactOfGuarantor { get; set; }
        }
    }
}
    
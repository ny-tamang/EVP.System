using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Models
{
    public class StudentVisa : Applicant
    {
        public int ApplicantID { get; set; }

        public string HighestQualification { get; set; }

        public string NameOfEducationProvider {get; set; }

        public string AddressOfEducationProvider { get; set; }

        public string IntendedCourse { get; set; }

        public string NameOfUniversity { get; set; }

        public string CommencementDate { get; set; }

        public string FinishDate { get; set; }

        public string NameofEnglishLanguageTest { get; set; }

        public string TestLocation { get; set; }

        public string TestCertificateumber { get; set; }

        public string TestScore { get; set; }
              
        public string PurposedAddressInNepal { get; set; }
       
    }
}

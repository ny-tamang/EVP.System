using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Models
{
    public class PassportInfo : Applicant
    {
        public int ApplicantId { get; set; } 

        public int PassportNo { get; set; }

        public string DateOfIssue { get; set; }

        public string ExpiryDate { get; set; }

        public string IssuedAt { get; set; }

        public string IssuingAuthority { get; set; }
    }
}

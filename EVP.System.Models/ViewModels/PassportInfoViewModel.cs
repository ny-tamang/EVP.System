using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.ViewModels
{
    public class PassportInfoViewModel
    {
        public int ApplicantId { get; set; }

        public int PassportNo { get; set; }

        public string DateOfIssue { get; set; }

        public string ExpiryDate { get; set; }

        public string IssuedAt { get; set; }

        public string IssuingAuthority { get; set; }

        public class CreatePassportInfoViewModel
        {
            public int ApplicantId { get; set; }

            public int PassportNo { get; set; }

            public string DateOfIssue { get; set; }

            public string ExpiryDate { get; set; }

            public string IssuedAt { get; set; }

            public string IssuingAuthority { get; set; }
        }
    }

}

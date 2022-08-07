using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.ViewModels
{
    public class ApplicantViewModel
    {

        [Key]
        public int ApplicantId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNo { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string PlaceOfBirth { get; set; }
        [Required]
        public string RelationshipStatus { get; set; }
        [Required]
        public string CitizenshipNo { get; set; }

        public class ApplicantCreateViewModel
        {
            [Key]
            public int ApplicantId { get; set; }
            [Required]
            public string Name { get; set; }
            [Required]
            public string Email { get; set; }
            [Required]
            public string PhoneNo { get; set; }
            [Required]
            public string Gender { get; set; }
            [Required]
            public string PlaceOfBirth { get; set; }
            [Required]
            public string RelationshipStatus { get; set; }
            [Required]
            public string CitizenshipNo { get; set; }
        }
    }
}

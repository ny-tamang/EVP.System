using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Models
{
    public class Applicant
    {
        [Key]
        public int ApplicantId { get; set; } 
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Phone No.")]
        public string PhoneNo { get; set; }
        
        [Required]
        public string Gender { get; set; }

        [Required]
        [Display(Name = "Permanent Address")]
        public string PermanentAddress { get; set; }

        [Display(Name = "Temporary Address")]
        public string TemporaryAddress { get; set; }
        
        [Required]
        public string DateOfBirth { get; set; }
        [Required]
        public string PlaceOfBirth { get; set; }
        [Required]
        public string RelationshipStatus { get; set; }
        [Required]
        public string CitizenshipNo { get; set; }

        public string Occupation { get; set; }

        public bool IsDeleted { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EVP.System.Models;
using EVP.System.Repository;
using EVP.System.ViewModels;
using static EVP.System.ViewModels.ApplicantViewModel;

namespace EVP.System.Services
{
    public interface IApplicantService
    {
        (bool, string) Create(ApplicantCreateViewModel model);
        (bool, string) HardDelete(int id);
        (bool, string) SoftDelete(int id);
    }
    public class ApplicantService : IApplicantService
    {
        private readonly IApplicantRepository ApplicantRepository;

        public ApplicantService(ApplicantRepository IApplicantRepository)
        {
            this.ApplicantRepository = IApplicantRepository;   
        }

        public (bool, string) Create(ApplicantCreateViewModel model)
        {
            try
            {
                var applicant = new Applicant()
                {
                    Name = model.Name,
                    Email = model.Email,
                    PhoneNo = model.PhoneNo,
                    Gender = model.Gender,
                    PlaceOfBirth = model.PlaceOfBirth,  
                    RelationshipStatus = model.RelationshipStatus,
                    CitizenshipNo = model.CitizenshipNo,
                };
                return ApplicantRepository.Create(applicant);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }


        //concept of soft delete

        public (bool, string) SoftDelete(int id)
        {
            try
            {
                var existing = ApplicantRepository.GetByID(id);
                if (existing == null) return (false, $"Record with {id} not found");

                existing.IsDeleted = true;
                return ApplicantRepository.Edit(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public (bool, string) HardDelete(int id)
        {
            try
            {
                var existing = ApplicantRepository.GetByID(id);
                if (existing == null) return (false, $"Record with {id} not found");

                return ApplicantRepository.Delete(existing);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }

   
}
    

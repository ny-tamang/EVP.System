using EVP.System.Data;
using EVP.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Repository
{
    public interface IApplicantRepository
    {
        (bool, string) Create(Applicant model);
        (bool, string) Edit(Applicant model);
        (bool, string) Delete(Applicant model);
        IQueryable<Applicant> GetAll();
        Applicant GetByID(int id);
    }
    public class ApplicantRepository : IApplicantRepository
    {
        private readonly ApplicationDbContext db;
        public ApplicantRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<Applicant> GetAll()
        {
            return db.Applicants;
        }

        public Applicant GetByID(int id)
        {
            var existing = db.Applicants.Find(id);
           if ((existing == null) || existing.IsDeleted)
                return null;
           return existing;

        }

        public (bool, string) Create(Applicant model)
        {
            try
            {
                db.Applicants.Add(model);
                db.SaveChanges();

                return (true, "Added Successfully");

            }
            catch(Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Edit(Applicant model)
        {
            try
            {
                db.Applicants.Update(model);
                db.SaveChanges();
                return (true, "It is updated successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Delete(Applicant model)
        {
            try
            {
                db.Applicants.Remove(model);
                db.SaveChanges();
                return (true, "It is deleted successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}

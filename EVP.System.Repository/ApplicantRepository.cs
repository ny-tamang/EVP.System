using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Repository
{   
    public interface IRepository
    {

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
    }
}

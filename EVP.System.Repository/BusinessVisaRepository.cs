using EVP.System.Data;
using EVP.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Repository
{
    public interface IBusinessVisaRepository
    {
        (bool, string) Create(BusinessVisa model);
        (bool, string) Edit(BusinessVisa model);
        (bool, string) Delete(BusinessVisa model);
        IQueryable<BusinessVisa> GetAll();
        BusinessVisa GetByID(int id);
    }
         
    public class BusinessVisaRepository
    {
            private readonly ApplicationDbContext db;
            public BusinessVisaRepository(ApplicationDbContext db)
            {
                this.db = db;
            }

            public IQueryable<BusinessVisa> GetAll()
            {
                return db.BusinessVisas;
            }

            public BusinessVisa GetByID(int id)
            {
            var existing = db.BusinessVisas.Find(id);
                if ((existing == null) || existing.IsDeleted)
                    return null;
                return existing;

            }

            public (bool, string) Create(BusinessVisa model)
            {
                try
                {
                    db.BusinessVisas.Add(model);
                    db.SaveChanges();

                    return (true, "Added Successfully");

                }
                catch (Exception ex)
                {
                    return (false, ex.Message);
                }
            }
            public (bool, string) Edit(BusinessVisa model)
            {
                try
                {
                    db.BusinessVisas.Update(model);
                    db.SaveChanges();
                    return (true, "It is updated successfully");
                }
                catch (Exception ex)
                {
                    return (false, ex.Message);
                }
            }
            public (bool, string) Delete(BusinessVisa model)
            {
                try
                {
                    db.BusinessVisas.Remove(model);
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

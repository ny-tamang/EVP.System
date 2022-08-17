using EVP.System.Data;
using EVP.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Repository
{
    public class TouristVisaRepository
    {
        private readonly ApplicationDbContext db;
        public TouristVisaRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<TouristVisa> GetAll()
        {
            return db.TouristVisas;
        }

        public TouristVisa GetByID(int id)
        {
            var existing = db.TouristVisas.Find(id);
            if ((existing == null) || existing.IsDeleted)
                return null;
            return existing;

        }

        public (bool, string) Create(TouristVisa model)
        {
            try
            {
                db.TouristVisas.Add(model);
                db.SaveChanges();

                return (true, "Added Successfully");

            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Edit(TouristVisa model)
        {
            try
            {
                db.TouristVisas.Update(model);
                db.SaveChanges();
                return (true, "It is updated successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Delete(TouristVisa model)
        {
            try
            {
                db.TouristVisas.Remove(model);
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

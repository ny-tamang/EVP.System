using EVP.System.Data;
using EVP.System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Repository
{
    public interface IPassportInfoRepository
    {

    }
    public class PassportInfoRepository
    {
        private readonly ApplicationDbContext db;
        public PassportInfoRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<PassportInfo> GetAll()
        {
            return db.PassportInfos;
        }

        public PassportInfo GetByID(int id)
        {
            var existing = db.PassportInfos.Find(id);
            if ((existing == null) || existing.IsDeleted)
                return null;
            return existing;

        }

        public (bool, string) Create(PassportInfo model)
        {
            try
            {
                db.PassportInfos.Add(model);
                db.SaveChanges();

                return (true, "Added Successfully");

            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Edit(PassportInfo model)
        {
            try
            {
                db.PassportInfos.Update(model);
                db.SaveChanges();
                return (true, "It is updated successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Delete(PassportInfo model)
        {
            try
            {
                db.PassportInfos.Remove(model);
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

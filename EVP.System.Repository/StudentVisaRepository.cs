using EVP.System.Data;
using EVP.System.Models;
using EVP.System.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVP.System.Repository
{
    public interface IStudentVisaRepository
    {

    }
    public class StudentVisaRepository
    {
        private readonly ApplicationDbContext db;
        public StudentVisaRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IQueryable<StudentVisa> GetAll()
        {
            return db.StudentVisas;
        }

        public StudentVisa GetByID(int id)
        {
            var existing = db.StudentVisas.Find(id);
            if ((existing == null) || existing.IsDeleted)
                return null;
            return existing;

        }

        public (bool, string) Create(StudentVisa model)
        {
            try
            {
                db.StudentVisas.Add(model);
                db.SaveChanges();

                return (true, "Added Successfully");

            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Edit(StudentVisa model)
        {
            try
            {
                db.StudentVisas.Update(model);
                db.SaveChanges();
                return (true, "It is updated successfully");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
        public (bool, string) Delete(StudentVisa model)
        {
            try
            {
                db.StudentVisas.Remove(model);
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

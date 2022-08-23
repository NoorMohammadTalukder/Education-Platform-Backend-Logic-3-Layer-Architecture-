using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class student : IRepoS<Student, int, bool>
    {
        Education_Platform_Final_TermEntities db;
        public student(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Student obj)
        {
            db.Students.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student obj)
        {
            var data = db.Students.SingleOrDefault(s => s.Id == obj.Id);
            data.Id = obj.Id;
            data.Name = obj.Name;
            data.Address = obj.Address;
            data.Email = obj.Email;
            data.Phone = obj.Phone;
            data.Institution = obj.Institution;
            data.Education = obj.Education;
            data.Password = obj.Password;
            data.IsValid = obj.IsValid;
            data.Gender = obj.Gender;

            db.SaveChanges();

            return true;
        }
    }
}
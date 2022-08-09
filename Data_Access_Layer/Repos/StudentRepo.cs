using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class StudentRepo : IRepo<Student, int>
    {
        Education_Platform_Final_TermEntities db;
        public StudentRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Student obj)
        {

            db.Students.Add(obj);
            db.SaveChanges();
            return true;

        }

        public bool Delete(int id)
        {
            var data = (from i in db.Students where i.Id == id select i).FirstOrDefault();
            db.Students.Remove(data);
            db.SaveChanges();
            return true;
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student GetId(int id)
        {
            return db.Students.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Student obj)
        {
            var data = (from i in db.Students where i.Id == obj.Id select i).FirstOrDefault();
            db.Entry(data).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;

        }
    }
}
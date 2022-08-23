using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class ReviewStudentRepo : IRepo<Reviewstudent, int>
    {
        Education_Platform_Final_TermEntities db;

        public ReviewStudentRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Reviewstudent obj)
        {
            db.Reviewstudents.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var reviewstudentid = db.Reviewstudents.FirstOrDefault(i => i.Id == id);
            db.Reviewstudents.Remove(reviewstudentid);
            db.SaveChanges();
            return true;
        }

        public List<Reviewstudent> Get()
        {
            return db.Reviewstudents.ToList();
        }

        public Reviewstudent GetId(int id)
        {
            return db.Reviewstudents.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Reviewstudent obj)
        {
            var updatereview = db.Reviewstudents.FirstOrDefault(i => i.Id == obj.Id);
            db.Entry(updatereview).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
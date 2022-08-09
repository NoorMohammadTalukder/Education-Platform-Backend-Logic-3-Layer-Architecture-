using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class AssignmentRepo : IRepo<Assignment, int>
    {
        Education_Platform_Final_TermEntities db;

        public AssignmentRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Assignment obj)
        {
            db.Assignments.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var data = (from i in db.Assignments where i.Id == id select i).FirstOrDefault();
            db.Assignments.Remove(data);
            db.SaveChanges();
            return true;
        }

        public List<Assignment> Get()
        {
            return db.Assignments.ToList();
        }

        public Assignment GetId(int id)
        {
            var data = (from i in db.Assignments where i.Id == id select i).FirstOrDefault();
            return data;
        }

        public bool Update(Assignment obj)
        {
            var data = (from i in db.Assignments where i.Id == obj.Id select i).FirstOrDefault();
            db.Entry(data).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
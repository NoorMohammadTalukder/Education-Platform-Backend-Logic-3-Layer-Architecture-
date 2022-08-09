using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class ValidStudentRepo: IRepo<ValidStudent, int>
    {
        Education_Platform_Final_TermEntities db;

        public ValidStudentRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(ValidStudent obj)
        {
            db.ValidStudents.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
           
                var x = db.ValidStudents.FirstOrDefault(e => e.Id == id);
                db.ValidStudents.Remove(x);
                db.SaveChanges();
                return true;

           
        }

        public List<ValidStudent> Get()
        {
            return db.ValidStudents.ToList();

        }

        public ValidStudent GetId(int id)
        {
            var x = (from i in db.ValidStudents
                     where i.Id == id
                     select i).FirstOrDefault();
            return x;

        }

        public bool Update(ValidStudent obj)
        {
            var x = (from i in db.ValidStudents 
                     where i.Id == obj.Id
                     select i).FirstOrDefault();
            
            db.Entry(x).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}

using System;
using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class CourseModuleRepo : IRepo<CourseModule, int>
    {
        Education_Platform_Final_TermEntities db;

        public CourseModuleRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(CourseModule obj)
        {
            db.CourseModules.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CourseModule> Get()
        {
            return db.CourseModules.ToList();
        }

        public CourseModule GetId(int id)
        {
            var data = (from i in db.CourseModules where i.Id == id select i).FirstOrDefault();
            return data;
        }

        public bool Update(CourseModule obj)
        {
            var data = (from i in db.CourseModules where i.Id == obj.Id select i).FirstOrDefault();
            db.Entry(data).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
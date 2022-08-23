using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class SCourseM : IRepoS<CourseModule, int, bool>
    {
        Education_Platform_Final_TermEntities db;
        public SCourseM(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(CourseModule obj)
        {
            db.CourseModules.Add(obj);
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

        public List<CourseModule> Get()
        {
            return db.CourseModules.ToList();
        }

        public CourseModule GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CourseModule obj)
        {
            var data = db.CourseModules.SingleOrDefault(s => s.Id == obj.Id);
            data.Id = obj.Id;
            data.CourseId = obj.CourseId;
            data.MentorId = obj.MentorId;
            data.Material = obj.Material;
            data.Description = obj.Description;
            data.Module = obj.Module;
            data.Date = obj.Date;

            db.SaveChanges();

            return true;
        }
    }
}
using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{

    public class ScourseRepo : IRepoS<Cours, int, bool>
    {
        Education_Platform_Final_TermEntities db;
        public ScourseRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Cours obj)
        {
            db.Courses.Add(obj);
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

        public List<Cours> Get()
        {
            return db.Courses.ToList();
        }

        public Cours GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cours obj)
        {
            var data = db.Courses.SingleOrDefault(s => s.Id == obj.Id);
            data.Id = obj.Id;
            data.Name = obj.Name;
            data.Details = obj.Details;
            data.Price = obj.Price;
            data.Duration = obj.Duration;
            data.Date = obj.Date;
            data.Photo = obj.Photo;
            data.InstitutionId = obj.InstitutionId;
            data.MentorId = obj.MentorId;

            db.SaveChanges();

            return true;
        }
    }
}
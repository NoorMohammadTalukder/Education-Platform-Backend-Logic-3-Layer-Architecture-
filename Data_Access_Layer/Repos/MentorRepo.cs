using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class MentorRepo : IRepo<Mentor, int>
    {
        Education_Platform_Final_TermEntities db;
        public MentorRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Mentor obj)
        {
            db.Mentors.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {

            var mentor = db.Mentors.FirstOrDefault(i => i.Id == id);
            db.Mentors.Remove(mentor);
            db.SaveChanges();
            return true;
        }

        public List<Mentor> Get()
        {
            return db.Mentors.ToList();
        }

        public Mentor GetId(int id)
        {
            return db.Mentors.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Mentor obj)
        {
            var updatementor = db.Mentors.FirstOrDefault(i => i.Id == obj.Id);
            db.Entry(updatementor).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;

        }

    }
}
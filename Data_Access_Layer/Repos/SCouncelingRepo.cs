using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class SCounselingRepo : IRepoS <Counseling, int, bool>
    {
        Education_Platform_Final_TermEntities db;
        public SCounselingRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Counseling obj)
        {
            db.Counselings.Add(obj);
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

        public List<Counseling> Get()
        {
            return db.Counselings.ToList();
        }

        public Counseling GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Counseling obj)
        {
            var data = db.Counselings.SingleOrDefault(s => s.Id == obj.Id);
            data.Id = obj.Id;
            data.MentorId = obj.MentorId;
            data.CourseId = obj.CourseId;
            data.MeetLink = obj.MeetLink;
            data.Details = obj.Details;
            data.Date = obj.Date;

            db.SaveChanges();

            return true;
        }
    }
}
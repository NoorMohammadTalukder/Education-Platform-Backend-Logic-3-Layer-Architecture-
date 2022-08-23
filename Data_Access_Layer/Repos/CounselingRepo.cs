using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class CounselingRepo : IRepo<Counseling, int>
    {
        Education_Platform_Final_TermEntities db;
        public CounselingRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Counseling obj)
        {
            db.Counselings.Add(obj);
            db.SaveChanges();
            return true; ;
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
            return db.Counselings.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Counseling obj)
        {
            var updatecounseling = db.Counselings.FirstOrDefault(i => i.Id == obj.Id);
            db.Entry(updatecounseling).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true; ;
        }
    }
}
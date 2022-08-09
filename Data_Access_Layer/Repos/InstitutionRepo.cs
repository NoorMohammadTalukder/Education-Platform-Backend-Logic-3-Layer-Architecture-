using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class InstitutionRepo:IRepo<Institution,int>
    {
        Education_Platform_Final_TermEntities db;

        public InstitutionRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Institution obj)
        {
            db.Institutions.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            
                var institution = db.Institutions.FirstOrDefault(e => e.Id == id);
                db.Institutions.Remove(institution);
                db.SaveChanges();
                return true;
           
        }

        public List<Institution> Get()
        {
            return db.Institutions.ToList();

        }

        public Institution GetId(int id)
        {
            var institution = (from i in db.Institutions
                         where i.Id == id
                         select i).FirstOrDefault();
            return institution;

        }

        public bool Update(Institution obj)
        {
            var institution = (from i in db.Institutions where i.Id == obj.Id select i).FirstOrDefault();
            db.Entry(institution).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}

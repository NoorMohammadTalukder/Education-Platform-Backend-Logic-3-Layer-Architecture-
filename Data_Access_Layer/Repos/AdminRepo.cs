using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class AdminRepo : IRepo<Admin, int>
    {
        Education_Platform_Final_TermEntities db;

        public AdminRepo (Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Admin obj)
        {
            db.Admins.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            try
            {
                var admin = db.Admins.FirstOrDefault(e => e.Id == id);
                db.Admins.Remove(admin);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public List<Admin> Get()
        {
           return db.Admins.ToList();
          
        }

        public Admin GetId(int id)
        {
            var admin = (from i in db.Admins
                        where i.Id==id select i).FirstOrDefault();
            return admin;
                 
        }

        public bool Update(Admin obj)
        {
            var admin=(from i in db.Admins where i.Id==obj.Id select i).FirstOrDefault();
            db.Entry(admin).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }


}

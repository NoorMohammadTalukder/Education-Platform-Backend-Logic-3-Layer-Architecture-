using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class PasswordChangeRequestRepo: IRepo<PasswordChangeRequest, int>
    {
        Education_Platform_Final_TermEntities db;

        public PasswordChangeRequestRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }



        public bool Create(PasswordChangeRequest obj)
        {
            db.PasswordChangeRequests.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PasswordChangeRequest> Get()
        {
            return db.PasswordChangeRequests.ToList();
        }

        public PasswordChangeRequest GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(PasswordChangeRequest obj)
        {
            throw new NotImplementedException();
        }
    }
}

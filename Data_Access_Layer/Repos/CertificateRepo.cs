using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class CertificateRepo : IRepo<Certificate, int>
    {
        Education_Platform_Final_TermEntities db;

        public CertificateRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Certificate obj)
        {
            db.Certificates.Add(obj);
            db.SaveChanges();

        





            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Certificate> Get()
        {
            throw new NotImplementedException();
        }

        public Certificate GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Certificate obj)
        {
            var updatecertificate = db.Certificates.FirstOrDefault(i => i.Id == obj.Id);
            db.Entry(updatecertificate).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class ActivateDeactivateUserRepo:IUserActivateDeactivateApprove
    {
        Education_Platform_Final_TermEntities db;

        public ActivateDeactivateUserRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool ActivateInstitution(int id)
        {

            var institution = (from i in db.Institutions
                               where i.Id == id
                               select i).FirstOrDefault();

            institution.IsValid = "Yes";

            db.SaveChanges();
            return true;
        }

        public bool DeactivateInstitution(int id)
        {

            var institution = (from i in db.Institutions
                               where i.Id == id
                               select i).FirstOrDefault();

            institution.IsValid = "No";

            db.SaveChanges();
            return true;
        }

        public bool ActivateMentor(int id)
        {

            var x = (from i in db.Mentors
                               where i.Id == id
                               select i).FirstOrDefault();

            x.IsValid = "Yes";

            db.SaveChanges();
            return true;
        }

        public bool DeactivateMentor(int id)
        {

            var x = (from i in db.Mentors
                               where i.Id == id
                               select i).FirstOrDefault();

            x.IsValid = "No";

            db.SaveChanges();
            return true;
        }

        public bool ActivateStudent(int id)
        {

            var x = (from i in db.Students
                               where i.Id == id
                               select i).FirstOrDefault();

            x.IsValid = "Yes";

            db.SaveChanges();
            return true;
        }

        public bool DeactivateStudent(int id)
        {

            var x = (from i in db.Students
                               where i.Id == id
                               select i).FirstOrDefault();

            x.IsValid = "No";

            db.SaveChanges();
            return true;
        }

        public bool CertificateApprove(int id)
        {

            var x = (from i in db.Certificates
                     where i.Id == id
                     select i).FirstOrDefault();

            x.Status = "Approved by ABC Education";

            db.SaveChanges();
            return true;
        }
    }
}

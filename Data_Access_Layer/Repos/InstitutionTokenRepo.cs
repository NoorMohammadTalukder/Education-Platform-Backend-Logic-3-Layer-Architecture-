using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class InstitutionTokenRepo : IInstitutionAuth
    {
        Education_Platform_Final_TermEntities db;

        public InstitutionTokenRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public InstitutionToken Authenticate(Institution use)
        {
            InstitutionToken t = null;
            var u = db.Institutions.FirstOrDefault(e => e.Email == use.Email && e.Password == use.Password);
            if (u != null)
            {
                var g = Guid.NewGuid().ToString();
                t = new InstitutionToken()
                {
                    InstitutionId = u.Id,
                    Token = g,
                    CreatedAt = DateTime.Now.ToString()
                };
                db.InstitutionTokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string tok)
        {
            var ac_token = db.InstitutionTokens.FirstOrDefault(e => e.Token.Equals(tok) && e.ExpiredAt == null);
            if (ac_token != null)
            {
                return true;
            }
            return false;
        }

        public bool Logout(string token)
        {
            var t = db.InstitutionTokens.FirstOrDefault(e => e.Token.Equals(token));
            if (t != null)
            {
                t.ExpiredAt = DateTime.Now.ToString();
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
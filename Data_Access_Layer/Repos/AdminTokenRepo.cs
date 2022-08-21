using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class AdminTokenRepo : IAdminAuth
    {
        Education_Platform_Final_TermEntities db;

        public AdminTokenRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public AdminToken Authenticate(Admin use)
        {
            AdminToken t = null;
            var u = db.Admins.FirstOrDefault(e => e.Email == use.Email && e.Password == use.Password);
            if (u != null)
            {
                var g = Guid.NewGuid().ToString();
                t = new AdminToken()
                {
                    AdminId = u.Id,
                    Token = g,
                    CreatedAt = DateTime.Now.ToString()
                };
                db.AdminTokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string tok)
        {
            var ac_token = db.AdminTokens.FirstOrDefault(e => e.Token.Equals(tok) && e.ExpiredAt == null);
            if (ac_token != null)
            {
                return true;
            }
            return false;
        }

        public bool Logout(string token)
        {
            var t = db.AdminTokens.FirstOrDefault(e => e.Token.Equals(token));
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

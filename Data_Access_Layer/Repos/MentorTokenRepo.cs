using System;
using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class MentorTokenRepo : IMentorAuth
    {
        Education_Platform_Final_TermEntities db;

        public MentorTokenRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public MentorToken Authenticate(Mentor use)
        {
            MentorToken t = null;
            var u = db.Mentors.FirstOrDefault(e => e.Email == use.Email && e.Password == use.Password);
            if (u != null)
            {
                var g = Guid.NewGuid().ToString();
                t = new MentorToken()
                {
                    MentorId = u.Id,
                    Token = g,
                    Createdat = DateTime.Now.ToString()
                };
                db.MentorTokens.Add(t);
                db.SaveChanges();
            }
            return t;
        }

        public bool IsAuthenticated(string tok)
        {
            throw new NotImplementedException();
        }

        public bool Logout(string token)
        {
            var t = db.MentorTokens.FirstOrDefault(e => e.Token.Equals(token));
            if (t != null)
            {
                t.Expiredat = DateTime.Now.ToString();
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
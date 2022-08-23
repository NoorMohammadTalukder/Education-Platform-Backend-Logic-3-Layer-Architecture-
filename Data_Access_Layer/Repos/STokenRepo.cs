using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    internal class STokenRepo : IRepoS<Token, string, Token>
    {
        Education_Platform_Final_TermEntities db;
        public STokenRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            db.SaveChanges();
            return obj;
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token GetId(string token)
        {
            return db.Tokens.FirstOrDefault(t => t.TokenKey.Equals(token));

        }

        public bool Update(Token obj)
        {
            var exst = db.Tokens.FirstOrDefault(x => x.TokenKey.Equals(obj.TokenKey));
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
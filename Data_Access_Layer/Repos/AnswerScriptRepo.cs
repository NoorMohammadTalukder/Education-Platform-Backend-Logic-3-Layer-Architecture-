using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class AnswerScriptRepo : IRepo<AnswerScript, int>
    {
        Education_Platform_Final_TermEntities db;

        public AnswerScriptRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }


        public bool Create(AnswerScript obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<AnswerScript> Get()
        {
            return db.AnswerScripts.ToList();
        }

        public AnswerScript GetId(int id)
        {
            return db.AnswerScripts.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(AnswerScript obj)
        {
            throw new NotImplementedException();
        }
    }
}
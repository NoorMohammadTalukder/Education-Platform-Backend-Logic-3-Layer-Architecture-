using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class ResultRepo : IRepo<Result, int>
    {
        Education_Platform_Final_TermEntities db;
        public ResultRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Result obj)
        {
            db.Results.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {

            var result = db.Results.FirstOrDefault(e => e.Id == id);
            db.Results.Remove(result);
            db.SaveChanges();
            return true;
        }

        public List<Result> Get()
        {
            return db.Results.ToList();
        }

        public Result GetId(int id)
        {
            var result = (from i in db.Results
                          where i.Id == id
                          select i).FirstOrDefault();
            return result;
        }

        public bool Update(Result obj)
        {
            var result = (from i in db.Results where i.Id == obj.Id select i).FirstOrDefault();
            db.Entry(result).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class RatingsRepo : IRepo<Rating, int>
    {
        Education_Platform_Final_TermEntities db;

        public RatingsRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Rating obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rating> Get()
        {
            return db.Ratings.ToList();
        }

        public Rating GetId(int id)
        {

            return db.Ratings.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Rating obj)
        {
            throw new NotImplementedException();
        }
    }
}
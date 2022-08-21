using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class TransactionRepo: IRepo<Transaction, int>
    {
        Education_Platform_Final_TermEntities db;
        public TransactionRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Transaction obj)
        {
            db.Transactions.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> Get()
        {
            return db.Transactions.ToList();
        }

        public Transaction GetId(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Transaction obj)
        {
            throw new NotImplementedException();
        }
    }
}

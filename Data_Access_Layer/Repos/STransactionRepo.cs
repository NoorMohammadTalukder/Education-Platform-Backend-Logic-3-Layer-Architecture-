using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class STransactionRepo : IRepoS<Transaction, int, bool>
    {
        Education_Platform_Final_TermEntities db;
        public STransactionRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Transaction obj)
        {
            db.Transactions.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
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
            var data = db.Transactions.SingleOrDefault(s => s.Id == obj.Id);
            data.Id = obj.Id;
            data.CourseId = obj.CourseId;
            data.StudentId = obj.StudentId;
            data.InstitutionId = obj.InstitutionId;
            data.BkashTransactionNumber = obj.BkashTransactionNumber;
            data.Date = obj.Date;
            data.CreditedAmount = obj.CreditedAmount;

            db.SaveChanges();

            return true;
        }
    }
}
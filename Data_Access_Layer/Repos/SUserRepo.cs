using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class SUserRepo : IRepoS<Student, string, bool>, IAuth<Student>
    {
        Education_Platform_Final_TermEntities db;
        public SUserRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public Student Authenticate(string email, string password)
        {
            return db.Students.FirstOrDefault(u => u.Email.Equals(email)
             && u.Password.Equals(password));
        }

        public bool Create(Student obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Student> Get()
        {
            throw new NotImplementedException();
        }

        public Student GetId(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Student obj)
        {
            throw new NotImplementedException();
        }
    }
}
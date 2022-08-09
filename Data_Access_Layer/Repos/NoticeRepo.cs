using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class NoticeRepo : IRepo<Notice, int>
    {

        Education_Platform_Final_TermEntities db;
        public NoticeRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }

        public bool Create(Notice obj)
        {
            db.Notices.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var notice = db.Notices.FirstOrDefault(i => i.Id == id);
            db.Notices.Remove(notice);
            db.SaveChanges();
            return true;
        }

        public List<Notice> Get()
        {
            return db.Notices.ToList();
        }

        public Notice GetId(int id)
        {
            return db.Notices.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Notice obj)
        {
            var updatenotice = db.Notices.FirstOrDefault(i => i.Id == obj.Id);
            db.Entry(updatenotice).CurrentValues.SetValues(obj);
            db.SaveChanges();
            return true;
        }
    }
}
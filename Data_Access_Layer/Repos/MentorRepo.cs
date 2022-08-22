using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer.Repos
{
    public class MentorRepo : IRepo<Mentor, int>
    {
        Education_Platform_Final_TermEntities db;
        public MentorRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Mentor obj)
        {
            db.Mentors.Add(obj);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {

            var mentor = db.Mentors.FirstOrDefault(i => i.Id == id);
            db.Mentors.Remove(mentor);
            db.SaveChanges();
            return true;
        }

        public List<Mentor> Get()
        {
            return db.Mentors.ToList();
        }

        public Mentor GetId(int id)
        {
            return db.Mentors.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Mentor obj)
        {
            var updatementor = db.Mentors.FirstOrDefault(i => i.Id == obj.Id);
            db.Entry(updatementor).CurrentValues.SetValues(obj);
            db.SaveChanges();

            MailMessage mail = new MailMessage();
            mail.To.Add(obj.Email);
            mail.From = new MailAddress("19-40649-1@student.aiub.edu");
            mail.Subject = "Your Profile has updated by Admin of ABC Education";
            string Body = "Hello sir <br/>" +
                           "Your profile has been updated by our admin panel <br/>" +
                           "Your new username or mail:" + obj.Email + "<br/>" +
                           "Your new password:" + obj.Password + "<br/>" +
                           "Please login to check the update" + "<br/>" +
                           "<br/>" +
                           "<b>Best Regards</b><br/>" +
                           "Admin Panel <br/>" +
                           "ABC Education";

            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("19-40649-1@student.aiub.edu", "*nana*apon*pran*bacha*90279027*@!"); // Enter seders User name and password  
            smtp.EnableSsl = true;
            smtp.Send(mail);

            return true;

        }

    }
}
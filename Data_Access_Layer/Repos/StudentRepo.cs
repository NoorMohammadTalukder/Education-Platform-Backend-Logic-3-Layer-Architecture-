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
    public class StudentRepo : IRepo<Student, int>
    {
        Education_Platform_Final_TermEntities db;
        public StudentRepo(Education_Platform_Final_TermEntities db)
        {
            this.db = db;
        }
        public bool Create(Student obj)
        {

            db.Students.Add(obj);
            db.SaveChanges();

            MailMessage mail = new MailMessage();
            // var studentId = (from p in db.Results where p.Id == id select p.StudentId).FirstOrDefault();

            mail.To.Add(obj.Email);
            mail.From = new MailAddress("19-40116-1@student.aiub.edu");
            mail.Subject = "Your  account is recommanded by Mentor";
            string Body = "Hello " + obj.Name + "<br/>Your created by our mentor ";

            mail.Body = Body;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new System.Net.NetworkCredential("19-40116-1@student.aiub.edu", "aleX@monaf 32");
            smtp.EnableSsl = true;
            smtp.Send(mail);
            return true;

        }

        public bool Delete(int id)
        {
            var data = (from i in db.Students where i.Id == id select i).FirstOrDefault();
            db.Students.Remove(data);
            db.SaveChanges();
            return true;
        }

        public List<Student> Get()
        {
            return db.Students.ToList();
        }

        public Student GetId(int id)
        {
            return db.Students.FirstOrDefault(i => i.Id == id);
        }

        public bool Update(Student obj)
        {
            var data = (from i in db.Students where i.Id == obj.Id select i).FirstOrDefault();
            db.Entry(data).CurrentValues.SetValues(obj);
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
using Data_Access_Layer.Entity_Framework;
using Data_Access_Layer.Interfaces;
using Data_Access_Layer.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DataAccess
    {
        static Education_Platform_Final_TermEntities db = new Education_Platform_Final_TermEntities();

        public static IRepo<Admin, int> GetAdminDataAccess()
        {
            
            return new AdminRepo(db);
        }

        public static IRepo<Institution,int> GetInstitutionDataAccess()
        {
            return new InstitutionRepo(db);
        }

        public static IRepo<ValidStudent, int> GetValidStudentDataAccess()
        {
            return new ValidStudentRepo(db);
        }

        public static IRepo<Mentor, int> GetMentorDataAccess()
        {

            return new MentorRepo(db);
        }
        public static IRepo<Student, int> GetStudentDataAccess()
        {

            return new StudentRepo(db);
        }
        public static IRepo<Assignment, int> GetAssignmentDataAccess()
        {

            return new AssignmentRepo(db);
        }
        
      
        public static IRepo<Notice, int> GetNoticeDataAccess()
        {
            return new NoticeRepo(db);
        }

        public static IRepo<Cours, int> GetCourseDataAccess()
        {
            return new CourseRepo(db);
        }
    }
}

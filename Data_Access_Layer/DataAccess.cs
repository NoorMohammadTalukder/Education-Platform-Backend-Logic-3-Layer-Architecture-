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

        public static IRepo<Transaction, int> GetTransactionDataAccess()
        {
            return new TransactionRepo(db);
        }

       

        public static IRepo<PasswordChangeRequest, int> GetPasswordChangeRequestDataAccess()
        {
            return new PasswordChangeRequestRepo(db);
        }

        public static IAdminAuth GetAdminTokenDataAccess()
        {
            return new AdminTokenRepo(db);
        }

        public static IUserActivateDeactivateApprove GetActivateDeactivateDataAccess()
        {
            return new ActivateDeactivateUserRepo(db);
        }

      
        public static IRepo<Result, int> GetResultDataAccess()
        {
            return new ResultRepo(db);
        }

       
        public static IInstitutionAuth GetInstitutionTokenDataAccess()
        {
            return new InstitutionTokenRepo(db);
        }

      
        public static IRepo<Counseling, int> GetCounselingDataAccess()
        {
            return new CounselingRepo(db);
        }
        public static IRepo<Reviewstudent, int> GetReviewstudentDataAccess()
        {
            return new ReviewStudentRepo(db);
        }
        public static IRepo<Rating, int> GetRatingDataAccess()
        {
            return new RatingsRepo(db);
        }
        public static IRepo<Certificate, int> GetCertificateDataAccess()
        {
            return new CertificateRepo(db);
        }
        
        public static IRepo<AnswerScript, int> GetAnswerScriptDataAccess()
        {
            return new AnswerScriptRepo(db);
        }
        public static IRepo<CourseModule, int> GetCourseModuleDataAccess()
        {
            return new CourseModuleRepo(db);
        }
        public static IMentorAuth GetMentorTokenDataAccess()
        {
            return new MentorTokenRepo(db);
        }

        //-------------------------------------------------
        public static IRepoS<Student, int, bool> SGetStudentDataAccess()
        {

            return new student(db);
        }
        public static IRepoS<Counseling, int, bool> SGetCounselingDataAccess()
        {

            return new SCounselingRepo(db);
        }
        public static IRepoS<Transaction, int, bool> SGetTransactionDataAccess()
        {

            return new STransactionRepo(db);
        }
        public static IRepoS<CourseModule, int, bool> SGetCourseModuleDataAccess()
        {

            return new SCourseM(db);
        }
        public static IRepoS<Cours, int, bool> SGetCourseDataAccess()
        {

            return new ScourseRepo(db);
        }
        public static IRepoS<Token, string, Token> SGetTokenDataAccess()
        {
            return new STokenRepo(db);
        }
        public static IRepoS<Student, string, bool> SGetUserDataAccess()
        {
            return new SUserRepo(db);
        }
        public static IAuth<Student> SGetAuthDataAccess()
        {
            return new SUserRepo(db);
        }
    }
}

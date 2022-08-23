using AutoMapper;
using Business_Logic_Layer.BOs;
using Data_Access_Layer;
using Data_Access_Layer.Entity_Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic_Layer.Services
{
    public class MentorService
    {
        public static bool Create(MentorModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MentorModel, Mentor>())).Map<Mentor>(obj);
            try
            {
                DataAccess.GetMentorDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<MentorModel> GetAllMentor()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Mentor, MentorModel>())).Map<List<MentorModel>>(DataAccess.GetMentorDataAccess().Get());
            return data;

        }
        public static bool Update(MentorModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MentorModel, Mentor>())).Map<Mentor>(obj);
            try
            {
                DataAccess.GetMentorDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }

            //  var mentor = new Mentor();
            //  mentor.Name=obj.Name;
            //  mentor.Address = obj.Address;
            //  mentor.Email = obj.Email;
            //   mentor.Phone = obj.Phone;
            //  mentor.Password = obj.Password;

            //  mentor.Gender=obj.Gender;
            // mentor.Institution = obj.Institution;

            // return DataAccess.GetMentorDataAccess().Update(mentor);
        }
        public static MentorModel Get(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Mentor, MentorModel>())).Map<MentorModel>(DataAccess.GetMentorDataAccess().GetId(id));
            return data;
        }
        public static bool Delete(int id)
        {
            try
            {
                DataAccess.GetMentorDataAccess().Delete(id);
                return true;
            }
            catch
            {

                return false;
            }
        }
        public static bool StudentCreate(StudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>())).Map<Student>(obj);
            try
            {
                DataAccess.GetStudentDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static StudentModel GetStudentonly(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentModel>())).Map<StudentModel>(DataAccess.GetStudentDataAccess().GetId(id));
            return data;

        }
        public static bool StudentDelete(int id)
        {
            try
            {
                DataAccess.GetStudentDataAccess().Delete(id);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public static bool StudentUpdate(StudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>())).Map<Student>(obj);
            try
            {
                DataAccess.GetStudentDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Assignment Entities


        public static bool AssignmentCreate(AssignmentModel obj, string fg)
        {
            var mentorId = int.Parse(fg);
            obj.MentorId = mentorId;
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AssignmentModel, Assignment>())).Map<Assignment>(obj);
            try
            {
                DataAccess.GetAssignmentDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static AssignmentModel GetAssignmentonly(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Assignment, AssignmentModel>())).Map<AssignmentModel>(DataAccess.GetAssignmentDataAccess().GetId(id));
            return data;

        }
        public static bool AssignmentUpdate(AssignmentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AssignmentModel, Assignment>())).Map<Assignment>(obj);
            try
            {
                DataAccess.GetAssignmentDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool AssignmentDelete(int id)
        {
            try
            {
                DataAccess.GetAssignmentDataAccess().Delete(id);
                return true;
            }
            catch
            {

                return false;
            }
        }
        //Notice
        public static bool NoticeCreate(NoticeModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<NoticeModel, Notice>())).Map<Notice>(obj);
            try
            {
                DataAccess.GetNoticeDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static NoticeModel GetNoticeonly(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Notice, NoticeModel>())).Map<NoticeModel>(DataAccess.GetAssignmentDataAccess().GetId(id));
            return data;

        }
        public static bool NoticeUpdate(NoticeModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<NoticeModel, Notice>())).Map<Notice>(obj);
            try
            {
                DataAccess.GetNoticeDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<NoticeModel> GetAllNotice()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Notice, NoticeModel>())).Map<List<NoticeModel>>(DataAccess.GetNoticeDataAccess().Get());
            return data;

        }
        //Counseling

        public static bool CounselingCreate(CounselingModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CounselingModel, Counseling>())).Map<Counseling>(obj);
            try
            {
                DataAccess.GetCounselingDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static CounselingModel GetCounselingeonly(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Counseling, CounselingModel>())).Map<CounselingModel>(DataAccess.GetCounselingDataAccess().GetId(id));
            return data;

        }
        public static List<CounselingModel> GetAllCounseling()
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Counseling, CounselingModel>())).Map<List<CounselingModel>>(DataAccess.GetNoticeDataAccess().Get());
            return data;

        }
        public static bool CounselingUpdate(CounselingModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CounselingModel, Counseling>())).Map<Counseling>(obj);
            try
            {
                DataAccess.GetCounselingDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //ReviewStudents

        public static bool ReviewStudentCreate(ReviewStudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReviewStudentModel, Reviewstudent>())).Map<Reviewstudent>(obj);
            try
            {
                DataAccess.GetReviewstudentDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static List<ReviewStudentModel> GetAllStudentsReview()
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Reviewstudent, ReviewStudentModel>())).Map<List<ReviewStudentModel>>(DataAccess.GetReviewstudentDataAccess().Get());
            return data;

        }
        public static ReviewStudentModel GetSingleStudentsReview(int id)
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Reviewstudent, ReviewStudentModel>())).Map<ReviewStudentModel>(DataAccess.GetReviewstudentDataAccess().GetId(id));
            return data;

        }
        public static bool StudentReviewUpdate(ReviewStudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ReviewStudentModel, Reviewstudent>())).Map<Reviewstudent>(obj);
            try
            {
                DataAccess.GetReviewstudentDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //ViewRating
        public static ViewRatingModel GetSingleRating(int id)
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Rating, ViewRatingModel>())).Map<ViewRatingModel>(DataAccess.GetRatingDataAccess().GetId(id));
            return data;

        }

        public static List<ViewRatingModel> GetAllRatings()
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Rating, ViewRatingModel>())).Map<List<ViewRatingModel>>(DataAccess.GetRatingDataAccess().Get());
            return data;

        }

        //Recomand Certificate
        public static bool CertificateCreate(CertificateModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CertificateModel, Certificate>())).Map<Certificate>(obj);
            try
            {
                DataAccess.GetCertificateDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool CertificateUpdate(CertificateModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CertificateModel, Certificate>())).Map<Certificate>(obj);
            try
            {
                DataAccess.GetCertificateDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }


        //Post Result
        public static bool ResultCreate(ResultModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ResultModel, Result>())).Map<Result>(obj);
            try
            {
                DataAccess.GetResultDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<ResultModel> GetAllStudentsResult()
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Result, ResultModel>())).Map<List<ResultModel>>(DataAccess.GetResultDataAccess().Get());
            return data;

        }
        public static ResultModel GetSingleStudentsResult(int id)
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Result, ResultModel>())).Map<ResultModel>(DataAccess.GetResultDataAccess().GetId(id));
            return data;

        }

        public static bool ResultDelete(int id)
        {
            try
            {
                DataAccess.GetResultDataAccess().Delete(id);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public static bool ResultUpdate(ResultModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ResultModel, Result>())).Map<Result>(obj);
            try
            {
                DataAccess.GetResultDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static AnswerScriptModel GetSingleAnswerScript(int id)
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AnswerScript, AnswerScriptModel>())).Map<AnswerScriptModel>(DataAccess.GetAnswerScriptDataAccess().GetId(id));
            return data;

        }

        public static List<AnswerScriptModel> GetAllAnswerScript()
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AnswerScript, AnswerScriptModel>())).Map<List<AnswerScriptModel>>(DataAccess.GetAnswerScriptDataAccess().Get());
            return data;

        }

        /////////////////////////////////////////////


        public static bool CourseModuleCreate(CourseModuleModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CourseModuleModel, CourseModule>())).Map<CourseModule>(obj);
            try
            {
                DataAccess.GetCourseModuleDataAccess().Create(data);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<CourseModuleModel> GetAllCourseModule()
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CourseModule, CourseModuleModel>())).Map<List<CourseModuleModel>>(DataAccess.GetCourseModuleDataAccess().Get());
            return data;

        }
        public static CourseModuleModel GetSingleCourseModule(int id)
        {

            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CourseModule, CourseModuleModel>())).Map<CourseModuleModel>(DataAccess.GetCourseModuleDataAccess().GetId(id));
            return data;

        }

        public static bool CourseModuleDelete(int id)
        {
            try
            {
                DataAccess.GetCourseModuleDataAccess().Delete(id);
                return true;
            }
            catch
            {

                return false;
            }
        }

        public static bool CourseModuleUpdate(CourseModuleModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CourseModuleModel, CourseModule>())).Map<CourseModule>(obj);
            try
            {
                DataAccess.GetCourseModuleDataAccess().Update(data);
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
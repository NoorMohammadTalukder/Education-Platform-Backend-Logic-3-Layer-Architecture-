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
    public class InstitutionService
    {
        public static List<InstitutionModel> GetInstitution()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Institution, InstitutionModel>())).Map<List<InstitutionModel>>(DataAccess.GetInstitutionDataAccess().Get());
            return data;
        }
        public static InstitutionModel GetSingleInstitution(int id)
        {
            var config = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Institution, InstitutionModel>()));
            var data = config.Map<InstitutionModel>(DataAccess.GetInstitutionDataAccess().GetId(id));
            return data;
        }
        public static bool CreateInstitution(InstitutionModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<InstitutionModel, Institution>())).Map<Institution>(obj);
            // var data = config.Map<Institution>(obj);

            try
            {
                DataAccess.GetInstitutionDataAccess().Create(data);

                return true;

            }
            catch
            {
                return false;
            }

        }
        public static bool UpdateInstitution(InstitutionModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<InstitutionModel, Institution>())).Map<Institution>(obj);
            // var data = config.Map<Institution>(obj);

            try
            {
                DataAccess.GetInstitutionDataAccess().Update(data);

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteInstitution(int id)
        {
            DataAccess.GetInstitutionDataAccess().Delete(id);
            return true;
        }
        /* Mentor services-------
       * ---------------
       * ---------------*/
        public static bool CreateMentor(MentorModel obj)
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
        public static bool UpdateMentor(MentorModel obj)
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


        }
        public static MentorModel GetSingleMentor(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Mentor, MentorModel>())).Map<MentorModel>(DataAccess.GetMentorDataAccess().GetId(id));
            return data;
        }
        public static bool DeleteMentor(int id)
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

        /* Notice Services-------
     * ---------------
     * ---------------*/

        public static bool CreateNotice(NoticeModel obj)
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
        public static List<NoticeModel> GetAllNotice()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Notice, NoticeModel>())).Map<List<NoticeModel>>(DataAccess.GetNoticeDataAccess().Get());
            return data;

        }
        public static bool UpdateNotice(NoticeModel obj)
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
        public static NoticeModel GetSingleNotice(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Notice, NoticeModel>())).Map<NoticeModel>(DataAccess.GetNoticeDataAccess().GetId(id));
            return data;
        }
        public static bool DeleteNotice(int id)
        {
            try
            {
                DataAccess.GetNoticeDataAccess().Delete(id);
                return true;
            }
            catch
            {

                return false;
            }
        }

        /* ----------------Course services---------------
     ***********************---------------
     *************************** ---------------*/

        public static List<CourseModel> GetCourse()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Cours, CourseModel>())).Map<List<CourseModel>>(DataAccess.GetCourseDataAccess().Get());
            return data;
        }
        public static CourseModel GetSingleCourse(int id)
        {
            var config = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Cours, CourseModel>()));
            var data = config.Map<CourseModel>(DataAccess.GetCourseDataAccess().GetId(id));
            return data;
        }
        public static bool CreateCourse(CourseModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CourseModel, Cours>())).Map<Cours>(obj);
            // var data = config.Map<Institution>(obj);

            try
            {
                DataAccess.GetCourseDataAccess().Create(data);

                return true;

            }
            catch
            {
                return false;
            }

        }
        public static bool UpdateCourse(CourseModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<CourseModel, Cours>())).Map<Cours>(obj);
            // var data = config.Map<Institution>(obj);

            try
            {
                DataAccess.GetCourseDataAccess().Update(data);

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteCourse(int id)
        {
            DataAccess.GetCourseDataAccess().Delete(id);
            return true;
        }


        /* ----------------Result services---------------
     ***********************---------------
     *************************** ---------------*/

        public static List<ResultModel> GetResult()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Result, ResultModel>())).Map<List<ResultModel>>(DataAccess.GetResultDataAccess().Get());
            return data;
        }

        public static ResultModel GetSingleResult(int id)
        {
            var config = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Result, ResultModel>()));
            var data = config.Map<ResultModel>(DataAccess.GetResultDataAccess().GetId(id));
            return data;
        }

        public static bool CreateResult(ResultModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ResultModel, Result>())).Map<Result>(obj);
            // var data = config.Map<Institution>(obj);

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
        public static bool UpdateResult(ResultModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ResultModel, Result>())).Map<Result>(obj);
            // var data = config.Map<Institution>(obj);

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

        public static bool DeleteResult(int id)
        {
            DataAccess.GetResultDataAccess().Delete(id);
            return true;
        }

        /* ----------------Transaction services---------------
   ***********************---------------
   *************************** ---------------*/
        public static List<TransactionModel> GetTransaction()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Transaction, TransactionModel>())).Map<List<TransactionModel>>(DataAccess.GetTransactionDataAccess().Get());
            return data;
        }

        public static TransactionModel GetSingleTransaction(int id)
        {
            var config = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Transaction, TransactionModel>()));
            var data = config.Map<TransactionModel>(DataAccess.GetTransactionDataAccess().GetId(id));
            return data;
        }

    }
}
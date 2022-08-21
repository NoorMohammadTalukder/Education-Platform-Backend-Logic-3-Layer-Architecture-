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
    public class AdminService
    {

       /*
        public static List<AdminModel> Get1()
        {
            var data = DataAccess.GetAdminDataAccess().Get();
            var rdata = new List<AdminModel>();
            foreach (var item in data)
            {
                rdata.Add(new AdminModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                   
                });
            }
            return rdata;
        }
       */

        public static List<AdminModel> Get()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>())).Map<List<AdminModel>>(DataAccess.GetAdminDataAccess().Get());
            return data;
        }

        public static AdminModel GetId(int id)
        {
            var config = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Admin, AdminModel>()));
            var data = config.Map<AdminModel>(DataAccess.GetAdminDataAccess().GetId(id));
            return data;
        }

        public static bool Create(AdminModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(obj);
           // var data = config.Map<Admin>(obj);

            try
            {
                DataAccess.GetAdminDataAccess().Create(data);

                return true;
                
            }
            catch
            {
                return false;
            }
            
        }

        public static bool Update(AdminModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(obj);
            // var data = config.Map<Admin>(obj);

            try
            {
                DataAccess.GetAdminDataAccess().Update(data);

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool Delete(int id)
        {
            DataAccess.GetAdminDataAccess().Delete(id);
            return true;
        }


        //-----------------------------------------------------------
        //------------------Institution Work Started-----------------
        //-----------------------------------------------------------

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
            //var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(obj);
            // var data = config.Map<Admin>(obj);
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<InstitutionModel, Institution>())).Map<Institution>(obj);

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


        //-----------------------------------------------------------
        //------------------Valid Student Work Started-----------------
        //-----------------------------------------------------------

        public static List<ValidStudentModel> GetValidStudent()
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ValidStudent, ValidStudentModel>())).Map<List<ValidStudentModel>>(DataAccess.GetValidStudentDataAccess().Get());
            return data;
        }

        public static ValidStudentModel GetSingleValidStudent(int id)
        {
            var config = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ValidStudent, ValidStudentModel>()));
            var data = config.Map<ValidStudentModel>(DataAccess.GetValidStudentDataAccess().GetId(id));
            return data;
        }

        public static bool CreateValidStudent(ValidStudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ValidStudentModel, ValidStudent>())).Map<ValidStudent>(obj);


            try
            {
                DataAccess.GetValidStudentDataAccess().Create(data);

                return true;

            }
            catch
            {
                return false;
            }

        }

        public static bool UpdateValidStudent(ValidStudentModel obj)
        {
            
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<ValidStudentModel, ValidStudent > ())).Map<ValidStudent>(obj);

            try
            {
                DataAccess.GetValidStudentDataAccess().Update(data);

                return true;

            }
            catch
            {
                return false;
            }
        }

        public static bool DeleteValidStudent(int id)
        {
            DataAccess.GetValidStudentDataAccess().Delete(id);
            return true;
        }

        //-----------------------------------------------------------
        //------------------Courses Work Started-----------------
        //-----------------------------------------------------------
        public static List<CourseModel> GetCourses()
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
            var data = new Mapper(new MapperConfiguration
                (cfg => cfg.CreateMap<CourseModel, Cours>())).Map<Cours>(obj);


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


        //-----------------------------------------------------------
        //------------------Mentor Work Started-----------------
        //-----------------------------------------------------------

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
        public static List<MentorModel> GetMentors()
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
            DataAccess.GetMentorDataAccess().Delete(id);
            return true;
        }

        //-----------------------------------------------------------
        //------------------Student Work Started-----------------
        //-----------------------------------------------------------

        public static bool StudentCreate(StudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>())).Map<Student>(obj);

            DataAccess.GetStudentDataAccess().Create(data);
            return true;

        }
        public static List<StudentModel> GetStudents()
        {
            var data = new Mapper(new MapperConfiguration
                (cfg => cfg.CreateMap<Student, StudentModel>())).Map<List<StudentModel>>(DataAccess.GetStudentDataAccess().Get());
            return data;

        }

        public static StudentModel SingleStudent(int id)
        {
            var data = new Mapper(new MapperConfiguration
                (cfg => cfg.CreateMap<Student, StudentModel>())).Map<StudentModel>(DataAccess.GetStudentDataAccess().GetId(id));
            return data;

        }
        public static bool DeleteStudent(int id)
        {

            DataAccess.GetStudentDataAccess().Delete(id);
            return true;


        }
        public static bool UpdateStudent(StudentModel obj)
        {
            var data = new Mapper
                (new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>())).Map<Student>(obj);

            DataAccess.GetStudentDataAccess().Update(data);
            return true;


        }

        //-----------------------------------------------------------
        //------------------Transaction Work Started-----------------
        //-----------------------------------------------------------
        public static List<TransactionModel> GetTransactions()
        {
            var data = new Mapper(new MapperConfiguration
                (cfg => cfg.CreateMap<Transaction, TransactionModel>())).Map<List<TransactionModel>>(DataAccess.GetTransactionDataAccess().Get());
            return data;

        }

        //-----------------------------------------------------------
        //------------------Revenue Work Started-----------------
        //-----------------------------------------------------------
        public static List<string> GetRevenue()
        {
            var data = new Mapper(new MapperConfiguration
                (cfg => cfg.CreateMap<Transaction, TransactionModel>())).Map<List<TransactionModel>>(DataAccess.GetTransactionDataAccess().Get());

            var sellingAmount = (from i in data
                                 where (i.Id > 0)
                                 select i.CreditedAmount).Sum();
            var myEarning = 0.6 * sellingAmount;
            var varsityEarning = 0.4 * sellingAmount;

            var x = new List<string>()
                   
                    {
                    sellingAmount.ToString(),
                    myEarning.ToString(),
                    varsityEarning.ToString(),

                    };
            
                 
            return x;
        }

        //-----------------------------------------------------------
        //------------------Search Work Started-----------------
        //-----------------------------------------------------------

        //Student

        public static List<StudentModel> StudentSearch (string search)
        {
            var data = new Mapper(new MapperConfiguration
                 (cfg => cfg.CreateMap<Student, StudentModel>())).Map<List<StudentModel>>(DataAccess.GetStudentDataAccess().Get());

            var searchResult = (from i in data
                                where i.Name.Contains(search) || i.Email.Contains(search)

                                select i).ToList();
            return searchResult;

        }

        //Mentor

        public static List<MentorModel> MentorSearch(string search)
        {
            var data = new Mapper(new MapperConfiguration
                 (cfg => cfg.CreateMap<Mentor, MentorModel>())).Map<List<MentorModel>>(DataAccess.GetMentorDataAccess().Get());

            var searchResult = (from i in data
                                where i.Name.Contains(search) || i.Email.Contains(search)

                                select i).ToList();
            return searchResult;

        }

        //Institution

        public static List<InstitutionModel> InstitutionSearch(string search)
        {
            var data = new Mapper(new MapperConfiguration
                 (cfg => cfg.CreateMap<Institution, InstitutionModel>())).Map<List<InstitutionModel>>(DataAccess.GetInstitutionDataAccess().Get());

            var searchResult = (from i in data
                                where i.Name.Contains(search) || i.Email.Contains(search)

                                select i).ToList();
            return searchResult;

        }

        //-----------------------------------------------------------
        //------------------Password Request Work Started-----------------
        //-----------------------------------------------------------

        public static List<PasswordChangeRequestModel> GetPasswordRequests()
        {
            var data = new Mapper(new MapperConfiguration
                (cfg => cfg.CreateMap<PasswordChangeRequest, PasswordChangeRequestModel>())).Map<List<PasswordChangeRequestModel>>(DataAccess.GetPasswordChangeRequestDataAccess().Get());
            return data;

        }




    }
}

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


        public static bool AssignmentCreate(AssignmentModel obj)
        {
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
    }
}
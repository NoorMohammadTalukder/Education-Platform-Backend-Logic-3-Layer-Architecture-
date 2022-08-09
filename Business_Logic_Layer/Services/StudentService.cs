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
    public class StudentService
    {
        public static bool StudentCreate(StudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>())).Map<Student>(obj);
            
                DataAccess.GetStudentDataAccess().Create(data);
                return true;
          
        }

        public static StudentModel SingleStudent(int id)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<Student, StudentModel>())).Map<StudentModel>(DataAccess.GetStudentDataAccess().GetId(id));
            return data;

        }
        public static bool DeleteStudent(int id)
        {
            
                DataAccess.GetStudentDataAccess().Delete(id);
                return true;
           
          
        }
        public static bool UpdateStudent(StudentModel obj)
        {
            var data = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<StudentModel, Student>())).Map<Student>(obj);
            
                DataAccess.GetStudentDataAccess().Update(data);
                return true;
            
           
        }
    }
}

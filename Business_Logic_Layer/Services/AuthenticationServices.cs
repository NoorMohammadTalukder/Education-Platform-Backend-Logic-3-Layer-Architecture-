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
    public class AuthenticationServices
    {
        //-------------------------------------Admin-----------------------------------
        public static AdminTokenModel Auth(AdminModel user)
        {
            var dbuser = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminModel, Admin>())).Map<Admin>(user);
            var createToken = DataAccess.GetAdminTokenDataAccess().Authenticate(dbuser);
            var returnToken = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<AdminToken, AdminTokenModel>())).Map<AdminTokenModel>(createToken);
            return returnToken;
        }

        public static bool CheckValidityToken(string token)
        {
            var x = DataAccess.GetAdminTokenDataAccess().IsAuthenticated(token);
            return x;
        }

        public static bool Logout(string token)
        {
            return DataAccess.GetAdminTokenDataAccess().Logout(token);
        }
        //---------------------Institution Work Started-------------------------
        public static InstitutionTokenModel InstitutionAuth(InstitutionModel user)
        {
            var dbuser = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<InstitutionModel, Institution>())).Map<Institution>(user);
            var createToken = DataAccess.GetInstitutionTokenDataAccess().Authenticate(dbuser);
            var returnToken = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<InstitutionToken, InstitutionTokenModel>())).Map<InstitutionTokenModel>(createToken);
            return returnToken;
        }

        public static bool InstitutionCheckValidityToken(string token)
        {
            var x = DataAccess.GetInstitutionTokenDataAccess().IsAuthenticated(token);
            return x;
        }

        public static bool InstitutionLogout(string token)
        {
            return DataAccess.GetInstitutionTokenDataAccess().Logout(token);
        }

        //---------------------------Mentor-------------------------------------------------
        public static MentorTokenModel MentorAuth(MentorModel user)
        {
            var dbuser = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MentorModel, Mentor>())).Map<Mentor>(user);
            var createToken = DataAccess.GetMentorTokenDataAccess().Authenticate(dbuser);
            var returnToken = new Mapper(new MapperConfiguration(cfg => cfg.CreateMap<MentorToken, MentorTokenModel>())).Map<MentorTokenModel>(createToken);
            return returnToken;

        }
        public static bool MentorLogout(string token)
        {
            return DataAccess.GetMentorTokenDataAccess().Logout(token);
        }
    }
}

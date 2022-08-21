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
    }
}

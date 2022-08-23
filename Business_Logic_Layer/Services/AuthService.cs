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
    public class AuthService
    {
        public static TokenModel Authenticate(string email, string pass)
        {
            var user = DataAccess.SGetAuthDataAccess().Authenticate(email, pass);
            TokenModel t = null;
            if (user != null)
            {
                var key = GenToken();
                Token token = new Token();
                token.TokenKey = key;
                token.UserId = user.Id;
                token.CreatedAt = DateTime.Now;
                var created_token = DataAccess.SGetTokenDataAccess().Create(token);
                t = new TokenModel()
                {
                    Id = created_token.Id,
                    TokenKey = created_token.TokenKey,
                    CreatedAt = (DateTime)created_token.CreatedAt,
                    UserId = (int)created_token.UserId,
                    ExpiredAt = created_token.ExpiredAt
                };


            }
            return t;
        }
        public static string GenToken()
        {
            Random res = new Random();

            // String of alphabets 
            String str = "abcdefghijklmnopqrstuvwxyz";
            int size = 40;

            // Initializing the empty string
            String ran = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly
                int x = res.Next(26);

                // Appending the character at the 
                // index to the random string.
                ran = ran + str[x];
            }
            return ran;
        }
        public static bool TokenValidity(string token)
        {
            var tk = DataAccess.SGetTokenDataAccess().GetId(token);
            if (tk != null && tk.ExpiredAt == null)
            {
                return true;
            }
            return false;

        }
        public static bool Logout(TokenModel tk)
        {
            var d_tk = DataAccess.SGetTokenDataAccess().GetId(tk.TokenKey);
            d_tk.ExpiredAt = DateTime.Now;
            return DataAccess.SGetTokenDataAccess().Update(d_tk);

        }
    }
}
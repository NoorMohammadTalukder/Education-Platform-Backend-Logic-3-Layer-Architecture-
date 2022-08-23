using Business_Logic_Layer.BOs;
using Business_Logic_Layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Education_Platform_Backend_Logic.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AuthenticationController : ApiController
    {
        //------------------Admin-------------------
        [Route("api/admin/login")]
        [HttpPost]
        public HttpResponseMessage Auth(AdminModel user)
        {
            var data = AuthenticationServices.Auth(user);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }

        [Route("api/admin/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AuthenticationServices.Logout(token);
                if (rs)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, "Logout Successful");
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Logout Not Successful");
        }


        //------------------------Institution------------------------------------
        [Route("api/Institution/Login")]
        [HttpPost]
        public HttpResponseMessage InstitutionAuth(InstitutionModel user)
        {
            var data = AuthenticationServices.InstitutionAuth(user);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "user not found");
        }

        [Route("api/Institution/Logout")]
        [HttpGet]
        public HttpResponseMessage InstitutionLogout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AuthenticationServices.InstitutionLogout(token);
                if (rs)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, "sucessfull");
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, false);
        }

        //---------------------Mentor------------------------------------------
        [Route("api/mentor/login")]
        [HttpPost]
        public HttpResponseMessage MentorAuth(MentorModel user)
        {
            var data = AuthenticationServices.MentorAuth(user);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }

            return Request.CreateResponse(HttpStatusCode.NotFound, "user the pro");
        }

        [Route("api/mentor/logout")]
        [HttpGet]
        public HttpResponseMessage MentorLogout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AuthenticationServices.MentorLogout(token);
                if (rs)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.OK, "sucessfull");
                }

            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "something went wrong");
        }
    }
}

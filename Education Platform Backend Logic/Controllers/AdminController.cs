using Business_Logic_Layer.BOs;
using Business_Logic_Layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Education_Platform_Backend_Logic.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/all/admin")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/single/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage GetId(int id)
        {
            var data = AdminService.GetId(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/add/admin")]
        [HttpPost]
        public HttpResponseMessage Create(AdminModel obj)
        {
            bool data = AdminService.Create(obj);
            return Request.CreateResponse(data ? true: false);

        }

        [Route("api/update/admin")]
        [HttpPost]
        public HttpResponseMessage Update(AdminModel obj)
        {
            bool data = AdminService.Update(obj);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/delete/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            bool data = AdminService.Delete(id);
            return Request.CreateResponse(data ? true : false);

        }

        //-----------------------------------------------------------
        //------------------Institution Work Started-----------------
        //-----------------------------------------------------------
        
        [Route("api/admin/all/institution")]
        [HttpGet]
        public HttpResponseMessage GetInstution()
        {
            var data = AdminService.GetInstitution();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}

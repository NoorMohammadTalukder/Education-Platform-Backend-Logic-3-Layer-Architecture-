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

        [Route("api/admin/single/institution/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleInstitution(int id)
        {
            var data = AdminService.GetSingleInstitution(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/add/institution")]
        [HttpPost]
        public HttpResponseMessage CreateInstitution(InstitutionModel obj)
        {
            bool data = AdminService.CreateInstitution(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/admin/update/institution")]
        [HttpPost]
        public HttpResponseMessage UpdateInstitution(InstitutionModel obj)
        {
            bool data = AdminService.UpdateInstitution(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/admin/delete/Institution/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteInstitution(int id)
        {
            bool data = AdminService.DeleteInstitution(id);
            return Request.CreateResponse(data ? true : false);

        }


        //-----------------------------------------------------------
        //------------------Valid Student Work Started-----------------
        //-----------------------------------------------------------

        [Route("api/admin/all/validStudent")]
        [HttpGet]
        public HttpResponseMessage GetValidStudent()
        {
            var data = AdminService.GetValidStudent();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/single/validStudent/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleValidStudent(int id)
        {
            var data = AdminService.GetSingleValidStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/add/validStudent")]
        [HttpPost]
        public HttpResponseMessage CreateValidStudent(ValidStudentModel obj)
        {
            bool data = AdminService.CreateValidStudent(obj);
            return Request.CreateResponse(data ? true : false);

        }


        [Route("api/admin/update/validStudent")]
        [HttpPost]
        public HttpResponseMessage UpdateValidStudent(ValidStudentModel obj)
        {
            bool data = AdminService.UpdateValidStudent(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/admin/delete/validStudent/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteValidStudent(int id)
        {
            bool data = AdminService.DeleteValidStudent(id);
            return Request.CreateResponse(data ? true : false);

        }
    }
}

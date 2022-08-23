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
    public class studentController : ApiController
    {
        [Route("api/student")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = studentService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/student/create")]
        [HttpPost]
        public HttpResponseMessage Create(StudentModel st)
        {
            var data = studentService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }

        [Route("api/user/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = studentService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
    }
}
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
    public class CourseController : ApiController
    {
        [Route("api/course")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = courseService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/course/create")]
        [HttpPost]
        public HttpResponseMessage Create(CourseModel st)
        {
            var data = courseService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }

        [Route("api/course/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = courseService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
    }
}
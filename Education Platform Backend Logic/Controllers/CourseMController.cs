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
    public class CourseMController : ApiController
    {
        [Route("api/courseM")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CourseMServic.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/courseM/create")]
        [HttpPost]
        public HttpResponseMessage Create(CourseMModel st)
        {
            var data = CourseMServic.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }

        [Route("api/courseM/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = CourseMServic.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
    }
}
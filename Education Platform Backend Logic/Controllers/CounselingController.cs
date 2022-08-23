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
    public class CounselingController : ApiController
    {
        [Route("api/counseling")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = CounselingService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/counseling/create")]
        [HttpPost]
        public HttpResponseMessage Create(CounselingModel st)
        {
            var data = CounselingService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }

        [Route("api/counseling/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = CounselingService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
    }
}
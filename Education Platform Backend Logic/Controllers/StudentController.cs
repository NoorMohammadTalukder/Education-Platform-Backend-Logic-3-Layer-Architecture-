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
    public class StudentController : ApiController
    {
     
        [Route("api/student/{id}")]
        [HttpGet]
        public HttpResponseMessage GetStudentonly(int id)
        {
            var data = StudentService.SingleStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/createstudent")]
        [HttpPost]
        public HttpResponseMessage StudentCreate(StudentModel obj)
        {
            var data = StudentService.StudentCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/updatestudent")]
        [HttpPost]
        public HttpResponseMessage StudentUpdate(StudentModel obj)
        {
            var data = StudentService.UpdateStudent(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/deletestudent/{id}")]
        [HttpPost]
        public HttpResponseMessage StudentDelete(int id)
        {
            var data = StudentService.DeleteStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
       
    }
}

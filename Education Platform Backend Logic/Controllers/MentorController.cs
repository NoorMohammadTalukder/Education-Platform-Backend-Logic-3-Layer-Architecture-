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
    //Mentor Entities
    public class MentorController : ApiController
    {
        [Route("api/mentorcreate")]
        [HttpPost]
        public HttpResponseMessage Create(MentorModel obj)
        {
            var data = MentorService.Create(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/mentorlist")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = MentorService.GetAllMentor();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/mentorinfo/{id}")]
        [HttpGet]
        public HttpResponseMessage Getonly(int id)
        {
            var data = MentorService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/mentorupdate")]
        [HttpPost]
        public HttpResponseMessage Update(MentorModel obj)
        {
            var data = MentorService.Update(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/mentordelete/{id}")]
        [HttpPost]
        public HttpResponseMessage Delete(int id)
        {
            var data = MentorService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //Student Entities
        [Route("api/studentcreate")]
        [HttpPost]
        public HttpResponseMessage StudentCreate(StudentModel obj)
        {
            var data = MentorService.StudentCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/studentinfo/{id}")]
        [HttpGet]
        public HttpResponseMessage GetStudentonly(int id)
        {
            var data = MentorService.GetStudentonly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/studentupdate")]
        [HttpPost]
        public HttpResponseMessage StudentUpdate(StudentModel obj)
        {
            var data = MentorService.StudentUpdate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/studentdelete/{id}")]
        [HttpPost]
        public HttpResponseMessage StudentDelete(int id)
        {
            var data = MentorService.StudentDelete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        // Assigment Entities

        [Route("api/assignmentcreate")]
        [HttpPost]
        public HttpResponseMessage AssignmentCreate(AssignmentModel obj)
        {
            var data = MentorService.AssignmentCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/assignmentinfo/{id}")]
        [HttpGet]
        public HttpResponseMessage GetAssignmentonly(int id)
        {
            var data = MentorService.GetAssignmentonly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/assignmentupdate")]
        [HttpPost]
        public HttpResponseMessage AssignmentUpdate(AssignmentModel obj)
        {
            var data = MentorService.AssignmentUpdate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/assignmentdelete/{id}")]
        [HttpPost]
        public HttpResponseMessage AssignmentDelete(int id)
        {
            var data = MentorService.AssignmentDelete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
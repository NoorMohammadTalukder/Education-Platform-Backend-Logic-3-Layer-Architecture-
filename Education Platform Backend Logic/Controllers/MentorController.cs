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

    //Mentor Entities
    public class MentorController : ApiController
    {
        [Route("api/mentorcreate")]
        [HttpPost]
        public HttpResponseMessage Create(MentorModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
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
            var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.AssignmentCreate(obj, fg);
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

        //Notice API
        [Route("api/noticecreate")]
        [HttpPost]
        public HttpResponseMessage NoticeCreate(NoticeModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.NoticeCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/noticeinfo/{id}")]
        [HttpGet]
        public HttpResponseMessage GetNoticeonly(int id)
        {
            var data = MentorService.GetNoticeonly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/noticeupdate")]
        [HttpPost]
        public HttpResponseMessage NoticeUpdate(NoticeModel obj)
        {
            var data = MentorService.NoticeUpdate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/noticelist")]
        [HttpGet]
        public HttpResponseMessage GetAllNotices()
        {
            var data = MentorService.GetAllNotice();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        // Counseling API

        [Route("api/counselingcreate")]
        [HttpPost]
        public HttpResponseMessage CounselingCreate(CounselingModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.CounselingCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/counselinginfo/{id}")]
        [HttpGet]
        public HttpResponseMessage GetCounselingeonly(int id)
        {
            var data = MentorService.GetCounselingeonly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/counselingupdate")]
        [HttpPost]
        public HttpResponseMessage CounselingUpdate(CounselingModel obj)
        {
            var data = MentorService.CounselingUpdate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/counsilinglist")]
        [HttpGet]
        public HttpResponseMessage GetAllCounseling()
        {
            var data = MentorService.GetAllCounseling();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }



        //ReviewStudent
        [Route("api/studentreviewcreate")]
        [HttpPost]
        public HttpResponseMessage StudentReviewCreate(ReviewStudentModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.ReviewStudentCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/reviewlist")]
        [HttpGet]
        public HttpResponseMessage GetAllStudentReview()
        {
            var data = MentorService.GetAllStudentsReview();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/singlereview/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleonly(int id)
        {
            var data = MentorService.GetSingleStudentsReview(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/studentreviewupdate")]
        [HttpPost]
        public HttpResponseMessage StudentReviewUpdate(ReviewStudentModel obj)
        {
            var data = MentorService.StudentReviewUpdate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        //ViewRatings
        [Route("api/ratinglist")]
        [HttpGet]
        public HttpResponseMessage GetAllRatings()
        {
            var data = MentorService.GetAllRatings();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/singlerating/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleRating(int id)
        {
            var data = MentorService.GetSingleRating(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }




        //Recomand Certificate

        [Route("api/certificatecreate")]
        [HttpPost]
        public HttpResponseMessage CertificateCreate(CertificateModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.CertificateCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/certificateupdate")]
        [HttpPost]
        public HttpResponseMessage CertificateUpdate(CertificateModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.CertificateCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //PostResult

        [Route("api/resultcreate")]
        [HttpPost]
        public HttpResponseMessage ResultCreate(ResultModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.ResultCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/Resultlist")]
        [HttpGet]
        public HttpResponseMessage GetAllResult()
        {
            var data = MentorService.GetAllStudentsResult();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/singlestudentresult/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleStudentResultonly(int id)
        {
            var data = MentorService.GetSingleStudentsResult(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/resultupdate")]
        [HttpPost]
        public HttpResponseMessage ResultUpdate(ResultModel obj)
        {
            var data = MentorService.ResultUpdate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/resultdelete/{id}")]
        [HttpPost]
        public HttpResponseMessage ResultDelete(int id)
        {
            var data = MentorService.ResultDelete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //AnswerScript
        [Route("api/answerscriptlist")]
        [HttpGet]
        public HttpResponseMessage GetAllAnswerScript()
        {
            var data = MentorService.GetAllAnswerScript();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/singleanswerscript/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleAnswerScript(int id)
        {
            var data = MentorService.GetSingleAnswerScript(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        //CourseModule

        [Route("api/coursemodulecreate")]
        [HttpPost]
        public HttpResponseMessage CourseModuleCreate(CourseModuleModel obj)
        {
            //  var fg = Request.Headers.GetValues("manu").SingleOrDefault().ToString();
            var data = MentorService.CourseModuleCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/coursemodulelist")]
        [HttpGet]
        public HttpResponseMessage GetAllCourseModule()
        {
            var data = MentorService.GetAllCourseModule();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/singlecoursemodule/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleCourseModule(int id)
        {
            var data = MentorService.GetSingleCourseModule(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/coursemoduleupdate")]
        [HttpPost]
        public HttpResponseMessage CourseModuleUpdate(CourseModuleModel obj)
        {
            var data = MentorService.CourseModuleUpdate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/coursemoduledelete/{id}")]
        [HttpPost]
        public HttpResponseMessage CourseModuleDelete(int id)
        {
            var data = MentorService.CourseModuleDelete(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


    }
}
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
    public class InstitutionController : ApiController
    {

        [Route("api/AllInstitution")]
        [HttpGet]
        public HttpResponseMessage GetInstitution()
        {
            var data = InstitutionService.GetInstitution();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/SingleInstitution/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleInstituion(int id)
        {
            var data = InstitutionService.GetSingleInstitution(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/CreateInstitution")]
        [HttpPost]
        public HttpResponseMessage Create(InstitutionModel obj)
        {
            bool data = InstitutionService.CreateInstitution(obj);

            return Request.CreateResponse(data ? true : false);


        }

        [Route("api/UpdateInstitution")]
        [HttpPost]
        public HttpResponseMessage UpdateInstituion(InstitutionModel obj)
        {
            bool data = InstitutionService.UpdateInstitution(obj);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/DeleteInstitution/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            bool data = InstitutionService.DeleteInstitution(id);
            return Request.CreateResponse(data ? true : false);

        }

        /* -------------Mentor Controller-------
         ******************** ---------------
         * ---------------*******************/

        [Route("api/CreateMentor")]
        [HttpPost]
        public HttpResponseMessage CreateMentor(MentorModel obj)
        {
            var data = InstitutionService.CreateMentor(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/AllMentor")]
        [HttpGet]
        public HttpResponseMessage GetAllMentor()
        {
            var data = InstitutionService.GetAllMentor();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/SingleMentor/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleMentor(int id)
        {
            var data = InstitutionService.GetSingleMentor(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/UpdateMentor")]
        [HttpPost]
        public HttpResponseMessage UpdateMentor(MentorModel obj)
        {
            var data = InstitutionService.UpdateMentor(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/DeleteMentor/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteMentor(int id)
        {
            bool data = InstitutionService.DeleteMentor(id);
            return Request.CreateResponse(data ? true : false);

        }
        /* Notice Controller-------***********
    *****************  Notice Controller ---------------
    * ********************---------------*/

        [Route("api/CreateNotice")]
        [HttpPost]
        public HttpResponseMessage CreateNotice(NoticeModel obj)
        {
            var data = InstitutionService.CreateNotice(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/AllNotice")]
        [HttpGet]
        public HttpResponseMessage GetAllNotice()
        {
            var data = InstitutionService.GetAllNotice();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/SingleNotice/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleNotice(int id)
        {
            var data = InstitutionService.GetSingleNotice(id);

            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/UpdateNotice")]
        [HttpPost]
        public HttpResponseMessage UpdateNotice(NoticeModel obj)
        {
            var data = InstitutionService.UpdateNotice(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/DeleteNotice/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteNotice(int id)
        {
            bool data = InstitutionService.DeleteNotice(id);
            return Request.CreateResponse(data ? true : false);
        }
        /* Course Controller-------***********
   *****************  Course Controller ---------------
   * ********************---------------*/
        [Route("api/AllCourse")]
        [HttpGet]
        public HttpResponseMessage GetCourse()
        {
            var data = InstitutionService.GetCourse();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/SingleCourse/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleCourse(int id)
        {
            var data = InstitutionService.GetSingleCourse(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/CreateCourse")]
        [HttpPost]
        public HttpResponseMessage CreateCourse(CourseModel obj)
        {
            bool data = InstitutionService.CreateCourse(obj);

            return Request.CreateResponse(data ? true : false);


        }

        [Route("api/UpdateCourse")]
        [HttpPost]
        public HttpResponseMessage UpdateCourse(CourseModel obj)
        {
            bool data = InstitutionService.UpdateCourse(obj);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/DeleteColurse/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteCourse(int id)
        {
            bool data = InstitutionService.DeleteCourse(id);
            return Request.CreateResponse(data ? true : false);

        }

        /* -------------Result Controller-------
         ******************** ---------------
         * ---------------*******************/

        [Route("api/AllResult")]
        [HttpGet]
        public HttpResponseMessage GetResult()
        {
            var data = InstitutionService.GetResult();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/SingleResult/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleResult(int id)
        {
            var data = InstitutionService.GetSingleResult(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/CreateResult")]
        [HttpPost]
        public HttpResponseMessage CreateResult(ResultModel obj)
        {
            bool data = InstitutionService.CreateResult(obj);

            return Request.CreateResponse(data ? true : false);


        }

        [Route("api/UpdateResult")]
        [HttpPost]
        public HttpResponseMessage UpdateResult(ResultModel obj)
        {
            bool data = InstitutionService.UpdateResult(obj);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/DeleteResult/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteResult(int id)
        {
            bool data = InstitutionService.DeleteResult(id);
            return Request.CreateResponse(data ? true : false);

        }

        /* -------------Transaction Controller-------
        ******************** ---------------
        * ---------------*******************/

        [Route("api/AllTransaction")]
        [HttpGet]
        public HttpResponseMessage GetTransaction()
        {
            var data = InstitutionService.GetTransaction();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/SingleTransaction/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleTransaction(int id)
        {
            var data = InstitutionService.GetSingleTransaction(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}
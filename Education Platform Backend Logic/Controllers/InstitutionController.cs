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
    public class InstitutionController : ApiController
    {

        [Route("api/AllInstitution")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = InstitutionService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/SingleInstitution/{id}")]
        [HttpGet]
        public HttpResponseMessage GetId(int id)
        {
            var data = InstitutionService.GetSingle(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/CreateInstitution")]
        [HttpPost]
        public HttpResponseMessage Create(InstitutionModel obj)
        {
            bool data = InstitutionService.Create(obj);

            return Request.CreateResponse(data ? true : false);


        }

        [Route("api/UpdateInstitution")]
        [HttpPost]
        public HttpResponseMessage Update(InstitutionModel obj)
        {
            bool data = InstitutionService.Update(obj);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/DeleteInstitution/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            bool data = InstitutionService.Delete(id);
            return Request.CreateResponse(data ? true : false);

        }

        /* Mentor Controller-------
         * ---------------
         * ---------------*/

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
        public HttpResponseMessage Getonly(int id)
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
        public HttpResponseMessage NoticeMentor(int id)
        {
            bool data = InstitutionService.DeleteNotice(id);
            return Request.CreateResponse(data ? true : false);
        }
    }
}
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
    public class TransactionController : ApiController
    {
        [EnableCors("*", "*", "*")]
        [Route("api/transaction")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = TransactionService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/transaction/create")]
        [HttpPost]
        public HttpResponseMessage Create(TransactionModel st)
        {
            var data = TransactionService.Create(st);
            return Request.CreateResponse(HttpStatusCode.OK, "CREATED");
        }

        [Route("api/transaction/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {

            var data = TransactionService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "DELETED");
        }
    }
}
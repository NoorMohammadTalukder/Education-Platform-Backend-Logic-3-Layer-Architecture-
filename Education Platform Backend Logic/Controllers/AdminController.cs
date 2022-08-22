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
    public class AdminController : ApiController
    {
        [Route("api/all/admin")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = AdminService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/single/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage GetId(int id)
        {
            var data = AdminService.GetId(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/add/admin")]
        [HttpPost]
        public HttpResponseMessage Create(AdminModel obj)
        {
            bool data = AdminService.Create(obj);
            return Request.CreateResponse(data ? true: false);

        }

        [Route("api/update/admin")]
        [HttpPost]
        public HttpResponseMessage Update(AdminModel obj)
        {
            bool data = AdminService.Update(obj);
            return Request.CreateResponse(data ? HttpStatusCode.OK : HttpStatusCode.BadRequest);

        }

        [Route("api/delete/admin/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            bool data = AdminService.Delete(id);
            return Request.CreateResponse(data ? true : false);

        }

        //-----------------------------------------------------------
        //------------------Institution Work Started-----------------
        //-----------------------------------------------------------
        
        [Route("api/admin/all/institution")]
        [HttpGet]
        public HttpResponseMessage GetInstution()
        {
            var data = AdminService.GetInstitution();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/single/institution/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleInstitution(int id)
        {
            var data = AdminService.GetSingleInstitution(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/add/institution")]
        [HttpPost]
        public HttpResponseMessage CreateInstitution(InstitutionModel obj)
        {
            bool data = AdminService.CreateInstitution(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/admin/update/institution")]
        [HttpPost]
        public HttpResponseMessage UpdateInstitution(InstitutionModel obj)
        {
            bool data = AdminService.UpdateInstitution(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/admin/delete/Institution/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteInstitution(int id)
        {
            bool data = AdminService.DeleteInstitution(id);
            return Request.CreateResponse(data ? true : false);

        }


        //-----------------------------------------------------------
        //------------------Valid Student Work Started-----------------
        //-----------------------------------------------------------

        [Route("api/admin/all/validStudent")]
        [HttpGet]
        public HttpResponseMessage GetValidStudent()
        {
            var data = AdminService.GetValidStudent();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/single/validStudent/{id}")]
        [HttpGet]
        public HttpResponseMessage GetSingleValidStudent(int id)
        {
            var data = AdminService.GetSingleValidStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/add/validStudent")]
        [HttpPost]
        public HttpResponseMessage CreateValidStudent(ValidStudentModel obj)
        {
            bool data = AdminService.CreateValidStudent(obj);
            return Request.CreateResponse(data ? true : false);

        }


        [Route("api/admin/update/validStudent")]
        [HttpPost]
        public HttpResponseMessage UpdateValidStudent(ValidStudentModel obj)
        {
            bool data = AdminService.UpdateValidStudent(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/admin/delete/validStudent/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteValidStudent(int id)
        {
            bool data = AdminService.DeleteValidStudent(id);
            return Request.CreateResponse(data ? true : false);

        }

        //-----------------------------------------------------------
        //------------------Course Work Started-----------------
        //-----------------------------------------------------------

        [Route("api/admin/all/courses")]
        [HttpGet]
        public HttpResponseMessage GetAllCourses()
        {
            var data = AdminService.GetCourses();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/single/course/{id}")]
        [HttpGet]
        public HttpResponseMessage GetCourse(int id)
        {
            var data = AdminService.GetSingleCourse(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/add/course")]
        [HttpPost]
        public HttpResponseMessage CreateCourse(CourseModel obj)
        {
            bool data = AdminService.CreateCourse(obj);
            return Request.CreateResponse(data ? true : false);

        }


        [Route("api/admin/update/course")]
        [HttpPost]
        public HttpResponseMessage UpdateCourse(CourseModel obj)
        {
            bool data = AdminService.UpdateCourse(obj);
            return Request.CreateResponse(data ? true : false);

        }

        [Route("api/admin/delete/course/{id}")]
        [HttpGet]
        public HttpResponseMessage DeketeCourse(int id)
        {
            bool data = AdminService.DeleteCourse(id);
            return Request.CreateResponse(data ? true : false);

        }

        //-----------------------------------------------------------
        //------------------Course Work Started-----------------
        //-----------------------------------------------------------
      

        [Route("api/admin/all/mentor")]
        [HttpGet]
        public HttpResponseMessage GetAllMentor()
        {
            var data = AdminService.GetMentors();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/single/mentor/{id}")]
        [HttpGet]
        public HttpResponseMessage GetMentor(int id)
        {
            var data = AdminService.GetSingleMentor(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/add/mentor")]
        [HttpPost]
        public HttpResponseMessage CreateMentor(MentorModel obj)
        {
            var data = AdminService.CreateMentor(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/admin/update/mentor")]
        [HttpPost]
        public HttpResponseMessage UpdateMentor(MentorModel obj)
        {
            var data = AdminService.UpdateMentor(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/admin/delete/mentor/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteMentor(int id)
        {
            var data = AdminService.DeleteMentor(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //-----------------------------------------------------------
        //------------------Student Work Started-----------------
        //-----------------------------------------------------------

        [Route("api/admin/all/student")]
        [HttpGet]
        public HttpResponseMessage GetAllStudents()
        {
            var data = AdminService.GetStudents();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        [Route("api/admin/single/student/{id}")]
        [HttpGet]
        public HttpResponseMessage GetStudent(int id)
        {
            var data = AdminService.SingleStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/admin/create/student")]
        [HttpPost]
        public HttpResponseMessage StudentCreate(StudentModel obj)
        {
            var data = AdminService.StudentCreate(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }


        [Route("api/admin/update/student")]
        [HttpPost]
        public HttpResponseMessage StudentUpdate(StudentModel obj)
        {
            var data = AdminService.UpdateStudent(obj);
            return Request.CreateResponse(data ? true : false);

        }


        [Route("api/admin/delete/student/{id}")]
        [HttpPost]
        public HttpResponseMessage StudentDelete(int id)
        {
            var data = AdminService.DeleteStudent(id);
            return Request.CreateResponse(data ? true : false);
        }

        //-----------------------------------------------------------
        //------------------Transaction Work Started-----------------
        //-----------------------------------------------------------

        [Route("api/admin/all/transaction")]
        [HttpGet]
        public HttpResponseMessage GetAllTransactions()
        {
            var data = AdminService.GetTransactions();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //-----------------------------------------------------------
        //------------------Revenue Model Work Started-----------------
        //-----------------------------------------------------------

        //all
        [Route("api/admin/all/revenue")]
        [HttpGet]
        public HttpResponseMessage GetAllRevenue()
        {
            var data = AdminService.GetRevenue();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //institution
        [Route("api/admin/institution/revenue/{id}")]
        [HttpGet]
        public HttpResponseMessage InstitutionRevenue(int id)
        {
            var data = AdminService.InstitutionRevenue(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //-----------------------------------------------------------
        //------------------Search Work Started-----------------
        //-----------------------------------------------------------

        //Mentor

        [Route("api/admin/search/student/{search}")]
        [HttpGet]
        public HttpResponseMessage StudentSearch(string search)
        {
            var data = AdminService.StudentSearch(search);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //Mentor

        [Route("api/admin/search/mentor/{search}")]
        [HttpGet]
        public HttpResponseMessage MentorSearch(string search)
        {
            var data = AdminService.MentorSearch(search);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //Institution

        [Route("api/admin/search/institution/{search}")]
        [HttpGet]
        public HttpResponseMessage InstitutionSearch(string search)
        {
            var data = AdminService.InstitutionSearch(search);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //-----------------------------------------------------------
        //------------------Password Change Requests Work Started-----------------
        //-----------------------------------------------------------

        [Route("api/admin/get/passwordchangerequests")]
        [HttpGet]
        public HttpResponseMessage PasswordChangeRequests()
        {
             var data = AdminService.GetPasswordRequests();
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //-----------------------------------------------------------
        //------------------Activate Deactivate Verify Work Started-----------------
        //-----------------------------------------------------------

        //institution
        [Route("api/admin/activate/institution/{id}")]
        [HttpGet]
        public HttpResponseMessage ActivateInstitution(int id)
        {
            var data = AdminService.ActivateInstitution(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/admin/deactivate/institution/{id}")]
        [HttpGet]
        public HttpResponseMessage DeactivateInstitution(int id)
        {
            var data = AdminService.DeactivateInstitution(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //mentor
        [Route("api/admin/activate/mentor/{id}")]
        [HttpGet]
        public HttpResponseMessage ActivateMentor(int id)
        {
            var data = AdminService.ActivateMentor(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/admin/deactivate/mentor/{id}")]
        [HttpGet]
        public HttpResponseMessage DeactivateMentor(int id)
        {
            var data = AdminService.DeactivateMentor(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //student
        [Route("api/admin/activate/student/{id}")]
        [HttpGet]
        public HttpResponseMessage ActivateStudent(int id)
        {
            var data = AdminService.ActivateStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
        [Route("api/admin/deactivate/student/{id}")]
        [HttpGet]
        public HttpResponseMessage DeactivateStudent(int id)
        {
            var data = AdminService.DeactivateStudent(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }

        //-----------------------------------------------------------
        //------------------Certificate Approve Work Started---------
        //-----------------------------------------------------------
        [Route("api/admin/certificate/approve/student/{id}")]
        [HttpGet]
        public HttpResponseMessage CertificateApprove(int id)
        {
            var data = AdminService.CertificateApprove(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);

        }
    }
}

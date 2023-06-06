using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PcBuild.Controllers
{
    public class ModeratorController : ApiController
    {
        [HttpGet]
        [Route("api/moderator/get")]
        public HttpResponseMessage ModeratorData()
        {
            try
            {
                var data = ManageModeratorService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/moderator/get/{id}")]
        public HttpResponseMessage ModeratorData(int id)
        {
            try
            {
                var data = ManageModeratorService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/moderator/get/{id}/salesreport")]
        public HttpResponseMessage ModeratorSalesReportData(int id)
        {
            try
            {
                var data = ManageModeratorService.GetwithSalesReport(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        //[HttpGet]
        //[Route("api/moderator/{id}/salesreport")]
        //public HttpResponseMessage ModeratorSalesReport(int id)
        //{
        //    try
        //    {
        //        var data = ManageModeratorService.GetwithSalesReport(id);
        //        return Request.CreateResponse(HttpStatusCode.OK, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
        //    }
        //}
        [HttpPost]
        [Route("api/moderator/insert")]
        public HttpResponseMessage Insert(ModeratorDTO Moderator)
        {
            try
            {
                var data = ManageModeratorService.Create(Moderator);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = Moderator });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = Moderator });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/moderator/update")]
        public HttpResponseMessage Update(ModeratorDTO Moderator)
        {
            try
            {
                var data = ManageModeratorService.Update(Moderator);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Updated", Data = Moderator });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Updated", Data = Moderator });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/moderator/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, ManageModeratorService.Delete(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}

using BLL.DTOs;
using BLL.Services;
using PcBuild.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PcBuild.Controllers
{
    [EnableCors("*", "*", "*")]
    public class orderinformationController : ApiController
    {

        [Looged]
        [HttpGet]
        [Route("api/orderinformations")]
        public HttpResponseMessage orderinformation()
        {
            try
            {
                var data = orderinformationService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpGet]
        [Route("api/orderinformations/{id}")]
        public HttpResponseMessage orderinformation(int id)
        {
            try
            {
                var data = orderinformationService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpGet]
        [Route("api/orderinformations/{id}/Orders")]
        public HttpResponseMessage showOrder(int id)
        {
            try
            {
                var data = orderinformationService.GetwithOrders(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/orderinformations/add")]
        public HttpResponseMessage Add(orderinformationDTO obj)
        {
            try
            {
                var res = orderinformationService.Create(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = obj });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = obj });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/orderinformations/update")]
        public HttpResponseMessage Update(orderinformationDTO obj)
        {
            try
            {
                var res = orderinformationService.Update(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Updated", Data = obj });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Updated", Data = obj });
                }
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = obj });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/orderinformatis/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, orderinformationService.Delete(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}

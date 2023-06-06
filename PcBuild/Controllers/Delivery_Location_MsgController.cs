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
    public class Delivery_Location_MsgController : ApiController
    {
        [Looged]
        [HttpGet]
        [Route("api/Delivery_Location_Msgs")]
        public HttpResponseMessage Delivery_Location_Msgs()
        {
            try
            {
                var data = Delivery_Location_Msg_Service.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpGet]
        [Route("api/Delivery_Location_Msgs/{id}")]
        public HttpResponseMessage Delivery_Location_Msgs(int Id)
        {
            try
            {
                var data = Delivery_Location_Msg_Service.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpGet]
        [Route("api/Delivery_Location_Msgs/{id}/Orders")]
        public HttpResponseMessage showOrder(int Id)
        {
            try
            {
                var data = orderinformationService.GetwithOrders(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/Delivery_Location_Msgs/add")]
        public HttpResponseMessage Add(Delivery_Location_MsgDTO obj)
        {
            try
            {
                var res = Delivery_Location_Msg_Service.Create(obj);
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
        [Route("api/Delivery_Location_Msgs/update")]
        public HttpResponseMessage Update(Delivery_Location_MsgDTO obj)
        {
            try
            {
                var res = Delivery_Location_Msg_Service.Update(obj);
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
        [Route("api/Delivery_Location_Msgs/delete/{id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, Delivery_Location_Msg_Service.Delete(Id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}

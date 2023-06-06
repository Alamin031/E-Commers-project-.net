using BLL.DTOs;
using BLL.Services;
using PcBuild.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PcBuild.Controllers
{
    public class OrderDetailsController : ApiController
    {
        [HttpGet]
        [Route("api/OrderDetails/get")]
        public HttpResponseMessage OrderDetailsData()
        {
            try
            {
                var data = OrderDetailsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/OrderDetails/get/{id}")]
        public HttpResponseMessage OrderDetailsData(int id)
        {
            try
            {
                var data = OrderDetailsService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
       
        [HttpPost]
        [Route("api/OrderDetails/insert")]
        public HttpResponseMessage Insert(OrderDetailsDTO OrderDetails)
        {
            try
            {
                var data = OrderDetailsService.Create(OrderDetails);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = OrderDetails });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = OrderDetails });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/OrderDetails/update")]
        public HttpResponseMessage Update(OrderDetailsDTO OrderDetails)
        {
            try
            {
                var data = OrderDetailsService.Update(OrderDetails);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Updated", Data = OrderDetails });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Updated", Data = OrderDetails });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/OrderDetails/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, OrderDetailsService.Delete(id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}


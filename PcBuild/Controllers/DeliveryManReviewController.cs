using BLL.DTOs;
using BLL.Services;
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
    public class DeliveryManReviewController : ApiController
    {
        [HttpGet]
        [Route("api/DeliveryManReviews/get")]
        public HttpResponseMessage review()
        {
            try
            {
                var data = DelivaryManReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/DeliveryManReviews/get/{id}")]
        public HttpResponseMessage review(int id)
        {
            try
            {
                var data = DelivaryManReviewService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/DeliveryManReviews/insert")]
        public HttpResponseMessage Insert(DeliveryManReviewDTO cart)
        {
            try
            {
                var data = DelivaryManReviewService.Create(cart);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = cart });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = cart });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/DeliveryManReviews/update")]
        public HttpResponseMessage Update(DeliveryManReviewDTO cart)
        {
            try
            {
                var data = DelivaryManReviewService.Update(cart);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Message = "Updated", Data = cart });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = "Not Updated", Data = cart });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/DeliveryManReviews/{id}/user")]
        public HttpResponseMessage ShowReview(int id)
        {
            try
            {
                var data = DelivaryManReviewService.GetwithOrders(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }




        [HttpGet]
        [Route("api/DeliveryManReviews/delete/{rid}")]
        public HttpResponseMessage Delete(int rid)
        {
            try
            {
                var data = DelivaryManReviewService.Delete(rid);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

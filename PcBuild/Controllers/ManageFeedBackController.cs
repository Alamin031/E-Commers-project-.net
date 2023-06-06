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
    public class ManageFeedBackController : ApiController
    {
        [HttpGet]
        [Route("api/product/review/{id}")]
        public HttpResponseMessage ProductReview(int id)
        {
            try
            {
                var data = ManageFeedBackService.ProductReview(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/user/review/{id}")]
        public HttpResponseMessage UserReview(int id)
        {
            try
            {
                var data = ManageFeedBackService.UserReview(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/review/feedback/{id}")]
        public HttpResponseMessage ReviewFeedBack(int id)
        {
            try
            {
                var data = ManageFeedBackService.ReviewFeedBack(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/feedback/get")]
        public HttpResponseMessage feedback()
        {
            try
            {
                var data = ManageFeedBackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/feedback/get/{id}")]
        public HttpResponseMessage feedback(int id)
        {
            try
            {
                var data = ManageFeedBackService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/feedback/insert")]
        public HttpResponseMessage Insert(FeedBackDTO cart)
        {
            try
            {
                var data = ManageFeedBackService.Create(cart);
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
        [Route("api/feedback/update")]
        public HttpResponseMessage Update(FeedBackDTO cart)
        {
            try
            {
                var data = ManageFeedBackService.Update(cart);
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
        [Route("api/feedback/delete/{fid}")]
        public HttpResponseMessage Delete(int fid)
        {
            try
            {
                var data = ManageFeedBackService.Delete(fid);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

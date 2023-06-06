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
    public class DFeedBackController : ApiController
    {

        [Looged]
        [HttpGet]
        [Route("api/DFeedBacks/get")]
        public HttpResponseMessage DFeedBacks()
        {
            try
            {
                var data = DFeedBackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpGet]
        [Route("api/DFeedBacks/get/{id}")]
        public HttpResponseMessage feedback(int id)
        {
            try
            {
                var data = DFeedBackService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/DFeedBacks/insert")]
        public HttpResponseMessage Insert(DFeedBackDTO cart)
        {
            try
            {
                var data = DFeedBackService.Create(cart);
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
        [Looged]
        [HttpPost]
        [Route("api/DFeedBacks/update")]
        public HttpResponseMessage Update(DFeedBackDTO cart)
        {
            try
            {
                var data = DFeedBackService.Update(cart);
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
        [Looged]
        [HttpGet]
        [Route("api/DFeedBacks/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {
                var data = DFeedBackService.Delete(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

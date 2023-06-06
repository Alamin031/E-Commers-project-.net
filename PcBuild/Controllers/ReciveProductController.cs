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
    public class ReciveProductController : ApiController
    {
        [Looged]
        [HttpGet]
        [Route("api/ReciveProducts")]
        public HttpResponseMessage ReciveProducts()
        {
            try
            {
                var data = ReciveProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpGet]
        [Route("api/ReciveProducts/{Id}")]
        public HttpResponseMessage ReciveProducts(int ID)
        {
            try
            {
                var data = ReciveProductService.Get(ID);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/ReciveProducts/add")]
        public HttpResponseMessage Add(ReciveProductDTO ID)
        {
            try
            {
                var res = ReciveProductService.Create(ID);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = ID });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = ID });
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = ID });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/ReciveProducts/update")]
        public HttpResponseMessage Update(ReciveProductDTO ID)
        {
            try
            {
                var data = ReciveProductService.Update(ID);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = ID });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/ReciveProducts/delete/{Id}")]
        public HttpResponseMessage Delete(int ID)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, ReciveProductService.Delete(ID));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
    }
}

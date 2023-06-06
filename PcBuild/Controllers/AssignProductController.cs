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
    public class AssignProductController : ApiController
    {
        [Looged]
        [HttpGet]
        [Route("api/AssignProducts")]
        public HttpResponseMessage AssignProducts()
        {
            try
            {
                var data = AssignProductService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpGet]
        [Route("api/AssignProducts/{Id}")]
        public HttpResponseMessage AssignProducts(int Id)
        {
            try
            {
                var data = AssignProductService.Get(Id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/AssignProducts/add")]
        public HttpResponseMessage Add(AssignProductDTO Id)
        {
            try
            {
                var res = AssignProductService.Create(Id);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = Id });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = Id });
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = Id });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/AssignProducts/update")]
        public HttpResponseMessage Update(AssignProductDTO id)
        {
            try
            {
                var data = AssignProductService.Update(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = id });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/AssignProducts/delete/{Id}")]
        public HttpResponseMessage Delete(int Id)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, AssignProductService.Delete(Id));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

    }
}


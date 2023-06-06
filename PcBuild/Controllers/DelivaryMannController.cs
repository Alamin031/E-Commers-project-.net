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
    public class DelivaryMannController : ApiController
    {
        [Looged]

        [HttpGet]
        [Route("api/DeliveryMans")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = DeliveryManService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [Looged]

        [HttpGet]
        [Route("api/DeliveryMans/{Uname}")]
        public HttpResponseMessage DeliveryMans(string Uname)
        {
            try
            {
                var data = DeliveryManService.Get(Uname);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/DeliveryMans/add")]
        public HttpResponseMessage Add(DeliveryManDTO Uname)
        {
            try
            {
                var res = DeliveryManService.Create(Uname);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = Uname });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = Uname });
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = Uname });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/DeliveryMans/update")]
        public HttpResponseMessage Update(DeliveryManDTO Uname)
        {
            try
            {
                var data = DeliveryManService.Update(Uname);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = Uname });
            }
        }
        [Looged]
        [HttpPost]
        [Route("api/DeliveryMans/delete/{Uname}")]
        public HttpResponseMessage Delete(string Uname)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, DeliveryManService.Delete(Uname));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }


    }
}

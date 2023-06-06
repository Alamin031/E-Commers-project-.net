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
    public class SellerController : ApiController
    {
        [HttpGet]
        [Route("api/seller")]
        public HttpResponseMessage Sellers()
        {
            try
            {
                var data = SellerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpGet]
        [Route("api/seller/{Sname}")]
        public HttpResponseMessage Sellers(string Sname)
        {
            try
            {
                var data = SellerService.Get(Sname);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }

        [HttpPost]
        [Route("api/seller/add")]
        public HttpResponseMessage Add(SellerDTO Sname)
        {
            try
            {
                var res = SellerService.Create(Sname);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = Sname });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = Sname });
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message, Data = Sname });
            }
        }

        [HttpPost]
        [Route("api/seller/update")]
        public HttpResponseMessage Update(SellerDTO Sname)
        {
            try
            {
                var data = SellerService.Update(Sname);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message, Data = Sname });
            }
        }

        [HttpPost]
        [Route("api/seller/delete/{Sname}")]
        public HttpResponseMessage Delete(string Sname)
        {
            try
            {

                return Request.CreateResponse(HttpStatusCode.OK, SellerService.Delete(Sname));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpPost]
        [Route("api/seller/change-password/{Sname}")]
        public HttpResponseMessage ChangePassword(string Sname, ChangePasswordDTO changePass)
        {
            var seller = SellerService.Get(Sname);
            if (seller != null)
            {
                try
                {
                    var res = SellerService.ChangePassword(Sname, changePass);
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }
    }
}
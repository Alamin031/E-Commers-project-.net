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
    public class ManageUserOrderController : ApiController
    {
        [HttpPost]
        [Route("api/user/order/insert")]
        public HttpResponseMessage Insert(User_OrderDTO uo)
        {
            try
            {
                var data = ManageUserOrderService.Create(uo);
                if (data)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", Data = uo });
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Not Inserted", Data = uo });
                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/user/order/get")]
        public HttpResponseMessage UserOrder()
        {
            try
            {
                var data = ManageUserOrderService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/user/order/get/{id}")]
        public HttpResponseMessage UserOrder(int id)
        {
            try
            {
                var data = ManageUserOrderService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/user/order/update")]
        public HttpResponseMessage Update(User_OrderDTO cart)
        {
            try
            {
                var data = ManageUserOrderService.Update(cart);
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
        [Route("api/user/order/delete/{uid}")]
        public HttpResponseMessage Delete(int uid)
        {
            try
            {
                var data = ManageUserOrderService.Delete(uid);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

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
    public class ManageCartController : ApiController
    {
        [HttpGet]
        [Route("api/product/in/cart/{id}")]
        public HttpResponseMessage GetwithProductInCart(int id)
        {
            try
            {
                var data = ManageCartService.GetwithProductInCart(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/cart/product/{id}")]
        public HttpResponseMessage GetProductsInCart(int id)
        {
            try
            {
                var data = ManageCartService.GetProductsInCart(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/cart/get")]
        public HttpResponseMessage Cart()
        {
            try
            {
                var data = ManageCartService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/cart/get/{id}")]
        public HttpResponseMessage Cart(int id)
        {
            try
            {
                var data = ManageCartService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/cart/insert")]
        public HttpResponseMessage Insert(CartDTO cart)
        {
            try
            {
                var data = ManageCartService.Create(cart);
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
        [Route("api/cart/update")]
        public HttpResponseMessage Update(CartDTO cart)
        {
            try
            {
                var data = ManageCartService.Update(cart);
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
        [Route("api/cart/delete/{uid}/{pid}")]
        public HttpResponseMessage Delete(int uid, int pid)
        {
            try
            {
                var data = ManageCartService.Delete(uid, pid);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

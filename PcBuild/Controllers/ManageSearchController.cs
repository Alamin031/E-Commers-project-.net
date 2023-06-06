using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PcBuild.Controllers
{
    public class ManageSearchController : ApiController
    {
        [HttpGet]
        [Route("api/user/product/search/{src}")]
        public HttpResponseMessage ProductsSearch(string src)
        {
            try
            {
                var data = SearchService.ProductsSearch(src);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/product/search/filter/{min}/{max}")]
        public HttpResponseMessage Filter(int min, int max)
        {
            try
            {
                var data = SearchService.Filter(min, max);
                return Request.CreateResponse(HttpStatusCode.OK, data);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message });
            }
        }
    }
}

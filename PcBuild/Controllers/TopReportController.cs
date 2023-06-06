using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PcBuild.Controllers
{
    public class TopReportController : ApiController
    {
        [HttpGet]
        [Route("api/TopReport/Products")]
        public HttpResponseMessage TopSellingProduct()
        {
            var list = OrderDetailsService.GetTop();
            if(list.Count !=0) return Request.CreateResponse(HttpStatusCode.OK,list);
            else return Request.CreateResponse(HttpStatusCode.OK,"nothing");
        }
    }
}

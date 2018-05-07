using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sodex.Controllers
{
    [RoutePrefix("api/Sample")]
    public class SampleController : ApiController
    {
        [HttpGet, Route("List")]
        public List<Models.Sample1> nameList() {
            List<Models.Sample1> list = new List<Models.Sample1>();

            list.Add(new Models.Sample1() { firstName = "Edison", lastName = "Llorada" });
            list.Add(new Models.Sample1() { firstName = "Edisons", lastName = "Lloradas" });


            return list;
        }

        [HttpPost, Route("Add")]
        public HttpResponseMessage Add(Models.Sample1 obj) {
            Debug.WriteLine(obj.firstName);

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}

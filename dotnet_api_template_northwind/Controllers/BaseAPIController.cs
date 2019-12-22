using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Resources;
using System.Reflection;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Text; //Encoding

namespace dotnet_api_template_northwind.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class BaseAPIController : ApiController
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public IHttpActionResult JsonResp(object result)
        {
            var resp = new HttpResponseMessage()
            {
                Content = new StringContent(JsonConvert.SerializeObject(result), Encoding.UTF8, "application/json")
            };

            return ResponseMessage(resp);
        }

        [ApiExplorerSettings(IgnoreApi = true)]
        public string GetMethodSignature(string className, string methodName)
        {
            return className + ":" + methodName + "()";
        }

        //[ApiExplorerSettings(IgnoreApi = true)]
        //public string GetResource(string resourceName)
        //{
        //    Resource
        //}
       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FINAL_PROJECT4.Models.DAL;
using FINAL_PROJECT4.Models;

namespace FINAL_PROJECT4.Controllers
{
    public class GatePassController : ApiController
    {

        public HttpResponseMessage Post([FromBody] GatePass g)
        {
            g.InsertGatePass();
            return Request.CreateResponse(HttpStatusCode.Created);
        }


    }
}

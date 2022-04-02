using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PROJECT_5.Models.DAL;
using PROJECT_5.Models;

namespace PROJECT_5.Controllers
{
    public class GatePassController : ApiController
    {

        public HttpResponseMessage Post([FromBody] GatePass g)
        {
            g.InsertGatePass();
            return Request.CreateResponse(HttpStatusCode.Created);
        }


        //בדיקה לטבלה
        public List<GatePass> Get(string transportCompany)
        {
            GatePass gatePass = new GatePass();
            return gatePass.ReadgatePass(transportCompany);
        }
    }
}

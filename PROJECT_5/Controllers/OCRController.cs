﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FINAL_PROJECT4.Models;

namespace FINAL_PROJECT4.Controllers
{
    public class OCRController : ApiController
    {
        // GET: api/OCR
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/OCR/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/OCR
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/OCR/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/OCR/5
        public void Delete(int id)
        {
        }
    }
}

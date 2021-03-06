﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAppContainer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "CI using Azure DevOps", "CD", "Azure Container Registry and Web App for Containers" };
        }

        // GET api/values/5
        // Can you trigger my pipeline???
        // Hi Dex?
        // i am ironman.
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "CI-CD using Azure Devops";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bjss_option1.Models;
using bjss_option1.Services;
using System.Linq;
using Newtonsoft;

namespace bjss_option1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CVManagerController : ControllerBase
    {
        private ICVManager _cvmanager;

        public CVManagerController(ICVManager cvmanager)
        {
            _cvmanager = cvmanager;
        }

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            //return new string[] { "value1", "value2" };
            var (success, result) = _cvmanager.GetCandidates();

            if (success)
            {
                return new ActionResult<IEnumerable<string>>(result.Select(x => $"{x.FirstName} {x.Surname}"));
            }
            else
            {
                return new ActionResult<IEnumerable<string>>(new List<string>());
            }
        }

        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            var (success, result) = _cvmanager.GetCandidate(name);

            return new ActionResult<string>(Newtonsoft.Json.JsonConvert.
                SerializeObject(result.SingleOrDefault()));
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

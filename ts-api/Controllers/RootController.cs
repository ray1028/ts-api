using System;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace ts_api.Controllers
{

    [Route("/data")]
    [ApiController]
    public class RootController : ControllerBase
    {
        Int32[] values = new Int32[50000];

        [HttpGet(Name = nameof(GetRoot))]
        public IActionResult GetRoot()
        {
            for (int i = 0; i < 50000; i++)
            {
                values[i] = i;
            }

            var response = new
            {
                data = values
            };

            return Ok(response);
        }
    }
}

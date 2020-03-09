using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CaptiveDependencyTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CaptiveDependencyTestController : ControllerBase
    {
        private readonly ISingletonDependecy singletonDependecy;

        public CaptiveDependencyTestController(ISingletonDependecy singletonDependecy)
        {
            this.singletonDependecy = singletonDependecy;
        }

        [HttpGet]
        public string Get()
        {
            return $"Next count: {singletonDependecy.GetNextCounter()}";
        }
    }
}

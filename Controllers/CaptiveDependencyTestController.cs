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
        private readonly SingletonDependency singletonDependecy;

        public CaptiveDependencyTestController(SingletonDependency singletonDependecy)
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

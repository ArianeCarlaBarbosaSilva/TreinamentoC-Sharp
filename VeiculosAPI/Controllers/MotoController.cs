using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VeiculosAPI.Entities;

namespace VeiculosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class MotoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Moto> Get()
        {

        }

        [HttpPost]
        public ActionResult<Moto> Post()
        {

        }

        [HttpPut]
        public ActionResult<Moto> Put()
        {

        }

        [HttpDelete]
        public ActionResult<Moto> Delete()
        {

        }
    }
    
}
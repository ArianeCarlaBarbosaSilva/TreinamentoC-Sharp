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
        public MotoController()
        [HttpGet("{id}")]
        public ActionResult<Moto> GetOne(long id)
        {
            try
            {
                var moto = .GetMotos(id);
                return Ok(moto);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodeResult.Status500InternalServerError)
            }
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
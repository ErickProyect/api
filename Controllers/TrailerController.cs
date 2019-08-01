using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TrailerApi.Models;

namespace TrailerApi.Controllers
{

    [Authorize]
    [RoutePrefix("api/[controller]")]
    public class TrailerController : ApiController
    {
        
        [HttpGet]
        [Route("trailers")]
        public async Task<IHttpActionResult> getAll()
        {
            //settear todos los cambioos de
            return Ok("");
        }

        [HttpGet]
        [Route("trailers/{id}")]
        public async Task<IHttpActionResult> getById(int? Id)
        {
            return Ok(Id);
        }

        [HttpPost]
        [Route("trailers/save")]
        public async Task<IHttpActionResult> post([FromBody] TrailerModel model)
        {
            return Ok();
        }

    }
}

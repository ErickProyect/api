using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using TrailerApi.Models;

namespace TrailerApi.Controllers
{

    [AllowAnonymous]
    [RoutePrefix("api/login")]
    public class LoginController : ApiController
    {
        [HttpGet]
        [Route("ping")]
        public IHttpActionResult Ping()
        {
            return Ok(true);
        }

        [HttpGet]
        [Route("user/current")]
        public IHttpActionResult CurrentUser()
        {
            var identity = Thread.CurrentPrincipal.Identity;
            return Ok($ " IPrincipal-user: {identity.Name} - IsLoggued: {identity.IsAuthenticated}");
        }

        [HttpPost]
        [Route("auth")]
        public IHttpActionResult Login(LoginModel login)
        {
            if (login == null)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            bool isValid = true;
            if (isValid)
            {
               
                var respose = new LoginResponse
                {
                    Token = TokenGenerator.GenerateToken(login.Username)
                };
                return Ok(respose);
            }
            else
            {
                return Unauthorized();
            }
        }
        
    }
}

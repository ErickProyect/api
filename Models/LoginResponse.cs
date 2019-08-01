using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrailerApi.Models
{
    public class LoginResponse
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Token { get; set; }
    }
}
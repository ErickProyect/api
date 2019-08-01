using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrailerApi.Models
{
    public class TrailerModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public DateTime Estreno { get; set; }
        public string Link { get; set; }
        public string Portada { get; set; }
        private string Token { get; set; }
    }
}
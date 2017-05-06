using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiCorreios.Models
{
    public class endereco
    {
        public string CEP { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Complemento2 { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public bool erro { get; set; }

    }
}
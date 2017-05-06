using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebApiCorreios.Models;

namespace WebApiCorreios.Controllers
{
    public class CorreiosController : ApiController
    {
        public endereco end = new endereco();
        


        // GET: api/Correios
        public endereco Get()
        {
            return end;
        }

        // GET: api/Correios/5
        public endereco Get(string id)
        {
            var ws = new WSCorreios.AtendeClienteClient();
            try
            {
                var resposta = ws.consultaCEP(id);
                end = new endereco
                {
                    Logradouro = resposta.end,
                    Complemento = resposta.complemento,
                    Complemento2 = resposta.complemento2,
                    Bairro = resposta.bairro,
                    Cidade = resposta.cidade,
                    UF = resposta.uf,
                    CEP = resposta.cep,
                    erro = false
                };
            }
            catch (Exception erro)
            {
                end = new endereco
                {
                    Logradouro = erro.Message.ToString(),
                    CEP = erro.HResult.ToString(),
                    erro = true
                };
               
            }
            
            return end;

        }

        // POST: api/Correios
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Correios/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Correios/5
        public void Delete(int id)
        {
        }
    }
}

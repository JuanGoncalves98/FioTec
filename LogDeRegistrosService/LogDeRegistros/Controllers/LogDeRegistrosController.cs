using LogDeRegistros.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace LogDeRegistros.Controllers
{
    [ApiController]
    [Route("LogDeRegistros")]
    public class LogDeRegistrosController : Controller
    {
        [Route("Registrar")]
        [HttpPost]
        public Relatorio Index(Relatorio relatorio)
        {
            RegistraLog registraLog = new RegistraLog();

            return registraLog.registrar(relatorio);
        }
    }
}

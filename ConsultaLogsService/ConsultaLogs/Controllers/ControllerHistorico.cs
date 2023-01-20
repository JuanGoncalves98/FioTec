using ConsultaLogs.Model;
using Microsoft.AspNetCore.Mvc;

namespace ConsultaLogs.Controllers
{
    [ApiController]
    [Route("Historico")]
    public class ControllerHistorico : Controller
    {
        [Route("Consultar")]
        [HttpGet]
        public List<Relatorio> consultarHistorico()
        {
            ConsultaBD consultaBD = new ConsultaBD();
            return consultaBD.consultar();
        }
    }
}

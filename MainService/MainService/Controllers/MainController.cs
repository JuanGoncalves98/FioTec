using MainService.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace MainService.Controllers
{
    [ApiController]
    [Route("Main")]
    public class MainController : Controller
    {
        [Route("OpenDataSUS")]
        [HttpGet]
        public IActionResult obterDadosPorData([FromQuery]DateTime data, [FromQuery] String nome, [FromQuery] String CPF)
        {
            ConsultaOpenDataSUS openDataSUS = new ConsultaOpenDataSUS();
            return new JsonResult(openDataSUS.consultar(data, nome, CPF));
        }

        [Route("Historico")]
        [HttpGet]
        public IActionResult obterHistorico()
        {
            ConsultaHistorico historico = new ConsultaHistorico();
            return new JsonResult(historico.consultar());
        }
    }
}

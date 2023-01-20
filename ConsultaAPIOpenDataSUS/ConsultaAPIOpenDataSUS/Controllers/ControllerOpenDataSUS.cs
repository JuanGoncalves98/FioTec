using Microsoft.AspNetCore.Mvc;
using ConsultaAPIOpenDataSUSService.Model;
using Newtonsoft.Json;

namespace ConsultaAPIOpenDataSUSService.Controllers
{
    [Route("OpenDataSUS")]
    public class ConsultaAPIOpenDataSUS : Controller
    {
        [Route("Consultar")]
        [HttpGet]
        public Relatorio Get([FromQuery]string nome, [FromQuery]string CPF, [FromQuery]DateTime data)
        {
            ConsultaOpenDataSUS consulta = new ConsultaOpenDataSUS();
            Relatorio teste = consulta.consultarOpenDataSUS(data, nome, CPF);
            return teste;//new JsonResult(JsonConvert.SerializeObject(teste));
        }
    }
}

using Newtonsoft.Json;
using RestSharp;
using System.Data;
using System.Data.SqlClient;

namespace MainService.Model
{
    public class ConsultaHistorico
    {
        public ConsultaHistorico() { }

        public List<Relatorio> consultar()
        {
            RestClient restClient = criarRestClient();
            RestRequest requisicao = new RestRequest("", Method.Get);

            RestResponse resposta = restClient.Execute(requisicao);

            return JsonConvert.DeserializeObject<List<Relatorio>>(resposta.Content);
        }

        private RestClient criarRestClient()
        {
            return new RestClient("https://localhost:7151/Historico/Consultar");
        }
    }
}

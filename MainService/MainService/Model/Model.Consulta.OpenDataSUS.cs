using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;

namespace MainService.Model
{
    public class ConsultaOpenDataSUS
    {
        public ConsultaOpenDataSUS() { }

        public Relatorio consultar(DateTime data, string nome, string CPF)
        {
            RestClient restClient = criarRestClient();

            RestRequest requisicao = new RestRequest("", Method.Get);

            requisicao.AddParameter("nome", nome, ParameterType.QueryString);
            requisicao.AddParameter("data", data.ToString("yyyy-MM-dd"), ParameterType.QueryString);
            requisicao.AddParameter("CPF", CPF, ParameterType.QueryString);

            RestResponse resposta = restClient.Execute(requisicao);

            return JsonConvert.DeserializeObject<Relatorio>(resposta.Content);
        }

        private RestClient criarRestClient()
        {
            return new RestClient("https://localhost:7010/OpenDataSUS/Consultar");
        }
    }
}

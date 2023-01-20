using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Specialized;
using System.Text;
using System.Web.Helpers;
using System.Xml.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsultaAPIOpenDataSUSService.Model
{
    public class ConsultaOpenDataSUS
    {
        public ConsultaOpenDataSUS() { }


        private void configurarRequisicao(RestRequest requisicao, Relatorio relatorio)
        {
            requisicao.AddStringBody(JsonConvert.SerializeObject(relatorio),"application/json");
        }

        private void configurarRestClientParaLog(RestClient restClient)
        {
            restClient.Options.BaseUrl = new Uri("https://localhost:7200/LogDeRegistros/Registrar");
            restClient.Authenticator = null;
        }

        public Relatorio consultarOpenDataSUS(DateTime data, string nome, string CPF)
        {
            MontaRelatorio montaRelatorio = new MontaRelatorio();
            RestClient restClient = criarRestClient();
            RespostaOpenSUS respostaOpenSUS = realizarPostComQueryDSL(restClient, data);
            
            Relatorio relatorio = montaRelatorio.montar(respostaOpenSUS.hits.hits.Count(), data, nome, CPF);
            registrarLog(restClient, relatorio);

            return relatorio;
        }

        private RestClient criarRestClient()
        {
            RestClient restClient = new RestClient("https://imunizacao-es.saude.gov.br/_search/?scroll=1m");
            restClient.Authenticator = new HttpBasicAuthenticator("imunizacao_public", "qlto5t&7r_@+#Tlstigi");

            return restClient;
        }

        private void registrarLog(RestClient restClient, Relatorio relatorio)
        {
            RestRequest requisicao = new RestRequest("", Method.Post);

            configurarRestClientParaLog(restClient);
            configurarRequisicao(requisicao, relatorio);

            RestResponse resposta = restClient.Execute(requisicao);
            relatorio = JsonConvert.DeserializeObject<Relatorio>(resposta.Content);
        }

        private string queryDSL(DateTime data)
        {
            string JSONqueryDSL = File.ReadAllText(".\\Documents\\queryDSL.txt");
            return JSONqueryDSL.Replace(":DATAACONSULTAR", data.ToString("yyyy-MM-dd"));
        }

        private RespostaOpenSUS realizarPostComQueryDSL(RestClient restClient, DateTime data)
        {
            RestRequest requisicao = new RestRequest("", Method.Post);
            requisicao.AddStringBody(queryDSL(data), "application/json");

            RestResponse resposta = restClient.Execute(requisicao);
            
            return JsonConvert.DeserializeObject<RespostaOpenSUS>(resposta.Content);
        }

        private string relatorioParaJson(Relatorio relatorio)
        {
            return Convert.ToBase64String(Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(relatorio)));
        }
    }
}

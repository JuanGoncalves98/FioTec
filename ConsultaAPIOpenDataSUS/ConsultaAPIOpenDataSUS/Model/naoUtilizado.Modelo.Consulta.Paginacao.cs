using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Specialized;
using System.Text;
using System.Web.Helpers;

namespace ConsultaAPIOpenDataSUSService.Model
{
    public class NaoUtilizadoConsultaPaginacao
    {
        public NaoUtilizadoConsultaPaginacao() { }

        private class BodyPrimeiroRequest
        {
            public BodyPrimeiroRequest()
            {
                this.parametro = "size";
                this.valor = "10000";
            }
            public string parametro;
            public string valor;
        }

        private class BodyScrollId
        {
            public BodyScrollId(string ultimoScrollId)
            {
                this.valor1 = ultimoScrollId;
            }

            public string parametro1 = "scroll_id";
            public string valor1;
        }

        private class BodyScroll
        {
            public BodyScroll() { }

            public string parametro2 = "scroll";
            public string valor2 = "1m";
        }

        private void atualizarEndPointPaginacao(RestClient restClient)
        {
            restClient.Options.BaseUrl = new Uri("https://imunizacao-es.saude.gov.br/_search/scroll");
        }

        private HttpContent bodyPOST()
        {
            return new StringContent("{size:10000}", Encoding.UTF8, "application/json");
        }


        public Relatorio consultarOpenDataSUS(DateTime data)
        {
            int quantidadeVacinados = 0;

            MontaRelatorio montaRelatorio = new MontaRelatorio();
            RestClient restClient = criarRestClient();
            RespostaOpenSUS respostaOpenSUS = realizarPost(restClient);

            do
            {
                quantidadeVacinados += montaRelatorio.contar(respostaOpenSUS, data);
                string ultimoScrollId = respostaOpenSUS._scroll_id;
                respostaOpenSUS = realizarPostProximasPaginas(restClient, ultimoScrollId);
            } while (respostaOpenSUS.hits.total.value > 0);

//            Relatorio relatorio = montaRelatorio.montar(quantidadeVacinados, data);

//            return relatorio;
            return null;
        }

        private RestClient criarRestClient()
        {
            RestClient restClient = new RestClient("https://imunizacao-es.saude.gov.br/_search/?scroll=1m");
            restClient.Authenticator = new HttpBasicAuthenticator("imunizacao_public", "qlto5t&7r_@+#Tlstigi");

            return restClient;
        }

        private RespostaOpenSUS realizarPost(RestClient restClient)
        {
            RestRequest request = new RestRequest("", Method.Post);

            request.AddStringBody("{\"size\":10000}", "application/json");

            RestResponse response = restClient.Execute(request);
            RespostaOpenSUS respostaOpenSUS = JsonConvert.DeserializeObject<RespostaOpenSUS>(response.Content);


            if (respostaOpenSUS.hits.total.value > 0)
                return respostaOpenSUS;
            else
            {
                return new RespostaOpenSUS();
            }
        }

        private RespostaOpenSUS realizarPostProximasPaginas(RestClient restClient, string ultimoScrollId)
        {
            atualizarEndPointPaginacao(restClient);

            RestRequest requisicao = new RestRequest("", Method.Post);
            requisicao.AddStringBody("{\"scroll\":\"1m\", \"scroll_id\":\"" + ultimoScrollId + "\"}", "application/json");

            RestResponse resposta = restClient.Execute(requisicao);
            RespostaOpenSUS respostaOpenSUS = JsonConvert.DeserializeObject<RespostaOpenSUS>(resposta.Content);

            if ((respostaOpenSUS.hits.total is not null) && (respostaOpenSUS.hits.total.value > 0))
                return respostaOpenSUS;
            else
                return new RespostaOpenSUS();
        }
    }
}

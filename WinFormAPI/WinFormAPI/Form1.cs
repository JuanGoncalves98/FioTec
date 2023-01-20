using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using System.Net.Http;
using System.Text;

namespace WinFormAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            System.Net.ServicePointManager.CheckCertificateRevocationList = true;
            HttpClient httpClient = new HttpClient();
            string auth = Convert.ToBase64String(Encoding.UTF8.GetBytes("imunizacao_public:qlto5t&7r_@+#Tlstigi"));
            httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", auth);
            
            HttpResponseMessage resposta = httpClient.GetAsync("https://imunizacao-es.saude.gov.br/_search").Result;

            textBox1.Text = resposta.Content.ReadAsStringAsync().Result.ToString();*/
            //textBox1.Text = httpClient.DefaultRequestHeaders.Date.HasValue.ToString();
            //textBox1.Text = DateTime.Now.ToShortDateString();

            RestClient client = new RestClient("https://imunizacao-es.saude.gov.br/_search");
            RestRequest request = new RestRequest("", Method.Post);
            client.Authenticator = new HttpBasicAuthenticator("imunizacao_public", "qlto5t&7r_@+#Tlstigi");
            RestResponse response = client.Execute(request);

            textBox1.Text = response.Content.ToString();
        }
    }
}
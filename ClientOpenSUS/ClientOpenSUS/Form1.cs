using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Web.Mvc;

namespace ClientOpenSUS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConsultarOpenSUS_Click(object sender, EventArgs e)
        {
            HttpClient httpClient = new HttpClient();
            string url = String.Format("https://localhost:7066/Main/OpenDataSUS?nome={0}&CPF={1}&data={2}", txtNome.Text, txtCPF.Text, dtpDataAplicacao.Text);
            HttpResponseMessage httpResponse = httpClient.GetAsync(url).Result;

            Relatorio relatorio = new Relatorio();
            relatorio.solicitante = new Solicitante();

            relatorio = JsonConvert.DeserializeObject<Relatorio>((httpResponse.Content.ReadAsStringAsync().Result));

            if (httpResponse.IsSuccessStatusCode)
            {
                txtResultado.Text = "O total de pessoas vacinadas com PFizer no Rio de Janeiro neste dia foi de: " + relatorio.quantidadeDeVacinados.ToString();
            }
        }
    }
}
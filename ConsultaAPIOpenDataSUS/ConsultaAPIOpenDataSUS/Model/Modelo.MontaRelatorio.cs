using System.Web.WebPages;

namespace ConsultaAPIOpenDataSUSService.Model
{
    public class MontaRelatorio
    {
        public MontaRelatorio() { }


        //Foi usado somente como paginacão. Substituido por busca via query DSL.
        //Deixei apenas como histórico de implementação.
        //Consulta levou mais de uma hora.
        public int contar(RespostaOpenSUS respostaOpenSUS, DateTime data)
        {
            int contagem = 0;

            foreach (RespostaOpenSUSHitsHits hit in respostaOpenSUS.hits.hits)
            {
                if ((hit._source.vacina_dataAplicacao == data) &&
                    (hit._source.vacina_fabricante_nome == "PFIZER") &&
                    (hit._source.estabelecimento_uf == "RJ"))
                    contagem++;
            }

            return contagem;
        }

        public Relatorio montar(int quantidadeVacinados, DateTime data, string nome, string CPF)
        {
            Relatorio relatorio = new Relatorio();
            relatorio.solicitante = new Solicitante();

            relatorio.solicitante.CPF = CPF;
            relatorio.solicitante.nome = nome;
            relatorio.dataSolicitacao = DateTime.Today;
            relatorio.dataAplicacao = data;
            relatorio.descricaoRelatorio = "Relatório Vacinas Pfizer aplicadas no RJ_Data da aplicação_" + data.ToString("dd/MM/yyyy");
            relatorio.quantidadeDeVacinados = quantidadeVacinados;

            return relatorio;
        }
    }
}

using ConsultaLogs.Model.ConsultaLogs.Model;
using System.Data;
using System.Data.SqlClient;

namespace ConsultaLogs.Model
{
    public class ConsultaBD{ 
        ConexaoBD conexao;
        SqlCommand comandoSQL;
        SqlDataAdapter adapter;
        DataSet dataSet;

        public ConsultaBD()
        {
            conexao = new ConexaoBD();
            comandoSQL = new SqlCommand();
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
            comandoSQL.Connection = conexao.Conectar();
        }

        public List<Relatorio> consultar()
        {
            dataSet = executarQuery();
            return popularLista(dataSet);
        }

        private List<Relatorio> popularLista(DataSet dataSet)
        {
            List<Relatorio> listaRelatorio = new List<Relatorio>();

            for (int i = 0; i < dataSet.Tables[0].Rows.Count; i++)
            {
                Relatorio relatorioAuxiliar = new Relatorio();
                relatorioAuxiliar.solicitante = new Solicitante();

                relatorioAuxiliar.descricaoRelatorio = Convert.ToString(dataSet.Tables[0].Rows[i]["DESCRICAO_RELATORIO"]);
                relatorioAuxiliar.dataSolicitacao = Convert.ToDateTime(dataSet.Tables[0].Rows[i]["DATA_SOLICITACAO"]);
                relatorioAuxiliar.dataAplicacao = Convert.ToDateTime(dataSet.Tables[0].Rows[i]["DATA_APLICACAO"]);
                relatorioAuxiliar.quantidadeDeVacinados = Convert.ToInt32(dataSet.Tables[0].Rows[i]["QUANTIDADE_VACINADOS"]);
                relatorioAuxiliar.solicitante.nome = Convert.ToString(dataSet.Tables[0].Rows[i]["NOME"]);
                relatorioAuxiliar.solicitante.CPF = Convert.ToString(dataSet.Tables[0].Rows[i]["CPF"]);

                listaRelatorio.Add(relatorioAuxiliar);
            }

            return listaRelatorio;
        }

        private DataSet executarQuery()
        {
            comandoSQL.CommandText = "SELECT *                                                  " +
                                     "  FROM RELATORIO                                          " +
                                     " INNER JOIN SOLICITANTE                                   " +
                                     "    ON RELATORIO.IDSOLICITANTE = SOLICITANTE.IDSOLICITANTE";

            adapter.SelectCommand = comandoSQL;
            adapter.Fill(dataSet);

            return dataSet;
        }
}
}

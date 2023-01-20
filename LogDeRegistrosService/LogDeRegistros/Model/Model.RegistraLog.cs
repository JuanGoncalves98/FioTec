using System.Data;
using System.Data.SqlClient;


namespace LogDeRegistros.Model
{
    public class RegistraLog
    {
        ConexaoBD conexao;
        SqlDataAdapter adapter;
        DataSet dataSet;
        SqlCommand comandoSQL;

        public RegistraLog() {

            conexao = new ConexaoBD();
            adapter = new SqlDataAdapter();
            dataSet = new DataSet();
            comandoSQL = new SqlCommand();
            comandoSQL.Connection = conexao.Conectar();
        }

        public Relatorio registrar(Relatorio relatorio)
        {
            relatorio.solicitante.idSolicitante = inserirSolicitante(relatorio.solicitante.CPF, relatorio.solicitante.nome);
            return inserirLog(relatorio);
        }

        private int verificarExistenciaDoSolicitante(string CPF)
        {
            string SQL = "SELECT IDSOLICITANTE " +
                         "  FROM SOLICITANTE" +
                         " WHERE CPF = ':CPF'";

            comandoSQL.CommandText = SQL.Replace(":CPF", CPF);

            adapter.SelectCommand = comandoSQL;
            adapter.Fill(dataSet);

            if (dataSet.Tables[0].Rows.Count > 0)
                return Convert.ToInt32(dataSet.Tables[0].Rows[0]["IDSOLICITANTE"]);
            else
                return 0;
        }

        private Relatorio inserirLog(Relatorio relatorio)
        {
            string SQL = "INSERT INTO RELATORIO (DATA_SOLICITACAO, DATA_APLICACAO, DESCRICAO_RELATORIO, QUANTIDADE_VACINADOS, IDSOLICITANTE) " +
                         "               VALUES (':DATA_SOLICITACAO', ':DATA_APLICACAO', ':DESCRICAO_RELATORIO', ':QUANTIDADE_VACINADOS', ':IDSOLICITANTE')";

            comandoSQL.CommandText = SQL.Replace(":DATA_SOLICITACAO", relatorio.dataSolicitacao.ToString("yyyyMMdd HH:mm:ss"))
                                        .Replace(":DATA_APLICACAO", relatorio.dataAplicacao.ToString("yyyyMMdd"))
                                        .Replace(":DESCRICAO_RELATORIO", relatorio.descricaoRelatorio)
                                        .Replace(":QUANTIDADE_VACINADOS", relatorio.quantidadeDeVacinados.ToString())
                                        .Replace(":IDSOLICITANTE", relatorio.solicitante.idSolicitante.ToString());

            if (comandoSQL.ExecuteNonQuery() > 0)
                return relatorio;
            else
                throw (new Exception("Erro ao inserir log."));
        }

        private int inserirSolicitante(string CPF, string nome)
        {
            int idSolicitante = verificarExistenciaDoSolicitante(CPF);

            if (idSolicitante != 0)
                return idSolicitante;

            string SQL = "INSERT INTO SOLICITANTE (CPF, NOME) VALUES (':CPF', ':NOME')";
            comandoSQL.CommandText = SQL.Replace(":CPF", CPF)
                                        .Replace(":NOME", nome);

            comandoSQL.ExecuteNonQuery();

            return verificarExistenciaDoSolicitante(CPF);
        }
    }
}

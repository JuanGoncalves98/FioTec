using System.Data.SqlClient;

namespace ConsultaLogs.Model
{
    namespace ConsultaLogs.Model
    {
        public class ConexaoBD
        {
            SqlConnection conexao = new SqlConnection();
            public ConexaoBD()
            {
                conexao.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=VACINACAORJ;Integrated Security=True";
            }
            public SqlConnection Conectar()
            {
                if (conexao.State == System.Data.ConnectionState.Closed)
                {
                    conexao.Open();
                }
                return conexao;
            }
        }
    }
}

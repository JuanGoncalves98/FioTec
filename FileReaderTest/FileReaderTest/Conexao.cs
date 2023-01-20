using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderTest
{
    public class Conexao
    {
        SqlConnection conexaoBD = new SqlConnection();
        public Conexao()
        {
            conexaoBD.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=Palavras;Integrated Security=True";
        }
        public SqlConnection Conectar()
        {
            if (conexaoBD.State == System.Data.ConnectionState.Closed)
            {
                conexaoBD.Open();
            }
            return conexaoBD;
        }
    }
}

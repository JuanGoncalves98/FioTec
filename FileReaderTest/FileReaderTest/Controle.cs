using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderTest
{
    internal class Controle
    {
        Conexao conexao;
        SqlCommand comandoSQL;

        public Controle()
        {
            conexao = new Conexao();
            comandoSQL = new SqlCommand();
            comandoSQL.Connection = conexao.Conectar();
        }

        public string inserir(String palavra)
        {
            comandoSQL.CommandText = "INSERT INTO PALAVRASLIDAS (PALAVRA) VALUES ('" +  palavra + "')";

            try
            {
                comandoSQL.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                return e.Message;
            }

            return "Linha inserida.";
        }
    }
}

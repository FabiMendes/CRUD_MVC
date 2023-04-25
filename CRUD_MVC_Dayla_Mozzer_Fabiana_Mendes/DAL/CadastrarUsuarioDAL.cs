using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DAL
{
    class CadastrarUsuarioDAL
    {

        // Metodo para cadastro de usuário

        public bool CadastrarUsuario(CadastrarUsuarioDTO usuario)
        {
            try
            {
                // chama o método de conexão com banco de dados
                var conn = UtilsDAL.GetConnection();

                //verifica se conexão esta ok, por meio da comparação entre a propriedade
                // state do objeto de conexão e a variável Enum ConnectionState com seu atributo Open
                if (conn.State == ConnectionState.Open)
                {
                    // no momento em vamos salvar no banco precisamos converter o texto recebido de nivel para valor do
                    // indice da tabela pois é uma chave a sersalva como FK na tabela usuarios, para isso
                    // iremos fazer uso de um método de conversão que foi criado em UtisDAL
                    UtilsDAL cp = new UtilsDAL();
                    int nivel = cp.PrimaryKey("id_nivel", "nivel", "nome", usuario.Nivel);

                    //definimos a variável sql de inserção de dados
                    string sql = $"INSERT INTO usuario " +
                        $"(nome, email, senha, nivel) " +
                        $"Values " +
                        $"('{usuario.Nome}', '{usuario.Email}', '{usuario.Senha}', '{nivel}')";

                    //o objeto comando possui a conexão e a query a ser executada
                    SqlCommand comando = new SqlCommand(sql, conn);

                    // aqui executamos a inserção no banco de dados
                    comando.ExecuteNonQuery();

                    // por  boas práticas encerramos a conexão
                    conn.Close();
                }

            }
            catch (System.Exception)
            {
                return false; // retorna falso caso não salve o usuário no banco
            }
            return true; // retorna verdadeiro quando o usuário for salvo
        }
    }
}

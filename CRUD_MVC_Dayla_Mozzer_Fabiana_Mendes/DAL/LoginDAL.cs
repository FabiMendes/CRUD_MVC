using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DAL
{
    class LoginDAL
    {
        // método que consulta o banco de dados e retorna se o usuário está cadastrado
        public bool GetLoginDAL(LoginDTO loginDTO)
        {
            //conectar ao banco de dados
            try
            {
                //criar a conexão
                SqlConnection conn = UtilsDAL.GetConnection();

                //verificar a conexão
                if(conn.State == ConnectionState.Open)
                {
                    //pesquisa no banco se o usuário existe
                    string sql = $"select * from usuario" +
                                    $" where " +
                                    $"email = '{loginDTO.Email}' " +
                                    $"and  " +
                                    $"senha = '{loginDTO.Senha}' ";

                    SqlCommand retorno = new SqlCommand(sql, conn);
                    //executar no banco a query
                    SqlDataReader reader = retorno.ExecuteReader();
                    // se ouver conteúdo a perquisa retorna true
                    if (reader.Read())
                    {
                        return true;
                    }
                }
            }
            catch (System.Exception erro)
            {
                //apresentar mensagem de erro caso houver problema na conexão
                MessageBox.Show(erro.Message);
            }
            return false;
        }
    }
}

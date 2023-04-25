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
    internal class ListarUsuariosDAL
    {
        //criar lista com objeto de usuários
        public List<ListarUsuariosDTO> usuariosLista = new List<ListarUsuariosDTO>();

        //o método ListarTodos retorna uma lista contendo objetos do tipo ListarUsuariosDTO
        public List<ListarUsuariosDTO> ListarTodos()
        {
            try
            {
                //conectar ao banco de dados
                var conn = UtilsDAL.GetConnection();

                //verifica se a conexão está ok
                if (conn.State == ConnectionState.Open)
                {
                    var sql = "SELECT * FROM usuario";

                    var retorno = new SqlCommand(sql, conn);

                    var reader = retorno.ExecuteReader();

                    //percorremos o resultado da pesquisa do banco 
                    //enquano houver dados no reader ele será verdadeiro e o
                    //loop while ficará sendo executado

                    while (reader.Read())
                    {
                        //adição dos usuários a lista
                        usuariosLista.Add(new ListarUsuariosDTO()
                        {
                            Id = reader[0].ToString(), //primeira coluna da tabela de usuários
                            Nome = reader[1].ToString(),
                            Email = reader[2].ToString(),
                            Senha = reader[3].ToString(),
                            Nivel = reader[4].ToString(),
                            
                        });
                    }
                    conn.Close(); //encerra a conexão
                }
            }
            catch (SystemException erro)
            {
                MessageBox.Show(erro.Message);
            }
            return usuariosLista; //retorna a lista de usuários
        }
    }
}

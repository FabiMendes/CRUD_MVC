using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.BLL;
using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DAL;
using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.UI
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            // para que possamos cadstrar um usuario primeiro precisamos coletar os dados do
            // formulario, e para isso temos o objeto de transporte da camada DTO
            // chamaremos este objeto de "usuario" e iremos atribuir a eles os valores do formulario
            CadastrarUsuarioDTO usuario = new CadastrarUsuarioDTO
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text,
                Nivel = cmbNivel.Text
            };

            // chamar o método CadastrarUsuario() da camada BLL
            CadastrarUsuarioBLL cadUserBLL = new CadastrarUsuarioBLL();
            bool retorno = cadUserBLL.CadastrarUsuario(usuario);

            if (retorno)
            {
                MessageBox.Show("usuário cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Usuário não pode ser cadastrado!");
            }
        }

        private void FormCadastroUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                // Chama o método de conexão com o banco de dados
                var conn = UtilsDAL.GetConnection();

                // verifica se a conexão está ok, por meio da comparaão entre a propriedade
                // state do objeto de conexão e a variável Enum ConnectionState com seu atributo Open
                if (conn.State == ConnectionState.Open)
                {
                    // definimos a variável sql com a query de inserção de dados
                    string sql = $" SELECT * FROM nivel";

                    // o objeto comando possui a conexão e a query a ser executada
                    SqlCommand comando = new SqlCommand(sql, conn);

                    //carregar um DataReader com MySqlCommand
                    SqlDataReader data = comando.ExecuteReader();

                    // Criar uma tabela com os dados
                    DataTable table = new DataTable();

                    // Carrega a tabela com os dados
                    table.Load(data);

                    //informa qual o tipo dado será apresentado no combobox
                    cmbNivel.DisplayMember = "nome";

                    // Carrega os dados no combobox
                    cmbNivel.DataSource = table;

                    // Fecha a conexão com o banco
                    conn.Close();
                }
            }
            catch (Exception ex ) // caso ocorra um erro durante a transação com o BD
            {
                MessageBox.Show("Erro:" + ex.Message);
            }
        }
    }
}

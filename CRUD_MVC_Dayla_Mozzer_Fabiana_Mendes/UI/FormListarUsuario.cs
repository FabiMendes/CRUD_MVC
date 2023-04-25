using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.UI
{
    public partial class FormListarUsuario : Form
    {
        public FormListarUsuario()
        {
            InitializeComponent();
        }

        private void FormListarUsuario_Load(object sender, EventArgs e)
        {
            //configurar objetos ao iniciar formulário
            rdoNome.Checked = true;

            //configuração inicial dos botões
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            //objeto que representa a camada BLL
            ListarUsuariosBLL listar = new ListarUsuariosBLL();

            //chamando o controller (BLL) e objendo o retorno (lista)
            var retorno = listar.ListarUsuarios();

            //Montar o DataGridView
            dgvListar.Rows.Clear(); //limpa as linhas do DataGridView
            dgvListar.Columns.Clear(); //limpa as colunas
            dgvListar.Refresh(); //atualiza o DataGridView

            //criar as colunas do DataGridView que serão preenchidas pela lista de usuários
            dgvListar.Columns.Add("Id", "ID");
            dgvListar.Columns.Add("Nome", "Nome");
            dgvListar.Columns.Add("Email", "Email");
            dgvListar.Columns.Add("Senha", "Senha");
            dgvListar.Columns.Add("Nivel", "Nivel");
            dgvListar.Columns.Add("Data", "Data");

            //preencher a lista e monta o DataGridView
            foreach (var i in retorno)
            {
                dgvListar.Rows.Add(i.Id, i.Nome, i.Email, i.Senha, i.Nivel, i.Data);  
            }

            //ajustar automaticamente o tamanho das colunas
            dgvListar.AutoResizeColumn(1); //coluna indice 1
            dgvListar.AutoResizeColumn(2);
            dgvListar.AutoResizeColumn(5);

            //não permite que as colunas sejam editadas manualmente
            dgvListar.ReadOnly = true;

            //controla os botões do formulário
            btnAtualizar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}

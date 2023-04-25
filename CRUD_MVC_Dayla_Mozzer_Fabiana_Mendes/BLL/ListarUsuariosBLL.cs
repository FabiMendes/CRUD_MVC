using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DAL;
using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.BLL
{
    class ListarUsuariosBLL
    {
        //o método apenas chama a DAL e retorna a lista
        public List<ListarUsuariosDTO> ListarUsuarios()
        {
            //criar o objeto da classe da DAL
            ListarUsuariosDAL lista = new ListarUsuariosDAL();

            //chamar método ListarTodos da classe DAL
            return lista.ListarTodos();
        }
    }
}

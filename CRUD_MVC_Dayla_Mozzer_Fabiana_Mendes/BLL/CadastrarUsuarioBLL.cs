using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DAL;
using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.BLL
{
    class CadastrarUsuarioBLL
    {
        //O método de controle Cadrastarar Usuário deve validar os dados e chamar o metódo da DALL
        //que retorna um booleano a ser tratado

        public bool CadastrarUsuario(CadastrarUsuarioDTO usuario)
        {

            // Validações 

            // O método CadastrarUsuário da camada BLL deverá, após todas as validações de campos
            // e se tudo estiver ok com os dados recebidos cahmar o metódo de cadastrar usuário
            // CadrastrarUsuario() da camada DAL, para isso precisamos que existe um objeto de classse
            // CadrastrarUsuarioDAL que permita o acesso ao metódo.

            CadastrarUsuarioDAL cadUserDa1 = new CadastrarUsuarioDAL();

            // estando tudo ok com os dados do usuário podemos chamar o metódo que realiza
            // a gravação da camada DAL
            bool retorno = cadUserDa1.CadastrarUsuario(usuario);

            // A variavel de retorno do metódo CadrastrarUsuário() da camada DAL retorna verdadeiro se
            // conseguiu slavar e falso se não. portanto o controle também deve retornar esses valores
            // a quem o solicitar para que seja pos´sível controlar o que está sendo feito
            if (retorno) return true;

            return false; // retorna falso padrão
        }
    }
}

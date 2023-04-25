using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DAL;
using CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_MVC_Dayla_Mozzer_Fabiana_Mendes.BLL
{
    class LoginBLL
    {
        public bool GetLoginBLL(LoginDTO loginDTO)
        {
            //validar usuário
            LoginDAL login = new LoginDAL();
            bool retorno = login.GetLoginDAL(loginDTO);
            //se o retorno da DAL for verdadeiro retonar true 
            if (retorno)
            {
                return true;
            }

            return false;
        }
    }
}

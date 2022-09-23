using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEsig.DAO
{
    public class Nome
    {
        public static bool Recalcular(Models.Pessoa_salario salario)
        {
            try 
            {
                using (var conexao = new Models.ProjetoEsigprodEntities3())
               {
                conexao.Pessoa_salario.Add(salario);
                conexao.SaveChanges();
                return true;
               }
            }
            catch(Exception erro)
            {
                return false;
            }
        }
    }
}

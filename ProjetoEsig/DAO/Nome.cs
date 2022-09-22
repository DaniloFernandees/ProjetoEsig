using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoEsig.DAO
{
    public class Nome
    {
        public static bool Cadastrar(Models.Pessoa_salario pessoa_Salario)
        {
            try 
            {
                using (var conexao = new Models.ProjetoEsigprodEntities1())
               {
                conexao.Pessoa_salario.Add(pessoa_Salario);
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

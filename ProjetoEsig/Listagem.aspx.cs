using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoEsig
{
    public partial class Listagem : System.Web.UI.Page
    {
        protected override void OnInit(EventArgs e)
        {
            btnCadastrar.Click += BtnCadastrar_Click;
        }

        void BtnCadastrar_Click(object sender, EventArgs e)
        {
            var PessoaNova = new Models.Pessoa_salario();
            PessoaNova.ID = txtID.Text;
            PessoaNova.Nome = txtNome.Text;
            PessoaNova.Cargo_ID = txtCargo_ID.Text;

            bool cadastrado DAO.Nome.Cadastrar(PessoaNova);
            if (cadastrado) 
            {
                ltMensagem.Text = PessoaNova.Nome + "Foi cadastrado(a) com sucesso.";
            }
            else 
            {
                ltMensagem.Text = "Ocorreu um erro ao tentar cadastrar uma nova pessoa." + PessoaNova.Nome;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
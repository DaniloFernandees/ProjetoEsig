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
            btnRecalcular.Click += BtnRecalcular_Click;
        }

        private void BtnRecalcular_Click(object sender, EventArgs e)
        {
            var novoSalario = new Models.Pessoa_salario();
            novoSalario.Nome = txtNome.Text;
            novoSalario.Cargo_ID = txtCargo_ID.Text;

            bool calculado = DAO.Nome.Recalcular(novoSalario);
            if (calculado)
            {
                ltMensagem.Text = "O novo salário de " + novoSalario.Nome + " foi adicionado com sucesso.";
            }
            else
            {
                ltMensagem.Text = "Ocorreu um erro ao tentar adicionar o novo salário de "  + novoSalario.Nome + "!";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}
using GerenciadorEstoque.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorEstoque.Forms.Pedidos
{
    public partial class OrganizacaoPlanilhaPedidos : Form
    {
        bool liberado = false;
        DTOUsuarios usuarioLogado;

        public OrganizacaoPlanilhaPedidos(DTOUsuarios u)
        {
            usuarioLogado = u;

            InitializeComponent();
        }

        private void OrganizacaoPlanilhaPedidos_Load(object sender, EventArgs e)
        {
            CarregaDadosBase();
        }

        private void CarregaDadosBase()
        {
            CarregaUnidade();
        }

        private void CarregaUnidade()
        {
            BLLUnidade bllun = new BLLUnidade();

            cbUnidade.DataSource = bllun.Localizar();
            cbUnidade.DisplayMember = "nomeReduzido";
            cbUnidade.ValueMember = "id_unidade";
            cbUnidade.Text = "nomeReduzido";

            BLLPermissoes bllperm = new BLLPermissoes();
            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Pedidos, usuarioLogado) >= 2)
            {
                cbUnidade.Enabled = true;
            }
            else
            {
                cbUnidade.Enabled = false;
            }
        }


    }
}

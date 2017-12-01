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

namespace GerenciadorEstoque.Forms.Comuns
{
    public partial class FrmEmailSuporte : Form
    {
        DTOUsuarios usuarioConectado = new DTOUsuarios();

        public FrmEmailSuporte(DTOUsuarios u)
        {
            usuarioConectado = u;
            InitializeComponent();
        }

        private void FrmEmailSuporte_Load(object sender, EventArgs e)
        {

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtEnviar_Click(object sender, EventArgs e)
        {
            if(txtAssunto.Text.Trim() == "")
            {
                MessageBox.Show("O campo Assunto deve ser preenchido.");
            }
            else
            {
                if (TxtMensagem.Text.Trim() == "")
                {
                    MessageBox.Show("O campo Mensagem deve ser preenchido.");
                }
                else
                {
                    EnviaEmail es = new EnviaEmail();
                    es.EnviarEmailSUporte(usuarioConectado, txtAssunto.Text, TxtMensagem.Text);
                    this.Close();
                }
            }

            

        }
    }
}

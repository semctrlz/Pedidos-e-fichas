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

namespace GerenciadorEstoque.Forms.Usuarios
{
    public partial class FrmSenhaEmail : Form
    {
        public DTOUsuarios usuarioLogado;
        public bool alterado = false;        

        public FrmSenhaEmail(DTOUsuarios user)
        {
            InitializeComponent();

            usuarioLogado = user;
        }

        private void CbxExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxExibirSenha.Checked)
            {
                txtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtSenha.UseSystemPasswordChar = true;
            }
        }

        private void FrmSenhaEmail_Load(object sender, EventArgs e)
        {
            txtEmail.Text = usuarioLogado.Email;
            txtSenha.Text = usuarioLogado.SenhaEmail;
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text.Trim().Length == 0)
            {
                MessageBox.Show("O email deve ser preenchido.");
            }
            else if (txtSenha.Text.Trim().Length == 0)
            {
                MessageBox.Show("A senha deve ser preenchida.");
            }
            else
            {
                usuarioLogado.Email = txtEmail.Text.Trim();
                usuarioLogado.SenhaEmail = txtSenha.Text.Trim();

                BLLUSuarios BLLUsu = new BLLUSuarios();
                BLLUsu.Alterar(usuarioLogado, "");
                alterado = true;

                this.Close();

            }
        }
    }
}

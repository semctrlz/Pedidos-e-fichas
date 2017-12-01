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
    public partial class FrmAlterarSenha : Form
    {

    public DTOUsuarios usuarioLogado;
        bool recuperar = false;
        
        public FrmAlterarSenha(DTOUsuarios user, bool recuperacao)
        {
            InitializeComponent();
            recuperar = recuperacao;
            usuarioLogado = user;
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            Formatar fr = new Formatar();

            lbNome.Text = fr.PrimeirasLetrasMaiusculas(usuarioLogado.Nome, true);
            lbUsuario.Text = usuarioLogado.Usuario;

            if (recuperar)
            {
                txtSenhaAtual.Enabled = false;
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtAlterar_Click(object sender, EventArgs e)
        {
            if(txtSenhaAtual.Text != usuarioLogado.Senha && !recuperar)
            {
                MessageBox.Show("Senha atual incorreta.");
            }
            else if(txtNovaSenha.Text != txtRepetirSenha.Text)
            {
                MessageBox.Show("Os campos \"Nova\" senha e \"Repetir senha\" devem ser iguais.");
            }
            else
            {
                BLLUSuarios bllUsu = new BLLUSuarios();
                bllUsu.AlterarSenha(usuarioLogado, txtNovaSenha.Text);                               
                MessageBox.Show("Senha alterada com sucesso.");                
                usuarioLogado.Senha = txtNovaSenha.Text;
                BLLRecuperarSenha bllrs = new BLLRecuperarSenha();
                bllrs.Excluir(usuarioLogado.Id_usuario);
                this.Close();

            }
        }
    }
}

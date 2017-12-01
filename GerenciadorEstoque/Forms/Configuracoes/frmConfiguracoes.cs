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

namespace GerenciadorEstoque.Forms.Configuracoes
{
    public partial class FrmConfiguracoes : Form
    {

        Panel pnAtivo;
        
        public DTOUsuarios usuarioLogado;

        public FrmConfiguracoes(DTOUsuarios user)
        {
            InitializeComponent();

            usuarioLogado = user;
        }

        private void FrmConfiguracoes_Load(object sender, EventArgs e)
        {
            AtivarPannel();
        }

        private void AtivarPannel()
        {

            Point ativo = new Point(197, 12);
            Point Inativo = new Point(800, 12);

            pnServidoresEmail.Location = Inativo;
            pnDadosUsuario.Location = Inativo;

            if(pnAtivo != null)
            {
                pnAtivo.Location = ativo;
            }

        }

        private void LbServidorDeEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {            
            pnAtivo = pnServidoresEmail;

            Clear();

            AtivarPannel();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            BLLConfigEmail bllCE = new BLLConfigEmail();

            if (txtServidor.Text.Trim() == "")
            {
                MessageBox.Show("O servidor deve ser preenchido!");
            }
            else if (txtPorta.Text.Trim() == "")
            {
                MessageBox.Show("A Porta deve ser preenchida!");                
            }
            else
            {
                DTOConfigEmail DTOCE = new DTOConfigEmail()
                {
                    Porta = Convert.ToInt32(txtPorta.Text),
                    Smtp = txtServidor.Text,
                    Ssl = cbxSSL.Checked,
                    Usuarios_id_usuario = usuarioLogado.Id_usuario
                };

                if (bllCE.TemRegistro())
                {
                    bllCE.Alterar(DTOCE);
                }
                else
                {
                    bllCE.Incluir(DTOCE);
                }
            }
        }

        private void Clear()
        {
            BLLConfigEmail bllCE = new BLLConfigEmail();

            DTOConfigEmail dtoCE = new DTOConfigEmail();

            dtoCE = bllCE.CarregaModelo();

            txtPorta.Text = dtoCE.Porta.ToString();
            txtServidor.Text = dtoCE.Smtp;
            cbxSSL.Checked = dtoCE.Ssl;

        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtTestarConexao_Click(object sender, EventArgs e)
        {
            EnviaEmail EE = new EnviaEmail();

            //Verifica se o Usuario tem email e senha cadastrados
            if (usuarioLogado.Email.Length != 0 && usuarioLogado.SenhaEmail.Length != 0)
            {
                try
                {
                    EE.EnviarEmailPara(usuarioLogado, usuarioLogado.Email, "", "Teste de conexão do sistema de estoque.", "Parabéns, o sistema foi configurado corretamente.", true);
                }
                catch
                {
                    MessageBox.Show("Falha no envio!");
                }
            }
            else
            {
                Usuarios.FrmSenhaEmail se = new Usuarios.FrmSenhaEmail(usuarioLogado);
                se.ShowDialog();
                se.Dispose();

                try
                {
                    EE.EnviarEmailPara(usuarioLogado, usuarioLogado.Email, "", "Teste de conexão do sistema de estoque.", "Parabéns, o sistema foi configurado corretamente.", true);
                }
                catch
                {
                    MessageBox.Show("Falha no envio!");
                }

            }
        }

        private void LbDadosUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnAtivo = pnDadosUsuario;

            Clear();

            AtivarPannel();

            txtNome.Text = usuarioLogado.Nome;
            txtEmail.Text = usuarioLogado.Email;
            txtTelefone.Text = usuarioLogado.Telefone;

        }

        private void TxtNome_Enter(object sender, EventArgs e)
        {
            txtNome.SelectionStart = 0;
            txtNome.SelectionLength = txtNome.Text.Length;
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            txtEmail.SelectionStart = 0;
            txtEmail.SelectionLength = txtEmail.Text.Length;
        }

        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            txtTelefone.SelectionStart = 0;
            txtTelefone.SelectionLength = txtTelefone.Text.Length;
        }

        private void LbAlterarSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Usuarios.FrmAlterarSenha con = new Usuarios.FrmAlterarSenha(usuarioLogado, false);
            con.ShowDialog();
            con.Dispose();

            BLLUSuarios bllUsu = new BLLUSuarios();
            usuarioLogado = bllUsu.CarregaModeloUsuarios(usuarioLogado.Id_usuario);
        }

        private void BtSalvarUsuario_Click(object sender, EventArgs e)
        {
            usuarioLogado.Nome = txtNome.Text;
            usuarioLogado.Email = txtEmail.Text;
            usuarioLogado.Telefone = txtTelefone.Text;

            BLLUSuarios bllUsu = new BLLUSuarios();            
            bllUsu.Alterar(usuarioLogado, "");
            MessageBox.Show("Dados salvos com sucesso!");
            usuarioLogado = bllUsu.CarregaModeloUsuarios(usuarioLogado.Id_usuario);
            
        }
    }
}

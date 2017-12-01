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
    public partial class frmLogin : Form
    {
        public DTOUsuarios user = new DTOUsuarios();

        int id;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtLogin_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text.Trim() == "" || txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, preencha os campos usuário e senha para logar.", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DTOUsuarios dto = new DTOUsuarios();
                BLLUSuarios bll = new BLLUSuarios();

                
                user = bll.CarregaModeloUsuarios(txtUsuario.Text.ToUpper().Trim(), txtSenha.Text);

                if (user.Usuario == null)
                {
                    MessageBox.Show("Combinação de usuário e senha incorreta.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {

                        if (cbxPermanecerLogado.Checked)
                        {
                            BLLManterConectado bllMC = new BLLManterConectado();

                            DTOManterConectado dtoMC = new DTOManterConectado();

                            RecuperaDadosMaquina dados = new RecuperaDadosMaquina();

                            dtoMC.Ip = dados.RecuperarIp();
                            dtoMC.NomePC = dados.RecuperaNome();
                            dtoMC.Id_usuario = user.Id_usuario;
                            dtoMC.Umtima_conexao = DateTime.Now;

                            bllMC.Incluir(dtoMC);
                        }

                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Combinação de usuário e senha incorreta.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void LbEsqueceuASenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BLLUSuarios bll = new BLLUSuarios();

            id = bll.IdPorUser(txtUsuario.Text.ToUpper().Trim());
            
            if (id > 0)
            {
                pnEsqueciSenha.Visible = true;
            }
            else if(txtUsuario.Text.Trim() == "")
            {

                MessageBox.Show("Digite seu usuário para recuperar sua senha.");
            }
            else
            {
                MessageBox.Show("Usuário não encontrado, tente novamente.\nCaso o erro persista, contate o administrador do sistema.");
            }
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            pnEsqueciSenha.Visible = false;
        }

        private void BtEnvia_Click(object sender, EventArgs e)
        {
            BLLRecuperarSenha bll = new BLLRecuperarSenha();

            bll.Criar(id);
            MessageBox.Show("Uma senha com orientações para recuperar sua senha foi enviada para seu email. Verifique, favor.");

        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            BLLRecuperarSenha bll = new BLLRecuperarSenha();
            if (bll.VerificaCodigo(id, txtCod.Text.Trim()))
            {
                BLLUSuarios bllu = new BLLUSuarios();

                Usuarios.FrmAlterarSenha nsenha = new Usuarios.FrmAlterarSenha(bllu.CarregaModeloUsuarios(id), true);
                nsenha.ShowDialog();
                nsenha.Dispose();
                this.Close();

            }
            else
            {
                MessageBox.Show("Código digitado inválido. Verifique seu email para mais informações.");
            }
        }
    }




}

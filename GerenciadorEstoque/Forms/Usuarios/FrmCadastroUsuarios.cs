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
    public partial class FrmCadastroUsuarios : Form
    {
        DTOUsuarios usuarioLogado;
        int EditarUsuario = 0;
        EstadosJanela EstadoJanela = EstadosJanela.Inicial;
        DTOUsuarios EditandoUsuario = new DTOUsuarios();

        enum EstadosJanela { Inicial, Visualizar, Editar };

        public FrmCadastroUsuarios(DTOUsuarios dto)
        {
            InitializeComponent();
            usuarioLogado = dto;
        }

        private void FrmCadastroUsuarios_Load(object sender, EventArgs e)
        {
            AtualizaUnidades();
            AtualizaBotes();
            LimparJanela();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {

            DTOUsuarios dto = new DTOUsuarios();

            if(EditandoUsuario.Id_usuario > 0)
            {
            dto = EditandoUsuario;
            }

            dto.Nome = TxtNome.Text;
            dto.Usuario = TxtUsuario.Text;
            dto.IdUnidade = Convert.ToInt32(CbUnidade.SelectedValue.ToString());
            dto.Email = TxtEmail.Text;
            dto.Telefone = TxtTelefone.Text;
            dto.Ativo = CbxAtivo.Checked;
            

            BLLUSuarios bll = new BLLUSuarios();

            if (EditarUsuario == 0)
            {
                dto.Senha = CriaSenha();
                bll.Incluir(dto, "");                                

                DTOPermissao dtoperm = new DTOPermissao();
                BLLPermissoes bllperm = new BLLPermissoes();

                dtoperm.Id_usuarios = dto.Id_usuario;

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Fichas);
                dtoperm.Permissao = Convert.ToInt32(CbFichas.SelectedIndex.ToString());
                bllperm.Incluir(dtoperm);

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Pedidos);
                dtoperm.Permissao = Convert.ToInt32(CbCompras.SelectedIndex.ToString());
                bllperm.Incluir(dtoperm);

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Cadastros);
                dtoperm.Permissao = Convert.ToInt32(CbCadastro.SelectedIndex.ToString());
                bllperm.Incluir(dtoperm);

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Usarios);
                dtoperm.Permissao = Convert.ToInt32(CbUsuarios.SelectedIndex.ToString());
                bllperm.Incluir(dtoperm);


                MessageBox.Show($"Usuário {dto.Usuario.Trim().ToUpper()} criado com sucesso.\nSenha definida como {dto.Senha}.");
                EstadoJanela = EstadosJanela.Inicial;
                LimparJanela();
                AtualizaBotes();

            }
            else
            {
                dto.Id_usuario = EditandoUsuario.Id_usuario;                
                bll.Alterar(dto, "");

                DTOPermissao dtoperm = new DTOPermissao();
                BLLPermissoes bllperm = new BLLPermissoes();

                dtoperm.Id_usuarios = dto.Id_usuario;

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Fichas);
                dtoperm.Permissao = Convert.ToInt32(CbFichas.SelectedIndex.ToString());
                bllperm.Alterar(dtoperm);

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Pedidos);
                dtoperm.Permissao = Convert.ToInt32(CbCompras.SelectedIndex.ToString());
                bllperm.Alterar(dtoperm);

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Cadastros);
                dtoperm.Permissao = Convert.ToInt32(CbCadastro.SelectedIndex.ToString());
                bllperm.Alterar(dtoperm);

                dtoperm.LocalPermissao = Convert.ToInt32(Diversos.LocaisPermissoes.Usarios);
                dtoperm.Permissao = Convert.ToInt32(CbUsuarios.SelectedIndex.ToString());
                bllperm.Alterar(dtoperm);


                MessageBox.Show($"Usuário {dto.Usuario.Trim().ToUpper()} alterado com sucesso.");
                EstadoJanela = EstadosJanela.Inicial;
                LimparJanela();
                AtualizaBotes();
            }



        }

        private string CriaSenha()
        {
            return $"Dado@{DateTime.Now.Year.ToString()}";
        }

        private void BtBuscar_Click(object sender, EventArgs e)
        {
            FrmConsultaUsuarios frm = new FrmConsultaUsuarios();
            frm.ShowDialog();
            EditarUsuario = frm.idUsuario;
            frm.Dispose();

            if (EditarUsuario > 0)
            {
                CarregaUsuario();
            }
        }

        public class Language
        {
            public string NUnidade { get; set; }
            public string VUnidade { get; set; }
        }

        private void AtualizaUnidades()
        {
            var DSUnidade = new List<Language>();

            BLLUnidade bll = new BLLUnidade();
            DataTable TabelaUnidade = bll.Localizar();

            for (int i = 0; i < TabelaUnidade.Rows.Count; i++)
            {
                DSUnidade.Add(new Language() { NUnidade = TabelaUnidade.Rows[i][7].ToString(), VUnidade = TabelaUnidade.Rows[i][0].ToString() });
            }

            DTOUnidade dtoun = new DTOUnidade();
            BLLUnidade bllun = new BLLUnidade();

            //Adicionar ao ComboBox
            this.CbUnidade.DataSource = DSUnidade;
            this.CbUnidade.DisplayMember = "NUnidade";
            this.CbUnidade.ValueMember = "VUnidade";
            this.CbUnidade.SelectedIndex = 0;
        }

        private void AtualizaBotes()
        {
            GbDados.Enabled = true;
            GbAcessos.Enabled = true;
            BtCancelar.Enabled = true;
            BtSalvar.Enabled = true;
            BtEditar.Enabled = true;
            BtExcluir.Enabled = true;

            if (EstadoJanela == EstadosJanela.Inicial)
            {
                BtEditar.Enabled = false;
                BtExcluir.Enabled = false;
            }
            else if (EstadoJanela == EstadosJanela.Editar)
            {
                BtEditar.Enabled = false;
                BtExcluir.Enabled = false;
                BtExcluir.Enabled = true;
            }
            else
            {
                GbAcessos.Enabled = false;
                GbDados.Enabled = false;
                BtEditar.Enabled = true;
                BtExcluir.Enabled = true;
            }
        }

        private void CarregaUsuario()
        {           
            DTOUnidade dtoun = new DTOUnidade();
            BLLUSuarios bll = new BLLUSuarios();
            BLLUnidade bllun = new BLLUnidade();

            EditandoUsuario = bll.CarregaModeloUsuarios(EditarUsuario);
            dtoun = bllun.CarregaModelo(EditandoUsuario.IdUnidade);

            TxtNome.Text = EditandoUsuario.Nome;
            TxtUsuario.Text = EditandoUsuario.Usuario;
            CbUnidade.Text = dtoun.NomeReduzido;
            TxtEmail.Text = EditandoUsuario.Email;
            TxtTelefone.Text = EditandoUsuario.Telefone;
            CbxAtivo.Checked = EditandoUsuario.Ativo;            

            BLLPermissoes bllperm = new BLLPermissoes();
            CbCompras.SelectedIndex = bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Pedidos, EditandoUsuario);
            CbUsuarios.SelectedIndex = bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Usarios, EditandoUsuario);
            CbCadastro.SelectedIndex = bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Cadastros, EditandoUsuario);
            CbFichas.SelectedIndex = bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Fichas, EditandoUsuario);

            EstadoJanela = EstadosJanela.Visualizar;

            AtualizaBotes();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            EstadoJanela = EstadosJanela.Editar;
            AtualizaBotes();
        }

        private void LimparJanela()
        {
            TxtNome.Clear();
            TxtUsuario.Clear();
            CbUnidade.SelectedIndex = 0;
            TxtEmail.Clear();
            TxtTelefone.Clear();
            CbxAtivo.Checked = true;
            CbCompras.SelectedIndex = 0;
            CbUsuarios.SelectedIndex = 0;
            CbCadastro.SelectedIndex = 0;
            CbFichas.SelectedIndex = 0;
            EditandoUsuario = new DTOUsuarios();
            EditarUsuario = 0;

        }

        private void BtExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show($"Você deseja mesmo excluir o usuário {TxtUsuario.Text}?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                BLLUSuarios bll = new BLLUSuarios();
                BLLPermissoes bllperm = new BLLPermissoes();
                try
                {
                    //Tenta excluir usuário
                    bll.Excluir(EditarUsuario);
                    bllperm.Excluir(EditarUsuario);
                }
                catch
                {                    
                    bll.DesativarUsuario(EditarUsuario);
                }

                LimparJanela();
                EstadoJanela = EstadosJanela.Inicial;
                AtualizaBotes();

            }
        }
                
    }
}

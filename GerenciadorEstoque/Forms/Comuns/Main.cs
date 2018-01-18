using System;
using System.Data;
using System.Windows.Forms;
using GerenciadorEstoque.Code;
using System.Data.SqlClient;
using System.Xml;
using System.Diagnostics;
using System.Reflection;
using System.IO;

namespace GerenciadorEstoque.Forms
{
    public partial class Main : Form
    {
        DTOUsuarios usuarioLogado = new DTOUsuarios();

        DTOManterConectado dtoMC = new DTOManterConectado();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            ChecaUsuario();
            VerificaXMV();            
        }

        private bool TestaConexao()
        {
            bool result = false;

            DTOOutros dto = new DTOOutros();
            
            SqlConnection con = new SqlConnection()
            {
                ConnectionString = $"Data Source={dto.DC()[0]};Initial Catalog={dto.DC()[1]};Persist Security Info=True;User ID={dto.DC()[2]};Password={dto.DC()[3]}"
            };

            try
            {
                con.Open();

                if (con.State == ConnectionState.Open)
                {
                    result = true;
                    con.Close();
                }
                else
                {
                result = false;
                }
            }
            catch
            {
            }

            return result;
        }
        
        void ChecaUsuario()
        {
            if (!TestaConexao())
            {

                bool sucesso = false;
                Conexoes.FrmConfigDBConection frmcon = new Conexoes.FrmConfigDBConection();
                frmcon.ShowDialog();
                sucesso = frmcon.sucesso;
                frmcon.Dispose();
                if (!sucesso)
                {
                    this.Close();
                }

            }

            if (String.IsNullOrEmpty(usuarioLogado.Usuario))
            {
                BLLManterConectado bllMC = new BLLManterConectado();

                RecuperaDadosMaquina dados = new RecuperaDadosMaquina();

                dtoMC =  bllMC.CarregaModeloConexao(dados.RecuperarIp());

                if (!String.IsNullOrEmpty(dtoMC.Ip))
                {
                    BLLUSuarios bllUsu = new BLLUSuarios();
                    usuarioLogado = bllUsu.CarregaModeloUsuarios(dtoMC.Id_usuario);
                    dtoMC = bllMC.CarregaModeloConexao(dados.RecuperarIp());
                    bllMC.AtualizarData();

                    Logar();
                }
                else
                {
                    Comuns.frmLogin login = new Comuns.frmLogin();
                    login.ShowDialog();
                    usuarioLogado = login.user;
                    login.Dispose();

                    dtoMC = bllMC.CarregaModeloConexao(dados.RecuperarIp());


                    if (String.IsNullOrEmpty(usuarioLogado.Usuario))
                    {
                        this.Close();
                    }
                    else
                    {
                        Logar();

                    }
                }
            }
        }

        void ChecaConexao()
        {

        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logar()
        {
            Formatar form = new Formatar();
            username.Text = form.PrimeirasLetrasMaiusculas(usuarioLogado.Nome.Trim().ToUpper(), true);
            RecuperaDadosMaquina dados = new RecuperaDadosMaquina();

            BLLRecuperarSenha bllrs = new BLLRecuperarSenha();
            bllrs.Excluir(usuarioLogado.Id_usuario);

            lbPCNome.Text = dados.RecuperaNome();

            BloqueiaItens();

        }

        void BloqueiaItens()
        {
            BLLPermissoes bllperm = new BLLPermissoes();

            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Usarios, usuarioLogado) < 4)
            {
                ferramentasToolStripMenuItem.Enabled = false;
                usuariosToolStripMenuItem.Enabled = false;
            }
        }

        private void LogoffToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dtoMC.Ip))
            {
                BLLManterConectado bllMC = new BLLManterConectado();
                bllMC.Excluir(dtoMC.Id_conexao);
            }
                this.Close();
            
        }

        private void LoginsAutomáticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Conexoes.frmConexoesAtuais con = new Conexoes.frmConexoesAtuais(usuarioLogado);
            con.ShowDialog();
            con.Dispose();
        }        

        private void AlterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios.FrmAlterarSenha con = new Usuarios.FrmAlterarSenha(usuarioLogado, false);
            con.ShowDialog();
            con.Dispose();

            BLLUSuarios bllUsu = new BLLUSuarios();
            usuarioLogado = bllUsu.CarregaModeloUsuarios(usuarioLogado.Id_usuario);

        }

        private void ConfiguraçõesGeraisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracoes.FrmConfiguracoes config = new Configuracoes.FrmConfiguracoes(usuarioLogado);
            config.ShowDialog();
            config.Dispose();

            BLLUSuarios bllUsu = new BLLUSuarios();
            usuarioLogado = bllUsu.CarregaModeloUsuarios(usuarioLogado.Id_usuario);            
            Logar();
        }

        private void InserirDadosEmLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLargeData frm = new AddLargeData();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void AprovarMarcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresas.FrmCadastroProdutos frm = new Empresas.FrmCadastroProdutos(usuarioLogado);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void CriarFichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLPermissoes bllperm = new BLLPermissoes();
            if(bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Fichas, usuarioLogado)>=2)
            {
            Fichas.frmCadastroFichas frm = new Fichas.frmCadastroFichas(usuarioLogado);            
            frm.ShowDialog();
            frm.Dispose();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para criar fichas técnicas\nPor favor, contate o administrador do sistema.!", "Aviso");
            }

        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLPermissoes bllperm = new BLLPermissoes();
            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Usarios, usuarioLogado) >= 3)
            {
                Usuarios.FrmCadastroUsuarios frm = new Usuarios.FrmCadastroUsuarios(usuarioLogado);
                frm.ShowDialog();
                frm.Dispose();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para criar usuários.\nPor favor, contate o administrador do sistema.!", "Aviso");
            }
        }

        private void AdicionarMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLPermissoes bllperm = new BLLPermissoes();
            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Cadastros, usuarioLogado) >= 3)
            {
                Empresas.FrmAdicionarMovimentos frm = new Empresas.FrmAdicionarMovimentos(usuarioLogado);
                frm.ShowDialog();
                frm.Dispose();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para criar movimentos.\nPor favor, contate o administrador do sistema.!", "Aviso");
            }
        }

        private void SuporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Comuns.FrmEmailSuporte frm = new Comuns.FrmEmailSuporte(usuarioLogado);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void ConsultarFichasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLPermissoes bllperm = new BLLPermissoes();
            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Fichas, usuarioLogado) >= 1)
            {
                Fichas.FrmConsultaFichas frm = new Fichas.FrmConsultaFichas(usuarioLogado, false);
                frm.ShowDialog();
                frm.Dispose();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para visualizar as fichas técnicas.\nPor favor, contate o administrador do sistema.!", "Aviso");
            }
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool update;

            Comuns.FrmInfo frm = new Comuns.FrmInfo();
            frm.ShowDialog();
            update = frm.atualizar;
            frm.Dispose();

            if (update)
            {
                try
                {
                    this.Location.ToString();
                    string local;
                    local = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                                        

                    Process.Start(local+"\\AssistenteAtualizacao.exe");

                    this.Close();
                    

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred!!!: " + ex.Message);
                    return;
                }
            }
        }

        private void BackupDoBancoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ferramentas.FrmBackupDatabase frm = new Ferramentas.FrmBackupDatabase();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void VerificaXMV()
        {
   
        }

        private void CotaçoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLPermissoes bllperm = new BLLPermissoes();
            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Pedidos, usuarioLogado) >= 3)
            {
                Pedidos.FrmCotacoesFruteiras frm = new Pedidos.FrmCotacoesFruteiras(usuarioLogado);
                frm.ShowDialog();
                frm.Dispose();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para realizar cotações da fruteira.\nPor favor, contate o administrador do sistema.!", "Aviso");
            }
        }

        private void ConsultaItensBaseDerivadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empresas.FrmConsultaMateriaisEDerivados frm = new Empresas.FrmConsultaMateriaisEDerivados();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string mensagem = "<table width = \"100%\"  border = \"0\" cellspacing = \"0\" cellpadding = \"0\"> " +
            " <tr> <td align = \"center\" valign = \"middle\" height = \"60\" style = \"background-color:#ff6c00;\" bgcolor = \"#ff6c00;\" > <font face = \"Segoe UI\"> <h1>OI</h1> </font></td></tr></table> ";
             

            EnviaEmail ee = new EnviaEmail();
            ee.EnviarEmailPara(usuarioLogado, "vagner.lenon@dadobier.com.br", "", "Teste", mensagem, true);
        }

        private void CotaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos.FrmPedidos frm = new Pedidos.FrmPedidos(usuarioLogado);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void criarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos.FrmPedido f = new Pedidos.FrmPedido(usuarioLogado);
            f.ShowDialog();
            f.Dispose();
        }

        private void CadastrarEmLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmCadastraProdutosEmLote f = new Produtos.FrmCadastraProdutosEmLote(usuarioLogado);
            f.ShowDialog();
            f.Dispose();
            
        }

        private void organizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pedidos.OrganizacaoPlanilhaPedidos f = new Pedidos.OrganizacaoPlanilhaPedidos(usuarioLogado);
            f.ShowDialog();
            f.Dispose();
        }

        private void cadastrarValorExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmValorExterno f = new Produtos.FrmValorExterno(usuarioLogado);
            f.ShowDialog();
            f.Dispose();
        }

        private void EspecializaçãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.FrmEspecializacaoMateriais f = new Produtos.FrmEspecializacaoMateriais(usuarioLogado);
            f.ShowDialog();
            f.Dispose();
        }

        private void criarLevantamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLLPermissoes bllperm = new BLLPermissoes();
            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Pedidos, usuarioLogado) >= 3)
            {
                Pedidos.FrmLevantamento frm = new Pedidos.FrmLevantamento(usuarioLogado);
                frm.ShowDialog();
                frm.Dispose();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para realizar levantamentos.\nPor favor, contate o administrador do sistema.!", "Aviso");
            }
        }
    }
}

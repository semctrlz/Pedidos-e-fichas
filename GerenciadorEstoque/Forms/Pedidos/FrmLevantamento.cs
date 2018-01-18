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
    public partial class FrmLevantamento : Form
    {

        bool liberado = false;
        DTOUsuarios usuarioLogado;
        int unidade;
        StatusJanela Status;

        public enum StatusJanela {inicial, criacao };

        public FrmLevantamento(DTOUsuarios u)
        {
            usuarioLogado = u;
            InitializeComponent();
        }

        private void FrmLevantamento_Load(object sender, EventArgs e)
        {
            Status = StatusJanela.inicial;
            CarregaPagina();
            TxtObs.Focus();

            

            PnItensDerivadosV(false);

            liberado = true;
        }

        private void CarregaPagina()
        {
            CarregaUnidades();

            //AtualizaBotoes();
        }

        private void AtualizaLv()
        {
            LvMatDer.Items.Clear();
            
            
            LvMatDer.Items.Add("Teste 01");
            LvMatDer.Items.Add("Teste 02");
            LvMatDer.Items.Add("Teste 03");
        }

        private void PnItensDerivadosV(bool visivel)
        {
            if (visivel)
            {
                PnItensDerivados.Location = new Point(9, 59);
                PnItensDerivados.Visible = true;
            }
            else
            {
                PnItensDerivados.Location = new Point(576, 59);
                PnItensDerivados.Visible = false;
            }
        }

        private void AtualizaBotoes()
        {
            GbBase.Enabled = false;
            GbItens.Enabled = false;

            if(Status == StatusJanela.inicial)
            {
                GbBase.Enabled = true;
            }
            else
            {
                GbItens.Enabled = false;
            }



        }

        private void CarregaUnidades()
        {
            BLLUnidade bllun = new BLLUnidade();

            cbUnidade.DataSource = bllun.Localizar();
            cbUnidade.DisplayMember = "nomeReduzido";
            cbUnidade.ValueMember = "id_unidade";
            cbUnidade.Text = "nomeReduzido";


            BLLPermissoes bllperm = new BLLPermissoes();

            if (bllperm.PermissaoPorLocal(Diversos.LocaisPermissoes.Usarios, usuarioLogado) >= 4)
            {
                cbUnidade.Enabled = true;
            }

            else
            {
                cbUnidade.Enabled = false;
            }

            unidade = Convert.ToInt32(cbUnidade.SelectedValue);
        }

        private void TxtCodItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                DTOMateriais dto = new DTOMateriais();

                Empresas.FrmConsultaItens f = new Empresas.FrmConsultaItens(true);
                f.ShowDialog();
                dto = f.material;
                f.Dispose();

                if (dto.CodigoCigam != null)
                {
                    try
                    {
                        txtCodItem.Text = dto.CodigoCigam.ToString();
                        txtNomeItem.Text = dto.Descricao.ToString();                        
                        CbUm.Text = dto.Um.ToString();
                        txtQuant.Enabled = true;
                        BtAddItem.Enabled = true;

                        txtQuant.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Código inválido. Por favor selecione um código existente");
                        BtAddItem.Enabled = false;
                        txtQuant.Enabled = false;
                    }
                }
                else
                {

                }

            }
        }

        private void BtCriar_Click(object sender, EventArgs e)
        {
            Status = StatusJanela.criacao;
            DTOLevantamentos dto = new DTOLevantamentos();
            BLLLevantamentos bll = new BLLLevantamentos();

            dto.IdUsuario = usuarioLogado.Id_usuario;
            dto.Id_unidade = Convert.ToInt32(cbUnidade.SelectedValue);
            dto.Obs = TxtObs.Text;


            bll.Incluir(dto);
            TxtNumeroLevantamento.Text = dto.Id.ToString("000000");
            


            AtualizaBotoes();

            txtCodItem.Focus();
        }
    }
}
